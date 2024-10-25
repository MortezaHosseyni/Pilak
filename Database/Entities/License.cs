using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pilak.Database.Entities
{
    public class License : BaseEntity
    {
        [Required] public required int FirstDigitSection { get; set; }
        [Required][MaxLength(50)] public required string? LetterSection { get; set; }
        [Required] public required int SecondDigitSection { get; set; }
        [Required] public required int CityCode { get; set; }

        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        #region Relations
        public required Guid PersonId { get; set; }
        [ForeignKey(nameof(PersonId))] public virtual Person? Person { get; set; }
        #endregion

        public string PersonName => $"{Person!.FirstName} {Person.LastName} ({Person.NationalCode})";

    }
}
