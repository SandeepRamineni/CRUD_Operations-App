namespace CRUD_operations
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DeptID = new System.Windows.Forms.Label();
            this.text_DeptID = new System.Windows.Forms.TextBox();
            this.DeptName = new System.Windows.Forms.Label();
            this.LocationID = new System.Windows.Forms.Label();
            this.text_DeptName = new System.Windows.Forms.TextBox();
            this.text_LocID = new System.Windows.Forms.TextBox();
            this.AddNew = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.display_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DeptID
            // 
            this.DeptID.AutoSize = true;
            this.DeptID.Location = new System.Drawing.Point(14, 31);
            this.DeptID.Name = "DeptID";
            this.DeptID.Size = new System.Drawing.Size(86, 15);
            this.DeptID.TabIndex = 0;
            this.DeptID.Text = "Department ID";
            // 
            // text_DeptID
            // 
            this.text_DeptID.Location = new System.Drawing.Point(155, 28);
            this.text_DeptID.Name = "text_DeptID";
            this.text_DeptID.Size = new System.Drawing.Size(128, 21);
            this.text_DeptID.TabIndex = 1;
            // 
            // DeptName
            // 
            this.DeptName.AutoSize = true;
            this.DeptName.Location = new System.Drawing.Point(14, 74);
            this.DeptName.Name = "DeptName";
            this.DeptName.Size = new System.Drawing.Size(104, 15);
            this.DeptName.TabIndex = 2;
            this.DeptName.Text = "Department Name";
            // 
            // LocationID
            // 
            this.LocationID.AutoSize = true;
            this.LocationID.Location = new System.Drawing.Point(14, 119);
            this.LocationID.Name = "LocationID";
            this.LocationID.Size = new System.Drawing.Size(68, 15);
            this.LocationID.TabIndex = 3;
            this.LocationID.Text = "Location ID";
            // 
            // text_DeptName
            // 
            this.text_DeptName.Location = new System.Drawing.Point(155, 70);
            this.text_DeptName.Name = "text_DeptName";
            this.text_DeptName.Size = new System.Drawing.Size(128, 21);
            this.text_DeptName.TabIndex = 4;
            // 
            // text_LocID
            // 
            this.text_LocID.Location = new System.Drawing.Point(155, 115);
            this.text_LocID.Name = "text_LocID";
            this.text_LocID.Size = new System.Drawing.Size(128, 21);
            this.text_LocID.TabIndex = 5;
            // 
            // AddNew
            // 
            this.AddNew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddNew.Location = new System.Drawing.Point(14, 179);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(87, 27);
            this.AddNew.TabIndex = 6;
            this.AddNew.Text = "AddNew";
            this.AddNew.UseVisualStyleBackColor = false;
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Save.Location = new System.Drawing.Point(108, 179);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(87, 27);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Search.Location = new System.Drawing.Point(203, 179);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(87, 27);
            this.Search.TabIndex = 8;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Update.Location = new System.Drawing.Point(62, 212);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(87, 27);
            this.Update.TabIndex = 9;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete.Location = new System.Drawing.Point(155, 212);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(87, 27);
            this.Delete.TabIndex = 10;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(320, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(355, 291);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // display_button
            // 
            this.display_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.display_button.Location = new System.Drawing.Point(108, 245);
            this.display_button.Name = "display_button";
            this.display_button.Size = new System.Drawing.Size(87, 27);
            this.display_button.TabIndex = 12;
            this.display_button.Text = "Display";
            this.display_button.UseVisualStyleBackColor = false;
            this.display_button.Click += new System.EventHandler(this.display_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(701, 344);
            this.Controls.Add(this.display_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.AddNew);
            this.Controls.Add(this.text_LocID);
            this.Controls.Add(this.text_DeptName);
            this.Controls.Add(this.LocationID);
            this.Controls.Add(this.DeptName);
            this.Controls.Add(this.text_DeptID);
            this.Controls.Add(this.DeptID);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "CRUD_Buttons";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeptID;
        private System.Windows.Forms.TextBox text_DeptID;
        private System.Windows.Forms.Label DeptName;
        private System.Windows.Forms.Label LocationID;
        private System.Windows.Forms.TextBox text_DeptName;
        private System.Windows.Forms.TextBox text_LocID;
        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button display_button;
    }
}

