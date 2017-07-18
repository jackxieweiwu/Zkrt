using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zkrt.bean;
using Zkrt.until;

namespace Zkrt
{
    public partial class zkrt_map : Form
    {
        private GMapOverlay markersOverlay = new GMapOverlay("markers"); //放置marker的图层
         // GMapOverlay polyOverlay = new GMapOverlay(“polygons”); 
        GMapOverlay polyOverlay = new GMapOverlay("Routes");
        private Ip ip = login.Ip;
        private string[] leftBottom;
        private string[] rightUp;
        private GMapMarker marker;

        public zkrt_map()
        {
            InitializeComponent();
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;//全屏
            Rectangle ret = Screen.GetWorkingArea(this);
            this.mapControl1.ClientSize = new Size(ret.Width, ret.Height);
            this.mapControl1.Dock = DockStyle.Fill;
            this.mapControl1.BringToFront();

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
            while (true)
            {
                System.Threading.Thread.Sleep(500);
                string url = login.httpUrl+"/v1/pyApiDroneMsg?web=DroneMsg";
                string status = until.until_network.GetModel(url);
                DroneMessage droneMsg = until.until_network.GetObj<DroneMessage>(status.Trim());
                //获取到的坐标 立马显示在地图上
                AddMapMarker(droneMsg);
            }
        }
        

        private void zkrt_map_Load(object sender, EventArgs e)
        {
            try
            {
                //System.NET.IPHostEntry e = System.net.Dns.GetHostEntry("ditu.amap.com");

            }
            catch
            {
                mapControl1.Manager.Mode = AccessMode.CacheOnly;
                MessageBox.Show("No internet connection avaible, going to CacheOnly mode.", "GMap.NET Demo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            this.splitContainer1.IsSplitterFixed = true;
        
            mapControl1.CacheLocation = Environment.CurrentDirectory + "\\GMapCache\\"; //缓存位置
            //  mapControl1.MapProvider = GMapProviders.GoogleChinaMap; //google china 地图
            //详情看类AMapProvider与GMapProviders即可明白
            mapControl1.MapProvider = AMapProvider.Instance;
            mapControl1.MinZoom = 2;  //最小比例
            mapControl1.MaxZoom = 24; //最大比例
            mapControl1.Zoom = 10;    //当前比例
            mapControl1.ShowCenter = false; //不显示中心十字点
            mapControl1.DragButton = System.Windows.Forms.MouseButtons.Left; //左键拖拽地图

            //分割获取到的GPS点，然后计算出大致的位置显示
            string[] sArray = ip.rectangle.Split(';');
            leftBottom = sArray[0].Split(',');
            rightUp = sArray[1].Split(',');

            mapControl1.Position = 
                new PointLatLng((Convert.ToSingle(leftBottom[1]) + Convert.ToSingle(rightUp[1])) / 2, 
                (Convert.ToSingle(leftBottom[0])+ Convert.ToSingle(rightUp[0]))/2); //地图中心位置

            //List<PointLatLng> points = new List<PointLatLng>();
            //points.Add(new PointLatLng(32.064, 118.704));
            //points.Add(new PointLatLng(32.253, 118.513));
            //points.Add(new PointLatLng(32.542, 118.322));
            // points.Add(new PointLatLng(32.764, 118.104));
            //绘制多边形用GMapPolygon 
            //GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
            ////绘制折线用GMapRoute 
            //GMapRoute route = new GMapRoute(points, "");
            //route.Stroke = new Pen(Color.Red, 1);

            //polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            //polygon.Stroke = new Pen(Color.Red, 1);
            // polyOverlay.Polygons.Add(polygon);
            //polyOverlay.Routes.Add(route);
            //mapControl1.Overlays.Add(polyOverlay);

            //定位显示marker标示
            PointLatLng point = mapControl1.FromLocalToLatLng(32, 118);
            GMapMarker marker = new GMarkerGoogle(mapControl1.Position, GMarkerGoogleType.green);
            markersOverlay.Markers.Add(marker);
            mapControl1.Overlays.Add(markersOverlay);

            mapControl1.MouseClick += new MouseEventHandler(mapControl_MouseClick);
        }

        //显示地图上的marker
        private void AddMapMarker(DroneMessage droneMsg)
        {
            int lat = (int)Math.Round(Convert.ToSingle(droneMsg.DroneGpsLat));
            int lng = (int)Math.Round(Convert.ToSingle(droneMsg.DroneGpsLng));
            //定位显示marker标示
            PointLatLng point = mapControl1.FromLocalToLatLng(lat,lng);
            if (marker != null)
            {
                marker
            }
            else
            {
                marker = new GMarkerGoogle(mapControl1.Position, GMarkerGoogleType.green);
            }
            markersOverlay.Markers.Add(marker);
            mapControl1.Overlays.Add(markersOverlay);
        }

        void mapControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                PointLatLng point = mapControl1.FromLocalToLatLng(e.X, e.Y);
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.green);
                markersOverlay.Markers.Add(marker);
            }
        }
    }
}
