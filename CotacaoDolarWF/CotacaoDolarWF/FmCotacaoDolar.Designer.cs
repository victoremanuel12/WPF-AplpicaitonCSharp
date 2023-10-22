namespace CotacaoDolarWF
{
    partial class FmCotacaoDolar
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
            this.Title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.TitleBuy = new System.Windows.Forms.Label();
            this.TitleSell = new System.Windows.Forms.Label();
            this.TitleVariation = new System.Windows.Forms.Label();
            this.lblBuy = new System.Windows.Forms.Label();
            this.lblSell = new System.Windows.Forms.Label();
            this.lblVariation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title.Location = new System.Drawing.Point(18, 11);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(431, 86);
            this.Title.TabIndex = 0;
            this.Title.Text = "Dólar";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(306, 566);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(143, 40);
            this.Search.TabIndex = 2;
            this.Search.Text = "Pesquisar";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // TitleBuy
            // 
            this.TitleBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBuy.Location = new System.Drawing.Point(6, 138);
            this.TitleBuy.Name = "TitleBuy";
            this.TitleBuy.Size = new System.Drawing.Size(139, 38);
            this.TitleBuy.TabIndex = 3;
            this.TitleBuy.Text = "Compra:";
            this.TitleBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleSell
            // 
            this.TitleSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleSell.Location = new System.Drawing.Point(6, 241);
            this.TitleSell.Name = "TitleSell";
            this.TitleSell.Size = new System.Drawing.Size(139, 38);
            this.TitleSell.TabIndex = 4;
            this.TitleSell.Text = "Venda:";
            this.TitleSell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleVariation
            // 
            this.TitleVariation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleVariation.Location = new System.Drawing.Point(6, 358);
            this.TitleVariation.Name = "TitleVariation";
            this.TitleVariation.Size = new System.Drawing.Size(139, 38);
            this.TitleVariation.TabIndex = 5;
            this.TitleVariation.Text = "Variação:";
            this.TitleVariation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBuy
            // 
            this.lblBuy.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBuy.Location = new System.Drawing.Point(151, 133);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(298, 43);
            this.lblBuy.TabIndex = 6;
            this.lblBuy.Text = "0,0";
            this.lblBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSell
            // 
            this.lblSell.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSell.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSell.Location = new System.Drawing.Point(151, 241);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(298, 43);
            this.lblSell.TabIndex = 7;
            this.lblSell.Text = "0,0";
            this.lblSell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVariation
            // 
            this.lblVariation.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblVariation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVariation.Location = new System.Drawing.Point(151, 354);
            this.lblVariation.Name = "lblVariation";
            this.lblVariation.Size = new System.Drawing.Size(298, 43);
            this.lblVariation.TabIndex = 8;
            this.lblVariation.Text = "0,0";
            this.lblVariation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FmCotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 636);
            this.Controls.Add(this.lblVariation);
            this.Controls.Add(this.lblSell);
            this.Controls.Add(this.lblBuy);
            this.Controls.Add(this.TitleVariation);
            this.Controls.Add(this.TitleSell);
            this.Controls.Add(this.TitleBuy);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FmCotacaoDolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotação Dólar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label TitleBuy;
        private System.Windows.Forms.Label TitleSell;
        private System.Windows.Forms.Label TitleVariation;
        private System.Windows.Forms.Label lblBuy;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.Label lblVariation;
    }
}

