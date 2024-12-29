import React, { useContext, useEffect } from "react";
import { Link, useNavigate, useParams } from "react-router-dom";
import { DataContext } from "../../contexts/dataContext";
import { Container, Button, Navbar, } from "react-bootstrap";
import StoreGeneral from "./StoreGeneral/StoreGeneral";
import StoreTrends from "./StoreTrends/StoreTrends";
import StoreInformation from "./StoreInformation/StoreInformation";
import { useReportContext } from "../../contexts/reportContext";
import StoreOverview from "./StoreOverview/StoreOverview";
import StoreBrandmix from "./StoreBrandmix/StoreBrandmix";


const DetailPage: React.FC = () => {
    const { id, tab } = useParams<{ id: string, tab: string }>();
    const storeId = parseInt(id!, 10);
    const { page } = useContext(DataContext);
    const { setStore, fetchReport } = useReportContext();
    const store = page?.klanten.find((store) => store.id === storeId);

    const navigate = useNavigate();
    

    useEffect(() => {
        if (store) {
            setStore(store); 
            fetchReport(store.id); 
        }
    }, []);

    // Foutopvang als de winkel niet gevonden is
    if (!store) {
        return (
            <Container className="d-flex flex-column align-items-center justify-content-center" style={{ height: "100vh" }}>
                <Button variant="secondary" onClick={() => window.history.back()}>
                    &larr; Terug
                </Button>
                <h2>Winkel niet gevonden</h2>
            </Container>
        );
    }


    const Tabs = () => {
        switch (String(tab)) {
            case "Brandmix":
                return <StoreBrandmix store={store} onBackwards={() => navigate(`/${id}`)} onSafeAndForward={() => navigate(`/${id}/General`)} />
                break;
            case "General":
                return <StoreGeneral store={store} onBackwards={() => navigate(`/${id}/Brandmix`)} onSaveAndForwards={() => navigate(`/${id}/Trends`)} />
                break;
            case "Trends":
                return <StoreTrends onBackwards={() => navigate(`/${id}/General`)} onSaveAndForwards={() => navigate(`/${id}/Overview`)}/>
                break;
            case "Overview":
                return <StoreOverview />
                break;
            default:
                return <StoreInformation
                    store={store} onBackwards={() => navigate(`/`)} onSaveAndForwards={() => navigate(`/${id}/Brandmix`)}/>
                break;
        }
    }

    return (
        <>
            <Navbar>
                <Container className="justify-content-center">
                    <ul className="nav col-12 col-md-auto mb-2 justify-content-center mb-md-0">
                        <li><Link to={`/${id}`} className={`nav-link px-2 ${location.pathname == `/${id}` && "link-secondary"}`}>Winkelinformatie</Link></li>
                        <li><Link to={`/${id}/Brandmix`} className={`nav-link px-2 ${location.pathname == `/${id}/Brandmix` && "link-secondary"}`}>Brandmix</Link></li>
                        <li><Link to={`/${id}/General`} className={`nav-link px-2 ${location.pathname == `/${id}/General` && "link-secondary"}`}>General</Link></li>
                        <li><Link to={`/${id}/Trends`} className={`nav-link px-2 ${location.pathname == `/${id}/Trends` && "link-secondary"}`}>Trends</Link></li>
                        <li><Link to={`/${id}/Overview`} className={`nav-link px-2 ${location.pathname == `/${id}/Overview` && "link-secondary"}`}>Overview</Link></li>
                    </ul>
                </Container>
            </Navbar>
            <Tabs />
        </>
    );
};

export default DetailPage;
