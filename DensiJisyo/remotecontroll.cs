using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;

namespace DensiJisyo
{
    public partial class remotecontroll : UserControl
    {
        public remotecontroll()
        {
            InitializeComponent();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort1.ReadLine();	// ポートから文字列を受信する
                if (!string.IsNullOrEmpty(data))
                {
                    Invoke((MethodInvoker)(() =>	// 受信用スレッドから切り替えてデータを書き込む
                    {
                        label1.Text = data;	// ラベルを受信した文字列へ変更
                        Thread.Sleep(1);
                        button1.Enabled = true;	// ボタンを押せるようにしておく
                        Console.WriteLine(data);
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            serialPort1.Close();
            serialPort1.PortName = comboBox1.SelectedItem.ToString();
            serialPort1.Parity = Parity.None;
            serialPort1.Open();
            serialPort1.Write("A");
            button1.Enabled = false;
        }

        private void remotecontroll_Load(object sender, EventArgs e)
        {
            
        }
    }
}
