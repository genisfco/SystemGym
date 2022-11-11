namespace GenesysGym
{
    partial class TelaGestaoUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nup_Nivel = new System.Windows.Forms.NumericUpDown();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_NomeUsuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluirUser = new System.Windows.Forms.Button();
            this.btnSalvarAlterUser = new System.Windows.Forms.Button();
            this.btnNovoUser = new System.Windows.Forms.Button();
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Nivel)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 22);
            this.label8.TabIndex = 25;
            this.label8.Text = "D=Desligado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 22);
            this.label7.TabIndex = 24;
            this.label7.Text = "B=Bloqueado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "A=Ativo";
            // 
            // nup_Nivel
            // 
            this.nup_Nivel.Location = new System.Drawing.Point(23, 261);
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
            this.nup_Nivel.Size = new System.Drawing.Size(106, 28);
            this.nup_Nivel.TabIndex = 22;
            this.nup_Nivel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "A",
            "B",
            "D"});
            this.cb_Status.Location = new System.Drawing.Point(167, 261);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(161, 30);
            this.cb_Status.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nível Acesso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nome";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(167, 185);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(161, 28);
            this.txt_Senha.TabIndex = 15;
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(18, 185);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(111, 28);
            this.txt_Username.TabIndex = 14;
            // 
            // txt_NomeUsuario
            // 
            this.txt_NomeUsuario.Location = new System.Drawing.Point(18, 111);
            this.txt_NomeUsuario.Name = "txt_NomeUsuario";
            this.txt_NomeUsuario.Size = new System.Drawing.Size(310, 28);
            this.txt_NomeUsuario.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 22);
            this.label9.TabIndex = 27;
            this.label9.Text = "ID";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(18, 35);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(111, 28);
            this.txt_ID.TabIndex = 26;
            this.txt_ID.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.btnExcluirUser);
            this.panel1.Controls.Add(this.btnSalvarAlterUser);
            this.panel1.Controls.Add(this.btnNovoUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 54);
            this.panel1.TabIndex = 28;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Location = new System.Drawing.Point(687, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(179, 45);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluirUser
            // 
            this.btnExcluirUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirUser.Location = new System.Drawing.Point(400, 3);
            this.btnExcluirUser.Name = "btnExcluirUser";
            this.btnExcluirUser.Size = new System.Drawing.Size(179, 45);
            this.btnExcluirUser.TabIndex = 2;
            this.btnExcluirUser.Text = "Excluir Usuário";
            this.btnExcluirUser.UseVisualStyleBackColor = true;
            this.btnExcluirUser.Click += new System.EventHandler(this.btnExcluirUser_Click);
            // 
            // btnSalvarAlterUser
            // 
            this.btnSalvarAlterUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarAlterUser.Location = new System.Drawing.Point(202, 3);
            this.btnSalvarAlterUser.Name = "btnSalvarAlterUser";
            this.btnSalvarAlterUser.Size = new System.Drawing.Size(179, 45);
            this.btnSalvarAlterUser.TabIndex = 1;
            this.btnSalvarAlterUser.Text = "Salvar alterações";
            this.btnSalvarAlterUser.UseVisualStyleBackColor = true;
            this.btnSalvarAlterUser.Click += new System.EventHandler(this.btnSalvarAlterUser_Click);
            // 
            // btnNovoUser
            // 
            this.btnNovoUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoUser.Location = new System.Drawing.Point(0, 3);
            this.btnNovoUser.Name = "btnNovoUser";
            this.btnNovoUser.Size = new System.Drawing.Size(179, 45);
            this.btnNovoUser.TabIndex = 0;
            this.btnNovoUser.Text = "Novo Usuário";
            this.btnNovoUser.UseVisualStyleBackColor = true;
            this.btnNovoUser.Click += new System.EventHandler(this.btnNovoUser_Click);
            // 
            // dgv_Usuarios
            // 
            this.dgv_Usuarios.AllowUserToAddRows = false;
            this.dgv_Usuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuarios.EnableHeadersVisualStyles = false;
            this.dgv_Usuarios.Location = new System.Drawing.Point(359, 35);
            this.dgv_Usuarios.MultiSelect = false;
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.ReadOnly = true;
            this.dgv_Usuarios.RowHeadersVisible = false;
            this.dgv_Usuarios.RowHeadersWidth = 62;
            this.dgv_Usuarios.RowTemplate.Height = 28;
            this.dgv_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Usuarios.Size = new System.Drawing.Size(507, 296);
            this.dgv_Usuarios.TabIndex = 29;
            this.dgv_Usuarios.SelectionChanged += new System.EventHandler(this.dgv_Usuarios_SelectionChanged);
            // 
            // TelaGestaoUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 419);
            this.Controls.Add(this.dgv_Usuarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_ID);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaGestaoUsers";
            this.Text = "Gestão de Usuários";
            this.Load += new System.EventHandler(this.TelaGestaoUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nup_Nivel)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nup_Nivel;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_NomeUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Usuarios;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluirUser;
        private System.Windows.Forms.Button btnSalvarAlterUser;
        private System.Windows.Forms.Button btnNovoUser;
    }
}