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
    public partial class SlipwayManage : Form
    {
        public SlipwayManage()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUI.AddSlipway asw = new AddSlipway();
            this.Hide();
            asw.ShowDialog();
            this.Show();
            BLL.BLL ss = new BLL.BLL();
            DataSet ds1 = ss.SlipwayManage_Sx();
            int hs1 = ds1.Tables[0].Rows.Count;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = ds1.Tables[0];
        }
            

        private void SlipwayManage_Load(object sender, EventArgs e)
        {
            BLL.BLL ss = new BLL.BLL();
            DataSet ds1 = ss.SlipwayManage_Sx();
            int hs1 = ds1.Tables[0].Rows.Count;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = ds1.Tables[0];
            if (comboBox1.Items.Count != 0) 

                comboBox1.SelectedIndex = 0;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            object a = comboBox1.SelectedValue;
            BLL.BLL SS = new BLL.BLL();
            DataSet ds2 = SS.SlipwayManage_SS(a);
            int hs2 = ds2.Tables[0].Rows.Count;
            for (int loop = 0; loop < hs2; loop++)
            {
                listBox1.Items.Add(ds2.Tables[0].Rows[loop].ItemArray[0].ToString());
            }
            BLL.BLL BB = new BLL.BLL();
            DataSet ds3 = BB.SlipwayManage_BB();
            int hs3 = ds3.Tables[0].Rows.Count;
            for (int loop = 0; loop < hs3; loop++)
            {
                listBox2.Items.Add(ds3.Tables[0].Rows[loop].ItemArray[0].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int loop = 0; loop < listBox2.SelectedItems.Count; loop++)
            {
                listBox1.Items.Add(listBox2.SelectedItems[loop]);
                listBox2.Items.Remove(listBox2.SelectedItems[loop]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int loop = 0; loop < listBox1.SelectedItems.Count; loop++)
            {
                listBox2.Items.Add(listBox1.SelectedItems[loop]);
                listBox1.Items.Remove(listBox1.SelectedItems[loop]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            object x= comboBox1.SelectedValue;
            BLL.BLL xx = new BLL.BLL();
            int a=Convert.ToInt32(xx.SlipwayMage_a(x));
            if (a >= listBox1.Items.Count)
            {
                for (int loop = 0; loop < listBox1.Items.Count; loop++)
                {
                    object c = comboBox1.SelectedValue;
                    object b = listBox1.Items[loop];
                    BLL.BLL lb1 = new BLL.BLL();
                    lb1.SlipwayManage_listbox1(c, b);
                }
                for (int loop = 0; loop < listBox2.Items.Count; loop++)
                {
                    object c = listBox2.Items[loop];
                    BLL.BLL lb2 = new BLL.BLL();
                    lb2.SlipwayManage_listbox2(c);
                }
                MessageBox.Show("更改成功");
            }
            else
            {
                string message = string.Format("船台容纳不了这么多船最多容纳{0}艘船", a);
                MessageBox.Show(message, "提醒");
            }
        }

        private void SlipwayManage_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
