namespace WindowsFormsApp1
{
    partial class insert_content_form
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
            this.tb_value = new System.Windows.Forms.TextBox();
            this.tb_kol = new System.Windows.Forms.TextBox();
            this.tb_weight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ins_btn = new System.Windows.Forms.Button();
            this.end_btn = new System.Windows.Forms.Button();
            this.contentGrid = new System.Windows.Forms.DataGridView();
            this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(239, 12);
            this.tb_name.MaxLength = 256;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(173, 22);
            this.tb_name.TabIndex = 1;
            // 
            // tb_value
            // 
            this.tb_value.Location = new System.Drawing.Point(239, 50);
            this.tb_value.MaxLength = 12;
            this.tb_value.Name = "tb_value";
            this.tb_value.Size = new System.Drawing.Size(173, 22);
            this.tb_value.TabIndex = 2;
            this.tb_value.TextChanged += new System.EventHandler(this.tb_value_TextChanged);
            this.tb_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_value_KeyPress);
            // 
            // tb_kol
            // 
            this.tb_kol.Location = new System.Drawing.Point(239, 95);
            this.tb_kol.MaxLength = 4;
            this.tb_kol.Name = "tb_kol";
            this.tb_kol.Size = new System.Drawing.Size(173, 22);
            this.tb_kol.TabIndex = 3;
            this.tb_kol.TextChanged += new System.EventHandler(this.tb_kol_TextChanged);
            this.tb_kol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_kol_KeyPress);
            // 
            // tb_weight
            // 
            this.tb_weight.Location = new System.Drawing.Point(239, 133);
            this.tb_weight.MaxLength = 5;
            this.tb_weight.Name = "tb_weight";
            this.tb_weight.Size = new System.Drawing.Size(173, 22);
            this.tb_weight.TabIndex = 4;
            this.tb_weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_weight_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Объявленная стоимость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Вес 1 штуки, кг";
            // 
            // ins_btn
            // 
            this.ins_btn.Location = new System.Drawing.Point(475, 10);
            this.ins_btn.Name = "ins_btn";
            this.ins_btn.Size = new System.Drawing.Size(101, 60);
            this.ins_btn.TabIndex = 9;
            this.ins_btn.Text = "Добавить";
            this.ins_btn.UseVisualStyleBackColor = true;
            this.ins_btn.Click += new System.EventHandler(this.ins_btn_Click);
            // 
            // end_btn
            // 
            this.end_btn.Location = new System.Drawing.Point(624, 12);
            this.end_btn.Name = "end_btn";
            this.end_btn.Size = new System.Drawing.Size(101, 60);
            this.end_btn.TabIndex = 10;
            this.end_btn.Text = "Закончить добавление";
            this.end_btn.UseVisualStyleBackColor = true;
            this.end_btn.Click += new System.EventHandler(this.end_btn_Click);
            // 
            // contentGrid
            // 
            this.contentGrid.AllowUserToAddRows = false;
            this.contentGrid.AllowUserToDeleteRows = false;
            this.contentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.contentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column26,
            this.Column27,
            this.Column28,
            this.Column29});
            this.contentGrid.Location = new System.Drawing.Point(13, 171);
            this.contentGrid.Margin = new System.Windows.Forms.Padding(4);
            this.contentGrid.Name = "contentGrid";
            this.contentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contentGrid.Size = new System.Drawing.Size(712, 125);
            this.contentGrid.TabIndex = 11;
            // 
            // Column26
            // 
            this.Column26.HeaderText = "Наименование товара";
            this.Column26.Name = "Column26";
            this.Column26.Width = 169;
            // 
            // Column27
            // 
            this.Column27.HeaderText = "Объявленная стоимость";
            this.Column27.Name = "Column27";
            this.Column27.Width = 182;
            // 
            // Column28
            // 
            this.Column28.HeaderText = "Количество";
            this.Column28.Name = "Column28";
            this.Column28.Width = 115;
            // 
            // Column29
            // 
            this.Column29.HeaderText = "Вес";
            this.Column29.Name = "Column29";
            this.Column29.Width = 61;
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(475, 129);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(101, 26);
            this.del_btn.TabIndex = 12;
            this.del_btn.Text = "Удалить";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // insert_content_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 316);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.contentGrid);
            this.Controls.Add(this.end_btn);
            this.Controls.Add(this.ins_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_weight);
            this.Controls.Add(this.tb_kol);
            this.Controls.Add(this.tb_value);
            this.Controls.Add(this.tb_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "insert_content_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery service";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.insert_content_form_FormClosing);
            this.Load += new System.EventHandler(this.insert_content_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_value;
        private System.Windows.Forms.TextBox tb_kol;
        private System.Windows.Forms.TextBox tb_weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ins_btn;
        private System.Windows.Forms.Button end_btn;
        private System.Windows.Forms.DataGridView contentGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column26;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column27;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column28;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column29;
        private System.Windows.Forms.Button del_btn;
    }
}