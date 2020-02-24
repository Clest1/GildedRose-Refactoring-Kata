using System.Collections.Generic;

namespace csharpcore
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
            for (var i = 0; i < Items.Count; i++)
            {
                var usureMult = 1;
                if (Items[i].Name.StartsWith("Conjured"))
                {
                    usureMult = 2;
                }
                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Items[i].Quality > 0 && Items[i].Name != "Sulfuras, Hand of Ragnaros")
                    {
                        Items[i].Quality = Items[i].Quality - 1*usureMult;
                    }
                }
                else
                {
                    Items[i].Quality = Items[i].Quality + 1;

                    if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (Items[i].SellIn < 11)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                        if (Items[i].SellIn < 6)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                    }
                }
                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }
                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name == "Aged Brie")
                    {
                        Items[i].Quality = Items[i].Quality + 1;
                    }
                    else if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        Items[i].Quality = 0;
                    }
                    else
                    {
                        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            Items[i].Quality = Items[i].Quality - 1 * usureMult;
                        }
                    }
                }
                if (Items[i].Name == "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].Quality = 80;
                }
                else if(Items[i].Quality > 50)
                {
                    Items[i].Quality = 50;
                }
                else if (Items[i].Quality < 0)
                {
                    Items[i].Quality = 0;
                }
            }
        }
    }
}
