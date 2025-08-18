namespace BankingSystem.Forms {
    partial class MainPage {
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
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblUplata = new System.Windows.Forms.Label();
            this.lblIsplata = new System.Windows.Forms.Label();
            this.lblTransferId = new System.Windows.Forms.Label();
            this.txtBoxUplati = new System.Windows.Forms.TextBox();
            this.txtBoxIsplati = new System.Windows.Forms.TextBox();
            this.lblAmountTransfer = new System.Windows.Forms.Label();
            this.txtBoxAmount = new System.Windows.Forms.TextBox();
            this.txtBoxAccount_idTransfer = new System.Windows.Forms.TextBox();
            this.btnUplata = new System.Windows.Forms.Button();
            this.btnIsplata = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lblVasAccId = new System.Windows.Forms.Label();
            this.lblPrikazIda = new System.Windows.Forms.Label();
            this.btnPrikazTransakcija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(44, 35);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(46, 13);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "Balance";
            // 
            // lblUplata
            // 
            this.lblUplata.AutoSize = true;
            this.lblUplata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUplata.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUplata.Location = new System.Drawing.Point(44, 248);
            this.lblUplata.Name = "lblUplata";
            this.lblUplata.Size = new System.Drawing.Size(50, 17);
            this.lblUplata.TabIndex = 1;
            this.lblUplata.Text = "Uplati";
            // 
            // lblIsplata
            // 
            this.lblIsplata.AutoSize = true;
            this.lblIsplata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIsplata.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIsplata.Location = new System.Drawing.Point(242, 248);
            this.lblIsplata.Name = "lblIsplata";
            this.lblIsplata.Size = new System.Drawing.Size(51, 17);
            this.lblIsplata.TabIndex = 2;
            this.lblIsplata.Text = "Isplati";
            this.lblIsplata.Click += new System.EventHandler(this.lblIsplata_Click);
            // 
            // lblTransferId
            // 
            this.lblTransferId.AutoSize = true;
            this.lblTransferId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTransferId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTransferId.Location = new System.Drawing.Point(357, 248);
            this.lblTransferId.Name = "lblTransferId";
            this.lblTransferId.Size = new System.Drawing.Size(88, 17);
            this.lblTransferId.TabIndex = 3;
            this.lblTransferId.Text = "Account_id";
            // 
            // txtBoxUplati
            // 
            this.txtBoxUplati.Location = new System.Drawing.Point(47, 276);
            this.txtBoxUplati.Name = "txtBoxUplati";
            this.txtBoxUplati.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUplati.TabIndex = 4;
            // 
            // txtBoxIsplati
            // 
            this.txtBoxIsplati.Location = new System.Drawing.Point(235, 276);
            this.txtBoxIsplati.Name = "txtBoxIsplati";
            this.txtBoxIsplati.Size = new System.Drawing.Size(100, 20);
            this.txtBoxIsplati.TabIndex = 5;
            // 
            // lblAmountTransfer
            // 
            this.lblAmountTransfer.AutoSize = true;
            this.lblAmountTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAmountTransfer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAmountTransfer.Location = new System.Drawing.Point(357, 277);
            this.lblAmountTransfer.Name = "lblAmountTransfer";
            this.lblAmountTransfer.Size = new System.Drawing.Size(62, 17);
            this.lblAmountTransfer.TabIndex = 6;
            this.lblAmountTransfer.Text = "Amount";
            // 
            // txtBoxAmount
            // 
            this.txtBoxAmount.Location = new System.Drawing.Point(451, 276);
            this.txtBoxAmount.Name = "txtBoxAmount";
            this.txtBoxAmount.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAmount.TabIndex = 7;
            // 
            // txtBoxAccount_idTransfer
            // 
            this.txtBoxAccount_idTransfer.Location = new System.Drawing.Point(451, 245);
            this.txtBoxAccount_idTransfer.Name = "txtBoxAccount_idTransfer";
            this.txtBoxAccount_idTransfer.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAccount_idTransfer.TabIndex = 8;
            // 
            // btnUplata
            // 
            this.btnUplata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUplata.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUplata.Location = new System.Drawing.Point(47, 329);
            this.btnUplata.Name = "btnUplata";
            this.btnUplata.Size = new System.Drawing.Size(100, 36);
            this.btnUplata.TabIndex = 9;
            this.btnUplata.Text = "Uplati";
            this.btnUplata.UseVisualStyleBackColor = true;
            this.btnUplata.Click += new System.EventHandler(this.btnUplata_Click);
            // 
            // btnIsplata
            // 
            this.btnIsplata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIsplata.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIsplata.Location = new System.Drawing.Point(235, 329);
            this.btnIsplata.Name = "btnIsplata";
            this.btnIsplata.Size = new System.Drawing.Size(86, 36);
            this.btnIsplata.TabIndex = 10;
            this.btnIsplata.Text = "Isplati";
            this.btnIsplata.UseVisualStyleBackColor = true;
            this.btnIsplata.Click += new System.EventHandler(this.btnIsplata_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeposit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeposit.Location = new System.Drawing.Point(451, 329);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(87, 36);
            this.btnDeposit.TabIndex = 11;
            this.btnDeposit.Text = "Transfer";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lblVasAccId
            // 
            this.lblVasAccId.AutoSize = true;
            this.lblVasAccId.Location = new System.Drawing.Point(44, 77);
            this.lblVasAccId.Name = "lblVasAccId";
            this.lblVasAccId.Size = new System.Drawing.Size(56, 13);
            this.lblVasAccId.TabIndex = 12;
            this.lblVasAccId.Text = "AccountId";
            // 
            // lblPrikazIda
            // 
            this.lblPrikazIda.AutoSize = true;
            this.lblPrikazIda.Location = new System.Drawing.Point(24, 77);
            this.lblPrikazIda.Name = "lblPrikazIda";
            this.lblPrikazIda.Size = new System.Drawing.Size(0, 13);
            this.lblPrikazIda.TabIndex = 13;
            // 
            // btnPrikazTransakcija
            // 
            this.btnPrikazTransakcija.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrikazTransakcija.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrikazTransakcija.Location = new System.Drawing.Point(592, 46);
            this.btnPrikazTransakcija.Name = "btnPrikazTransakcija";
            this.btnPrikazTransakcija.Size = new System.Drawing.Size(120, 33);
            this.btnPrikazTransakcija.TabIndex = 14;
            this.btnPrikazTransakcija.Text = "PrikazTransakcija";
            this.btnPrikazTransakcija.UseVisualStyleBackColor = true;
            this.btnPrikazTransakcija.Click += new System.EventHandler(this.btnPrikazTransakcija_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrikazTransakcija);
            this.Controls.Add(this.lblPrikazIda);
            this.Controls.Add(this.lblVasAccId);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnIsplata);
            this.Controls.Add(this.btnUplata);
            this.Controls.Add(this.txtBoxAccount_idTransfer);
            this.Controls.Add(this.txtBoxAmount);
            this.Controls.Add(this.lblAmountTransfer);
            this.Controls.Add(this.txtBoxIsplati);
            this.Controls.Add(this.txtBoxUplati);
            this.Controls.Add(this.lblTransferId);
            this.Controls.Add(this.lblIsplata);
            this.Controls.Add(this.lblUplata);
            this.Controls.Add(this.lblBalance);
            this.Name = "MainPage";
            this.Text = "Racun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblUplata;
        private System.Windows.Forms.Label lblIsplata;
        private System.Windows.Forms.Label lblTransferId;
        private System.Windows.Forms.TextBox txtBoxUplati;
        private System.Windows.Forms.TextBox txtBoxIsplati;
        private System.Windows.Forms.Label lblAmountTransfer;
        private System.Windows.Forms.TextBox txtBoxAmount;
        private System.Windows.Forms.TextBox txtBoxAccount_idTransfer;
        private System.Windows.Forms.Button btnUplata;
        private System.Windows.Forms.Button btnIsplata;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label lblVasAccId;
        private System.Windows.Forms.Label lblPrikazIda;
        private System.Windows.Forms.Button btnPrikazTransakcija;
    }
}