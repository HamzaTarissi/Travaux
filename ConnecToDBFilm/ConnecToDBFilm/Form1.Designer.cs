namespace ConnectoDBFilm
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
            this.buttselect = new System.Windows.Forms.Button();
            this.buttinsert = new System.Windows.Forms.Button();
            this.buttupdate = new System.Windows.Forms.Button();
            this.buttdelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttselect
            // 
            this.buttselect.Location = new System.Drawing.Point(545, 66);
            this.buttselect.Name = "buttselect";
            this.buttselect.Size = new System.Drawing.Size(164, 242);
            this.buttselect.TabIndex = 0;
            this.buttselect.Text = "select";
            this.buttselect.UseVisualStyleBackColor = true;
            this.buttselect.Click += new System.EventHandler(this.buttselect_Click_1);
            // 
            // buttinsert
            // 
            this.buttinsert.Location = new System.Drawing.Point(53, 365);
            this.buttinsert.Name = "buttinsert";
            this.buttinsert.Size = new System.Drawing.Size(94, 29);
            this.buttinsert.TabIndex = 1;
            this.buttinsert.Text = "insert";
            this.buttinsert.UseVisualStyleBackColor = true;
            this.buttinsert.Click += new System.EventHandler(this.buttinsert_Click);
            // 
            // buttupdate
            // 
            this.buttupdate.Location = new System.Drawing.Point(234, 365);
            this.buttupdate.Name = "buttupdate";
            this.buttupdate.Size = new System.Drawing.Size(94, 29);
            this.buttupdate.TabIndex = 2;
            this.buttupdate.Text = "update";
            this.buttupdate.UseVisualStyleBackColor = true;
            this.buttupdate.Click += new System.EventHandler(this.buttupdate_Click);
            // 
            // buttdelete
            // 
            this.buttdelete.Location = new System.Drawing.Point(402, 365);
            this.buttdelete.Name = "buttdelete";
            this.buttdelete.Size = new System.Drawing.Size(94, 29);
            this.buttdelete.TabIndex = 3;
            this.buttdelete.Text = "delete";
            this.buttdelete.UseVisualStyleBackColor = true;
            this.buttdelete.Click += new System.EventHandler(this.buttdelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(443, 242);
            this.dataGridView1.TabIndex = 4;
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
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttselect;
        private Button buttinsert;
        private Button buttupdate;
        private Button buttdelete;
        private DataGridView dataGridView1;
    }
}