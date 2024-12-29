import { BrandDto } from "../Brands/BrandDto";

export interface GeneralSituationDto {
    bestBrands?: BrandDto[];
    worstBrands?: BrandDto[];
    retiringBrands?: BrandDto[];
}