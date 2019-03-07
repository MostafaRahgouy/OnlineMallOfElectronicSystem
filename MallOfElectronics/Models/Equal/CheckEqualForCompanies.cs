using MallOfElectronics.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MallOfElectronics.Models.Equal
{
    public class CheckEqualForCompanies
    {
        public bool IsEqual(Company previousCompany , Company newCompany)
        {
            if(previousCompany == null || newCompany == null)
                return false;
            if(previousCompany.Name != newCompany.Name)
                return false;
            if (previousCompany.CompanyType != newCompany.CompanyType)
                return false;
            if (previousCompany.Description != newCompany.Description)
                return false;
            if (previousCompany.Email != newCompany.Email)
                return false;
            if (previousCompany.CompanyCategory != newCompany.CompanyCategory)
                return false;
            if (previousCompany.CompanyIDCategories != newCompany.CompanyIDCategories)
                return false;
            return true;
        }
    }
}