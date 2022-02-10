using System.Collections.Generic;
using LNStone.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace LNStone_Tests
{
    [TestClass]
    public class UnitTest
    {

        [TestMethod]
        public void ObjStoneList_Add()
        {
            //Arrange 
            List<StoneDTO> ObjStoneList = new List<StoneDTO>();

            //ACT
            ObjStoneList.Add(new StoneDTO
            {
                Id = 1,
                StoneName = "StoneExample",
                DiameterOfStone = 6,
                CordPrice = 22.22,
                AmountOfStone = 12,
                PricePerStone = 1.83,
                Store = "Other",
                Faceting = "Yes"
            });

            //Assert
            Assert.IsNotNull(ObjStoneList);
        }
    }
}
