namespace RequestRoom.Boundary
{
    partial class ReviewRequests
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
            this.DGRequests = new System.Windows.Forms.DataGridView();
            this.lblReviewRequests = new System.Windows.Forms.Label();
            this.btnApproveRequest = new System.Windows.Forms.Button();
            this.btnDenyRequest = new System.Windows.Forms.Button();
            this.btnLogOutReviewRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // DGRequests
            // 
            this.DGRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGRequests.Location = new System.Drawing.Point(12, 123);
            this.DGRequests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGRequests.Name = "DGRequests";
            this.DGRequests.RowTemplate.Height = 24;
            this.DGRequests.Size = new System.Drawing.Size(776, 315);
            this.DGRequests.TabIndex = 0;
            // 
            // lblReviewRequests
            // 
            this.lblReviewRequests.AutoSize = true;
            this.lblReviewRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewRequests.Location = new System.Drawing.Point(277, 25);
            this.lblReviewRequests.Name = "lblReviewRequests";
            this.lblReviewRequests.Size = new System.Drawing.Size(235, 32);
            this.lblReviewRequests.TabIndex = 1;
            this.lblReviewRequests.Text = "Review Requests";
            // 
            // btnApproveRequest
            // 
            this.btnApproveRequest.Location = new System.Drawing.Point(607, 96);
            this.btnApproveRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApproveRequest.Name = "btnApproveRequest";
            this.btnApproveRequest.Size = new System.Drawing.Size(75, 23);
            this.btnApproveRequest.TabIndex = 2;
            this.btnApproveRequest.Text = "Approve";
            this.btnApproveRequest.UseVisualStyleBackColor = true;

            // 
            // btnDenyRequest
            // 
            this.btnDenyRequest.Location = new System.Drawing.Point(688, 96);
            this.btnDenyRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDenyRequest.Name = "btnDenyRequest";
            this.btnDenyRequest.Size = new System.Drawing.Size(75, 23);
            this.btnDenyRequest.TabIndex = 3;
            this.btnDenyRequest.Text = "Deny";
            this.btnDenyRequest.UseVisualStyleBackColor = true;
            // 
            // btnLogOutReviewRequest
            // 
            this.btnLogOutReviewRequest.Location = new System.Drawing.Point(688, 33);
            this.btnLogOutReviewRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOutReviewRequest.Name = "btnLogOutReviewRequest";
            this.btnLogOutReviewRequest.Size = new System.Drawing.Size(75, 36);
            this.btnLogOutReviewRequest.TabIndex = 4;
            this.btnLogOutReviewRequest.Text = "Log Out";
            this.btnLogOutReviewRequest.UseVisualStyleBackColor = true;
            this.btnLogOutReviewRequest.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReviewRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogOutReviewRequest);
            this.Controls.Add(this.btnDenyRequest);
            this.Controls.Add(this.btnApproveRequest);
            this.Controls.Add(this.lblReviewRequests);
            this.Controls.Add(this.DGRequests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReviewRequests";
            this.Text = "Review Requests";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ReviewRequests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGRequests;
        private System.Windows.Forms.Label lblReviewRequests;
        private System.Windows.Forms.Button btnApproveRequest;
        private System.Windows.Forms.Button btnDenyRequest;
        private System.Windows.Forms.Button btnLogOutReviewRequest;
    }
}

