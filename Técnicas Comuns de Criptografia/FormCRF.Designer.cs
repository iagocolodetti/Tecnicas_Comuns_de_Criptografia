﻿namespace Técnicas_Comuns_de_Criptografia
{
    partial class FormCRF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCRF));
            this.btCifrar = new System.Windows.Forms.Button();
            this.btDecifrar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.TLP1 = new System.Windows.Forms.TableLayoutPanel();
            this.RtbResultado = new System.Windows.Forms.RichTextBox();
            this.RtbTexto = new System.Windows.Forms.RichTextBox();
            this.LbTexto = new System.Windows.Forms.Label();
            this.LbResultado = new System.Windows.Forms.Label();
            this.BtInverter = new System.Windows.Forms.Button();
            this.TLB2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtLimparTexto = new System.Windows.Forms.Button();
            this.BtLimparResultado = new System.Windows.Forms.Button();
            this.TLP1.SuspendLayout();
            this.TLB2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCifrar
            // 
            this.btCifrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btCifrar.Location = new System.Drawing.Point(138, 6);
            this.btCifrar.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btCifrar.Name = "btCifrar";
            this.btCifrar.Size = new System.Drawing.Size(107, 27);
            this.btCifrar.TabIndex = 7;
            this.btCifrar.Text = "Cifrar";
            this.btCifrar.UseVisualStyleBackColor = true;
            this.btCifrar.Click += new System.EventHandler(this.BtCifrar_Click);
            // 
            // btDecifrar
            // 
            this.btDecifrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btDecifrar.Location = new System.Drawing.Point(275, 6);
            this.btDecifrar.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btDecifrar.Name = "btDecifrar";
            this.btDecifrar.Size = new System.Drawing.Size(107, 27);
            this.btDecifrar.TabIndex = 8;
            this.btDecifrar.Text = "Decifrar";
            this.btDecifrar.UseVisualStyleBackColor = true;
            this.btDecifrar.Click += new System.EventHandler(this.BtDecifrar_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btVoltar.Location = new System.Drawing.Point(206, 285);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(132, 27);
            this.btVoltar.TabIndex = 10;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.BtVoltar_Click);
            // 
            // TLP1
            // 
            this.TLP1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TLP1.ColumnCount = 3;
            this.TLP1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TLP1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP1.Controls.Add(this.RtbResultado, 2, 1);
            this.TLP1.Controls.Add(this.RtbTexto, 0, 1);
            this.TLP1.Controls.Add(this.LbTexto, 0, 0);
            this.TLP1.Controls.Add(this.LbResultado, 2, 0);
            this.TLP1.Controls.Add(this.BtInverter, 1, 1);
            this.TLP1.Location = new System.Drawing.Point(12, 12);
            this.TLP1.Name = "TLP1";
            this.TLP1.RowCount = 2;
            this.TLP1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TLP1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP1.Size = new System.Drawing.Size(521, 222);
            this.TLP1.TabIndex = 0;
            // 
            // RtbResultado
            // 
            this.RtbResultado.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.RtbResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtbResultado.Location = new System.Drawing.Point(293, 43);
            this.RtbResultado.Name = "RtbResultado";
            this.RtbResultado.ReadOnly = true;
            this.RtbResultado.Size = new System.Drawing.Size(225, 176);
            this.RtbResultado.TabIndex = 5;
            this.RtbResultado.Text = "";
            // 
            // RtbTexto
            // 
            this.RtbTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtbTexto.Location = new System.Drawing.Point(3, 43);
            this.RtbTexto.Name = "RtbTexto";
            this.RtbTexto.Size = new System.Drawing.Size(224, 176);
            this.RtbTexto.TabIndex = 3;
            this.RtbTexto.Text = "";
            // 
            // LbTexto
            // 
            this.LbTexto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbTexto.AutoSize = true;
            this.LbTexto.Location = new System.Drawing.Point(92, 11);
            this.LbTexto.Name = "LbTexto";
            this.LbTexto.Size = new System.Drawing.Size(45, 18);
            this.LbTexto.TabIndex = 1;
            this.LbTexto.Text = "Texto";
            // 
            // LbResultado
            // 
            this.LbResultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbResultado.AutoSize = true;
            this.LbResultado.Location = new System.Drawing.Point(368, 11);
            this.LbResultado.Name = "LbResultado";
            this.LbResultado.Size = new System.Drawing.Size(75, 18);
            this.LbResultado.TabIndex = 2;
            this.LbResultado.Text = "Resultado";
            // 
            // BtInverter
            // 
            this.BtInverter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtInverter.Location = new System.Drawing.Point(233, 97);
            this.BtInverter.Name = "BtInverter";
            this.BtInverter.Size = new System.Drawing.Size(54, 68);
            this.BtInverter.TabIndex = 4;
            this.BtInverter.Text = "<<<<\r\n<<>>\r\n>>>>";
            this.BtInverter.UseVisualStyleBackColor = true;
            this.BtInverter.Click += new System.EventHandler(this.BtInverter_Click);
            // 
            // TLB2
            // 
            this.TLB2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TLB2.ColumnCount = 4;
            this.TLB2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLB2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLB2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLB2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLB2.Controls.Add(this.BtLimparTexto, 0, 0);
            this.TLB2.Controls.Add(this.btCifrar, 1, 0);
            this.TLB2.Controls.Add(this.btDecifrar, 2, 0);
            this.TLB2.Controls.Add(this.BtLimparResultado, 3, 0);
            this.TLB2.Location = new System.Drawing.Point(12, 237);
            this.TLB2.Name = "TLB2";
            this.TLB2.RowCount = 1;
            this.TLB2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLB2.Size = new System.Drawing.Size(521, 40);
            this.TLB2.TabIndex = 9;
            // 
            // BtLimparTexto
            // 
            this.BtLimparTexto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtLimparTexto.Location = new System.Drawing.Point(11, 6);
            this.BtLimparTexto.Name = "BtLimparTexto";
            this.BtLimparTexto.Size = new System.Drawing.Size(107, 27);
            this.BtLimparTexto.TabIndex = 6;
            this.BtLimparTexto.Text = "Limpar";
            this.BtLimparTexto.UseVisualStyleBackColor = true;
            this.BtLimparTexto.Click += new System.EventHandler(this.BtLimparTexto_Click);
            // 
            // BtLimparResultado
            // 
            this.BtLimparResultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtLimparResultado.Location = new System.Drawing.Point(402, 6);
            this.BtLimparResultado.Name = "BtLimparResultado";
            this.BtLimparResultado.Size = new System.Drawing.Size(107, 27);
            this.BtLimparResultado.TabIndex = 9;
            this.BtLimparResultado.Text = "Limpar";
            this.BtLimparResultado.UseVisualStyleBackColor = true;
            this.BtLimparResultado.Click += new System.EventHandler(this.BtLimparResultado_Click);
            // 
            // FormCRF
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(545, 326);
            this.Controls.Add(this.TLB2);
            this.Controls.Add(this.TLP1);
            this.Controls.Add(this.btVoltar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(561, 365);
            this.Name = "FormCRF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cifra Rail Fence (Zig Zag)";
            this.TLP1.ResumeLayout(false);
            this.TLP1.PerformLayout();
            this.TLB2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btCifrar;
        private System.Windows.Forms.Button btDecifrar;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.TableLayoutPanel TLP1;
        private System.Windows.Forms.RichTextBox RtbResultado;
        private System.Windows.Forms.RichTextBox RtbTexto;
        private System.Windows.Forms.Label LbTexto;
        private System.Windows.Forms.Label LbResultado;
        private System.Windows.Forms.Button BtInverter;
        private System.Windows.Forms.TableLayoutPanel TLB2;
        private System.Windows.Forms.Button BtLimparTexto;
        private System.Windows.Forms.Button BtLimparResultado;
    }
}

