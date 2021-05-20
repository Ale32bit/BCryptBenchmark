
namespace BCryptBenchmark {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if ( disposing && (components != null) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timeTakenText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.costResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.runTestButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.minTimeInput = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timeTakenManualText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBarManual = new System.Windows.Forms.ProgressBar();
            this.runManualTestButton = new System.Windows.Forms.Button();
            this.manualCostInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minTimeInput)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manualCostInput)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeTakenText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.costResult);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.runTestButton);
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.minTimeInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Benchmark best cost";
            // 
            // timeTakenText
            // 
            this.timeTakenText.Location = new System.Drawing.Point(179, 118);
            this.timeTakenText.Name = "timeTakenText";
            this.timeTakenText.ReadOnly = true;
            this.timeTakenText.Size = new System.Drawing.Size(120, 27);
            this.timeTakenText.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "This cost took:";
            // 
            // costResult
            // 
            this.costResult.Location = new System.Drawing.Point(179, 85);
            this.costResult.Name = "costResult";
            this.costResult.ReadOnly = true;
            this.costResult.Size = new System.Drawing.Size(120, 27);
            this.costResult.TabIndex = 5;
            this.costResult.Text = "4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Best cost:";
            // 
            // runTestButton
            // 
            this.runTestButton.Location = new System.Drawing.Point(179, 46);
            this.runTestButton.Name = "runTestButton";
            this.runTestButton.Size = new System.Drawing.Size(120, 29);
            this.runTestButton.TabIndex = 1;
            this.runTestButton.Text = "Run Test";
            this.runTestButton.UseVisualStyleBackColor = true;
            this.runTestButton.Click += new System.EventHandler(this.runTestButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 151);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(293, 29);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Target time in ms";
            // 
            // minTimeInput
            // 
            this.minTimeInput.Location = new System.Drawing.Point(6, 46);
            this.minTimeInput.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.minTimeInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minTimeInput.Name = "minTimeInput";
            this.minTimeInput.Size = new System.Drawing.Size(167, 27);
            this.minTimeInput.TabIndex = 0;
            this.minTimeInput.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.timeTakenManualText);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.progressBarManual);
            this.groupBox2.Controls.Add(this.runManualTestButton);
            this.groupBox2.Controls.Add(this.manualCostInput);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Benchmark manual cost";
            // 
            // timeTakenManualText
            // 
            this.timeTakenManualText.Location = new System.Drawing.Point(136, 61);
            this.timeTakenManualText.Name = "timeTakenManualText";
            this.timeTakenManualText.ReadOnly = true;
            this.timeTakenManualText.Size = new System.Drawing.Size(163, 27);
            this.timeTakenManualText.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Time taken in ms:";
            // 
            // progressBarManual
            // 
            this.progressBarManual.Location = new System.Drawing.Point(7, 94);
            this.progressBarManual.Name = "progressBarManual";
            this.progressBarManual.Size = new System.Drawing.Size(292, 29);
            this.progressBarManual.TabIndex = 7;
            // 
            // runManualTestButton
            // 
            this.runManualTestButton.Location = new System.Drawing.Point(179, 25);
            this.runManualTestButton.Name = "runManualTestButton";
            this.runManualTestButton.Size = new System.Drawing.Size(120, 29);
            this.runManualTestButton.TabIndex = 6;
            this.runManualTestButton.Text = "Run Test";
            this.runManualTestButton.UseVisualStyleBackColor = true;
            this.runManualTestButton.Click += new System.EventHandler(this.runManualTestButton_Click);
            // 
            // manualCostInput
            // 
            this.manualCostInput.Location = new System.Drawing.Point(54, 25);
            this.manualCostInput.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.manualCostInput.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.manualCostInput.Name = "manualCostInput";
            this.manualCostInput.Size = new System.Drawing.Size(99, 27);
            this.manualCostInput.TabIndex = 5;
            this.manualCostInput.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cost:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 353);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "BCrypt Benchmark";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minTimeInput)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manualCostInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button runTestButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown minTimeInput;
        private System.Windows.Forms.TextBox costResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox timeTakenManualText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBarManual;
        private System.Windows.Forms.Button runManualTestButton;
        private System.Windows.Forms.NumericUpDown manualCostInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timeTakenText;
        private System.Windows.Forms.Label label5;
    }
}

