namespace Zkrt
{
    partial class login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.btn_login = new System.Windows.Forms.Button();
            this.user_name_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.userName_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.Logo_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            resources.ApplyResources(this.btn_login, "btn_login");
            this.btn_login.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_login.Name = "btn_login";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // user_name_label
            // 
            resources.ApplyResources(this.user_name_label, "user_name_label");
            this.user_name_label.BackColor = System.Drawing.Color.Transparent;
            this.user_name_label.Name = "user_name_label";
            // 
            // password_label
            // 
            resources.ApplyResources(this.password_label, "password_label");
            this.password_label.BackColor = System.Drawing.Color.Transparent;
            this.password_label.Name = "password_label";
            // 
            // userName_textBox
            // 
            resources.ApplyResources(this.userName_textBox, "userName_textBox");
            this.userName_textBox.Name = "userName_textBox";
            // 
            // password_textBox
            // 
            resources.ApplyResources(this.password_textBox, "password_textBox");
            this.password_textBox.Name = "password_textBox";
            // 
            // Logo_label
            // 
            resources.ApplyResources(this.Logo_label, "Logo_label");
            this.Logo_label.Name = "Logo_label";
            // 
            // login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.Logo_label);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.userName_textBox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.user_name_label);
            this.Controls.Add(this.btn_login);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label user_name_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox userName_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label Logo_label;
    }
}

