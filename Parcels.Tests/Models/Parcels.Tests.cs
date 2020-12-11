using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Parcels.Models;
using System;

namespace Parcels.Tests
{
    [TestClass]
    public class ParcelsTests
    {
        [TestMethod]
        public void Parcel_Volume_CostToShip()
        {
            Parcel newParcel = new Parcel(12, 12, 12);
            Assert.AreEqual(576, newParcel.CostToShip());
        }

        [TestMethod]
        public void Parcel_CostToShip()
        {
            Parcel newParcel = new Parcel(24, 24, 24);
            Assert.AreEqual(4608, newParcel.CostToShip());
        }

        [TestMethod]
        public void Parcel_CostToShipPackage()
        {
            Parcel newParcel = new Parcel(6, 9, 18);
            Assert.AreEqual(324, newParcel.CostToShip());
        }
    }
}