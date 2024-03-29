namespace studentDiary
{
    partial class StudentScheduleWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentScheduleWindow));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ScheduleForm = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.StudShed4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.StudShed1 = new System.Windows.Forms.DataGridView();
            this.Предмет = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.StudShed6 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.StudShed5 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.ScheduleForm4 = new System.Windows.Forms.TableLayoutPanel();
            this.StudShed3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wednesday = new System.Windows.Forms.Label();
            this.ScheduleForm3 = new System.Windows.Forms.TableLayoutPanel();
            this.StudShed2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuesday = new System.Windows.Forms.Label();
            this.GroupComboSt = new System.Windows.Forms.ComboBox();
            this.ViewSheduleBtn = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.ScheduleForm.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudShed4)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudShed1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudShed6)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudShed5)).BeginInit();
            this.ScheduleForm4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudShed3)).BeginInit();
            this.ScheduleForm3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudShed2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1021, 26);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(62, 23);
            this.toolStripButton1.Text = "Назад";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.SlateBlue;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 23);
            this.toolStripLabel1.Text = "Группа";
            // 
            // ScheduleForm
            // 
            this.ScheduleForm.ColumnCount = 2;
            this.ScheduleForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ScheduleForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ScheduleForm.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.ScheduleForm.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.ScheduleForm.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.ScheduleForm.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.ScheduleForm.Controls.Add(this.ScheduleForm4, 0, 2);
            this.ScheduleForm.Controls.Add(this.ScheduleForm3, 0, 1);
            this.ScheduleForm.Location = new System.Drawing.Point(0, 29);
            this.ScheduleForm.Name = "ScheduleForm";
            this.ScheduleForm.RowCount = 3;
            this.ScheduleForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ScheduleForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ScheduleForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ScheduleForm.Size = new System.Drawing.Size(1021, 689);
            this.ScheduleForm.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.SlateBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.31746F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.68254F));
            this.tableLayoutPanel1.Controls.Add(this.StudShed4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(513, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 223);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // StudShed4
            // 
            this.StudShed4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudShed4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.StudShed4.Location = new System.Drawing.Point(55, 3);
            this.StudShed4.Name = "StudShed4";
            this.StudShed4.ReadOnly = true;
            this.StudShed4.RowHeadersWidth = 51;
            this.StudShed4.RowTemplate.Height = 24;
            this.StudShed4.Size = new System.Drawing.Size(446, 217);
            this.StudShed4.TabIndex = 5;
            this.StudShed4.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StudShed4_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Предмет";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 395;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 154);
            this.label1.TabIndex = 1;
            this.label1.Text = "Четверг";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.SlateBlue;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.31746F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.68254F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.StudShed1, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(504, 223);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(14, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 154);
            this.label4.TabIndex = 1;
            this.label4.Text = "Понедельник";
            // 
            // StudShed1
            // 
            this.StudShed1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudShed1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Предмет});
            this.StudShed1.Location = new System.Drawing.Point(55, 3);
            this.StudShed1.Name = "StudShed1";
            this.StudShed1.ReadOnly = true;
            this.StudShed1.RowHeadersWidth = 51;
            this.StudShed1.RowTemplate.Height = 24;
            this.StudShed1.Size = new System.Drawing.Size(446, 217);
            this.StudShed1.TabIndex = 4;
            this.StudShed1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StudShed1_CellMouseDoubleClick);
            // 
            // Предмет
            // 
            this.Предмет.HeaderText = "Предмет";
            this.Предмет.MinimumWidth = 6;
            this.Предмет.Name = "Предмет";
            this.Предмет.ReadOnly = true;
            this.Предмет.Width = 395;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.SlateBlue;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.31746F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.68254F));
            this.tableLayoutPanel3.Controls.Add(this.StudShed6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(513, 461);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(504, 223);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // StudShed6
            // 
            this.StudShed6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudShed6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5});
            this.StudShed6.Location = new System.Drawing.Point(55, 3);
            this.StudShed6.Name = "StudShed6";
            this.StudShed6.ReadOnly = true;
            this.StudShed6.RowHeadersWidth = 51;
            this.StudShed6.RowTemplate.Height = 24;
            this.StudShed6.Size = new System.Drawing.Size(446, 217);
            this.StudShed6.TabIndex = 5;
            this.StudShed6.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StudShed6_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Предмет";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 395;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(14, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 145);
            this.label3.TabIndex = 1;
            this.label3.Text = "Суббота";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.SlateBlue;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.31746F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.68254F));
            this.tableLayoutPanel2.Controls.Add(this.StudShed5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(513, 232);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(504, 223);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // StudShed5
            // 
            this.StudShed5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudShed5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.StudShed5.Location = new System.Drawing.Point(55, 3);
            this.StudShed5.Name = "StudShed5";
            this.StudShed5.ReadOnly = true;
            this.StudShed5.RowHeadersWidth = 51;
            this.StudShed5.RowTemplate.Height = 24;
            this.StudShed5.Size = new System.Drawing.Size(446, 217);
            this.StudShed5.TabIndex = 5;
            this.StudShed5.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StudShed5_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Предмет";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 395;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(14, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 152);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пятница";
            // 
            // ScheduleForm4
            // 
            this.ScheduleForm4.BackColor = System.Drawing.Color.SlateBlue;
            this.ScheduleForm4.ColumnCount = 2;
            this.ScheduleForm4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.71429F));
            this.ScheduleForm4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.28571F));
            this.ScheduleForm4.Controls.Add(this.StudShed3, 0, 0);
            this.ScheduleForm4.Controls.Add(this.Wednesday, 0, 0);
            this.ScheduleForm4.Location = new System.Drawing.Point(3, 461);
            this.ScheduleForm4.Name = "ScheduleForm4";
            this.ScheduleForm4.RowCount = 1;
            this.ScheduleForm4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ScheduleForm4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.ScheduleForm4.Size = new System.Drawing.Size(504, 223);
            this.ScheduleForm4.TabIndex = 4;
            // 
            // StudShed3
            // 
            this.StudShed3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudShed3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.StudShed3.Location = new System.Drawing.Point(57, 3);
            this.StudShed3.Name = "StudShed3";
            this.StudShed3.ReadOnly = true;
            this.StudShed3.RowHeadersWidth = 51;
            this.StudShed3.RowTemplate.Height = 24;
            this.StudShed3.Size = new System.Drawing.Size(444, 217);
            this.StudShed3.TabIndex = 5;
            this.StudShed3.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StudShed3_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Предмет";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 395;
            // 
            // Wednesday
            // 
            this.Wednesday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Wednesday.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Wednesday.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Wednesday.Location = new System.Drawing.Point(15, 55);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(23, 112);
            this.Wednesday.TabIndex = 3;
            this.Wednesday.Text = "Среда";
            // 
            // ScheduleForm3
            // 
            this.ScheduleForm3.ColumnCount = 2;
            this.ScheduleForm3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.71429F));
            this.ScheduleForm3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.28571F));
            this.ScheduleForm3.Controls.Add(this.StudShed2, 0, 0);
            this.ScheduleForm3.Controls.Add(this.Tuesday, 0, 0);
            this.ScheduleForm3.Location = new System.Drawing.Point(3, 232);
            this.ScheduleForm3.Name = "ScheduleForm3";
            this.ScheduleForm3.RowCount = 1;
            this.ScheduleForm3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ScheduleForm3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.ScheduleForm3.Size = new System.Drawing.Size(504, 223);
            this.ScheduleForm3.TabIndex = 2;
            // 
            // StudShed2
            // 
            this.StudShed2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudShed2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.StudShed2.Location = new System.Drawing.Point(57, 3);
            this.StudShed2.Name = "StudShed2";
            this.StudShed2.ReadOnly = true;
            this.StudShed2.RowHeadersWidth = 51;
            this.StudShed2.RowTemplate.Height = 24;
            this.StudShed2.Size = new System.Drawing.Size(444, 217);
            this.StudShed2.TabIndex = 5;
            this.StudShed2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StudShed2_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Предмет";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 395;
            // 
            // Tuesday
            // 
            this.Tuesday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tuesday.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tuesday.ForeColor = System.Drawing.Color.SlateBlue;
            this.Tuesday.Location = new System.Drawing.Point(15, 33);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(23, 156);
            this.Tuesday.TabIndex = 3;
            this.Tuesday.Text = "Вторник";
            // 
            // GroupComboSt
            // 
            this.GroupComboSt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupComboSt.FormattingEnabled = true;
            this.GroupComboSt.Location = new System.Drawing.Point(140, 2);
            this.GroupComboSt.Name = "GroupComboSt";
            this.GroupComboSt.Size = new System.Drawing.Size(121, 24);
            this.GroupComboSt.TabIndex = 2;
            // 
            // ViewSheduleBtn
            // 
            this.ViewSheduleBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ViewSheduleBtn.Location = new System.Drawing.Point(923, 2);
            this.ViewSheduleBtn.Name = "ViewSheduleBtn";
            this.ViewSheduleBtn.Size = new System.Drawing.Size(86, 23);
            this.ViewSheduleBtn.TabIndex = 3;
            this.ViewSheduleBtn.Text = "Показать";
            this.ViewSheduleBtn.UseVisualStyleBackColor = false;
            this.ViewSheduleBtn.Click += new System.EventHandler(this.ViewSheduleBtn_Click);
            // 
            // StudentScheduleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 717);
            this.Controls.Add(this.ViewSheduleBtn);
            this.Controls.Add(this.GroupComboSt);
            this.Controls.Add(this.ScheduleForm);
            this.Controls.Add(this.toolStrip1);
            this.Name = "StudentScheduleWindow";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ScheduleForm.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudShed4)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudShed1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudShed6)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudShed5)).EndInit();
            this.ScheduleForm4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudShed3)).EndInit();
            this.ScheduleForm3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudShed2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TableLayoutPanel ScheduleForm;
        private System.Windows.Forms.TableLayoutPanel ScheduleForm4;
        private System.Windows.Forms.TableLayoutPanel ScheduleForm3;
        private System.Windows.Forms.Label Tuesday;
        private System.Windows.Forms.Label Wednesday;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView StudShed1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GroupComboSt;
        private System.Windows.Forms.Button ViewSheduleBtn;
        private System.Windows.Forms.DataGridView StudShed4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Предмет;
        private System.Windows.Forms.DataGridView StudShed6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView StudShed5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView StudShed3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView StudShed2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}