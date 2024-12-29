import { Container, Form, Button, Row, Col } from "react-bootstrap";
import { Klant } from "../../../models/Enterprise/Klant";
import React,{ useState, useRef } from "react";
import { useReportContext } from "../../../contexts/reportContext";
import { ConversationPartner } from "../../../models/Report/ConversationPartner";
import PageFooterNavigation from "../../Shared/PageFooterNavigation";

export interface StoreInformationProps {
  store: Klant;
  onSaveAndForwards: () => void;
  onBackwards: () => void;
}

const StoreInformation = ({ store, onSaveAndForwards, onBackwards }: StoreInformationProps) => {
  const { stableReport: report, setReason, setConversationPartner, conversationPartner, getCurrentReport } = useReportContext();

  const [addNewContactPersonSelected, setAddNewContactPersonSelected] = useState(false);
  const [newContactPerson, setNewContactPerson] = useState<ConversationPartner | null>(null);
  const [selectedContactPersonId, setSelectedContactPersonId] = useState(() => {
    return getCurrentReport()?.conversationPartners?.find((partner) => partner.isLastSpoken)?.id || "";
  });

  const [localReason, setLocalReason] = useState<string>(() => {
    return getCurrentReport()?.reason || "";
});


  const initialReasonPlaceholderRef = useRef(report?.reason
    ? `feedback van de laatste bezoek: \n${report.reason}`
    : "Vul hier de reden van het bezoek in...");

  const [localGesprekPartners, setLocalGesprekPartners] = useState<ConversationPartner[]>((): any => {
    return getCurrentReport()?.conversationPartners.length != 0 ? getCurrentReport()?.conversationPartners : report?.conversationPartners;
  });

  const handleContactPersonChange = (e: React.ChangeEvent<HTMLSelectElement>) => {
    const selectedId = parseInt(e.target.value, 10);
    setSelectedContactPersonId(selectedId.toString());
    setLocalGesprekPartners((prevPartners) =>
      prevPartners.map((partner) => ({
        ...partner,
        isLastSpoken: partner.id === selectedId,
      }))
    );
  };

  const handleNewContactPersonChange = (field: keyof ConversationPartner, value: string) => {
    setNewContactPerson((prev) => ({
      ...(prev || {}),
      [field]: value,
    }) as ConversationPartner);
  };

  const handleAddNewContactPerson = () => {
    if (newContactPerson?.firstName && newContactPerson?.lastName) {
      const newId =
      localGesprekPartners.length > 0
        ? Math.max(...localGesprekPartners.map((p) => p.id)) + 1
        : 1;

      const newPartner = {
        id: newId,
        firstName: newContactPerson.firstName,
        lastName: newContactPerson.lastName,
        isLastSpoken: true,
      };
      setLocalGesprekPartners((prevPartners) =>
    prevPartners.map((partner) => ({
      ...partner,
      isLastSpoken: false, 
    })).concat(newPartner) 
  );
      setConversationPartner([...(localGesprekPartners || []), newPartner]);
      setNewContactPerson({ id: 0, firstName: "", lastName: "", isLastSpoken: true });
      setAddNewContactPersonSelected(false);
      setSelectedContactPersonId(newPartner.id.toString());
      if (Array.isArray(conversationPartner)) {
       setConversationPartner([...conversationPartner, newPartner]);
       }
       getCurrentReport();
    } else {
      alert("Vul zowel voornaam als achternaam in.");
    }
  };

  const toggleAddNewContactPerson = () => {
    setAddNewContactPersonSelected(!addNewContactPersonSelected);
  };

  const handleReasonChange = (e: React.ChangeEvent<HTMLTextAreaElement>) => {
    setLocalReason(e.target.value);
  };

  const address = store?.address
    ? store.address
    : { street: "Onbekend", postcode: "Onbekend", city: "Onbekend" };

  const handleOnSave = () => {
    setReason(localReason);
    setConversationPartner(localGesprekPartners);
  
    const updatedReport = getCurrentReport();
    if (updatedReport) {
      setLocalReason(updatedReport.reason || "");
      setLocalGesprekPartners(updatedReport.conversationPartners || []);

      onSaveAndForwards();
  };
}

  return (
    <>
      <Container className="py-5" style={{ maxWidth: "600px" }}>
        <div className="d-flex justify-content-between align-items-center mb-4">
          <h1 className="text-center mb-0">{store.name}</h1>
        </div>

        <Form>
          <h2 className="mb-3 mt-4">Winkelinformatie</h2>
          <Row className="mb-4">
            <Col xs={12} className="mb-3">
              <Form.Label>Winkelnaam</Form.Label>
              <Form.Control type="text" value={store.name} disabled />
            </Col>
            <Col xs={12} className="mb-3">
              <Form.Label>Straat</Form.Label>
              <Form.Control type="text" value={address.street} disabled />
            </Col>
            <Col xs={12} sm={3} className="mb-3">
              <Form.Label>Postcode</Form.Label>
              <Form.Control type="text" value={address.postcode} disabled />
            </Col>
            <Col xs={12} sm={9} className="mb-3">
              <Form.Label>Stad</Form.Label>
              <Form.Control type="text" value={address.city} disabled />
            </Col>
          </Row>

          <h2 className="mb-3 mt-4">Gesprekspartner</h2>
          <Row className="align-items-center mb-4">
            <Col xs={10}>
              <Form.Select
                value={selectedContactPersonId}
                onChange={handleContactPersonChange}
                className="h-100"
              >
                <option value="">-- Kies een gesprekspartner --</option>
                {localGesprekPartners.map((partner) => (
                  <option key={partner.id} value={partner.id}>
                    {`${partner.firstName} ${partner.lastName}`}
                  </option>
                ))}
              </Form.Select>
            </Col>
            <Col xs={2} className="text-end">
              <Button
                variant={addNewContactPersonSelected ? "danger" : "primary"}
                className="w-100 h-100 d-flex justify-content-center align-items-center"
                onClick={toggleAddNewContactPerson}
              >
                {addNewContactPersonSelected ? "×" : "+"}
              </Button>
            </Col>
          </Row>

          {addNewContactPersonSelected && (
            <Row className="mb-3">
              <Col xs={12} sm={6} className="mb-3 mb-sm-0">
                <Form.Label>Voornaam</Form.Label>
                <Form.Control
                  type="text"
                  value={newContactPerson?.firstName || ""}
                  onChange={(e) => handleNewContactPersonChange("firstName", e.target.value)}
                />
              </Col>
              <Col xs={12} sm={6}>
                <Form.Label>Achternaam</Form.Label>
                <Form.Control
                  type="text"
                  value={newContactPerson?.lastName || ""}
                  onChange={(e) => handleNewContactPersonChange("lastName", e.target.value)}
                />
              </Col>
              <Col xs={12} className="mt-3">
                <Button variant="primary" onClick={handleAddNewContactPerson}>
                  Voeg toe
                </Button>
              </Col>
            </Row>
          )}

          <h2 className="mb-3 mt-4">Reden van bezoek</h2>
          <Row className="mb-4">
            <Col xs={12}>
              <Form.Control
                as="textarea"
                rows={3}
                placeholder={initialReasonPlaceholderRef.current}
                value={localReason}
                onChange={handleReasonChange}
              />
            </Col>
          </Row>

          <PageFooterNavigation
            handleOnForward={handleOnSave}
            handleOnBackwards={onBackwards}
            />
        </Form>
      </Container>
    </>
  );
};

export default StoreInformation;
