namespace Forms
{
    partial class FrmLog
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
            dtgLog = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgLog).BeginInit();
            SuspendLayout();
            // 
            // dtgLog
            // 
            dtgLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgLog.Location = new Point(2, -1);
            dtgLog.Name = "dtgLog";
            dtgLog.RowTemplate.Height = 25;
            dtgLog.Size = new Size(555, 452);
            dtgLog.TabIndex = 0;
            // 
            // FrmLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 450);
            Controls.Add(dtgLog);
            Name = "FrmLog";
            Text = "frmLog";
            Load += FrmLog_Load;
            ((System.ComponentModel.ISupportInitialize)dtgLog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgLog;
    }
}