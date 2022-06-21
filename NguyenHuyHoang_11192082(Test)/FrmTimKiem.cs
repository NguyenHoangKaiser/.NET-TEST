using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NguyenHuyHoang_11192082_Test_
{
    public partial class FrmTimKiem : Form
    {
        public FrmTimKiem()
        {
            InitializeComponent();
        }

        KetNoi_CSDL kn = new KetNoi_CSDL();

        private void FrmTimKiem_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (thongbao == DialogResult.Yes)
                this.Close();
        }

        private void btnFInd_Click(object sender, EventArgs e)
        {
            DataTable dta = kn.Lay_DulieuBang("Select * From TAISAN where NUOCSX like N'" + txtNUOC.Text + "' ");
            dataGridTImKiem.DataSource = dta;
        }
    }
}
