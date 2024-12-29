import { Brand } from "../Brands/Brand";

export interface GeneralSituation {
    bestBrands?: Brand[];
    worstBrands?: Brand[];
    retiringBrands?: Brand[];
}