namespace BankingSystem.Forms {
    partial class Transactions {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnPovratak = new System.Windows.Forms.Button();
            this.dgvTransakcije = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransakcije)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPovratak.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPovratak.Location = new System.Drawing.Point(69, 365);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(95, 38);
            this.btnPovratak.TabIndex = 0;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // dgvTransakcije
            // 
            this.dgvTransakcije.AllowUserToAddRows = false;
            this.dgvTransakcije.AllowUserToDeleteRows = false;
            this.dgvTransakcije.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTransakcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransakcije.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvTransakcije.Location = new System.Drawing.Point(143, 110);
            this.dgvTransakcije.Name = "dgvTransakcije";
            this.dgvTransakcije.ReadOnly = true;
            this.dgvTransakcije.Size = new System.Drawing.Size(394, 199);
            this.dgvTransakcije.TabIndex = 1;
            this.dgvTransakcije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransakcije_CellContentClick);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTransakcije);
            this.Controls.Add(this.btnPovratak);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Transactions";
            this.Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransakcije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.DataGridView dgvTransakcije;
    }
}