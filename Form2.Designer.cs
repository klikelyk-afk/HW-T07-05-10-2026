namespace WinFormsApp_Babylon_2026_v2
{
    partial class Form2
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
            buttonScan = new Button();
            buttonLoadScripts = new Button();
            listBoxScripts = new ListBox();
            textBoxScanResult = new TextBox();
            SuspendLayout();
            // 
            // buttonScan
            // 
            buttonScan.Location = new Point(12, 12);
            buttonScan.Name = "buttonScan";
            buttonScan.Size = new Size(144, 29);
            buttonScan.TabIndex = 0;
            buttonScan.Text = "Scan";
            buttonScan.UseVisualStyleBackColor = true;
            buttonScan.Click += buttonScan_Click;
            // 
            // buttonLoadScripts
            // 
            buttonLoadScripts.Location = new Point(381, 12);
            buttonLoadScripts.Name = "buttonLoadScripts";
            buttonLoadScripts.Size = new Size(144, 29);
            buttonLoadScripts.TabIndex = 1;
            buttonLoadScripts.Text = "Load scripts";
            buttonLoadScripts.UseVisualStyleBackColor = true;
            buttonLoadScripts.Click += buttonLoadScripts_Click;
            // 
            // listBoxScripts
            // 
            listBoxScripts.FormattingEnabled = true;
            listBoxScripts.Location = new Point(381, 64);
            listBoxScripts.Name = "listBoxScripts";
            listBoxScripts.Size = new Size(208, 504);
            listBoxScripts.TabIndex = 2;
            // 
            // textBoxScanResult
            // 
            textBoxScanResult.Location = new Point(12, 64);
            textBoxScanResult.Multiline = true;
            textBoxScanResult.Name = "textBoxScanResult";
            textBoxScanResult.ScrollBars = ScrollBars.Vertical;
            textBoxScanResult.Size = new Size(340, 507);
            textBoxScanResult.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 583);
            Controls.Add(textBoxScanResult);
            Controls.Add(listBoxScripts);
            Controls.Add(buttonLoadScripts);
            Controls.Add(buttonScan);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonScan;
        private Button buttonLoadScripts;
        private ListBox listBoxScripts;
        private TextBox textBoxScanResult;
    }
}