using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EquipmentManagement.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "學生信箱")]
        [EmailAddress, StringLength(100)]
        [Required]
        public string Stu_mail { get; set; }

        [Display(Name = "手機號碼"), StringLength(20, MinimumLength = 10)]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "姓名"), StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }

        [Display(Name = "聯絡信箱")]
        [EmailAddress, StringLength(100)]
        public string Hot_mail { get; set; }

        [Required]
        [Display(Name = "身份"), StringLength(10)]
        public string Identity { get; set; }

        [Display(Name = "已繳社費")]
        public bool Member_fee { get; set; }

        [Display(Name = "建立時間"), DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreateDate { get; set; }

        [NotMapped]
        [Display(Name = "密碼"), StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }

    }
}
