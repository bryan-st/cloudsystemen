import React, { useEffect, useState, useRef } from "react";
import { Container, Form } from "react-bootstrap";
import { useReportContext } from "../../../contexts/reportContext";
import PageFooterNavigation from "../../Shared/PageFooterNavigation";

interface StoreTrendsProps { 
    onSaveAndForwards: () => void;
    onBackwards: () => void;
}


const StoreTrends =  ({onSaveAndForwards: handleOnForward, onBackwards: handleOnBackwards}:StoreTrendsProps) => {
    const { report, setTrendsRequirements, setFeedback, getCurrentReport } = useReportContext();

    const [localTrends, setLocalTrends] = useState<string>(() => {
        return getCurrentReport()?.trendsRequirements || "";
    });

    const [localFeedback, setLocalFeedback] = useState<string>(() => {
        return getCurrentReport()?.feedback || "";
    });

    const [isInitialized, setIsInitialized] = useState(false);

    const initialTrendsPlaceholderRef = useRef("");
    const initialFeedbackPlaceholderRef = useRef("");

    useEffect(() => {
        if (report && !isInitialized) {
            initialTrendsPlaceholderRef.current = report?.trendsRequirements
                ? `feedback van de laatste bezoek: \n${report.trendsRequirements}`
                : "Naar welke stijl of items is er veel vraag?";

            initialFeedbackPlaceholderRef.current = report?.feedback
                ? `feedback van de laatste bezoek: \n${report.feedback}`
                : "Vul hier eventuele opmerkingen of feedback in...";

            if (localTrends === null || localTrends === undefined) {
                setLocalTrends("");
            }
            if (localFeedback === null || localFeedback === undefined) {
                setLocalFeedback("");
            }

            setIsInitialized(true);
        }

    }, []);

    const handleTrendsChange = (e: React.ChangeEvent<HTMLTextAreaElement>) => {
        setLocalTrends(e.target.value);
    };

    const handleFeedbackChange = (e: React.ChangeEvent<HTMLTextAreaElement>) => {
        setLocalFeedback(e.target.value);
    };


    const handleSave = () => {
        setFeedback(localFeedback);
        setTrendsRequirements(localTrends);
        handleOnForward();
    };

    const trendsPlaceholder = localTrends ? "" : initialTrendsPlaceholderRef.current;
    const feedbackPlaceholder = localFeedback ? "" : initialFeedbackPlaceholderRef.current;

    return (
        <Container className="py-5" style={{ maxWidth: "600px" }}>
            <div className="d-flex justify-content-between align-items-center mb-4">
                <h1 className="text-center mb-0">
                    {report?.customerInformation?.name || "Store"}  
                </h1>
            </div>
            <h2 className="mb-3 mt-4">Extra opmerkingen en/of feedback</h2>
            <Form onSubmit={handleSave}>
                <Form.Group className="mb-3">
                    <Form.Label>Trends & noden</Form.Label>
                    <Form.Control
                        as="textarea"
                        rows={3}
                        placeholder={trendsPlaceholder}
                        value={localTrends}
                        onChange={handleTrendsChange}
                    />
                </Form.Group>
                <Form.Group className="mb-3">
                    <Form.Label>Verbeterpunten</Form.Label>
                    <Form.Control
                        as="textarea"
                        rows={3}
                        placeholder={feedbackPlaceholder}
                        value={localFeedback}
                        onChange={handleFeedbackChange}
                    />
                </Form.Group>

                <PageFooterNavigation handleOnForward={handleSave} handleOnBackwards={handleOnBackwards} />
            </Form>
        </Container>
    );
};

export default StoreTrends;
