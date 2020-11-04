namespace Ernie
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum5 = new System.Windows.Forms.TextBox();
            this.txtNum4 = new System.Windows.Forms.TextBox();
            this.txtPB = new System.Windows.Forms.TextBox();
            this.txtNum6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum7 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(46, 111);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(362, 41);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(46, 68);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(36, 22);
            this.txtNum1.TabIndex = 1;
            // 
            // txtNum3
            // 
            this.txtNum3.Location = new System.Drawing.Point(130, 68);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(36, 22);
            this.txtNum3.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(88, 68);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(36, 22);
            this.txtNum2.TabIndex = 3;
            // 
            // txtNum5
            // 
            this.txtNum5.Location = new System.Drawing.Point(214, 68);
            this.txtNum5.Name = "txtNum5";
            this.txtNum5.Size = new System.Drawing.Size(36, 22);
            this.txtNum5.TabIndex = 4;
            // 
            // txtNum4
            // 
            this.txtNum4.Location = new System.Drawing.Point(172, 68);
            this.txtNum4.Name = "txtNum4";
            this.txtNum4.Size = new System.Drawing.Size(36, 22);
            this.txtNum4.TabIndex = 5;
            // 
            // txtPB
            // 
            this.txtPB.Location = new System.Drawing.Point(372, 68);
            this.txtPB.Name = "txtPB";
            this.txtPB.Size = new System.Drawing.Size(36, 22);
            this.txtPB.TabIndex = 6;
            // 
            // txtNum6
            // 
            this.txtNum6.Location = new System.Drawing.Point(256, 68);
            this.txtNum6.Name = "txtNum6";
            this.txtNum6.Size = new System.Drawing.Size(36, 22);
            this.txtNum6.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Power Ball";
            // 
            // txtNum7
            // 
            this.txtNum7.Location = new System.Drawing.Point(298, 68);
            this.txtNum7.Name = "txtNum7";
            this.txtNum7.Size = new System.Drawing.Size(36, 22);
            this.txtNum7.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Game Numbers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 192);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNum6);
            this.Controls.Add(this.txtPB);
            this.Controls.Add(this.txtNum4);
            this.Controls.Add(this.txtNum5);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Power Ball";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum5;
        private System.Windows.Forms.TextBox txtNum4;
        private System.Windows.Forms.TextBox txtPB;
        private System.Windows.Forms.TextBox txtNum6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum7;
        private System.Windows.Forms.Label label2;
    }
}

