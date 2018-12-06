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
            this.DGRequests.AllowUserToAddRows = false;
            this.DGRequests.AllowUserToDeleteRows = false;
            this.DGRequests.AllowUserToResizeColumns = false;
            this.DGRequests.AllowUserToResizeRows = false;
            this.DGRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGRequests.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGRequests.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGRequests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGRequests.Location = new System.Drawing.Point(11, 99);
            this.DGRequests.Margin = new System.Windows.Forms.Padding(2);
            this.DGRequests.MultiSelect = false;
            this.DGRequests.Name = "DGRequests";
            this.DGRequests.ReadOnly = true;
            this.DGRequests.RowHeadersVisible = false;
            this.DGRequests.RowTemplate.Height = 24;
            this.DGRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGRequests.Size = new System.Drawing.Size(578, 256);
            this.DGRequests.TabIndex = 0;
            this.DGRequests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGRequests_CellClick);
            // 
            // lblReviewRequests
            // 
            this.lblReviewRequests.AutoSize = true;
            this.lblReviewRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewRequests.Location = new System.Drawing.Point(208, 20);
            this.lblReviewRequests.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReviewRequests.Name = "lblReviewRequests";
            this.lblReviewRequests.Size = new System.Drawing.Size(182, 26);
            this.lblReviewRequests.TabIndex = 1;
            this.lblReviewRequests.Text = "Review Requests";
            // 
            // btnApproveRequest
            // 
            this.btnApproveRequest.Location = new System.Drawing.Point(456, 72);
            this.btnApproveRequest.Margin = new System.Windows.Forms.Padding(2);
            this.btnApproveRequest.Name = "btnApproveRequest";
            this.btnApproveRequest.Size = new System.Drawing.Size(56, 23);
            this.btnApproveRequest.TabIndex = 2;
            this.btnApproveRequest.Text = "Approve";
            this.btnApproveRequest.UseVisualStyleBackColor = true;
            this.btnApproveRequest.Click += new System.EventHandler(this.btnApproveRequest_Click);
            // 
            // btnDenyRequest
            // 
            this.btnDenyRequest.Location = new System.Drawing.Point(516, 72);
            this.btnDenyRequest.Margin = new System.Windows.Forms.Padding(2);
            this.btnDenyRequest.Name = "btnDenyRequest";
            this.btnDenyRequest.Size = new System.Drawing.Size(56, 23);
            this.btnDenyRequest.TabIndex = 3;
            this.btnDenyRequest.Text = "Deny";
            this.btnDenyRequest.UseVisualStyleBackColor = true;
            this.btnDenyRequest.Click += new System.EventHandler(this.btnDenyRequest_Click);
            // 
            // btnLogOutReviewRequest
            // 
            this.btnLogOutReviewRequest.Location = new System.Drawing.Point(516, 27);
            this.btnLogOutReviewRequest.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOutReviewRequest.Name = "btnLogOutReviewRequest";
            this.btnLogOutReviewRequest.Size = new System.Drawing.Size(56, 29);
            this.btnLogOutReviewRequest.TabIndex = 4;
            this.btnLogOutReviewRequest.Text = "Log Out";
            this.btnLogOutReviewRequest.UseVisualStyleBackColor = true;
            this.btnLogOutReviewRequest.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReviewRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnLogOutReviewRequest);
            this.Controls.Add(this.btnDenyRequest);
            this.Controls.Add(this.btnApproveRequest);
            this.Controls.Add(this.lblReviewRequests);
            this.Controls.Add(this.DGRequests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReviewRequests";
            this.Text = "Review Requests";
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

