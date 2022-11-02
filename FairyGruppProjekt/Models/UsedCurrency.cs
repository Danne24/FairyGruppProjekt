using System.ComponentModel.DataAnnotations;

namespace FairyGruppProjekt.Models
{
    public class UsedCurrency
    {
        [Key]
        public int TempKey { get; set; }
        public decimal CurValue { get; set; }
        public string CurName { get; set; }
    }
}
