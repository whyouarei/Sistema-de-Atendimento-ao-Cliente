
namespace SAU
{
    partial class fmrLogin
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
            this.lblEmailUsuario = new System.Windows.Forms.Label();
            this.lblmsgEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblSenhaAtual = new System.Windows.Forms.Label();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.lblRepetirSenha = new System.Windows.Forms.Label();
            this.txtEmailUsuario = new System.Windows.Forms.TextBox();
            this.mskSenha = new System.Windows.Forms.MaskedTextBox();
            this.mskSenhaAtual = new System.Windows.Forms.MaskedTextBox();
            this.mskNovaSenha = new System.Windows.Forms.MaskedTextBox();
            this.mskRepetirSenha = new System.Windows.Forms.MaskedTextBox();
            this.pnlMudarSenha = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlMudarSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmailUsuario
            // 
            this.lblEmailUsuario.AutoSize = true;
            this.lblEmailUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailUsuario.Location = new System.Drawing.Point(81, 35);
            this.lblEmailUsuario.Name = "lblEmailUsuario";
            this.lblEmailUsuario.Size = new System.Drawing.Size(53, 20);
            this.lblEmailUsuario.TabIndex = 0;
            this.lblEmailUsuario.Text = "Email";
            // 
            // lblmsgEmail
            // 
            this.lblmsgEmail.AutoSize = true;
            this.lblmsgEmail.Location = new System.Drawing.Point(82, 87);
            this.lblmsgEmail.Name = "lblmsgEmail";
            this.lblmsgEmail.Size = new System.Drawing.Size(151, 13);
            this.lblmsgEmail.TabIndex = 1;
            this.lblmsgEmail.Text = "O email será o usuário de login";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSenha.Location = new System.Drawing.Point(81, 133);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(61, 20);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha";
            // 
            // lblSenhaAtual
            // 
            this.lblSenhaAtual.AutoSize = true;
            this.lblSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaAtual.Location = new System.Drawing.Point(113, 36);
            this.lblSenhaAtual.Name = "lblSenhaAtual";
            this.lblSenhaAtual.Size = new System.Drawing.Size(108, 20);
            this.lblSenhaAtual.TabIndex = 3;
            this.lblSenhaAtual.Text = "Senha Atual";
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaSenha.Location = new System.Drawing.Point(113, 93);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(106, 20);
            this.lblNovaSenha.TabIndex = 4;
            this.lblNovaSenha.Text = "Nova Senha";
            this.lblNovaSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRepetirSenha
            // 
            this.lblRepetirSenha.AutoEllipsis = true;
            this.lblRepetirSenha.AutoSize = true;
            this.lblRepetirSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetirSenha.Location = new System.Drawing.Point(113, 157);
            this.lblRepetirSenha.Name = "lblRepetirSenha";
            this.lblRepetirSenha.Size = new System.Drawing.Size(125, 20);
            this.lblRepetirSenha.TabIndex = 5;
            this.lblRepetirSenha.Text = "Repetir Senha";
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailUsuario.Location = new System.Drawing.Point(85, 58);
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(325, 26);
            this.txtEmailUsuario.TabIndex = 0;
            // 
            // mskSenha
            // 
            this.mskSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskSenha.Location = new System.Drawing.Point(85, 156);
            this.mskSenha.Name = "mskSenha";
            this.mskSenha.PasswordChar = '*';
            this.mskSenha.Size = new System.Drawing.Size(325, 26);
            this.mskSenha.TabIndex = 1;
            // 
            // mskSenhaAtual
            // 
            this.mskSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskSenhaAtual.Location = new System.Drawing.Point(117, 59);
            this.mskSenhaAtual.Name = "mskSenhaAtual";
            this.mskSenhaAtual.PasswordChar = '*';
            this.mskSenhaAtual.Size = new System.Drawing.Size(257, 26);
            this.mskSenhaAtual.TabIndex = 4;
            // 
            // mskNovaSenha
            // 
            this.mskNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNovaSenha.Location = new System.Drawing.Point(117, 116);
            this.mskNovaSenha.Name = "mskNovaSenha";
            this.mskNovaSenha.PasswordChar = '*';
            this.mskNovaSenha.Size = new System.Drawing.Size(257, 26);
            this.mskNovaSenha.TabIndex = 5;
            // 
            // mskRepetirSenha
            // 
            this.mskRepetirSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskRepetirSenha.Location = new System.Drawing.Point(117, 180);
            this.mskRepetirSenha.Name = "mskRepetirSenha";
            this.mskRepetirSenha.PasswordChar = '*';
            this.mskRepetirSenha.Size = new System.Drawing.Size(257, 26);
            this.mskRepetirSenha.TabIndex = 6;
            // 
            // pnlMudarSenha
            // 
            this.pnlMudarSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMudarSenha.Controls.Add(this.btnAlterar);
            this.pnlMudarSenha.Controls.Add(this.mskRepetirSenha);
            this.pnlMudarSenha.Controls.Add(this.mskNovaSenha);
            this.pnlMudarSenha.Controls.Add(this.mskSenhaAtual);
            this.pnlMudarSenha.Controls.Add(this.lblRepetirSenha);
            this.pnlMudarSenha.Controls.Add(this.lblNovaSenha);
            this.pnlMudarSenha.Controls.Add(this.lblSenhaAtual);
            this.pnlMudarSenha.Location = new System.Drawing.Point(495, -1);
            this.pnlMudarSenha.Name = "pnlMudarSenha";
            this.pnlMudarSenha.Size = new System.Drawing.Size(501, 324);
            this.pnlMudarSenha.TabIndex = 11;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(217, 235);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 33);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(85, 234);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 33);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(335, 234);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 33);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // fmrLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 322);
            this.Controls.Add(this.pnlMudarSenha);
            this.Controls.Add(this.mskSenha);
            this.Controls.Add(this.txtEmailUsuario);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblmsgEmail);
            this.Controls.Add(this.lblEmailUsuario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnOk);
            this.Name = "fmrLogin";
            this.Text = "fmrLogin";
            this.Load += new System.EventHandler(this.fmrLogin_Load);
            this.pnlMudarSenha.ResumeLayout(false);
            this.pnlMudarSenha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmailUsuario;
        private System.Windows.Forms.Label lblmsgEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblSenhaAtual;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.Label lblRepetirSenha;
        private System.Windows.Forms.TextBox txtEmailUsuario;
        private System.Windows.Forms.MaskedTextBox mskSenha;
        private System.Windows.Forms.MaskedTextBox mskSenhaAtual;
        private System.Windows.Forms.MaskedTextBox mskNovaSenha;
        private System.Windows.Forms.MaskedTextBox mskRepetirSenha;
        private System.Windows.Forms.Panel pnlMudarSenha;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnSair;
    }
}