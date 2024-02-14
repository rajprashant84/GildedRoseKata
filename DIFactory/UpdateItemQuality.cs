using csharp.Interface;
using csharp.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.DIFactory
{
    public class UpdateItemQuality
    {
        public static IUpdateItemQuality GetItemUpdateName(Item Items)
        {
            switch (Items.Name)
            {
                case "Aged Brie":
                    return new AgedBrieItemUpdate();
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackstageItemUpdate();
                case "Sulfuras, Hand of Ragnaros":
                    return new SulfurasItemUpdate();
                default:
                    return new NormaltItemUpdate();
            }
        }
    }
}
