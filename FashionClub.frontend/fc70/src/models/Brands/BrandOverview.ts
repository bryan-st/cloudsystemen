import { Employee } from "../Enterprise/Employee";
import { Brand } from "./Brand";

export interface BrandOverview {
    brand: Brand;
    sellOut: string;
    employee: Employee;
}

