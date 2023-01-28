
namespace NeedWorkApp
{
    partial class Databarang
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
            this.tablebarang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablebarang)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(914, 569);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Kembali";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tablebarang
            // 
            this.tablebarang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tablebarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablebarang.Location = new System.Drawing.Point(0, -2);
            this.tablebarang.Name = "tablebarang";
            this.tablebarang.RowHeadersWidth = 51;
            this.tablebarang.RowTemplate.Height = 29;
            this.tablebarang.Size = new System.Drawing.Size(1154, 565);
            this.tablebarang.TabIndex = 5;
            this.tablebarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablebarang_CellContentClick);
            // 
            // Databarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 639);
            this.Controls.Add(this.tablebarang);
            this.Controls.Add(this.button2);
            this.Name = "Databarang";
            this.Text = "Databarang";
            this.Load += new System.EventHandler(this.Databarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablebarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView tablebarang;
    }
}