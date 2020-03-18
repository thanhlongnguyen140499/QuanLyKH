namespace _102170286_NguyenThanhLong_17TCLC2
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
            this.datagrview_1 = new System.Windows.Forms.DataGridView();
            this.txtBox_Search = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.cbBox_Sort = new System.Windows.Forms.ComboBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Showtest = new System.Windows.Forms.Button();
            this.cbbox_HoTen = new System.Windows.Forms.ComboBox();
            this.lb_HoTen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrview_1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrview_1
            // 
            this.datagrview_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrview_1.Location = new System.Drawing.Point(26, 59);
            this.datagrview_1.Name = "datagrview_1";
            this.datagrview_1.Size = new System.Drawing.Size(546, 166);
            this.datagrview_1.TabIndex = 154;
            // 
            // txtBox_Search
            // 
            this.txtBox_Search.Location = new System.Drawing.Point(352, 259);
            this.txtBox_Search.Multiline = true;
            this.txtBox_Search.Name = "txtBox_Search";
            this.txtBox_Search.Size = new System.Drawing.Size(154, 23);
            this.txtBox_Search.TabIndex = 149;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(38, 257);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 143;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Sort
            // 
            this.btn_Sort.Location = new System.Drawing.Point(512, 286);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(75, 23);
            this.btn_Sort.TabIndex = 147;
            this.btn_Sort.Text = "Sort";
            this.btn_Sort.UseVisualStyleBackColor = true;
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(513, 259);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 146;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.ForeColor = System.Drawing.Color.Red;
            this.btn_Delete.Location = new System.Drawing.Point(248, 257);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 145;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // cbBox_Sort
            // 
            this.cbBox_Sort.FormattingEnabled = true;
            this.cbBox_Sort.Items.AddRange(new object[] {
            "MSKH",
            "HoTen"});
            this.cbBox_Sort.Location = new System.Drawing.Point(352, 288);
            this.cbBox_Sort.Name = "cbBox_Sort";
            this.cbBox_Sort.Size = new System.Drawing.Size(154, 21);
            this.cbBox_Sort.TabIndex = 150;
            this.cbBox_Sort.SelectedIndexChanged += new System.EventHandler(this.cbBox_Sort_SelectedIndexChanged);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(144, 257);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 144;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Showtest
            // 
            this.btn_Showtest.Location = new System.Drawing.Point(38, 299);
            this.btn_Showtest.Name = "btn_Showtest";
            this.btn_Showtest.Size = new System.Drawing.Size(75, 23);
            this.btn_Showtest.TabIndex = 155;
            this.btn_Showtest.Text = "SHOW Test";
            this.btn_Showtest.UseVisualStyleBackColor = true;
            this.btn_Showtest.Click += new System.EventHandler(this.btn_Showtest_Click);
            // 
            // cbbox_HoTen
            // 
            this.cbbox_HoTen.FormattingEnabled = true;
            this.cbbox_HoTen.Items.AddRange(new object[] {
            "Long A",
            "Long B",
            "Long C",
            "Long D"});
            this.cbbox_HoTen.Location = new System.Drawing.Point(165, 19);
            this.cbbox_HoTen.Name = "cbbox_HoTen";
            this.cbbox_HoTen.Size = new System.Drawing.Size(121, 21);
            this.cbbox_HoTen.TabIndex = 156;
            this.cbbox_HoTen.SelectedIndexChanged += new System.EventHandler(this.cbbox_HoTen_SelectedIndexChanged);
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.AutoSize = true;
            this.lb_HoTen.Location = new System.Drawing.Point(50, 22);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.Size = new System.Drawing.Size(95, 13);
            this.lb_HoTen.TabIndex = 157;
            this.lb_HoTen.Text = "Tên khách hàng  :";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 347);
            this.Controls.Add(this.lb_HoTen);
            this.Controls.Add(this.cbbox_HoTen);
            this.Controls.Add(this.btn_Showtest);
            this.Controls.Add(this.datagrview_1);
            this.Controls.Add(this.txtBox_Search);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Sort);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.cbBox_Sort);
            this.Controls.Add(this.btn_Update);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrview_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrview_1;
        private System.Windows.Forms.TextBox txtBox_Search;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ComboBox cbBox_Sort;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Showtest;
        private System.Windows.Forms.ComboBox cbbox_HoTen;
        private System.Windows.Forms.Label lb_HoTen;
    }
}

