using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        int ProductIdDelete { get; set; }
        int QuantityDelete { get; set; }
        DataGridView DataGridView { get; set; }
        event EventHandler ButtonOkClick;
        event EventHandler ButtonAddClick;
        event EventHandler FormLoad;
        event EventHandler ProductDelete;
    }
    public partial class Scanner : Form, IScanner
    {
        
        public Scanner()
        {
            InitializeComponent();
            btnEnter.Click += BtnEnter_Click;
            btnProductAdd.Click += BtnProductAdd_Click;
            Load += Scanner_Load;
            btnDelete.Click += BtnDelete_Click;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (ProductDelete != null) ProductDelete(this, EventArgs.Empty);
            lblProductIdDelete.Focus();
        }

        private void Scanner_Load(object sender, EventArgs e)
        {
            if (FormLoad != null) FormLoad(this, EventArgs.Empty);
            
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
        public int ProductIdDelete
        {
            get { return Int32.Parse(lblProductIdDelete.Text); }
            set { lblProductIdDelete.Text = value.ToString(); }
        }
        public int QuantityDelete
        {
            get { return Convert.ToInt16(lblQuantityDelete.Text); }
            set { lblQuantityDelete.Text = value.ToString(); }
        }      
        public DataGridView DataGridView
        {
            get { return dataGridView1; }
            set { dataGridView1.DataSource = value; }
        }
        public event EventHandler ButtonOkClick;
        public event EventHandler ButtonAddClick;
        public event EventHandler FormLoad;
        public event EventHandler ProductDelete;




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Scanner_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabCurrentInvoice_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
