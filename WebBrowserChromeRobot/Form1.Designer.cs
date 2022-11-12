namespace WebBrowserChromeRobot
{
    partial class Form1
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
            this.btn_dolar = new System.Windows.Forms.Button();
            this.btn_bitcoin = new System.Windows.Forms.Button();
            this.btn_euro = new System.Windows.Forms.Button();
            this.btn_compra = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_dolar
            // 
            this.btn_dolar.Location = new System.Drawing.Point(12, 12);
            this.btn_dolar.Name = "btn_dolar";
            this.btn_dolar.Size = new System.Drawing.Size(75, 23);
            this.btn_dolar.TabIndex = 0;
            this.btn_dolar.Text = "Dolar";
            this.btn_dolar.UseVisualStyleBackColor = true;
            this.btn_dolar.Click += new System.EventHandler(this.btn_dolar_Click);
            // 
            // btn_bitcoin
            // 
            this.btn_bitcoin.Location = new System.Drawing.Point(105, 12);
            this.btn_bitcoin.Name = "btn_bitcoin";
            this.btn_bitcoin.Size = new System.Drawing.Size(75, 23);
            this.btn_bitcoin.TabIndex = 1;
            this.btn_bitcoin.Text = "Bitcoin";
            this.btn_bitcoin.UseVisualStyleBackColor = true;
            this.btn_bitcoin.Click += new System.EventHandler(this.btn_bitcoin_Click);
            // 
            // btn_euro
            // 
            this.btn_euro.Location = new System.Drawing.Point(199, 12);
            this.btn_euro.Name = "btn_euro";
            this.btn_euro.Size = new System.Drawing.Size(75, 23);
            this.btn_euro.TabIndex = 2;
            this.btn_euro.Text = "Euro";
            this.btn_euro.UseVisualStyleBackColor = true;
            this.btn_euro.Click += new System.EventHandler(this.btn_euro_Click);
            // 
            // btn_compra
            // 
            this.btn_compra.Location = new System.Drawing.Point(486, 12);
            this.btn_compra.Name = "btn_compra";
            this.btn_compra.Size = new System.Drawing.Size(75, 23);
            this.btn_compra.TabIndex = 3;
            this.btn_compra.Text = "Compra";
            this.btn_compra.UseVisualStyleBackColor = true;
            this.btn_compra.Click += new System.EventHandler(this.btn_compra_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Location = new System.Drawing.Point(-4, 51);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(581, 237);
            this.panel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 287);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btn_compra);
            this.Controls.Add(this.btn_euro);
            this.Controls.Add(this.btn_bitcoin);
            this.Controls.Add(this.btn_dolar);
            this.Name = "Form1";
            this.Text = "Painel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_dolar;
        private System.Windows.Forms.Button btn_bitcoin;
        private System.Windows.Forms.Button btn_euro;
        private System.Windows.Forms.Button btn_compra;
        private System.Windows.Forms.Panel panel;
    }
}

