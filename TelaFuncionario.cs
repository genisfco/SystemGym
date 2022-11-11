using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace GenesysGym
{
    public partial class TelaFuncionario : Form
    {
        public TelaFuncionario()
        {
            InitializeComponent();
        }

        private bool ValidarForm()
        {
            bool FormValido;

            if (txtCodFuncionario.Text == "" 
                || txtCargoFuncionario.Text == "" 
                || txtNomeFuncionario.Text == "" 
                || comboxDiaFuncionario.Text == "" 
                || comboxMesFuncionario.Text == "" 
                || comboxAnoFuncionario.Text == "")
                FormValido = false;
            else if (rdbtnMascFuncionario.Checked == false && rdbtnFemFuncionario.Checked == false)
                FormValido = false;
            else if (txtLogradouroFuncionario.Text == "" || txtNumLogradouroFuncionario.Text == "" 
                || maskCEPFuncionario.Text.Length != 9 || txtBairroFuncionario.Text == "" 
                || txtCidadeFuncionario.Text == "" || txtEstadoFuncionario.Text == "")
                FormValido = false;
            else if (maskTelefoneFuncionario.Text.Length != 13 || txtEmailFuncionario.Text == "")
                FormValido = false;
            else
                FormValido = true;

            return FormValido;
        }

        private void LimparForm()
        {
            txtCodFuncionario.Text = string.Empty;
            txtCargoFuncionario.Text = string.Empty;
            txtNomeFuncionario.Text = string.Empty;
            maskCPFFuncionario.Text = string.Empty;
            maskRGFuncionario.Text = string.Empty;
            comboxDiaFuncionario.Text = string.Empty;
            comboxMesFuncionario.Text = string.Empty;
            comboxAnoFuncionario.Text = string.Empty;
            rdbtnMascFuncionario.Checked = false;
            rdbtnFemFuncionario.Checked = false;
            txtLogradouroFuncionario.Text = string.Empty;
            txtNumLogradouroFuncionario.Text = string.Empty;
            maskCEPFuncionario.Text = string.Empty;
            txtBairroFuncionario.Text = string.Empty;
            txtCidadeFuncionario.Text = string.Empty;
            txtEstadoFuncionario.Text = string.Empty;
            maskTelefoneFuncionario.Text = string.Empty;
            txtEmailFuncionario.Text = string.Empty;
        }

        

        private void LimparFormPesquisaFunc()
        {
            txtCodFuncAlter.Text = string.Empty;
            txtCargoFuncAlter.Text = string.Empty;
            txtNomeFuncAlter.Text = string.Empty;
            maskCPFFuncAlter.Text = string.Empty;
            maskRGFuncAlter.Text = string.Empty;
            txtLogradouroFuncAlter.Text = string.Empty;
            txtNumLogradouroFuncAlter.Text = string.Empty;
            maskCEPFuncAlter.Text = string.Empty;
            txtBairroFuncAlter.Text = string.Empty;
            txtCidadeFuncAlter.Text = string.Empty;
            txtEstadoFuncAlter.Text = string.Empty;
            maskTelefoneFuncAlter.Text = string.Empty;
            txtEmailFuncAlter.Text = string.Empty;
        }


        private void maskCEPFuncionario_Leave(object sender, EventArgs e)
        {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                try
                {
                    var endereco = ws.consultaCEP(maskCEPFuncionario.Text.Trim());
                    txtEstadoFuncionario.Text = endereco.uf;
                    txtCidadeFuncionario.Text = endereco.cidade;
                    txtBairroFuncionario.Text = endereco.bairro;
                    txtLogradouroFuncionario.Text = endereco.end;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void TelaFuncionario_Load(object sender, EventArgs e)
        {   
            pnlCadastrarFuncionario.Visible = false;
            pnlConsultarFuncionario.Visible = false;

        }

        private void menuCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            pnlCadastrarFuncionario.Visible = true;
            pnlConsultarFuncionario.Visible = false;
        }

        private void menuConsultarFuncionario_Click(object sender, EventArgs e)
        {
            pnlConsultarFuncionario.Visible = true;
            pnlCadastrarFuncionario.Visible = false;

            btnSalvarAlterFuncion.Enabled = false;

            DataTable dt = new DataTable();

            string connection_mysql = @"Server=localhost;Database=GenesysGym;Uid=root;Pwd='1234'";

            MySqlConnection msConnection = new MySqlConnection();
            msConnection.ConnectionString = connection_mysql;
            msConnection.Open();
            MySqlCommand msCommand = new MySqlCommand();
            msCommand.CommandText = "SELECT codfuncionario as 'COD.Funcionário', cargo as 'Cargo', nome as 'Nome Funcionário', cpf as 'CPF', rg as 'RG', sexo as 'sexo', dtMatricula as 'Data Admissão', dtNascimento as 'Data Nascimento', logradouro as 'Logradouro', numLogradouro as 'Nº', bairro as 'Bairro', cidade as 'Cidade', estado as 'UF', cep as 'CEP', telefone as 'Telefone', email as 'Email' FROM funcionario WHERE 1=1";
            msCommand.Connection = msConnection;
            MySqlDataAdapter msdAdapter = new MySqlDataAdapter(msCommand);
            msdAdapter.Fill(dt);

            dtgridFuncionariosCadastrados.DataSource = dt;
            msConnection.Close();
        }

        private void btnSairCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSairPesquisaFuncionario_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            // Exigir preenchimento completo dos campos obrigatórios
            if (ValidarForm() == false)
            {
                MessageBox.Show("ATENÇÃO: Todos os campos precisam ser preenchidos!");
            }
            else if (maskCPFFuncionario.Text.Length != 14)
            {
                MessageBox.Show("CPF incompleto, digite todos os digítos!");
            }

            // Aplicando Classe para validação de RG e CPF
            else if (ClassValidacao.validarCpf(maskCPFFuncionario.Text) == false)
            {
                MessageBox.Show("CPF inválido!");
            }
            else if (ClassValidacao.validarRg(maskRGFuncionario.Text) == false)
            {
                MessageBox.Show("RG inválido!");
            }

            // Dados válidos -> Processo de Insert 
            else if (ValidarForm() && ClassValidacao.validarCpf(maskCPFFuncionario.Text) && ClassValidacao.validarRg(maskRGFuncionario.Text))
            {
                // TRATAMENTO DOS DADOS PARA O INSERT
                string cpf = maskCPFFuncionario.Text;
                string rg = maskRGFuncionario.Text;
                cpf = cpf.Replace(",", "").Replace("-", "");
                rg = rg.Replace(",", "").Replace("-", "");

                string sexo;
                if (rdbtnMascFuncionario.Checked == true)
                {
                    sexo = "M";
                }
                else
                {
                    sexo = "F";
                }

                string year = dttimepickDataAdmissao.Value.Year.ToString();
                string month = dttimepickDataAdmissao.Value.Month.ToString();
                string day = dttimepickDataAdmissao.Value.Day.ToString();
                string data_admissao = year + "-" + month + "-" + day;

                string data_nasc = comboxAnoFuncionario.Text + "-" + comboxMesFuncionario.Text + "-" + comboxDiaFuncionario.Text;
                string telefone = maskTelefoneFuncionario.Text;
                telefone = telefone.Replace("(", "").Replace(")", "");

                // INSERT DOS DADOS PARA A TABELA CLIENTE
                string connection_mysql = @"Server=localhost;Database=GenesysGym;Uid=root;Pwd='1234'";

                MySqlConnection msConnection = new MySqlConnection();
                msConnection.ConnectionString = connection_mysql;
                msConnection.Open();
                MySqlCommand msCommand = new MySqlCommand();
                msCommand.CommandText = "insert into funcionario values ("
                          + txtCodFuncionario.Text +
                    ", '" + txtNomeFuncionario.Text +
                    "', '" + cpf +
                    "', '" + rg +
                    "', '" + sexo +
                    "', '" + data_admissao +
                    "', '" + data_nasc +
                    "', '" + txtLogradouroFuncionario.Text +
                    "', '" + txtNumLogradouroFuncionario.Text +
                    "', '" + txtBairroFuncionario.Text +
                    "', '" + txtCidadeFuncionario.Text +
                    "', '" + txtEstadoFuncionario.Text +
                    "', '" + maskCEPFuncionario.Text +
                    "', '" + txtCargoFuncionario.Text +
                    "', '" + telefone +
                    "', '" + txtEmailFuncionario.Text +
                    "');";
                

                msCommand.Connection = msConnection;
                msCommand.ExecuteNonQuery();
                msConnection.Close();

                MessageBox.Show("Funcionário cadastrado com sucesso!");
                LimparForm();
            }

        }

        private void btnLimparDadosFuncionario_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void btnSairPesquisaFuncionario_Click_1(object sender, EventArgs e)
        {
            
            LimparFormPesquisaFunc();
            Close();
        }

        private void btnPesquisarFuncionario_Click(object sender, EventArgs e)
        {
            btnSalvarAlterFuncion.Enabled = true;

            string cod = txtPesquisarCodFuncionario.Text;

            if (cod == "")
            {
                MessageBox.Show("Obrigatório preencher o Código do Funcionário!");
            }

            else
            {
                DataTable dt = new DataTable();

                string connection_mysql = @"Server=localhost;Database=GenesysGym;Uid=root;Pwd='1234'";

                MySqlConnection msConnection = new MySqlConnection();
                msConnection.ConnectionString = connection_mysql;
                msConnection.Open();
                MySqlCommand msCommand = new MySqlCommand();
                string pesquisarcod = " and codfuncionario = '" + cod + "'";
                string texto = "SELECT codfuncionario as 'COD.Funcionário', cargo as 'Cargo', nome as 'Nome Funcionário', cpf as 'CPF', rg as 'RG', sexo as 'sexo', dtMatricula as 'Data Admissão', dtNascimento as 'Data Nascimento', logradouro as 'Logradouro', numLogradouro as 'Nº', bairro as 'Bairro', cidade as 'Cidade', estado as 'UF', cep as 'CEP', telefone as 'Telefone', email as 'Email' FROM funcionario WHERE 1=1";
                if (cod != "   ") texto += pesquisarcod;


                msCommand.CommandText = texto;
                msCommand.Connection = msConnection;
                MySqlDataAdapter msdAdapter = new MySqlDataAdapter(msCommand);
                msdAdapter.Fill(dt);

                dtgridPesquisaFuncionario.DataSource = dt;
                msConnection.Close();
            }
        }

        private void dtgridPesquisaFuncionario_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vcod = dgv.SelectedRows[0].Cells[0].Value.ToString();

                dt = DataConnection.ObterDadosFuncionario(vcod);

                txtCodFuncAlter.Text = dt.Rows[0].Field<int>("codfuncionario").ToString();
                txtNomeFuncAlter.Text = dt.Rows[0].Field<string>("nome").ToString();
                maskCPFFuncAlter.Text = dt.Rows[0].Field<string>("cpf").ToString();
                maskRGFuncAlter.Text = dt.Rows[0].Field<string>("rg").ToString();
                txtLogradouroFuncAlter.Text = dt.Rows[0].Field<string>("logradouro").ToString();
                txtNumLogradouroFuncAlter.Text = dt.Rows[0].Field<int>("numLogradouro").ToString();
                maskCEPFuncAlter.Text = dt.Rows[0].Field<string>("cep").ToString();
                txtBairroFuncAlter.Text = dt.Rows[0].Field<string>("bairro").ToString();
                txtCidadeFuncAlter.Text = dt.Rows[0].Field<string>("cidade").ToString();
                txtEstadoFuncAlter.Text = dt.Rows[0].Field<string>("estado").ToString();
                maskTelefoneFuncAlter.Text = dt.Rows[0].Field<string>("telefone").ToString();
                txtEmailFuncAlter.Text = dt.Rows[0].Field<string>("email").ToString();                
                txtCargoFuncAlter.Text = dt.Rows[0].Field<string>("cargo").ToString();
            }
        }

        private void btnSalvarAlterFuncion_Click(object sender, EventArgs e)
        {
            int linha = dtgridPesquisaFuncionario.SelectedRows[0].Index;
            Funcionario func = new Funcionario();

            //TRATAMENTO DOS DADOS PARA INSERÇÃO
            string cpf = maskCPFFuncAlter.Text;
            string rg = maskRGFuncAlter.Text;
            string telefone = maskTelefoneFuncAlter.Text;
            cpf = cpf.Replace(",", "").Replace("-", "");
            rg = rg.Replace(",", "").Replace("-", "");
            telefone = telefone.Replace("(", "").Replace(")", "");

            func.codfunc = Convert.ToInt32(txtCodFuncAlter.Text);
            func.cargo = txtCargoFuncAlter.Text;
            func.nomefunc = txtNomeFuncAlter.Text;
            func.cpffunc = cpf;
            func.rgfunc = rg;
            func.logradourofunc = txtLogradouroFuncAlter.Text;
            func.numLogradourofunc = Convert.ToInt32(txtNumLogradouroFuncAlter.Text);
            func.cepfunc = maskCEPFuncAlter.Text;
            func.bairrofunc = txtBairroFuncAlter.Text;
            func.cidadefunc = txtCidadeFuncAlter.Text;
            func.estadofunc = txtEstadoFuncAlter.Text;
            func.telefonefunc = telefone;
            func.emailfunc = txtEmailFuncAlter.Text;

            DataConnection.AtualizarDadosFuncionario(func);
            dtgridPesquisaFuncionario[1, linha].Value = txtNomeFuncAlter.Text;

            MessageBox.Show("Dados atualizados com sucesso!");            
            LimparFormPesquisaFunc();


            ///ATUALIZANDO O DATAGRID VIEW DE FUNCIONARIOS            
            DataTable dt = new DataTable();

            string connection_mysql = @"Server=localhost;Database=GenesysGym;Uid=root;Pwd='1234'";

            MySqlConnection msConnection = new MySqlConnection();
            msConnection.ConnectionString = connection_mysql;
            msConnection.Open();
            MySqlCommand msCommand = new MySqlCommand();
            msCommand.CommandText = "SELECT codfuncionario as 'COD.Funcionário', cargo as 'Cargo', nome as 'Nome Funcionário', cpf as 'CPF', rg as 'RG', sexo as 'sexo', dtMatricula as 'Data Admissão', dtNascimento as 'Data Nascimento', logradouro as 'Logradouro', numLogradouro as 'Nº', bairro as 'Bairro', cidade as 'Cidade', estado as 'UF', cep as 'CEP', telefone as 'Telefone', email as 'Email' FROM funcionario WHERE 1=1";
            msCommand.Connection = msConnection;
            MySqlDataAdapter msdAdapter = new MySqlDataAdapter(msCommand);
            msdAdapter.Fill(dt);

            dtgridFuncionariosCadastrados.DataSource = dt;
            msConnection.Close();


        }

        private void btnExcluirFunc_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja realmente Excluir?", "Exclusão de Funcionário", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string cod = txtCodFuncAlter.Text;
                cod = cod.Replace(",", "").Replace("-", "");

                DataConnection.ExcluirDadosFuncionario(cod);
                dtgridFuncionariosCadastrados.Rows.Remove(dtgridFuncionariosCadastrados.CurrentRow);

                MessageBox.Show("Funcionário excluído com Sucesso!");
                LimparFormPesquisaFunc();
            }
        }

        private void maskCEPFuncAlter_Leave(object sender, EventArgs e)
        {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                try
                {
                    var endereco = ws.consultaCEP(maskCEPFuncAlter.Text.Trim());
                    txtEstadoFuncAlter.Text = endereco.uf;
                    txtCidadeFuncAlter.Text = endereco.cidade;
                    txtBairroFuncAlter.Text = endereco.bairro;
                    txtLogradouroFuncAlter.Text = endereco.end;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
