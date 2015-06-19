namespace GasModelWin.Forms
{
    partial class PredictionForm
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
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miClose = new System.Windows.Forms.ToolStripMenuItem();
            this.edRadius = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.grpInputData = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edSolarRadiation = new System.Windows.Forms.NumericUpDown();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.edTubeWeight = new System.Windows.Forms.NumericUpDown();
            this.edHeatQuantity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.edMeltingTime = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreatePrediction = new System.Windows.Forms.Button();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRadius)).BeginInit();
            this.grpInputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edSolarRadiation)).BeginInit();
            this.grpResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edTubeWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHeatQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMeltingTime)).BeginInit();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHelp,
            this.miClose});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(498, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
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
            // edRadius
            // 
            this.edRadius.DecimalPlaces = 4;
            this.edRadius.Location = new System.Drawing.Point(20, 45);
            this.edRadius.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.edRadius.Name = "edRadius";
            this.edRadius.Size = new System.Drawing.Size(147, 22);
            this.edRadius.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 14);
            this.label3.TabIndex = 15;
            this.label3.Text = "Радиус ледяной пробки";
            // 
            // grpInputData
            // 
            this.grpInputData.Controls.Add(this.label2);
            this.grpInputData.Controls.Add(this.label4);
            this.grpInputData.Controls.Add(this.edSolarRadiation);
            this.grpInputData.Controls.Add(this.label1);
            this.grpInputData.Controls.Add(this.label3);
            this.grpInputData.Controls.Add(this.edRadius);
            this.grpInputData.Location = new System.Drawing.Point(12, 27);
            this.grpInputData.Name = "grpInputData";
            this.grpInputData.Size = new System.Drawing.Size(471, 87);
            this.grpInputData.TabIndex = 17;
            this.grpInputData.TabStop = false;
            this.grpInputData.Text = "Исходные данные";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 14);
            this.label1.TabIndex = 17;
            this.label1.Text = "метры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 20;
            this.label2.Text = "Вт/м^2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 14);
            this.label4.TabIndex = 18;
            this.label4.Text = "Величина солнечного излучения";
            // 
            // edSolarRadiation
            // 
            this.edSolarRadiation.DecimalPlaces = 4;
            this.edSolarRadiation.Location = new System.Drawing.Point(253, 45);
            this.edSolarRadiation.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.edSolarRadiation.Name = "edSolarRadiation";
            this.edSolarRadiation.Size = new System.Drawing.Size(147, 22);
            this.edSolarRadiation.TabIndex = 19;
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.edMeltingTime);
            this.grpResults.Controls.Add(this.label6);
            this.grpResults.Controls.Add(this.edHeatQuantity);
            this.grpResults.Controls.Add(this.label5);
            this.grpResults.Controls.Add(this.edTubeWeight);
            this.grpResults.Controls.Add(this.label8);
            this.grpResults.Location = new System.Drawing.Point(12, 120);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(471, 120);
            this.grpResults.TabIndex = 21;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Результаты прогнозирования";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 14);
            this.label8.TabIndex = 15;
            this.label8.Text = "Масса ледяной пробки = ";
            // 
            // edTubeWeight
            // 
            this.edTubeWeight.DecimalPlaces = 4;
            this.edTubeWeight.Enabled = false;
            this.edTubeWeight.Location = new System.Drawing.Point(176, 23);
            this.edTubeWeight.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.edTubeWeight.Name = "edTubeWeight";
            this.edTubeWeight.ReadOnly = true;
            this.edTubeWeight.Size = new System.Drawing.Size(279, 22);
            this.edTubeWeight.TabIndex = 21;
            // 
            // edHeatQuantity
            // 
            this.edHeatQuantity.DecimalPlaces = 4;
            this.edHeatQuantity.Enabled = false;
            this.edHeatQuantity.Location = new System.Drawing.Point(346, 52);
            this.edHeatQuantity.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.edHeatQuantity.Name = "edHeatQuantity";
            this.edHeatQuantity.ReadOnly = true;
            this.edHeatQuantity.Size = new System.Drawing.Size(109, 22);
            this.edHeatQuantity.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 14);
            this.label5.TabIndex = 22;
            this.label5.Text = "Суммарное количество теплоты для таяния пробки = ";
            // 
            // edMeltingTime
            // 
            this.edMeltingTime.DecimalPlaces = 4;
            this.edMeltingTime.Enabled = false;
            this.edMeltingTime.Location = new System.Drawing.Point(282, 80);
            this.edMeltingTime.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.edMeltingTime.Name = "edMeltingTime";
            this.edMeltingTime.ReadOnly = true;
            this.edMeltingTime.Size = new System.Drawing.Size(173, 22);
            this.edMeltingTime.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 14);
            this.label6.TabIndex = 24;
            this.label6.Text = "Время, необходимое для таяния пробки = ";
            // 
            // btnCreatePrediction
            // 
            this.btnCreatePrediction.Location = new System.Drawing.Point(358, 246);
            this.btnCreatePrediction.Name = "btnCreatePrediction";
            this.btnCreatePrediction.Size = new System.Drawing.Size(125, 38);
            this.btnCreatePrediction.TabIndex = 22;
            this.btnCreatePrediction.Text = "Создать прогноз";
            this.btnCreatePrediction.UseVisualStyleBackColor = true;
            this.btnCreatePrediction.Click += new System.EventHandler(this.btnCreatePrediction_Click);
            // 
            // PredictionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 296);
            this.Controls.Add(this.btnCreatePrediction);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpInputData);
            this.Controls.Add(this.msMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.msMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PredictionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прогноз";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRadius)).EndInit();
            this.grpInputData.ResumeLayout(false);
            this.grpInputData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edSolarRadiation)).EndInit();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edTubeWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHeatQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMeltingTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miClose;
        private System.Windows.Forms.NumericUpDown edRadius;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpInputData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown edSolarRadiation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.NumericUpDown edMeltingTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown edHeatQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown edTubeWeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCreatePrediction;
    }
}