using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EquipmentManagement.Models
{
    public class Equipment
    {
        [Key]
        [Display(Name = "器材編號")]
        public int Id { get; set; }

        [Display(Name = "器材照片")]
        public byte[] Img { get; set; }

        [Required]
        [Display(Name = "器材名稱"), StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        [Range(1, Int64.MaxValue, ErrorMessage = "數量格式不合法")]
        [Display(Name = "總數")]
        public int Quantity { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "租金")]
        public int Price_non_member { get; set; }

        [Display(Name = "優惠租金")]
        [DataType(DataType.Currency)]
        public int Price_member { get; set; }

        [Display(Name = "器材來源"), StringLength(30, MinimumLength = 2)]
        public string Source { get; set; }

        [Display(Name = "此為技術性工具")]
        public bool Special { get; set; }

        [Display(Name = "期限"), DataType(DataType.Date)]
        public DateTime Period_time { get; set; }

        [Required]
        [Display(Name = "位置代號"), StringLength(10, MinimumLength = 1)]
        public string Location_code { get; set; }
        
        [ForeignKey("Location_code")]
        public virtual Location Location { get; set; } //導覽至位置名稱(限制性)

        //額外
        [NotMapped]
        public List<string> List { get; set; }
        [NotMapped]
        public List<string> ListValue { get; set; }

        [NotMapped]
        [Display(Name = "剩餘")]
        public int Surplus { get; set; }
    }
}
