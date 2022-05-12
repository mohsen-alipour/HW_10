using System.ComponentModel.DataAnnotations;
namespace HW_10.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "نام کتاب")]
        public string  BookName { get; set; }

        //public int libraryId { get; set; }
        //[Display(Name = "کتابخانه")]
        //public Library library { get; set; }

        //public int memberId { get; set; }
        //[Display(Name = "شخص")]
        //public Member Member { get; set; }
    }
}
