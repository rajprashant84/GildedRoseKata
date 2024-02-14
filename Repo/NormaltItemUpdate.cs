using csharp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Repo
{
    public class NormaltItemUpdate : IUpdateItemQuality
    {
        public void UpdateQuality(Item Items)
        {
            //Default
            Items.SellIn--;
            if (Items.Quality > 0)
            {
                Items.Quality = Items.Quality - 1;
            }

            if (Items.Quality > 0 && Items.SellIn < 0)
            {
                Items.Quality = Items.Quality - 1;
            }
        }
    }
}
