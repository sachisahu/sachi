using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sachi
{
    public partial class Form1 : Form
    {
        Session1Entities s1 = new Session1Entities();
        public Form1()
        {
            InitializeComponent();
            dgvData.ColumnCount = 3;
            dgvData.Columns[0].Name = "Part Name";
            dgvData.Columns[1].Name = "Batch Number";
            dgvData.Columns[2].Name = "Amount";

            dgv2.DataSource = s1.Assets.Select(x => new
            {
                january = x.WarrantyDate.Value.Month == 2
            }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string[] data = { comboBox.SelectedItem.ToString(), txtName.Text, txtAmount.Value.ToString() };

            dgvData.Rows.Add(data);

            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.Text = "Remove";
            link.Name = "Action";
            link.UseColumnTextForLinkValue = true;
            DataGridViewLinkColumn link2 = new DataGridViewLinkColumn();
            link2.Text = "Edit";
            link2.Name = "";
            link2.UseColumnTextForLinkValue = true;
            dgvData.Columns.Add(link);
            dgvData.Columns.Add(link2);
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == 3)
            {
                dgvData.Rows.RemoveAt(e.RowIndex);
            }
            if(e.RowIndex == 4)
            {

            }
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            sach s = new sach();
            s.Show();
        }
    }
}
