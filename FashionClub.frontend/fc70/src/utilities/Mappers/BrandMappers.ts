import { Brand } from "../../models/Brands/Brand";
import { BrandDto } from "../../models/Dtos/Brands/BrandDto";

export const mapToBrandDto = (brands?: Brand[]): BrandDto[] | undefined => {
    return brands?.map(brand => ({
        id: brand.id,
        name: brand.name
    }));
};

export const mapFromBrandDto = (brands?: BrandDto[] | null): Brand[] | undefined => {
    if (!brands) {
        return [];
    }
    return brands?.map(brand => ({
        id: brand.id,
        name: brand.name
    }));
};