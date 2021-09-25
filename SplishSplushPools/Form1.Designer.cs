namespace SplishSplushPools
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbPoolType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpHeatingPool = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.radSolarHeating = new System.Windows.Forms.RadioButton();
            this.radHeatPump = new System.Windows.Forms.RadioButton();
            this.radGeyser = new System.Windows.Forms.RadioButton();
            this.txtHeatedPoolCost = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grpSaltPool = new System.Windows.Forms.GroupBox();
            this.txtSaltWaterCost = new System.Windows.Forms.TextBox();
            this.txtSaltCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtNumOfLitres = new System.Windows.Forms.TextBox();
            this.txtBasicPoolCost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtpooltypeResults = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpHeatingPool.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpSaltPool.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.txtDepth);
            this.groupBox1.Controls.Add(this.txtWidth);
            this.groupBox1.Controls.Add(this.txtLength);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pool Size";
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(172, 110);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(100, 27);
            this.txtDepth.TabIndex = 9;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(172, 71);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 27);
            this.txtWidth.TabIndex = 8;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(172, 37);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 27);
            this.txtLength.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Depth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.cmbPoolType);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(317, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 91);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pool Type";
            // 
            // cmbPoolType
            // 
            this.cmbPoolType.FormattingEnabled = true;
            this.cmbPoolType.Location = new System.Drawing.Point(166, 33);
            this.cmbPoolType.Name = "cmbPoolType";
            this.cmbPoolType.Size = new System.Drawing.Size(168, 28);
            this.cmbPoolType.TabIndex = 2;
            this.cmbPoolType.SelectedIndexChanged += new System.EventHandler(this.cmbPoolType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Selected Pool Type";
            // 
            // grpHeatingPool
            // 
            this.grpHeatingPool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpHeatingPool.Controls.Add(this.panel1);
            this.grpHeatingPool.Controls.Add(this.txtHeatedPoolCost);
            this.grpHeatingPool.Controls.Add(this.label10);
            this.grpHeatingPool.Location = new System.Drawing.Point(317, 119);
            this.grpHeatingPool.Name = "grpHeatingPool";
            this.grpHeatingPool.Size = new System.Drawing.Size(308, 239);
            this.grpHeatingPool.TabIndex = 2;
            this.grpHeatingPool.TabStop = false;
            this.grpHeatingPool.Text = "Heating Pool";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.radSolarHeating);
            this.panel1.Controls.Add(this.radHeatPump);
            this.panel1.Controls.Add(this.radGeyser);
            this.panel1.Location = new System.Drawing.Point(20, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 131);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Heating Type:";
            // 
            // radSolarHeating
            // 
            this.radSolarHeating.AutoSize = true;
            this.radSolarHeating.Location = new System.Drawing.Point(19, 43);
            this.radSolarHeating.Name = "radSolarHeating";
            this.radSolarHeating.Size = new System.Drawing.Size(132, 24);
            this.radSolarHeating.TabIndex = 0;
            this.radSolarHeating.TabStop = true;
            this.radSolarHeating.Text = "Solar Heating";
            this.radSolarHeating.UseVisualStyleBackColor = true;
            // 
            // radHeatPump
            // 
            this.radHeatPump.AutoSize = true;
            this.radHeatPump.Location = new System.Drawing.Point(19, 73);
            this.radHeatPump.Name = "radHeatPump";
            this.radHeatPump.Size = new System.Drawing.Size(170, 24);
            this.radHeatPump.TabIndex = 1;
            this.radHeatPump.TabStop = true;
            this.radHeatPump.Text = "Heatpump Heating";
            this.radHeatPump.UseVisualStyleBackColor = true;
            // 
            // radGeyser
            // 
            this.radGeyser.AutoSize = true;
            this.radGeyser.Location = new System.Drawing.Point(19, 103);
            this.radGeyser.Name = "radGeyser";
            this.radGeyser.Size = new System.Drawing.Size(147, 24);
            this.radGeyser.TabIndex = 2;
            this.radGeyser.TabStop = true;
            this.radGeyser.Text = "Geyser Heating";
            this.radGeyser.UseVisualStyleBackColor = true;
            // 
            // txtHeatedPoolCost
            // 
            this.txtHeatedPoolCost.Location = new System.Drawing.Point(166, 196);
            this.txtHeatedPoolCost.Name = "txtHeatedPoolCost";
            this.txtHeatedPoolCost.Size = new System.Drawing.Size(121, 27);
            this.txtHeatedPoolCost.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Heated Pool Cost:";
            // 
            // grpSaltPool
            // 
            this.grpSaltPool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpSaltPool.Controls.Add(this.txtSaltWaterCost);
            this.grpSaltPool.Controls.Add(this.txtSaltCost);
            this.grpSaltPool.Controls.Add(this.label7);
            this.grpSaltPool.Controls.Add(this.label6);
            this.grpSaltPool.Location = new System.Drawing.Point(317, 378);
            this.grpSaltPool.Name = "grpSaltPool";
            this.grpSaltPool.Size = new System.Drawing.Size(308, 127);
            this.grpSaltPool.TabIndex = 3;
            this.grpSaltPool.TabStop = false;
            this.grpSaltPool.Text = "Salt Water Pool";
            // 
            // txtSaltWaterCost
            // 
            this.txtSaltWaterCost.Location = new System.Drawing.Point(187, 83);
            this.txtSaltWaterCost.Name = "txtSaltWaterCost";
            this.txtSaltWaterCost.Size = new System.Drawing.Size(100, 27);
            this.txtSaltWaterCost.TabIndex = 8;
            // 
            // txtSaltCost
            // 
            this.txtSaltCost.Location = new System.Drawing.Point(186, 39);
            this.txtSaltCost.Name = "txtSaltCost";
            this.txtSaltCost.Size = new System.Drawing.Size(101, 27);
            this.txtSaltCost.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Salt Water Pool Cost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Salt Cost:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Number of Litres:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Basics Pool Cost:";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(94, 434);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(128, 50);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Process Results";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtNumOfLitres
            // 
            this.txtNumOfLitres.Location = new System.Drawing.Point(158, 248);
            this.txtNumOfLitres.Name = "txtNumOfLitres";
            this.txtNumOfLitres.Size = new System.Drawing.Size(126, 27);
            this.txtNumOfLitres.TabIndex = 7;
            // 
            // txtBasicPoolCost
            // 
            this.txtBasicPoolCost.Location = new System.Drawing.Point(158, 290);
            this.txtBasicPoolCost.Name = "txtBasicPoolCost";
            this.txtBasicPoolCost.Size = new System.Drawing.Size(126, 27);
            this.txtBasicPoolCost.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Pool Type:";
            // 
            // txtpooltypeResults
            // 
            this.txtpooltypeResults.Location = new System.Drawing.Point(158, 348);
            this.txtpooltypeResults.Name = "txtpooltypeResults";
            this.txtpooltypeResults.Size = new System.Drawing.Size(126, 27);
            this.txtpooltypeResults.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(857, 573);
            this.Controls.Add(this.txtpooltypeResults);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBasicPoolCost);
            this.Controls.Add(this.txtNumOfLitres);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grpSaltPool);
            this.Controls.Add(this.grpHeatingPool);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Splish Splush Pools Company";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpHeatingPool.ResumeLayout(false);
            this.grpHeatingPool.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpSaltPool.ResumeLayout(false);
            this.grpSaltPool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpHeatingPool;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPoolType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radSolarHeating;
        private System.Windows.Forms.RadioButton radHeatPump;
        private System.Windows.Forms.RadioButton radGeyser;
        private System.Windows.Forms.TextBox txtHeatedPoolCost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpSaltPool;
        private System.Windows.Forms.TextBox txtSaltWaterCost;
        private System.Windows.Forms.TextBox txtSaltCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtNumOfLitres;
        private System.Windows.Forms.TextBox txtBasicPoolCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtpooltypeResults;
    }
}

