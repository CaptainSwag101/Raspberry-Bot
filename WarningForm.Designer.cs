namespace Raspberry
{
    partial class WarningForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OkayButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(32)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 41);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Renogare", 20.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work in Progress";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Renogare", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(32)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(0, 44);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(400, 109);
            this.label2.TabIndex = 1;
            this.label2.Text = "This bot was made by a 16 year old who doesn\'t actually know C#, expect it to be " +
    "unstable and bad.";
            // 
            // OkayButton
            // 
            this.OkayButton.AutoSize = true;
            this.OkayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(32)))), ((int)(((byte)(66)))));
            this.OkayButton.FlatAppearance.BorderSize = 0;
            this.OkayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkayButton.Font = new System.Drawing.Font("Renogare", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OkayButton.Location = new System.Drawing.Point(307, 154);
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.Size = new System.Drawing.Size(81, 38);
            this.OkayButton.TabIndex = 2;
            this.OkayButton.Text = "Okay";
            this.OkayButton.UseVisualStyleBackColor = false;
            this.OkayButton.Click += new System.EventHandler(this.OkayButton_Click);
            // 
            // WarningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(400, 204);
            this.Controls.Add(this.OkayButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WarningForm";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OkayButton;
    }
}