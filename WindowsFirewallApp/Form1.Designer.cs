namespace WindowsFirewallApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.login_btn = new System.Windows.Forms.Button();
            this._register_btn = new System.Windows.Forms.Button();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.username_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(258, 218);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(156, 31);
            this.login_btn.TabIndex = 1;
            this.login_btn.Text = "Log in";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // _register_btn
            // 
            this._register_btn.BackColor = System.Drawing.Color.Green;
            this._register_btn.ForeColor = System.Drawing.Color.White;
            this._register_btn.Location = new System.Drawing.Point(258, 255);
            this._register_btn.Name = "_register_btn";
            this._register_btn.Size = new System.Drawing.Size(156, 31);
            this._register_btn.TabIndex = 2;
            this._register_btn.Text = "Sign Up";
            this._register_btn.UseVisualStyleBackColor = false;
            this._register_btn.Click += new System.EventHandler(this._register_btn_Click);
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(258, 181);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(156, 20);
            this.password_txt.TabIndex = 3;
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(258, 131);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(156, 20);
            this.username_txt.TabIndex = 4;
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(258, 115);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(53, 13);
            this.username_lbl.TabIndex = 5;
            this.username_lbl.Text = "username";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(258, 165);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(52, 13);
            this.password_lbl.TabIndex = 6;
            this.password_lbl.Text = "password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(652, 385);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this._register_btn);
            this.Controls.Add(this.login_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button _register_btn;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label password_lbl;
    }
}

