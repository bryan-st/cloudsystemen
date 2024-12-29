import { Klant } from "./Enterprise/Klant";

export interface Page {
    klanten: Klant[];
    pages: number;
}