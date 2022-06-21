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
    public partial class FrmNhap : Form
    {
        public FrmNhap()
        {
            InitializeComponent();
        }

        KetNoi_CSDL kn = new KetNoi_CSDL();

        private void FrmNhap_Load(object sender, EventArgs e)
        {
            BangDieuChuyen();
            ListDonVi();
            ListTaiSan();
            //HIENTHI_DULIEU();
            btnSave.Enabled = false;
            txtMaDC.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (thongbao == DialogResult.Yes)
                this.Close();
        }

        public void BangDieuChuyen()
        {
            DataTable dta = kn.Lay_DulieuBang("Select * From DIEUCHUYEN order by MADC");
            dataGridDieuChuyen.DataSource = dta;
            HIENTHI_DULIEU();
        }

        public void ListTaiSan()
        {
            DataTable dta = kn.Lay_DulieuBang("Select * From TAISAN order by MATS");
            cboMaTS.DataSource = dta;
            cboMaTS.DisplayMember = "MATS";
        }

        public void ListDonVi()
        {
            DataTable dta = kn.Lay_DulieuBang("Select * From DONVI order by MADV");
            cboDVden.DataSource = dta;
            cboDVden.DisplayMember = "MADV";
            DataTable dta2 = kn.Lay_DulieuBang("Select * From DONVI order by MADV");
            cboDVdi.DataSource = dta2;
            cboDVdi.DisplayMember = "MADV";
        }

        private void HIENTHI_DULIEU()
        {
            txtMaDC.DataBindings.Clear();
            txtMaDC.DataBindings.Add("Text", dataGridDieuChuyen.DataSource, "MADC");

            cboMaTS.DataBindings.Clear();
            cboMaTS.DataBindings.Add("Text", dataGridDieuChuyen.DataSource, "MATS");

            dtpNgayDC.DataBindings.Clear();
            dtpNgayDC.DataBindings.Add("Text", dataGridDieuChuyen.DataSource, "NGAYDC");

            cboDVden.DataBindings.Clear();
            cboDVden.DataBindings.Add("Text", dataGridDieuChuyen.DataSource, "MADONVI_DEN");

            cboDVdi.DataBindings.Clear();
            cboDVdi.DataBindings.Add("Text", dataGridDieuChuyen.DataSource, "MADONVI_DI");

            txtTinhTrang.DataBindings.Clear();
            txtTinhTrang.DataBindings.Add("Text", dataGridDieuChuyen.DataSource, "TINHTRANG");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            txtMaDC.Text = "";
            cboMaTS.SelectedIndex = 0; 
            dtpNgayDC.Value = DateTime.Now;
            cboDVden.SelectedIndex = 0;
            cboDVdi.SelectedIndex = 0;
            txtTinhTrang.Text = "";
            txtMaDC.Focus();
            btnSave.Enabled = true;
            txtMaDC.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaDC.Text.Trim() == "")
            {
                MessageBox.Show("Xin hãy nhập vào Mã điều chuyển", "Thông báo");
                txtMaDC.Focus();
            } 
            else
            {
                string strKra = "Select MADC from DIEUCHUYEN where MADC = '" + txtMaDC.Text + "'";
                SqlCommand cmd = new SqlCommand(strKra, kn.cnn);
                SqlDataReader doc_dl = cmd.ExecuteReader();

                if (doc_dl.Read() == true)
                {
                    MessageBox.Show("Mã điều chuyển này đã tồn tại, nhập lại mã khác", "Thông báo");
                    txtMaDC.Focus();
                    doc_dl.Close();
                    doc_dl.Dispose();
                }
                else
                {
                    string sql_luu = "Insert into DIEUCHUYEN Values(N'"+ txtMaDC.Text +"', N'"+ cboMaTS.Text +"', '"+ dtpNgayDC.Value.Date.ToString("yyyyMMdd") + "', N'"+ cboDVden.Text +"', N'"+ cboDVdi.Text +"', N'"+ txtTinhTrang.Text +"')";
                    kn.Thucthi(sql_luu);
                    BangDieuChuyen();
                    btnSave.Enabled = false;
                    txtMaDC.Enabled = false;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Trước khi xóa dữ liệu cần phải kiểm tra tính ràng buộc (Khóa)
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn muốn xóa dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (thongbao == DialogResult.Yes)
            {
                string sql_xoa = "Delete from DIEUCHUYEN where MADC = '" + txtMaDC.Text + "'";
                kn.Thucthi(sql_xoa);
                BangDieuChuyen();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql_Sua = "Update DIEUCHUYEN SET MATS = N'" + cboMaTS.Text + "', " +
                " NGAYDC = '" + dtpNgayDC.Value.Date.ToString("yyyyMMdd") + "', " +
                " MADONVI_DEN = N'" + cboDVden.Text + "', " +
                " MADONVI_DI = N'" + cboDVdi.Text + "', " +
                " TINHTRANG = N'" + txtTinhTrang.Text + "' where MADC = '" + txtMaDC.Text + "'";
            kn.Thucthi(sql_Sua);
            BangDieuChuyen();
        }
    }
}
