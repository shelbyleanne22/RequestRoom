namespace RequestRoom.Boundary
{
    partial class BookRoom
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
            this.btnLogOutBookARoom = new System.Windows.Forms.Button();
            this.DGAvailableRooms = new System.Windows.Forms.DataGridView();
            this.calBookRoom = new System.Windows.Forms.MonthCalendar();
            this.lblBookARoom = new System.Windows.Forms.Label();
            this.btnBookRoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGAvailableRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOutBookARoom
            // 
            this.btnLogOutBookARoom.Location = new System.Drawing.Point(688, 219);
            this.btnLogOutBookARoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOutBookARoom.Name = "btnLogOutBookARoom";
            this.btnLogOutBookARoom.Size = new System.Drawing.Size(85, 32);
            this.btnLogOutBookARoom.TabIndex = 5;
            this.btnLogOutBookARoom.Text = "Log Out";
            this.btnLogOutBookARoom.UseVisualStyleBackColor = true;
            this.btnLogOutBookARoom.Click += new System.EventHandler(this.btnLogOutBookARoom_Click);
            // 
            // DGAvailableRooms
            // 
            this.DGAvailableRooms.AllowUserToAddRows = false;
            this.DGAvailableRooms.AllowUserToDeleteRows = false;
            this.DGAvailableRooms.AllowUserToResizeColumns = false;
            this.DGAvailableRooms.AllowUserToResizeRows = false;
            this.DGAvailableRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGAvailableRooms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGAvailableRooms.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGAvailableRooms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGAvailableRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGAvailableRooms.ColumnHeadersVisible = false;
            this.DGAvailableRooms.Location = new System.Drawing.Point(15, 262);
            this.DGAvailableRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGAvailableRooms.MultiSelect = false;
            this.DGAvailableRooms.Name = "DGAvailableRooms";
            this.DGAvailableRooms.ReadOnly = true;
            this.DGAvailableRooms.RowHeadersVisible = false;
            this.DGAvailableRooms.RowTemplate.Height = 24;
            this.DGAvailableRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGAvailableRooms.Size = new System.Drawing.Size(771, 303);
            this.DGAvailableRooms.TabIndex = 6;
            this.DGAvailableRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGAvailableRooms_CellClick);
            this.DGAvailableRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGAvailableRooms_CellContentClick_1);
            // 
            // calBookRoom
            // 
            this.calBookRoom.Location = new System.Drawing.Point(251, 52);
            this.calBookRoom.MaxSelectionCount = 1;
            this.calBookRoom.Name = "calBookRoom";
            this.calBookRoom.TabIndex = 7;
            this.calBookRoom.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calBookRoom_DateChanged);
            // 
            // lblBookARoom
            // 
            this.lblBookARoom.AutoSize = true;
            this.lblBookARoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookARoom.Location = new System.Drawing.Point(300, 11);
            this.lblBookARoom.Name = "lblBookARoom";
            this.lblBookARoom.Size = new System.Drawing.Size(188, 32);
            this.lblBookARoom.TabIndex = 8;
            this.lblBookARoom.Text = "Book A Room";
            // 
            // btnBookRoom
            // 
            this.btnBookRoom.Location = new System.Drawing.Point(584, 219);
            this.btnBookRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBookRoom.Name = "btnBookRoom";
            this.btnBookRoom.Size = new System.Drawing.Size(84, 32);
            this.btnBookRoom.TabIndex = 9;
            this.btnBookRoom.Text = "Book";
            this.btnBookRoom.UseVisualStyleBackColor = true;
            this.btnBookRoom.Click += new System.EventHandler(this.btnBookRoom_Click);
            // 
            // BookRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.btnBookRoom);
            this.Controls.Add(this.lblBookARoom);
            this.Controls.Add(this.calBookRoom);
            this.Controls.Add(this.DGAvailableRooms);
            this.Controls.Add(this.btnLogOutBookARoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BookRoom";
            this.Text = "BookRoom";
            this.Load += new System.EventHandler(this.BookRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGAvailableRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOutBookARoom;
        private System.Windows.Forms.DataGridView DGAvailableRooms;
        private System.Windows.Forms.MonthCalendar calBookRoom;
        private System.Windows.Forms.Label lblBookARoom;
        private System.Windows.Forms.Button btnBookRoom;
    }
}