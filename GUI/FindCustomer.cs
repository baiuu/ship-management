using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Marina.GUI
{
    public partial class FindCustomer : Form
    {
        public FindCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("没有船只被选中请选择");
            }
            else
            {
                label2.Text = "";
                BLL.BLL bl = new BLL.BLL();
                Entity.Customer cs = new Entity.Customer();
                cs.Phoneno = Convert.ToString(listBox1.SelectedValue);
                Entity.Customer cs1 = bl.FindCustomer(cs);
                textBox1.Text = cs1.Address;
                textBox2.Text = cs1.phoneno;
                label2.Text = "注册编号：" + cs1.Boat1.Stateregistrationno + "   制造商:" + cs1.Boat1.Manufacturer + "    船长：" + cs1.Boat1.length + "\r\n" + "     年份:" + cs1.Boat1.Validity +"";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entity.Customer ec = new Entity.Customer();
            ec.Address = textBox1.Text;
            ec.Phoneno = textBox2.Text;
            BLL.BLL bb = new BLL.BLL();            
            try
            {
                bb.Update(ec);
                MessageBox.Show("更新成功");
            }
            catch
            {
                MessageBox.Show("更新失败");
            }
        }

        private void FindCustomer_Load(object sender, EventArgs e)
        {
            BLL.BLL ss = new BLL.BLL();
            DataSet ds = ss.FindCustomer_Selecr();
            int hs = ds.Tables[0].Rows.Count;
            listBox1.DisplayMember = "name";
            listBox1.ValueMember = "phoneno";
            listBox1.DataSource = ds.Tables[0];
            if (listBox1.Items.Count != 0) 
            listBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FindCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
