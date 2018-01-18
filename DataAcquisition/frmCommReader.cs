using CandyCoreCS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace DataAcquisition
{
    public partial class frmCommReader : Form
    {
        private ToledoS toledos = new ToledoS();
        private System.Timers.Timer timer = new System.Timers.Timer(900);
        private String scaleName = "test";

        public frmCommReader()
        {
            InitializeComponent();
            comParity.Items.Add(Parity.None);
            comParity.Items.Add(Parity.Odd);
            comParity.Items.Add(Parity.Even);
            comParity.Items.Add(Parity.Mark);
            comParity.Items.Add(Parity.Space);

            comStopbits.Items.Add(StopBits.None);
            comStopbits.Items.Add(StopBits.One);
            comStopbits.Items.Add(StopBits.OnePointFive);
            comStopbits.Items.Add(StopBits.Two);

            timer.Elapsed += timer_Elapsed;//定时做的事件
            timer.AutoReset = true; //是否不断重复定时器操作
            timer.Enabled = true;

            toledos.setScaleName(scaleName);
        }

        private  void OpenOrCloseSerialPort(object sender, EventArgs e)
        {
            try
            {
                if (toledos.isOpen())
                {
                    toledos.closeSerialPort();
                }
                else
                {
                    //toledos.setSetting((String)comPortName.SelectedText, (int)comBaudrate.SelectedValue, (int)comDatabits.SelectedValue, (Parity)comParity.SelectedValue, (StopBits)comStopbits.SelectedValue);
                    toledos.startRead();
                }

                Thread.CurrentThread.Join(5000);//阻止设定时间
                Console.WriteLine("test");
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(typeof(frmCommReader), ex);
            }
        }

        //public void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        //{

        //    string s = "";
        //    int count = serialPort.BytesToRead;

        //    byte[] data = new byte[count];
        //    serialPort.Read(data, 0, count);

        //    foreach (byte item in data)
        //    {
        //        s += Convert.ToChar(item);
        //    }

        //    if (this.InvokeRequired)//由于是非创建线程访问<span style="font-family:Arial, Helvetica, sans-serif;">textBox1，所以要使用代理句柄。要不然会抛异常，这点需要特别注意</span>  
        //    {
        //        this.Invoke(new MethodInvoker(delegate { this.txtData.Text = s; }));
        //    }
        //    else
        //    {
        //        this.txtData.Text = s;
        //    }
        //}

        #region 定时去取系统状态中秤的重量值
        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Status.scaleGrossWeight.ContainsKey(scaleName))
            {
                float grossWeith = (float)Status.scaleGrossWeight[scaleName];
                //double netWeight = Convert.ToDouble(StateMachine.weightContenHT[devName].ToString()) - currentSkinWeight;
                //if (StateMachine.issame)
                //{

                //    grossWeightL.Dispatcher.Invoke(new Action(delegate { grossWeightL.Content = StateMachine.weightContenHT[devName].ToString(); }));
                //    //netWeightL.Dispatcher.Invoke(new Action(delegate { netWeightL.Content = netWeight; }));
                //    grossWeightL.Dispatcher.Invoke(new Action(delegate { grossWeightL.Foreground = Brushes.Red; }));
                //}
                //else
                //{
                //    grossWeightL.Dispatcher.Invoke(new Action(delegate { grossWeightL.Content = StateMachine.weightContenHT[devName].ToString(); }));
                //    //netWeightL.Dispatcher.Invoke(new Action(delegate { netWeightL.Content = netWeight; }));
                //    grossWeightL.Dispatcher.Invoke(new Action(delegate { grossWeightL.Foreground = Brushes.Black; }));
                //}

                if (this.InvokeRequired)//由于是非创建线程访问<span style="font-family:Arial, Helvetica, sans-serif;">textBox1，所以要使用代理句柄。要不然会抛异常，这点需要特别注意</span>  
                {
                    this.Invoke(new MethodInvoker(delegate { labResult.Text =Convert.ToString(grossWeith);
                        txtData.Text = toledos.getBufferString();
                    }));
                }
                else
                {
                    this.txtData.Text = Convert.ToString(grossWeith);
                    txtData.Text = toledos.getBufferString();
                }
            }
            else
            {
                if (this.InvokeRequired)//由于是非创建线程访问<span style="font-family:Arial, Helvetica, sans-serif;">textBox1，所以要使用代理句柄。要不然会抛异常，这点需要特别注意</span>  
                {
                    this.Invoke(new MethodInvoker(delegate {
                        //labResult.Text = "--.--";
                        //txtData.Text = toledos.getBufferString();
                    }));
                }
                else
                {
                    this.txtData.Text = "--.--"; this.txtData.Text = toledos.getBufferString();
                }
            }

        }
        #endregion
    }
}
