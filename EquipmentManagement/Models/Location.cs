using System.ComponentModel.DataAnnotations;

namespace EquipmentManagement.Models
{
    public class Location
    {
        public int Id { get; set; }

        [Display(Name = "位置代號")]
        public string Code { get; set; }

        [Display(Name = "位置名稱")]
        public string Name { get; set; }
    }
}
