namespace Rechnung_Rechner
{
    partial class rechnungRechner
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.preisTxtBox = new System.Windows.Forms.TextBox();
            this.preisListeTxtBox = new System.Windows.Forms.TextBox();
            this.preisAddierenBtn = new System.Windows.Forms.Button();
            this.outputLbl = new System.Windows.Forms.Label();
            this.multiplikatorTxtBox = new System.Windows.Forms.TextBox();
            this.errechnenBtn = new System.Windows.Forms.Button();
            this.multiplikaterLbl = new System.Windows.Forms.Label();
            this.preisLbl = new System.Windows.Forms.Label();
            this.totalPreisTxtBox = new System.Windows.Forms.TextBox();
            this.steuerRateTxtBox = new System.Windows.Forms.TextBox();
            this.steuerRateLbl = new System.Windows.Forms.Label();
            this.percentageLbl = new System.Windows.Forms.Label();
            this.saveToFileBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // preisTxtBox
            // 
            this.preisTxtBox.Location = new System.Drawing.Point(124, 14);
            this.preisTxtBox.Name = "preisTxtBox";
            this.preisTxtBox.Size = new System.Drawing.Size(174, 20);
            this.preisTxtBox.TabIndex = 0;
            this.preisTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.preisTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.preisTxtBox_KeyDown);
            // 
            // preisListeTxtBox
            // 
            this.preisListeTxtBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.preisListeTxtBox.Location = new System.Drawing.Point(568, 12);
            this.preisListeTxtBox.Multiline = true;
            this.preisListeTxtBox.Name = "preisListeTxtBox";
            this.preisListeTxtBox.ReadOnly = true;
            this.preisListeTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.preisListeTxtBox.Size = new System.Drawing.Size(201, 528);
            this.preisListeTxtBox.TabIndex = 1;
            this.preisListeTxtBox.TabStop = false;
            this.preisListeTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // preisAddierenBtn
            // 
            this.preisAddierenBtn.Location = new System.Drawing.Point(304, 39);
            this.preisAddierenBtn.Name = "preisAddierenBtn";
            this.preisAddierenBtn.Size = new System.Drawing.Size(97, 23);
            this.preisAddierenBtn.TabIndex = 2;
            this.preisAddierenBtn.Text = "addieren Preis";
            this.preisAddierenBtn.UseVisualStyleBackColor = true;
            this.preisAddierenBtn.Click += new System.EventHandler(this.preisAddierenBtn_Click);
            // 
            // outputLbl
            // 
            this.outputLbl.BackColor = System.Drawing.SystemColors.Control;
            this.outputLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLbl.Location = new System.Drawing.Point(9, 384);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(553, 182);
            this.outputLbl.TabIndex = 3;
            // 
            // multiplikatorTxtBox
            // 
            this.multiplikatorTxtBox.Location = new System.Drawing.Point(246, 41);
            this.multiplikatorTxtBox.Name = "multiplikatorTxtBox";
            this.multiplikatorTxtBox.Size = new System.Drawing.Size(52, 20);
            this.multiplikatorTxtBox.TabIndex = 1;
            this.multiplikatorTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.multiplikatorTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.multiplikatorTxtBox_KeyDown);
            // 
            // errechnenBtn
            // 
            this.errechnenBtn.Location = new System.Drawing.Point(304, 358);
            this.errechnenBtn.Name = "errechnenBtn";
            this.errechnenBtn.Size = new System.Drawing.Size(97, 23);
            this.errechnenBtn.TabIndex = 4;
            this.errechnenBtn.Text = "errechnen";
            this.errechnenBtn.UseVisualStyleBackColor = true;
            this.errechnenBtn.Click += new System.EventHandler(this.errechnenBtn_Click);
            // 
            // multiplikaterLbl
            // 
            this.multiplikaterLbl.AutoSize = true;
            this.multiplikaterLbl.Location = new System.Drawing.Point(177, 44);
            this.multiplikaterLbl.Name = "multiplikaterLbl";
            this.multiplikaterLbl.Size = new System.Drawing.Size(50, 13);
            this.multiplikaterLbl.TabIndex = 6;
            this.multiplikaterLbl.Text = "Quantität";
            // 
            // preisLbl
            // 
            this.preisLbl.AutoSize = true;
            this.preisLbl.Location = new System.Drawing.Point(88, 17);
            this.preisLbl.Name = "preisLbl";
            this.preisLbl.Size = new System.Drawing.Size(30, 13);
            this.preisLbl.TabIndex = 7;
            this.preisLbl.Text = "Preis";
            this.preisLbl.Click += new System.EventHandler(this.preisLbl_Click);
            // 
            // totalPreisTxtBox
            // 
            this.totalPreisTxtBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalPreisTxtBox.Location = new System.Drawing.Point(568, 546);
            this.totalPreisTxtBox.Name = "totalPreisTxtBox";
            this.totalPreisTxtBox.ReadOnly = true;
            this.totalPreisTxtBox.Size = new System.Drawing.Size(201, 20);
            this.totalPreisTxtBox.TabIndex = 8;
            this.totalPreisTxtBox.TabStop = false;
            this.totalPreisTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // steuerRateTxtBox
            // 
            this.steuerRateTxtBox.Location = new System.Drawing.Point(304, 332);
            this.steuerRateTxtBox.Name = "steuerRateTxtBox";
            this.steuerRateTxtBox.Size = new System.Drawing.Size(97, 20);
            this.steuerRateTxtBox.TabIndex = 3;
            this.steuerRateTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.steuerRateTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.steuerRateTxtBox_KeyDown);
            // 
            // steuerRateLbl
            // 
            this.steuerRateLbl.AutoSize = true;
            this.steuerRateLbl.Location = new System.Drawing.Point(234, 335);
            this.steuerRateLbl.Name = "steuerRateLbl";
            this.steuerRateLbl.Size = new System.Drawing.Size(64, 13);
            this.steuerRateLbl.TabIndex = 10;
            this.steuerRateLbl.Text = "Steuer Rate";
            // 
            // percentageLbl
            // 
            this.percentageLbl.AutoSize = true;
            this.percentageLbl.BackColor = System.Drawing.Color.Transparent;
            this.percentageLbl.Location = new System.Drawing.Point(398, 335);
            this.percentageLbl.Name = "percentageLbl";
            this.percentageLbl.Size = new System.Drawing.Size(15, 13);
            this.percentageLbl.TabIndex = 11;
            this.percentageLbl.Text = "%";
            // 
            // saveToFileBtn
            // 
            this.saveToFileBtn.Location = new System.Drawing.Point(487, 358);
            this.saveToFileBtn.Name = "saveToFileBtn";
            this.saveToFileBtn.Size = new System.Drawing.Size(75, 23);
            this.saveToFileBtn.TabIndex = 12;
            this.saveToFileBtn.Text = "Speichern";
            this.saveToFileBtn.UseVisualStyleBackColor = true;
            this.saveToFileBtn.Click += new System.EventHandler(this.saveToFileBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(487, 330);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 13;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // rechnungRechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 578);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.saveToFileBtn);
            this.Controls.Add(this.percentageLbl);
            this.Controls.Add(this.steuerRateLbl);
            this.Controls.Add(this.steuerRateTxtBox);
            this.Controls.Add(this.totalPreisTxtBox);
            this.Controls.Add(this.preisLbl);
            this.Controls.Add(this.multiplikaterLbl);
            this.Controls.Add(this.errechnenBtn);
            this.Controls.Add(this.multiplikatorTxtBox);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.preisAddierenBtn);
            this.Controls.Add(this.preisListeTxtBox);
            this.Controls.Add(this.preisTxtBox);
            this.Name = "rechnungRechner";
            this.Text = "Rechnung Rechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox preisTxtBox;
        private System.Windows.Forms.TextBox preisListeTxtBox;
        private System.Windows.Forms.Button preisAddierenBtn;
        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.TextBox multiplikatorTxtBox;
        private System.Windows.Forms.Button errechnenBtn;
        private System.Windows.Forms.Label multiplikaterLbl;
        private System.Windows.Forms.Label preisLbl;
        private System.Windows.Forms.TextBox totalPreisTxtBox;
        private System.Windows.Forms.TextBox steuerRateTxtBox;
        private System.Windows.Forms.Label steuerRateLbl;
        private System.Windows.Forms.Label percentageLbl;
        private System.Windows.Forms.Button saveToFileBtn;
        private System.Windows.Forms.Button loadBtn;
    }
}

