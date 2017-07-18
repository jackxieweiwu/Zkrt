namespace Zkrt
{
    partial class zkrt_map
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zkrt_map));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.alt_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lng_label = new System.Windows.Forms.Label();
            this.lng_label_name = new System.Windows.Forms.Label();
            this.lat_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mapControl1 = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mapControl1);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.alt_label, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lng_label, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lng_label_name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lat_label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // alt_label
            // 
            resources.ApplyResources(this.alt_label, "alt_label");
            this.alt_label.Name = "alt_label";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // lng_label
            // 
            resources.ApplyResources(this.lng_label, "lng_label");
            this.lng_label.Name = "lng_label";
            // 
            // lng_label_name
            // 
            resources.ApplyResources(this.lng_label_name, "lng_label_name");
            this.lng_label_name.Name = "lng_label_name";
            // 
            // lat_label
            // 
            resources.ApplyResources(this.lat_label, "lat_label");
            this.lat_label.Name = "lat_label";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // mapControl1
            // 
            this.mapControl1.Bearing = 0F;
            this.mapControl1.CanDragMap = true;
            this.mapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapControl1.GrayScaleMode = false;
            this.mapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapControl1.LevelsKeepInMemmory = 5;
            resources.ApplyResources(this.mapControl1, "mapControl1");
            this.mapControl1.MarkersEnabled = true;
            this.mapControl1.MaxZoom = 2;
            this.mapControl1.MinZoom = 2;
            this.mapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NegativeMode = false;
            this.mapControl1.PolygonsEnabled = true;
            this.mapControl1.RetryLoadTile = 0;
            this.mapControl1.RoutesEnabled = true;
            this.mapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapControl1.ShowTileGridLines = false;
            this.mapControl1.Zoom = 0D;
            // 
            // zkrt_map
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "zkrt_map";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.zkrt_map_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        //private Control.MapControl mapControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label alt_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lng_label;
        private System.Windows.Forms.Label lng_label_name;
        private System.Windows.Forms.Label lat_label;
        private GMap.NET.WindowsForms.GMapControl mapControl1;
    }
}