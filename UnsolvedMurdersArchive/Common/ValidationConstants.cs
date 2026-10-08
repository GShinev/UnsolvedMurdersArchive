namespace UnsolvedMurdersArchive.Common
{
    public static class ValidationConstants
    {
        public const int CaseTitleMinLength = 5;
        public const int CaseTitleMaxLength = 150;
        public const int CaseYearMinValue = 1900;
        public const int CaseYearMaxValue = 1999;
        public const int CaseCountryMinLength = 2;
        public const int CaseCountryMaxLength = 100;
        public const int CaseLocationMinLength = 2;
        public const int CaseLocationMaxLength = 200;
        public const int CaseSummaryMinLength = 20;
        public const int CaseSummaryMaxLength = 1000;
        public const int CaseCrimeDescriptionMinLength = 50;
        public const int CaseCrimeDescriptionMaxLength = 5000;
        public const int CaseInvestigationMinLength = 50;
        public const int CaseInvestigationMaxLength = 2000;
        public const int CaseEvidenceMinLength = 50;
        public const int CaseEvidenceMaxLength = 2000;
        public const int CaseSuspectsAndTheoriesMinLength = 50;
        public const int CaseSuspectsAndTheoriesMaxLength = 3000;
        public const int CaseImageUrlMaxLength = 500;
    }
}
