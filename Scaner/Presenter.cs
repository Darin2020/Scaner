using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NorthwindEntitiesLib;
using System.Data;
using System.Data.SqlClient;

namespace Scanner
{
    public class Presenter
    {
        private readonly IScanner _viewScaner;
        private readonly IFileManager _fileManager;
        private readonly IMessageService _messegeServece;
        //public List<string> CurrentOrder = new List<string>();   
        

        public Presenter(IScanner form)
        {              
                _viewScaner = form;
                _fileManager = new FileManager();
                _messegeServece = new MessageSarvice();
                _viewScaner.ButtonOkClick += _view_ButtonOkClick;
                _viewScaner.ButtonAddClick += _view_ButtonAddClick;
                _viewScaner.ProductDelete += _viewScaner_ProductDelete;
                _viewScaner.FormLoad += _viewScaner_FormLoad;           
        }

        private void _viewScaner_FormLoad(object sender, EventArgs e)
        {
            _fileManager.CreateNewDelivery();            
        }

        private void _view_ButtonOkClick(object sender, EventArgs e)
        {
            try
            {
                Product product = _fileManager.GetProductById(_viewScaner.ProductId);
                if (product != null)
                {
                    _viewScaner.ProductName1 = product.ProductName;
                    _viewScaner.UnitPrice = product.UnitPrice;
                    _viewScaner.QuantityPerUnit = product.QuantityPerUnit;
                    _viewScaner.UnitsInStock = product.UnitsInStock;
                }
                else
                {
                    _messegeServece.ShowMessage("There is no such product.");
                }
            }
            catch (Exception ex)
            {
                _messegeServece.ShowError(ex.Message);
            }

        }

        private void _view_ButtonAddClick(object sender, EventArgs e)
        {
            try
            {
                short? add = (short?)_viewScaner.QuantityAdd;                
                Product product = _fileManager.GetProductById(_viewScaner.ProductId);
                
                if (add != 0)
                {                      
                    _fileManager.QuantityAdd(add, product);
                    _fileManager.ProductDataAddDelivery(product, add);
                    CurrentDelivery();
                    RefreshForm();
                }
                else
                {
                    _messegeServece.ShowMessage("You did not specify the quantity of the product.");
                }
            }
            catch(Exception ex)
            {
                _messegeServece.ShowError(ex.Message);
            }
        }
        private void _viewScaner_ProductDelete(object sender, EventArgs e)
        {            
            try
            {
                short? delete = (short?)_viewScaner.QuantityDelete;                
                Product product = _fileManager.GetProductById(_viewScaner.ProductIdDelete);

                if (delete != 0)
                {
                    _fileManager.QuantityDelete(delete, product);
                    _fileManager.ProductDataDeleteDelivery(product, delete);
                    CurrentDelivery();
                    _viewScaner.ProductIdDelete = 0;
                    _viewScaner.QuantityDelete = 0;                    
                }
                else
                {
                    _messegeServece.ShowMessage("You did not specify the quantity of the product.");
                }
            }
            catch (Exception ex)
            {
                _messegeServece.ShowError(ex.Message);
            }
        }
        
        private void RefreshForm()
        {
            _viewScaner.ProductName1 = null;
            _viewScaner.QuantityPerUnit = null;
            _viewScaner.UnitsInStock = null;
            _viewScaner.UnitPrice = null;
            _viewScaner.ProductId = 0;
            _viewScaner.QuantityAdd = 0;
        }
        public void CurrentDelivery()
        {            
            _viewScaner.DataGridView.DataSource = _fileManager.CurrentInvoice();
        }
    }
}