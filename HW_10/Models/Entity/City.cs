using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW_10.Models
{
    public class City
    {
        public int ID { get; set; }
        [Display(Name = "نام شهر")]
        public string CityName { get; set; }


        [ForeignKey("Library")]
        public int libraryId { get; set; }

        [Display(Name = "کتابخانه")]
        public Library Library { get; set; }
    }
}
