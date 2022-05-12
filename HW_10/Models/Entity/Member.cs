using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using HW_10.Models.Enum;
namespace HW_10.Models
{
    public class Member
    {
       
        public int ID { get; set; }

        [Display(Name = "نام")]
        public string Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        public string Family { get; set; }

        [Display(Name = "تاریخ ثبت")]
        public DateTime Date_sabt { get; set; }

        [Display(Name = "تاریخ تولد")]
        public DateTime Date_birthday { get; set; }

        [Display(Name = "کد ملی")]
        public int Codemeli { get; set; }

        [Display(Name = "نوع عضویت")]
        public MembershipEnum Typemember { get; set; }

        [Display(Name = "شماره تماس")]
        public string Tel { get; set; }

        [Display(Name = "جنسیت")]
        public GenderEnum Gender { get; set; }

        [Display(Name = "کتابهای امانی")]
        public ICollection<Book>? Books { get; set; }

        //public int libraryId { get; set; }

        //[Display(Name = "کتابخانه")]
        //public Library library { get; set; }
    }
}
