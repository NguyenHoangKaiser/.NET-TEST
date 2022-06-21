namespace NguyenHuyHoang_11192082_Test_
{
    partial class FrmTimKiem
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
            this.dataGridTImKiem = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFInd = new System.Windows.Forms.Button();
            this.txtNUOC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTImKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTImKiem
            // 
            this.dataGridTImKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTImKiem.Location = new System.Drawing.Point(115, 199);
            this.dataGridTImKiem.Name = "dataGridTImKiem";
            this.dataGridTImKiem.RowTemplate.Height = 24;
            this.dataGridTImKiem.Size = new System.Drawing.Size(997, 271);
            this.dataGridTImKiem.TabIndex = 27;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(940, 112);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 67);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFInd
            // 
            this.btnFInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFInd.Location = new System.Drawing.Point(730, 112);
            this.btnFInd.Name = "btnFInd";
            this.btnFInd.Size = new System.Drawing.Size(177, 67);
            this.btnFInd.TabIndex = 25;
            this.btnFInd.Text = "Tìm kiếm";
            this.btnFInd.UseVisualStyleBackColor = true;
            this.btnFInd.Click += new System.EventHandler(this.btnFInd_Click);
            // 
            // txtNUOC
            // 
            this.txtNUOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNUOC.Location = new System.Drawing.Point(377, 127);
            this.txtNUOC.Name = "txtNUOC";
            this.txtNUOC.Size = new System.Drawing.Size(336, 38);
            this.txtNUOC.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "NƯỚC SẢN XUẤT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 38);
            this.label1.TabIndex = 22;
            this.label1.Text = "TÌM KIẾM THÔNG TIN";
            // 
            // FrmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 696);
            this.Controls.Add(this.dataGridTImKiem);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFInd);
            this.Controls.Add(this.txtNUOC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTimKiem";
            this.Text = "FrmTimKiem";
            this.Load += new System.EventHandler(this.FrmTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTImKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTImKiem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFInd;
        private System.Windows.Forms.TextBox txtNUOC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}