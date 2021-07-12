using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Acervo.Classes;
using System.Data;

namespace Acervo.UseControlForms
{
    public partial class UC_Mangas : UserControl, IFerramentas
    {
        public UC_Mangas()
        {
            InitializeComponent();
            LimparCampos();
        }

        readonly MySqlConnection conexao = new MySqlConnection("server = localhost; port = 3306; user id = acervo; database = acervo; password = acervo");

        public void AbrirFicha()
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand("SELECT ID, Titulo, Subtitulo, Colecao, Autor, Volume, Unico, Editora, Genero, Edicao, Proprietario, Observacoes FROM mangas WHERE ID = ?", conexao);
                comando.Parameters.Clear();
                comando.Parameters.Add("@ID", MySqlDbType.Int64, 15).Value = Txt_Id.Text;

                MySqlDataReader resultado = comando.ExecuteReader();
                resultado.Read();

                Txt_Id.Text = resultado.GetInt64(0).ToString();
                Txt_Titulo.Text = resultado.GetString(1);
                Txt_Subtitulo.Text = resultado.GetString(2);
                Txt_Colecao.Text = resultado.GetString(3);
                Txt_Autor.Text = resultado.GetString(4);
                Txt_Volume.Text = resultado.GetInt32(5).ToString();
                Chk_VolumeUnico.Checked = resultado.GetBoolean(6);
                Txt_Editora.Text = resultado.GetString(7);
                Txt_Genero.Text = resultado.GetString(8);
                Txt_Edicao.Text = resultado.GetInt32(9).ToString();
                string proprietario = resultado.GetString(10);
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
                Txt_Observacoes.Text = resultado.GetString(11);

                conexao.Close();

                MessageBox.Show($"Ficha {Txt_Id.Text} localizada!");
            }
            catch
            {
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

                MySqlCommand comando = new MySqlCommand("INSERT INTO mangas (ID, Titulo, Subtitulo, Colecao, Autor, Volume, Unico, Editora, Genero, Edicao, Proprietario, Observacoes) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", conexao);
                comando.Parameters.Add("@ID", MySqlDbType.Int64, 15).Value = Txt_Id.Text;
                comando.Parameters.Add("@Titulo", MySqlDbType.VarChar, 75).Value = Txt_Titulo.Text;
                comando.Parameters.Add("@Subtitulo", MySqlDbType.VarChar, 75).Value = Txt_Subtitulo.Text;
                comando.Parameters.Add("@Colecao", MySqlDbType.VarChar, 75).Value = Txt_Colecao.Text;
                comando.Parameters.Add("@Autor", MySqlDbType.VarChar, 75).Value = Txt_Autor.Text;
                comando.Parameters.Add("@Volume", MySqlDbType.Int16, 2).Value = Txt_Volume.Text;
                comando.Parameters.Add("@Unico", MySqlDbType.Int16, 1).Value = Chk_VolumeUnico.Checked;
                comando.Parameters.Add("@Editora", MySqlDbType.VarChar, 50).Value = Txt_Editora.Text;
                comando.Parameters.Add("@Genero", MySqlDbType.VarChar, 50).Value = Txt_Genero.Text;
                comando.Parameters.Add("@Edicao", MySqlDbType.Int16, 2).Value = Txt_Edicao.Text;
                comando.Parameters.Add("@Proprietario", MySqlDbType.VarChar, 1).Value = proprietario;
                comando.Parameters.Add("@Observacoes", MySqlDbType.VarChar, 150).Value = Txt_Observacoes.Text;
                comando.ExecuteNonQuery();

                conexao.Close();

                MessageBox.Show($"Ficha {Txt_Id.Text} arquivada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                MySqlCommand comando = new MySqlCommand("UPDATE mangas SET Titulo = ?, Subtitulo = ?, Colecao = ?, Autor = ?, Volume = ?, Unico = ?, Editora = ?, Genero = ?, Edicao = ?, Proprietario = ?, Observacoes = ? WHERE ID = ?", conexao);
                comando.Parameters.Clear();
                comando.Parameters.Add("@Titulo", MySqlDbType.VarChar, 75).Value = Txt_Titulo.Text;
                comando.Parameters.Add("@Subtitulo", MySqlDbType.VarChar, 75).Value = Txt_Subtitulo.Text;
                comando.Parameters.Add("@Colecao", MySqlDbType.VarChar, 75).Value = Txt_Colecao.Text;
                comando.Parameters.Add("@Autor", MySqlDbType.VarChar, 75).Value = Txt_Autor.Text;
                comando.Parameters.Add("@Volume", MySqlDbType.Int16, 2).Value = Txt_Volume.Text;
                comando.Parameters.Add("@Unico", MySqlDbType.Int16, 1).Value = Chk_VolumeUnico.Checked;
                comando.Parameters.Add("@Editora", MySqlDbType.VarChar, 50).Value = Txt_Editora.Text;
                comando.Parameters.Add("@Genero", MySqlDbType.VarChar, 50).Value = Txt_Genero.Text;
                comando.Parameters.Add("@Edicao", MySqlDbType.Int16, 2).Value = Txt_Edicao.Text;
                comando.Parameters.Add("@Proprietario", MySqlDbType.VarChar, 1).Value = proprietario;
                comando.Parameters.Add("@Observacoes", MySqlDbType.VarChar, 150).Value = Txt_Observacoes.Text;
                comando.Parameters.Add("@ID", MySqlDbType.Int64, 15).Value = Txt_Id.Text;
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

                MySqlCommand comando = new MySqlCommand("DELETE FROM mangas WHERE ID = ?", conexao);
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

                MySqlCommand comando = new MySqlCommand("SELECT ID, Titulo, Subtitulo, Autor FROM mangas WHERE ID LIKE ? OR Titulo LIKE ? OR Subtitulo LIKE ? OR Colecao LIKE ? OR Autor LIKE ? OR Volume LIKE ? OR Unico LIKE ? OR Editora LIKE ? OR Genero LIKE ? OR Edicao LIKE ? OR Proprietario LIKE ? OR Observacoes LIKE ?", conexao);
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
                if (Txt_Subtitulo.Text != "")
                {
                    comando.Parameters.Add("@Subtitulo", MySqlDbType.VarChar, 75).Value = '%' + Txt_Subtitulo.Text + '%';
                }
                else
                {
                    comando.Parameters.Add("@Subtitulo", MySqlDbType.VarChar, 75).Value = null;
                }
                if (Txt_Colecao.Text != "")
                {
                    comando.Parameters.Add("@Colecao", MySqlDbType.VarChar, 75).Value = '%' + Txt_Colecao.Text + '%';
                }
                else
                {
                    comando.Parameters.Add("@Colecao", MySqlDbType.VarChar, 75).Value = null;
                }
                if (Txt_Autor.Text != "")
                {
                    comando.Parameters.Add("@Autor", MySqlDbType.VarChar, 75).Value = '%' + Txt_Autor.Text + '%';
                }
                else
                {
                    comando.Parameters.Add("@Autor", MySqlDbType.VarChar, 75).Value = null;
                }
                if (Txt_Volume.Text != "")
                {
                    comando.Parameters.Add("@Volume", MySqlDbType.VarChar, 2).Value = '%' + Txt_Volume.Text + '%';
                }
                else
                {
                    comando.Parameters.Add("@Volume", MySqlDbType.VarChar, 2).Value = null;
                }
                if (Chk_VolumeUnico.Checked)
                {
                    comando.Parameters.Add("@Unico", MySqlDbType.VarChar, 1).Value = '%' + "1" + '%';
                }
                else
                {
                    comando.Parameters.Add("@Unico", MySqlDbType.VarChar, 1).Value = '%' + "0" + '%';
                }
                if (Txt_Editora.Text != "")
                {
                    comando.Parameters.Add("@Editora", MySqlDbType.VarChar, 50).Value = '%' + Txt_Editora.Text + '%';
                }
                else
                {
                    comando.Parameters.Add("@Editora", MySqlDbType.VarChar, 50).Value = null;
                }
                if (Txt_Genero.Text != "")
                {
                    comando.Parameters.Add("@Genero", MySqlDbType.VarChar, 50).Value = '%' + Txt_Genero.Text + '%';
                }
                else
                {
                    comando.Parameters.Add("@Genero", MySqlDbType.VarChar, 50).Value = null;
                }
                if (Txt_Edicao.Text != "")
                {
                    comando.Parameters.Add("@Edicao", MySqlDbType.VarChar, 2).Value = '%' + Txt_Edicao.Text + '%';
                }
                else
                {
                    comando.Parameters.Add("@Edicao", MySqlDbType.VarChar, 2).Value = null;
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
            if (Txt_Subtitulo.Focused == true)
            {
                texto = Txt_Subtitulo;
            }
            if (Txt_Colecao.Focused == true)
            {
                texto = Txt_Colecao;
            }
            if (Txt_Autor.Focused == true)
            {
                texto = Txt_Autor;
            }
            if (Txt_Volume.Focused == true)
            {
                texto = Txt_Volume;
            }
            if (Txt_Editora.Focused == true)
            {
                texto = Txt_Editora;
            }
            if (Txt_Genero.Focused == true)
            {
                texto = Txt_Genero;
            }
            if (Txt_Edicao.Focused == true)
            {
                texto = Txt_Edicao;
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
            Txt_Subtitulo.Text = "";
            Txt_Volume.Text = "";
            Chk_VolumeUnico.Checked = false;
            Txt_Colecao.Text = "";
            Txt_Autor.Text = "";
            Txt_Editora.Text = "";
            Txt_Genero.Text = "";
            Txt_Edicao.Text = "";
            Txt_Observacoes.Text = "";
            Rdb_D.Checked = false;
            Lbl_D.Enabled = true;
            Rdb_R.Checked = false;
            Lbl_R.Enabled = true;
            Rdb_T.Checked = false;
            Lbl_T.Enabled = true;
        }

        private void Chk_VolumeUnico_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_VolumeUnico.Checked)
            {
                Lbl_Unico.Enabled = true;
                Txt_Volume.Enabled = false;
            }
            else
            {
                Lbl_Unico.Enabled = false;
                Txt_Volume.Enabled = true;
            }
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