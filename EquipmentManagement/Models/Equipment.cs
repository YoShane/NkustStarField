using System;
using System.ComponentModel.DataAnnotations;

namespace EquipmentManagement.Models
{
    public class Equipment
    {
        [Display(Name = "器材編號")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "器材照片")]
        public string Img { get; set; }

        [Required]
        [Display(Name = "器材名稱"), StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "器材數量")]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "租金")]
        public int Pirce_non_member { get; set; }

        [Display(Name = "優惠租金")]
        public int Price_member { get; set; }

        [Display(Name = "器材來源")]
        public string Source { get; set; }

        [Display(Name = "技術性工具")]
        public bool Special { get; set; }

        [Display(Name = "使用期限"), DataType(DataType.Date)]
        public DateTime Period_time { get; set; }

        [Display(Name = "位置代號")]
        public string Location { get; set; }
    }
}
