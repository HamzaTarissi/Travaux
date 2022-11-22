namespace Calculator
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
            this.UserTextInput = new System.Windows.Forms.TextBox();
            this.Calculationresult = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.equal = new System.Windows.Forms.Button();
            this.coma = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.Pourcentage = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserTextInput
            // 
            this.UserTextInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserTextInput.Location = new System.Drawing.Point(6, 23);
            this.UserTextInput.Name = "UserTextInput";
            this.UserTextInput.Size = new System.Drawing.Size(510, 22);
            this.UserTextInput.TabIndex = 0;
            // 
            // Calculationresult
            // 
            this.Calculationresult.Location = new System.Drawing.Point(3, 58);
            this.Calculationresult.Name = "Calculationresult";
            this.Calculationresult.Size = new System.Drawing.Size(722, 74);
            this.Calculationresult.TabIndex = 1;
            this.Calculationresult.Text = "Entrer an equation and press enter to see results";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.ColumnCount = 4;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.Controls.Add(this.equal, 3, 4);
            this.ButtonsPanel.Controls.Add(this.coma, 2, 4);
            this.ButtonsPanel.Controls.Add(this.zero, 1, 4);
            this.ButtonsPanel.Controls.Add(this.plus, 3, 3);
            this.ButtonsPanel.Controls.Add(this.one, 2, 3);
            this.ButtonsPanel.Controls.Add(this.two, 1, 3);
            this.ButtonsPanel.Controls.Add(this.three, 0, 3);
            this.ButtonsPanel.Controls.Add(this.minus, 3, 2);
            this.ButtonsPanel.Controls.Add(this.four, 2, 2);
            this.ButtonsPanel.Controls.Add(this.five, 1, 2);
            this.ButtonsPanel.Controls.Add(this.six, 0, 2);
            this.ButtonsPanel.Controls.Add(this.multiply, 3, 1);
            this.ButtonsPanel.Controls.Add(this.nine, 2, 1);
            this.ButtonsPanel.Controls.Add(this.eight, 1, 1);
            this.ButtonsPanel.Controls.Add(this.seven, 0, 1);
            this.ButtonsPanel.Controls.Add(this.Pourcentage, 3, 0);
            this.ButtonsPanel.Controls.Add(this.Del, 2, 0);
            this.ButtonsPanel.Controls.Add(this.CE, 0, 0);
            this.ButtonsPanel.Location = new System.Drawing.Point(6, 135);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 5;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.Size = new System.Drawing.Size(510, 369);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // equal
            // 
            this.equal.AllowDrop = true;
            this.equal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equal.Location = new System.Drawing.Point(384, 295);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(123, 71);
            this.equal.TabIndex = 19;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // coma
            // 
            this.coma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coma.Location = new System.Drawing.Point(257, 295);
            this.coma.Name = "coma";
            this.coma.Size = new System.Drawing.Size(121, 71);
            this.coma.TabIndex = 18;
            this.coma.Text = ".";
            this.coma.UseVisualStyleBackColor = true;
            this.coma.Click += new System.EventHandler(this.dot_Click);
            // 
            // zero
            // 
            this.zero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zero.Location = new System.Drawing.Point(130, 295);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(121, 71);
            this.zero.TabIndex = 17;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // plus
            // 
            this.plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plus.Location = new System.Drawing.Point(384, 222);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(123, 67);
            this.plus.TabIndex = 15;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // one
            // 
            this.one.Dock = System.Windows.Forms.DockStyle.Fill;
            this.one.Location = new System.Drawing.Point(257, 222);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(121, 67);
            this.one.TabIndex = 14;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.AllowDrop = true;
            this.two.AutoEllipsis = true;
            this.two.Dock = System.Windows.Forms.DockStyle.Fill;
            this.two.Location = new System.Drawing.Point(130, 222);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(121, 67);
            this.two.TabIndex = 13;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Dock = System.Windows.Forms.DockStyle.Fill;
            this.three.Location = new System.Drawing.Point(3, 222);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(121, 67);
            this.three.TabIndex = 12;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // minus
            // 
            this.minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minus.Location = new System.Drawing.Point(384, 149);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(123, 67);
            this.minus.TabIndex = 11;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // four
            // 
            this.four.Dock = System.Windows.Forms.DockStyle.Fill;
            this.four.Location = new System.Drawing.Point(257, 149);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(121, 67);
            this.four.TabIndex = 10;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Dock = System.Windows.Forms.DockStyle.Fill;
            this.five.Location = new System.Drawing.Point(130, 149);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(121, 67);
            this.five.TabIndex = 9;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Dock = System.Windows.Forms.DockStyle.Fill;
            this.six.Location = new System.Drawing.Point(3, 149);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(121, 67);
            this.six.TabIndex = 8;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // multiply
            // 
            this.multiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiply.Location = new System.Drawing.Point(384, 76);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(123, 67);
            this.multiply.TabIndex = 7;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // nine
            // 
            this.nine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nine.Location = new System.Drawing.Point(257, 76);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(121, 67);
            this.nine.TabIndex = 6;
            this.nine.Text = "7";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eight.Location = new System.Drawing.Point(130, 76);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(121, 67);
            this.eight.TabIndex = 5;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // seven
            // 
            this.seven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seven.Location = new System.Drawing.Point(3, 76);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(121, 67);
            this.seven.TabIndex = 4;
            this.seven.Text = "9";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // Pourcentage
            // 
            this.Pourcentage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pourcentage.Location = new System.Drawing.Point(384, 3);
            this.Pourcentage.Name = "Pourcentage";
            this.Pourcentage.Size = new System.Drawing.Size(123, 67);
            this.Pourcentage.TabIndex = 3;
            this.Pourcentage.Text = "%";
            this.Pourcentage.UseVisualStyleBackColor = true;
            this.Pourcentage.Click += new System.EventHandler(this.Pourcentage_Click);
            // 
            // Del
            // 
            this.Del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Del.Location = new System.Drawing.Point(257, 3);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(121, 67);
            this.Del.TabIndex = 2;
            this.Del.Text = "Del";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // CE
            // 
            this.CE.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CE.Location = new System.Drawing.Point(3, 3);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(121, 67);
            this.CE.TabIndex = 0;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.equal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CE;
            this.ClientSize = new System.Drawing.Size(522, 506);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.Calculationresult);
            this.Controls.Add(this.UserTextInput);
            this.MaximumSize = new System.Drawing.Size(540, 553);
            this.MinimumSize = new System.Drawing.Size(382, 553);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserTextInput;
        private System.Windows.Forms.Label Calculationresult;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Button Pourcentage;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button coma;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
    }
}

