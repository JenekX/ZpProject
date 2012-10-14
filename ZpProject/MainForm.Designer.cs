namespace ZpProject
{
    partial class MainForm
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmReferences = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDepartments = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPaymentTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViewCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViewCategory1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViewCategory2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInterval = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIntervalCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIntervalCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReports = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReport1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReport2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPayments = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPaymentsCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.chFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmReferences,
            this.tsmView,
            this.tsmReports,
            this.tsmPayments});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(727, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "Главное меню";
            // 
            // tsmReferences
            // 
            this.tsmReferences.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDepartments,
            this.tsmEmployees,
            this.tsmPaymentTypes});
            this.tsmReferences.Name = "tsmReferences";
            this.tsmReferences.Size = new System.Drawing.Size(94, 20);
            this.tsmReferences.Text = "Справочники";
            // 
            // tsmDepartments
            // 
            this.tsmDepartments.Name = "tsmDepartments";
            this.tsmDepartments.Size = new System.Drawing.Size(174, 22);
            this.tsmDepartments.Text = "Отделы";
            this.tsmDepartments.Click += new System.EventHandler(this.TsmDepartmentsClick);
            // 
            // tsmEmployees
            // 
            this.tsmEmployees.Name = "tsmEmployees";
            this.tsmEmployees.Size = new System.Drawing.Size(174, 22);
            this.tsmEmployees.Text = "Сотрудники";
            this.tsmEmployees.Click += new System.EventHandler(this.TsmEmployeesClick);
            // 
            // tsmPaymentTypes
            // 
            this.tsmPaymentTypes.Name = "tsmPaymentTypes";
            this.tsmPaymentTypes.Size = new System.Drawing.Size(174, 22);
            this.tsmPaymentTypes.Text = "Типы начислений";
            this.tsmPaymentTypes.Click += new System.EventHandler(this.TsmPaymentTypesClick);
            // 
            // tsmView
            // 
            this.tsmView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmViewCategory,
            this.tsmInterval});
            this.tsmView.Name = "tsmView";
            this.tsmView.Size = new System.Drawing.Size(95, 20);
            this.tsmView.Text = "Отображение";
            // 
            // tsmViewCategory
            // 
            this.tsmViewCategory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmViewCategory1,
            this.tsmViewCategory2});
            this.tsmViewCategory.Name = "tsmViewCategory";
            this.tsmViewCategory.Size = new System.Drawing.Size(152, 22);
            this.tsmViewCategory.Text = "Категории";
            // 
            // tsmViewCategory1
            // 
            this.tsmViewCategory1.CheckOnClick = true;
            this.tsmViewCategory1.Name = "tsmViewCategory1";
            this.tsmViewCategory1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.tsmViewCategory1.Size = new System.Drawing.Size(179, 22);
            this.tsmViewCategory1.Text = "Категория 1";
            this.tsmViewCategory1.Click += new System.EventHandler(this.tsmViewCategory1_Click);
            // 
            // tsmViewCategory2
            // 
            this.tsmViewCategory2.CheckOnClick = true;
            this.tsmViewCategory2.Name = "tsmViewCategory2";
            this.tsmViewCategory2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.tsmViewCategory2.Size = new System.Drawing.Size(179, 22);
            this.tsmViewCategory2.Text = "Категория 2";
            this.tsmViewCategory2.Click += new System.EventHandler(this.tsmViewCategory2_Click);
            // 
            // tsmInterval
            // 
            this.tsmInterval.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmIntervalCurrent,
            this.tsmIntervalCustom});
            this.tsmInterval.Name = "tsmInterval";
            this.tsmInterval.Size = new System.Drawing.Size(152, 22);
            this.tsmInterval.Text = "Период";
            this.tsmInterval.DropDownOpening += new System.EventHandler(this.tsmInterval_DropDownOpening);
            // 
            // tsmIntervalCurrent
            // 
            this.tsmIntervalCurrent.Name = "tsmIntervalCurrent";
            this.tsmIntervalCurrent.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tsmIntervalCurrent.Size = new System.Drawing.Size(202, 22);
            this.tsmIntervalCurrent.Text = "Текущий месяц";
            this.tsmIntervalCurrent.Click += new System.EventHandler(this.tsmIntervalCurrent_Click);
            // 
            // tsmIntervalCustom
            // 
            this.tsmIntervalCustom.Name = "tsmIntervalCustom";
            this.tsmIntervalCustom.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.tsmIntervalCustom.Size = new System.Drawing.Size(202, 22);
            this.tsmIntervalCustom.Text = "Другой";
            this.tsmIntervalCustom.Click += new System.EventHandler(this.tsmIntervalCustom_Click);
            // 
            // tsmReports
            // 
            this.tsmReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmReport1,
            this.tsmReport2});
            this.tsmReports.Name = "tsmReports";
            this.tsmReports.Size = new System.Drawing.Size(60, 20);
            this.tsmReports.Text = "Отчеты";
            // 
            // tsmReport1
            // 
            this.tsmReport1.Name = "tsmReport1";
            this.tsmReport1.Size = new System.Drawing.Size(191, 22);
            this.tsmReport1.Text = "Расчетная ведомость";
            // 
            // tsmReport2
            // 
            this.tsmReport2.Name = "tsmReport2";
            this.tsmReport2.Size = new System.Drawing.Size(191, 22);
            this.tsmReport2.Text = "Расчетный листок";
            // 
            // tsmPayments
            // 
            this.tsmPayments.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPaymentsCreate});
            this.tsmPayments.Name = "tsmPayments";
            this.tsmPayments.Size = new System.Drawing.Size(87, 20);
            this.tsmPayments.Text = "Начисления";
            // 
            // tsmPaymentsCreate
            // 
            this.tsmPaymentsCreate.Name = "tsmPaymentsCreate";
            this.tsmPaymentsCreate.Size = new System.Drawing.Size(158, 22);
            this.tsmPaymentsCreate.Text = "Сформировать";
            this.tsmPaymentsCreate.Click += new System.EventHandler(this.tsmPaymentsCreate_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chFIO,
            this.chDepartment,
            this.chCategory,
            this.chSum});
            this.dgvItems.Location = new System.Drawing.Point(12, 27);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(703, 291);
            this.dgvItems.TabIndex = 1;
            this.dgvItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellDoubleClick);
            // 
            // chFIO
            // 
            this.chFIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chFIO.HeaderText = "Ф.И.О.";
            this.chFIO.Name = "chFIO";
            this.chFIO.ReadOnly = true;
            // 
            // chDepartment
            // 
            this.chDepartment.HeaderText = "Отдел";
            this.chDepartment.Name = "chDepartment";
            this.chDepartment.ReadOnly = true;
            // 
            // chCategory
            // 
            this.chCategory.HeaderText = "Категория";
            this.chCategory.Name = "chCategory";
            this.chCategory.ReadOnly = true;
            // 
            // chSum
            // 
            this.chSum.HeaderText = "Сумма";
            this.chSum.Name = "chSum";
            this.chSum.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 330);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчет зарплаты - {0}";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmReferences;
        private System.Windows.Forms.ToolStripMenuItem tsmEmployees;
        private System.Windows.Forms.ToolStripMenuItem tsmDepartments;
        private System.Windows.Forms.ToolStripMenuItem tsmPaymentTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmView;
        private System.Windows.Forms.ToolStripMenuItem tsmViewCategory;
        private System.Windows.Forms.ToolStripMenuItem tsmViewCategory1;
        private System.Windows.Forms.ToolStripMenuItem tsmViewCategory2;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.ToolStripMenuItem tsmInterval;
        private System.Windows.Forms.ToolStripMenuItem tsmIntervalCurrent;
        private System.Windows.Forms.ToolStripMenuItem tsmIntervalCustom;
        private System.Windows.Forms.ToolStripMenuItem tsmReports;
        private System.Windows.Forms.ToolStripMenuItem tsmReport1;
        private System.Windows.Forms.ToolStripMenuItem tsmReport2;
        private System.Windows.Forms.ToolStripMenuItem tsmPayments;
        private System.Windows.Forms.ToolStripMenuItem tsmPaymentsCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn chFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn chDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn chCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn chSum;
    }
}

