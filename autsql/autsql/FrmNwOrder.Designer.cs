﻿namespace autsql
{
    partial class FrmNwOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.textOrder = new System.Windows.Forms.TextBox();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单名";
            // 
            // textOrder
            // 
            this.textOrder.Location = new System.Drawing.Point(96, 26);
            this.textOrder.Name = "textOrder";
            this.textOrder.Size = new System.Drawing.Size(165, 21);
            this.textOrder.TabIndex = 1;
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(122, 66);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(69, 23);
            this.btnconfirm.TabIndex = 2;
            this.btnconfirm.Text = "确定";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmNwOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 102);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.textOrder);
            this.Controls.Add(this.label1);
            this.Name = "FrmNwOrder";
            this.Text = "创建新订单";
            this.Load += new System.EventHandler(this.FrmNwOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textOrder;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Button button2;
    }
}