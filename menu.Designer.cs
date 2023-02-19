namespace Devicesinfo
{
    partial class menu
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
            this.label2 = new System.Windows.Forms.Label();
            this.Cihazadı = new System.Windows.Forms.Label();
            this.tür = new System.Windows.Forms.Label();
            this.ram = new System.Windows.Forms.Label();
            this.kuladı = new System.Windows.Forms.Label();
            this.işletimad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cihaz Özellikleri";
            // 
            // Cihazadı
            // 
            this.Cihazadı.AutoSize = true;
            this.Cihazadı.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cihazadı.Location = new System.Drawing.Point(74, 95);
            this.Cihazadı.Name = "Cihazadı";
            this.Cihazadı.Size = new System.Drawing.Size(66, 19);
            this.Cihazadı.TabIndex = 2;
            this.Cihazadı.Text = "Cihaz Adı";
            // 
            // tür
            // 
            this.tür.AutoSize = true;
            this.tür.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tür.Location = new System.Drawing.Point(74, 241);
            this.tür.Name = "tür";
            this.tür.Size = new System.Drawing.Size(27, 19);
            this.tür.TabIndex = 6;
            this.tür.Text = "tür";
            // 
            // ram
            // 
            this.ram.AutoSize = true;
            this.ram.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ram.Location = new System.Drawing.Point(74, 202);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(33, 19);
            this.ram.TabIndex = 5;
            this.ram.Text = "ram";
            // 
            // kuladı
            // 
            this.kuladı.AutoSize = true;
            this.kuladı.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kuladı.Location = new System.Drawing.Point(74, 164);
            this.kuladı.Name = "kuladı";
            this.kuladı.Size = new System.Drawing.Size(75, 19);
            this.kuladı.TabIndex = 7;
            this.kuladı.Text = "kullanıcıadı";
            // 
            // işletimad
            // 
            this.işletimad.AutoSize = true;
            this.işletimad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.işletimad.Location = new System.Drawing.Point(74, 129);
            this.işletimad.Name = "işletimad";
            this.işletimad.Size = new System.Drawing.Size(70, 19);
            this.işletimad.TabIndex = 8;
            this.işletimad.Text = "işletim adı";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 400);
            this.Controls.Add(this.işletimad);
            this.Controls.Add(this.kuladı);
            this.Controls.Add(this.tür);
            this.Controls.Add(this.ram);
            this.Controls.Add(this.Cihazadı);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menu";
            this.Text = "menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label Cihazadı;
        private Label tür;
        private Label ram;
        private Label kuladı;
        private Label işletimad;
    }
}