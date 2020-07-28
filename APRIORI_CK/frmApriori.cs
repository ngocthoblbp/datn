using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AprioriAlgorithm;
using System.IO;
namespace APRIORI_CK
{
    public partial class frmApriori : Form
    {
        public frmApriori()
        {
            InitializeComponent();
        }
        private DataSet ds;
        private IApriori _apriori;
        string[,] mang_doi = new string[20, 2];
        private void BTLoad_Click(object sender, EventArgs e)
        {
            //ĐỌC DỮ LIỆU TỪ FILE XML
            ds = new DataSet();
            ds.ReadXmlSchema("Schema_CK.xml");
            ds.ReadXml("Data_CK.xml");
            dataGridView1.DataSource = ds.Tables[0];
            lbsoluong.Text = "Tổng dữ liệu: " + ds.Tables[0].Rows.Count;//tông số sữ liệu
            string[] anpha = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q","r","s","t" };
            //ĐỌC DỮ LIỆU VÀO CHECKBOX
            string[] mang=new string[20];
            int dem=0;
            //mang[dem] = ds.Tables[0].Rows[0][0].ToString().Trim();
           for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
           // for (int i = 1; i < 20; i++)
            {
                if (ds.Tables[0].Rows[i][0].ToString().Trim() != "" && !Kiem_tra_trung(mang,ds.Tables[0].Rows[i][0].ToString().Trim()))
                {
                    
                    mang[dem] = ds.Tables[0].Rows[i][0].ToString().Trim();
                    checkedListBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString().Trim(), CheckState.Unchecked);
                    mang_doi[dem, 0] = anpha[dem];
                    mang_doi[dem, 1] = ds.Tables[0].Rows[i][0].ToString().Trim();
                    dem++;
                }
            }
           lbtongsocot.Text = "Tổng số cột: " + ds.Tables[0].Columns.Count;//tông số cột

        }
        private bool Kiem_tra_trung(string[] mang, string gt)
        {
            for (int i = 0; i < mang.Length; i++)
                if (mang[i] == gt)
                    return true;
            return false;
        }

        private void BTAPRIORI_Click(object sender, EventArgs e)
        {
            float minsup = 0;
            float minconf = 0;
            if (txtminsupp.Text.Trim() == "")
            {
                MessageBox.Show("Nhập MinSupp");
                return;
            }
            minsup =(float)(float.Parse(txtminsupp.Text)/100.0);

            if (txtminconf.Text.Trim() == "")
            {
                MessageBox.Show("Nhập MinConf");
                return;
            }
            minconf =(float)(float.Parse(txtminconf.Text)/100.0);
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            if (txtngay.Text.Trim() == "")
                return;
            string[] mack_chon = new string[20];
            int dem_tang = 0;
            foreach (var item in checkedListBox1.CheckedItems)
            {

                mack_chon[dem_tang] = item.ToString().Trim();
                dem_tang++;
            }
            DataTable dt = (DataTable)dataGridView1.DataSource;
            int songay = int.Parse(txtngay.Text);
            string[] mang_ngay=new string[songay];
            string thoigian="";
            string[,] mang_data_tang = new string[songay, 2];
            string[,] mang_data_giam = new string[songay, 2];
            string[,] mang_data_dingang = new string[songay, 2];
            //mang_ngay[0] = Convert.ToDateTime(dt.Rows[0]["THOIGIAN"].ToString()).ToString("dd/MM/yyyy") ;
            int cs = 0;

            for (int i = 0; i < songay; i++)
            {
                thoigian = Convert.ToDateTime(dt.Rows[i]["THOIGIAN"].ToString()).ToString("dd/MM/yyyy");
                if (!Kiem_tra_trung(mang_ngay, thoigian))
                {
                    mang_ngay[cs] = thoigian;
                    mang_data_tang[cs, 0] = thoigian;
                    mang_data_giam[cs, 0] = thoigian;
                    mang_data_dingang[cs, 0] = thoigian;
                    cs++;
                }
            }
            //tập hợp các item tăng trong c ngày giao dịch

            for (int i = 0; i < mang_ngay.Length; i++)
            {
                string s_tang="";
                string s_dingang = "";
                string s_giam = "";
                DataRow[] DtRow = dt.Select("THOIGIAN='" +DateTime.ParseExact(mang_ngay[i],"dd/MM/yyyy",null)+"'");
                foreach (DataRow dr in DtRow)
                {
                    if (Kiem_tra_chon(mack_chon, dr["MACK"].ToString()))
                    {
                        if (float.Parse(dr["TANGGIAM"].ToString()) > 0)
                            s_tang = s_tang + dr["MACK"].ToString()+"-";
                        else if(float.Parse(dr["TANGGIAM"].ToString()) == 0)
                            s_dingang = s_dingang + dr["MACK"].ToString()+"-";
                        else
                            s_giam = s_giam + dr["MACK"].ToString()+"-";
                    }
                }
                if (s_tang.Trim() != "")
                    mang_data_tang[i, 1] = s_tang.Substring(0, s_tang.Length - 1);
                if (s_dingang.Trim() != "")
                    mang_data_dingang[i, 1] = s_dingang.Substring(0, s_dingang.Length - 1);
                if (s_giam.Trim() != "")
                    mang_data_giam[i, 1] = s_giam.Substring(0, s_giam.Length - 1) ;
            }
            //Đổi sang ký hiệu anpha
            //luu gia tri Item
            List<string>  item_tang = new List<string>();
            List<string> item_dingang = new List<string>();
            List<string> item_giam = new List<string>();

            //xử lý co mã chứng khoán tăng
            List<string> trans = new List<string>();
            List<string> trans_dingang = new List<string>();
            List<string> trans_giam = new List<string>();
            for (int i = 0; i < mang_data_tang.Length/2; i++)
            {
                string chuoi = Doi_MaCK_sang_AnPha(mang_data_tang[i, 1]);
                trans.Add(chuoi);
               
                for(int u=0;u<chuoi.Length;u++)
                    if(!Kiem_tra_trung(item_tang.ToArray(),chuoi[u].ToString()))
                        item_tang.Add(chuoi[u].ToString());
                
            }
            for (int i = 0; i < mang_data_dingang.Length / 2; i++)
            {
               
                string chuoi_dingang = Doi_MaCK_sang_AnPha(mang_data_dingang[i, 1]);
                trans_dingang.Add(chuoi_dingang);
               
                for (int u = 0; u < chuoi_dingang.Length; u++)
                    if (!Kiem_tra_trung(item_dingang.ToArray(), chuoi_dingang[u].ToString()))
                        item_dingang.Add(chuoi_dingang[u].ToString());
                              
            }

            for (int i = 0; i < mang_data_giam.Length / 2; i++)
            {
               
                string chuoi_giam = Doi_MaCK_sang_AnPha(mang_data_giam[i, 1]);
                trans_giam.Add(chuoi_giam);
                
                for (int u = 0; u < chuoi_giam.Length; u++)
                    if (!Kiem_tra_trung(item_giam.ToArray(), chuoi_giam[u].ToString()))
                        item_giam.Add(chuoi_giam[u].ToString());

            }
                
            Output output = _apriori.ProcessTransaction(minsup,minconf, item_tang, trans.ToArray());

            Output output_dingang = _apriori.ProcessTransaction(minsup, minconf, item_dingang, trans_dingang.ToArray());

            Output output_giam = _apriori.ProcessTransaction(minsup, minconf, item_giam, trans_giam.ToArray());
            //xuất tập luật và luật kết hợp
            //IList<string> itemset = output.FrequentItems;
            string kq = "";
            for (int v = 0; v < output.FrequentItems.Count(); v++)
            {
                kq="{";
                for (int k = 0; k < output.FrequentItems[v].Name.Length; k++)
                {
                    kq = kq + Doi_Nguoc_AnPha_MaCK(output.FrequentItems[v].Name[k].ToString()) + ",";
                }
                kq = kq.Substring(0, kq.Length - 1);
                    kq=kq+"}";

                //listBox1.Items.Add(kq + " Supp: " + Math.Round((output.FrequentItems[v].Support / mack_chon.Length), 2) * 100 + "%");
                listBox1.Items.Add(kq + " Supp: " + output.FrequentItems[v].Support);
            }
            for (int i = 0; i < output.StrongRules.Count(); i++)
            {
                string kq_X = "{";
                string kq_Y = "{";
                //lay gia tri X
                for (int k = 0; k < output.StrongRules[i].X.Length; k++)
                {
                    kq_X = kq_X + Doi_Nguoc_AnPha_MaCK(output.StrongRules[i].X[k].ToString()) + ",";
                }
                kq_X = kq_X.Substring(0, kq_X.Length - 1);
                kq_X = kq_X + "}";
                //Lay gia tri y
                for (int k = 0; k < output.StrongRules[i].Y.Length; k++)
                {
                    kq_Y = kq_Y + Doi_Nguoc_AnPha_MaCK(output.StrongRules[i].Y[k].ToString()) + ",";
                }
                kq_Y = kq_Y.Substring(0, kq_Y.Length - 1);
                kq_Y = kq_Y + "}";
                listBox2.Items.Add(kq_X + "--->" + kq_Y + " Conf: " + Math.Round(output.StrongRules[i].Confidence * 100, 2) + "%");
            }
          //Xử lý cho mã chứng khoán đi ngang
            kq = "";
            for (int v = 0; v < output_dingang.FrequentItems.Count(); v++)
            {
                kq = "{";
                for (int k = 0; k < output_dingang.FrequentItems[v].Name.Length; k++)
                {
                    kq = kq + Doi_Nguoc_AnPha_MaCK(output_dingang.FrequentItems[v].Name[k].ToString()) + ",";
                }
                kq = kq.Substring(0, kq.Length - 1);
                kq = kq + "}";

                //listBox3.Items.Add(kq + " Supp: " + Math.Round((output_dingang.FrequentItems[v].Support / mack_chon.Length), 2) * 100 + "%");
                listBox3.Items.Add(kq + " Supp: " + output_dingang.FrequentItems[v].Support);
            }
            for (int i = 0; i < output_dingang.StrongRules.Count(); i++)
            {
                string kq_X = "{";
                string kq_Y = "{";
                //lay gia tri X
                for (int k = 0; k < output_dingang.StrongRules[i].X.Length; k++)
                {
                    kq_X = kq_X + Doi_Nguoc_AnPha_MaCK(output_dingang.StrongRules[i].X[k].ToString()) + ",";
                }
                kq_X = kq_X.Substring(0, kq_X.Length - 1);
                kq_X = kq_X + "}";
                //Lay gia tri y
                for (int k = 0; k < output_dingang.StrongRules[i].Y.Length; k++)
                {
                    kq_Y = kq_Y + Doi_Nguoc_AnPha_MaCK(output_dingang.StrongRules[i].Y[k].ToString()) + ",";
                }
                kq_Y = kq_Y.Substring(0, kq_Y.Length - 1);
                kq_Y = kq_Y + "}";
                listBox4.Items.Add(kq_X + "--->" + kq_Y + " Conf: " + Math.Round(output_dingang.StrongRules[i].Confidence * 100, 2) + "%");
            }
            //Xử lý cho mã chứng khoán giảm sàn
            kq = "";
            for (int v = 0; v < output_giam.FrequentItems.Count(); v++)
            {
                kq = "{";
                for (int k = 0; k < output_giam.FrequentItems[v].Name.Length; k++)
                {
                    kq = kq + Doi_Nguoc_AnPha_MaCK(output_giam.FrequentItems[v].Name[k].ToString()) + ",";
                }
                kq = kq.Substring(0, kq.Length - 1);
                kq = kq + "}";

                //listBox5.Items.Add(kq + " Supp: " + Math.Round((output_giam.FrequentItems[v].Support / mack_chon.Length), 2) * 100 + "%");
                listBox5.Items.Add(kq + " Supp: " + output_giam.FrequentItems[v].Support);
            }
            for (int i = 0; i < output_giam.StrongRules.Count(); i++)
            {
                string kq_X = "{";
                string kq_Y = "{";
                //lay gia tri X
                for (int k = 0; k < output_giam.StrongRules[i].X.Length; k++)
                {
                    kq_X = kq_X + Doi_Nguoc_AnPha_MaCK(output_giam.StrongRules[i].X[k].ToString()) + ",";
                }
                kq_X = kq_X.Substring(0, kq_X.Length - 1);
                kq_X = kq_X + "}";
                //Lay gia tri y
                for (int k = 0; k < output_giam.StrongRules[i].Y.Length; k++)
                {
                    kq_Y = kq_Y + Doi_Nguoc_AnPha_MaCK(output_giam.StrongRules[i].Y[k].ToString()) + ",";
                }
                kq_Y = kq_Y.Substring(0, kq_Y.Length - 1);
                kq_Y = kq_Y + "}";
                listBox6.Items.Add(kq_X + "--->" + kq_Y + " Conf: " + Math.Round(output_giam.StrongRules[i].Confidence * 100, 2) + "%");
            }
        }
        private bool Kiem_tra_chon(string[] mang, string gt)
        {
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] == gt)
                    return true;
            }
            return false;
        }
        private void frmApriori_Load(object sender, EventArgs e)
        {
            var apriori = ContainerProvider.Container.GetExportedValue<IApriori>();
            this._apriori = apriori;
        }
        private string Doi_MaCK_sang_AnPha(string chuoi)
        {
            string s = "";
            if (chuoi != null)
            {
                string[] mang = chuoi.Split('-');
                for (int i = 0; i < mang.Length; i++)
                {
                    for (int j = 0; j < mang_doi.Length / 2; j++)
                    {
                        if (mang[i] == mang_doi[j, 1])
                        {
                            s = s + mang_doi[j, 0];
                            j = mang_doi.Length;
                        }
                    }
                }
            }
            return s;
        }
        private string Doi_Nguoc_AnPha_MaCK(string chuoi)
        {
            string s = "";
            
                for (int j = 0; j < mang_doi.Length / 2; j++)
                {
                    if (chuoi == mang_doi[j, 0])
                    {
                        s = s + mang_doi[j, 1];
                        j = mang_doi.Length;
                    }
                }
            
            return s;
        }

        private void BTLuu_Click(object sender, EventArgs e)
        {
            FileStream fs1 = new FileStream("Itemset_CK_Tang.txt", FileMode.Create);
            StreamWriter sw1 = new StreamWriter(fs1);
            for(int i=0;i<listBox1.Items.Count;i++)
            {
                sw1.WriteLine(listBox1.Items[i]);
            }
            FileStream fs2 = new FileStream("Itemset_CK_Di_Ngang.txt", FileMode.Create);
            StreamWriter sw2 = new StreamWriter(fs2);
            for (int i = 0; i < listBox3.Items.Count; i++)
            {
                sw2.WriteLine(listBox3.Items[i]);
            }
            FileStream fs3 = new FileStream("Itemset_CK_Giam.txt", FileMode.Create);
            StreamWriter sw3 = new StreamWriter(fs3);

            for (int i = 0; i < listBox5.Items.Count; i++)
            {
                sw3.WriteLine(listBox5.Items[i]);
            }
            FileStream fs11 = new FileStream("Rules_CK_Tang.txt", FileMode.Create);
            StreamWriter sw11 = new StreamWriter(fs11);
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                sw1.WriteLine(listBox2.Items[i]);
            }
            FileStream fs22 = new FileStream("Rules_CK_Di_Ngang.txt", FileMode.Create);
            StreamWriter sw22 = new StreamWriter(fs22);
            for (int i = 0; i < listBox4.Items.Count; i++)
            {
                sw1.WriteLine(listBox4.Items[i]);
            }
            FileStream fs33 = new FileStream("Rules_CK_Giam.txt", FileMode.Create);
            StreamWriter sw33 = new StreamWriter(fs33);
            for (int i = 0; i < listBox6.Items.Count; i++)
            {
                sw1.WriteLine(listBox6.Items[i]);
            }

            sw1.Close();
            fs1.Close();
            sw2.Close();
            fs2.Close();
            sw3.Close();
            fs3.Close();

            sw11.Close();
            fs11.Close();
            sw22.Close();
            fs22.Close();
            sw33.Close();
            fs33.Close();
            MessageBox.Show("Đã lưu dữ liệu thành công");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkBox1.Checked)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
                else
                    checkedListBox1.SetItemChecked(i,false);
            }
        }
    }
}
