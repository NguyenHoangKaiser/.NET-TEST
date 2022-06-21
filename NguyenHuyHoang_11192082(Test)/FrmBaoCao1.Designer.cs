namespace NguyenHuyHoang_11192082_Test_
{
    partial class FrmBaoCao1
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
            this.crpBaoCaoTS = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpBaoCaoTS
            // 
            this.crpBaoCaoTS.ActiveViewIndex = -1;
            this.crpBaoCaoTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpBaoCaoTS.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpBaoCaoTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpBaoCaoTS.Location = new System.Drawing.Point(0, 0);
            this.crpBaoCaoTS.Name = "crpBaoCaoTS";
            this.crpBaoCaoTS.Size = new System.Drawing.Size(1254, 504);
            this.crpBaoCaoTS.TabIndex = 0;
            // 
            // FrmBaoCao1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 504);
            this.Controls.Add(this.crpBaoCaoTS);
            this.Name = "FrmBaoCao1";
            this.Text = "FrmBaoCao1";
            this.Load += new System.EventHandler(this.FrmBaoCao1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpBaoCaoTS;
    }
}