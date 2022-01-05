using System.IO;
using System.Text;
using Scanner;
using System;
using System.Collections.Generic;
using NorthwindContextLib;
using System.Linq;
using NorthwindEntitiesLib;
using Cryptography;
using System.Xml.Serialization;
using System.Data;
using System.Data.SqlClient;

namespace Scanner
{
    public interface IFileManager
    {                
        Product GetProductById(int productId);        
        bool QuantityAdd(short? add, Product product);
        bool QuantityDelete(short? delete, Product product);
        void CreateNewDelivery();
        bool ProductDataAddDelivery(Product product, short? add);
        bool ProductDataDeleteDelivery(Product product, short? delete);
        DataTable CurrentInvoice();       
    }

    public class FileManager : IFileManager
    {        
        readonly Northwind db = new Northwind();
        public int CurrentDelivery;
        private SqlDataAdapter adapter = null;
        private DataTable table = null;
        public Product GetProductById(int productId)
        {
            Product productName = db.Products.Where(c => c.ProductID == productId).FirstOrDefault();
            return productName;
        }
        public DataTable CurrentInvoice()
        {                  
            adapter = new SqlDataAdapter("SELECT DeliveryProduct, DeliveryProductPrice, DeliveryProductQuantity " +
            "FROM Delivery " +
            "WHERE DeliveryCurrentNumber = " + CurrentDelivery + "", @"Data Source=(localdb)\mssqllocaldb;" +
            "Initial Catalog=Northwind;" +
            "Integrated Security=true;" +
            "MultipleActiveResultSets=true;");
            table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        #region Work from Data Base
        public bool QuantityAdd(short? add, Product product)
        {           
            product.UnitsInStock += add;
            int affected = db.SaveChanges();
            return (affected == 1);
        }
        //  TODO: Вместо ид зделать продукт
        public bool QuantityDelete(short? delete, Product product)
        {            
            product.UnitsInStock -= delete;
            int affected = db.SaveChanges();
            return (affected == 1);
        }
        #endregion
        #region Work from Delivery
        public void CreateNewDelivery()
        {            
            var MaxValueDeliveryCurrentNumber = db.Delivery.Select(s => s.DeliveryCurrentNumber).Max();
            CurrentDelivery = ++MaxValueDeliveryCurrentNumber;
        }        
        public bool ProductDataAddDelivery(Product product, short? add)
        {            
                Delivery newDelivery = new Delivery()
                {
                    DeliveryCurrentNumber = CurrentDelivery,
                    DeliveryProduct = product.ProductName,
                    DeliveryProductPrice = product.UnitPrice.ToString(),
                    DeliveryProductQuantity = Convert.ToInt32(add)
                };
                db.Delivery.Add(newDelivery);
                int affected = db.SaveChanges();
                return (affected == 1);            
        }        
        public bool ProductDataDeleteDelivery(Product product, short? delete)
        {                                    
            Delivery deliveryDelete = db.Delivery.Where(w => w.DeliveryCurrentNumber == CurrentDelivery && w.DeliveryProduct == product.ProductName)
                .FirstOrDefault();
            if (deliveryDelete.DeliveryProductQuantity == Convert.ToInt32(delete))
            {
                db.Delivery.Remove(deliveryDelete);
                int affected = db.SaveChanges();
                return (affected == 1);
            }
            else
            {
                deliveryDelete.DeliveryProductQuantity -= Convert.ToInt32(delete);
                int affected = db.SaveChanges();
                return (affected == 1);
            }           
        }
        #endregion
    }
}