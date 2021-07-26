
namespace FormsAppTemplate
{
    partial class DICTForms
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DICTForms));
            this.labelWelcome = new System.Windows.Forms.Label();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.textusername = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelbox = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Castellar", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWelcome.ForeColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Location = new System.Drawing.Point(63, 31);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(558, 34);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome To DICT LogIn Form!";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelWelcome.Click += new System.EventHandler(this.labelWelcome_Click);
            // 
            // textpassword
            // 
            this.textpassword.BackColor = System.Drawing.Color.Thistle;
            this.textpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textpassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textpassword.Location = new System.Drawing.Point(53, 218);
            this.textpassword.Name = "textpassword";
            this.textpassword.PasswordChar = '*';
            this.textpassword.PlaceholderText = "Password:";
            this.textpassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textpassword.Size = new System.Drawing.Size(395, 37);
            this.textpassword.TabIndex = 4;
            this.textpassword.TextChanged += new System.EventHandler(this.textpassword_TextChanged);
            // 
            // textusername
            // 
            this.textusername.BackColor = System.Drawing.Color.Thistle;
            this.textusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textusername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textusername.Location = new System.Drawing.Point(53, 149);
            this.textusername.Name = "textusername";
            this.textusername.PlaceholderText = "Username:";
            this.textusername.Size = new System.Drawing.Size(395, 34);
            this.textusername.TabIndex = 3;
            this.textusername.TextChanged += new System.EventHandler(this.textusername_TextChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogin.BackgroundImage")));
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.ForeColor = System.Drawing.Color.Black;
            this.buttonLogin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLogin.Location = new System.Drawing.Point(128, 296);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(245, 62);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "LOG IN";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(212, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panelbox
            // 
            this.panelbox.BackColor = System.Drawing.Color.Transparent;
            this.panelbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelbox.Controls.Add(this.textpassword);
            this.panelbox.Controls.Add(this.pictureBox1);
            this.panelbox.Controls.Add(this.buttonLogin);
            this.panelbox.Controls.Add(this.textusername);
            this.panelbox.ForeColor = System.Drawing.Color.LightGray;
            this.panelbox.Location = new System.Drawing.Point(90, 108);
            this.panelbox.Name = "panelbox";
            this.panelbox.Size = new System.Drawing.Size(546, 415);
            this.panelbox.TabIndex = 7;
            // 
            // DICTForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 594);
            this.Controls.Add(this.panelbox);
            this.Controls.Add(this.labelWelcome);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DICTForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DICT FORM";
            this.Load += new System.EventHandler(this.DICTForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelbox.ResumeLayout(false);
            this.panelbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelbox;
    }
}

