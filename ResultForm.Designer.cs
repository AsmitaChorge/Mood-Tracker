namespace SentimentAnalyzerApp
{
    partial class ResultForm
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
            this.lblInput = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.TextBox();
            this.btnAnalyzeAnother = new System.Windows.Forms.Button();
            this.btnSaveHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.BackColor = System.Drawing.SystemColors.MenuText;
            this.lblInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.ForeColor = System.Drawing.Color.White;
            this.lblInput.Location = new System.Drawing.Point(212, 232);
            this.lblInput.Multiline = true;
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(505, 54);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "\r\n";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Gold;
            this.lblResult.Location = new System.Drawing.Point(205, 157);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(557, 31);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Result";
            this.lblResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAnalyzeAnother
            // 
            this.btnAnalyzeAnother.BackColor = System.Drawing.Color.Gold;
            this.btnAnalyzeAnother.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalyzeAnother.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyzeAnother.Location = new System.Drawing.Point(504, 346);
            this.btnAnalyzeAnother.Name = "btnAnalyzeAnother";
            this.btnAnalyzeAnother.Size = new System.Drawing.Size(195, 49);
            this.btnAnalyzeAnother.TabIndex = 2;
            this.btnAnalyzeAnother.Text = "ANALYZE ANOTHER";
            this.btnAnalyzeAnother.UseVisualStyleBackColor = false;
            this.btnAnalyzeAnother.Click += new System.EventHandler(this.btnAnalyzeAnother_Click);
            // 
            // btnSaveHistory
            // 
            this.btnSaveHistory.BackColor = System.Drawing.Color.Gold;
            this.btnSaveHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveHistory.Location = new System.Drawing.Point(223, 346);
            this.btnSaveHistory.Name = "btnSaveHistory";
            this.btnSaveHistory.Size = new System.Drawing.Size(203, 49);
            this.btnSaveHistory.TabIndex = 3;
            this.btnSaveHistory.Text = "SAVE MOOD HISTORY";
            this.btnSaveHistory.UseVisualStyleBackColor = false;
            this.btnSaveHistory.Click += new System.EventHandler(this.saveMH_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(952, 572);
            this.Controls.Add(this.btnSaveHistory);
            this.Controls.Add(this.btnAnalyzeAnother);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblInput);
            this.Name = "ResultForm";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lblInput;
        private System.Windows.Forms.TextBox lblResult;
        private System.Windows.Forms.Button btnAnalyzeAnother;
        private System.Windows.Forms.Button btnSaveHistory;
    }
}