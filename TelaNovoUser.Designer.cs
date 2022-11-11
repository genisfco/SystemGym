namespace GenesysGym
{
    partial class TelaNovoUser
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
            this.txt_NomeUsuario = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.nup_Nivel = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvarUser = new System.Windows.Forms.Button();
            this.btnNovoUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Nivel)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_NomeUsuario
            // 
            this.txt_NomeUsuario.Location = new System.Drawing.Point(19, 40);
            this.txt_NomeUsuario.Name = "txt_NomeUsuario";
            this.txt_NomeUsuario.Size = new System.Drawing.Size(393, 28);
            this.txt_NomeUsuario.TabIndex = 0;
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(444, 40);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(111, 28);
            this.txt_Username.TabIndex = 1;
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(593, 40);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(161, 28);
            this.txt_Senha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nível Acesso";
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "A",
            "B",
            "D"});
            this.cb_Status.Location = new System.Drawing.Point(307, 108);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(105, 30);
            this.cb_Status.TabIndex = 8;
            // 
            // nup_Nivel
            // 
            this.nup_Nivel.Location = new System.Drawing.Point(13, 108);
            this.nup_Nivel.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nup_Nivel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup_Nivel.Name = "nup_Nivel";
            this.nup_Nivel.Size = new System.Drawing.Size(111, 28);
            this.nup_Nivel.TabIndex = 9;
            this.nup_Nivel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "A=Ativo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "B=Bloqueado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(639, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "D=Desligado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnSalvarUser);
            this.panel1.Controls.Add(this.btnNovoUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 72);
            this.panel1.TabIndex = 13;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Location = new System.Drawing.Point(726, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(110, 54);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(288, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(110, 54);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvarUser
            // 
            this.btnSalvarUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarUser.Location = new System.Drawing.Point(150, 4);
            this.btnSalvarUser.Name = "btnSalvarUser";
            this.btnSalvarUser.Size = new System.Drawing.Size(110, 54);
            this.btnSalvarUser.TabIndex = 1;
            this.btnSalvarUser.Text = "Salvar";
            this.btnSalvarUser.UseVisualStyleBackColor = true;
            this.btnSalvarUser.Click += new System.EventHandler(this.btnSalvarUser_Click);
            // 
            // btnNovoUser
            // 
            this.btnNovoUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoUser.Location = new System.Drawing.Point(14, 4);
            this.btnNovoUser.Name = "btnNovoUser";
            this.btnNovoUser.Size = new System.Drawing.Size(110, 54);
            this.btnNovoUser.TabIndex = 0;
            this.btnNovoUser.Text = "Novo";
            this.btnNovoUser.UseVisualStyleBackColor = true;
            this.btnNovoUser.Click += new System.EventHandler(this.btnNovoUser_Click);
            // 
            // TelaNovoUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 265);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nup_Nivel);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.txt_NomeUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TelaNovoUser";
            this.Text = "Cadastrar Novo Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.nup_Nivel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NomeUsuario;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.NumericUpDown nup_Nivel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvarUser;
        private System.Windows.Forms.Button btnNovoUser;
    }
}