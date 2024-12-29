import { Container, Form, Row, Col } from "react-bootstrap";
import { Klant } from "../../../models/Enterprise/Klant";
import { useState } from "react";
import PageFooterNavigation from "../../Shared/PageFooterNavigation";
import BrandInputSection from "./BrandInputField";
import { useReportContext } from "../../../contexts/reportContext";
import { Brand } from "../../../models/Brands/Brand";

export interface StoreGeneralProps {
  store: Klant;
  onSaveAndForwards: () => void;
  onBackwards: () => void;
}

const StoreGeneral = ({
  store,
  onSaveAndForwards,
  onBackwards,
}: StoreGeneralProps) => {
  const { report, getCurrentReport, setGeneralSituation } = useReportContext();
  const brandMixBrands = getCurrentReport()?.brandMixOverview?.brands || [];

  const [bestBrands, setBestBrands] = useState<Brand[]>(() => {
    const currentReport = getCurrentReport();
    return currentReport?.generalSituation?.bestBrands ?? report?.generalSituation?.bestBrands ?? [];
  });
  
  const [worstBrands, setWorstBrands] = useState<Brand[]>(() => {
    const currentReport = getCurrentReport();
    return currentReport?.generalSituation?.worstBrands ?? report?.generalSituation?.worstBrands ?? [];
  });
  
  const [brandsOut, setBrandsOut] = useState<Brand[]>(() => {
    const currentReport = getCurrentReport();
    return currentReport?.generalSituation?.retiringBrands ?? report?.generalSituation?.retiringBrands ?? [];
  });
  

  const handleAddBrand = (
    newBrand: Brand,
    setBrandList: React.Dispatch<React.SetStateAction<Brand[]>>,
    brandList: Brand[]
  ) => {
    if (
      !bestBrands.some((b) => b.id === newBrand.id) &&
      !worstBrands.some((b) => b.id === newBrand.id) &&
      !brandsOut.some((b) => b.id === newBrand.id)
    ) {
      setBrandList([...brandList, newBrand]);
    }
  };

  const handleRemoveBrand = (
    index: number,
    setBrandList: React.Dispatch<React.SetStateAction<Brand[]>>,
    brandList: Brand[]
  ) => {
    const updatedBrands = brandList.filter((_, i) => i !== index);
    setBrandList(updatedBrands);
  };

  const handleSave = () => {
    const generalSituation = {
      bestBrands,
      worstBrands,
      brandsOut,
    };
    setGeneralSituation(generalSituation);
    onSaveAndForwards();
  }


  return (
    <Container className="py-5" style={{ maxWidth: "600px" }}>
      <div className="d-flex justify-content-between align-items-center mb-4">
        <h1 className="text-center mb-0">{store.name}</h1>
      </div>
      <h2 className="mb-3 mt-4">Algemene situatie</h2>
      <Form>
        <BrandInputSection
          title="Beste merken"
          brands={bestBrands}
          availableBrands={brandMixBrands}
          onAdd={(newBrand) => handleAddBrand(newBrand, setBestBrands, bestBrands)}
          onRemove={(index) => handleRemoveBrand(index, setBestBrands, bestBrands)}
        />

        <BrandInputSection
          title="Slechtste merken"
          brands={worstBrands}
          availableBrands={brandMixBrands}
          onAdd={(newBrand) => handleAddBrand(newBrand, setWorstBrands, worstBrands)}
          onRemove={(index) => handleRemoveBrand(index, setWorstBrands, worstBrands)}
        />

        <BrandInputSection
          title="Merken out"
          brands={brandsOut}
          availableBrands={brandMixBrands}
          onAdd={(newBrand) => handleAddBrand(newBrand, setBrandsOut, brandsOut)}
          onRemove={(index) => handleRemoveBrand(index, setBrandsOut, brandsOut)}
        />

        <Row className="mt-4">
          <Col xs={12}>
            <PageFooterNavigation
              handleOnForward={handleSave}
              handleOnBackwards={onBackwards}
            />
          </Col>
        </Row>
      </Form>
    </Container>
  );
};

export default StoreGeneral;
