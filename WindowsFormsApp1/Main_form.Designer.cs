﻿namespace WindowsFormsApp1
{
    partial class Main_form
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.operatorPage = new System.Windows.Forms.TabPage();
            this.adminPage = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.departurePage = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.departureGrid = new System.Windows.Forms.DataGridView();
            this.contentGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.create_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.cb_veight = new System.Windows.Forms.ComboBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.tb_otpr = new System.Windows.Forms.TextBox();
            this.tb_pol = new System.Windows.Forms.TextBox();
            this.cb_po = new System.Windows.Forms.ComboBox();
            this.cb_pp = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comment = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_go = new System.Windows.Forms.ComboBox();
            this.cb_gp = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.change_btn = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.refGrid = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.pvGrid = new System.Windows.Forms.DataGridView();
            this.insert_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.cb_city = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.pv_search_btn = new System.Windows.Forms.Button();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.operatorPage.SuspendLayout();
            this.adminPage.SuspendLayout();
            this.departurePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departureGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.operatorPage);
            this.tabControl1.Controls.Add(this.adminPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 701);
            this.tabControl1.TabIndex = 0;
            // 
            // operatorPage
            // 
            this.operatorPage.Controls.Add(this.tabControl2);
            this.operatorPage.Location = new System.Drawing.Point(4, 22);
            this.operatorPage.Name = "operatorPage";
            this.operatorPage.Padding = new System.Windows.Forms.Padding(3);
            this.operatorPage.Size = new System.Drawing.Size(976, 675);
            this.operatorPage.TabIndex = 0;
            this.operatorPage.Text = "Оператор";
            this.operatorPage.UseVisualStyleBackColor = true;
            // 
            // adminPage
            // 
            this.adminPage.Controls.Add(this.pv_search_btn);
            this.adminPage.Controls.Add(this.del_btn);
            this.adminPage.Controls.Add(this.insert_btn);
            this.adminPage.Controls.Add(this.label14);
            this.adminPage.Controls.Add(this.cb_city);
            this.adminPage.Controls.Add(this.pvGrid);
            this.adminPage.Location = new System.Drawing.Point(4, 22);
            this.adminPage.Name = "adminPage";
            this.adminPage.Padding = new System.Windows.Forms.Padding(3);
            this.adminPage.Size = new System.Drawing.Size(976, 675);
            this.adminPage.TabIndex = 1;
            this.adminPage.Text = "Администратор";
            this.adminPage.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(962, 643);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Клиенты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // departurePage
            // 
            this.departurePage.Controls.Add(this.label13);
            this.departurePage.Controls.Add(this.refGrid);
            this.departurePage.Controls.Add(this.groupBox1);
            this.departurePage.Controls.Add(this.search_btn);
            this.departurePage.Controls.Add(this.delete_btn);
            this.departurePage.Controls.Add(this.create_btn);
            this.departurePage.Controls.Add(this.label3);
            this.departurePage.Controls.Add(this.label2);
            this.departurePage.Controls.Add(this.contentGrid);
            this.departurePage.Controls.Add(this.departureGrid);
            this.departurePage.Controls.Add(this.label1);
            this.departurePage.Controls.Add(this.textBox1);
            this.departurePage.Location = new System.Drawing.Point(4, 22);
            this.departurePage.Name = "departurePage";
            this.departurePage.Padding = new System.Windows.Forms.Padding(3);
            this.departurePage.Size = new System.Drawing.Size(962, 643);
            this.departurePage.TabIndex = 0;
            this.departurePage.Text = "Отправления";
            this.departurePage.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер заказа";
            // 
            // departureGrid
            // 
            this.departureGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departureGrid.Location = new System.Drawing.Point(14, 80);
            this.departureGrid.Name = "departureGrid";
            this.departureGrid.Size = new System.Drawing.Size(596, 188);
            this.departureGrid.TabIndex = 1;
            // 
            // contentGrid
            // 
            this.contentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contentGrid.Location = new System.Drawing.Point(14, 309);
            this.contentGrid.Name = "contentGrid";
            this.contentGrid.Size = new System.Drawing.Size(596, 175);
            this.contentGrid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Отправления:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Содержимое:";
            // 
            // create_btn
            // 
            this.create_btn.Location = new System.Drawing.Point(442, 19);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(75, 23);
            this.create_btn.TabIndex = 5;
            this.create_btn.Text = "Создать";
            this.create_btn.UseVisualStyleBackColor = true;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(535, 20);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 6;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = true;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(303, 20);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 7;
            this.search_btn.Text = "Поиск";
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.change_btn);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cb_gp);
            this.groupBox1.Controls.Add(this.cb_go);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comment);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.cb_pp);
            this.groupBox1.Controls.Add(this.cb_po);
            this.groupBox1.Controls.Add(this.tb_pol);
            this.groupBox1.Controls.Add(this.tb_otpr);
            this.groupBox1.Controls.Add(this.cb_status);
            this.groupBox1.Controls.Add(this.cb_veight);
            this.groupBox1.Controls.Add(this.cb_type);
            this.groupBox1.Location = new System.Drawing.Point(650, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 404);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // cb_type
            // 
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(151, 71);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(121, 21);
            this.cb_type.TabIndex = 0;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cb_veight
            // 
            this.cb_veight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_veight.FormattingEnabled = true;
            this.cb_veight.Location = new System.Drawing.Point(151, 102);
            this.cb_veight.Name = "cb_veight";
            this.cb_veight.Size = new System.Drawing.Size(121, 21);
            this.cb_veight.TabIndex = 1;
            this.cb_veight.SelectedIndexChanged += new System.EventHandler(this.cb_veight_SelectedIndexChanged);
            // 
            // cb_status
            // 
            this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "отправлено",
            "доставлено",
            "отказано"});
            this.cb_status.Location = new System.Drawing.Point(151, 129);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(121, 21);
            this.cb_status.TabIndex = 2;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.cb_status_SelectedIndexChanged);
            // 
            // tb_otpr
            // 
            this.tb_otpr.Location = new System.Drawing.Point(151, 16);
            this.tb_otpr.Name = "tb_otpr";
            this.tb_otpr.Size = new System.Drawing.Size(121, 20);
            this.tb_otpr.TabIndex = 3;
            // 
            // tb_pol
            // 
            this.tb_pol.Location = new System.Drawing.Point(151, 45);
            this.tb_pol.Name = "tb_pol";
            this.tb_pol.Size = new System.Drawing.Size(121, 20);
            this.tb_pol.TabIndex = 4;
            // 
            // cb_po
            // 
            this.cb_po.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_po.FormattingEnabled = true;
            this.cb_po.Location = new System.Drawing.Point(151, 211);
            this.cb_po.Name = "cb_po";
            this.cb_po.Size = new System.Drawing.Size(121, 21);
            this.cb_po.TabIndex = 5;
            // 
            // cb_pp
            // 
            this.cb_pp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pp.FormattingEnabled = true;
            this.cb_pp.Location = new System.Drawing.Point(151, 243);
            this.cb_pp.Name = "cb_pp";
            this.cb_pp.Size = new System.Drawing.Size(121, 21);
            this.cb_pp.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 307);
            this.textBox2.MaxLength = 512;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 57);
            this.textBox2.TabIndex = 7;
            // 
            // comment
            // 
            this.comment.AutoSize = true;
            this.comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comment.Location = new System.Drawing.Point(6, 16);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(95, 17);
            this.comment.TabIndex = 8;
            this.comment.Text = "Отправитель";
            this.comment.Click += new System.EventHandler(this.comment_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Получатель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Тип доставки";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(4, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Весовая категория";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(4, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Статус";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(4, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Пункт отправления";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Пункт назначения";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(104, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Комментарий";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cb_go
            // 
            this.cb_go.FormattingEnabled = true;
            this.cb_go.Location = new System.Drawing.Point(151, 156);
            this.cb_go.Name = "cb_go";
            this.cb_go.Size = new System.Drawing.Size(121, 21);
            this.cb_go.TabIndex = 16;
            // 
            // cb_gp
            // 
            this.cb_gp.FormattingEnabled = true;
            this.cb_gp.Location = new System.Drawing.Point(151, 184);
            this.cb_gp.Name = "cb_gp";
            this.cb_gp.Size = new System.Drawing.Size(121, 21);
            this.cb_gp.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(4, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Город отправления";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(4, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Город получения";
            // 
            // change_btn
            // 
            this.change_btn.Location = new System.Drawing.Point(107, 370);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(75, 23);
            this.change_btn.TabIndex = 20;
            this.change_btn.Text = "Изменить";
            this.change_btn.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.departurePage);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(970, 669);
            this.tabControl2.TabIndex = 0;
            // 
            // refGrid
            // 
            this.refGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.refGrid.Location = new System.Drawing.Point(14, 519);
            this.refGrid.Name = "refGrid";
            this.refGrid.Size = new System.Drawing.Size(596, 108);
            this.refGrid.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(13, 487);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(223, 24);
            this.label13.TabIndex = 10;
            this.label13.Text = "Информация об отказе:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // pvGrid
            // 
            this.pvGrid.AllowUserToAddRows = false;
            this.pvGrid.AllowUserToDeleteRows = false;
            this.pvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pvGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.pvGrid.Location = new System.Drawing.Point(20, 70);
            this.pvGrid.Name = "pvGrid";
            this.pvGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pvGrid.Size = new System.Drawing.Size(936, 218);
            this.pvGrid.TabIndex = 0;
            this.pvGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pvGrid_CellContentClick);
            this.pvGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.pvGrid_CellEndEdit);
            this.pvGrid.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.pvGrid_RowLeave);
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(786, 41);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(75, 23);
            this.insert_btn.TabIndex = 2;
            this.insert_btn.Text = "Добавить";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(881, 41);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(75, 23);
            this.del_btn.TabIndex = 3;
            this.del_btn.Text = "Удалить";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // cb_city
            // 
            this.cb_city.FormattingEnabled = true;
            this.cb_city.Location = new System.Drawing.Point(113, 37);
            this.cb_city.Name = "cb_city";
            this.cb_city.Size = new System.Drawing.Size(121, 21);
            this.cb_city.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(16, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 24);
            this.label14.TabIndex = 4;
            this.label14.Text = "Город";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // pv_search_btn
            // 
            this.pv_search_btn.Location = new System.Drawing.Point(253, 37);
            this.pv_search_btn.Name = "pv_search_btn";
            this.pv_search_btn.Size = new System.Drawing.Size(75, 23);
            this.pv_search_btn.TabIndex = 5;
            this.pv_search_btn.Text = "Поиск";
            this.pv_search_btn.UseVisualStyleBackColor = true;
            this.pv_search_btn.Click += new System.EventHandler(this.pv_search_btn_Click);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Код пункта";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Город";
            this.Column1.MinimumWidth = 50;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 140;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Адрес";
            this.Column2.MaxInputLength = 512;
            this.Column2.MinimumWidth = 100;
            this.Column2.Name = "Column2";
            this.Column2.Width = 450;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Городской телефон";
            this.Column3.MinimumWidth = 50;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Мобильный телефон";
            this.Column4.MinimumWidth = 50;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 701);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery service";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_form_FormClosed);
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.tabControl1.ResumeLayout(false);
            this.operatorPage.ResumeLayout(false);
            this.adminPage.ResumeLayout(false);
            this.adminPage.PerformLayout();
            this.departurePage.ResumeLayout(false);
            this.departurePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departureGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage operatorPage;
        private System.Windows.Forms.TabPage adminPage;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage departurePage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_gp;
        private System.Windows.Forms.ComboBox cb_go;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label comment;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cb_pp;
        private System.Windows.Forms.ComboBox cb_po;
        private System.Windows.Forms.TextBox tb_pol;
        private System.Windows.Forms.TextBox tb_otpr;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.ComboBox cb_veight;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView contentGrid;
        private System.Windows.Forms.DataGridView departureGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView refGrid;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.ComboBox cb_city;
        private System.Windows.Forms.DataGridView pvGrid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button pv_search_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}