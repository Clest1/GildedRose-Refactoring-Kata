using System;
using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRose
    {
        IList<Item> _items;
        public GildedRose(IList<Item> items)
        {
            this._items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                if (item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    item.Quality = Math.Clamp(item.Quality, 0, 50);
                    item.SellIn--;
                }
                var usureMult = (item.Name.StartsWith("Conjured") ? 2 : 1);
                var sellMult = (item.SellIn < 0 ? 2 : 1);
                switch (item.Name)
                {
                    case "Aged Brie":
                        item.Quality += sellMult;
                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        if (item.SellIn < 0) item.Quality = 0;
                        else
                        {
                            item.Quality++;
                            if (item.SellIn < 11) item.Quality++;
                            if (item.SellIn < 6) item.Quality++;
                        }
                        break;
                    case "Sulfuras, Hand of Ragnaros":
                        // does absolutely nothing and dies
                        break;
                    default:
                        item.Quality -= usureMult * sellMult;
                        break;
                }
                if (item.Name == "Sulfuras, Hand of Ragnaros") item.Quality = 80;
                else item.Quality = Math.Clamp(item.Quality, 0, 50);
            }
        }
    }
}
