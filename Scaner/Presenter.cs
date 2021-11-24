using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NorthwindEntitiesLib;

namespace Scanner
{

    public class Presenter
    {
        private readonly IScanner _viewScaner;
        private readonly IFileManager _fileManager;
        private readonly IMessageService _messegeServece;


        public Presenter(IScanner form)
        {
            _viewScaner = form;
            _fileManager = new FileManager();
            _messegeServece = new MessageSarvice();
            _viewScaner.ButtonOkClick += _view_ButtonOkClick;
            _viewScaner.ButtonAddClick += _view_ButtonAddClick;
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

        private void _view_ButtonAddClick(object sender, EventArgs e)
        {
            short? add = (short?)_viewScaner.QuantityAdd;
            int productId = _viewScaner.ProductId;
            _fileManager.QuantityAdd(add, productId);
            RefreshForm();
        }

        private void _view_ButtonOkClick(object sender, EventArgs e)
        {
            try
            {
                var IsExist = _fileManager.IsExist(_viewScaner.ProductId);
                if (IsExist)
                {
                    Product product = _fileManager.GetProductById(_viewScaner.ProductId);
                    _viewScaner.ProductName1 = product.ProductName;
                    _viewScaner.UnitPrice = product.UnitPrice;
                    _viewScaner.QuantityPerUnit = product.QuantityPerUnit;
                    _viewScaner.UnitsInStock = product.UnitsInStock;
                }
                else
                {
                    _messegeServece.ShowMessage("There is no such product");
                }
            }
            catch (Exception ex)
            {
                _messegeServece.ShowError(ex.Message);
            }

        }
    }
}