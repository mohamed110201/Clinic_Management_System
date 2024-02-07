namespace ISProject
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Role = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PassWord = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.UserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Loginbtn = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 258);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox6);
            this.panel5.Location = new System.Drawing.Point(6, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(532, 50);
            this.panel5.TabIndex = 84;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(458, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(75, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 82;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(104, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(66)))));
            this.panel3.Controls.Add(this.Role);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(104, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 69);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Role
            // 
            this.Role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(66)))));
            this.Role.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(66)))));
            this.Role.BorderRadius = 20;
            this.Role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Role.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.Role.FocusedColor = System.Drawing.Color.Empty;
            this.Role.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(66)))));
            this.Role.FocusedState.Parent = this.Role;
            this.Role.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Role.ForeColor = System.Drawing.Color.White;
            this.Role.FormattingEnabled = true;
            this.Role.HoverState.Parent = this.Role;
            this.Role.ItemHeight = 30;
            this.Role.Items.AddRange(new object[] {
            "Admin",
            "Receptionist",
            "Doctor"});
            this.Role.ItemsAppearance.Parent = this.Role;
            this.Role.Location = new System.Drawing.Point(55, 17);
            this.Role.Name = "Role";
            this.Role.ShadowDecoration.Parent = this.Role;
            this.Role.Size = new System.Drawing.Size(203, 36);
            this.Role.TabIndex = 66;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 327);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(66)))));
            this.panel4.Controls.Add(this.PassWord);
            this.panel4.Controls.Add(this.UserName);
            this.panel4.Controls.Add(this.Loginbtn);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(104, -5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(326, 280);
            this.panel4.TabIndex = 1;
            // 
            // PassWord
            // 
            this.PassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassWord.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PassWord.HintForeColor = System.Drawing.Color.Gray;
            this.PassWord.HintText = "Password";
            this.PassWord.isPassword = true;
            this.PassWord.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.PassWord.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.PassWord.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.PassWord.LineThickness = 3;
            this.PassWord.Location = new System.Drawing.Point(29, 122);
            this.PassWord.Margin = new System.Windows.Forms.Padding(4);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(268, 54);
            this.PassWord.TabIndex = 75;
            this.PassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PassWord.OnValueChanged += new System.EventHandler(this.PassWord_OnValueChanged);
            // 
            // UserName
            // 
            this.UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.UserName.ForeColor = System.Drawing.Color.White;
            this.UserName.HintForeColor = System.Drawing.Color.Gray;
            this.UserName.HintText = "USER NAME";
            this.UserName.isPassword = false;
            this.UserName.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.UserName.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.UserName.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.UserName.LineThickness = 3;
            this.UserName.Location = new System.Drawing.Point(29, 41);
            this.UserName.Margin = new System.Windows.Forms.Padding(4);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(268, 54);
            this.UserName.TabIndex = 74;
            this.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Loginbtn
            // 
            this.Loginbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(66)))));
            this.Loginbtn.BorderRadius = 20;
            this.Loginbtn.CheckedState.Parent = this.Loginbtn;
            this.Loginbtn.CustomImages.Parent = this.Loginbtn;
            this.Loginbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.White;
            this.Loginbtn.HoverState.Parent = this.Loginbtn;
            this.Loginbtn.Location = new System.Drawing.Point(65, 202);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.ShadowDecoration.Parent = this.Loginbtn;
            this.Loginbtn.Size = new System.Drawing.Size(180, 45);
            this.Loginbtn.TabIndex = 73;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.panel3;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this.panel4;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 583);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Guna.UI2.WinForms.Guna2ComboBox Role;
        private Guna.UI2.WinForms.Guna2Button Loginbtn;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PassWord;
    }
}

