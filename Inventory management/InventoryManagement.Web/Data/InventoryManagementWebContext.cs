using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InventoryManagement.BLL.Entities;

namespace InventoryManagement.Web.Models
{
    public class InventoryManagementWebContext : DbContext
    {
        public InventoryManagementWebContext (DbContextOptions<InventoryManagementWebContext> options)
            : base(options)
        {
        }

        public DbSet<InventoryManagement.BLL.Entities.Item> Item { get; set; }
    }
}
