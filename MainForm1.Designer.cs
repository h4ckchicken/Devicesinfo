namespace Devicesinfo
{
    partial class MainForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm1));
            this.Başlık = new System.Windows.Forms.Panel();
            this.theme = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.closed = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.Button();
            this.ayrıntı = new System.Windows.Forms.Button();
            this.development = new System.Windows.Forms.Button();
            this.github = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sayfa = new System.Windows.Forms.Panel();
            this.managerbtn = new System.Windows.Forms.Button();
            this.Başlık.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // Başlık
            // 
            this.Başlık.BackColor = System.Drawing.Color.White;
            this.Başlık.Controls.Add(this.theme);
            this.Başlık.Controls.Add(this.minimize);
            this.Başlık.Controls.Add(this.closed);
            this.Başlık.Controls.Add(this.title);
            this.Başlık.Controls.Add(this.icon);
            this.Başlık.Dock = System.Windows.Forms.DockStyle.Top;
            this.Başlık.Location = new System.Drawing.Point(0, 0);
            this.Başlık.Name = "Başlık";
            this.Başlık.Size = new System.Drawing.Size(825, 48);
            this.Başlık.TabIndex = 0;
            this.Başlık.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.Başlık.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.Başlık.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // theme
            // 
            this.theme.BackColor = System.Drawing.Color.Transparent;
            this.theme.FlatAppearance.BorderSize = 0;
            this.theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.theme.Image = ((System.Drawing.Image)(resources.GetObject("theme.Image")));
            this.theme.Location = new System.Drawing.Point(262, 7);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(41, 36);
            this.theme.TabIndex = 5;
            this.theme.UseVisualStyleBackColor = false;
            this.theme.Click += new System.EventHandler(this.theme_Click);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(743, 15);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(35, 19);
            this.minimize.TabIndex = 4;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.button2_Click);
            // 
            // closed
            // 
            this.closed.BackColor = System.Drawing.Color.Transparent;
            this.closed.FlatAppearance.BorderSize = 0;
            this.closed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closed.Image = ((System.Drawing.Image)(resources.GetObject("closed.Image")));
            this.closed.Location = new System.Drawing.Point(780, 3);
            this.closed.Name = "closed";
            this.closed.Size = new System.Drawing.Size(41, 31);
            this.closed.TabIndex = 1;
            this.closed.UseVisualStyleBackColor = false;
            this.closed.Click += new System.EventHandler(this.button1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.SystemColors.Desktop;
            this.title.Location = new System.Drawing.Point(66, 11);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(196, 28);
            this.title.TabIndex = 1;
            this.title.Text = "Devices İnfo System";
            // 
            // icon
            // 
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(12, 1);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(53, 45);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Menu.FlatAppearance.BorderSize = 0;
            this.Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Menu.Image = ((System.Drawing.Image)(resources.GetObject("Menu.Image")));
            this.Menu.Location = new System.Drawing.Point(12, 83);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(145, 45);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "  Menü";
            this.Menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // ayrıntı
            // 
            this.ayrıntı.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ayrıntı.FlatAppearance.BorderSize = 0;
            this.ayrıntı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ayrıntı.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ayrıntı.Image = ((System.Drawing.Image)(resources.GetObject("ayrıntı.Image")));
            this.ayrıntı.Location = new System.Drawing.Point(12, 141);
            this.ayrıntı.Name = "ayrıntı";
            this.ayrıntı.Size = new System.Drawing.Size(145, 45);
            this.ayrıntı.TabIndex = 2;
            this.ayrıntı.Text = "   Ayrıntılı";
            this.ayrıntı.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ayrıntı.UseVisualStyleBackColor = false;
            this.ayrıntı.Click += new System.EventHandler(this.ayrıntı_Click);
            // 
            // development
            // 
            this.development.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.development.FlatAppearance.BorderSize = 0;
            this.development.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.development.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.development.Image = ((System.Drawing.Image)(resources.GetObject("development.Image")));
            this.development.Location = new System.Drawing.Point(12, 254);
            this.development.Name = "development";
            this.development.Size = new System.Drawing.Size(145, 45);
            this.development.TabIndex = 3;
            this.development.Text = " Geliştirici Bilgileri";
            this.development.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.development.UseVisualStyleBackColor = false;
            this.development.Click += new System.EventHandler(this.development_Click);
            // 
            // github
            // 
            this.github.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.github.FlatAppearance.BorderSize = 0;
            this.github.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.github.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.github.Image = ((System.Drawing.Image)(resources.GetObject("github.Image")));
            this.github.Location = new System.Drawing.Point(12, 312);
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(145, 45);
            this.github.TabIndex = 4;
            this.github.Text = " GitHub Adresi";
            this.github.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.github.UseVisualStyleBackColor = false;
            this.github.Click += new System.EventHandler(this.github_Click);
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.quit.FlatAppearance.BorderSize = 0;
            this.quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quit.Image = ((System.Drawing.Image)(resources.GetObject("quit.Image")));
            this.quit.Location = new System.Drawing.Point(12, 368);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(145, 45);
            this.quit.TabIndex = 5;
            this.quit.Text = "  Çıkış";
            this.quit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(63, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "V1.5.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.label3.Location = new System.Drawing.Point(48, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "App Version";
            // 
            // sayfa
            // 
            this.sayfa.AutoScroll = true;
            this.sayfa.AutoScrollMargin = new System.Drawing.Size(0, 8);
            this.sayfa.Location = new System.Drawing.Point(163, 54);
            this.sayfa.Name = "sayfa";
            this.sayfa.Size = new System.Drawing.Size(654, 400);
            this.sayfa.TabIndex = 8;
            // 
            // managerbtn
            // 
            this.managerbtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.managerbtn.FlatAppearance.BorderSize = 0;
            this.managerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managerbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.managerbtn.Image = ((System.Drawing.Image)(resources.GetObject("managerbtn.Image")));
            this.managerbtn.Location = new System.Drawing.Point(12, 198);
            this.managerbtn.Name = "managerbtn";
            this.managerbtn.Size = new System.Drawing.Size(145, 45);
            this.managerbtn.TabIndex = 9;
            this.managerbtn.Text = " Sistem Kullanımı";
            this.managerbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.managerbtn.UseVisualStyleBackColor = false;
            this.managerbtn.Click += new System.EventHandler(this.managerbtn_Click);
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(825, 482);
            this.Controls.Add(this.managerbtn);
            this.Controls.Add(this.sayfa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.github);
            this.Controls.Add(this.development);
            this.Controls.Add(this.ayrıntı);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Başlık);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devices İnfo Systems";
            this.Başlık.ResumeLayout(false);
            this.Başlık.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel Başlık;
        private Label title;
        private PictureBox icon;
        private Button minimize;
        private Button closed;
        private Button theme;
        private Button Menu;
        private Button ayrıntı;
        private Button development;
        private Button github;
        private Button quit;
        private Label label2;
        private Label label3;
        private Panel sayfa;
        private Button managerbtn;
    }
}