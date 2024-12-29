import { Container, Form, Button, Table, InputGroup, Col, Row, Dropdown } from "react-bootstrap";
import { Klant } from "../../../models/Enterprise/Klant";
import { useContext, useEffect, useState } from "react";
import { DataContext } from "../../../contexts/dataContext";
import { Brand } from "../../../models/Brands/Brand";
import 'bootstrap-icons/font/bootstrap-icons.css';
import { useReportContext } from "../../../contexts/reportContext";
import PageFooterNavigation from "../../Shared/PageFooterNavigation";

export interface StoreBrandmixProps {
    store: Klant
    onSafeAndForward: () => void;
    onBackwards: () => void;
}

const StoreBrandmix = ({ store, onSafeAndForward: onSaveAndMoveToNext, onBackwards}: StoreBrandmixProps) => {
    const {
        fetchBrands,
        Brands,
        fetchCompetitorBrands,
        competitorBrands,
        sendMessage
    } = useContext(DataContext);

    const { report, setBrandMixOverview, getCurrentReport } = useReportContext();

    // FC70 brands
    // -----------
    
    const [showSearch, setShowSearch] = useState<boolean>(() => {
        const storageShowSearch = localStorage.getItem("showSearch");
        return storageShowSearch === "true";
    });

    const [showSearchResults, setShowSearchResults] = useState<boolean>(() => {
        const storageShowSearchResults = localStorage.getItem("showSearchResults");
        return storageShowSearchResults === "true";
    });

    const [searchTermBrands, setSearchTermBrands] = useState<string>(() => {
        const storageSearchTermBrands = localStorage.getItem("searchTermBrands");
        return String(storageSearchTermBrands ? storageSearchTermBrands : "");
    });

    const [selectedBrands, setSelectedBrands] = useState<Brand[]>(() =>{
        const currentReportBrands = getCurrentReport()?.brandMixOverview?.brands || [];
    return currentReportBrands.length === 0 
        ? report?.brandMixOverview?.brands || [] 
        : currentReportBrands;
    });

    useEffect(() => {
        localStorage.setItem("showSearch", String(showSearch));
    }, [showSearch]);

    useEffect(() => {
        localStorage.setItem("showSearchResults", String(showSearchResults));
    }, [showSearchResults]);

    useEffect(() => {
        localStorage.setItem("searchTermBrands", searchTermBrands);
    }, [searchTermBrands]);

    const handleSearch = async (e: React.FormEvent) => {
        e.preventDefault();
        setShowSearch(true);
        if (searchTermBrands.length >= 1) {
            await fetchBrands(searchTermBrands);
        } else {
            localStorage.removeItem("searchTermBrands");
            sendMessage("Brandmix search", "Voer minstens 3 karakters in.")
        }
    };

    const handleAddBrand = (brand: Brand) => {
        setSelectedBrands(prevSelectedBrands => {
            if (!prevSelectedBrands.some(b => b.id === brand.id)) {
                return [...prevSelectedBrands, brand];
            }
            return prevSelectedBrands;
        });
    };

    const handleRemoveBrand = (brandId: number) => {
        setSelectedBrands(selectedBrands.filter(brand => brand.id !== brandId));
    };



    // Competitor brands
    // -----------------
    const [showSearchComp, setShowSearchComp] = useState<boolean>(() => {
        const storageShowSearchComp = localStorage.getItem("showSearchComp");
        return storageShowSearchComp === "true";
    });

    const [showSearchResultsComp, setShowSearchResultsComp] = useState<boolean>(() => {
        const storageShowSearchResultsComp = localStorage.getItem("showSearchResultsComp");
        return storageShowSearchResultsComp === "true";
    });

    const [searchTermBrandsComp, setSearchTermBrandsComp] = useState<string>(() => {
        const storageSearchTermBrandsComp = localStorage.getItem("searchTermBrandsComp");
        return String(storageSearchTermBrandsComp ? storageSearchTermBrandsComp : "");
    });

    const [selectedBrandsComp, setSelectedBrandsComp] = useState<Brand[]>(() => {
        const currentReportBrands = getCurrentReport()?.brandMixOverview?.competitorBrands || [];
        return currentReportBrands.length === 0 
            ? report?.brandMixOverview?.competitorBrands || [] 
            : currentReportBrands;
        });

    const [errorComp, setErrorComp] = useState<string | null>(null);

    useEffect(() => {
        localStorage.setItem("showSearchComp", String(showSearchComp));
    }, [showSearchComp]);

    useEffect(() => {
        localStorage.setItem("showSearchResultsComp", String(showSearchResultsComp));
    }, [showSearchResultsComp]);

    useEffect(() => {
        localStorage.setItem("searchTermBrandsComp", searchTermBrandsComp);
    }, [searchTermBrandsComp]);

    const handleSearchComp = async (e: React.FormEvent) => {
        e.preventDefault();
        setShowSearchComp(true);
        if (searchTermBrandsComp.length >= 3) {
            await fetchCompetitorBrands(searchTermBrandsComp);
        } else {
            localStorage.removeItem("searchTermBrandsComp");
            setErrorComp("Voer minstens 3 karakters in.")
        }
    };

    const handleAddBrandComp = (brandComp: Brand) => {
        setSelectedBrandsComp(prevSelectedBrands => {
            if (!prevSelectedBrands.some(b => b.id === brandComp.id)) {
                return [...prevSelectedBrands, brandComp];
            }
            return prevSelectedBrands;
        });
    };

    const handleRemoveBrandComp = (brandIdComp: number) => {
        setSelectedBrandsComp(selectedBrandsComp.filter(brandComp => brandComp.id !== brandIdComp));
    };



    // test (Ik heb voorlopig alles met "tmp" benoemd)
    // ----
    // Problem: Test werkt enkel wanneer er eerst een zoekopdracht gedaan wordt in het "FC70 brands" gedeelte. Vervolgens werkt het gedeelte "Test" wel zoals verwacht.
    // Dit komt omdat er dan eerst een fetchBrands() gedaan wordt en de Brands array gevuld is. Als er geen fetchBrands() ALS EERSTE gedaan wordt,
    // is de Brands array leeg en werkt de zoekfunctie niet.
    // Wanneer ik fetchBrands() in een useEffect() steek of ik voeg deze toe in handleSearchTmp, duiken er steeds bugs op
    const [tmp, setTmp] = useState<string>("");
    const [bestBrands, setBestBrands] = useState<string[]>([]);
    const [filteredBrands, setFilteredBrands] = useState<Brand[]>([]);
    const [tmpError, setTmpError] = useState<string>("");

    const handleRemoveTmp = (index: number) => {
        const updatedBrands = bestBrands.filter((_, i) => i !== index);
        setTmpError("");
        setBestBrands(updatedBrands);
    };

    // useEffect(() => {
    //     fetchBrands("");
    // }, []);
    const url = import.meta.env.VITE_APP_API_URL;
    useEffect(() => {
        if (/^[A-Za-z]*$/.test(tmp)) {
            if (tmp)
                fetch(`${url}/Brands/fc70/${tmp}`)
                    .then(responce => responce.json())
                    .then(json => setFilteredBrands(json));
        } else {
            setTmpError("Input may only contain letters.");
        }
    }, [tmp]);

    const handleSelect = (brand: string) => {
        setTmp(brand);
        setFilteredBrands([]);
    };

    const handleBlur = () => {
        setTimeout(() => setFilteredBrands([]), 200); // Timeout voorkomt direct sluiten bij klikken
    };

    const handleSave = () => {
        setBrandMixOverview(
            {
                brands: selectedBrands,
                competitorBrands: selectedBrandsComp,
                brandsOverviews: []
            }
        );
        onSaveAndMoveToNext();
    }

    return (
        <>
            <Container className="py-5" style={{ maxWidth: "600px" }}>
                <div className="d-flex justify-content-between align-items-center mb-4">
                    <h1 className="text-center mb-0">{store.name}</h1>
                </div>
                <h2 className="mb-3 mt-4">Brandmix</h2>
                <Form>
                    {/* Zoekfunctie test */}
                    <h4 className="mt-3">Test</h4>
                    {bestBrands.map((brand, index) => (
                        <Row className="mb-3" key={index}>
                            <Col xs={10}>
                                <Form.Control type="text" value={brand} disabled className="h-100" />
                            </Col>
                            <Col xs={2} className="text-end">
                                <Button
                                    variant="danger"
                                    className="w-100 h-100 d-flex justify-content-center align-items-center"
                                    onClick={() => handleRemoveTmp(index)}
                                >
                                    &times;
                                </Button>
                            </Col>
                        </Row>
                    ))}
                    <Row className="mt-3">
                        {tmpError && <p className="text-danger mb-4">{tmpError}</p>}
                        <Col xs={10} style={{ position: 'relative' }}>
                            <Form.Control
                                type="text"
                                placeholder="Nieuw merk toevoegen"
                                value={tmp}
                                onChange={(e) => setTmp(e.target.value)}
                                onBlur={handleBlur}
                                className="h-100"
                            />
                            <i className="bi bi-search" style={{ position: 'absolute', right: '25px', top: '50%', transform: 'translateY(-50%)' }}></i>
                            {filteredBrands.length > 0 && (
                                <Dropdown.Menu show style={{ width: '95%' }}>
                                    {filteredBrands.map((brand, index) => (
                                        <Dropdown.Item key={index} onClick={() => handleSelect(brand.name)}>
                                            {brand.name}
                                        </Dropdown.Item>
                                    ))}
                                </Dropdown.Menu>
                            )}
                        </Col>

                        <Col xs={2} className="text-end">
                            <Button
                                className="w-100 h-100 d-flex justify-content-center align-items-center"
                                onClick={() => {
                                    setBestBrands([...bestBrands, tmp]);
                                    setTmp("");
                                }}
                            >
                                +
                            </Button>
                        </Col>
                    </Row>
                </Form>
                {/* </Container>
        </> */}

                {/* FC70 brands */}
                <h4 className="mt-5">FC70 brands</h4>
                <Table striped>
                    <thead>
                        <tr className="border-bottom border-dark">
                            <th>#</th>
                            <th>Brand Name</th>
                        </tr>
                    </thead>
                    <tbody>
                        {selectedBrands.length === 0 ? (
                            <tr>
                                <td colSpan={3} className="text-center">(leeg)</td>
                            </tr>
                        ) : (
                            selectedBrands.map((brand: Brand) => (
                                <tr key={brand.id}>
                                    <td>{brand.id}</td>
                                    <td>{brand.name}</td>
                                    <td className="text-end">
                                        <Button onClick={() => handleRemoveBrand(brand.id)}>Verwijderen</Button>
                                    </td>
                                </tr>
                            ))
                        )}
                    </tbody>
                </Table>

                <Button onClick={() => {
                    setShowSearch(!showSearch);
                    setShowSearchResults(!showSearchResults);
                }}>
                    {showSearch ? "Verberg tabel" : "Merk zoeken"}
                </Button>

                {showSearch && (
                    <Form
                        onSubmit={(e) => {
                            e.preventDefault();
                            setShowSearchResults(true);
                            handleSearch(e);
                        }}
                        className="w-100 mt-3"
                    >
                        <Form.Label>Merk zoeken</Form.Label>
                        <InputGroup>
                            <Form.Control
                                type="text"
                                placeholder="Zoeken"
                                value={searchTermBrands}
                                onChange={(e) => {
                                    e.preventDefault();
                                    setShowSearch(true);
                                    setSearchTermBrands(e.target.value)
                                }}
                            />
                            <Button type="submit">Zoeken</Button>
                        </InputGroup>
                    </Form>
                )}

                {showSearchResults && (
                    <Table striped>
                        <thead>
                            <tr className="border-bottom border-dark">
                                <th>#</th>
                                <th>Brand Name</th>
                            </tr>
                        </thead>
                        <tbody>
                            {Brands.map((brand: Brand) => (
                                <tr key={brand.id}>
                                    <td>{brand.id}</td>
                                    <td>{brand.name}</td>
                                    <td className="text-end">
                                        <Button onClick={() => { handleAddBrand(brand); }}>Toevoegen</Button>
                                    </td>
                                </tr>
                            ))}
                        </tbody>
                    </Table>
                )}

                {/* Competitor brands */}
                <h4 className="mt-5">Competitor brands</h4>
                <Table striped>
                    <thead>
                        <tr className="border-bottom border-dark">
                            <th>#</th>
                            <th>Brand Name</th>
                        </tr>
                    </thead>
                    <tbody>
                        {selectedBrandsComp.length === 0 ? (
                            <tr>
                                <td colSpan={3} className="text-center">(leeg)</td>
                            </tr>
                        ) : (
                            selectedBrandsComp.map((brandComp: Brand) => (
                                <tr key={brandComp.id}>
                                    <td>{brandComp.name}</td>
                                    <td className="text-end">
                                        <Button onClick={() => handleRemoveBrandComp(brandComp.id)}>Verwijderen</Button>
                                    </td>
                                </tr>
                            ))
                        )}
                    </tbody>
                </Table>

                <Button onClick={() => {
                    setShowSearchComp(!showSearchComp);
                    setShowSearchResultsComp(!showSearchResultsComp);
                }}>
                    {showSearchComp ? "Verberg tabel" : "Merk zoeken"}
                </Button>

                {showSearchComp && (
                    <Form
                        onSubmit={(e) => {
                            e.preventDefault();
                            setShowSearchResultsComp(true);
                            handleSearchComp(e);
                        }}
                        className="w-100 mt-3"
                    >
                        <Form.Label>Merk zoeken</Form.Label>
                        <InputGroup>
                            <Form.Control
                                type="text"
                                placeholder="Zoeken"
                                value={searchTermBrandsComp}
                                onChange={(e) => {
                                    e.preventDefault();
                                    setShowSearchComp(true);
                                    setSearchTermBrandsComp(e.target.value)
                                }}
                            />
                            <Button type="submit">Zoeken</Button>
                        </InputGroup>
                    </Form>
                )}

                {showSearchComp && errorComp && <p className="text-danger">{errorComp}</p>}

                {showSearchResultsComp && (!errorComp) && (
                    <Table striped>
                        <thead>
                            <tr className="border-bottom border-dark">
                                <th>#</th>
                                <th>Brand Name</th>
                            </tr>
                        </thead>
                        <tbody>
                            {competitorBrands.map((brandComp: Brand) => (
                                <tr key={brandComp.id}>
                                    <td>{brandComp.id}</td>
                                    <td>{brandComp.name}</td>
                                    <td className="text-end">
                                        <Button onClick={() => { handleAddBrandComp(brandComp); }}>Toevoegen</Button>
                                    </td>
                                </tr>
                            ))}
                        </tbody>
                    </Table>
                )}

                <br />
                <PageFooterNavigation handleOnForward={handleSave} handleOnBackwards={onBackwards}/>
            </Container>
        </>
    )
};

export default StoreBrandmix;