namespace WindowsFormsApp_Hotel
{
    partial class RoomId
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Showbutton = new System.Windows.Forms.Button();
            this.roomidtext = new System.Windows.Forms.TextBox();
            this.roomidbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Room_Info = new System.Windows.Forms.DataGridView();
            this.TotalAmount = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cusidtext = new System.Windows.Forms.TextBox();
            this.Calculatebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Room_Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(759, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(856, 556);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Showbutton
            // 
            this.Showbutton.Location = new System.Drawing.Point(1107, 621);
            this.Showbutton.Name = "Showbutton";
            this.Showbutton.Size = new System.Drawing.Size(341, 83);
            this.Showbutton.TabIndex = 1;
            this.Showbutton.Text = "Show";
            this.Showbutton.UseVisualStyleBackColor = true;
            this.Showbutton.Click += new System.EventHandler(this.Showbutton_Click);
            // 
            // roomidtext
            // 
            this.roomidtext.Location = new System.Drawing.Point(215, 129);
            this.roomidtext.Name = "roomidtext";
            this.roomidtext.Size = new System.Drawing.Size(172, 31);
            this.roomidtext.TabIndex = 2;
            // 
            // roomidbutton
            // 
            this.roomidbutton.Location = new System.Drawing.Point(240, 186);
            this.roomidbutton.Name = "roomidbutton";
            this.roomidbutton.Size = new System.Drawing.Size(108, 44);
            this.roomidbutton.TabIndex = 3;
            this.roomidbutton.Text = "Search";
            this.roomidbutton.UseVisualStyleBackColor = true;
            this.roomidbutton.Click += new System.EventHandler(this.roomidbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Room number:";
            // 
            // Room_Info
            // 
            this.Room_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Room_Info.Location = new System.Drawing.Point(24, 288);
            this.Room_Info.Name = "Room_Info";
            this.Room_Info.RowHeadersWidth = 82;
            this.Room_Info.RowTemplate.Height = 33;
            this.Room_Info.Size = new System.Drawing.Size(550, 276);
            this.Room_Info.TabIndex = 5;
            this.Room_Info.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Room_Info_CellContentClick);
            // 
            // TotalAmount
            // 
            this.TotalAmount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TotalAmount.Location = new System.Drawing.Point(187, 725);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.RowHeadersWidth = 82;
            this.TotalAmount.RowTemplate.Height = 33;
            this.TotalAmount.Size = new System.Drawing.Size(334, 159);
            this.TotalAmount.TabIndex = 6;
            this.TotalAmount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TotalAmount_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 608);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Customer Id for Amount:";
            // 
            // cusidtext
            // 
            this.cusidtext.Location = new System.Drawing.Point(440, 608);
            this.cusidtext.Name = "cusidtext";
            this.cusidtext.Size = new System.Drawing.Size(100, 31);
            this.cusidtext.TabIndex = 8;
            this.cusidtext.TextChanged += new System.EventHandler(this.cusidtext_TextChanged);
            // 
            // Calculatebutton
            // 
            this.Calculatebutton.Location = new System.Drawing.Point(420, 658);
            this.Calculatebutton.Name = "Calculatebutton";
            this.Calculatebutton.Size = new System.Drawing.Size(135, 35);
            this.Calculatebutton.TabIndex = 9;
            this.Calculatebutton.Text = "Calculate";
            this.Calculatebutton.UseVisualStyleBackColor = true;
            this.Calculatebutton.Click += new System.EventHandler(this.Calculatebutton_Click);
            // 
            // RoomId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1649, 979);
            this.Controls.Add(this.Calculatebutton);
            this.Controls.Add(this.cusidtext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalAmount);
            this.Controls.Add(this.Room_Info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomidbutton);
            this.Controls.Add(this.roomidtext);
            this.Controls.Add(this.Showbutton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RoomId";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RoomId_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Room_Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Showbutton;
        private System.Windows.Forms.TextBox roomidtext;
        private System.Windows.Forms.Button roomidbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Room_Info;
        private System.Windows.Forms.DataGridView TotalAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cusidtext;
        private System.Windows.Forms.Button Calculatebutton;
    }
}

