using csharp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Repo
{
    public class BackstageItemUpdate : IUpdateItemQuality
    {
        public void UpdateQuality(Item Items)
        {
            //Backstage
            if (Items.Quality < 50)
            {
                Items.Quality = Items.Quality + 1;
            }

            if (Items.SellIn < 11)
            {
                Items.Quality = Items.Quality + 1;
            }

            if (Items.SellIn < 6)
            {
                Items.Quality = Items.Quality + 1;
            }
            if (Items.SellIn <= 0)
            {
                Items.Quality = Items.Quality - Items.Quality;
            }
        }
    }
}
