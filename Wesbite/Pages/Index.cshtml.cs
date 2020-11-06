using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;

namespace Wesbite.Pages
{
    public class IndexModel : PageModel
    {

        public IEnumerable<IOrderItem> MenuItems { get; set; }

        public string SearchTerms { get; set; }

        public void OnGet(int? CalMin, int? CalMax, double? PriceMin, double)
        {
            MenuItems = Menu.Search(SearchTerms);
        }
    }
}
