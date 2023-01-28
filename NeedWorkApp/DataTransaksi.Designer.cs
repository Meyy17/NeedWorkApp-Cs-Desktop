
namespace NeedWorkApp
{
    partial class DataTransaksi
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
            this.tabletransaksi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabletransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(942, 564);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Kembali";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabletransaksi
            // 
            this.tabletransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabletransaksi.Location = new System.Drawing.Point(0, -1);
            this.tabletransaksi.Name = "tabletransaksi";
            this.tabletransaksi.RowHeadersWidth = 51;
            this.tabletransaksi.RowTemplate.Height = 29;
            this.tabletransaksi.Size = new System.Drawing.Size(1154, 559);
            this.tabletransaksi.TabIndex = 4;
            this.tabletransaksi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabletransaksi_CellContentClick);
            // 
            // DataTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 639);
            this.Controls.Add(this.tabletransaksi);
            this.Controls.Add(this.button2);
            this.Name = "DataTransaksi";
            this.Text = "DataTransaksi";
            ((System.ComponentModel.ISupportInitialize)(this.tabletransaksi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView tabletransaksi;
    }
}