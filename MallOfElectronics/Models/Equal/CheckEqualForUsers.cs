using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MallOfElectronics.Models.DataBase;

namespace MallOfElectronics.Models.Equal
{
    public class CheckEqualForUsers
    {
        public bool IsEqual(Person previousPerson , Person newPerson)
        {
            if(previousPerson == null || newPerson == null)
                return false;
            if(previousPerson.Email != newPerson.Email)
                return false;
            if(previousPerson.IdOfTheCategoryOfPersons != newPerson.IdOfTheCategoryOfPersons)
                return false;
            if(previousPerson.Name != newPerson.Name)
                return false;
            if(previousPerson.Password != newPerson.Password)
                return false;
            if(previousPerson.RegisteryDate != newPerson.RegisteryDate)
                return false;
            if(previousPerson.Sex != newPerson.Sex)
                return false;
            if(previousPerson.Image != newPerson.Image)
                return false;
            return true;
        }
    }
}