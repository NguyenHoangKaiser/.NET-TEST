namespace NguyenHuyHoang_11192082_Test_
{
    partial class FrmNhap
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
            this.components = new System.ComponentModel.Container();
            this.tEST1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEST1DataSet = new NguyenHuyHoang_11192082_Test_.TEST1DataSet();
            this.cboDVdi = new System.Windows.Forms.ComboBox();
            this.cboDVden = new System.Windows.Forms.ComboBox();
            this.txtMaDC = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboMaTS = new System.Windows.Forms.ComboBox();
            this.dtpNgayDC = new System.Windows.Forms.DateTimePicker();
            this.dataGridDieuChuyen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tEST1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEST1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDieuChuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // tEST1DataSetBindingSource
            // 
            this.tEST1DataSetBindingSource.DataSource = this.tEST1DataSet;
            this.tEST1DataSetBindingSource.Position = 0;
            // 
            // tEST1DataSet
            // 
            this.tEST1DataSet.DataSetName = "TEST1DataSet";
            this.tEST1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboDVdi
            // 
            this.cboDVdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDVdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDVdi.FormattingEnabled = true;
            this.cboDVdi.Location = new System.Drawing.Point(406, 373);
            this.cboDVdi.Name = "cboDVdi";
            this.cboDVdi.Size = new System.Drawing.Size(533, 39);
            this.cboDVdi.TabIndex = 36;
            // 
            // cboDVden
            // 
            this.cboDVden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDVden.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDVden.FormattingEnabled = true;
            this.cboDVden.Location = new System.Drawing.Point(406, 302);
            this.cboDVden.Name = "cboDVden";
            this.cboDVden.Size = new System.Drawing.Size(533, 39);
            this.cboDVden.TabIndex = 35;
            // 
            // txtMaDC
            // 
            this.txtMaDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDC.Location = new System.Drawing.Point(406, 79);
            this.txtMaDC.Name = "txtMaDC";
            this.txtMaDC.Size = new System.Drawing.Size(533, 38);
            this.txtMaDC.TabIndex = 32;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1013, 522);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 67);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1013, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 67);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(1013, 304);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(153, 67);
            this.btnEdit.TabIndex = 29;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1013, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 67);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(1013, 79);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(153, 67);
            this.btnCreate.TabIndex = 27;
            this.btnCreate.Text = "Tạo mới";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 32);
            this.label6.TabIndex = 26;
            this.label6.Text = "ĐƠN VỊ ĐI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 32);
            this.label5.TabIndex = 25;
            this.label5.Text = "ĐƠN VỊ ĐẾN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "NGÀY ĐIỀU CHUYỂN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 32);
            this.label3.TabIndex = 23;
            this.label3.Text = "MÃ TÀI SẢN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "MÃ ĐIỀU CHUYỂN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 38);
            this.label1.TabIndex = 21;
            this.label1.Text = "THÔNG TIN ĐIỀU CHUYỂN";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTrang.Location = new System.Drawing.Point(406, 444);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(533, 38);
            this.txtTinhTrang.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(99, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 32);
            this.label7.TabIndex = 38;
            this.label7.Text = "TÌNH TRẠNG:";
            // 
            // cboMaTS
            // 
            this.cboMaTS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaTS.FormattingEnabled = true;
            this.cboMaTS.Location = new System.Drawing.Point(406, 155);
            this.cboMaTS.Name = "cboMaTS";
            this.cboMaTS.Size = new System.Drawing.Size(533, 39);
            this.cboMaTS.TabIndex = 40;
            // 
            // dtpNgayDC
            // 
            this.dtpNgayDC.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDC.Location = new System.Drawing.Point(406, 242);
            this.dtpNgayDC.Name = "dtpNgayDC";
            this.dtpNgayDC.Size = new System.Drawing.Size(533, 22);
            this.dtpNgayDC.TabIndex = 41;
            // 
            // dataGridDieuChuyen
            // 
            this.dataGridDieuChuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDieuChuyen.Location = new System.Drawing.Point(105, 532);
            this.dataGridDieuChuyen.Name = "dataGridDieuChuyen";
            this.dataGridDieuChuyen.RowTemplate.Height = 24;
            this.dataGridDieuChuyen.Size = new System.Drawing.Size(834, 257);
            this.dataGridDieuChuyen.TabIndex = 42;
            // 
            // FrmNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 825);
            this.Controls.Add(this.dataGridDieuChuyen);
            this.Controls.Add(this.dtpNgayDC);
            this.Controls.Add(this.cboMaTS);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboDVdi);
            this.Controls.Add(this.cboDVden);
            this.Controls.Add(this.txtMaDC);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmNhap";
            this.Text = "FrmNhap";
            this.Load += new System.EventHandler(this.FrmNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tEST1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEST1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDieuChuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboDVdi;
        private System.Windows.Forms.ComboBox cboDVden;
        private System.Windows.Forms.TextBox txtMaDC;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboMaTS;
        private System.Windows.Forms.DateTimePicker dtpNgayDC;
        private System.Windows.Forms.BindingSource tEST1DataSetBindingSource;
        private TEST1DataSet tEST1DataSet;
        private System.Windows.Forms.DataGridView dataGridDieuChuyen;
    }
}