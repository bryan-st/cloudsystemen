import React, { useState, useEffect } from "react";
import { Page } from "../models/Page";
import { Brand } from "../models/Brands/Brand";
import { Modal } from "react-bootstrap";

export interface DataContextProps {
    id: number;
    main: string;
    page: Page | undefined;
    currentPage: number;
    searchTerm: string;
    setSearchTerm: (term: string) => void;
    setCurrentPage: (page: number) => void;
    fetchPage: () => void;
    fetchBrands: (name: string) => void;
    Brands: Brand[];
    setBrands: (brands: Brand[]) => void;
    fetchCompetitorBrands: (name: string) => void;
    competitorBrands: Brand[];
    darkMode: boolean;
    sendMessage: (title: string, message: string) => void;
}

export const DataContext = React.createContext<DataContextProps>({
    id: 1,
    main: "",
    page: undefined,
    currentPage: 1,
    searchTerm: "",
    setSearchTerm: () => { },
    setCurrentPage: () => { },
    fetchPage: () => { },
    fetchBrands: () => { },
    Brands: [],
    setBrands: () => { },
    fetchCompetitorBrands: () => { },
    competitorBrands: [],
    darkMode: true,
    sendMessage: () => { }
});

export const DataProvider = ({ children }: { children: React.ReactNode }) => {
    const [searchTerm, setSearchTerm] = useState<string>(() => {
        const storageSearchTerm = localStorage.getItem("searchTermHome");
        return storageSearchTerm !== null ? storageSearchTerm : "";
    });

    const [currentPage, setCurrentPage] = useState<number>(() => {
        const storageCurrentPage = localStorage.getItem("currentPage")
        return !Number.isNaN(Number(storageCurrentPage)) && Number(storageCurrentPage) > 0 ? Number(storageCurrentPage) : 1;
    });

    const [page, setPage] = useState<Page>(() => {
        const storagePage = localStorage.getItem("page");
        if (storagePage) {
            let page: Page = JSON.parse(storagePage);
            page.pages = 1;
            return page;
        } else {
            return {
                klanten: [],
                pages: 1
            };
        }
    });

    const [brands, setBrands] = useState<Brand[]>([]);
    const [competitorBrands, setCompetitorBrands] = useState<Brand[]>([]);
    const [darkMode, setDarkMode] = useState<boolean>(() => {
        const storageDarkMode = localStorage.getItem('darkMode');
        return Boolean(storageDarkMode !== null ? storageDarkMode : window.matchMedia('(prefers-color-scheme: dark)').matches);
    });

    const [showMessage, setShowMessage] = useState<boolean>(false);
    const [titleMessage, setTitelMessage] = useState<string>("");
    const [message, setMessage] = useState<string>("");
    const sendMessage = (title: string, message: string) => {
        setTitelMessage(title);
        setMessage(message);
        setShowMessage(true);
    }

    useEffect(() => {
        localStorage.setItem("searchTermHome", searchTerm);
    }, [searchTerm]);

    useEffect(() => {
        localStorage.setItem("currentPage", String(currentPage));
    }, [currentPage]);

    useEffect(() => {
        localStorage.setItem("page", JSON.stringify(page));
    }, [page]);

    useEffect(() => {
        const html = document.querySelector("html");
        html && html.setAttribute("data-bs-theme", darkMode ? "dark" : "light");
        localStorage.setItem("darkMode", String(darkMode));
    }, [darkMode]);

    const getApiUrl = () => {
        const url = import.meta.env.VITE_APP_API_URL;
        if (!url) {
            throw new Error("API URL is not defined. Please set VITE_APP_API_URL in your environment.");
        }
        return url;
    };

    const apiUrl = getApiUrl();

    const fetchPage = async () => {
        if (searchTerm.length > 0) {
            try {
                const response = await fetch(`${apiUrl}/Klanten/${searchTerm}/${currentPage}`, {
                    headers: {
                        "ngrok-skip-browser-warning": "true", // Bypass ngrok warning
                    },
                });

                if (response.status === 404) {
                    sendMessage("Klanten search", `${searchTerm} niet gevonden`);
                    return;
                }

                if (!response.ok) {
                    throw new Error(`HTTP error! status: ${response.status}`);
                }

                const json = await response.json();
                setPage(json);
            } catch (err) {
                console.error('Fetch error:', err);
                sendMessage("Klanten search", 'Er is een fout opgetreden bij het ophalen van de gegevens.');
            }
        }
    };

    const fetchBrands = async (name: string) => {
        try {
            const response = await fetch(`${apiUrl}/Brands/fc70/${name}`, {
                headers: {
                    "ngrok-skip-browser-warning": "true", // Bypass ngrok warning
                },
            });

            if (response.status === 404) {
                sendMessage("Brands search", `brand ${name} niet gevonden`);
                return;
            }

            if (!response.ok) {
                throw new Error(`HTTP error! status: ${response.status}`);
            }

            const json = await response.json();
            setBrands(json);
        } catch (err) {
            console.error('Fetch error:', err);
            sendMessage("Brands search", 'Er is een fout opgetreden bij het ophalen van de gegevens.');
        }
    };

    const fetchCompetitorBrands = async (name: string) => {
        try {
            const response = await fetch(`${apiUrl}/Brands/competitorbrands/${name}`, {
                headers: {
                    "ngrok-skip-browser-warning": "true", // Bypass ngrok warning
                },
            });

            if (response.status === 404) {
                sendMessage("Competitor brands search", `competitor brand ${name} niet gevonden`);
                return;
            }

            if (!response.ok) {
                throw new Error(`HTTP error! status: ${response.status}`);
            }

            const json = await response.json();
            setCompetitorBrands(json);
        } catch (err) {
            console.error('Fetch error:', err);
            sendMessage("Competitor brands search", 'Er is een fout opgetreden bij het ophalen van de gegevens.');
        }
    };

    useEffect(() => {
        fetchPage();
    }, [currentPage]);

    return (
        <DataContext.Provider value={
            {
                id: 1,
                main: "",
                page: page,
                currentPage: currentPage,
                searchTerm: searchTerm,
                setSearchTerm: setSearchTerm,
                setCurrentPage: (page: number) => { if (searchTerm.length > 0) setCurrentPage(page) },
                fetchPage: fetchPage,
                fetchBrands: fetchBrands,
                Brands: brands,
                setBrands: setBrands,
                fetchCompetitorBrands: fetchCompetitorBrands,
                competitorBrands: competitorBrands,
                darkMode: darkMode,
                sendMessage: sendMessage
            }}>
            {children}
            <Modal show={showMessage} onHide={() => setShowMessage(false)}>
                <Modal.Header closeButton>
                    <Modal.Title>{titleMessage}</Modal.Title>
                </Modal.Header>
                <Modal.Body>{message}</Modal.Body>
                <Modal.Footer>
                    <button className="btn btn-primary" onClick={() => setShowMessage(false)}>
                        Close
                    </button>
                </Modal.Footer>
            </Modal>
            <button onClick={() => setDarkMode(!darkMode)} className={`position-fixed bottom-0 end-0 mb-3 me-3 btn btn-${darkMode ? "light" : "dark"}`}>{darkMode ? "Dark" : "Light"}</button>
        </DataContext.Provider>
    );
};
