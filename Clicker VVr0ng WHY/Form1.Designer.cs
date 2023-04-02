namespace Clicker_VVr0ng_WHY
{
    partial class GildiaWhyClicker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GildiaWhyClicker));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CPSTrackBar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.CPSValue = new System.Windows.Forms.Label();
            this.AutoClicker = new System.Windows.Forms.Timer(this.components);
            this.btnToggle = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Random = new System.Windows.Forms.Timer(this.components);
            this.RandomTrackbar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.Binding = new System.Windows.Forms.Timer(this.components);
            this.Bindbtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label3 = new System.Windows.Forms.Label();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Mining = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clicker by VVr0ng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Left Mouse Button";
            // 
            // CPSTrackBar
            // 
            this.CPSTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.CPSTrackBar.Location = new System.Drawing.Point(6, 121);
            this.CPSTrackBar.Maximum = 20;
            this.CPSTrackBar.Minimum = 6;
            this.CPSTrackBar.Name = "CPSTrackBar";
            this.CPSTrackBar.Size = new System.Drawing.Size(300, 23);
            this.CPSTrackBar.TabIndex = 2;
            this.CPSTrackBar.ThumbColor = System.Drawing.Color.LightGreen;
            this.CPSTrackBar.Value = 10;
            this.CPSTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.CPSTrackBar_Scroll);
            // 
            // CPSValue
            // 
            this.CPSValue.AutoSize = true;
            this.CPSValue.BackColor = System.Drawing.Color.Transparent;
            this.CPSValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPSValue.Location = new System.Drawing.Point(335, 121);
            this.CPSValue.Name = "CPSValue";
            this.CPSValue.Size = new System.Drawing.Size(30, 24);
            this.CPSValue.TabIndex = 3;
            this.CPSValue.Text = "10";
            // 
            // AutoClicker
            // 
            this.AutoClicker.Tick += new System.EventHandler(this.AutoClicker_Ticks);
            // 
            // btnToggle
            // 
            this.btnToggle.Animated = true;
            this.btnToggle.BackColor = System.Drawing.Color.Transparent;
            this.btnToggle.BorderColor = System.Drawing.Color.Transparent;
            this.btnToggle.CheckedState.FillColor = System.Drawing.Color.Red;
            this.btnToggle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToggle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToggle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToggle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToggle.FillColor = System.Drawing.Color.Transparent;
            this.btnToggle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnToggle.ForeColor = System.Drawing.Color.LightGreen;
            this.btnToggle.Location = new System.Drawing.Point(270, 9);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(256, 45);
            this.btnToggle.TabIndex = 4;
            this.btnToggle.Text = "Enable";
            this.btnToggle.TextChanged += new System.EventHandler(this.btnToggle_TextChanged);
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // Random
            // 
            this.Random.Enabled = true;
            this.Random.Interval = 150;
            this.Random.Tick += new System.EventHandler(this.Random_Tick);
            // 
            // RandomTrackbar
            // 
            this.RandomTrackbar.BackColor = System.Drawing.Color.Black;
            this.RandomTrackbar.Location = new System.Drawing.Point(304, 426);
            this.RandomTrackbar.Maximum = 30;
            this.RandomTrackbar.Name = "RandomTrackbar";
            this.RandomTrackbar.Size = new System.Drawing.Size(300, 23);
            this.RandomTrackbar.TabIndex = 5;
            this.RandomTrackbar.ThumbColor = System.Drawing.Color.LightGreen;
            this.RandomTrackbar.Value = 10;
            this.RandomTrackbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RandomTrackbar_Scroll);
            // 
            // Binding
            // 
            this.Binding.Enabled = true;
            // 
            // Bindbtn
            // 
            this.Bindbtn.Animated = true;
            this.Bindbtn.BackColor = System.Drawing.Color.Transparent;
            this.Bindbtn.BorderColor = System.Drawing.Color.Transparent;
            this.Bindbtn.CheckedState.FillColor = System.Drawing.Color.Red;
            this.Bindbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Bindbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Bindbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Bindbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Bindbtn.FillColor = System.Drawing.Color.Transparent;
            this.Bindbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Bindbtn.ForeColor = System.Drawing.Color.LightGreen;
            this.Bindbtn.Location = new System.Drawing.Point(537, 9);
            this.Bindbtn.Name = "Bindbtn";
            this.Bindbtn.PressedColor = System.Drawing.Color.Transparent;
            this.Bindbtn.Size = new System.Drawing.Size(56, 45);
            this.Bindbtn.TabIndex = 6;
            this.Bindbtn.Text = "none";
            this.Bindbtn.Click += new System.EventHandler(this.Bindbtn_Click);
            this.Bindbtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bindbtn_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Right Mouse Button";
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.BorderColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.LightGreen;
            this.siticoneButton1.Location = new System.Drawing.Point(537, 175);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(56, 45);
            this.siticoneButton1.TabIndex = 8;
            this.siticoneButton1.Text = "none";
            // 
            // Mining
            // 
            this.Mining.BackColor = System.Drawing.Color.Transparent;
            this.Mining.BorderColor = System.Drawing.Color.Transparent;
            this.Mining.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Mining.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Mining.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Mining.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Mining.FillColor = System.Drawing.Color.Transparent;
            this.Mining.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Mining.ForeColor = System.Drawing.Color.LightGreen;
            this.Mining.Location = new System.Drawing.Point(423, 109);
            this.Mining.Name = "Mining";
            this.Mining.Size = new System.Drawing.Size(170, 45);
            this.Mining.TabIndex = 9;
            this.Mining.Text = "AutoMining";
            this.Mining.Click += new System.EventHandler(this.Mining_Click);
            // 
            // GildiaWhyClicker
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.Mining);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Bindbtn);
            this.Controls.Add(this.RandomTrackbar);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.CPSValue);
            this.Controls.Add(this.CPSTrackBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.LightGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GildiaWhyClicker";
            this.Text = "GildiaWhyClicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar CPSTrackBar;
        private System.Windows.Forms.Label CPSValue;
        private System.Windows.Forms.Timer AutoClicker;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnToggle;
        private System.Windows.Forms.Timer Random;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar RandomTrackbar;
        private System.Windows.Forms.Timer Binding;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Bindbtn;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Mining;
    }
}

