namespace WindowsFormsApp1
{
    partial class insert_ref_form
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
            this.tb_pr = new System.Windows.Forms.TextBox();
            this.tb_resh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ok_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_pr
            // 
            this.tb_pr.Location = new System.Drawing.Point(192, 23);
            this.tb_pr.MaxLength = 512;
            this.tb_pr.Multiline = true;
            this.tb_pr.Name = "tb_pr";
            this.tb_pr.Size = new System.Drawing.Size(267, 69);
            this.tb_pr.TabIndex = 0;
            // 
            // tb_resh
            // 
            this.tb_resh.Location = new System.Drawing.Point(192, 112);
            this.tb_resh.MaxLength = 512;
            this.tb_resh.Multiline = true;
            this.tb_resh.Name = "tb_resh";
            this.tb_resh.Size = new System.Drawing.Size(267, 71);
            this.tb_resh.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Причина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Решение";
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(48, 202);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(107, 35);
            this.ok_btn.TabIndex = 4;
            this.ok_btn.Text = "Добавить";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // insert_ref_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 249);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_resh);
            this.Controls.Add(this.tb_pr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "insert_ref_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery service";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.insert_ref_form_FormClosing);
            this.Load += new System.EventHandler(this.insert_ref_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_pr;
        private System.Windows.Forms.TextBox tb_resh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ok_btn;
    }
}