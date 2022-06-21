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
    public partial class FrmBaoCao1 : Form
    {
        public FrmBaoCao1()
        {
            InitializeComponent();
        }

        KetNoi_CSDL kn = new KetNoi_CSDL();

        private void FrmBaoCao1_Load(object sender, EventArgs e)
        {
            //Báo cáo khi chạy lần đầu sẽ thông báo "Logon failed", chỉ cần tắt Form báo cáo bật lại là ok
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from TAISAN");
            bao_cao_tai_san Baocao = new bao_cao_tai_san();
            Baocao.SetDataSource(dta);
            crpBaoCaoTS.ReportSource = Baocao;
        }
    }
}
