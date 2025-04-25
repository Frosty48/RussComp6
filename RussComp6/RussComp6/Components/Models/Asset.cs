using System.ComponentModel.DataAnnotations;

namespace RussComp6.Components.Models
{
    public class Asset
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Asset Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Entry Date is required.")]
        public DateTime EntryDate { get; set; }

        [Required(ErrorMessage = "Exit Date is required.")]
        public DateTime ExitDate { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Starting Value must be a positive number.")]
        public double StartingValue { get; set; }


        [Range(0, double.MaxValue, ErrorMessage = "Salvage Value must be a positive number.")]
        public double SalvageValue { get; set; }
    }
}
