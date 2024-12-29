import React, {
  createContext,
  useContext,
  useEffect,
  useState,
  useMemo,
} from "react";
import { Report } from "../models/Report/Report";
import { Klant } from "../models/Enterprise/Klant";
import { BrandmixOverview } from "../models/Brands/BrandMixOverview";
import { ReportDto } from "../models/Dtos/Report/ReportDto";
import { GeneralSituation } from "../models/Report/GeneralSituation";
import { Brand } from "../models/Brands/Brand";
import {
  mapFromBrandMixOverviewDto,
  mapFromConversationPartnerDto,
  mapFromGeneralSituationDto,
  mapToBrandMixOverviewDto,
  mapToConversationPartnerDto,
  mapToGeneralSituationDto,
} from "../utilities/Mappers/ReportMappers";
import { ConversationPartner } from "../models/Report/ConversationPartner";
import {
  mapFromBrandDto,
  mapToBrandDto,
} from "../utilities/Mappers/BrandMappers";
import { DataContext } from "./dataContext";

interface ReportContextProps {
  report: Report | null;
  stableReport: Report | null;
  getCurrentReport: () => ReportDto | null;
  setStore: (klant: Klant | undefined) => void;
  setBrandMixOverview: (brandMixOverview: BrandmixOverview | null) => void;
  setGeneralSituation: (generalSituation: GeneralSituation | null) => void;
  setInterestingBrands: (interestingBrands: Brand[] | null) => void;
  setConversationPartner: (
    conversationPartner: ConversationPartner[] | null
  ) => void;
  conversationPartner: ConversationPartner[] | null;
  setReason: (reason: string | null) => void;
  setTrendsRequirements: (trendsRequirements: string | null) => void;
  setFeedback: (feedback: string | null) => void;
  fetchReport: (klantId: number) => Promise<void>;
  postReport: () => Promise<void>;
}


const ReportContext = createContext<ReportContextProps | undefined>(undefined);

export const useReportContext = (): ReportContextProps => {
  const context = useContext(ReportContext);
  if (!context) {
    throw new Error("useReportContext must be used within a ReportProvider");
  }
  return context;
};

export const ReportProvider = ({ children }: { children: React.ReactNode }) => {
  const { sendMessage } = useContext(DataContext);
  const [report, setReport] = useState<Report | null>(() => {
    const savedReport = localStorage.getItem("report");
    return savedReport ? JSON.parse(savedReport) : null;
  });

  const [store, setStore] = useState<Klant | undefined>(undefined);
  const [brandMixOverview, setBrandMixOverview] =
    useState<BrandmixOverview | null>(null);
  const [generalSituation, setGeneralSituation] =
    useState<GeneralSituation | null>(null);
  const [interestingBrands, setInterestingBrands] = useState<Brand[] | null>(
    null
  );
  const [conversationPartner, setConversationPartner] = useState<
    ConversationPartner[] | null
  >(null);
  const [reason, setReason] = useState<string | null>(null);
  const [trendsRequirements, setTrendsRequirements] = useState<string | null>(
    null
  );
  const [feedback, setFeedback] = useState<string | null>(null);

  const getApiUrl = () => {
    const url = import.meta.env.VITE_APP_API_URL;
    if (!url) {
      throw new Error(
        "API URL is not defined. Please set VITE_APP_API_URL in your environment."
      );
    }
    return url;
  };

const stableReport = useMemo(() => report, [report]);

  const apiUrl = useMemo(() => getApiUrl(), []);

  useEffect(() => {
    console.log("reportContext use effect called", report);
    if (report) {
      localStorage.setItem("report", JSON.stringify(report));
    }
  }, []);

  const fetchReport = async (klantId: number) => {
    try {
      const response = await fetch(`${apiUrl}/Report/${klantId}`);
      if (!response.ok) throw new Error("Failed to fetch report");

      const reportDto: ReportDto = await response.json();
      const mappedReport = mapReportDtoToReport(reportDto);
      console.log("Fetched report:", mappedReport);
      setReport(mappedReport);
      localStorage.setItem("report", JSON.stringify(mappedReport));
    } catch (error) {
      console.error("Error fetching report:", error);
      sendMessage("Raport", "An error occurred while fetching the report.");
    }
  };

  const getCurrentReport = (): ReportDto => {
    const dto: ReportDto = {
      klantId: store?.id ?? 0,
      customerInformation: store ?? null,
      brandMixOverview: brandMixOverview
        ? mapToBrandMixOverviewDto(brandMixOverview)
        : null,
      generalSituation: generalSituation
        ? mapToGeneralSituationDto(generalSituation)
        : null,
      interestingBrands: interestingBrands
        ? mapToBrandDto(interestingBrands)
        : [],
      conversationPartners: conversationPartner
        ? mapToConversationPartnerDto(conversationPartner)
        : [],
      reason: reason ?? "",
      trendsRequirements: trendsRequirements ?? "",
      feedback: feedback ?? "",
    };
    return dto;
  };
  

  const populateReportDto = (): ReportDto => {
    const dto: ReportDto = {} as ReportDto;
    dto.klantId = store?.id ?? 0;
    dto.customerInformation = store ?? null;
    dto.brandMixOverview = brandMixOverview
      ? mapToBrandMixOverviewDto(brandMixOverview)
      : null;
    dto.generalSituation = generalSituation
      ? mapToGeneralSituationDto(generalSituation)
      : null;
    dto.interestingBrands = interestingBrands
      ? mapToBrandDto(interestingBrands)
      : [];
    dto.conversationPartners = conversationPartner
      ? mapToConversationPartnerDto(conversationPartner)
      : [];
    dto.reason = reason ?? "";
    dto.trendsRequirements = trendsRequirements ?? "";
    dto.feedback = feedback ?? "";
    return dto;
  };

  const postReport = async () => {
    try {
      const dto = populateReportDto();
      const response = await fetch(`${apiUrl}/Report`, {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(dto),
      });

      if (!response.ok) {
        sendMessage("Error", "Failed to post report.")
      }

      const data = await response.json();
      setReport(data);
      localStorage.setItem("report", JSON.stringify(data));
      sendMessage("Raport", "Raport posted")
    } catch (err) {
      console.error("Error posting report:", err);
      sendMessage("Raport", "An error occurred while fetching the report.");
    }
  };

  const mapReportDtoToReport = (reportDto: ReportDto): Report => {
    const mappedReport: Report = {
      customerInformation: store ?? null,
      brandMixOverview:
        reportDto.brandMixOverview !== undefined
          ? mapFromBrandMixOverviewDto(reportDto.brandMixOverview)
          : null,
      generalSituation:
        reportDto.generalSituation !== undefined
          ? mapFromGeneralSituationDto(reportDto.generalSituation)
          : null,
      interestingBrands:
        reportDto.interestingBrands !== undefined
          ? mapFromBrandDto(reportDto.interestingBrands)
          : null,
      conversationPartners:
        reportDto.conversationPartners !== undefined
          ? mapFromConversationPartnerDto(reportDto.conversationPartners)
          : null,
      reason: reportDto.reason ?? null,
      trendsRequirements: reportDto.trendsRequirements ?? null,
      feedback: reportDto.feedback ?? null,
    };
    return mappedReport;
  };

  return (
    <ReportContext.Provider
      value={{
        report,
        stableReport,
        getCurrentReport,
        setStore,
        setBrandMixOverview,
        setGeneralSituation,
        setConversationPartner,
        conversationPartner,
        setReason,
        setTrendsRequirements,
        setFeedback,
        setInterestingBrands,
        fetchReport,
        postReport,
      }}
    >
      {children}
    </ReportContext.Provider>
  );
};
