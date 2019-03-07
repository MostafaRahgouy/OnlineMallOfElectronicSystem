using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MallOfElectronics.Models.DataBase;

namespace MallOfElectronics.Models.Equal
{
    public class CheckEqualForBuying
    {
        public bool IsEqual(Buy previousBuy , Buy newBuy)
        {
            if (previousBuy == null || newBuy == null)
                return false;
            if (previousBuy.TrackingCode != newBuy.TrackingCode)
                return false;
            if (previousBuy.Year != newBuy.Year)
                return false;
            if (previousBuy.Month != newBuy.Month)
                return false;
            if (previousBuy.Day != newBuy.Day)
                return false;
            if (previousBuy.CustomerID != newBuy.CustomerID)
                return false;
            if (previousBuy.CardNumber != newBuy.CardNumber)
                return false;
            return true;
        }
    }
}