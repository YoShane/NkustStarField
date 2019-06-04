using System;
using System.ComponentModel.DataAnnotations;


namespace EquipmentManagement.Models
{
    public class Member
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "學生信箱")]
        public string Stu_mail { get; set; }

        [Required]
        [Display(Name = "手機號碼"), StringLength(10, MinimumLength = 10)]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "姓名"), StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }

        [Display(Name = "身份")]
        public string Identity { get; set; }

        [Display(Name = "已繳社費")]
        public bool Member_fee { get; set; }

        [Display(Name = "建立時間"), DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

    }
}
