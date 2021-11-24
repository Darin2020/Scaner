using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scanner
{
    public interface IScanner
    {
        int ProductId { get; set; }
        int QuantityAdd { get; set; }
        string ProductName1 { get; set; }
        decimal? UnitPrice { set; }
        string QuantityPerUnit { set; }
        short? UnitsInStock { set; }
        event EventHandler ButtonOkClick;
        event EventHandler ButtonAddClick;
    }
    public partial class Scanner : Form, IScanner
    {
        public Scanner()
        {
            InitializeComponent();
            btnEnter.Click += BtnEnter_Click;
            btnProductAdd.Click += BtnProductAdd_Click;
        }

        private void BtnProductAdd_Click(object sender, EventArgs e)
        {
            if (ButtonAddClick != null) ButtonAddClick(this, EventArgs.Empty);
            lblProductId.Focus();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (ButtonOkClick != null) ButtonOkClick(this, EventArgs.Empty);
            lblQuantityToAdd.Focus();
        }

        public int ProductId
        {            
            get { return Int32.Parse(lblProductId.Text); }
            set { lblProductId.Text = value.ToString(); }
        }
        public int QuantityAdd
        {
            get { return Convert.ToInt16(lblQuantityToAdd.Text); }
            set { lblQuantityToAdd.Text = value.ToString(); }
        }
        public string ProductName1
        {
            get { return lblProductName.Text; }
            set { lblProductName.Text = value; }
        }
        public decimal? UnitPrice
        {
            set { lblUnitPrice.Text = value.ToString(); }
        }
        public string QuantityPerUnit
        {
            set { lblQuantityPerUnit.Text = value; }
        }
        public short? UnitsInStock
        {
            set { lblUnitsInStock.Text = value.ToString(); }
        }
        public event EventHandler ButtonOkClick;
        public event EventHandler ButtonAddClick;





        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
