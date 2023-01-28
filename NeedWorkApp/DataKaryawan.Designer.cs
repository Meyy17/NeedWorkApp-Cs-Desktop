
namespace NeedWorkApp
{
    partial class DataKaryawan
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
            this.button2 = new System.Windows.Forms.Button();
            this.tablekaryawan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablekaryawan)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(915, 562);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kembali";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tablekaryawan
            // 
            this.tablekaryawan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tablekaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablekaryawan.GridColor = System.Drawing.SystemColors.Control;
            this.tablekaryawan.Location = new System.Drawing.Point(-3, 0);
            this.tablekaryawan.Name = "tablekaryawan";
            this.tablekaryawan.RowHeadersWidth = 51;
            this.tablekaryawan.RowTemplate.Height = 29;
            this.tablekaryawan.Size = new System.Drawing.Size(1158, 556);
            this.tablekaryawan.TabIndex = 3;
            // 
            // DataKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 639);
            this.Controls.Add(this.tablekaryawan);
            this.Controls.Add(this.button2);
            this.Name = "DataKaryawan";
            this.Text = "DataKaryawan";
            this.Load += new System.EventHandler(this.DataKaryawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablekaryawan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView tablekaryawan;
    }
}