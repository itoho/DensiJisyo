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
        public kobetu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
            {
                {
                    SQLiteConnection dic = new SQLiteConnection("Data Source=dictionary/pdic_eiwa.db;Version=3;");
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
                            dai1index.Text = sdr["title"].ToString();
                            dai2index.Text = sdr["means"].ToString();
                            //Console.Write("sdr[\"means\"]="+sdr["means"].ToString());
                            Console.WriteLine(sdr["means"]);
                            Console.WriteLine(sdr["means"]);
                            Debug.WriteLine(sdr);
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
    }
}
