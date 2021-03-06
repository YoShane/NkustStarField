﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EquipmentManagement.Models
{
    public class BorrowOrder
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "學生信箱")]
        [EmailAddress, StringLength(100)]
        public string Stu_mail { get; set; }

        [Display(Name = "租借時間"), DataType(DataType.Date)]
        public DateTime Borrow_time { get; set; }
       
        [Display(Name = "歸還期限"), DataType(DataType.Date)]
        public DateTime Restore_time { get; set; }

        [Display(Name = "已還裝備")]
        public bool Restore_state { get; set; }

        [Display(Name = "備註")]
        public string Remark { get; set; }

        [NotMapped]
        public List<BorrowRecord> BorrowRecords { get; set; }

        [NotMapped]
        public Member Member { get; set; }

    }
}
