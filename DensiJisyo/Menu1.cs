using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DensiJisyo
{
    public partial class Menu1 : UserControl
    {
        
        int menunum;
        int pagenum;
        
        public Menu1()
        {
            InitializeComponent();
        }

        

        private void Menu1_KeyDown(object sender, KeyEventArgs e)
        {

        }
       
        public int Getrabbit()
        {
            return menunum;//ページナンバー 8あとでかけるやつ
            
        }
        public int Getpagerabbit()
        {
            return pagenum;//ページ内
        }

        
        public void Changerabbit(int num)
        {
            menunum = num;
            Console.WriteLine("rabbit" + num);
            button1.BackColor = Color.FromKnownColor(KnownColor.ActiveCaptionText);
            button2.BackColor = Color.FromKnownColor(KnownColor.ActiveCaptionText);
            button3.BackColor = Color.FromKnownColor(KnownColor.ActiveCaptionText);
            button4.BackColor = Color.FromKnownColor(KnownColor.ActiveCaptionText);
            button5.BackColor = Color.FromKnownColor(KnownColor.ActiveCaptionText);
            button6.BackColor = Color.FromKnownColor(KnownColor.ActiveCaptionText);
            button7.BackColor = Color.FromKnownColor(KnownColor.ActiveCaptionText);
            button8.BackColor = Color.FromKnownColor(KnownColor.ActiveCaptionText);
            switch (num)
            {
                case 1:
                    button1.BackColor = Color.FromArgb(0x30, 0x30, 0xAF);
                    contents1.BackgroundImage = null;
                    contents1_text.Text = "";
                    contents2.BackgroundImage = null;
                    contents2_text.Text = "";
                    contents3.BackgroundImage = null;
                    contents3_text.Text = "";
                    contents4.BackgroundImage = null;
                    contents4_text.Text = "";
                    contents5.BackgroundImage = null;
                    contents5_text.Text = "";
                    contents6.BackgroundImage = null;
                    contents6_text.Text = "";
                    contents7.BackgroundImage = null;
                    contents7_text.Text = "";
                    contents8.BackgroundImage = null;
                    contents8_text.Text = "";
                    contents1.BackgroundImage = Image.FromFile("images/bluerect.jpg");
                    contents1_text.Text = "国語辞典";
                    //contents1.Text = "国語辞典";
                    break;
                case 2:
                    button2.BackColor = Color.FromArgb(0x30, 0x30, 0xAF);
                    contents1.BackgroundImage = null;
                    contents1_text.Text = "";
                    contents2.BackgroundImage = null;
                    contents2_text.Text = "";
                    contents3.BackgroundImage = null;
                    contents3_text.Text = "";
                    contents4.BackgroundImage = null;
                    contents4_text.Text = "";
                    contents5.BackgroundImage = null;
                    contents5_text.Text = "";
                    contents6.BackgroundImage = null;
                    contents6_text.Text = "";
                    contents7.BackgroundImage = null;
                    contents7_text.Text = "";
                    contents8.BackgroundImage = null;
                    contents8_text.Text = "";
                    break;
                case 3:
                    button3.BackColor = Color.FromArgb(0x30, 0x30, 0xAF);
                    contents1.BackgroundImage = null;
                    contents1_text.Text = "";
                    contents2.BackgroundImage = null;
                    contents2_text.Text = "";
                    contents3.BackgroundImage = null;
                    contents3_text.Text = "";
                    contents4.BackgroundImage = null;
                    contents4_text.Text = "";
                    contents5.BackgroundImage = null;
                    contents5_text.Text = "";
                    contents6.BackgroundImage = null;
                    contents6_text.Text = "";
                    contents7.BackgroundImage = null;
                    contents7_text.Text = "";
                    contents8.BackgroundImage = null;
                    contents8_text.Text = "";
                    contents1.BackgroundImage = Image.FromFile("images/pdic_eiwa.jpg");
                    contents1_text.Text = "英和辞書";
                    break;
                case 4:
                    button4.BackColor = Color.FromArgb(0x30, 0x30, 0xAF);
                    contents1.BackgroundImage = Image.FromFile("images/pdic_waei.jpg");
                    contents1_text.Text = "英和辞書";
                    contents2.BackgroundImage = null;
                    contents2_text.Text = "";
                    contents3.BackgroundImage = null;
                    contents3_text.Text = "";
                    contents4.BackgroundImage = null;
                    contents4_text.Text = "";
                    contents5.BackgroundImage = null;
                    contents5_text.Text = "";
                    contents6.BackgroundImage = null;
                    contents6_text.Text = "";
                    contents7.BackgroundImage = null;
                    contents7_text.Text = "";
                    contents8.BackgroundImage = null;
                    contents8_text.Text = "";
                    break;
                case 5:
                    button5.BackColor = Color.FromArgb(0x30, 0x30, 0xAF);
                    contents1.BackgroundImage = null;
                    contents1_text.Text = "";
                    contents2.BackgroundImage = null;
                    contents2_text.Text = "";
                    contents3.BackgroundImage = null;
                    contents3_text.Text = "";
                    contents4.BackgroundImage = null;
                    contents4_text.Text = "";
                    contents5.BackgroundImage = null;
                    contents5_text.Text = "";
                    contents6.BackgroundImage = null;
                    contents6_text.Text = "";
                    contents7.BackgroundImage = null;
                    contents7_text.Text = "";
                    contents8.BackgroundImage = null;
                    contents8_text.Text = "";
                    break;
                case 6:
                    button6.BackColor = Color.FromArgb(0x30, 0x30, 0xAF);
                    contents1.BackgroundImage = null;
                    contents1_text.Text = "";
                    contents2.BackgroundImage = null;
                    contents2_text.Text = "";
                    contents3.BackgroundImage = null;
                    contents3_text.Text = "";
                    contents4.BackgroundImage = null;
                    contents4_text.Text = "";
                    contents5.BackgroundImage = null;
                    contents5_text.Text = "";
                    contents6.BackgroundImage = null;
                    contents6_text.Text = "";
                    contents7.BackgroundImage = null;
                    contents7_text.Text = "";
                    contents8.BackgroundImage = null;
                    contents8_text.Text = "";
                    break;
                case 7:
                    button7.BackColor = Color.FromArgb(0x30, 0x30, 0xAF);
                    contents1.BackgroundImage = null;
                    contents1_text.Text = "";
                    contents2.BackgroundImage = null;
                    contents2_text.Text = "";
                    contents3.BackgroundImage = null;
                    contents3_text.Text = "";
                    contents4.BackgroundImage = null;
                    contents4_text.Text = "";
                    contents5.BackgroundImage = null;
                    contents5_text.Text = "";
                    contents6.BackgroundImage = null;
                    contents6_text.Text = "";
                    contents7.BackgroundImage = null;
                    contents7_text.Text = "";
                    contents8.BackgroundImage = null;
                    contents8_text.Text = "";
                    break;
                case 8:
                    button8.BackColor = Color.FromArgb(0x30, 0x30, 0xAF);
                    contents1.BackgroundImage = null;
                    contents1_text.Text = "";
                    contents2.BackgroundImage = null;
                    contents2_text.Text = "リモコン";
                    contents3.BackgroundImage = null;
                    contents3_text.Text = "";
                    contents4.BackgroundImage = null;
                    contents4_text.Text = "";
                    contents5.BackgroundImage = null;
                    contents5_text.Text = "";
                    contents6.BackgroundImage = null;
                    contents6_text.Text = "";
                    contents7.BackgroundImage = null;
                    contents7_text.Text = "";
                    contents8.BackgroundImage = null;
                    contents8_text.Text = "";
                    contents1.BackgroundImage = Image.FromFile("images/settei.jpg");
                    contents1_text.Text = "設定";
                    break;




            }

        }

        //public class InkCanvas : FrameworkElement, IInkCanvas
        public void updaterabbit()//kobetunisenni 
        {
            if (Form1.ctr2.kobetu_reload() != 0)
            {
                Form1.ctr1.Visible = false;
                Form1.ctr2.Visible = true;
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Changerabbit(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Changerabbit(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Changerabbit(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Changerabbit(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Changerabbit(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Changerabbit(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Changerabbit(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Changerabbit(8);
        }

        private void Menu1_Load(object sender, EventArgs e)
        {
            Changerabbit(1);
        }


        private void contents1_Click(object sender, EventArgs e)//コンテンツがくりっくされたとき
        {
           pagenum = 1;
         
           updaterabbit();
        }

        private void contents2_Click(object sender, EventArgs e)
        {
            pagenum = 2;
           
            updaterabbit();
        }

        private void contents3_Click(object sender, EventArgs e)
        {
            pagenum = 3;
            
            updaterabbit();
        }

        private void contents4_Click(object sender, EventArgs e)
        {
            pagenum = 4;
           
            updaterabbit();
        }

        private void contents5_Click(object sender, EventArgs e)
        {
            pagenum = 5;
            
            updaterabbit();
        }

        private void contents6_Click(object sender, EventArgs e)
        {
            pagenum = 6;
            
            updaterabbit();
        }

        private void contents7_Click(object sender, EventArgs e)
        {
            pagenum = 7;
            
            updaterabbit();
        }

        private void contents8_Click(object sender, EventArgs e)
        {
            pagenum = 8;
           
            updaterabbit();
        }
    }
}
