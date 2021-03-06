﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EquipmentManagement.Models
{
    public class Location
    {

        [Key]
        [Display(Name = "位置代碼")]
        [StringLength(10, MinimumLength = 1),RegularExpression(@"^[a-zA-Z0-9""'\s-]*$",ErrorMessage ="僅允許輸入英數組合")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Location_code { get; set; }

        [Display(Name = "位置名稱"), StringLength(50,MinimumLength =1)]
        public string Name { get; set; }

        public virtual ICollection<Equipment> Equipment { get; set; } //導覽至本位置有的器材
    }
}
