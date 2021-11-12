using MiNET;

using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardFootCalculator
{
    public class WoodRepository
    {
        private List<Wood> _inventory;
        
        public WoodRepository()
        {
            _inventory.Add(item: new Wood { Id = 0, type = "Walnut", cost = 9.55 });
            _inventory.Add(item: new Wood { Id = 1, type = "Maple", cost = 8.15 });
            _inventory.Add(item: new Wood { Id = 2, type = "Amrosia Maple", cost = 9.55 });
            _inventory.Add(item: new Wood { Id = 3, type = "Beech", cost = 6.25 });
            _inventory.Add(item: new Wood { Id = 4, type = "Spalted Maple", cost = 8.35 });
            _inventory.Add(item: new Wood { Id = 5, type = "Red Oak", cost = 5.15 });
            _inventory.Add(item: new Wood { Id = 6, type = "Pecan", cost = 11.05 });
            _inventory.Add(item: new Wood { Id = 7, type = "Ash", cost = 5.05 });
            _inventory.Add(item: new Wood { Id = 8, type = "Cedar", cost = 4.25 });
            _inventory.Add(item: new Wood { Id = 9, type = "White Oak", cost = 7.05 });
        }

        
    }
}