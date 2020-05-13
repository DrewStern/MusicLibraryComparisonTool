﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MediaLibraryCompareTool.UnitTests
{
    [TestClass]
    public class MetalArchivesServiceProviderTests
    {
        private MetalArchivesServiceProvider _metalArchivesService = new MetalArchivesServiceProvider();

        [TestMethod]
        public void TestRequestMayNotBeNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => _metalArchivesService.Submit(null));
        }
    }
}