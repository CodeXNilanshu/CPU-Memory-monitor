namespace CPU_Memory_monitor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBarCPU = new System.Windows.Forms.ProgressBar();
            this.progressBarMem = new System.Windows.Forms.ProgressBar();
            this.buttonStart = new System.Windows.Forms.Button();
            this.lblCpuUsage = new System.Windows.Forms.Label();
            this.lblMemUsage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU Usage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Memory Usage:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // progressBarCPU
            // 
            this.progressBarCPU.Location = new System.Drawing.Point(27, 83);
            this.progressBarCPU.Name = "progressBarCPU";
            this.progressBarCPU.Size = new System.Drawing.Size(637, 23);
            this.progressBarCPU.TabIndex = 2;
            // 
            // progressBarMem
            // 
            this.progressBarMem.Location = new System.Drawing.Point(27, 195);
            this.progressBarMem.Name = "progressBarMem";
            this.progressBarMem.Size = new System.Drawing.Size(636, 23);
            this.progressBarMem.TabIndex = 3;
            this.progressBarMem.Click += new System.EventHandler(this.progressBarMem_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(26, 244);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(110, 36);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // lblCpuUsage
            // 
            this.lblCpuUsage.AutoSize = true;
            this.lblCpuUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuUsage.Location = new System.Drawing.Point(619, 46);
            this.lblCpuUsage.Name = "lblCpuUsage";
            this.lblCpuUsage.Size = new System.Drawing.Size(35, 20);
            this.lblCpuUsage.TabIndex = 5;
            this.lblCpuUsage.Text = "0%";
            this.lblCpuUsage.Click += new System.EventHandler(this.lblCpuUsage_Click);
            // 
            // lblMemUsage
            // 
            this.lblMemUsage.AutoSize = true;
            this.lblMemUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemUsage.Location = new System.Drawing.Point(619, 153);
            this.lblMemUsage.Name = "lblMemUsage";
            this.lblMemUsage.Size = new System.Drawing.Size(35, 20);
            this.lblMemUsage.TabIndex = 6;
            this.lblMemUsage.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 292);
            this.Controls.Add(this.lblMemUsage);
            this.Controls.Add(this.lblCpuUsage);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.progressBarMem);
            this.Controls.Add(this.progressBarCPU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBarCPU;
        private System.Windows.Forms.ProgressBar progressBarMem;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label lblCpuUsage;
        private System.Windows.Forms.Label lblMemUsage;
    }
}

