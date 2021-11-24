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
        bool IsExist(int productId);
        int ProductId(string lblProductId);
        Product GetProductById(int productId);        
        bool QuantityAdd(short? add, int productId);
    }
    public class FileManager : IFileManager
    {
        readonly Northwind db = new Northwind();
        public IEnumerable<Product> Products { get; set; }
        public bool QuantityAdd(short? add, int productId)
        {
            Product addUnitsInStock = GetProductById(productId);
            addUnitsInStock.UnitsInStock += add;
            int affected = db.SaveChanges();
            return (affected == 1);
        }
        public bool IsExist(int productId)
        {
            int result = db.Products.Where(w => w.ProductID == productId).Select(s => s.ProductID).FirstOrDefault();
            bool isExist = result != 0;
            return isExist;
        }
        public int ProductId(string lblProductId)
        {
            int productId = Int32.Parse(lblProductId);
            return productId;
        }

        public Product GetProductById(int productId)
        {
            Product productName = db.Products.Where(c => c.ProductID == productId).FirstOrDefault();
            return productName;
        }
    }
}