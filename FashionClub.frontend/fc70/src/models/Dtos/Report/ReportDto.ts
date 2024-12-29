import { Klant } from "../../Enterprise/Klant";
import { BrandDto } from "../Brands/BrandDto";
import { BrandmixOverviewDto } from "../Brands/BrandMixOverviewDto";
import { ConversationPartnerDto } from "./ConversationPartnerDto";
import { GeneralSituationDto } from "./GeneralSituation";


export interface ReportDto {
    klantId: number;
    customerInformation: Klant | null;
    brandMixOverview: BrandmixOverviewDto | null;
    generalSituation: GeneralSituationDto | null;
    interestingBrands?: BrandDto[] | null;
    conversationPartners: ConversationPartnerDto[];
    reason: string;
    trendsRequirements: string;
    feedback: string;

}

