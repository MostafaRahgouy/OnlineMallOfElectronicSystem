using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MallOfElectronics.Models.DataBase;

namespace MallOfElectronics.Models.Equal
{
    public class CheckEqualForPhoneSupport
    {
        public bool IsEqual(PhoneSupport previousPhoneSupport , PhoneSupport newPhoneSupport)
        {
            if (previousPhoneSupport == null || newPhoneSupport == null)
                return false;
            if (previousPhoneSupport.CompanyId != newPhoneSupport.CompanyId)
                return false;
            if (previousPhoneSupport.PhoneSupport1 != newPhoneSupport.PhoneSupport1)
                return false;
            return true;
        }
    }
}