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
        public Menu1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Menu1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.F1:
                    menunum = 1;
                    break;
                case Keys.F2:
                    menunum = 2;
                    break;
            }
            Console.WriteLine(menunum);
        }
    }
}
