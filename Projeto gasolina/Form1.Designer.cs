namespace Projeto_gasolina
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
            this.txtbox_alcool = new System.Windows.Forms.TextBox();
            this.txtbox_gasolina = new System.Windows.Forms.TextBox();
            this.lbl_alcool = new System.Windows.Forms.Label();
            this.lbl_gasolina = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_abasteca = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txtbox_resultado = new System.Windows.Forms.TextBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_alcool
            // 
            this.txtbox_alcool.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_alcool.Location = new System.Drawing.Point(78, 204);
            this.txtbox_alcool.Name = "txtbox_alcool";
            this.txtbox_alcool.Size = new System.Drawing.Size(223, 26);
            this.txtbox_alcool.TabIndex = 0;
            // 
            // txtbox_gasolina
            // 
            this.txtbox_gasolina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_gasolina.Location = new System.Drawing.Point(78, 299);
            this.txtbox_gasolina.Name = "txtbox_gasolina";
            this.txtbox_gasolina.Size = new System.Drawing.Size(223, 26);
            this.txtbox_gasolina.TabIndex = 1;
            // 
            // lbl_alcool
            // 
            this.lbl_alcool.AutoSize = true;
            this.lbl_alcool.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alcool.Location = new System.Drawing.Point(100, 172);
            this.lbl_alcool.Name = "lbl_alcool";
            this.lbl_alcool.Size = new System.Drawing.Size(182, 20);
            this.lbl_alcool.TabIndex = 2;
            this.lbl_alcool.Text = "Digite o valor do Alcool";
            // 
            // lbl_gasolina
            // 
            this.lbl_gasolina.AutoSize = true;
            this.lbl_gasolina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gasolina.Location = new System.Drawing.Point(85, 264);
            this.lbl_gasolina.Name = "lbl_gasolina";
            this.lbl_gasolina.Size = new System.Drawing.Size(202, 20);
            this.lbl_gasolina.TabIndex = 3;
            this.lbl_gasolina.Text = "Digite o valor da Gasolina";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(89, 421);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(193, 53);
            this.btn_calcular.TabIndex = 4;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lbl_abasteca
            // 
            this.lbl_abasteca.AutoSize = true;
            this.lbl_abasteca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_abasteca.Location = new System.Drawing.Point(133, 524);
            this.lbl_abasteca.Name = "lbl_abasteca";
            this.lbl_abasteca.Size = new System.Drawing.Size(121, 20);
            this.lbl_abasteca.TabIndex = 5;
            this.lbl_abasteca.Text = "Abasteça com:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("MV Boli", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(3, 68);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(408, 20);
            this.lbl_titulo.TabIndex = 6;
            this.lbl_titulo.Text = "Descubra qual o melhor custo beneficio Alcool ou Gasolina";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbox_resultado
            // 
            this.txtbox_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_resultado.Location = new System.Drawing.Point(89, 555);
            this.txtbox_resultado.Name = "txtbox_resultado";
            this.txtbox_resultado.Size = new System.Drawing.Size(198, 26);
            this.txtbox_resultado.TabIndex = 7;
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(326, 555);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(77, 37);
            this.btn_sair.TabIndex = 8;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(415, 599);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.txtbox_resultado);
            this.Controls.Add(this.lbl_abasteca);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lbl_gasolina);
            this.Controls.Add(this.lbl_alcool);
            this.Controls.Add(this.txtbox_gasolina);
            this.Controls.Add(this.txtbox_alcool);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_alcool;
        private System.Windows.Forms.TextBox txtbox_gasolina;
        private System.Windows.Forms.Label lbl_alcool;
        private System.Windows.Forms.Label lbl_gasolina;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_abasteca;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox txtbox_resultado;
        private System.Windows.Forms.Button btn_sair;
    }
}

