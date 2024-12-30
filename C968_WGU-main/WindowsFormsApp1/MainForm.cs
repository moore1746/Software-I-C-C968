using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WGU968
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainFormLoad();
        }

        public void MainFormLoad()
        {
            //Populate the lists
            Inventory.PopulateLists();


            DataGridViewSelectionMode Row = DataGridViewSelectionMode.FullRowSelect;
            //Show Products in Right Grid
            var Products = new BindingSource();
            Products.DataSource = Inventory.Products;
            ProductsGrid.DataSource = Products;
            ProductsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Show Parts in Left Grid
            var Parts = new BindingSource();
            Parts.DataSource = Inventory.AllParts;
            PartGrid.DataSource = Parts;
            //PartGrid.DataSource = DataGridViewAutoSizeColumnMode.Fill;
           
      
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPart f2 = new AddPart();
            f2.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //ModifyPart m2 = new ModifyPart();
           // m2.Show();

            if(PartGrid.CurrentRow.DataBoundItem.GetType() == typeof(WGU968.Inhouse))
            {
                Inhouse InPart = (Inhouse)PartGrid.CurrentRow.DataBoundItem;
                new ModifyPart(InPart).ShowDialog();
            }
            else
            {
                Outsourced OutPart = (Outsourced)PartGrid.CurrentRow.DataBoundItem;
                new ModifyPart(OutPart).ShowDialog();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PartGrid.CurrentRow == null || !PartGrid.CurrentRow.Selected)
            {
                MessageBox.Show("Please Select a Part to Delete");

            }
            else
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this record?", "Delete?", MessageBoxButtons.OKCancel);
                {
                    if (confirm == DialogResult.OK)
                    {
                        foreach (DataGridViewRow row in PartGrid.SelectedRows)
                        {

                            PartGrid.Rows.RemoveAt(row.Index);
                        }
                    }
                    else return;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool match = false;
            ProductsGrid.ClearSelection();

            if (ProductsSearch.TextLength<0)
            {
                return;
            }

            else
            {
                try
                {
                    foreach (DataGridViewRow row in ProductsGrid.Rows)
                    {
                        Product prod = (Product)row.DataBoundItem;
                        Product search = Inventory.LookupProduct(Convert.ToInt32(ProductsSearch.Text));

                        if(search.ID == prod?.ID)
                        {
                            row.Selected = true;
                            ProductsGrid.CurrentCell = row.Cells[0];
                            match = true;
                            return;
                        }
                        else
                        {
                            row.Selected = false;
                            match = false;
                        }
                      
                    }
                    
                }
                catch
                {

                }
                if (match == false)
                {
                    MessageBox.Show("No match found");
                }
            }
            


        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ProductsGrid.CurrentRow == null || !ProductsGrid.CurrentRow.Selected)
            {
                MessageBox.Show("Please Select a Product to Modify");
                return;
            }
            if (ProductsGrid.CurrentRow.DataBoundItem is Product)
            {
                Product SelectedProd = ProductsGrid.CurrentRow.DataBoundItem as Product;
                new ModifyProduct(SelectedProd).ShowDialog();
            }
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddProduct f3 = new AddProduct();
            f3.Show();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this record?", "Delete?", MessageBoxButtons.OKCancel);
            {
                if (confirm == DialogResult.OK)
                {

                    Product prod = (Product)ProductsGrid.CurrentRow.DataBoundItem;
                    if (prod.AssociatedParts.Count > 0)
                    {
                        MessageBox.Show("You Can't Delete a Product with a Part Assigned to it! You need to Remove the Associated Parts!");
                        return;
                    }

                    foreach (DataGridViewRow row in ProductsGrid.SelectedRows)
                    {
                        ProductsGrid.Rows.RemoveAt(row.Index);
                    }
                }
                else return;
            }
        }

        private void SearchParts_Click(object sender, EventArgs e)
        {
            PartGrid.ClearSelection();

            if (!string.IsNullOrEmpty(PartsSearch.Text) && PartGrid.Rows.Count>0)
            {
                foreach (DataGridViewRow row in PartGrid.Rows)
                {
                    if (row.Cells[0].Value.ToString().Contains(PartsSearch.Text) || row.Cells[1].Value.ToString().Contains(PartsSearch.Text))
                    {
                        
                        PartGrid.CurrentCell = row.Cells[0];
                        row.Selected = true;
                    }
                    if (row.Selected)
                    {
                         break;
                    }
                    
                }
                if (PartGrid.SelectedRows.Count == 0)
                {
                    MessageBox.Show("No match found");
                }
            }
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
