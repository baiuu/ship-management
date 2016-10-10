using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Marina.GUI
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        public Entity.Customer ec = new Entity.Customer();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0)
            {
                MessageBox.Show("请填写完整信息", "提示");
            }
            else
            {
                ec.Name = textBox1.Text;
                ec.Address = textBox2.Text;
                ec.Phoneno = textBox3.Text;
                BLL.BLL bc = new BLL.BLL();
                int count = Convert.ToInt32(bc.AddCustomer(ec));
                if (count == 0)
                {
                    AddBoat ab = new AddBoat();
                    ab.ec = this.ec;
                    this.Hide();
                    ab.ShowDialog();
                    this.Show();
                }
                else MessageBox.Show("用户名已被占用", "提示");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {   
        }       
    }
}
