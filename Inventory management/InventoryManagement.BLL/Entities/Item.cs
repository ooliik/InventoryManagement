using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement.BLL.Entities
{
   public class Item
    {
        public string ItemID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CategoryID { get; set; }

    }
}
