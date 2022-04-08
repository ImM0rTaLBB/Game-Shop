using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ShopDB
{
    public partial class ShopManager : Form
    {
        Point LastClick;
        public ShopManager()
        {
            InitializeComponent();
        }

        private void gameBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gameBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataSet);

        }

        private void ShopManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDataSet.Game' table. You can move, or remove it, as needed.
            this.gameTableAdapter.Fill(this.shopDataSet.Game);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login LN = new Login();
            LN.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastClick = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastClick.X;
                this.Top += e.Y - LastClick.Y;
            }
        }
    }
}