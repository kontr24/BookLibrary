
namespace BookLibrary
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbPublishingHouse = new System.Windows.Forms.TextBox();
            this.tbChapter = new System.Windows.Forms.TextBox();
            this.lAuthor = new System.Windows.Forms.Label();
            this.lTitle = new System.Windows.Forms.Label();
            this.lPublishingHouse = new System.Windows.Forms.Label();
            this.lChapter = new System.Windows.Forms.Label();
            this.lAvailability = new System.Windows.Forms.Label();
            this.lCondition = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pMain = new System.Windows.Forms.Panel();
            this.cbAvailability = new System.Windows.Forms.ComboBox();
            this.cbCondition = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.lSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowTemplate.Height = 25;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(907, 688);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.TabStop = false;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Автор";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 57;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Название";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 83;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Издательство";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 109;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Раздел";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 62;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Наличие";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 76;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Состояние";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 89;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(16, 106);
            this.tbAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(573, 27);
            this.tbAuthor.TabIndex = 3;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(16, 172);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(573, 27);
            this.tbTitle.TabIndex = 4;
            // 
            // tbPublishingHouse
            // 
            this.tbPublishingHouse.Location = new System.Drawing.Point(16, 243);
            this.tbPublishingHouse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPublishingHouse.Name = "tbPublishingHouse";
            this.tbPublishingHouse.Size = new System.Drawing.Size(573, 27);
            this.tbPublishingHouse.TabIndex = 5;
            // 
            // tbChapter
            // 
            this.tbChapter.Location = new System.Drawing.Point(16, 318);
            this.tbChapter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbChapter.Name = "tbChapter";
            this.tbChapter.Size = new System.Drawing.Size(573, 27);
            this.tbChapter.TabIndex = 6;
            // 
            // lAuthor
            // 
            this.lAuthor.AutoSize = true;
            this.lAuthor.Location = new System.Drawing.Point(16, 82);
            this.lAuthor.Name = "lAuthor";
            this.lAuthor.Size = new System.Drawing.Size(51, 20);
            this.lAuthor.TabIndex = 9;
            this.lAuthor.Text = "Автор";
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Location = new System.Drawing.Point(16, 148);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(77, 20);
            this.lTitle.TabIndex = 10;
            this.lTitle.Text = "Название";
            // 
            // lPublishingHouse
            // 
            this.lPublishingHouse.AutoSize = true;
            this.lPublishingHouse.Location = new System.Drawing.Point(16, 219);
            this.lPublishingHouse.Name = "lPublishingHouse";
            this.lPublishingHouse.Size = new System.Drawing.Size(103, 20);
            this.lPublishingHouse.TabIndex = 11;
            this.lPublishingHouse.Text = "Издательство";
            // 
            // lChapter
            // 
            this.lChapter.AutoSize = true;
            this.lChapter.Location = new System.Drawing.Point(16, 294);
            this.lChapter.Name = "lChapter";
            this.lChapter.Size = new System.Drawing.Size(56, 20);
            this.lChapter.TabIndex = 12;
            this.lChapter.Text = "Раздел";
            // 
            // lAvailability
            // 
            this.lAvailability.AutoSize = true;
            this.lAvailability.Location = new System.Drawing.Point(16, 369);
            this.lAvailability.Name = "lAvailability";
            this.lAvailability.Size = new System.Drawing.Size(70, 20);
            this.lAvailability.TabIndex = 13;
            this.lAvailability.Text = "Наличие";
            // 
            // lCondition
            // 
            this.lCondition.AutoSize = true;
            this.lCondition.Location = new System.Drawing.Point(16, 441);
            this.lCondition.Name = "lCondition";
            this.lCondition.Size = new System.Drawing.Size(83, 20);
            this.lCondition.TabIndex = 14;
            this.lCondition.Text = "Состояние";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Gray;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreate.Location = new System.Drawing.Point(186, 530);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(117, 34);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Добавить";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gray;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(309, 530);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(157, 34);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Редактировать";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(472, 530);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 34);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pMain.Controls.Add(this.cbAvailability);
            this.pMain.Controls.Add(this.cbCondition);
            this.pMain.Controls.Add(this.btnClear);
            this.pMain.Controls.Add(this.btnLoad);
            this.pMain.Controls.Add(this.btnSave);
            this.pMain.Controls.Add(this.cbSearch);
            this.pMain.Controls.Add(this.lSearch);
            this.pMain.Controls.Add(this.tbSearch);
            this.pMain.Controls.Add(this.tbAuthor);
            this.pMain.Controls.Add(this.btnCreate);
            this.pMain.Controls.Add(this.btnUpdate);
            this.pMain.Controls.Add(this.btnDelete);
            this.pMain.Controls.Add(this.tbTitle);
            this.pMain.Controls.Add(this.tbPublishingHouse);
            this.pMain.Controls.Add(this.tbChapter);
            this.pMain.Controls.Add(this.lCondition);
            this.pMain.Controls.Add(this.lAvailability);
            this.pMain.Controls.Add(this.lChapter);
            this.pMain.Controls.Add(this.lAuthor);
            this.pMain.Controls.Add(this.lPublishingHouse);
            this.pMain.Controls.Add(this.lTitle);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.pMain.Location = new System.Drawing.Point(913, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(618, 688);
            this.pMain.TabIndex = 18;
            // 
            // cbAvailability
            // 
            this.cbAvailability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAvailability.FormattingEnabled = true;
            this.cbAvailability.Items.AddRange(new object[] {
            "Есть",
            "Отсутствует"});
            this.cbAvailability.Location = new System.Drawing.Point(16, 392);
            this.cbAvailability.Name = "cbAvailability";
            this.cbAvailability.Size = new System.Drawing.Size(573, 28);
            this.cbAvailability.TabIndex = 25;
            // 
            // cbCondition
            // 
            this.cbCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCondition.FormattingEnabled = true;
            this.cbCondition.Items.AddRange(new object[] {
            "Отличное",
            "Хорошее",
            "Удовлетворительное"});
            this.cbCondition.Location = new System.Drawing.Point(16, 464);
            this.cbCondition.Name = "cbCondition";
            this.cbCondition.Size = new System.Drawing.Size(573, 28);
            this.cbCondition.TabIndex = 24;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(16, 530);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(164, 34);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Очистить поля";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Gray;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLoad.Location = new System.Drawing.Point(390, 617);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(199, 34);
            this.btnLoad.TabIndex = 22;
            this.btnLoad.Text = "Загрузить файл XML";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gray;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(185, 617);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(199, 34);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Сохранить файл XML";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Автор",
            "Раздел",
            "Наличие"});
            this.cbSearch.Location = new System.Drawing.Point(16, 28);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(195, 28);
            this.cbSearch.TabIndex = 20;
            // 
            // lSearch
            // 
            this.lSearch.AutoSize = true;
            this.lSearch.Location = new System.Drawing.Point(16, 5);
            this.lSearch.Name = "lSearch";
            this.lSearch.Size = new System.Drawing.Size(77, 20);
            this.lSearch.TabIndex = 19;
            this.lSearch.Text = "Поиск по:";
            // 
            // tbSearch
            // 
            this.tbSearch.ForeColor = System.Drawing.Color.Silver;
            this.tbSearch.Location = new System.Drawing.Point(241, 28);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(337, 27);
            this.tbSearch.TabIndex = 18;
            this.tbSearch.Text = "Поиск...";
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1531, 688);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.dgvMain);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbPublishingHouse;
        private System.Windows.Forms.TextBox tbChapter;
        private System.Windows.Forms.Label lAuthor;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lPublishingHouse;
        private System.Windows.Forms.Label lChapter;
        private System.Windows.Forms.Label lAvailability;
        private System.Windows.Forms.Label lCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbAvailability;
        private System.Windows.Forms.ComboBox cbCondition;
    }
}

