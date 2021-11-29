using System.IO;
using System.Text;
using Scanner;
using System;
using System.Collections.Generic;
using NorthwindContextLib;
using System.Linq;
using NorthwindEntitiesLib;

namespace Scanner
{
    public interface IFileManager
    {                
        Product GetProductById(int productId);        
        bool QuantityAdd(short? add, int productId);
    }
    public class FileManager : IFileManager
    {
        readonly Northwind db = new Northwind();        
        public bool QuantityAdd(short? add, int productId)
        {
            Product addUnitsInStock = GetProductById(productId);
            addUnitsInStock.UnitsInStock += add;
            int affected = db.SaveChanges();
            return (affected == 1);
        }
        public Product GetProductById(int productId)
        {
            Product productName = db.Products.Where(c => c.ProductID == productId).FirstOrDefault();
            return productName;
        }
    }
}