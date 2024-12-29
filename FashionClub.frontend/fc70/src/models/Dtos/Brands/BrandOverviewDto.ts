import { EmployeeDto } from "../Enterprise/EmployeeDto";
import { BrandDto } from "./BrandDto";


export interface BrandOverviewDto {
    brand: BrandDto;
    sellOut: string;
    employee: EmployeeDto;
}

