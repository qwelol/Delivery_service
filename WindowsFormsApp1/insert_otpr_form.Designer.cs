namespace WindowsFormsApp1
{
    partial class insert_otpr_form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.temp_pol = new System.Windows.Forms.ComboBox();
            this.temp_otpr = new System.Windows.Forms.ComboBox();
            this.cnl_btn = new System.Windows.Forms.Button();
            this.ins_btn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_gp = new System.Windows.Forms.ComboBox();
            this.cb_go = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.Label();
            this.tb_comm = new System.Windows.Forms.TextBox();
            this.cb_pp = new System.Windows.Forms.ComboBox();
            this.cb_po = new System.Windows.Forms.ComboBox();
            this.tb_pol = new System.Windows.Forms.TextBox();
            this.tb_otpr = new System.Windows.Forms.TextBox();
            this.cb_veight = new System.Windows.Forms.ComboBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cnl_btn);
            this.groupBox1.Controls.Add(this.ins_btn);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cb_gp);
            this.groupBox1.Controls.Add(this.cb_go);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comment);
            this.groupBox1.Controls.Add(this.tb_comm);
            this.groupBox1.Controls.Add(this.cb_pp);
            this.groupBox1.Controls.Add(this.cb_po);
            this.groupBox1.Controls.Add(this.tb_pol);
            this.groupBox1.Controls.Add(this.tb_otpr);
            this.groupBox1.Controls.Add(this.cb_veight);
            this.groupBox1.Controls.Add(this.cb_type);
            this.groupBox1.Controls.Add(this.temp_otpr);
            this.groupBox1.Controls.Add(this.temp_pol);
            this.groupBox1.Location = new System.Drawing.Point(4, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(408, 486);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // temp_pol
            // 
            this.temp_pol.FormattingEnabled = true;
            this.temp_pol.Location = new System.Drawing.Point(7, 269);
            this.temp_pol.Name = "temp_pol";
            this.temp_pol.Size = new System.Drawing.Size(121, 24);
            this.temp_pol.TabIndex = 23;
            this.temp_pol.Visible = false;
            // 
            // temp_otpr
            // 
            this.temp_otpr.FormattingEnabled = true;
            this.temp_otpr.Location = new System.Drawing.Point(9, 228);
            this.temp_otpr.Name = "temp_otpr";
            this.temp_otpr.Size = new System.Drawing.Size(121, 24);
            this.temp_otpr.TabIndex = 22;
            this.temp_otpr.Visible = false;
            // 
            // cnl_btn
            // 
            this.cnl_btn.Location = new System.Drawing.Point(299, 442);
            this.cnl_btn.Name = "cnl_btn";
            this.cnl_btn.Size = new System.Drawing.Size(100, 29);
            this.cnl_btn.TabIndex = 21;
            this.cnl_btn.Text = "Отмена";
            this.cnl_btn.UseVisualStyleBackColor = true;
            this.cnl_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ins_btn
            // 
            this.ins_btn.Location = new System.Drawing.Point(8, 442);
            this.ins_btn.Margin = new System.Windows.Forms.Padding(4);
            this.ins_btn.Name = "ins_btn";
            this.ins_btn.Size = new System.Drawing.Size(100, 28);
            this.ins_btn.TabIndex = 20;
            this.ins_btn.Text = "Добавить";
            this.ins_btn.UseVisualStyleBackColor = true;
            this.ins_btn.Click += new System.EventHandler(this.ins_btn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(8, 196);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Город получения";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(8, 162);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Город отправления";
            // 
            // cb_gp
            // 
            this.cb_gp.FormattingEnabled = true;
            this.cb_gp.Location = new System.Drawing.Point(201, 192);
            this.cb_gp.Margin = new System.Windows.Forms.Padding(4);
            this.cb_gp.Name = "cb_gp";
            this.cb_gp.Size = new System.Drawing.Size(198, 24);
            this.cb_gp.TabIndex = 17;
            this.cb_gp.SelectedIndexChanged += new System.EventHandler(this.cb_gp_SelectedIndexChanged);
            // 
            // cb_go
            // 
            this.cb_go.FormattingEnabled = true;
            this.cb_go.Location = new System.Drawing.Point(201, 158);
            this.cb_go.Margin = new System.Windows.Forms.Padding(4);
            this.cb_go.Name = "cb_go";
            this.cb_go.Size = new System.Drawing.Size(198, 24);
            this.cb_go.TabIndex = 16;
            this.cb_go.SelectedIndexChanged += new System.EventHandler(this.cb_go_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(156, 307);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Комментарий";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(8, 269);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Пункт назначения";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(5, 232);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Пункт отправления";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(5, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Весовая категория";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Тип доставки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Получатель";
            // 
            // comment
            // 
            this.comment.AutoSize = true;
            this.comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comment.Location = new System.Drawing.Point(8, 20);
            this.comment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(122, 20);
            this.comment.TabIndex = 8;
            this.comment.Text = "Отправитель";
            // 
            // tb_comm
            // 
            this.tb_comm.Location = new System.Drawing.Point(11, 331);
            this.tb_comm.Margin = new System.Windows.Forms.Padding(4);
            this.tb_comm.MaxLength = 512;
            this.tb_comm.Multiline = true;
            this.tb_comm.Name = "tb_comm";
            this.tb_comm.Size = new System.Drawing.Size(388, 91);
            this.tb_comm.TabIndex = 7;
            // 
            // cb_pp
            // 
            this.cb_pp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pp.FormattingEnabled = true;
            this.cb_pp.Location = new System.Drawing.Point(202, 265);
            this.cb_pp.Margin = new System.Windows.Forms.Padding(4);
            this.cb_pp.Name = "cb_pp";
            this.cb_pp.Size = new System.Drawing.Size(197, 24);
            this.cb_pp.TabIndex = 6;
            this.cb_pp.SelectedIndexChanged += new System.EventHandler(this.cb_pp_SelectedIndexChanged);
            // 
            // cb_po
            // 
            this.cb_po.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_po.FormattingEnabled = true;
            this.cb_po.Location = new System.Drawing.Point(201, 228);
            this.cb_po.Margin = new System.Windows.Forms.Padding(4);
            this.cb_po.Name = "cb_po";
            this.cb_po.Size = new System.Drawing.Size(198, 24);
            this.cb_po.TabIndex = 5;
            this.cb_po.SelectedIndexChanged += new System.EventHandler(this.cb_po_SelectedIndexChanged);
            // 
            // tb_pol
            // 
            this.tb_pol.Location = new System.Drawing.Point(201, 55);
            this.tb_pol.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pol.MaxLength = 12;
            this.tb_pol.Name = "tb_pol";
            this.tb_pol.Size = new System.Drawing.Size(198, 22);
            this.tb_pol.TabIndex = 4;
            this.tb_pol.TextChanged += new System.EventHandler(this.tb_pol_TextChanged);
            this.tb_pol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_pol_KeyPress);
            // 
            // tb_otpr
            // 
            this.tb_otpr.Location = new System.Drawing.Point(201, 20);
            this.tb_otpr.Margin = new System.Windows.Forms.Padding(4);
            this.tb_otpr.MaxLength = 12;
            this.tb_otpr.Name = "tb_otpr";
            this.tb_otpr.Size = new System.Drawing.Size(198, 22);
            this.tb_otpr.TabIndex = 3;
            this.tb_otpr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_otpr_KeyPress);
            // 
            // cb_veight
            // 
            this.cb_veight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_veight.FormattingEnabled = true;
            this.cb_veight.Location = new System.Drawing.Point(201, 126);
            this.cb_veight.Margin = new System.Windows.Forms.Padding(4);
            this.cb_veight.Name = "cb_veight";
            this.cb_veight.Size = new System.Drawing.Size(198, 24);
            this.cb_veight.TabIndex = 1;
            // 
            // cb_type
            // 
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(201, 87);
            this.cb_type.Margin = new System.Windows.Forms.Padding(4);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(198, 24);
            this.cb_type.TabIndex = 0;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.cb_type_SelectedIndexChanged);
            // 
            // insert_otpr_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 495);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "insert_otpr_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery service";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.insert_otpr_form_FormClosing);
            this.Load += new System.EventHandler(this.insert_otpr_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cnl_btn;
        private System.Windows.Forms.Button ins_btn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_gp;
        private System.Windows.Forms.ComboBox cb_go;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label comment;
        private System.Windows.Forms.TextBox tb_comm;
        private System.Windows.Forms.ComboBox cb_pp;
        private System.Windows.Forms.ComboBox cb_po;
        private System.Windows.Forms.TextBox tb_pol;
        private System.Windows.Forms.TextBox tb_otpr;
        private System.Windows.Forms.ComboBox cb_veight;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.ComboBox temp_otpr;
        private System.Windows.Forms.ComboBox temp_pol;
    }
}