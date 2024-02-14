using csharp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Repo
{
    public class SulfurasItemUpdate : IUpdateItemQuality
    {
        public void UpdateQuality(Item Items)
        {
            //"Sulfuras", being a legendary item, never has to be sold or decreases in Quality
            //Below Comments does not impac on UpdateQuality 

            //if (Items.Name != "Sulfuras, Hand of Ragnaros")
            //{
            //    Items.SellIn = Items.SellIn - 1;
            //}

        }
    }
}
