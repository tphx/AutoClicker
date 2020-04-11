namespace AutoClicker
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
            this.betweenClickMin = new System.Windows.Forms.TextBox();
            this.betweenClickMax = new System.Windows.Forms.TextBox();
            this.holdDownMax = new System.Windows.Forms.TextBox();
            this.holdDownMin = new System.Windows.Forms.TextBox();
            this.activationKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // betweenClickMin
            // 
            this.betweenClickMin.Location = new System.Drawing.Point(27, 47);
            this.betweenClickMin.Name = "betweenClickMin";
            this.betweenClickMin.Size = new System.Drawing.Size(100, 22);
            this.betweenClickMin.TabIndex = 0;
            this.betweenClickMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.betweenClickMin.Leave += new System.EventHandler(this.betweenClickMin_Leave);
            // 
            // betweenClickMax
            // 
            this.betweenClickMax.Location = new System.Drawing.Point(151, 47);
            this.betweenClickMax.Name = "betweenClickMax";
            this.betweenClickMax.Size = new System.Drawing.Size(100, 22);
            this.betweenClickMax.TabIndex = 1;
            this.betweenClickMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.betweenClickMax.Leave += new System.EventHandler(this.betweenClickMax_Leave);
            // 
            // holdDownMax
            // 
            this.holdDownMax.Location = new System.Drawing.Point(151, 128);
            this.holdDownMax.Name = "holdDownMax";
            this.holdDownMax.Size = new System.Drawing.Size(100, 22);
            this.holdDownMax.TabIndex = 3;
            this.holdDownMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.holdDownMax.Leave += new System.EventHandler(this.holdDownMax_Leave);
            // 
            // holdDownMin
            // 
            this.holdDownMin.Location = new System.Drawing.Point(27, 128);
            this.holdDownMin.Name = "holdDownMin";
            this.holdDownMin.Size = new System.Drawing.Size(100, 22);
            this.holdDownMin.TabIndex = 2;
            this.holdDownMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.holdDownMin.Leave += new System.EventHandler(this.holdDownMin_Leave);
            // 
            // activationKey
            // 
            this.activationKey.Location = new System.Drawing.Point(87, 205);
            this.activationKey.Name = "activationKey";
            this.activationKey.Size = new System.Drawing.Size(100, 22);
            this.activationKey.TabIndex = 4;
            this.activationKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.activationKey.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.activationKey_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Activation Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Time Between Clicks";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Click Hold Down";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 251);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.activationKey);
            this.Controls.Add(this.holdDownMax);
            this.Controls.Add(this.holdDownMin);
            this.Controls.Add(this.betweenClickMax);
            this.Controls.Add(this.betweenClickMin);
            this.Name = "Form1";
            this.Text = "ACV1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox betweenClickMin;
        private System.Windows.Forms.TextBox betweenClickMax;
        private System.Windows.Forms.TextBox holdDownMax;
        private System.Windows.Forms.TextBox holdDownMin;
        private System.Windows.Forms.TextBox activationKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

