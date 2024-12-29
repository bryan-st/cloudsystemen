import { Brand } from "./Brand";
import { BrandOverview } from "./BrandOverview";
import { CompetitorBrand } from "./CompetitorBrand";

export interface BrandmixOverview {
    brands?: Brand[];
    competitorBrands?: CompetitorBrand[];
    brandsOverviews: BrandOverview[];
}