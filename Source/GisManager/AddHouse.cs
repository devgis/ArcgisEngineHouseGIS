using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GisManager
{
    public partial class AddHouse : Form
    {
        public string HouseUser;
        public string HouseAddress;
        public double HouseArea;
        public AddHouse()
        {
            InitializeComponent();
        }


        private void btOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbHouseUser.Text.Trim()) || string.IsNullOrEmpty(tbHouseAddress.Text.Trim()) || String.IsNullOrEmpty(tbHouseArea.Text.Trim()))
            {
                MessageBox.Show("房主,位置,面积不能为空！");
                tbHouseUser.Focus();
            }
            else
            {
                try
                {
                    HouseArea = Convert.ToDouble(tbHouseArea.Text);
                    HouseUser = tbHouseUser.Text;
                    HouseAddress = tbHouseAddress.Text;
                    this.DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("面积必须为整数或者小数！");
                    tbHouseUser.Focus();
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddHouse_Load(object sender, EventArgs e)
        {
             tbHouseArea.Text=HouseArea.ToString();
             tbHouseUser.Text=HouseUser;
             tbHouseAddress.Text=HouseAddress;
        }
    }
}