namespace GenesysGym
{
    partial class TelaLogin
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
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.btn_Logar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(131, 99);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(271, 30);
            this.txt_UserName.TabIndex = 1;
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(131, 183);
            this.txt_Senha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(271, 30);
            this.txt_Senha.TabIndex = 2;
            // 
            // btn_Logar
            // 
            this.btn_Logar.Location = new System.Drawing.Point(131, 247);
            this.btn_Logar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Logar.Name = "btn_Logar";
            this.btn_Logar.Size = new System.Drawing.Size(121, 45);
            this.btn_Logar.TabIndex = 3;
            this.btn_Logar.Text = "Logar";
            this.btn_Logar.UseVisualStyleBackColor = true;
            this.btn_Logar.Click += new System.EventHandler(this.btn_Logar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(282, 247);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(121, 45);
            this.btn_Sair.TabIndex = 4;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Senha";
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(521, 391);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Logar);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_UserName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenesysGym System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Button btn_Logar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}