namespace Dbfilmconnec
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttselect = new System.Windows.Forms.Button();
            this.buttinsert = new System.Windows.Forms.Button();
            this.buttupdate = new System.Windows.Forms.Button();
            this.buttdelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(278, 320);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(278, 383);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 3;
            // 
            // buttselect
            // 
            this.buttselect.Location = new System.Drawing.Point(626, 30);
            this.buttselect.Name = "buttselect";
            this.buttselect.Size = new System.Drawing.Size(94, 219);
            this.buttselect.TabIndex = 4;
            this.buttselect.Text = "select";
            this.buttselect.UseVisualStyleBackColor = true;
            this.buttselect.Click += new System.EventHandler(this.buttselect_Click);
            // 
            // buttinsert
            // 
            this.buttinsert.Location = new System.Drawing.Point(626, 299);
            this.buttinsert.Name = "buttinsert";
            this.buttinsert.Size = new System.Drawing.Size(94, 29);
            this.buttinsert.TabIndex = 5;
            this.buttinsert.Text = "insert";
            this.buttinsert.UseVisualStyleBackColor = true;
            this.buttinsert.Click += new System.EventHandler(this.buttinsert_Click);
            // 
            // buttupdate
            // 
            this.buttupdate.Location = new System.Drawing.Point(626, 345);
            this.buttupdate.Name = "buttupdate";
            this.buttupdate.Size = new System.Drawing.Size(94, 29);
            this.buttupdate.TabIndex = 6;
            this.buttupdate.Text = "update";
            this.buttupdate.UseVisualStyleBackColor = true;
            this.buttupdate.Click += new System.EventHandler(this.buttupdate_Click);
            // 
            // buttdelete
            // 
            this.buttdelete.Location = new System.Drawing.Point(626, 394);
            this.buttdelete.Name = "buttdelete";
            this.buttdelete.Size = new System.Drawing.Size(94, 29);
            this.buttdelete.TabIndex = 7;
            this.buttdelete.Text = "delete";
            this.buttdelete.UseVisualStyleBackColor = true;
            this.buttdelete.Click += new System.EventHandler(this.buttdelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(499, 219);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttdelete);
            this.Controls.Add(this.buttupdate);
            this.Controls.Add(this.buttinsert);
            this.Controls.Add(this.buttselect);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttselect;
        private Button buttinsert;
        private Button buttupdate;
        private Button buttdelete;
        private DataGridView dataGridView1;
    }
}