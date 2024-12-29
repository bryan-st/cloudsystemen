import React, { useState } from "react";
import { Row, Col, Form, Button } from "react-bootstrap";
import { Brand } from "../../../models/Brands/Brand";

interface BrandInputSectionProps {
  title: string;
  brands: Brand[];
  availableBrands: Brand[];
  onAdd: (brand: Brand) => void;
  onRemove: (index: number) => void;
}

const BrandInputSection: React.FC<BrandInputSectionProps> = ({
  title,
  brands,
  availableBrands,
  onAdd,
  onRemove,
}) => {
  const [selectedBrandId, setSelectedBrandId] = useState<number | null>(null);

  const handleAdd = () => {
    if (!selectedBrandId) return;

    const newBrand = availableBrands.find(
      (brand) => brand.id === selectedBrandId
    );
    if (newBrand) {
      onAdd(newBrand);
      setSelectedBrandId(null);
    }
  };

  return (
    <>
      <h4 className="mt-4">{title}</h4>
      {brands.map((brand, index) => (
        <Row className="mb-3" key={brand.id}>
          <Col xs={10}>
            <Form.Control
              type="text"
              value={brand.name}
              disabled
              className="h-100"
            />
          </Col>
          <Col xs={2} className="text-end">
            <Button
              variant="danger"
              className="w-100 h-100 d-flex justify-content-center align-items-center"
              onClick={() => onRemove(index)}
            >
              &times;
            </Button>
          </Col>
        </Row>
      ))}

      <Row className="mt-3 mb-4">
        <Col xs={10}>
          <Form.Select
            value={selectedBrandId || ""}
            onChange={(e) => setSelectedBrandId(Number(e.target.value))}
            className="h-100"
          >
            <option value="" disabled>
              Selecteer een merk
            </option>
            {availableBrands
              .filter((brand) => !brands.some((b) => b.id === brand.id))
              .map((brand) => (
                <option key={brand.id} value={brand.id}>
                  {brand.name}
                </option>
              ))}
          </Form.Select>
        </Col>
        <Col xs={2} className="text-end">
          <Button
            className="w-100 h-100 d-flex justify-content-center align-items-center"
            onClick={handleAdd}
            disabled={!selectedBrandId}
          >
            +
          </Button>
        </Col>
      </Row>
    </>
  );
};

export default BrandInputSection;
