import { useContext } from "react";
import { Form, Button, InputGroup, ListGroup, Container } from "react-bootstrap";
import { Link } from "react-router-dom";
import { DataContext } from "../../contexts/dataContext";
import { Klant } from "../../models/Enterprise/Klant";

const HomePage = () => {
    const {
        page,
        currentPage,
        searchTerm,
        setSearchTerm,
        setCurrentPage,
        fetchPage,
        sendMessage,
        darkMode
    } = useContext(DataContext);


    const renderKlanten = () => {
        const itemsPerPage = 10;
        const startingIndex = (currentPage - 1) * itemsPerPage;

        return page?.klanten.map((klant: Klant, index: number) => (
            <ListGroup.Item key={index} className="d-flex align-items-start">
                <span style={{ fontWeight: "bold", marginRight: "10px", minWidth: "30px", textAlign: "right" }}>
                    {startingIndex + index + 1}.
                </span>
                <div>
                    <Link to={`/${klant.id}`} className="text-decoration-none">
                        <strong>{klant.name}</strong>
                    </Link>
                    <br />
                    {klant.address.street}, {klant.address.postcode} {klant.address.city}
                </div>
            </ListGroup.Item>
        ));
    };

    const hasResults = page?.klanten && page.klanten.length > 0;

    return (
        <Container
            className="d-flex flex-column align-items-center justify-content-center"
            style={{
                minHeight: "90vh",
                maxWidth: "600px",
                padding: "0 15px",
            }}
        >
            <Form
                onSubmit={(e) => {
                    e.preventDefault();
                    if (searchTerm.length < 1) {
                        sendMessage("Klanten search", 'Gelieve een zoekterm in te voeren.');
                    } else if (currentPage === 1) {
                        fetchPage();
                    } else {
                        setCurrentPage(1);
                    }
                }}
                className="w-100"
            >
                <InputGroup>
                    <Form.Control
                        type="text"
                        placeholder="Zoek winkel"
                        value={searchTerm}
                        onChange={(e) => setSearchTerm(e.target.value)}
                    />
                    <Button type="submit" variant="primary">
                        Zoeken
                    </Button>
                </InputGroup>
            </Form>

            {hasResults && (
                <div className="w-100 mt-3">
                    <ListGroup>{renderKlanten()}</ListGroup>
                </div>
            )}

            {hasResults && (
                <div className="d-flex justify-content-center align-items-center mt-3 flex-wrap">
                    <Button
                        variant="outline-primary"
                        onClick={() => currentPage > 1 && setCurrentPage(currentPage - 1)}
                        className="me-2"
                        style={{
                            width: "60px",
                            visibility: currentPage > 1 ? "visible" : "hidden",
                        }}
                    >
                        &larr;
                    </Button>
                    <span className="mx-2" style={{ fontWeight: "bold", color: "#007BFF" }}>
                        Pagina <span style={{ color: darkMode ? "white" : "black" }}>{currentPage}</span> / {page?.pages || 1}
                    </span>
                    <Button
                        variant="outline-primary"
                        onClick={() => page && currentPage < page.pages && setCurrentPage(currentPage + 1)}
                        className="ms-2"
                        style={{
                            width: "60px",
                            visibility: page && currentPage < page.pages ? "visible" : "hidden",
                        }}
                    >
                        &rarr;
                    </Button>
                </div>
            )}
        </Container>
    );
};

export default HomePage;
