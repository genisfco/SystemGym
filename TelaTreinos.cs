using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GenesysGym
{
    public partial class TelaTreinos : Form
    {
        public TelaTreinos()
        {
            InitializeComponent();
        }

        // LISTAS DE EXERCÍCIOS
        string[] exercPeitoral = {
            "Supino Reto",
            "Supino Inclinado",
            "Supino Declinado",
            "Crucifixo Reto",
            "Crucifixo Inclinado",
            "Fly Reto",
            "Fly Inclinado",
            "Peck Deck",
            "Cross-Over",
            "Flexão de braços",
            "Pull-Over"
        };

        string[] exercCostas = {
            "Barra fixa",
            "Pulley frontal",
            "Pulley frontal supinado",
            "Pulley frontal triângulo",
            "Remada Máquina",
            "Remada Baixa Sentado",
            "Remada Curvada",
            "Remada unilateral (serrote)",
            "Remada Cavalinho",
            "Pull-Down",
            "Extensão lombar"
        };

        string[] exercOmbros = {
            "Desenvolvimento halteres",
            "Desenvolvimento barra",
            "Desenvolvimento máquina",
            "Desenvolvimento Arnold",
            "Elevação lateral",
            "Elevação frontal",
            "Crucifixo inverso",
            "Remada alta",
            "Encolhimento halteres",
            "Encolhimento barra smith",
        };

        string[] exercTriceps = {
            "Pulley tríceps",
            "Pulley tríceps invertido",
            "Pulley corda",
            "Rosca francesa",
            "Tríceps testa",
            "Tríceps banco",
            "Tríceps coice",
            "Tríceps máquina",
            "Supino fechado",
            "Paralelas"
        };

        string[] exercBiceps = {
            "Rosca direta barra",
            "Rosca simultânea halteres",
            "Rosca alternada halteres",
            "Rosca scott",
            "Rosca scott unilateral",
            "Rosca concentrada",
            "Rosca inversa",
            "Rosca martelo",
        };

        string[] exercPernas = {
            "Leg press 45º",
            "Leg press horizontal",
            "Agachamento smith",
            "Agachamento hack",
            "Agachamento livre",
            "Cadeira extensora",
            "Cadeira flexora",
            "Mesa flexora",
            "Afundo",
            "Afundo búlgaro",
            "Avanço",
            "Passada",
            "Stiff",
            "Agachamento sumô",
            "Abdução",
            "Adução",
            "Elevação pélvica"
        };

        string[] exercPanturrilhas = {
            "Gêmeos sentado",
            "Elevação de gêmeos"
        };

        string[] exercAbdomen = {
            "Abdominal reto",
            "Elevação de pernas",
            "Abdominal máquina",
            "Prancha abdominal",
            "Prancha lateral",
            "Roda abdominal",
        };

        
        
        private void cboGrup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExerc1.Items.Clear();
            
            if (cboGrup1.SelectedIndex == 0)
            {
                cboExerc1.Items.AddRange(exercPeitoral);
                cboExerc1.SelectedIndex = 0;
            }
            else if (cboGrup1.SelectedIndex == 1)
            {
                cboExerc1.Items.AddRange(exercCostas);
                cboExerc1.SelectedIndex = 0;
            }
            else if (cboGrup1.SelectedIndex == 2)
            {
                cboExerc1.Items.AddRange(exercOmbros);
                cboExerc1.SelectedIndex = 0;
            }
            else if (cboGrup1.SelectedIndex == 3)
            {
                cboExerc1.Items.AddRange(exercTriceps);
                cboExerc1.SelectedIndex = 0;
            }
            else if (cboGrup1.SelectedIndex == 4)
            {
                cboExerc1.Items.AddRange(exercBiceps);
                cboExerc1.SelectedIndex = 0;
            }
            else if (cboGrup1.SelectedIndex == 5)
            {
                cboExerc1.Items.AddRange(exercPernas);
                cboExerc1.SelectedIndex = 0;
            }
            else if (cboGrup1.SelectedIndex == 6)
            {
                cboExerc1.Items.AddRange(exercPanturrilhas);
                cboExerc1.SelectedIndex = 0;
            }
            else if(cboGrup1.SelectedIndex == 7)
            {
                cboExerc1.Items.AddRange(exercAbdomen);
                cboExerc1.SelectedIndex=0;
            }

        }

        

        private void cboGrup2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExerc2.Items.Clear();

            if (cboGrup2.SelectedIndex == 0)
            {
                cboExerc2.Items.AddRange(exercPeitoral);
                cboExerc2.SelectedIndex = 0;
            }
            else if (cboGrup2.SelectedIndex == 1)
            {
                cboExerc2.Items.AddRange(exercCostas);
                cboExerc2.SelectedIndex = 0;
            }
            else if (cboGrup2.SelectedIndex == 2)
            {
                cboExerc2.Items.AddRange(exercOmbros);
                cboExerc2.SelectedIndex = 0;
            }
            else if (cboGrup2.SelectedIndex == 3)
            {
                cboExerc2.Items.AddRange(exercTriceps);
                cboExerc2.SelectedIndex = 0;
            }
            else if (cboGrup2.SelectedIndex == 4)
            {
                cboExerc2.Items.AddRange(exercBiceps);
                cboExerc2.SelectedIndex = 0;
            }
            else if (cboGrup2.SelectedIndex == 5)
            {
                cboExerc2.Items.AddRange(exercPernas);
                cboExerc2.SelectedIndex = 0;
            }
            else if (cboGrup2.SelectedIndex == 6)
            {
                cboExerc2.Items.AddRange(exercPanturrilhas);
                cboExerc2.SelectedIndex = 0;
            }
            else if (cboGrup2.SelectedIndex == 7)
            {
                cboExerc2.Items.AddRange(exercAbdomen);
                cboExerc2.SelectedIndex = 0;
            }
        }

        private void cboGrup3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExerc3.Items.Clear();

            if (cboGrup3.SelectedIndex == 0)
            {
                cboExerc3.Items.AddRange(exercPeitoral);
                cboExerc3.SelectedIndex = 0;
            }
            else if (cboGrup3.SelectedIndex == 1)
            {
                cboExerc3.Items.AddRange(exercCostas);
                cboExerc3.SelectedIndex = 0;
            }
            else if (cboGrup3.SelectedIndex == 2)
            {
                cboExerc3.Items.AddRange(exercOmbros);
                cboExerc3.SelectedIndex = 0;
            }
            else if (cboGrup3.SelectedIndex == 3)
            {
                cboExerc3.Items.AddRange(exercTriceps);
                cboExerc3.SelectedIndex = 0;
            }
            else if (cboGrup3.SelectedIndex == 4)
            {
                cboExerc3.Items.AddRange(exercBiceps);
                cboExerc3.SelectedIndex = 0;
            }
            else if (cboGrup3.SelectedIndex == 5)
            {
                cboExerc3.Items.AddRange(exercPernas);
                cboExerc3.SelectedIndex = 0;
            }
            else if (cboGrup3.SelectedIndex == 6)
            {
                cboExerc3.Items.AddRange(exercPanturrilhas);
                cboExerc3.SelectedIndex = 0;
            }
            else if (cboGrup3.SelectedIndex == 7)
            {
                cboExerc3.Items.AddRange(exercAbdomen);
                cboExerc3.SelectedIndex = 0;
            }
        }

        private void cboGrup4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExerc4.Items.Clear();

            if (cboGrup4.SelectedIndex == 0)
            {
                cboExerc4.Items.AddRange(exercPeitoral);
                cboExerc4.SelectedIndex = 0;
            }
            else if (cboGrup4.SelectedIndex == 1)
            {
                cboExerc4.Items.AddRange(exercCostas);
                cboExerc4.SelectedIndex = 0;
            }
            else if (cboGrup4.SelectedIndex == 2)
            {
                cboExerc4.Items.AddRange(exercOmbros);
                cboExerc4.SelectedIndex = 0;
            }
            else if (cboGrup4.SelectedIndex == 3)
            {
                cboExerc4.Items.AddRange(exercTriceps);
                cboExerc4.SelectedIndex = 0;
            }
            else if (cboGrup4.SelectedIndex == 4)
            {
                cboExerc4.Items.AddRange(exercBiceps);
                cboExerc4.SelectedIndex = 0;
            }
            else if (cboGrup4.SelectedIndex == 5)
            {
                cboExerc4.Items.AddRange(exercPernas);
                cboExerc4.SelectedIndex = 0;
            }
            else if (cboGrup4.SelectedIndex == 6)
            {
                cboExerc4.Items.AddRange(exercPanturrilhas);
                cboExerc4.SelectedIndex = 0;
            }
            else if (cboGrup4.SelectedIndex == 7)
            {
                cboExerc4.Items.AddRange(exercAbdomen);
                cboExerc4.SelectedIndex = 0;
            }
        }

        private void cboGrup5_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExerc5.Items.Clear();

            if (cboGrup5.SelectedIndex == 0)
            {
                cboExerc5.Items.AddRange(exercPeitoral);
                cboExerc5.SelectedIndex = 0;
            }
            else if (cboGrup5.SelectedIndex == 1)
            {
                cboExerc5.Items.AddRange(exercCostas);
                cboExerc5.SelectedIndex = 0;
            }
            else if (cboGrup5.SelectedIndex == 2)
            {
                cboExerc5.Items.AddRange(exercOmbros);
                cboExerc5.SelectedIndex = 0;
            }
            else if (cboGrup5.SelectedIndex == 3)
            {
                cboExerc5.Items.AddRange(exercTriceps);
                cboExerc5.SelectedIndex = 0;
            }
            else if (cboGrup5.SelectedIndex == 4)
            {
                cboExerc5.Items.AddRange(exercBiceps);
                cboExerc5.SelectedIndex = 0;
            }
            else if (cboGrup5.SelectedIndex == 5)
            {
                cboExerc5.Items.AddRange(exercPernas);
                cboExerc5.SelectedIndex = 0;
            }
            else if (cboGrup5.SelectedIndex == 6)
            {
                cboExerc5.Items.AddRange(exercPanturrilhas);
                cboExerc5.SelectedIndex = 0;
            }
            else if (cboGrup5.SelectedIndex == 7)
            {
                cboExerc5.Items.AddRange(exercAbdomen);
                cboExerc5.SelectedIndex = 0;
            }
        }

        private void cboGrup6_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExerc6.Items.Clear();

            if (cboGrup6.SelectedIndex == 0)
            {
                cboExerc6.Items.AddRange(exercPeitoral);
                cboExerc6.SelectedIndex = 0;
            }
            else if (cboGrup6.SelectedIndex == 1)
            {
                cboExerc6.Items.AddRange(exercCostas);
                cboExerc6.SelectedIndex = 0;
            }
            else if (cboGrup6.SelectedIndex == 2)
            {
                cboExerc6.Items.AddRange(exercOmbros);
                cboExerc6.SelectedIndex = 0;
            }
            else if (cboGrup6.SelectedIndex == 3)
            {
                cboExerc6.Items.AddRange(exercTriceps);
                cboExerc6.SelectedIndex = 0;
            }
            else if (cboGrup6.SelectedIndex == 4)
            {
                cboExerc6.Items.AddRange(exercBiceps);
                cboExerc6.SelectedIndex = 0;
            }
            else if (cboGrup6.SelectedIndex == 5)
            {
                cboExerc6.Items.AddRange(exercPernas);
                cboExerc6.SelectedIndex = 0;
            }
            else if (cboGrup6.SelectedIndex == 6)
            {
                cboExerc6.Items.AddRange(exercPanturrilhas);
                cboExerc6.SelectedIndex = 0;
            }
            else if (cboGrup6.SelectedIndex == 7)
            {
                cboExerc6.Items.AddRange(exercAbdomen);
                cboExerc6.SelectedIndex = 0;
            }
        }

        private void cboGrup7_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExerc7.Items.Clear();

            if (cboGrup7.SelectedIndex == 0)
            {
                cboExerc7.Items.AddRange(exercPeitoral);
                cboExerc7.SelectedIndex = 0;
            }
            else if (cboGrup7.SelectedIndex == 1)
            {
                cboExerc7.Items.AddRange(exercCostas);
                cboExerc7.SelectedIndex = 0;
            }
            else if (cboGrup7.SelectedIndex == 2)
            {
                cboExerc7.Items.AddRange(exercOmbros);
                cboExerc7.SelectedIndex = 0;
            }
            else if (cboGrup7.SelectedIndex == 3)
            {
                cboExerc7.Items.AddRange(exercTriceps);
                cboExerc7.SelectedIndex = 0;
            }
            else if (cboGrup7.SelectedIndex == 4)
            {
                cboExerc7.Items.AddRange(exercBiceps);
                cboExerc7.SelectedIndex = 0;
            }
            else if (cboGrup7.SelectedIndex == 5)
            {
                cboExerc7.Items.AddRange(exercPernas);
                cboExerc7.SelectedIndex = 0;
            }
            else if (cboGrup7.SelectedIndex == 6)
            {
                cboExerc7.Items.AddRange(exercPanturrilhas);
                cboExerc7.SelectedIndex = 0;
            }
            else if (cboGrup7.SelectedIndex == 7)
            {
                cboExerc7.Items.AddRange(exercAbdomen);
                cboExerc7.SelectedIndex = 0;
            }
        }

        private void cboGrup8_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExerc8.Items.Clear();

            if (cboGrup8.SelectedIndex == 0)
            {
                cboExerc8.Items.AddRange(exercPeitoral);
                cboExerc8.SelectedIndex = 0;
            }
            else if (cboGrup8.SelectedIndex == 1)
            {
                cboExerc8.Items.AddRange(exercCostas);
                cboExerc8.SelectedIndex = 0;
            }
            else if (cboGrup8.SelectedIndex == 2)
            {
                cboExerc8.Items.AddRange(exercOmbros);
                cboExerc8.SelectedIndex = 0;
            }
            else if (cboGrup8.SelectedIndex == 3)
            {
                cboExerc8.Items.AddRange(exercTriceps);
                cboExerc8.SelectedIndex = 0;
            }
            else if (cboGrup8.SelectedIndex == 4)
            {
                cboExerc8.Items.AddRange(exercBiceps);
                cboExerc8.SelectedIndex = 0;
            }
            else if (cboGrup8.SelectedIndex == 5)
            {
                cboExerc8.Items.AddRange(exercPernas);
                cboExerc8.SelectedIndex = 0;
            }
            else if (cboGrup8.SelectedIndex == 6)
            {
                cboExerc8.Items.AddRange(exercPanturrilhas);
                cboExerc8.SelectedIndex = 0;
            }
            else if (cboGrup8.SelectedIndex == 7)
            {
                cboExerc8.Items.AddRange(exercAbdomen);
                cboExerc8.SelectedIndex = 0;
            }
        }





        private void btnLimparTreinoA_Click(object sender, EventArgs e)
        {
            cboGrup1.Text = String.Empty; cboExerc1.Text = String.Empty; cboExerc1.Items.Clear(); cboSerie1.Text = String.Empty; cboRep1.Text = String.Empty;
            cboGrup2.Text = String.Empty; cboExerc2.Text = String.Empty; cboExerc2.Items.Clear(); cboSerie2.Text = String.Empty; cboRep2.Text = String.Empty;
            cboGrup3.Text = String.Empty; cboExerc3.Text = String.Empty; cboExerc3.Items.Clear(); cboSerie3.Text = String.Empty; cboRep3.Text = String.Empty;
            cboGrup4.Text = String.Empty; cboExerc4.Text = String.Empty; cboExerc4.Items.Clear(); cboSerie4.Text = String.Empty; cboRep4.Text = String.Empty;
            cboGrup5.Text = String.Empty; cboExerc5.Text = String.Empty; cboExerc5.Items.Clear(); cboSerie5.Text = String.Empty; cboRep5.Text = String.Empty;
            cboGrup6.Text = String.Empty; cboExerc6.Text = String.Empty; cboExerc6.Items.Clear(); cboSerie6.Text = String.Empty; cboRep6.Text = String.Empty;
            cboGrup7.Text = String.Empty; cboExerc7.Text = String.Empty; cboExerc7.Items.Clear(); cboSerie7.Text = String.Empty; cboRep7.Text = String.Empty;
            cboGrup8.Text = String.Empty; cboExerc8.Text = String.Empty; cboExerc8.Items.Clear(); cboSerie8.Text = String.Empty; cboRep8.Text = String.Empty;
        }

        private void btnLimparTreinoB_Click(object sender, EventArgs e)
        {
            cboGrup9.Text = String.Empty; cboExerc9.Text = String.Empty; cboExerc9.Items.Clear(); cboSerie9.Text = String.Empty; cboRep9.Text = String.Empty;
            cboGrup10.Text = String.Empty; cboExerc10.Text = String.Empty; cboExerc10.Items.Clear(); cboSerie10.Text = String.Empty; cboRep10.Text = String.Empty;
            cboGrup11.Text = String.Empty; cboExerc11.Text = String.Empty; cboExerc11.Items.Clear(); cboSerie11.Text = String.Empty; cboRep11.Text = String.Empty;
            cboGrup12.Text = String.Empty; cboExerc12.Text = String.Empty; cboExerc12.Items.Clear(); cboSerie12.Text = String.Empty; cboRep12.Text = String.Empty;
            cboGrup13.Text = String.Empty; cboExerc13.Text = String.Empty; cboExerc13.Items.Clear(); cboSerie13.Text = String.Empty; cboRep13.Text = String.Empty;
            cboGrup14.Text = String.Empty; cboExerc14.Text = String.Empty; cboExerc14.Items.Clear(); cboSerie14.Text = String.Empty; cboRep14.Text = String.Empty;
            cboGrup15.Text = String.Empty; cboExerc15.Text = String.Empty; cboExerc15.Items.Clear(); cboSerie15.Text = String.Empty; cboRep15.Text = String.Empty;
            cboGrup16.Text = String.Empty; cboExerc16.Text = String.Empty; cboExerc16.Items.Clear(); cboSerie16.Text = String.Empty; cboRep16.Text = String.Empty;
        }

        private void btnSairTreino_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravarTreino_Click(object sender, EventArgs e)
        {
            //Treino tre = new Treino();
            //tre.nome = txt_NomeUsuario.Text;
            //tre.username = txt_Username.Text;
            //tre.password = txt_Senha.Text;
            //tre.status = cb_Status.Text;
            //tre.nivel = Convert.ToInt32(Math.Round(nup_Nivel.Value, 0));

            //DataConnection.NovoTreino(tre);

            MessageBox.Show("Treino cadastrado!");

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string cpf = maskCPFClienteTreino.Text;
            cpf = cpf.Replace(",", "").Replace("-", "");

            if (cpf.Length != 11)
            {
                MessageBox.Show("Obrigatório preencher o CPF completo!");
            }

            else
            {
                
                DataTable dt = new DataTable();

                string connection_mysql = @"Server=localhost;Database=GenesysGym;Uid=root;Pwd='1234'";

                MySqlConnection msConnection = new MySqlConnection();
                msConnection.ConnectionString = connection_mysql;
                msConnection.Open();
                MySqlCommand msCommand = new MySqlCommand();
                string pesquisarCPF = " and cpf = '" + cpf + "'";
                string texto = "SELECT codCliente as 'COD. Cliente', nmCliente as 'Nome Cliente', cpf as 'CPF', rg as 'RG', sexo as 'sexo', dtMatricula as 'Data Matrícula', dtNascimento as 'Data Nascimento', logradouro as 'Logradouro', numLogradouro as 'Nº', bairro as 'Bairro', cidade as 'Cidade', estado as 'UF', cep as 'CEP', telefone as 'Telefone', email as 'Email' FROM cliente WHERE 1=1";
                if (cpf != "         ") texto += pesquisarCPF;

                msCommand.CommandText = texto;
                msCommand.Connection = msConnection;
                MySqlDataAdapter msdAdapter = new MySqlDataAdapter(msCommand);
                msdAdapter.Fill(dt);

                dataGridView1.DataSource = dt;
                msConnection.Close();
               
            }

            dataGridView1.Visible = true;
        }

        private void cboGrup9_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExerc9.Items.Clear();

            if (cboGrup9.SelectedIndex == 0)
            {
                cboExerc9.Items.AddRange(exercPeitoral);
                cboExerc9.SelectedIndex = 0;
            }
            else if (cboGrup9.SelectedIndex == 1)
            {
                cboExerc9.Items.AddRange(exercCostas);
                cboExerc9.SelectedIndex = 0;
            }
            else if (cboGrup9.SelectedIndex == 2)
            {
                cboExerc9.Items.AddRange(exercOmbros);
                cboExerc9.SelectedIndex = 0;
            }
            else if (cboGrup9.SelectedIndex == 3)
            {
                cboExerc9.Items.AddRange(exercTriceps);
                cboExerc9.SelectedIndex = 0;
            }
            else if (cboGrup9.SelectedIndex == 4)
            {
                cboExerc9.Items.AddRange(exercBiceps);
                cboExerc9.SelectedIndex = 0;
            }
            else if (cboGrup9.SelectedIndex == 5)
            {
                cboExerc9.Items.AddRange(exercPernas);
                cboExerc9.SelectedIndex = 0;
            }
            else if (cboGrup9.SelectedIndex == 6)
            {
                cboExerc9.Items.AddRange(exercPanturrilhas);
                cboExerc9.SelectedIndex = 0;
            }
            else if (cboGrup9.SelectedIndex == 7)
            {
                cboExerc9.Items.AddRange(exercAbdomen);
                cboExerc9.SelectedIndex = 0;
            }
        }

        private void cboGrup10_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExerc10.Items.Clear();

            if (cboGrup10.SelectedIndex == 0)
            {
                cboExerc10.Items.AddRange(exercPeitoral);
                cboExerc10.SelectedIndex = 0;
            }
            else if (cboGrup10.SelectedIndex == 1)
            {
                cboExerc10.Items.AddRange(exercCostas);
                cboExerc10.SelectedIndex = 0;
            }
            else if (cboGrup10.SelectedIndex == 2)
            {
                cboExerc10.Items.AddRange(exercOmbros);
                cboExerc10.SelectedIndex = 0;
            }
            else if (cboGrup10.SelectedIndex == 3)
            {
                cboExerc10.Items.AddRange(exercTriceps);
                cboExerc10.SelectedIndex = 0;
            }
            else if (cboGrup10.SelectedIndex == 4)
            {
                cboExerc10.Items.AddRange(exercBiceps);
                cboExerc10.SelectedIndex = 0;
            }
            else if (cboGrup10.SelectedIndex == 5)
            {
                cboExerc10.Items.AddRange(exercPernas);
                cboExerc10.SelectedIndex = 0;
            }
            else if (cboGrup10.SelectedIndex == 6)
            {
                cboExerc10.Items.AddRange(exercPanturrilhas);
                cboExerc10.SelectedIndex = 0;
            }
            else if (cboGrup10.SelectedIndex == 7)
            {
                cboExerc10.Items.AddRange(exercAbdomen);
                cboExerc10.SelectedIndex = 0;
            }
        }

        private void cboGrup11_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExerc11.Items.Clear();

            if (cboGrup11.SelectedIndex == 0)
            {
                cboExerc11.Items.AddRange(exercPeitoral);
                cboExerc11.SelectedIndex = 0;
            }
            else if (cboGrup11.SelectedIndex == 1)
            {
                cboExerc11.Items.AddRange(exercCostas);
                cboExerc11.SelectedIndex = 0;
            }
            else if (cboGrup11.SelectedIndex == 2)
            {
                cboExerc11.Items.AddRange(exercOmbros);
                cboExerc11.SelectedIndex = 0;
            }
            else if (cboGrup11.SelectedIndex == 3)
            {
                cboExerc11.Items.AddRange(exercTriceps);
                cboExerc11.SelectedIndex = 0;
            }
            else if (cboGrup11.SelectedIndex == 4)
            {
                cboExerc11.Items.AddRange(exercBiceps);
                cboExerc11.SelectedIndex = 0;
            }
            else if (cboGrup11.SelectedIndex == 5)
            {
                cboExerc11.Items.AddRange(exercPernas);
                cboExerc11.SelectedIndex = 0;
            }
            else if (cboGrup11.SelectedIndex == 6)
            {
                cboExerc11.Items.AddRange(exercPanturrilhas);
                cboExerc11.SelectedIndex = 0;
            }
            else if (cboGrup11.SelectedIndex == 7)
            {
                cboExerc11.Items.AddRange(exercAbdomen);
                cboExerc11.SelectedIndex = 0;
            }
        }

        private void cboGrup12_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExerc12.Items.Clear();

            if (cboGrup12.SelectedIndex == 0)
            {
                cboExerc12.Items.AddRange(exercPeitoral);
                cboExerc12.SelectedIndex = 0;
            }
            else if (cboGrup12.SelectedIndex == 1)
            {
                cboExerc12.Items.AddRange(exercCostas);
                cboExerc12.SelectedIndex = 0;
            }
            else if (cboGrup12.SelectedIndex == 2)
            {
                cboExerc12.Items.AddRange(exercOmbros);
                cboExerc12.SelectedIndex = 0;
            }
            else if (cboGrup12.SelectedIndex == 3)
            {
                cboExerc12.Items.AddRange(exercTriceps);
                cboExerc12.SelectedIndex = 0;
            }
            else if (cboGrup12.SelectedIndex == 4)
            {
                cboExerc12.Items.AddRange(exercBiceps);
                cboExerc12.SelectedIndex = 0;
            }
            else if (cboGrup12.SelectedIndex == 5)
            {
                cboExerc12.Items.AddRange(exercPernas);
                cboExerc12.SelectedIndex = 0;
            }
            else if (cboGrup12.SelectedIndex == 6)
            {
                cboExerc12.Items.AddRange(exercPanturrilhas);
                cboExerc12.SelectedIndex = 0;
            }
            else if (cboGrup12.SelectedIndex == 7)
            {
                cboExerc12.Items.AddRange(exercAbdomen);
                cboExerc12.SelectedIndex = 0;
            }
        }

        private void cboGrup13_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExerc13.Items.Clear();

            if (cboGrup13.SelectedIndex == 0)
            {
                cboExerc13.Items.AddRange(exercPeitoral);
                cboExerc13.SelectedIndex = 0;
            }
            else if (cboGrup13.SelectedIndex == 1)
            {
                cboExerc13.Items.AddRange(exercCostas);
                cboExerc13.SelectedIndex = 0;
            }
            else if (cboGrup13.SelectedIndex == 2)
            {
                cboExerc13.Items.AddRange(exercOmbros);
                cboExerc13.SelectedIndex = 0;
            }
            else if (cboGrup13.SelectedIndex == 3)
            {
                cboExerc13.Items.AddRange(exercTriceps);
                cboExerc13.SelectedIndex = 0;
            }
            else if (cboGrup13.SelectedIndex == 4)
            {
                cboExerc13.Items.AddRange(exercBiceps);
                cboExerc13.SelectedIndex = 0;
            }
            else if (cboGrup13.SelectedIndex == 5)
            {
                cboExerc13.Items.AddRange(exercPernas);
                cboExerc13.SelectedIndex = 0;
            }
            else if (cboGrup13.SelectedIndex == 6)
            {
                cboExerc13.Items.AddRange(exercPanturrilhas);
                cboExerc13.SelectedIndex = 0;
            }
            else if (cboGrup13.SelectedIndex == 7)
            {
                cboExerc13.Items.AddRange(exercAbdomen);
                cboExerc13.SelectedIndex = 0;
            }
        }

        private void cboGrup14_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExerc14.Items.Clear();

            if (cboGrup14.SelectedIndex == 0)
            {
                cboExerc14.Items.AddRange(exercPeitoral);
                cboExerc14.SelectedIndex = 0;
            }
            else if (cboGrup14.SelectedIndex == 1)
            {
                cboExerc14.Items.AddRange(exercCostas);
                cboExerc14.SelectedIndex = 0;
            }
            else if (cboGrup14.SelectedIndex == 2)
            {
                cboExerc14.Items.AddRange(exercOmbros);
                cboExerc14.SelectedIndex = 0;
            }
            else if (cboGrup14.SelectedIndex == 3)
            {
                cboExerc14.Items.AddRange(exercTriceps);
                cboExerc14.SelectedIndex = 0;
            }
            else if (cboGrup14.SelectedIndex == 4)
            {
                cboExerc14.Items.AddRange(exercBiceps);
                cboExerc14.SelectedIndex = 0;
            }
            else if (cboGrup14.SelectedIndex == 5)
            {
                cboExerc14.Items.AddRange(exercPernas);
                cboExerc14.SelectedIndex = 0;
            }
            else if (cboGrup14.SelectedIndex == 6)
            {
                cboExerc14.Items.AddRange(exercPanturrilhas);
                cboExerc14.SelectedIndex = 0;
            }
            else if (cboGrup14.SelectedIndex == 7)
            {
                cboExerc14.Items.AddRange(exercAbdomen);
                cboExerc14.SelectedIndex = 0;
            }
        }

        private void cboGrup15_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExerc15.Items.Clear();

            if (cboGrup15.SelectedIndex == 0)
            {
                cboExerc15.Items.AddRange(exercPeitoral);
                cboExerc15.SelectedIndex = 0;
            }
            else if (cboGrup15.SelectedIndex == 1)
            {
                cboExerc15.Items.AddRange(exercCostas);
                cboExerc15.SelectedIndex = 0;
            }
            else if (cboGrup15.SelectedIndex == 2)
            {
                cboExerc15.Items.AddRange(exercOmbros);
                cboExerc15.SelectedIndex = 0;
            }
            else if (cboGrup15.SelectedIndex == 3)
            {
                cboExerc15.Items.AddRange(exercTriceps);
                cboExerc15.SelectedIndex = 0;
            }
            else if (cboGrup15.SelectedIndex == 4)
            {
                cboExerc15.Items.AddRange(exercBiceps);
                cboExerc15.SelectedIndex = 0;
            }
            else if (cboGrup15.SelectedIndex == 5)
            {
                cboExerc15.Items.AddRange(exercPernas);
                cboExerc15.SelectedIndex = 0;
            }
            else if (cboGrup15.SelectedIndex == 6)
            {
                cboExerc15.Items.AddRange(exercPanturrilhas);
                cboExerc15.SelectedIndex = 0;
            }
            else if (cboGrup15.SelectedIndex == 7)
            {
                cboExerc15.Items.AddRange(exercAbdomen);
                cboExerc15.SelectedIndex = 0;
            }
        }

        private void cboGrup16_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExerc16.Items.Clear();

            if (cboGrup16.SelectedIndex == 0)
            {
                cboExerc16.Items.AddRange(exercPeitoral);
                cboExerc16.SelectedIndex = 0;
            }
            else if (cboGrup16.SelectedIndex == 1)
            {
                cboExerc16.Items.AddRange(exercCostas);
                cboExerc16.SelectedIndex = 0;
            }
            else if (cboGrup16.SelectedIndex == 2)
            {
                cboExerc16.Items.AddRange(exercOmbros);
                cboExerc16.SelectedIndex = 0;
            }
            else if (cboGrup16.SelectedIndex == 3)
            {
                cboExerc16.Items.AddRange(exercTriceps);
                cboExerc16.SelectedIndex = 0;
            }
            else if (cboGrup16.SelectedIndex == 4)
            {
                cboExerc16.Items.AddRange(exercBiceps);
                cboExerc16.SelectedIndex = 0;
            }
            else if (cboGrup16.SelectedIndex == 5)
            {
                cboExerc16.Items.AddRange(exercPernas);
                cboExerc16.SelectedIndex = 0;
            }
            else if (cboGrup16.SelectedIndex == 6)
            {
                cboExerc16.Items.AddRange(exercPanturrilhas);
                cboExerc16.SelectedIndex = 0;
            }
            else if (cboGrup16.SelectedIndex == 7)
            {
                cboExerc16.Items.AddRange(exercAbdomen);
                cboExerc16.SelectedIndex = 0;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                DataTable dt1 = new DataTable();
                string vcpf = dgv.SelectedRows[0].Cells[2].Value.ToString();

                dt1 = DataConnection.ObterDadosCliente(vcpf);

                txtNomeClienteTreino.Text = dt1.Rows[0].Field<string>("NmCliente").ToString();
                maskCPFClienteTreino.Text = dt1.Rows[0].Field<string>("cpf").ToString();

            }
        }

        
    }
}
