namespace WindowsFormsApp1
{
    partial class insert_vk_form
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_charge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ok_btn = new System.Windows.Forms.Button();
            this.cncl_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(181, 44);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_name.MaxLength = 32;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(191, 22);
            this.tb_name.TabIndex = 0;
            this.tb_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tb_charge
            // 
            this.tb_charge.Location = new System.Drawing.Point(181, 98);
            this.tb_charge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_charge.MaxLength = 2;
            this.tb_charge.Name = "tb_charge";
            this.tb_charge.Size = new System.Drawing.Size(191, 22);
            this.tb_charge.TabIndex = 1;
            this.tb_charge.TextChanged += new System.EventHandler(this.tb_charge_TextChanged);
            this.tb_charge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Наценка";
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(12, 148);
            this.ok_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(100, 28);
            this.ok_btn.TabIndex = 4;
            this.ok_btn.Text = "Добавить";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // cncl_btn
            // 
            this.cncl_btn.Location = new System.Drawing.Point(272, 148);
            this.cncl_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cncl_btn.Name = "cncl_btn";
            this.cncl_btn.Size = new System.Drawing.Size(100, 28);
            this.cncl_btn.TabIndex = 5;
            this.cncl_btn.Text = "Отменить";
            this.cncl_btn.UseVisualStyleBackColor = true;
            this.cncl_btn.Click += new System.EventHandler(this.cncl_btn_Click);
            // 
            // insert_vk_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 192);
            this.Controls.Add(this.cncl_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_charge);
            this.Controls.Add(this.tb_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "insert_vk_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery service";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.insert_vk_form_FormClosing);
            this.Load += new System.EventHandler(this.insert_vk_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_charge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button cncl_btn;
    }
}