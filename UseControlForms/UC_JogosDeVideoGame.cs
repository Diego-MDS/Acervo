using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Acervo.Classes;
using System.Data;

namespace Acervo.UseControlForms
{
    public partial class UC_JogosDeVideoGame : UserControl, IFerramentas
    {
        public UC_JogosDeVideoGame()
        {
            InitializeComponent();

            Cmb_Midia.Items.Clear();
            Cmb_Midia.Items.Add("Física");
            Cmb_Midia.Items.Add("Digital");

            Cmb_Plataforma.Items.Clear();
            Cmb_Plataforma.Items.Add("PS2");
            Cmb_Plataforma.Items.Add("PS3");
            Cmb_Plataforma.Items.Add("PC");

            LimparCampos();
        }

        readonly MySqlConnection conexao = new MySqlConnection("server = localhost; port = 3306; user id = acervo; database = acervo; password = acervo");

        public void AbrirFicha()
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand("SELECT ID, Titulo, Genero, Colecao, Midia, Plataforma, Desenvolvedora, Publicador, Proprietario, Observacoes FROM jogosdevideogame WHERE ID = ?", conexao);
                comando.Parameters.Clear();
                comando.Parameters.Add("@ID", MySqlDbType.Int64, 15).Value = Txt_Id.Text;

                MySqlDataReader resultado = comando.ExecuteReader();
                resultado.Read();

                Txt_Id.Text = resultado.GetInt64(0).ToString();
                Txt_Titulo.Text = resultado.GetString(1);
                Txt_Genero.Text = resultado.GetString(2);
                Txt_Colecao.Text = resultado.GetString(3);
                Cmb_Midia.Text = resultado.GetString(4);
                Cmb_Plataforma.Text = resultado.GetString(5);
                Txt_Desenvolvedora.Text = resultado.GetString(6);
                Txt_Publicador.Text = resultado.GetString(7);
                string proprietario = resultado.GetString(8);
                if (proprietario == "D")
                {
                    Rdb_D.Checked = true;
                }
                if (proprietario == "R")
                {
                    Rdb_R.Checked = true;
                }
                if (proprietario == "T")
                {
                    Rdb_T.Checked = true;
                }
                Txt_Observacoes.Text = resultado.GetString(9);

                conexao.Close();

                MessageBox.Show($"Ficha {Txt_Id.Text} localizada!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show($"Ficha {Txt_Id.Text} não localizada!");
            }
        }

        public void SalvarFicha()
        {
            string proprietario = "";

            if (Rdb_D.Checked == true)
            {
                proprietario = "D";
            }
            if (Rdb_R.Checked == true)
            {
                proprietario = "R";
            }
            if (Rdb_T.Checked == true)
            {
                proprietario = "T";
            }

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand("INSERT INTO jogosdevideogame (ID, Titulo, Genero, Colecao, Midia, Plataforma, Desenvolvedora, Publicador, Proprietario, Observacoes) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", conexao);
                comando.Parameters.Add("@ID", MySqlDbType.Int64, 15).Value = Txt_Id.Text;
                comando.Parameters.Add("@Titulo", MySqlDbType.VarChar, 75).Value = Txt_Titulo.Text;
                comando.Parameters.Add("@Genero", MySqlDbType.VarChar, 50).Value = Txt_Genero.Text;
                comando.Parameters.Add("@Colecao", MySqlDbType.VarChar, 75).Value = Txt_Colecao.Text;
                comando.Parameters.Add("@Midia", MySqlDbType.VarChar, 75).Value = Cmb_Midia.Text;
                comando.Parameters.Add("@Plataforma", MySqlDbType.VarChar, 75).Value = Cmb_Plataforma.Text;
                comando.Parameters.Add("@Desenvolvedora", MySqlDbType.VarChar, 50).Value = Txt_Desenvolvedora.Text;
                comando.Parameters.Add("@Publicador", MySqlDbType.VarChar, 75).Value = Txt_Publicador.Text;
                comando.Parameters.Add("@Proprietario", MySqlDbType.VarChar, 1).Value = proprietario;
                comando.Parameters.Add("@Observacoes", MySqlDbType.VarChar, 150).Value = Txt_Observacoes.Text;
                comando.ExecuteNonQuery();

                conexao.Close();

                MessageBox.Show($"Ficha {Txt_Id.Text} arquivada com sucesso!");
            }
            catch
            {
                MessageBox.Show($"Erro no arquivamento da ficha {Txt_Id.Text}!");
            }
        }

        public void AlterarFicha()
        {
            string proprietario = "";

            if (Rdb_D.Checked == true)
            {
                proprietario = "D";
            }
            if (Rdb_R.Checked == true)
            {
                proprietario = "R";
            }
            if (Rdb_T.Checked == true)
            {
                proprietario = "T";
            }

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand("UPDATE jogosdevideogame SET Titulo = ?, Genero = ?, Colecao = ?, Midia = ?, Plataforma = ?, Desenvolvedora = ?, Publicador = ?, Proprietario = ?, Observacoes = ? WHERE ID = ?", conexao);
                comando.Parameters.Add("@ID", MySqlDbType.Int64, 15).Value = Txt_Id.Text;
                comando.Parameters.Add("@Titulo", MySqlDbType.VarChar, 75).Value = Txt_Titulo.Text;
                comando.Parameters.Add("@Genero", MySqlDbType.VarChar, 50).Value = Txt_Genero.Text;
                comando.Parameters.Add("@Colecao", MySqlDbType.VarChar, 75).Value = Txt_Colecao.Text;
                comando.Parameters.Add("@Midia", MySqlDbType.VarChar, 75).Value = Cmb_Midia.Text;
                comando.Parameters.Add("@Plataforma", MySqlDbType.VarChar, 75).Value = Cmb_Plataforma.Text;
                comando.Parameters.Add("@Desenvolvedora", MySqlDbType.VarChar, 50).Value = Txt_Desenvolvedora.Text;
                comando.Parameters.Add("@Publicador", MySqlDbType.VarChar, 50).Value = Txt_Publicador.Text;
                comando.Parameters.Add("@Proprietario", MySqlDbType.VarChar, 1).Value = proprietario;
                comando.Parameters.Add("@Observacoes", MySqlDbType.VarChar, 150).Value = Txt_Observacoes.Text;
                comando.ExecuteNonQuery();

                conexao.Close();

                MessageBox.Show($"Ficha {Txt_Id.Text} atualizada com sucesso!");
            }
            catch
            {
                MessageBox.Show($"Erro na atualização da ficha {Txt_Id.Text}!");
            }
        }

        public void ApagarFicha()
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand("DELETE FROM jogosdevideogame WHERE ID = ?", conexao);
                comando.Parameters.Clear();
                comando.Parameters.Add("@ID", MySqlDbType.Int64, 15).Value = Txt_Id.Text;
                comando.ExecuteNonQuery();

                conexao.Close();

                LimparCampos();

                MessageBox.Show($"Ficha {Txt_Id.Text} removida com sucesso!");
            }
            catch
            {
                MessageBox.Show($"Erro na remoção da ficha {Txt_Id.Text}!");
            }
        }

        public void BuscarFichas()
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand("SELECT ID, Titulo, Genero, Plataforma FROM jogosdevideogame WHERE ID LIKE ? OR Titulo LIKE ? OR Genero LIKE ? OR Colecao LIKE ? OR Midia LIKE ? OR Plataforma LIKE ? OR Desenvolvedora LIKE ? OR Publicador LIKE ? OR Proprietario LIKE ? OR Observacoes LIKE ?", conexao);
                comando.Parameters.Clear();

                if (Txt_Id.Text != "")
                {
                    comando.Parameters.Add("@ID", MySqlDbType.VarChar, 15).Value = '%' + Txt_Id.Text + '%';
                }
                else
                {
                    comando.Parameters.Add("@ID", MySqlDbType.VarChar, 15).Value = null;
                }
                if (Txt_Titulo.Text != "")
                {
                    comando.Parameters.Add("@Titulo", MySqlDbType.VarChar, 75).Value = '%' + Txt_Titulo.Text + '%';
                }
                else
                {
                    comando.Parameters.Add("@Titulo", MySqlDbType.VarChar, 75).Value = null;
                }
                if (Txt_Genero.Text != "")
                {
                    comando.Parameters.Add("@Genero", MySqlDbType.VarChar, 75).Value = '%' + Txt_Genero.Text + '%';
                }
                else
                {
                    comando.Parameters.Add("@Genero", MySqlDbType.VarChar, 75).Value = null;
                }
                if (Txt_Colecao.Text != "")
                {
                    comando.Parameters.Add("@Colecao", MySqlDbType.VarChar, 75).Value = '%' + Txt_Colecao.Text + '%';
                }
                else
                {
                    comando.Parameters.Add("@Colecao", MySqlDbType.VarChar, 75).Value = null;
                }
                if (Cmb_Midia.Text != "")
                {
                    comando.Parameters.Add("@Midia", MySqlDbType.VarChar, 75).Value = '%' + Cmb_Midia.Text + '%';
                }
                else
                {
                    comando.Parameters.Add("@Midia", MySqlDbType.VarChar, 75).Value = null;
                }
                if (Cmb_Plataforma.Text != "")
                {
                    comando.Parameters.Add("@Plataforma", MySqlDbType.VarChar, 11).Value = '%' + Cmb_Plataforma.Text + '%';
                }
                else
                {
                    comando.Parameters.Add("@Plataforma", MySqlDbType.VarChar, 11).Value = null;
                }
                if (Txt_Desenvolvedora.Text != "")
                {
                    comando.Parameters.Add("@Desenvolvedora", MySqlDbType.VarChar, 50).Value = '%' + Txt_Desenvolvedora.Text + '%';
                }
                else
                {
                    comando.Parameters.Add("@Desenvolvedora", MySqlDbType.VarChar, 50).Value = null;
                }
                if (Txt_Publicador.Text != "")
                {
                    comando.Parameters.Add("@Publicador", MySqlDbType.VarChar, 11).Value = '%' + Txt_Publicador.Text + '%';
                }
                else
                {
                    comando.Parameters.Add("@Publicador", MySqlDbType.VarChar, 11).Value = null;
                }
                string proprietario = "";
                if (Rdb_D.Checked == true)
                {
                    proprietario = "D";
                }
                if (Rdb_R.Checked == true)
                {
                    proprietario = "R";
                }
                if (Rdb_T.Checked == true)
                {
                    proprietario = "T";
                }
                if (proprietario != "")
                {
                    comando.Parameters.Add("@Proprietario", MySqlDbType.VarChar, 1).Value = '%' + proprietario + '%';
                }
                else
                {
                    comando.Parameters.Add("@Proprietario", MySqlDbType.VarChar, 1).Value = null;
                }
                if (Txt_Observacoes.Text != "")
                {
                    comando.Parameters.Add("@Observacoes", MySqlDbType.VarChar, 150).Value = '%' + Txt_Observacoes.Text + '%';
                }
                else
                {
                    comando.Parameters.Add("@Observacoes", MySqlDbType.VarChar, 150).Value = null;
                }

                MySqlDataAdapter busca = new MySqlDataAdapter(comando);

                DataTable resultado = new DataTable();
                busca.Fill(resultado);
                Dgv_Busca.DataSource = resultado;
                Dgv_Busca.Columns[0].Visible = false;

                comando.ExecuteNonQuery();

                conexao.Close();

                LimparCampos();

                MessageBox.Show("Possíveis fichas localizadas!");
            }
            catch
            {
                MessageBox.Show("Nenhuma ficha foi localizada!");
            }

        }

        private void Dgv_Busca_DoubleClick(object sender, EventArgs e)
        {
            Txt_Id.Text = Dgv_Busca.CurrentRow.Cells[0].Value.ToString();
            AbrirFicha();
        }

        private TextBox texto;

        void Foco()
        {
            if (Txt_Id.Focused == true)
            {
                texto = Txt_Id;
            }
            if (Txt_Titulo.Focused == true)
            {
                texto = Txt_Titulo;
            }
            if (Txt_Genero.Focused == true)
            {
                texto = Txt_Genero;
            }
            if (Txt_Colecao.Focused == true)
            {
                texto = Txt_Colecao;
            }
            if (Txt_Desenvolvedora.Focused == true)
            {
                texto = Txt_Desenvolvedora;
            }
            if (Txt_Publicador.Focused == true)
            {
                texto = Txt_Publicador;
            }
            if (Txt_Observacoes.Focused == true)
            {
                texto = Txt_Observacoes;
            }
        }

        public void Recortar()
        {
            Foco();
            if (texto.SelectedText.Length > 0)
            {
                texto.Cut();
            }
        }

        public void Copiar()
        {
            Foco();
            if (texto.SelectedText.Length > 0)
            {
                texto.Copy();
            }
        }

        public void Colar()
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                Foco();
                texto.Paste();
            }
        }

        public void LimparCampos()
        {
            Txt_Id.Text = "";
            Txt_Titulo.Text = "";
            Txt_Genero.Text = "";
            Txt_Colecao.Text = "";
            Cmb_Midia.Text = "";
            Cmb_Plataforma.Text = "";
            Txt_Desenvolvedora.Text = "";
            Txt_Publicador.Text = "";
            Txt_Observacoes.Text = "";
            Rdb_D.Checked = false;
            Lbl_D.Enabled = true;
            Rdb_R.Checked = false;
            Lbl_R.Enabled = true;
            Rdb_T.Checked = false;
            Lbl_T.Enabled = true;
        }

        private void Rdb_D_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_D.Checked)
            {
                Lbl_D.Enabled = true;
                Lbl_R.Enabled = false;
                Lbl_T.Enabled = false;
            }
        }

        private void Rdb_R_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_R.Checked)
            {
                Lbl_R.Enabled = true;
                Lbl_D.Enabled = false;
                Lbl_T.Enabled = false;
            }
        }

        private void Rdb_T_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_T.Checked)
            {
                Lbl_T.Enabled = true;
                Lbl_D.Enabled = false;
                Lbl_R.Enabled = false;
            }
        }
    }
}
