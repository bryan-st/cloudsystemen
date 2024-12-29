import { BrandDto } from "./BrandDto";
import { BrandOverviewDto } from "./BrandOverviewDto";
import { CompetitorBrandDto } from "./CompetitorBrandDto";


export interface BrandmixOverviewDto {
    brands?: BrandDto[];
    competitorBrands?: CompetitorBrandDto[];
    brandsOverviews: BrandOverviewDto[];
}