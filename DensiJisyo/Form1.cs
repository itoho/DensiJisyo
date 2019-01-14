using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HongliangSoft.Utilities.Gui;

namespace DensiJisyo
{
    public partial class Form1 : Form
    {
        public static Menu1 ctr1;
        public Form1()
        {
            InitializeComponent();
            ctr1 = new Menu1();
            panel1.Controls.Add(ctr1);
            ctr1.Visible = true;
            //ctr2.Visible = false;
        }

        int menunum = 1;

        private void keyboardHook1_KeyboardHooked(object sender, HongliangSoft.Utilities.Gui.KeyboardHookedEventArgs e)
        {
            if(e.UpDown ==KeyboardUpDown.Down)
            {
                Console.WriteLine(e.KeyCode.ToString());
                if (e.KeyCode == Keys.F12)
                {
                    this.TopMost = true;
                    this.TopMost = false;
                    this.Activate();
                    this.WindowState = FormWindowState.Maximized;
                    Console.WriteLine("wei");
                }
                switch (e.KeyCode)
                {
                    case Keys.F1:
                        menunum = 1;
                        ctr1.Changerabbit(menunum);
                        break;
                    case Keys.F2:
                        menunum = 2;
                        ctr1.Changerabbit(menunum);
                        break;
                    case Keys.F3:
                        menunum = 3;
                        ctr1.Changerabbit(menunum);
                        break;
                    case Keys.F4:
                        menunum = 4;
                        ctr1.Changerabbit(menunum);
                        break;
                    case Keys.F5:
                        menunum = 5;
                        ctr1.Changerabbit(menunum);
                        break;
                    case Keys.F6:
                        menunum = 6;
                        ctr1.Changerabbit(menunum);
                        break;
                    case Keys.F7:
                        menunum = 7;
                        ctr1.Changerabbit(menunum);
                        break;
                    case Keys.F8:
                        menunum = 8;
                        ctr1.Changerabbit(menunum);
                        break;
                }
                //Console.WriteLine(menunum);
                
            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}
