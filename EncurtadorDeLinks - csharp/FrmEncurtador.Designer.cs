namespace EncurtadorDeLinks___csharp
{
    partial class FrmEncurtador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtLongUrl = new System.Windows.Forms.TextBox();
            this.btnShorten = new System.Windows.Forms.Button();
            this.txtShortUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEncurtarListaLinks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtLongUrl
            // 
            this.txtLongUrl.Location = new System.Drawing.Point(9, 54);
            this.txtLongUrl.Multiline = true;
            this.txtLongUrl.Name = "txtLongUrl";
            this.txtLongUrl.Size = new System.Drawing.Size(642, 33);
            this.txtLongUrl.TabIndex = 1;
            // 
            // btnShorten
            // 
            this.btnShorten.Location = new System.Drawing.Point(657, 33);
            this.btnShorten.Name = "btnShorten";
            this.btnShorten.Size = new System.Drawing.Size(118, 54);
            this.btnShorten.TabIndex = 2;
            this.btnShorten.Text = "Encurtar Link";
            this.btnShorten.UseVisualStyleBackColor = true;
            this.btnShorten.Click += new System.EventHandler(this.btnShorten_Click);
            // 
            // txtShortUrl
            // 
            this.txtShortUrl.Location = new System.Drawing.Point(201, 135);
            this.txtShortUrl.Multiline = true;
            this.txtShortUrl.Name = "txtShortUrl";
            this.txtShortUrl.Size = new System.Drawing.Size(378, 33);
            this.txtShortUrl.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "URL Encurtada";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtShortUrl);
            this.groupBox1.Controls.Add(this.txtLongUrl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnShorten);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 200);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Links Individuais";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEncurtarListaLinks);
            this.groupBox2.Location = new System.Drawing.Point(12, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(781, 200);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Links Multiplos";
            // 
            // btnEncurtarListaLinks
            // 
            this.btnEncurtarListaLinks.Location = new System.Drawing.Point(9, 83);
            this.btnEncurtarListaLinks.Name = "btnEncurtarListaLinks";
            this.btnEncurtarListaLinks.Size = new System.Drawing.Size(766, 54);
            this.btnEncurtarListaLinks.TabIndex = 5;
            this.btnEncurtarListaLinks.Text = "Encurtar Links";
            this.btnEncurtarListaLinks.UseVisualStyleBackColor = true;
            this.btnEncurtarListaLinks.Click += new System.EventHandler(this.btnEncurtarListaLinks_Click);
            // 
            // FrmEncurtador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 466);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEncurtador";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtShortUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShorten;
        private System.Windows.Forms.TextBox txtLongUrl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEncurtarListaLinks;
    }
}

