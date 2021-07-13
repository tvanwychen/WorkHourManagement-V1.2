
namespace WorkHourManagement_V1._2
{
    partial class HomePage
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbBxPayPeriods = new System.Windows.Forms.ComboBox();
            this.lblToday = new System.Windows.Forms.Label();
            this.lblTDay = new System.Windows.Forms.Label();
            this.txtBxRO = new System.Windows.Forms.TextBox();
            this.txtBxLaborTime = new System.Windows.Forms.TextBox();
            this.lblLaborTime = new System.Windows.Forms.Label();
            this.lblRoNum = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtbPayPeriodsDataSet = new WorkHourManagement_V1._2.dtbPayPeriodsDataSet();
            this.tblPayPeriodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPayPeriodsTableAdapter = new WorkHourManagement_V1._2.dtbPayPeriodsDataSetTableAdapters.tblPayPeriodsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laborHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbPayPeriodsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPayPeriodsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(175, 394);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 38);

            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));\
            
            this.btnClear.Location = new System.Drawing.Point(16, 394);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 38);

            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbBxPayPeriods
            // 
            this.cmbBxPayPeriods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBxPayPeriods.FormattingEnabled = true;

            this.cmbBxPayPeriods.Location = new System.Drawing.Point(16, 36);
            this.cmbBxPayPeriods.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBxPayPeriods.Name = "cmbBxPayPeriods";
            this.cmbBxPayPeriods.Size = new System.Drawing.Size(411, 33);

            this.cmbBxPayPeriods.TabIndex = 3;
            this.cmbBxPayPeriods.Text = "Select Pay Period...";
            this.cmbBxPayPeriods.SelectedValueChanged += new System.EventHandler(this.cmbBxPayPeriods_SelectedValueChanged);
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.lblToday.Location = new System.Drawing.Point(16, 107);
            this.lblToday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(130, 25);
            this.lblToday.TabIndex = 4;
            this.lblToday.Text = "Todays Date:";
            // 
            // lblTDay
            // 
            this.lblTDay.AutoSize = true;
            this.lblTDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.lblTDay.Location = new System.Drawing.Point(161, 107);
            this.lblTDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTDay.Name = "lblTDay";
            this.lblTDay.Size = new System.Drawing.Size(68, 25);
            this.lblTDay.TabIndex = 5;
            this.lblTDay.Text = "Today";
            // 
            // txtBxRO
            // 
            this.txtBxRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.txtBxRO.Location = new System.Drawing.Point(161, 241);
            this.txtBxRO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxRO.MaxLength = 6;
            this.txtBxRO.Name = "txtBxRO";
            this.txtBxRO.Size = new System.Drawing.Size(132, 30);
            this.txtBxRO.TabIndex = 6;
            // 
            // txtBxLaborTime
            // 
            this.txtBxLaborTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.txtBxLaborTime.Location = new System.Drawing.Point(161, 300);
            this.txtBxLaborTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxLaborTime.MaxLength = 4;
            this.txtBxLaborTime.Name = "txtBxLaborTime";
            this.txtBxLaborTime.Size = new System.Drawing.Size(132, 30);
            this.txtBxLaborTime.TabIndex = 7;
            // 
            // lblLaborTime
            // 
            this.lblLaborTime.AutoSize = true;
            this.lblLaborTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.lblLaborTime.Location = new System.Drawing.Point(16, 304);
            this.lblLaborTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLaborTime.Name = "lblLaborTime";
            this.lblLaborTime.Size = new System.Drawing.Size(117, 25);
            this.lblLaborTime.TabIndex = 8;
            this.lblLaborTime.Text = "Labor Time:";
            // 
            // lblRoNum
            // 
            this.lblRoNum.AutoSize = true;
            this.lblRoNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.lblRoNum.Location = new System.Drawing.Point(16, 245);
            this.lblRoNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoNum.Name = "lblRoNum";
            this.lblRoNum.Size = new System.Drawing.Size(121, 25);
            this.lblRoNum.TabIndex = 9;
            this.lblRoNum.Text = "RO Number:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;

            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.rODataGridViewTextBoxColumn,
            this.laborHoursDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPayPeriodsBindingSource;

            this.dataGridView1.Location = new System.Drawing.Point(509, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(524, 479);
            this.dataGridView1.TabIndex = 10;
            // 
            // dtbPayPeriodsDataSet
            // 
            this.dtbPayPeriodsDataSet.DataSetName = "dtbPayPeriodsDataSet";
            this.dtbPayPeriodsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPayPeriodsBindingSource
            // 
            this.tblPayPeriodsBindingSource.DataMember = "tblPayPeriods";
            this.tblPayPeriodsBindingSource.DataSource = this.dtbPayPeriodsDataSet;
            // 
            // tblPayPeriodsTableAdapter
            // 
            this.tblPayPeriodsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";

            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";

            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // rODataGridViewTextBoxColumn
            // 
            this.rODataGridViewTextBoxColumn.DataPropertyName = "RO";
            this.rODataGridViewTextBoxColumn.HeaderText = "RO";

            this.rODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rODataGridViewTextBoxColumn.Name = "rODataGridViewTextBoxColumn";
            this.rODataGridViewTextBoxColumn.ReadOnly = true;
            this.rODataGridViewTextBoxColumn.Width = 125;
            // 
            // laborHoursDataGridViewTextBoxColumn
            // 
            this.laborHoursDataGridViewTextBoxColumn.DataPropertyName = "LaborHours";
            this.laborHoursDataGridViewTextBoxColumn.HeaderText = "LaborHours";

            this.laborHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.laborHoursDataGridViewTextBoxColumn.Name = "laborHoursDataGridViewTextBoxColumn";
            this.laborHoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.laborHoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 503);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblRoNum);
            this.Controls.Add(this.lblLaborTime);
            this.Controls.Add(this.txtBxLaborTime);
            this.Controls.Add(this.txtBxRO);
            this.Controls.Add(this.lblTDay);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.cmbBxPayPeriods);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);

            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbBxPayPeriods;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblTDay;
        private System.Windows.Forms.TextBox txtBxRO;
        private System.Windows.Forms.TextBox txtBxLaborTime;
        private System.Windows.Forms.Label lblLaborTime;
        private System.Windows.Forms.Label lblRoNum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dtbPayPeriodsDataSet dtbPayPeriodsDataSet;
        private System.Windows.Forms.BindingSource tblPayPeriodsBindingSource;
        private dtbPayPeriodsDataSetTableAdapters.tblPayPeriodsTableAdapter tblPayPeriodsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laborHoursDataGridViewTextBoxColumn;
    }
}