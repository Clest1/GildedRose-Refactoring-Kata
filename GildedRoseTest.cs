using Xunit;
using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRoseTest
    {
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
            IList<Item> Items = new List<Item> { new Item { Name = "std item", SellIn = -1, Quality = 3 } };
            GildedRose app = new GildedRose(Items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(-2, Items[0].SellIn);
            Assert.Equal(1, Items[0].Quality);
        }
        [Fact]
        public void updateItemNormalPerrimePourris()
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "std item", SellIn = -1, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(-2, Items[0].SellIn);
            Assert.Equal(0, Items[0].Quality);
        }
        [Fact]
        public void updateItemSulfuras()
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 25 } };
            GildedRose app = new GildedRose(Items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(25, Items[0].Quality);
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
            Assert.Equal(2, Items[0].Quality);
        }
        [Fact]
        public void updateItemAgedBrieMax()
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 49 } };
            GildedRose app = new GildedRose(Items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(50, Items[0].Quality);
        }
        [Fact]
        public void updateItemAgedPerrime()
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 49 } };
            GildedRose app = new GildedRose(Items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(50, Items[0].Quality);
        }
        [Fact]
        public void updateItemBackstage()
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 25, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(2, Items[0].Quality);
        }
        [Fact]
        public void updateItemBackstageMax()
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 25, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(50, Items[0].Quality);
        }
        [Fact]
        public void updateItemBackstage11j()
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(3, Items[0].Quality);
        }
        [Fact]
        public void updateItemBackstage11jMax()
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 49 } };
            GildedRose app = new GildedRose(Items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(50, Items[0].Quality);
        }
        [Fact]
        public void updateItemBackstage6j()
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(4, Items[0].Quality);
        }
        [Fact]
        public void updateItemBackstage6jMax()
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 48 } };
            GildedRose app = new GildedRose(Items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(50, Items[0].Quality);
        }
        [Fact]
        public void updateItemBackstagePerrime()
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 25 } };
            GildedRose app = new GildedRose(Items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(0, Items[0].Quality);
        }
        [Fact]
        public void updateItemConjured()
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
        public void updateItemConjuredPerrime()
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "std item", SellIn = -1, Quality = 3 } };
            GildedRose app = new GildedRose(Items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(-2, Items[0].SellIn);
            Assert.Equal(1, Items[0].Quality);
        }
        [Fact]
        public void updateItemConjuredPerrimePourris()
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "std item", SellIn = -1, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(-2, Items[0].SellIn);
            Assert.Equal(0, Items[0].Quality);
        }
    }
}