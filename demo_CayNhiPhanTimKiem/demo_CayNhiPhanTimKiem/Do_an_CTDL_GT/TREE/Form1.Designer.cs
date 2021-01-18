namespace AVL_TREE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btInsert = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.btFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.lbPrintf = new System.Windows.Forms.Label();
            this.txtPrintf = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.btRandom = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.nbUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btInsert
            // 
            this.btInsert.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btInsert.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.ForeColor = System.Drawing.Color.White;
            this.btInsert.Location = new System.Drawing.Point(454, 6);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(75, 27);
            this.btInsert.TabIndex = 0;
            this.btInsert.Text = "Thêm ";
            this.btInsert.UseVisualStyleBackColor = false;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btdelete
            // 
            this.btdelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btdelete.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdelete.ForeColor = System.Drawing.Color.White;
            this.btdelete.Location = new System.Drawing.Point(454, 35);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 27);
            this.btdelete.TabIndex = 1;
            this.btdelete.Text = "Xóa";
            this.btdelete.UseVisualStyleBackColor = false;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // txtInsert
            // 
            this.txtInsert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInsert.Location = new System.Drawing.Point(330, 9);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(100, 23);
            this.txtInsert.TabIndex = 2;
            // 
            // txtDelete
            // 
            this.txtDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDelete.Location = new System.Drawing.Point(330, 42);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(100, 23);
            this.txtDelete.TabIndex = 3;
            // 
            // btFind
            // 
            this.btFind.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btFind.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFind.ForeColor = System.Drawing.Color.White;
            this.btFind.Location = new System.Drawing.Point(682, 16);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(75, 29);
            this.btFind.TabIndex = 4;
            this.btFind.Text = "Tìm Kiếm";
            this.btFind.UseVisualStyleBackColor = false;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFind.Location = new System.Drawing.Point(576, 21);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(100, 23);
            this.txtFind.TabIndex = 5;
            // 
            // lbPrintf
            // 
            this.lbPrintf.AutoSize = true;
            this.lbPrintf.Location = new System.Drawing.Point(25, 459);
            this.lbPrintf.Name = "lbPrintf";
            this.lbPrintf.Size = new System.Drawing.Size(0, 13);
            this.lbPrintf.TabIndex = 7;
            // 
            // txtPrintf
            // 
            this.txtPrintf.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPrintf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrintf.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrintf.ForeColor = System.Drawing.Color.White;
            this.txtPrintf.Location = new System.Drawing.Point(-1, 486);
            this.txtPrintf.Name = "txtPrintf";
            this.txtPrintf.ReadOnly = true;
            this.txtPrintf.Size = new System.Drawing.Size(1134, 26);
            this.txtPrintf.TabIndex = 9;
            this.txtPrintf.TextChanged += new System.EventHandler(this.txtPrintf_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Controls.Add(this.btRandom);
            this.panel1.Controls.Add(this.btClear);
            this.panel1.Controls.Add(this.nbUpDown);
            this.panel1.Controls.Add(this.txtDelete);
            this.panel1.Controls.Add(this.btInsert);
            this.panel1.Controls.Add(this.btdelete);
            this.panel1.Controls.Add(this.txtInsert);
            this.panel1.Controls.Add(this.btFind);
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 66);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btExit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.Location = new System.Drawing.Point(127, 35);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(111, 28);
            this.btExit.TabIndex = 12;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btRandom
            // 
            this.btRandom.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btRandom.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRandom.ForeColor = System.Drawing.Color.White;
            this.btRandom.Location = new System.Drawing.Point(127, 0);
            this.btRandom.Name = "btRandom";
            this.btRandom.Size = new System.Drawing.Size(111, 31);
            this.btRandom.TabIndex = 13;
            this.btRandom.Text = "Tạo ngẫu nhiên";
            this.btRandom.UseVisualStyleBackColor = false;
            this.btRandom.Click += new System.EventHandler(this.btRandom_Click);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btClear.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.ForeColor = System.Drawing.Color.White;
            this.btClear.Location = new System.Drawing.Point(10, 35);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(89, 28);
            this.btClear.TabIndex = 11;
            this.btClear.Text = "Xóa cây";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // nbUpDown
            // 
            this.nbUpDown.Location = new System.Drawing.Point(10, 6);
            this.nbUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nbUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbUpDown.Name = "nbUpDown";
            this.nbUpDown.Size = new System.Drawing.Size(89, 23);
            this.nbUpDown.TabIndex = 15;
            this.nbUpDown.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1131, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPrintf);
            this.Controls.Add(this.lbPrintf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CÂY NHỊ PHÂN TÌM KIẾM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label lbPrintf;
        private System.Windows.Forms.TextBox txtPrintf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btRandom;
        private System.Windows.Forms.NumericUpDown nbUpDown;
    }
}

