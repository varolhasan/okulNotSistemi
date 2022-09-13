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
namespace okulNotSistemi
{
    public partial class FrmOgrenciNotlar : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-RP5F7ET;Initial Catalog=OkulSistemi;Integrated Security=True");
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }
        public int ogrenciID;
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select DERSAD, OGRENCIID, SINAV1, SINAV2, SINAV3, PROJE, ORTALAMA, DURUM from Tbl_Notlar " +
                "INNER JOIN Tbl_Dersler on Tbl_Notlar.DERSID=Tbl_Dersler.DERSID where OGRENCIID=" + ogrenciID, baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
