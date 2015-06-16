namespace GasModelWin.Forms
{
    partial class WorkHistoryForm
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
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.btnChart = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.edP2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.edP1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGasType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miClose = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlChart = new System.Windows.Forms.Panel();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.cmbFormula = new System.Windows.Forms.ComboBox();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edP1)).BeginInit();
            this.msMain.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.cmbFormula);
            this.pnlFilter.Controls.Add(this.cmbUser);
            this.pnlFilter.Controls.Add(this.btnChart);
            this.pnlFilter.Controls.Add(this.btnFilter);
            this.pnlFilter.Controls.Add(this.edP2);
            this.pnlFilter.Controls.Add(this.label6);
            this.pnlFilter.Controls.Add(this.edP1);
            this.pnlFilter.Controls.Add(this.label5);
            this.pnlFilter.Controls.Add(this.label4);
            this.pnlFilter.Controls.Add(this.label3);
            this.pnlFilter.Controls.Add(this.cmbGasType);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Controls.Add(this.edDate);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Controls.Add(this.msMain);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(684, 162);
            this.pnlFilter.TabIndex = 0;
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(580, 125);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(91, 23);
            this.btnChart.TabIndex = 19;
            this.btnChart.Text = "График";
            this.btnChart.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(484, 125);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(91, 23);
            this.btnFilter.TabIndex = 18;
            this.btnFilter.Text = "Найти";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // edP2
            // 
            this.edP2.DecimalPlaces = 4;
            this.edP2.Location = new System.Drawing.Point(484, 61);
            this.edP2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.edP2.Name = "edP2";
            this.edP2.Size = new System.Drawing.Size(187, 22);
            this.edP2.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 14);
            this.label6.TabIndex = 16;
            this.label6.Text = "Давление в среде 2";
            // 
            // edP1
            // 
            this.edP1.DecimalPlaces = 4;
            this.edP1.Location = new System.Drawing.Point(484, 28);
            this.edP1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.edP1.Name = "edP1";
            this.edP1.Size = new System.Drawing.Size(187, 22);
            this.edP1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Давление в среде 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Тип газа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Расчетная формула";
            // 
            // cmbGasType
            // 
            this.cmbGasType.FormattingEnabled = true;
            this.cmbGasType.Location = new System.Drawing.Point(139, 93);
            this.cmbGasType.Name = "cmbGasType";
            this.cmbGasType.Size = new System.Drawing.Size(184, 22);
            this.cmbGasType.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пользователь";
            // 
            // edDate
            // 
            this.edDate.Location = new System.Drawing.Point(139, 28);
            this.edDate.Name = "edDate";
            this.edDate.Size = new System.Drawing.Size(184, 22);
            this.edDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата";
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miHelp,
            this.miClose});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.msMain.Size = new System.Drawing.Size(684, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDoc});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(48, 20);
            this.miFile.Text = "Файл";
            // 
            // miDoc
            // 
            this.miDoc.Name = "miDoc";
            this.miDoc.Size = new System.Drawing.Size(202, 22);
            this.miDoc.Text = "Создать документацию";
            // 
            // miHelp
            // 
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(65, 20);
            this.miHelp.Text = "Справка";
            // 
            // miClose
            // 
            this.miClose.Name = "miClose";
            this.miClose.Size = new System.Drawing.Size(53, 20);
            this.miClose.Text = "Выход";
            this.miClose.Click += new System.EventHandler(this.miClose_Click);
            // 
            // pnlChart
            // 
            this.pnlChart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChart.Location = new System.Drawing.Point(0, 342);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(684, 210);
            this.pnlChart.TabIndex = 1;
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.dgvResults);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(0, 162);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(684, 180);
            this.pnlData.TabIndex = 2;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(0, 0);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.Size = new System.Drawing.Size(684, 180);
            this.dgvResults.TabIndex = 0;
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(139, 60);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(184, 22);
            this.cmbUser.TabIndex = 20;
            // 
            // cmbFormula
            // 
            this.cmbFormula.FormattingEnabled = true;
            this.cmbFormula.Location = new System.Drawing.Point(139, 126);
            this.cmbFormula.Name = "cmbFormula";
            this.cmbFormula.Size = new System.Drawing.Size(184, 22);
            this.cmbFormula.TabIndex = 21;
            // 
            // WorkHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 552);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlChart);
            this.Controls.Add(this.pnlFilter);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.msMain;
            this.MinimizeBox = false;
            this.Name = "WorkHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "История работы";
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edP1)).EndInit();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Panel pnlChart;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miDoc;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGasType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker edDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.NumericUpDown edP2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown edP1;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.ComboBox cmbFormula;
        private System.Windows.Forms.ComboBox cmbUser;
    }
}