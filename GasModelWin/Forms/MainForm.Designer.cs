namespace GasModelWin.Forms
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
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miWorkHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.miDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.rbDiff = new System.Windows.Forms.RadioButton();
            this.rbIntegr = new System.Windows.Forms.RadioButton();
            this.cmbGasType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.txtGasVolume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGasType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTemperatureResult = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdiabatic = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBCoeff = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtACoeff = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtResultP1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtResultP2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miHelp,
            this.miAbout,
            this.miExit});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(648, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miWorkHistory,
            this.miDoc});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(48, 20);
            this.miFile.Text = "Файл";
            // 
            // miWorkHistory
            // 
            this.miWorkHistory.Name = "miWorkHistory";
            this.miWorkHistory.Size = new System.Drawing.Size(165, 22);
            this.miWorkHistory.Text = "История работы";
            // 
            // miDoc
            // 
            this.miDoc.Name = "miDoc";
            this.miDoc.Size = new System.Drawing.Size(165, 22);
            this.miDoc.Text = "Документация";
            // 
            // miHelp
            // 
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(65, 20);
            this.miHelp.Text = "Справка";
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(94, 20);
            this.miAbout.Text = "О программе";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(53, 20);
            this.miExit.Text = "Выход";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpOutput);
            this.splitContainer1.Size = new System.Drawing.Size(648, 410);
            this.splitContainer1.SplitterDistance = 305;
            this.splitContainer1.TabIndex = 1;
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.btnCalc);
            this.grpInput.Controls.Add(this.txtP2);
            this.grpInput.Controls.Add(this.label5);
            this.grpInput.Controls.Add(this.txtP1);
            this.grpInput.Controls.Add(this.label4);
            this.grpInput.Controls.Add(this.txtGasVolume);
            this.grpInput.Controls.Add(this.label3);
            this.grpInput.Controls.Add(this.txtTemperature);
            this.grpInput.Controls.Add(this.label2);
            this.grpInput.Controls.Add(this.label1);
            this.grpInput.Controls.Add(this.cmbGasType);
            this.grpInput.Controls.Add(this.rbIntegr);
            this.grpInput.Controls.Add(this.rbDiff);
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInput.Location = new System.Drawing.Point(0, 0);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(305, 410);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Исходные данные";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.label16);
            this.grpOutput.Controls.Add(this.txtResult);
            this.grpOutput.Controls.Add(this.label15);
            this.grpOutput.Controls.Add(this.txtResultP2);
            this.grpOutput.Controls.Add(this.label14);
            this.grpOutput.Controls.Add(this.txtResultP1);
            this.grpOutput.Controls.Add(this.label13);
            this.grpOutput.Controls.Add(this.txtCp);
            this.grpOutput.Controls.Add(this.label12);
            this.grpOutput.Controls.Add(this.txtACoeff);
            this.grpOutput.Controls.Add(this.label11);
            this.grpOutput.Controls.Add(this.txtBCoeff);
            this.grpOutput.Controls.Add(this.label10);
            this.grpOutput.Controls.Add(this.txtAdiabatic);
            this.grpOutput.Controls.Add(this.label9);
            this.grpOutput.Controls.Add(this.txtTemperatureResult);
            this.grpOutput.Controls.Add(this.label8);
            this.grpOutput.Controls.Add(this.txtFormula);
            this.grpOutput.Controls.Add(this.label7);
            this.grpOutput.Controls.Add(this.txtGasType);
            this.grpOutput.Controls.Add(this.label6);
            this.grpOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOutput.Location = new System.Drawing.Point(0, 0);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(339, 410);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Результаты";
            this.grpOutput.Enter += new System.EventHandler(this.grpOutput_Enter);
            // 
            // rbDiff
            // 
            this.rbDiff.AutoSize = true;
            this.rbDiff.Location = new System.Drawing.Point(12, 22);
            this.rbDiff.Name = "rbDiff";
            this.rbDiff.Size = new System.Drawing.Size(128, 18);
            this.rbDiff.TabIndex = 0;
            this.rbDiff.Text = "Дифф. уравнение";
            this.rbDiff.UseVisualStyleBackColor = true;
            this.rbDiff.CheckedChanged += new System.EventHandler(this.rbDiff_CheckedChanged);
            // 
            // rbIntegr
            // 
            this.rbIntegr.AutoSize = true;
            this.rbIntegr.Location = new System.Drawing.Point(156, 22);
            this.rbIntegr.Name = "rbIntegr";
            this.rbIntegr.Size = new System.Drawing.Size(133, 18);
            this.rbIntegr.TabIndex = 1;
            this.rbIntegr.Text = "Интегр. уравнение";
            this.rbIntegr.UseVisualStyleBackColor = true;
            this.rbIntegr.CheckedChanged += new System.EventHandler(this.rbDiff_CheckedChanged);
            // 
            // cmbGasType
            // 
            this.cmbGasType.FormattingEnabled = true;
            this.cmbGasType.Location = new System.Drawing.Point(12, 76);
            this.cmbGasType.Name = "cmbGasType";
            this.cmbGasType.Size = new System.Drawing.Size(277, 22);
            this.cmbGasType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тип газа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Температура газа от -73С до +73С";
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(12, 133);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(277, 22);
            this.txtTemperature.TabIndex = 5;
            // 
            // txtGasVolume
            // 
            this.txtGasVolume.Location = new System.Drawing.Point(12, 191);
            this.txtGasVolume.Name = "txtGasVolume";
            this.txtGasVolume.Size = new System.Drawing.Size(277, 22);
            this.txtGasVolume.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Объем истекающего газа";
            // 
            // txtP1
            // 
            this.txtP1.Location = new System.Drawing.Point(12, 247);
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(277, 22);
            this.txtP1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Давление в среде №1";
            // 
            // txtP2
            // 
            this.txtP2.Location = new System.Drawing.Point(12, 308);
            this.txtP2.Name = "txtP2";
            this.txtP2.Size = new System.Drawing.Size(277, 22);
            this.txtP2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Давление в среде №2";
            // 
            // txtGasType
            // 
            this.txtGasType.Location = new System.Drawing.Point(79, 23);
            this.txtGasType.Name = "txtGasType";
            this.txtGasType.ReadOnly = true;
            this.txtGasType.Size = new System.Drawing.Size(248, 22);
            this.txtGasType.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Тип газа - ";
            // 
            // txtFormula
            // 
            this.txtFormula.Location = new System.Drawing.Point(145, 56);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.ReadOnly = true;
            this.txtFormula.Size = new System.Drawing.Size(182, 22);
            this.txtFormula.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "Расчетная формула - ";
            // 
            // txtTemperatureResult
            // 
            this.txtTemperatureResult.Location = new System.Drawing.Point(145, 91);
            this.txtTemperatureResult.Name = "txtTemperatureResult";
            this.txtTemperatureResult.ReadOnly = true;
            this.txtTemperatureResult.Size = new System.Drawing.Size(182, 22);
            this.txtTemperatureResult.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 14);
            this.label8.TabIndex = 14;
            this.label8.Text = "Температура газа =";
            // 
            // txtAdiabatic
            // 
            this.txtAdiabatic.Location = new System.Drawing.Point(170, 127);
            this.txtAdiabatic.Name = "txtAdiabatic";
            this.txtAdiabatic.ReadOnly = true;
            this.txtAdiabatic.Size = new System.Drawing.Size(157, 22);
            this.txtAdiabatic.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "Адиабатная постоянная =";
            // 
            // txtBCoeff
            // 
            this.txtBCoeff.Location = new System.Drawing.Point(123, 164);
            this.txtBCoeff.Name = "txtBCoeff";
            this.txtBCoeff.ReadOnly = true;
            this.txtBCoeff.Size = new System.Drawing.Size(204, 22);
            this.txtBCoeff.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 14);
            this.label10.TabIndex = 18;
            this.label10.Text = "Коэффициент а =";
            // 
            // txtACoeff
            // 
            this.txtACoeff.Location = new System.Drawing.Point(123, 199);
            this.txtACoeff.Name = "txtACoeff";
            this.txtACoeff.ReadOnly = true;
            this.txtACoeff.Size = new System.Drawing.Size(204, 22);
            this.txtACoeff.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 14);
            this.label11.TabIndex = 20;
            this.label11.Text = "Коэффициент b =";
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(188, 234);
            this.txtCp.Name = "txtCp";
            this.txtCp.ReadOnly = true;
            this.txtCp.Size = new System.Drawing.Size(139, 22);
            this.txtCp.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 14);
            this.label12.TabIndex = 22;
            this.label12.Text = "Удельная теплоемкость Cp =";
            // 
            // txtResultP1
            // 
            this.txtResultP1.Location = new System.Drawing.Point(102, 270);
            this.txtResultP1.Name = "txtResultP1";
            this.txtResultP1.ReadOnly = true;
            this.txtResultP1.Size = new System.Drawing.Size(225, 22);
            this.txtResultP1.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 273);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 14);
            this.label13.TabIndex = 24;
            this.label13.Text = "Давлени Р1 = ";
            // 
            // txtResultP2
            // 
            this.txtResultP2.Location = new System.Drawing.Point(102, 308);
            this.txtResultP2.Name = "txtResultP2";
            this.txtResultP2.ReadOnly = true;
            this.txtResultP2.Size = new System.Drawing.Size(225, 22);
            this.txtResultP2.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 311);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 14);
            this.label14.TabIndex = 26;
            this.label14.Text = "Давлени Р2 = ";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(102, 369);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(225, 22);
            this.txtResult.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 345);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 14);
            this.label15.TabIndex = 28;
            this.label15.Text = "Результат моделирования:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 372);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 14);
            this.label16.TabIndex = 30;
            this.label16.Text = "Т2 - Т1 = ";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(198, 341);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(91, 45);
            this.btnCalc.TabIndex = 12;
            this.btnCalc.Text = "Получить результат";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 434);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.msMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.msMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miWorkHistory;
        private System.Windows.Forms.ToolStripMenuItem miDoc;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.TextBox txtP2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtP1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGasVolume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGasType;
        private System.Windows.Forms.RadioButton rbIntegr;
        private System.Windows.Forms.RadioButton rbDiff;
        private System.Windows.Forms.TextBox txtGasType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtACoeff;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBCoeff;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAdiabatic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTemperatureResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFormula;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtResultP2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtResultP1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCalc;
    }
}