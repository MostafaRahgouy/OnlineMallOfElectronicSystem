using MallOfElectronics.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MallOfElectronics.Models.Equal
{
    public class CheckEqualForProducts
    {
        public bool IsEqual(Product PreviousProduct , Product NewProduct)
        {
            if (PreviousProduct == null || NewProduct == null)
                return false;
            if(PreviousProduct.Company != NewProduct.Company)
            return false;
            if (PreviousProduct.Count != NewProduct.Count)
                return false;
            if (PreviousProduct.CompanyId != NewProduct.CompanyId)
                return false;
            if (PreviousProduct.Description != NewProduct.Description)
                return false;
            if (PreviousProduct.IdOfCategoryFeatures != NewProduct.IdOfCategoryFeatures)
                return false;
            if (PreviousProduct.MemorySize != NewProduct.MemorySize)
                return false;
            if (PreviousProduct.Name != NewProduct.Name)
                return false;
            if (PreviousProduct.PrecisionCamera != NewProduct.PrecisionCamera)
                return false;
            if (PreviousProduct.Price != NewProduct.Price)
                return false;
            if (PreviousProduct.ScreenSize != NewProduct.ScreenSize)
                return false;
            if (PreviousProduct.ProductType != NewProduct.ProductType)
                return false;
            if (PreviousProduct.Weight != NewProduct.Weight)
                return false;
            if (PreviousProduct.Image != NewProduct.Image)
                return false;
            if (PreviousProduct.Color != NewProduct.Color)
                return false;
            if (PreviousProduct.Brand != NewProduct.Brand)
                return false;
            return true;
        }
    }
}