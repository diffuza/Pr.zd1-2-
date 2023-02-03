namespace Практическая_1_2
{
    partial class frmSumma
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
            this.btnExit = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtSumma = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnCount1 = new System.Windows.Forms.Button();
            this.btnCount2 = new System.Windows.Forms.Button();
            this.btnCount3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(346, 225);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(58, 125);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 23);
            this.txtA.TabIndex = 1;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(185, 125);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 23);
            this.txtB.TabIndex = 2;
            // 
            // txtSumma
            // 
            this.txtSumma.Location = new System.Drawing.Point(321, 125);
            this.txtSumma.Name = "txtSumma";
            this.txtSumma.Size = new System.Drawing.Size(100, 23);
            this.txtSumma.TabIndex = 3;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(85, 196);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(218, 23);
            this.btnCount.TabIndex = 4;
            this.btnCount.Text = "Вычислить сумму модулей";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnCount1
            // 
            this.btnCount1.Location = new System.Drawing.Point(85, 225);
            this.btnCount1.Name = "btnCount1";
            this.btnCount1.Size = new System.Drawing.Size(218, 23);
            this.btnCount1.TabIndex = 5;
            this.btnCount1.Text = "Вычислить разность модулей ";
            this.btnCount1.UseVisualStyleBackColor = true;
            this.btnCount1.Click += new System.EventHandler(this.btnCount1_Click);
            // 
            // btnCount2
            // 
            this.btnCount2.Location = new System.Drawing.Point(85, 254);
            this.btnCount2.Name = "btnCount2";
            this.btnCount2.Size = new System.Drawing.Size(218, 23);
            this.btnCount2.TabIndex = 6;
            this.btnCount2.Text = "Вычислить произведение модулей";
            this.btnCount2.UseVisualStyleBackColor = true;
            this.btnCount2.Click += new System.EventHandler(this.btnCount2_Click);
            // 
            // btnCount3
            // 
            this.btnCount3.Location = new System.Drawing.Point(85, 283);
            this.btnCount3.Name = "btnCount3";
            this.btnCount3.Size = new System.Drawing.Size(218, 23);
            this.btnCount3.TabIndex = 7;
            this.btnCount3.Text = "Вычислить частное модулей";
            this.btnCount3.UseVisualStyleBackColor = true;
            this.btnCount3.Click += new System.EventHandler(this.btnCount3_Click);
            // 
            // frmSumma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCount3);
            this.Controls.Add(this.btnCount2);
            this.Controls.Add(this.btnCount1);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtSumma);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnExit);
            this.Name = "frmSumma";
            this.Text = "Задание 2";
            this.Load += new System.EventHandler(this.frmSumma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExit;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtSumma;
        private Button btnCount;
        private Button btnCount1;
        private Button btnCount2;
        private Button btnCount3;
    }
}