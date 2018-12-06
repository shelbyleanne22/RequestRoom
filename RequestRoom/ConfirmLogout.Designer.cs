namespace RequestRoom
{
    partial class ConfirmLogout
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
            this.btnLogOutConfirm = new System.Windows.Forms.Button();
            this.btnLogoutCancel = new System.Windows.Forms.Button();
            this.lblConfirmLogout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogOutConfirm
            // 
            this.btnLogOutConfirm.Location = new System.Drawing.Point(62, 84);
            this.btnLogOutConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogOutConfirm.Name = "btnLogOutConfirm";
            this.btnLogOutConfirm.Size = new System.Drawing.Size(56, 27);
            this.btnLogOutConfirm.TabIndex = 7;
            this.btnLogOutConfirm.Text = "Log Out";
            this.btnLogOutConfirm.UseVisualStyleBackColor = true;
            this.btnLogOutConfirm.Click += new System.EventHandler(this.btnLogOutConfirm_Click);
            // 
            // btnLogoutCancel
            // 
            this.btnLogoutCancel.Location = new System.Drawing.Point(189, 84);
            this.btnLogoutCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogoutCancel.Name = "btnLogoutCancel";
            this.btnLogoutCancel.Size = new System.Drawing.Size(56, 27);
            this.btnLogoutCancel.TabIndex = 8;
            this.btnLogoutCancel.Text = "Cancel";
            this.btnLogoutCancel.UseVisualStyleBackColor = true;
            this.btnLogoutCancel.Click += new System.EventHandler(this.btnLogoutCancel_Click);
            // 
            // lblConfirmLogout
            // 
            this.lblConfirmLogout.AutoSize = true;
            this.lblConfirmLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmLogout.Location = new System.Drawing.Point(75, 32);
            this.lblConfirmLogout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmLogout.Name = "lblConfirmLogout";
            this.lblConfirmLogout.Size = new System.Drawing.Size(161, 26);
            this.lblConfirmLogout.TabIndex = 9;
            this.lblConfirmLogout.Text = "Confirm Logout";
            this.lblConfirmLogout.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConfirmLogout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 143);
            this.Controls.Add(this.lblConfirmLogout);
            this.Controls.Add(this.btnLogoutCancel);
            this.Controls.Add(this.btnLogOutConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConfirmLogout";
            this.Text = "ConfirmLogout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOutConfirm;
        private System.Windows.Forms.Button btnLogoutCancel;
        private System.Windows.Forms.Label lblConfirmLogout;
    }
}