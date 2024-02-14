using csharp.DIFactory;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var Items in Items)
            {
                var UpdateItem = UpdateItemQuality.GetItemUpdateName(Items);
                UpdateItem.UpdateQuality(Items);
            }
        }
    }
}
