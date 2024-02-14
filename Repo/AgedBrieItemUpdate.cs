using csharp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Repo
{
    public class AgedBrieItemUpdate : IUpdateItemQuality
    {
        public void UpdateQuality(Item Items)
        {
            //Aged Brie
            if (Items.Quality < 50)
            {
                Items.Quality = Items.Quality + 1;
            }

            if (Items.Quality < 50 && Items.SellIn < 0)
            {
                Items.Quality = Items.Quality + 1;
            }
        }
    }
}
