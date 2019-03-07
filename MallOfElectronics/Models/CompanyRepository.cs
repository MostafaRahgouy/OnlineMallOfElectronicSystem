using MallOfElectronics.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MallOfElectronics.Models.Repository
{
    public class CompanyRepository
    {
        private MallOfElectronicsEntities db = null;
        public CompanyRepository()
        {
            db = new MallOfElectronicsEntities();
        }
    }
}