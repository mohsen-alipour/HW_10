
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW_10.Models
{
    public class Library
    {
        public int ID { get; set; }
        [Display(Name = "نام کتابخانه")]
        public string LibraryName { get; set; }
        public string LibraryAddress { get; set; }
        public ICollection<Book>? Books { get; set; }


        public int cityId { get; set; }

        [Display(Name = "شهر")]
        public City City { get; set; }

        public ICollection<Member>? Members { get; set; }

    }
}
