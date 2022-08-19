
namespace SAU
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnContatos = new System.Windows.Forms.Button();
            this.btnChamados = new System.Windows.Forms.Button();
            this.pctPrincipal = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(27, 50);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(156, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Área Exclusiva de:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnContatos);
            this.panel1.Controls.Add(this.btnChamados);
            this.panel1.Location = new System.Drawing.Point(31, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 328);
            this.panel1.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(31, 163);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 32);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnContatos
            // 
            this.btnContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContatos.Location = new System.Drawing.Point(31, 93);
            this.btnContatos.Name = "btnContatos";
            this.btnContatos.Size = new System.Drawing.Size(98, 32);
            this.btnContatos.TabIndex = 1;
            this.btnContatos.Text = "Contatos";
            this.btnContatos.UseVisualStyleBackColor = true;
            this.btnContatos.Click += new System.EventHandler(this.btnContatos_Click);
            // 
            // btnChamados
            // 
            this.btnChamados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamados.Location = new System.Drawing.Point(31, 29);
            this.btnChamados.Name = "btnChamados";
            this.btnChamados.Size = new System.Drawing.Size(98, 32);
            this.btnChamados.TabIndex = 0;
            this.btnChamados.Text = "Chamados";
            this.btnChamados.UseVisualStyleBackColor = true;
            this.btnChamados.Click += new System.EventHandler(this.btnChamados_Click);
            // 
            // pctPrincipal
            // 
            this.pctPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("pctPrincipal.Image")));
            this.pctPrincipal.Location = new System.Drawing.Point(365, 109);
            this.pctPrincipal.Name = "pctPrincipal";
            this.pctPrincipal.Size = new System.Drawing.Size(298, 280);
            this.pctPrincipal.TabIndex = 2;
            this.pctPrincipal.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctPrincipal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUsuario);
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Atendimento ao Usuário";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnContatos;
        private System.Windows.Forms.Button btnChamados;
        private System.Windows.Forms.PictureBox pctPrincipal;
    }
}