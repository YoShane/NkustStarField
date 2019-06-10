using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EquipmentManagement.Models
{
    public class BorrowRecord
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "訂單編號")]
        public int Order_id { get; set; }

        [Display(Name = "器材編號")]
        public int? Item_id { get; set; } //允許null

        [Display(Name = "租借數量")]
        public int Quantuty { get; set; }

        [Display(Name = "小計價格")]
        public int Price { get; set; }

        [Display(Name = "備註")]
        public string Remark { get; set; }

        [ForeignKey("Order_id")]
        public virtual BorrowOrder BorrowOrder { get; set; } //存在訂單才存在(連鎖反應) 

        [ForeignKey("Item_id")]
        public virtual Equipment Equipment { get; set; }  //存在裝備才存在 (Null) 
    }
}
