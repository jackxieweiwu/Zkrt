using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using Zkrt.bean;

namespace Zkrt
{
    public partial class login : Form
    {
        private static Ip ip;
        public static string httpUrl = "http://192.168.1.132:8080";
        internal static Ip Ip { get => ip; set => ip = value; }

        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (until.until_network.IsConnectedInternet())
            {
                System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(this.Result));
                thread.Start();
            }
            else
            {
                MessageBox.Show("请检查电脑的网络情况");
            }
        }

        private void Result()
        {
            System.Threading.Thread.Sleep(500);
            //开始进行webURL获取根据IP获取当前的位置信息
            string strURL = "http://restapi.amap.com/v3/ip?key=0c5157c6c97270867e460bf5e31e2421&ip=" + until.until_network.GetIP();
            string status = until.until_network.GetModel(strURL);
            byte[] buffer = Encoding.UTF8.GetBytes(status);
            string keyword = Encoding.GetEncoding("UTF-8").GetString(buffer);
            ip = until.until_network.GetObj<Ip>(status.Trim());
        }

        //确定登录btn事件
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (until.until_network.IsConnectedInternet())
            {
                string UserName = userName_textBox.Text.ToString();
                string UserPassword = password_textBox.Text.ToString();
                if (UserName.Length <= 0)
                {
                    showMessage("用户名不能为空!");
                }
                else
                {
                    if (UserPassword.Length <= 0)
                    {
                        showMessage("密码不能为空!");
                    }
                    else
                    {
                        string url = httpUrl+"/v1/login";
                        string strURL = url+ "?username=" + UserName + "&password=" + UserPassword;
                        string status = until.until_network.GetModel(strURL);
                        if (status.Equals("false"))
                        {
                            MessageBox.Show("请检查用户名与密码");
                        }
                        else
                        {
                            this.DialogResult = DialogResult.OK;    //返回一个登录成功的对话框状态
                            this.Close();    //关闭登录窗口
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请检查电脑的网络情况");
            }
        }

        private void showMessage(string msg)
        {
            MessageBox.Show(msg);
        }
    }

}
