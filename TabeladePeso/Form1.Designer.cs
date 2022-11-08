namespace TabeladePeso
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txb_peso = new System.Windows.Forms.TextBox();
            this.txb_altura = new System.Windows.Forms.TextBox();
            this.btm_calcular = new System.Windows.Forms.Button();
            this.txb_resultado = new System.Windows.Forms.TextBox();
            this.lbl_imc = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(114, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(244, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calcule seu IMC";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(116, 152);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(58, 24);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(116, 188);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(63, 24);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura:";
            // 
            // txb_peso
            // 
            this.txb_peso.Location = new System.Drawing.Point(226, 157);
            this.txb_peso.Name = "txb_peso";
            this.txb_peso.Size = new System.Drawing.Size(100, 20);
            this.txb_peso.TabIndex = 3;
            // 
            // txb_altura
            // 
            this.txb_altura.Location = new System.Drawing.Point(226, 193);
            this.txb_altura.Name = "txb_altura";
            this.txb_altura.Size = new System.Drawing.Size(100, 20);
            this.txb_altura.TabIndex = 4;
            // 
            // btm_calcular
            // 
            this.btm_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_calcular.Location = new System.Drawing.Point(133, 266);
            this.btm_calcular.Name = "btm_calcular";
            this.btm_calcular.Size = new System.Drawing.Size(161, 51);
            this.btm_calcular.TabIndex = 5;
            this.btm_calcular.Text = "CALCULAR";
            this.btm_calcular.UseVisualStyleBackColor = true;
            this.btm_calcular.Click += new System.EventHandler(this.btm_calcular_Click);
            // 
            // txb_resultado
            // 
            this.txb_resultado.Location = new System.Drawing.Point(226, 348);
            this.txb_resultado.Name = "txb_resultado";
            this.txb_resultado.ReadOnly = true;
            this.txb_resultado.Size = new System.Drawing.Size(100, 20);
            this.txb_resultado.TabIndex = 6;
            // 
            // lbl_imc
            // 
            this.lbl_imc.AutoSize = true;
            this.lbl_imc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_imc.Location = new System.Drawing.Point(116, 348);
            this.lbl_imc.Name = "lbl_imc";
            this.lbl_imc.Size = new System.Drawing.Size(43, 24);
            this.lbl_imc.TabIndex = 7;
            this.lbl_imc.Text = "IMC";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(179, 406);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(0, 13);
            this.lbl_resultado.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 450);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_imc);
            this.Controls.Add(this.txb_resultado);
            this.Controls.Add(this.btm_calcular);
            this.Controls.Add(this.txb_altura);
            this.Controls.Add(this.txb_peso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txb_peso;
        private System.Windows.Forms.TextBox txb_altura;
        private System.Windows.Forms.Button btm_calcular;
        private System.Windows.Forms.TextBox txb_resultado;
        private System.Windows.Forms.Label lbl_imc;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

