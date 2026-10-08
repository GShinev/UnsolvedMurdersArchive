using System.ComponentModel.DataAnnotations;
using UnsolvedMurdersArchive.Common;

namespace UnsolvedMurdersArchive.Models
{
    public class Case
    {
        public int Id { get; set; }

        [Required]
        [StringLength(ValidationConstants.CaseTitleMaxLength, 
        MinimumLength = ValidationConstants.CaseTitleMinLength)]
        public string Title { get; set; } = null!;

        [Range(ValidationConstants.CaseYearMinValue, ValidationConstants.CaseYearMaxValue)]
        public int Year { get; set; }

        [Required]
        [StringLength(ValidationConstants.CaseCountryMaxLength, 
        MinimumLength = ValidationConstants.CaseCountryMinLength)]
        public string Country { get; set; } = null!;

        [Required]
        [StringLength(ValidationConstants.CaseLocationMaxLength, 
        MinimumLength = ValidationConstants.CaseLocationMinLength)]
        public string Location { get; set; } = null!;

        [Required]
        [StringLength(ValidationConstants.CaseSummaryMaxLength, 
        MinimumLength = ValidationConstants.CaseSummaryMinLength)]
        public string Summary { get; set; } = null!;

        [Required]
        [StringLength(ValidationConstants.CaseCrimeDescriptionMaxLength, 
        MinimumLength = ValidationConstants.CaseCrimeDescriptionMinLength)]
        public string CrimeDescription { get; set; } = null!;

        [Required]
        [StringLength(ValidationConstants.CaseInvestigationMaxLength, 
        MinimumLength = ValidationConstants.CaseInvestigationMinLength)]
        public string Investigation { get; set; } = null!;

        [Required]
        [StringLength(ValidationConstants.CaseEvidenceMaxLength, 
        MinimumLength = ValidationConstants.CaseEvidenceMinLength)]
        public string Evidence { get; set; } = null!;

        [Required]
        [StringLength(ValidationConstants.CaseSuspectsAndTheoriesMaxLength, 
        MinimumLength = ValidationConstants.CaseSuspectsAndTheoriesMinLength)]
        public string SuspectsAndTheories { get; set; } = null!;

        [StringLength(ValidationConstants.CaseImageUrlMaxLength)]
        public string? ImageUrl { get; set; }
    }
}
