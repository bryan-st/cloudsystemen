import { BrandmixOverview } from "../../models/Brands/BrandMixOverview";
import { BrandmixOverviewDto } from "../../models/Dtos/Brands/BrandMixOverviewDto";
import { ConversationPartnerDto } from "../../models/Dtos/Report/ConversationPartnerDto";
import { GeneralSituationDto } from "../../models/Dtos/Report/GeneralSituation";
import { ConversationPartner } from "../../models/Report/ConversationPartner";
import { GeneralSituation } from "../../models/Report/GeneralSituation";
import { mapFromBrandDto, mapToBrandDto } from "./BrandMappers";


 export const mapToBrandMixOverviewDto = (brandMixOverview: BrandmixOverview): BrandmixOverviewDto => {
    return {
        brands: brandMixOverview.brands?.map(brand => ({
            id: brand.id,
            name: brand.name
        })),
        competitorBrands: brandMixOverview.competitorBrands?.map(competitorBrand => ({
            id: competitorBrand.id,
            name: competitorBrand.name
        })),
        brandsOverviews: brandMixOverview.brandsOverviews.map(brandOverview => ({
            brand: {
                id: brandOverview.brand.id,
                name: brandOverview.brand.name
            },
            sellOut: brandOverview.sellOut,
            employee: {
                id: brandOverview.employee.id,
                name: brandOverview.employee.name
            }
        }))
    };
};

export const mapFromBrandMixOverviewDto = (dto: BrandmixOverviewDto | null): BrandmixOverview => {
    if (!dto) {
        return {
            brands: [],
            competitorBrands: [],
            brandsOverviews: []
        };
    }
    return {
        brands: dto.brands?.map(brand => ({
            id: brand.id,
            name: brand.name
        })),
        competitorBrands: dto.competitorBrands?.map(competitorBrand => ({
            id: competitorBrand.id,
            name: competitorBrand.name
        })),
        brandsOverviews: dto.brandsOverviews?.map(brandOverview => ({
            brand: {
                id: brandOverview.brand.id,
                name: brandOverview.brand.name
            },
            sellOut: brandOverview.sellOut,
            employee: {
                id: brandOverview.employee.id,
                name: brandOverview.employee.name
            }
        }))
    };
};


export const mapToGeneralSituationDto = (generalSituation: GeneralSituation): GeneralSituationDto => {
    return {
        bestBrands: mapToBrandDto(generalSituation.bestBrands),
        worstBrands: mapToBrandDto(generalSituation.worstBrands),
        retiringBrands: mapToBrandDto(generalSituation.retiringBrands),
    };
};

export const mapFromGeneralSituationDto = (dto: GeneralSituationDto | null): GeneralSituation => {
    if (!dto) {
        return {
            bestBrands: [],
            worstBrands: [],
            retiringBrands: []
        };
    }
    return {
        bestBrands: mapFromBrandDto(dto.bestBrands),
        worstBrands: mapFromBrandDto(dto.worstBrands),
        retiringBrands: mapFromBrandDto(dto.retiringBrands),
    };
};


export const mapToConversationPartnerDto = (conversationPartners: ConversationPartner[]): ConversationPartnerDto[] => {
    return conversationPartners.map(conversationPartner => ({
        id: conversationPartner.id,
        firstName: conversationPartner.firstName,
        lastName: conversationPartner.lastName,
        isLastSpoken: conversationPartner.isLastSpoken
    }));
};


export const mapFromConversationPartnerDto = (
    dtos: ConversationPartnerDto[] | undefined | null
): ConversationPartner[] => {
    console.log("Input to mapFromConversationPartnerDto:", dtos);

    if (!dtos || !Array.isArray(dtos)) {
        console.warn("Invalid input to mapFromConversationPartnerDto:", dtos);
        return [];
    }

    const mapped = dtos.map((dto) => ({
        id: dto.id!,
        firstName: dto.firstName,
        lastName: dto.lastName,
        isLastSpoken: dto.isLastSpoken,
    }));

    return mapped;
};



