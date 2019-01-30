using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;

namespace DensiJisyo
{
    public partial class kobetu : UserControl
    {

        int tmpnum = 0;//辞書の番号.重複なしページ数*8＋ページ内順位
        int thereisjisyo;//0でないorそれ以外である
        public string jisyoname;
        public string jisyo_dir;
        public kobetu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
            {
                {
                    SQLiteConnection dic = new SQLiteConnection("Data Source="+jisyo_dir+";Version=3;");
                    dic.Open();
                    try
                    {
                        string sql = "select * from jisyo where title = '"+textBox1.Text.ToString()+"';";

                        SQLiteCommand com = new SQLiteCommand(sql, dic);
                        SQLiteDataReader sdr = com.ExecuteReader();
                        
                        while (sdr.Read() == true)
                        {
                            titleBox.Text = sql;   //sdr["title"].ToString();
                            var meeens = sdr["means"];
                            var titlee = sdr["title"];
                            //dai1index.Text = sdr["title"].ToString();
                            //dai2index.Text = sdr["means"].ToString();
                            //Console.Write("sdr[\"means\"]="+sdr["means"].ToString());
                            //Console.WriteLine(sdr["means"]);
                            //Console.WriteLine(sdr["means"]);
                            //Debug.WriteLine(sdr);
                            dai3index.Text = sdr["id"].ToString();

                        }
                        sdr.Close();
                    }
                    catch
                    {

                        Console.Write("データベースのエラー");
                    }
                    finally
                    {
                        
                        dic.Close();
                    }

                   
                }
            }

        }

        private void kobetu_Load(object sender, EventArgs e)
        {
            Console.WriteLine("kobetuload");
            kobetu_reload();
           
        }

        public int kobetu_reload()
        {
            
            tmpnum = Form1.ctr1.Getpagerabbit()  + Form1.ctr1.Getrabbit()*8;
            Console.WriteLine(tmpnum);
            pictureBox2.Image = null;
            jisyoname = "";
            switch (tmpnum)
            {
                case 9:
                    pictureBox2.Image = Image.FromFile("images/bluerect.jpg");
                    jisyoname = ("国語辞典（未実装）");
                    thereisjisyo = 1;
                    break;
                case 10:
                    thereisjisyo = 0;
                    
                    break;
                case 11:
                    thereisjisyo = 0;
                    break;
                case 12:
                    thereisjisyo = 0;
                    break;
                case 13:
                    thereisjisyo = 0;
                    break;
                case 14:
                    thereisjisyo = 0;
                    break;
                case 15:
                    thereisjisyo = 0;
                    break;
                case 16:
                    thereisjisyo = 0;
                    break;
                case 17:
                    thereisjisyo = 0;
                    break;
                case 18:
                    thereisjisyo = 0;
                    break;
                case 19:
                    thereisjisyo = 0;
                    break;
                case 20:
                    thereisjisyo = 0;
                    break;
                case 21:
                    thereisjisyo = 0;
                    break;
                case 22:
                    thereisjisyo = 0;
                    break;
                case 23:
                    thereisjisyo = 0;
                    break;
                case 24:
                    thereisjisyo = 0;
                    break;
                case 25://pdic英和
                    thereisjisyo = 1;
                    jisyoname = ("PDIC英和辞書");
                    jisyo_dir = ("dictionary/pdic_eiwa.db");
                    pictureBox2.Image = Image.FromFile("images/pdic_eiwa.jpg");
                    break;
                case 26:
                    thereisjisyo = 0;
                    break;
                case 27:
                    thereisjisyo = 0;
                    break;
                case 28:
                    thereisjisyo = 0;
                    break;
                case 29:
                    thereisjisyo = 0;
                    break;
                case 30:
                    thereisjisyo = 0;
                    break;
                case 31:
                    thereisjisyo = 0;
                    break;
                case 32:
                    thereisjisyo = 0;
                    break;
                case 33:
                    thereisjisyo = 1;
                    jisyoname = ("PDIC和英辞書");
                    jisyo_dir = ("dictionary/pdic_waei.db");
                    pictureBox2.Image = Image.FromFile("images/pdic_eiwa.jpg");
                    break;
                case 34:
                    thereisjisyo = 0;
                    break;
                case 35:
                    thereisjisyo = 0;
                    break;
                case 36:
                    thereisjisyo = 0;
                    break;
                case 37:
                    thereisjisyo = 0;
                    break;
                case 38:
                    thereisjisyo = 0;
                    break;
                case 39:
                    thereisjisyo = 0;
                    break;
                case 40:
                    thereisjisyo = 0;
                    break;
                case 41:
                    thereisjisyo = 0;
                    break;
                case 42:
                    thereisjisyo = 0;
                    break;
                case 43:
                    thereisjisyo = 0;
                    break;
                case 44:
                    thereisjisyo = 0;
                    break;
                case 45:
                    thereisjisyo = 0;
                    break;
                case 46:
                    thereisjisyo = 0;
                    break;
                case 47:
                    thereisjisyo = 0;
                    break;
                case 48:
                    thereisjisyo = 0;
                    break;
                case 49:
                    thereisjisyo = 0;
                    break;
                case 50:
                    thereisjisyo = 0;
                    break;
                case 51:
                    thereisjisyo = 0;
                    break;
                case 52:
                    thereisjisyo = 0;
                    break;
                case 53:
                    thereisjisyo = 0;
                    break;
                case 54:
                    thereisjisyo = 0;
                    break;
                case 55:
                    thereisjisyo = 0;
                    break;
                case 56:
                    thereisjisyo = 0;
                    break;
                case 57:
                    thereisjisyo = 0;
                    break;
                case 58:
                    thereisjisyo = 0;
                    break;
                case 59:
                    thereisjisyo = 0;
                    break;
                case 60:
                    thereisjisyo = 0;
                    break;
                case 61:
                    thereisjisyo = 0;
                    break;
                case 62:
                    thereisjisyo = 0;
                    break;
                case 63:
                    thereisjisyo = 0;
                    break;
                case 64:
                    thereisjisyo = 0;
                    break;
                case 65:
                    thereisjisyo = 0;
                    break;
                case 66:
                    thereisjisyo = 0;
                    jisyoname = ("リモコン");
                    Form1.ctr1.Visible = false;
                    Form1.ctr2.Visible = false;
                    Form1.remocon.Visible = true;
                    break;
                case 67:
                    thereisjisyo = 0;
                    break;
                case 68:
                    thereisjisyo = 0;
                    break;
                case 69:
                    thereisjisyo = 0;
                    break;
                case 70:
                    thereisjisyo = 0;
                    break;
                case 71:
                    thereisjisyo = 0;
                    break;
                case 72:
                    thereisjisyo = 0;
                    break;
            }
            titleBox.Text = jisyoname;
            return thereisjisyo;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backtorabbithouse();
        }
        public void backtorabbithouse()
        {
            Form1.ctr1.Visible = true;
            Form1.ctr2.Visible = false;
           

        }
    }
}
