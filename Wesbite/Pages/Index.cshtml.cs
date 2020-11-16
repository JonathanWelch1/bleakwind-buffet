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
        /// <summary>
        /// Collection of all the menu items
        /// </summary>
        public IEnumerable<IOrderItem> MenuItems { get; set; }

        /// <summary>
        /// the search term
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// Gets the type of menu
        /// </summary>

        public string[] MenuType { get; set; }

        /// <summary>
        /// gets and sets the CalMax
        /// </summary>
        public int? CalMax { get; set; }
        /// <summary>
        /// gets and sets the CalMin
        /// </summary>
        public int? CalMin { get; set; }
        /// <summary>
        /// gets and sets the Price min
        /// </summary>
        public double? PriceMin { get; set; }
        /// <summary>
        /// gets and sets the pricemax
        /// </summary>
        public double? PriceMax { get; set; }

        /// <summary>
        /// On get method 
        /// </summary>
        /// <param name="CalMin"></param>
        /// <param name="CalMax"></param>
        /// <param name="PriceMin"></param>
        /// <param name="PriceMax"></param>
        public void OnGet(string SearchTerms, string[] MenuType, int? CalMin, int? CalMax, double? PriceMin, double? PriceMax)
        {
            MenuItems = Menu.All;
            this.SearchTerms = SearchTerms;
            this.MenuType = MenuType;
            this.CalMax = CalMax;
            this.CalMin = CalMin;
            this.PriceMax = PriceMax;
            this.PriceMin = PriceMin;
            /*  MenuItems = Menu.Search(SearchTerms);
              MenuItems = Menu.FilterByType(MenuType, MenuItems);
              MenuItems = Menu.Calories(MenuItems, CalMin, CalMax);
              MenuItems = Menu.Price(MenuItems, PriceMin, PriceMax); */

            if (SearchTerms != null)
            {
                IEnumerable<IOrderItem> search = new List<IOrderItem>();
                List<IOrderItem> temp = new List<IOrderItem>();
                string[] t = SearchTerms.Split(" ");
                foreach(string s in t)
                {
                    search = MenuItems.Where(item => item.ToString() != null && item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase) || item.Description.Contains(s, StringComparison.InvariantCultureIgnoreCase));
                    temp.AddRange(search.ToList());
                }
                MenuItems = temp;
            }

            if(CalMin != null)
            {
                MenuItems = MenuItems.Where(item => item.Calories <= CalMax);
            }

            if (CalMax != null)
            {
                MenuItems = MenuItems.Where(item => item.Calories >= CalMin);
            }

            if (CalMin != null && CalMax != null)
            {
                MenuItems = MenuItems.Where(item => item.Calories <= CalMax && item.Calories >= CalMin);
            }


            if (PriceMin != null)
            {
                MenuItems = MenuItems.Where(item => item.Calories <= PriceMax);
            }

            if (PriceMax != null)
            {
                MenuItems = MenuItems.Where(item => item.Calories >= PriceMin);
            }

            if (PriceMin != null && PriceMax != null)
            {
                MenuItems = MenuItems.Where(item => item.Calories <= PriceMax && item.Calories >= PriceMin);
            }

            if(MenuType != null && MenuType.Length != 0)
            {
                MenuItems = MenuItems.Where(Item => (Item is Entree && MenuType.Contains("Entrees")) || (Item is Drink && MenuType.Contains("Drinks")) || (Item is Side && MenuType.Contains("Sides")));
            }
        }

        
    }
}
