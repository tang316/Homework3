﻿namespace Homework3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAllClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCM = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.txtYard = new System.Windows.Forms.TextBox();
            this.txtFt = new System.Windows.Forms.TextBox();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAllClear
            // 
            this.btnAllClear.Location = new System.Drawing.Point(118, 54);
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.Size = new System.Drawing.Size(156, 50);
            this.btnAllClear.TabIndex = 0;
            this.btnAllClear.Text = "清除";
            this.btnAllClear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "公分";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "公尺";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "公里";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "英吋";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "英呎";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "碼";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "說明文字";
            // 
            // txtCM
            // 
            this.txtCM.Location = new System.Drawing.Point(137, 174);
            this.txtCM.Name = "txtCM";
            this.txtCM.Size = new System.Drawing.Size(101, 25);
            this.txtCM.TabIndex = 8;
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(300, 174);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(101, 25);
            this.txtM.TabIndex = 9;
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(463, 174);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(101, 25);
            this.txtKM.TabIndex = 10;
            // 
            // txtYard
            // 
            this.txtYard.Location = new System.Drawing.Point(463, 260);
            this.txtYard.Name = "txtYard";
            this.txtYard.Size = new System.Drawing.Size(101, 25);
            this.txtYard.TabIndex = 11;
            // 
            // txtFt
            // 
            this.txtFt.Location = new System.Drawing.Point(300, 260);
            this.txtFt.Name = "txtFt";
            this.txtFt.Size = new System.Drawing.Size(101, 25);
            this.txtFt.TabIndex = 12;
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(137, 260);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(101, 25);
            this.txtIn.TabIndex = 13;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(137, 350);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(371, 25);
            this.txtInfo.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.txtFt);
            this.Controls.Add(this.txtYard);
            this.Controls.Add(this.txtKM);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtCM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAllClear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAllClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCM;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.TextBox txtYard;
        private System.Windows.Forms.TextBox txtFt;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.TextBox txtInfo;
    }
}

