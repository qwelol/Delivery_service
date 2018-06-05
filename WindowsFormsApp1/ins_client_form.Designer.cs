namespace WindowsFormsApp1
{
    partial class ins_client_form
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
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_pas = new System.Windows.Forms.TextBox();
            this.tb_fam = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.tb_adr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ins_btn = new System.Windows.Forms.Button();
            this.cnl_btn = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(333, 15);
            this.tb_phone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_phone.MaxLength = 12;
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(132, 22);
            this.tb_phone.TabIndex = 0;
            this.tb_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tb_pas
            // 
            this.tb_pas.Location = new System.Drawing.Point(333, 59);
            this.tb_pas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_pas.MaxLength = 10;
            this.tb_pas.Name = "tb_pas";
            this.tb_pas.Size = new System.Drawing.Size(132, 22);
            this.tb_pas.TabIndex = 1;
            this.tb_pas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // tb_fam
            // 
            this.tb_fam.Location = new System.Drawing.Point(333, 103);
            this.tb_fam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_fam.MaxLength = 64;
            this.tb_fam.Name = "tb_fam";
            this.tb_fam.Size = new System.Drawing.Size(132, 22);
            this.tb_fam.TabIndex = 2;
            this.tb_fam.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.tb_fam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(333, 148);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_name.MaxLength = 64;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(132, 22);
            this.tb_name.TabIndex = 3;
            this.tb_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_name_KeyPress);
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(333, 192);
            this.tb_surname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_surname.MaxLength = 64;
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(132, 22);
            this.tb_surname.TabIndex = 4;
            this.tb_surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_surname_KeyPress);
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(333, 236);
            this.tb_mail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_mail.MaxLength = 32;
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(132, 22);
            this.tb_mail.TabIndex = 5;
            // 
            // tb_adr
            // 
            this.tb_adr.Location = new System.Drawing.Point(140, 281);
            this.tb_adr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_adr.MaxLength = 512;
            this.tb_adr.Multiline = true;
            this.tb_adr.Name = "tb_adr";
            this.tb_adr.Size = new System.Drawing.Size(325, 68);
            this.tb_adr.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Номер телефона*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Номер паспорта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Фамилия*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(33, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Имя*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(33, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Отчество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(33, 245);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Электронная почта";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(33, 284);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Адрес";
            // 
            // ins_btn
            // 
            this.ins_btn.Location = new System.Drawing.Point(37, 374);
            this.ins_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ins_btn.Name = "ins_btn";
            this.ins_btn.Size = new System.Drawing.Size(100, 28);
            this.ins_btn.TabIndex = 14;
            this.ins_btn.Text = "Добавить";
            this.ins_btn.UseVisualStyleBackColor = true;
            this.ins_btn.Click += new System.EventHandler(this.ins_btn_Click);
            // 
            // cnl_btn
            // 
            this.cnl_btn.Location = new System.Drawing.Point(365, 374);
            this.cnl_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cnl_btn.Name = "cnl_btn";
            this.cnl_btn.Size = new System.Drawing.Size(100, 28);
            this.cnl_btn.TabIndex = 15;
            this.cnl_btn.Text = "Отмена";
            this.cnl_btn.UseVisualStyleBackColor = true;
            this.cnl_btn.Click += new System.EventHandler(this.cnl_btn_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(34, 353);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(324, 17);
            this.label28.TabIndex = 17;
            this.label28.Text = "Поля отмеченные * обязательны к заполнению";
            // 
            // ins_client_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 416);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.cnl_btn);
            this.Controls.Add(this.ins_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_adr);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_fam);
            this.Controls.Add(this.tb_pas);
            this.Controls.Add(this.tb_phone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ins_client_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery service";
            this.Load += new System.EventHandler(this.ins_client_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_pas;
        private System.Windows.Forms.TextBox tb_fam;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.TextBox tb_adr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ins_btn;
        private System.Windows.Forms.Button cnl_btn;
        private System.Windows.Forms.Label label28;
    }
}