export interface ConversationPartner  {
    id: number;
    firstName: string | null | undefined;
    lastName: string | null | undefined;
    isLastSpoken: boolean
}