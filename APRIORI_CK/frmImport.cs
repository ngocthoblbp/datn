using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
namespace APRIORI_CK
{
    public partial class frmImport : Form
    {
        public frmImport()
        {
            InitializeComponent();
        }

        private void frmImport_Load(object sender, EventArgs e)
        {

        }
        private DataSet ds;
        private void BTChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();//MỞ FILE EXCEL
            dlg.Filter = "Excel Files (.xls)|*.*";
            OleDbConnection conn;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                //tenfile = dlg.FileName;
                txtpath.Text = fileName;
                string path = fileName;
                if (Path.GetExtension(path) == ".xls")
                {
                    conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"");
                }
                else
                {
                    conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';");
                }
                //oledbConn.Open();
                OleDbCommand cmd;
                OleDbDataAdapter da = new OleDbDataAdapter();
                ds = new DataSet();//LƯU DỮ LIỆU TỪ EXCEL VÀO DATASET
                string query = "";

                query = "SELECT * FROM [Sheet1$]";
                if (conn.State == ConnectionState.Closed) conn.Open();//CẬP NHẬT VÀO FILE
                try
                {
                    cmd = new OleDbCommand(query, conn);
                    da = new OleDbDataAdapter(cmd);
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                }
                catch (Exception loi)
                {
                    MessageBox.Show("loi " + loi.Message);

                }
                finally
                {
                    da.Dispose();
                    conn.Close();
                }
            }
        }

        private void BTImportData_Click(object sender, EventArgs e)
        {
            //HÀM LƯU DỮ LIỆU
            ds.WriteXmlSchema("Schema_CK.xml");
            ds.WriteXml("Data_CK.xml");
            MessageBox.Show("Đã lưu dữ liệu");
            ds = new DataSet();
            ds.ReadXmlSchema("Schema_CK.xml");
            ds.ReadXml("Data_CK.xml");
            //LOAD DỮ LIỆU LÊN DATAGRIDVIEW
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BTXOA_Click(object sender, EventArgs e)
        {
            //HÀM XÓA FILE DỮ LIỆU
            File.Delete("Schema_CK.xml");
            File.Delete("Data_CK.xml");
            MessageBox.Show("Đã xóa dữ liệu thành công");
        }
    }
}
