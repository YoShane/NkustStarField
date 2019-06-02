using System;
using System.ComponentModel.DataAnnotations;


namespace EquipmentManagement.Models
{
    public class Member
    {
        public int Id { get; set; }

        [Display(Name = "學生證號碼")]
        public string Stu_id { get; set; }

        [Display(Name = "手機號碼"), StringLength(10, MinimumLength = 10)]
        public string Phone { get; set; }

        [Display(Name = "姓名"), StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }

        [Display(Name = "密碼")]
        public string Password { get; set; }

        [Display(Name = "身份")]
        public string Identity { get; set; }

        [Display(Name = "已繳社費")]
        public int Member_fee { get; set; }

        [Display(Name = "建立時間"), DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

    }
}
