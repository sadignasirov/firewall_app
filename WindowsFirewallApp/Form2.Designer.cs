namespace WindowsFirewallApp
{
    partial class registerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerForm));
            this.password_lbl = new System.Windows.Forms.Label();
            this._username_lbl = new System.Windows.Forms.Label();
            this._username_txt = new System.Windows.Forms.TextBox();
            this._password_txt = new System.Windows.Forms.TextBox();
            this.register_btn = new System.Windows.Forms.Button();
            this._login_btn = new System.Windows.Forms.Button();
            this.confirm_password_lbl = new System.Windows.Forms.Label();
            this.confirm_password_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(256, 136);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(52, 13);
            this.password_lbl.TabIndex = 13;
            this.password_lbl.Text = "password";
            // 
            // _username_lbl
            // 
            this._username_lbl.AutoSize = true;
            this._username_lbl.Location = new System.Drawing.Point(256, 93);
            this._username_lbl.Name = "_username_lbl";
            this._username_lbl.Size = new System.Drawing.Size(53, 13);
            this._username_lbl.TabIndex = 12;
            this._username_lbl.Text = "username";
            // 
            // _username_txt
            // 
            this._username_txt.Location = new System.Drawing.Point(258, 109);
            this._username_txt.Name = "_username_txt";
            this._username_txt.Size = new System.Drawing.Size(156, 20);
            this._username_txt.TabIndex = 11;
            // 
            // _password_txt
            // 
            this._password_txt.Location = new System.Drawing.Point(258, 152);
            this._password_txt.Name = "_password_txt";
            this._password_txt.PasswordChar = '*';
            this._password_txt.Size = new System.Drawing.Size(156, 20);
            this._password_txt.TabIndex = 10;
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.Green;
            this.register_btn.ForeColor = System.Drawing.Color.White;
            this.register_btn.Location = new System.Drawing.Point(258, 234);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(156, 31);
            this.register_btn.TabIndex = 9;
            this.register_btn.Text = "Sign Up";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // _login_btn
            // 
            this._login_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this._login_btn.ForeColor = System.Drawing.Color.White;
            this._login_btn.Location = new System.Drawing.Point(259, 274);
            this._login_btn.Name = "_login_btn";
            this._login_btn.Size = new System.Drawing.Size(156, 31);
            this._login_btn.TabIndex = 8;
            this._login_btn.Text = "Log in";
            this._login_btn.UseVisualStyleBackColor = false;
            this._login_btn.Click += new System.EventHandler(this._login_btn_Click);
            // 
            // confirm_password_lbl
            // 
            this.confirm_password_lbl.AutoSize = true;
            this.confirm_password_lbl.Location = new System.Drawing.Point(256, 181);
            this.confirm_password_lbl.Name = "confirm_password_lbl";
            this.confirm_password_lbl.Size = new System.Drawing.Size(89, 13);
            this.confirm_password_lbl.TabIndex = 15;
            this.confirm_password_lbl.Text = "confirm password";
            // 
            // confirm_password_txt
            // 
            this.confirm_password_txt.Location = new System.Drawing.Point(258, 197);
            this.confirm_password_txt.Name = "confirm_password_txt";
            this.confirm_password_txt.PasswordChar = '*';
            this.confirm_password_txt.Size = new System.Drawing.Size(156, 20);
            this.confirm_password_txt.TabIndex = 14;
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(652, 385);
            this.Controls.Add(this.confirm_password_lbl);
            this.Controls.Add(this.confirm_password_txt);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this._username_lbl);
            this.Controls.Add(this._username_txt);
            this.Controls.Add(this._password_txt);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this._login_btn);
            this.Name = "registerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label _username_lbl;
        private System.Windows.Forms.TextBox _username_txt;
        private System.Windows.Forms.TextBox _password_txt;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Button _login_btn;
        private System.Windows.Forms.Label confirm_password_lbl;
        private System.Windows.Forms.TextBox confirm_password_txt;
    }
}