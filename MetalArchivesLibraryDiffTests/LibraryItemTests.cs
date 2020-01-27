﻿using MetalArchivesLibraryDiffTool;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MetalArchivesLibraryDiffTests
{
    [TestClass]
    public class LibraryItemTests
    {
        //[TestMethod]
        //[ExpectedException(typeof())]
        //public void TestCantNullInitialize()
        //{
        //    var libraryItem = new LibraryItem(
        //        new ArtistData(null),
        //        new ReleaseData(null));

        //    libraryItem.ToString();
        //}

        [TestMethod]
        public void TestEquality()
        {
            var libraryItem1 = new LibraryItem(
                new ArtistData("artistName"),
                new ReleaseData("releaseName"));

            var libraryItem2 = new LibraryItem(
                new ArtistData("artistName"),
                new ReleaseData("releaseName"));

            Assert.IsTrue(libraryItem1.Equals(libraryItem2));
        }

        [TestMethod]
        public void TestNonEquality()
        {
            var libraryItem1 = new LibraryItem(
                new ArtistData("artistName1"),
                new ReleaseData("releaseName1"));

            var libraryItem2 = new LibraryItem(
                new ArtistData("artistName2"),
                new ReleaseData("releaseName2"));

            Assert.IsFalse(libraryItem1.Equals(libraryItem2));
        }

        [TestMethod]
        public void TestLibraryItemToString()
        {
            var libraryItem = new LibraryItem(
                new ArtistData("artistName", "unknownCountry"),
                new ReleaseData("releaseName", "demo"));

            var expected = "artistName (unknownCountry) - releaseName (demo)";
            var actual = libraryItem.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLibraryItemToString_NoReleaseType()
        {
            var libraryItem = new LibraryItem(
                new ArtistData("artistName", "unknownCountry"),
                new ReleaseData("releaseName"));

            var expected = "artistName (unknownCountry) - releaseName";
            var actual = libraryItem.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLibraryItemToString_NoCountry()
        {
            var libraryItem = new LibraryItem(
                new ArtistData("artistName"),
                new ReleaseData("releaseName", "split"));

            var expected = "artistName - releaseName (split)";
            var actual = libraryItem.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLibraryItemToString_NoReleaseType_NoCountry()
        {
            var libraryItem = new LibraryItem(
                new ArtistData("artistName"),
                new ReleaseData("releaseName"));

            var expected = "artistName - releaseName";
            var actual = libraryItem.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}