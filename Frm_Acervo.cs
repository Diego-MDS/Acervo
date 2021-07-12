using System;
using System.Windows.Forms;
using Acervo.UseControlForms;
using Acervo.Classes;

namespace Acervo
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Btn_Gaveta_01_Click(object sender, EventArgs e)
        {
            Pnl_Conteudo.Controls.Clear();
            var fichaLivro = new UC_Livros();
            Pnl_Conteudo.Controls.Add(fichaLivro);
            Text = "Acervo - Livros";
        }

        private void Btn_Gaveta_02_Click(object sender, EventArgs e)
        {
            Pnl_Conteudo.Controls.Clear();
            var fichaHq = new UC_Hqs();
            Pnl_Conteudo.Controls.Add(fichaHq);
            Text = "Acervo - Hqs";
        }

        private void Btn_Gaveta_03_Click(object sender, EventArgs e)
        {
            Pnl_Conteudo.Controls.Clear();
            var fichaManga = new UC_Mangas();
            Pnl_Conteudo.Controls.Add(fichaManga);
            Text = "Acervo - Mangá";
        }

        private void Btn_Gaveta_04_Click(object sender, EventArgs e)
        {
            Pnl_Conteudo.Controls.Clear();
            var fichaJogoTabuleiro = new UC_JogosDeTabuleiro();
            Pnl_Conteudo.Controls.Add(fichaJogoTabuleiro);
            Text = "Acervo - Jogos de Tabuleiro";
        }

        private void Btn_Gaveta_05_Click(object sender, EventArgs e)
        {
            Pnl_Conteudo.Controls.Clear();
            var fichaJogoDeVideoGame = new UC_JogosDeVideoGame();
            Pnl_Conteudo.Controls.Add(fichaJogoDeVideoGame);
            Text = "Acervo - Jogos de Video Game";
        }

        private void Tsb_Abrir_Click(object sender, EventArgs e)
        {
            if (Pnl_Conteudo.Controls != null && Pnl_Conteudo.Controls.Count > 0)
            {
                var abrir = Pnl_Conteudo.Controls[0] as IFerramentas;
                if (abrir != null)
                {
                    abrir.AbrirFicha();
                }
            }
        }

        private void Tsb_Salvar_Click(object sender, EventArgs e)
        {
            if (Pnl_Conteudo.Controls != null && Pnl_Conteudo.Controls.Count > 0)
            {
                var salvar = Pnl_Conteudo.Controls[0] as IFerramentas;
                if (salvar != null)
                {
                    salvar.SalvarFicha();
                }
            }
        }

        private void Tsb_Alterar_Click(object sender, EventArgs e)
        {
            if (Pnl_Conteudo.Controls != null && Pnl_Conteudo.Controls.Count > 0)
            {
                var alterar = Pnl_Conteudo.Controls[0] as IFerramentas;
                if (alterar != null)
                {
                    alterar.AlterarFicha();
                }
            }
        }

        private void Tsb_Apagar_Click(object sender, EventArgs e)
        {
            if (Pnl_Conteudo.Controls != null && Pnl_Conteudo.Controls.Count > 0)
            {
                var apagar = Pnl_Conteudo.Controls[0] as IFerramentas;
                if (apagar != null)
                {
                    apagar.ApagarFicha();
                }
            }
        }

        private void Tsb_Busca_Click(object sender, EventArgs e)
        {
            if (Pnl_Conteudo.Controls != null && Pnl_Conteudo.Controls.Count > 0)
            {
                var buscar = Pnl_Conteudo.Controls[0] as IFerramentas;
                if (buscar != null)
                {
                    buscar.BuscarFichas();
                }
            }
        }

        private void Tsb_Recortar_Click(object sender, EventArgs e)
        {
            if (Pnl_Conteudo.Controls != null && Pnl_Conteudo.Controls.Count > 0)
            {
                IFerramentas recortar = Pnl_Conteudo.Controls[0] as IFerramentas;
                if (recortar != null)
                {
                    recortar.Recortar();
                }
            }
        }

        private void Tsb_Copiar_Click(object sender, EventArgs e)
        {
            if (Pnl_Conteudo.Controls != null && Pnl_Conteudo.Controls.Count > 0)
            {
                var copiar = Pnl_Conteudo.Controls[0] as IFerramentas;
                if (copiar != null)
                {
                    copiar.Copiar();
                }
            }
        }

        private void Tsb_Colar_Click(object sender, EventArgs e)
        {
            var colar = Pnl_Conteudo.Controls[0] as IFerramentas;
            if (colar != null)
            {
                colar.Colar();
            }
        }

        private void Tsb_Limpar_Click(object sender, EventArgs e)
        {
            if(Pnl_Conteudo.Controls != null && Pnl_Conteudo.Controls.Count > 0)
            {
                var limpa = Pnl_Conteudo.Controls[0] as IFerramentas;
                if(limpa != null)
                {
                    limpa.LimparCampos();
                }
            }
        }

        private void Tsb_Fechar_Click(object sender, EventArgs e)
        {
            if(Pnl_Conteudo.Controls != null)
            {
                Pnl_Conteudo.Controls.Clear();
                Text = "Acervo";
            }
        }
    }
}

