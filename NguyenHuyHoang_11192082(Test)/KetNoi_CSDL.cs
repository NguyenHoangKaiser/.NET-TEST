using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NguyenHuyHoang_11192082_Test_
{
    class KetNoi_CSDL
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;

        public void KetNoi_DuLieu()
        {
            string strKetNoi = @"Data Source=NGUYENHUYHOANG;Initial Catalog=TEST1;Integrated Security=True";
            cnn = new SqlConnection(strKetNoi);
            cnn.Open();
        }

        public void HuyKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }

        public DataTable Lay_DulieuBang(string Sql)
        {
            KetNoi_DuLieu();
            ada = new SqlDataAdapter(Sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }

        public void Thucthi(string Sql)
        {
            KetNoi_DuLieu();
            cmd = new SqlCommand(Sql, cnn);
            cmd.ExecuteNonQuery();
            HuyKetNoi();
        }
    }
}
