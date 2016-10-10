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
    public partial class AddBoat : Form
    {
        public AddBoat()
        {
            InitializeComponent();
        }
        public string phoneno;
        public Entity.Customer ec ;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0 || textBox5.Text.Length == 0 || textBox6.Text.Length == 0 || (radioButton1.Checked == false && radioButton2.Checked == false) || (radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false))
            {
                MessageBox.Show("请填写完整信息", "提示");
            }
            else
            {
                string a = textBox3.Text;
                string b = textBox5.Text;
                string c = textBox6.Text;
                int result;
                if (int.TryParse(a, out result) && int.TryParse(b, out result) && int.TryParse(c, out result))
                {
                    Entity.Boat eb = new Entity.Boat();
                    eb.Stateregistrationno = textBox4.Text;
                    eb.Manufacturer = textBox1.Text;
                    eb.Length = Convert.ToInt32(textBox3.Text);
                    eb.Customerphone = ec.phoneno;
                    eb.Validity = textBox2.Text;
                    eb.sail = Convert.ToInt32(textBox5.Text);
                    eb.keel = Convert.ToInt32(textBox6.Text);
                    if (radioButton1.Checked)
                    {
                        eb.type = '1';
                    }
                    else if (radioButton2.Checked)
                    {
                        eb.type = '2';
                    }
                    if (radioButton3.Checked)
                    {
                        eb.energe = '1';
                    }
                    else if (radioButton4.Checked)
                    {
                        eb.energe = '2';
                    }
                    else if (radioButton5.Checked)
                    {
                        eb.energe = '3';
                    }
                    BLL.BLL bb = new BLL.BLL();
                    int xs = Convert.ToInt32(bb.AddBoat_SS(eb));
                    if (xs == 0)
                    {
                        int count = Convert.ToInt32(bb.AddBoat(eb, ec));
                        if (count == 0)
                        {
                            MessageBox.Show("添加游艇成功");
                        }
                        else MessageBox.Show("添加游艇失败");
                    }
                    else MessageBox.Show("数据库中查找到相同船只");
                }
                else MessageBox.Show("请检查长度、帆数、龙骨深度是否为数字","提示");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
        }

        private void AddBoat_FormClosing(object sender, FormClosingEventArgs e)
        {
        }              
    }
}
