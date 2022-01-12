using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.dataSet1.Product);
            // TODO: This line of code loads data into the 'dataSet1.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.dataSet1.Order);
            // TODO: This line of code loads data into the 'dataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.dataSet1.Customer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int product;
            product = (int)comboBox1.SelectedValue;
            this.productTableAdapter.MyInsertQuery(Convert.ToString(product), textBox3.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox1.Text));
            this.productTableAdapter.Fill(this.dataSet1.Product);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IDX;
            int Sel_Id = 0;
            IDX = dataGridView1.CurrentRow.Index;
            int.TryParse(dataGridView1.Rows[IDX].Cells[0].Value.ToString(), out Sel_Id);
            this.productTableAdapter.MyDeleteQuery(Sel_Id);
            this.productTableAdapter.Fill(this.dataSet1.Product);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int product_name, IDX;
            int Sel_Id = 0;
            IDX = dataGridView1.CurrentRow.Index;
            product_name = (int)comboBox1.SelectedValue;
            int.TryParse(dataGridView1.Rows[IDX].Cells[0].Value.ToString(), out Sel_Id);
            this.productTableAdapter.MyUpdateQuery(Convert.ToString(product_name), textBox3.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox1.Text), Sel_Id,0);
            this.productTableAdapter.Fill(this.dataSet1.Product);
        }

    "
    }
}
