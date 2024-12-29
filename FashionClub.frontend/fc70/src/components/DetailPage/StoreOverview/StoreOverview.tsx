import {Container, Table } from "react-bootstrap";
import { useReportContext } from "../../../contexts/reportContext";

const StoreOverview = () => {
    const { getCurrentReport, postReport } = useReportContext();
    
    const report = getCurrentReport();
    return (
        <Container className="py-5" style={{ maxWidth: "600px" }}>
            <div className="d-flex justify-content-between align-items-center mb-4">
                <h1 className="text-center mb-0">Overview</h1>
            </div>
            {report && <>
                {report.customerInformation && <>
                    <h2>Klantgegevens</h2>
                    <Table striped>
                        <thead>
                            <tr className="border-bottom border-dark">
                                <th>Klant</th>
                                <th>Stad</th>
                                <th>Straat</th>
                                <th>Postcode</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>{report.customerInformation.name}</td>
                                <td>{report.customerInformation.address.city}</td>
                                <td>{report.customerInformation.address.street}</td>
                                <td>{report.customerInformation.address.postcode}</td>
                            </tr>
                        </tbody>
                    </Table>
                </>}
                {report.brandMixOverview && <>
                    {report.brandMixOverview.brands && report.brandMixOverview.brands.length > 0 && <>
                        <h2>FC70 Brands</h2>
                        <Table striped>
                            <thead>
                                <tr className="border-bottom border-dark">
                                    <th>#</th>
                                    <th>Brand Name</th>
                                </tr>
                            </thead>
                            <tbody>
                                {report.brandMixOverview.brands.map((brand, index) =>
                                    <tr key={index}>
                                        <td>{index}</td>
                                        <td>{brand.name}</td>
                                    </tr>
                                )}
                            </tbody>
                        </Table>
                    </>}
                    {report.brandMixOverview.competitorBrands && report.brandMixOverview.competitorBrands.length > 0 && <>
                        <h2>Andere merken</h2>
                        <Table striped>
                            <thead>
                                <tr className="border-bottom border-dark">
                                    <th>#</th>
                                    <th>Brand Name</th>
                                </tr>
                            </thead>
                            <tbody>
                                {report.brandMixOverview.competitorBrands.map((brand, index) =>
                                    <tr key={index}>
                                        <td>{index}</td>
                                        <td>{brand.name}</td>
                                    </tr>
                                )}
                            </tbody>
                        </Table>
                    </>}
                    {report.brandMixOverview.brandsOverviews && report.brandMixOverview.brandsOverviews.length > 0 && <>
                        <h2>FC70 merken overzicht</h2>
                        <Table striped>
                            <tbody>
                                {report.brandMixOverview.brandsOverviews.map((brandOverview, index) =>
                                    <div key={index}>
                                        <tr>
                                            <th>Brand</th>
                                            <td>{index}</td>
                                            <td>{brandOverview.brand.name}</td>
                                        </tr>
                                        <tr>
                                            <th>Selout</th>
                                            <td>{brandOverview.sellOut}</td>
                                        </tr>
                                    </div>
                                )}
                            </tbody>
                        </Table>
                    </>}
                </>}
                {report.generalSituation && <>
                    {report.generalSituation.bestBrands && report.generalSituation.bestBrands.length > 0 && <>
                        <h2>Beste merken</h2>
                        <Table striped>
                            <thead>
                                <tr className="border-bottom border-dark">
                                    <th>#</th>
                                    <th>Brand Name</th>
                                </tr>
                            </thead>
                            <tbody>
                                {report.generalSituation.bestBrands.map((brand, index) =>
                                    <tr key={index}>
                                        <td>{index}</td>
                                        <td>{brand.name}</td>
                                    </tr>
                                )}
                            </tbody>
                        </Table>
                    </>}
                    {report.generalSituation.worstBrands && report.generalSituation.worstBrands.length > 0 && <>
                        <h2>Slechste merken</h2>
                        <Table striped>
                            <thead>
                                <tr className="border-bottom border-dark">
                                    <th>#</th>
                                    <th>Brand Name</th>
                                </tr>
                            </thead>
                            <tbody>
                                {report.generalSituation.worstBrands.map((brand, index) =>
                                    <tr key={index}>
                                        <td>{index}</td>
                                        <td>{brand.name}</td>
                                    </tr>
                                )}
                            </tbody>
                        </Table>
                    </>}
                    {report.generalSituation.retiringBrands && report.generalSituation.retiringBrands.length > 0 && <>
                        <h2>Merken out</h2>
                        <Table striped>
                            <thead>
                                <tr className="border-bottom border-dark">
                                    <th>#</th>
                                    <th>Brand Name</th>
                                </tr>
                            </thead>
                            <tbody>
                                {report.generalSituation.retiringBrands.map((brand, index) =>
                                    <tr key={index}>
                                        <td>{index}</td>
                                        <td>{brand.name}</td>
                                    </tr>
                                )}
                            </tbody>
                        </Table>
                    </>}
                </>}
                {report.interestingBrands && report.interestingBrands.length > 0 && <>
                    <h2>Interesse FC70 merken</h2>
                    <Table striped>
                        <thead>
                            <tr className="border-bottom border-dark">
                                <th>#</th>
                                <th>Brand Name</th>
                            </tr>
                        </thead>
                        <tbody>
                            {report.interestingBrands.map((brand, index) =>
                                <tr key={index}>
                                    <td>{brand.name}</td>
                                </tr>
                            )}
                        </tbody>
                    </Table>
                </>}
                {report.conversationPartners && report.conversationPartners.length > 0 && <>
                    <h2>Gesprekpartner</h2>
                    <Table striped>
                        <thead>
                            <tr className="border-bottom border-dark">
                                <th>first name</th>
                                <th>last name</th>
                            </tr>
                        </thead>
                        <tbody>
                            {report.conversationPartners
                            .filter((cp) => cp.isLastSpoken === true)
                            .map((cp, index) =>
                                <tr key={index}>
                                    <td>{String(cp.firstName)}</td>
                                    <td>{String(cp.lastName)}</td>
                                </tr>)}
                        </tbody>
                    </Table>
                </>}
                {report.reason && <>
                    <h2>Reden van bezoek</h2>
                    <p>{report.reason}</p>
                </>}
                {report.trendsRequirements && <>
                    <h2>Trends & noden in de markt</h2>
                    <p>{report.trendsRequirements}</p>
                </>}
                {report.feedback && <>
                    <h2>Extra opmerkingen en/of feedback</h2>
                    <p>{report.feedback}</p>
                </>}
            </>}
            <button type="submit" onClick={() => postReport()} className="w-100 btn btn-primary">Verzend</button>
        </Container>
    )
}

export default StoreOverview;