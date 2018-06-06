namespace WindowsFormsApp1
{
    partial class insert_city_form
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
            this.tb_obl = new System.Windows.Forms.TextBox();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ok_btn = new System.Windows.Forms.Button();
            this.cnl_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(192, 31);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_name.MaxLength = 32;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(197, 22);
            this.tb_name.TabIndex = 0;
            // 
            // tb_obl
            // 
            this.tb_obl.Location = new System.Drawing.Point(192, 92);
            this.tb_obl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_obl.MaxLength = 64;
            this.tb_obl.Name = "tb_obl";
            this.tb_obl.Size = new System.Drawing.Size(197, 22);
            this.tb_obl.TabIndex = 1;
            // 
            // tb_code
            // 
            this.tb_code.Location = new System.Drawing.Point(192, 148);
            this.tb_code.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_code.MaxLength = 4;
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(197, 22);
            this.tb_code.TabIndex = 2;
            this.tb_code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_code_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Область";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Телефонный код";
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(16, 199);
            this.ok_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(100, 28);
            this.ok_btn.TabIndex = 6;
            this.ok_btn.Text = "Добавить";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // cnl_btn
            // 
            this.cnl_btn.Location = new System.Drawing.Point(291, 199);
            this.cnl_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cnl_btn.Name = "cnl_btn";
            this.cnl_btn.Size = new System.Drawing.Size(100, 28);
            this.cnl_btn.TabIndex = 7;
            this.cnl_btn.Text = "Отмена";
            this.cnl_btn.UseVisualStyleBackColor = true;
            this.cnl_btn.Click += new System.EventHandler(this.cnl_btn_Click);
            // 
            // insert_city_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 251);
            this.Controls.Add(this.cnl_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_code);
            this.Controls.Add(this.tb_obl);
            this.Controls.Add(this.tb_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "insert_city_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery service";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.insert_city_form_FormClosed);
            this.Load += new System.EventHandler(this.insert_city_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_obl;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button cnl_btn;
    }
}