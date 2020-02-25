using Xunit;
using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRoseTest
    {
        [Fact]
        public void UpdateItemNormal()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "std item", SellIn = 1, Quality = 2 } };
            GildedRose app = new GildedRose(items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(0, items[0].SellIn);
            Assert.Equal(1, items[0].Quality);
        }
        [Fact]
        public void UpdateItemNormalExpired()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "std item", SellIn = -1, Quality = 3 } };
            GildedRose app = new GildedRose(items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(-2, items[0].SellIn);
            Assert.Equal(1, items[0].Quality);
        }
        [Fact]
        public void UpdateItemNormalExpiredAndRotten()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "std item", SellIn = -1, Quality = 0 } };
            GildedRose app = new GildedRose(items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(-2, items[0].SellIn);
            Assert.Equal(0, items[0].Quality);
        }
        [Fact]
        public void UpdateItemSulfuras()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } };
            GildedRose app = new GildedRose(items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(80, items[0].Quality);
        }
        [Fact]
        public void UpdateItemAgedBrie()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 1 } };
            GildedRose app = new GildedRose(items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(2, items[0].Quality);
        }
        [Fact]
        public void UpdateItemAgedBrieMax()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 49 } };
            GildedRose app = new GildedRose(items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(50, items[0].Quality);
        }
        [Fact]
        public void UpdateItemAgedExpired()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 47 } };
            GildedRose app = new GildedRose(items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(49, items[0].Quality);
        }
        [Fact]
        public void UpdateItemBackstage()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 25, Quality = 1 } };
            GildedRose app = new GildedRose(items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(2, items[0].Quality);
        }
        [Fact]
        public void UpdateItemBackstageMax()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 25, Quality = 50 } };
            GildedRose app = new GildedRose(items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(50, items[0].Quality);
        }
        [Fact]
        public void UpdateItemBackstage11J()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 1 } };
            GildedRose app = new GildedRose(items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(3, items[0].Quality);
        }
        [Fact]
        public void UpdateItemBackstage11JMax()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 49 } };
            GildedRose app = new GildedRose(items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(50, items[0].Quality);
        }
        [Fact]
        public void UpdateItemBackstage6J()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 1 } };
            GildedRose app = new GildedRose(items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(4, items[0].Quality);
        }
        [Fact]
        public void UpdateItemBackstage6JMax()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 48 } };
            GildedRose app = new GildedRose(items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(50, items[0].Quality);
        }
        [Fact]
        public void UpdateItemBackstageExpired()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 25 } };
            GildedRose app = new GildedRose(items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(0, items[0].Quality);
        }
        [Fact]
        public void UpdateItemConjured()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "Conjured std item", SellIn = 1, Quality = 3 } };
            GildedRose app = new GildedRose(items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(0, items[0].SellIn);
            Assert.Equal(1, items[0].Quality);
        }

        [Fact]
        public void UpdateItemConjuredExpired()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "Conjured std item", SellIn = -1, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(-2, items[0].SellIn);
            Assert.Equal(1, items[0].Quality);
        }

        [Fact]
        public void UpdateItemConjuredExpiredAndRotten()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "Conjured std item", SellIn = -1, Quality = 1 } };
            GildedRose app = new GildedRose(items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(-2, items[0].SellIn);
            Assert.Equal(0, items[0].Quality);
        }
    }
}