namespace WindowsFirewallApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.block_All_btn = new System.Windows.Forms.Button();
            this.allow_all_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.Green;
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_btn.ForeColor = System.Drawing.Color.White;
            this.start_btn.Location = new System.Drawing.Point(233, 62);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(192, 41);
            this.start_btn.TabIndex = 0;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.BackColor = System.Drawing.Color.Red;
            this.stop_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stop_btn.ForeColor = System.Drawing.Color.White;
            this.stop_btn.Location = new System.Drawing.Point(233, 137);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(192, 41);
            this.stop_btn.TabIndex = 1;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // block_All_btn
            // 
            this.block_All_btn.BackColor = System.Drawing.Color.Red;
            this.block_All_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.block_All_btn.ForeColor = System.Drawing.Color.White;
            this.block_All_btn.Location = new System.Drawing.Point(233, 287);
            this.block_All_btn.Name = "block_All_btn";
            this.block_All_btn.Size = new System.Drawing.Size(192, 41);
            this.block_All_btn.TabIndex = 2;
            this.block_All_btn.Text = "Block All";
            this.block_All_btn.UseVisualStyleBackColor = false;
            this.block_All_btn.Click += new System.EventHandler(this.block_All_btn_Click);
            // 
            // allow_all_btn
            // 
            this.allow_all_btn.BackColor = System.Drawing.Color.Green;
            this.allow_all_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allow_all_btn.ForeColor = System.Drawing.Color.White;
            this.allow_all_btn.Location = new System.Drawing.Point(233, 212);
            this.allow_all_btn.Name = "allow_all_btn";
            this.allow_all_btn.Size = new System.Drawing.Size(192, 41);
            this.allow_all_btn.TabIndex = 3;
            this.allow_all_btn.Text = "Allow All";
            this.allow_all_btn.UseVisualStyleBackColor = false;
            this.allow_all_btn.Click += new System.EventHandler(this.allow_all_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(652, 385);
            this.Controls.Add(this.allow_all_btn);
            this.Controls.Add(this.block_All_btn);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.start_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firewall by Sadig Nasirov";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button block_All_btn;
        private System.Windows.Forms.Button allow_all_btn;
    }
}