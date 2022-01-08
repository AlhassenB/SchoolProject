
namespace Schools
{
    partial class MaterialsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.PedagogicDate = new MetroFramework.Controls.MetroDateTime();
            this.SubjectList = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteSubject = new MetroFramework.Controls.MetroButton();
            this.UpdateSubject = new MetroFramework.Controls.MetroButton();
            this.AddSubject = new MetroFramework.Controls.MetroButton();
            this.SelectColor = new System.Windows.Forms.TextBox();
            this.SubjectClassName = new MetroFramework.Controls.MetroTextBox();
            this.NameSubject = new MetroFramework.Controls.MetroTextBox();
            this.CodeSubject = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ContainerColor = new MetroFramework.Controls.MetroLabel();
            this.PanelColor = new System.Windows.Forms.ColorDialog();
            this.ConvertedColor = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.IdSubject = new MetroFramework.Controls.MetroTextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectClassNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.convertedColorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.IdSubject);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.PedagogicDate);
            this.metroPanel1.Controls.Add(this.SubjectList);
            this.metroPanel1.Controls.Add(this.DeleteSubject);
            this.metroPanel1.Controls.Add(this.UpdateSubject);
            this.metroPanel1.Controls.Add(this.AddSubject);
            this.metroPanel1.Controls.Add(this.SelectColor);
            this.metroPanel1.Controls.Add(this.SubjectClassName);
            this.metroPanel1.Controls.Add(this.NameSubject);
            this.metroPanel1.Controls.Add(this.CodeSubject);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(2, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(971, 436);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(842, 181);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(96, 19);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "اليوم البيداغوجي";
            // 
            // PedagogicDate
            // 
            this.PedagogicDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PedagogicDate.Location = new System.Drawing.Point(607, 171);
            this.PedagogicDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.PedagogicDate.Name = "PedagogicDate";
            this.PedagogicDate.Size = new System.Drawing.Size(200, 29);
            this.PedagogicDate.TabIndex = 19;
            // 
            // SubjectList
            // 
            this.SubjectList.AllowUserToAddRows = false;
            this.SubjectList.AllowUserToDeleteRows = false;
            this.SubjectList.AllowUserToOrderColumns = true;
            this.SubjectList.AllowUserToResizeRows = false;
            this.SubjectList.AutoGenerateColumns = false;
            this.SubjectList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SubjectList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubjectList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SubjectList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubjectList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.SubjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.subjectClassNameDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.convertedColorDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.SubjectList.DataSource = this.subjectBindingSource1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SubjectList.DefaultCellStyle = dataGridViewCellStyle6;
            this.SubjectList.EnableHeadersVisualStyles = false;
            this.SubjectList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SubjectList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SubjectList.Location = new System.Drawing.Point(3, 0);
            this.SubjectList.Name = "SubjectList";
            this.SubjectList.ReadOnly = true;
            this.SubjectList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubjectList.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.SubjectList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.SubjectList.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.SubjectList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SubjectList.Size = new System.Drawing.Size(554, 370);
            this.SubjectList.Style = MetroFramework.MetroColorStyle.Blue;
            this.SubjectList.TabIndex = 18;
            this.SubjectList.Click += new System.EventHandler(this.SubjectList_Click);
            this.SubjectList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SubjectList_KeyDown);
            this.SubjectList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SubjectList_KeyUp);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PedagogicDate";
            this.dataGridViewTextBoxColumn1.HeaderText = "اليوم البيداغوجي";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // DeleteSubject
            // 
            this.DeleteSubject.Location = new System.Drawing.Point(607, 309);
            this.DeleteSubject.Name = "DeleteSubject";
            this.DeleteSubject.Size = new System.Drawing.Size(100, 30);
            this.DeleteSubject.TabIndex = 15;
            this.DeleteSubject.Text = "حذف";
            this.DeleteSubject.UseMnemonic = false;
            this.DeleteSubject.UseSelectable = true;
            this.DeleteSubject.UseStyleColors = true;
            this.DeleteSubject.Click += new System.EventHandler(this.DeleteSubject_Click);
            // 
            // UpdateSubject
            // 
            this.UpdateSubject.Location = new System.Drawing.Point(722, 309);
            this.UpdateSubject.Name = "UpdateSubject";
            this.UpdateSubject.Size = new System.Drawing.Size(105, 30);
            this.UpdateSubject.TabIndex = 14;
            this.UpdateSubject.Text = "تعديل";
            this.UpdateSubject.UseSelectable = true;
            this.UpdateSubject.UseStyleColors = true;
            this.UpdateSubject.Click += new System.EventHandler(this.UpdateSubject_Click);
            // 
            // AddSubject
            // 
            this.AddSubject.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddSubject.ForeColor = System.Drawing.Color.Black;
            this.AddSubject.Location = new System.Drawing.Point(844, 309);
            this.AddSubject.Name = "AddSubject";
            this.AddSubject.Size = new System.Drawing.Size(112, 30);
            this.AddSubject.TabIndex = 13;
            this.AddSubject.Text = "إضافة";
            this.AddSubject.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AddSubject.UseSelectable = true;
            this.AddSubject.UseStyleColors = true;
            this.AddSubject.Click += new System.EventHandler(this.AddSubject_Click);
            // 
            // SelectColor
            // 
            this.SelectColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SelectColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectColor.Location = new System.Drawing.Point(607, 212);
            this.SelectColor.Name = "SelectColor";
            this.SelectColor.ReadOnly = true;
            this.SelectColor.Size = new System.Drawing.Size(155, 20);
            this.SelectColor.TabIndex = 12;
            this.SelectColor.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // SubjectClassName
            // 
            // 
            // 
            // 
            this.SubjectClassName.CustomButton.Image = null;
            this.SubjectClassName.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.SubjectClassName.CustomButton.Name = "";
            this.SubjectClassName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SubjectClassName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SubjectClassName.CustomButton.TabIndex = 1;
            this.SubjectClassName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SubjectClassName.CustomButton.UseSelectable = true;
            this.SubjectClassName.CustomButton.Visible = false;
            this.SubjectClassName.Lines = new string[0];
            this.SubjectClassName.Location = new System.Drawing.Point(607, 137);
            this.SubjectClassName.MaxLength = 32767;
            this.SubjectClassName.Name = "SubjectClassName";
            this.SubjectClassName.PasswordChar = '\0';
            this.SubjectClassName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SubjectClassName.SelectedText = "";
            this.SubjectClassName.SelectionLength = 0;
            this.SubjectClassName.SelectionStart = 0;
            this.SubjectClassName.ShortcutsEnabled = true;
            this.SubjectClassName.Size = new System.Drawing.Size(155, 23);
            this.SubjectClassName.TabIndex = 9;
            this.SubjectClassName.UseSelectable = true;
            this.SubjectClassName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SubjectClassName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NameSubject
            // 
            // 
            // 
            // 
            this.NameSubject.CustomButton.Image = null;
            this.NameSubject.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.NameSubject.CustomButton.Name = "";
            this.NameSubject.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NameSubject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NameSubject.CustomButton.TabIndex = 1;
            this.NameSubject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NameSubject.CustomButton.UseSelectable = true;
            this.NameSubject.CustomButton.Visible = false;
            this.NameSubject.Lines = new string[0];
            this.NameSubject.Location = new System.Drawing.Point(607, 105);
            this.NameSubject.MaxLength = 32767;
            this.NameSubject.Name = "NameSubject";
            this.NameSubject.PasswordChar = '\0';
            this.NameSubject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameSubject.SelectedText = "";
            this.NameSubject.SelectionLength = 0;
            this.NameSubject.SelectionStart = 0;
            this.NameSubject.ShortcutsEnabled = true;
            this.NameSubject.Size = new System.Drawing.Size(155, 23);
            this.NameSubject.TabIndex = 8;
            this.NameSubject.UseSelectable = true;
            this.NameSubject.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NameSubject.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CodeSubject
            // 
            // 
            // 
            // 
            this.CodeSubject.CustomButton.Image = null;
            this.CodeSubject.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.CodeSubject.CustomButton.Name = "";
            this.CodeSubject.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CodeSubject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CodeSubject.CustomButton.TabIndex = 1;
            this.CodeSubject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CodeSubject.CustomButton.UseSelectable = true;
            this.CodeSubject.CustomButton.Visible = false;
            this.CodeSubject.Lines = new string[0];
            this.CodeSubject.Location = new System.Drawing.Point(607, 72);
            this.CodeSubject.MaxLength = 32767;
            this.CodeSubject.Name = "CodeSubject";
            this.CodeSubject.PasswordChar = '\0';
            this.CodeSubject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CodeSubject.SelectedText = "";
            this.CodeSubject.SelectionLength = 0;
            this.CodeSubject.SelectionStart = 0;
            this.CodeSubject.ShortcutsEnabled = true;
            this.CodeSubject.Size = new System.Drawing.Size(155, 23);
            this.CodeSubject.TabIndex = 7;
            this.CodeSubject.UseSelectable = true;
            this.CodeSubject.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CodeSubject.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(860, 213);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(81, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "اللون المفضل";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(782, 141);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(159, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Tag = "";
            this.metroLabel3.Text = "اسم المادة في جدول القسم";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(878, 109);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "بيان الماة";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(878, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "رمز المادة";
            // 
            // ContainerColor
            // 
            this.ContainerColor.AutoSize = true;
            this.ContainerColor.ForeColor = System.Drawing.Color.White;
            this.ContainerColor.Location = new System.Drawing.Point(255, 17);
            this.ContainerColor.Name = "ContainerColor";
            this.ContainerColor.Size = new System.Drawing.Size(45, 19);
            this.ContainerColor.TabIndex = 16;
            this.ContainerColor.Text = "         ";
            this.ContainerColor.Visible = false;
            // 
            // ConvertedColor
            // 
            this.ConvertedColor.AutoSize = true;
            this.ConvertedColor.Location = new System.Drawing.Point(389, 17);
            this.ConvertedColor.Name = "ConvertedColor";
            this.ConvertedColor.Size = new System.Drawing.Size(77, 19);
            this.ConvertedColor.TabIndex = 17;
            this.ConvertedColor.Text = "                 ";
            this.ConvertedColor.Visible = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(901, 40);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(34, 19);
            this.metroLabel6.TabIndex = 21;
            this.metroLabel6.Text = "الرقم";
            // 
            // IdSubject
            // 
            // 
            // 
            // 
            this.IdSubject.CustomButton.Image = null;
            this.IdSubject.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.IdSubject.CustomButton.Name = "";
            this.IdSubject.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.IdSubject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.IdSubject.CustomButton.TabIndex = 1;
            this.IdSubject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.IdSubject.CustomButton.UseSelectable = true;
            this.IdSubject.CustomButton.Visible = false;
            this.IdSubject.Lines = new string[0];
            this.IdSubject.Location = new System.Drawing.Point(607, 36);
            this.IdSubject.MaxLength = 32767;
            this.IdSubject.Name = "IdSubject";
            this.IdSubject.PasswordChar = '\0';
            this.IdSubject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IdSubject.SelectedText = "";
            this.IdSubject.SelectionLength = 0;
            this.IdSubject.SelectionStart = 0;
            this.IdSubject.ShortcutsEnabled = true;
            this.IdSubject.Size = new System.Drawing.Size(155, 23);
            this.IdSubject.TabIndex = 22;
            this.IdSubject.UseSelectable = true;
            this.IdSubject.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.IdSubject.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "الرقم";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "رمز المادة";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "بيان المادة";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectClassNameDataGridViewTextBoxColumn
            // 
            this.subjectClassNameDataGridViewTextBoxColumn.DataPropertyName = "SubjectClassName";
            this.subjectClassNameDataGridViewTextBoxColumn.HeaderText = "اسم المادة في جدول القسم";
            this.subjectClassNameDataGridViewTextBoxColumn.Name = "subjectClassNameDataGridViewTextBoxColumn";
            this.subjectClassNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "اللون";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorDataGridViewTextBoxColumn.Visible = false;
            // 
            // convertedColorDataGridViewTextBoxColumn1
            // 
            this.convertedColorDataGridViewTextBoxColumn1.DataPropertyName = "ConvertedColor";
            this.convertedColorDataGridViewTextBoxColumn1.HeaderText = "كود اللون";
            this.convertedColorDataGridViewTextBoxColumn1.Name = "convertedColorDataGridViewTextBoxColumn1";
            this.convertedColorDataGridViewTextBoxColumn1.ReadOnly = true;
            this.convertedColorDataGridViewTextBoxColumn1.Visible = false;
            // 
            // subjectBindingSource1
            // 
            this.subjectBindingSource1.DataSource = typeof(Schools.Subject);
            // 
            // subjectBindingSource2
            // 
            this.subjectBindingSource2.DataSource = typeof(Schools.Subject);
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(Schools.Subject);
            // 
            // MaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 500);
            this.Controls.Add(this.ConvertedColor);
            this.Controls.Add(this.ContainerColor);
            this.Controls.Add(this.metroPanel1);
            this.Movable = false;
            this.Name = "MaterialsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "المواد التعليمية";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.MaterialsForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox SubjectClassName;
        private MetroFramework.Controls.MetroTextBox NameSubject;
        private MetroFramework.Controls.MetroTextBox CodeSubject;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ColorDialog PanelColor;
        private MetroFramework.Controls.MetroButton DeleteSubject;
        private MetroFramework.Controls.MetroButton UpdateSubject;
        private MetroFramework.Controls.MetroButton AddSubject;
        private MetroFramework.Controls.MetroLabel ContainerColor;
        private System.Windows.Forms.TextBox SelectColor;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private MetroFramework.Controls.MetroLabel ConvertedColor;
        private System.Windows.Forms.BindingSource subjectBindingSource1;
        private System.Windows.Forms.BindingSource subjectBindingSource2;
        private MetroFramework.Controls.MetroGrid SubjectList;
        private MetroFramework.Controls.MetroDateTime PedagogicDate;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectClassNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn convertedColorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private MetroFramework.Controls.MetroTextBox IdSubject;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}