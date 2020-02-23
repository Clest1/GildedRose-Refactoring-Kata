using Xunit;
using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRoseTest
    {
        [Fact]
        public void foo()
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal("fixme", Items[0].Name);
        }

        [Fact]
        public void updateItemNormal()
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "std item", SellIn = 1, Quality = 2 } };
            GildedRose app = new GildedRose(Items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(0, Items[0].SellIn);
            Assert.Equal(1, Items[0].Quality);
        }
        [Fact]
        public void updateItemNormalPerrime()
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "std item", SellIn = -1, Quality = 2 } };
            GildedRose app = new GildedRose(Items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(0, Items[0].SellIn);
            Assert.Equal(0, Items[0].Quality);
        }
        [Fact]
        public void updateItemAgedBrie()
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(0, Items[0].SellIn);
            Assert.Equal(2, Items[0].Quality);
        }
        [Fact]
        public void updateItemAgedBrieMax()
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(0, Items[0].SellIn);
            Assert.Equal(50, Items[0].Quality);
        }
        [Fact]
        public void updateItemAgedPerrime()
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(0, Items[0].SellIn);
            Assert.Equal(50, Items[0].Quality);
        }
        [Fact]
        public void updateItemTAFKAL80ETC()
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(0, Items[0].SellIn);
            Assert.Equal(2, Items[0].Quality);
        }
        [Fact]
        public void updateItemAgedBrie()
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(0, Items[0].SellIn);
            Assert.Equal(2, Items[0].Quality);
        }
        [Fact]
        public void updateItemAgedBrie()
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(0, Items[0].SellIn);
            Assert.Equal(2, Items[0].Quality);
        }
    }
}