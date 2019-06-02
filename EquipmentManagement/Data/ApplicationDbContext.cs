using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EquipmentManagement.Models;

namespace EquipmentManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EquipmentManagement.Models.Equipment> Equipment { get; set; }
        public DbSet<EquipmentManagement.Models.Member> Member { get; set; }
        public DbSet<EquipmentManagement.Models.Location> Location { get; set; }
        public DbSet<EquipmentManagement.Models.BorrowOrder> BorrowOrder { get; set; }
    }
}
