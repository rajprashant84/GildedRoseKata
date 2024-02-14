using ApprovalUtilities.Persistence;
using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "TestItem", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("TestItem", Items[0].Name);
        }

        //Test to ensure All items have a SellIn value which denotes the number of days we have to sell the item

        [Test]
        public void UpdateQuality_When_AlItem_SellValueWhichDenoteNumberOfDaysWeHaveSellItem()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "TestItem", SellIn = 5, Quality = 10 } };
            var app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(4, Items[0].SellIn);
        }

        //Test  to ensure All items have a Quality value which denotes how valuable the item is
        [Test]
        public void UpdateQuality_When_AlItemQualityValueWhichDenoteHowValuabeItem()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "TestItem", SellIn = 5, Quality = 10 } };
            var app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(9, Items[0].Quality);
        }
        //At the end of each day, our system lowers both values for every item
        [Test]
        public void UpdateQuality_WhenEndOfEachDaysOurSystemLverBothValue()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "TestItem", SellIn = 5, Quality = 10 } };
            var app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(4, Items[0].SellIn);
            Assert.AreEqual(9, Items[0].Quality);
        }

        //Test To ensure Once the sell-by date has passed, Quality degrades twice as fast
        [Test]
        public void UpdateQuality_WhenSellDatePassedThenQualityDegradeTwice()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "TestItem", SellIn = 0, Quality = 10 } };
            var app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(8, Items[0].Quality);
        }
        // Test To Ensure The Quality of an item is never negative
        [Test]
        public void UpdateQuality_WhenQualityisNeverNegative()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "TestItem", SellIn = 0, Quality = 0 } };
            var app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.GreaterOrEqual(0, Items[0].Quality);
        }

        ///"Aged Brie" actually increases in Quality the older it gets
        
        [Test]
        public void UpdateQuality_WhenAgeBrieIncresseInQulaiyWhenGetOlder()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 11, Quality = 15 } };
            var app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(16, Items[0].Quality);
        }
        //Test To ensure thatThe Quality of an item is never more than 50
        [Test]
        public void UpdateQuality_WhenAgeBrieQualityNeverMoreThan50()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 11, Quality = 50 } };
            var app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(50, Items[0].Quality);
        }
        // "Sulfuras", being a legendary item, never has to be sold or decreases in Quality
        [Test]
        public void UpdateQuality_WhenSulfurasItemNeverSoldOrDecressesInQuality()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 11, Quality = 80 } };
            var app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(80, Items[0].Quality);
        }
        //"Backstage passes", like aged brie, increases in Quality as its SellIn value approaches;
       
        
        [Test]
        public void UpdateQuality_WhenBackstage_IncresseQualityWhenSelIncresse()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 20 } };
            var app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(21, Items[0].Quality);
        }
        // //Quality increases by 2 when there are 10 days
        [Test]
        public void UpdateQuality_WhenBackstage_QualityIncresseB2When10days()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20 } };
            var app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(22, Items[0].Quality);
        }

        ////Test to ensure less and by 3 when there are 5 days or 
       
        ///
        [Test]
        public void UpdateQuality_WhenBackstage_LessBy3in5Days()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20 } };
            var app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(23, Items[0].Quality);
        }
        // ///less but Quality drops to 0 after the concert
        [Test]
        public void UpdateQuality_WhenBackstage_LessDropQulityWhenSellIs0()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 } };
            var app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].Quality);
        }

    }
}
