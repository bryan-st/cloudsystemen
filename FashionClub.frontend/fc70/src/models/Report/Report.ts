import { Brand } from "../Brands/Brand";
import { Klant } from "../Enterprise/Klant";
import { GeneralSituation } from "./GeneralSituation";
import { BrandmixOverview } from "../Brands/BrandMixOverview";
import { ConversationPartner } from "./ConversationPartner";

export interface Report {
    customerInformation: Klant | null | undefined ;
    brandMixOverview: BrandmixOverview | null;
    generalSituation: GeneralSituation | null;
    interestingBrands?: Brand[] | null;
    conversationPartners: ConversationPartner[] | null;
    reason: string | null;
    trendsRequirements: string | null;
    feedback: string | null;
}