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
    public partial class sach : Form
    {
        Session1Entities s1 = new Session1Entities();
        public sach()
        {
            InitializeComponent();
        }

        private void sach_Load(object sender, EventArgs e)
        {
            loadData();
            colourData();


        }

        private void colourData()
        {
            for(int i = 0; i < dgvData.Rows.Count; i++)
            {
                Asset a = (Asset)dgvData.Rows[i].Cells["obj"].Value;
                if(a.DepartmentLocationID > 5)
                {
                    dgvData.Rows[i].Cells["Dept"].Style.BackColor = Color.Red;
                }
            }
            
        }

        private void loadData()
        {
            var dat = s1.Assets.Select(x => new
            {
                Assets = x.AssetName,
                Dept = x.DepartmentLocationID,
                obj = x
            }).ToList();

            dgvData.DataSource = dat;

            for(int x = 0; x < dat.Count; x++)
            {
                chart1.Series["location"].Points.AddXY(dat[x].Assets, dat[x].Dept);
            }
        }
    }
}
