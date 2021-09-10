
namespace Tipo_de_triangulo
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
            this.lblLado1 = new System.Windows.Forms.Label();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.gbxLados = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.pbxAngulo = new System.Windows.Forms.PictureBox();
            this.pbxTriangulo = new System.Windows.Forms.PictureBox();
            this.gbxLados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAngulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTriangulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Location = new System.Drawing.Point(9, 31);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(43, 13);
            this.lblLado1.TabIndex = 0;
            this.lblLado1.Text = "Lado 1:";
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Location = new System.Drawing.Point(9, 59);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(43, 13);
            this.lblLado2.TabIndex = 1;
            this.lblLado2.Text = "Lado 2:";
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.Location = new System.Drawing.Point(9, 87);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(43, 13);
            this.lblLado3.TabIndex = 2;
            this.lblLado3.Text = "Lado 3:";
            // 
            // gbxLados
            // 
            this.gbxLados.Controls.Add(this.btnOK);
            this.gbxLados.Controls.Add(this.txtLado3);
            this.gbxLados.Controls.Add(this.txtLado1);
            this.gbxLados.Controls.Add(this.txtLado2);
            this.gbxLados.Controls.Add(this.lblLado1);
            this.gbxLados.Controls.Add(this.lblLado2);
            this.gbxLados.Controls.Add(this.lblLado3);
            this.gbxLados.Location = new System.Drawing.Point(12, 12);
            this.gbxLados.Name = "gbxLados";
            this.gbxLados.Size = new System.Drawing.Size(179, 147);
            this.gbxLados.TabIndex = 3;
            this.gbxLados.TabStop = false;
            this.gbxLados.Text = "Digite os comprimentos dos lados";
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(49, 118);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(58, 84);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(100, 20);
            this.txtLado3.TabIndex = 3;
            this.txtLado3.TextChanged += new System.EventHandler(this.txtLado3_TextChanged);
            this.txtLado3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLado3_KeyPress);
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(58, 28);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 20);
            this.txtLado1.TabIndex = 1;
            this.txtLado1.TextChanged += new System.EventHandler(this.txtLado1_TextChanged);
            this.txtLado1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLado1_KeyPress);
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(58, 56);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 20);
            this.txtLado2.TabIndex = 2;
            this.txtLado2.TextChanged += new System.EventHandler(this.txtLado2_TextChanged);
            this.txtLado2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLado2_KeyPress);
            // 
            // pbxAngulo
            // 
            this.pbxAngulo.Image = global::Tipo_de_triangulo.Properties.Resources.angulo;
            this.pbxAngulo.Location = new System.Drawing.Point(197, 12);
            this.pbxAngulo.Name = "pbxAngulo";
            this.pbxAngulo.Size = new System.Drawing.Size(171, 147);
            this.pbxAngulo.TabIndex = 4;
            this.pbxAngulo.TabStop = false;
            // 
            // pbxTriangulo
            // 
            this.pbxTriangulo.Image = global::Tipo_de_triangulo.Properties.Resources.triangulo;
            this.pbxTriangulo.Location = new System.Drawing.Point(12, 165);
            this.pbxTriangulo.Name = "pbxTriangulo";
            this.pbxTriangulo.Size = new System.Drawing.Size(356, 171);
            this.pbxTriangulo.TabIndex = 5;
            this.pbxTriangulo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 347);
            this.Controls.Add(this.pbxTriangulo);
            this.Controls.Add(this.pbxAngulo);
            this.Controls.Add(this.gbxLados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tipo de triângulo e de ângulo";
            this.gbxLados.ResumeLayout(false);
            this.gbxLados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAngulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTriangulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.GroupBox gbxLados;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.PictureBox pbxAngulo;
        private System.Windows.Forms.PictureBox pbxTriangulo;
    }
}

