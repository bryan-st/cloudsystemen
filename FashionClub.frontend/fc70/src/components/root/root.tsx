import { Navbar, Container } from "react-bootstrap";
import { Link, Outlet } from "react-router-dom";
import Logo from "../../assets/logo-header.svg";
import { useContext } from "react";
import { DataContext } from "../../contexts/dataContext";

const Root = () => {
    const { darkMode } = useContext(DataContext);
    return (
        <>
            <header>
                <Navbar>
                    <Container className="justify-content-center">
                        <Link to="/" className="d-block text-center">
                            <img
                                src={Logo}
                                alt="Fashion Club Logo"
                                className="img-fluid"
                                style={{
                                    maxHeight: "60px",
                                    padding: "10px",
                                    cursor: "pointer",
                                    filter: darkMode ? "invert(80%)" : "none"
                                }}
                            />
                        </Link>
                    </Container>
                </Navbar>
            </header>

            <main className="container-sm mt-3">
                <Outlet />
            </main>
        </>
    );
};

export default Root;
