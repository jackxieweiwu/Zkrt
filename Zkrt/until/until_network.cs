using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;

namespace Zkrt.until
{
    public static class until_network
    {
        [DllImport("wininet")]
        private extern static bool InternetGetConnectedState(out int connectionDescription, int reservedValue);

        /**//// <summary>
        /// 检测本机是否联网
        /// </summary>
        /// <returns></returns>
        public static bool IsConnectedInternet()
        {
            int i = 0;
            if (InternetGetConnectedState(out i, 0))
            {
                //已联网
                return true;
            }
            else
            {
                //未联网
                return false;
            }
        }

        //进行网络请求
        public static string GetModel(string strUrl)
        {
            string strRet = null;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strUrl);
                request.Timeout = 2000;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                System.IO.Stream resStream = response.GetResponseStream();
                Encoding encode = System.Text.Encoding.UTF8;
                StreamReader readStream = new StreamReader(resStream, encode);
                Char[] read = new Char[256];
                int count = readStream.Read(read, 0, 256);
                while (count > 0)
                {
                    String str = new String(read, 0, count);
                    strRet = strRet + str;
                    count = readStream.Read(read, 0, 256);
                }
                resStream.Close();
            }
            catch (Exception e)
            {
                strRet =e.Message+"";
            }
            return strRet;
        }

        //获取本地IP地址
        public static string getPcIp()
        {
            IPHostEntry ipHost = Dns.Resolve(Dns.GetHostName()); ;
            IPAddress ipaddress = ipHost.AddressList[0];
            return ipaddress.ToString();
        }

        /// <summary>
        /// 获得客户端外网IP地址
        /// </summary>
        /// <returns>IP地址</returns>
        //获取本机的公网IP
        public static string GetIP()
        {
            string tempip = "";
            WebRequest request = WebRequest.Create("http://ip.qq.com/");
            request.Timeout = 10000;
            WebResponse response = request.GetResponse();
            Stream resStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(resStream, System.Text.Encoding.Default);
            string htmlinfo = sr.ReadToEnd();
            //匹配IP的正则表达式
            Regex r = new Regex("((25[0-5]|2[0-4]\\d|1\\d\\d|[1-9]\\d|\\d)\\.){3}(25[0-5]|2[0-4]\\d|1\\d\\d|[1-9]\\d|[1-9])", RegexOptions.None);
            Match mc = r.Match(htmlinfo);
            //获取匹配到的IP
            tempip = mc.Groups[0].Value;

            resStream.Close();
            sr.Close();
            return tempip;
        }


        public static T GetObj<T>(string jsonText)
        {
            T obj = Activator.CreateInstance<T>();
            DataContractJsonSerializer ds = new DataContractJsonSerializer(typeof(T));
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonText)))
            {
                obj = (T)ds.ReadObject(ms);
            }
            return obj;
        }
    }
}
