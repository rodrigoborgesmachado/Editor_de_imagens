using Editor_de_Imagens.Visao;
using ImageMagick;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_de_Imagens
{
    public partial class Form1 : Form
    {
        #region Atributos e propriedades

        public string caminhoSaida = AppDomain.CurrentDomain.BaseDirectory.ToString() + "OUT\\";

        public int sucesso = 0, erro = 0;

        public List<string> lista_errados = new List<string>();
        public List<string> lista_errados_motivo = new List<string>();

        #endregion Atributos e propriedades

        #region Eventos

        /// <summary>
        /// Evento chamado quando se digita nos campos width e height
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Txb_estoqueProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Evento chamado quando se clica no botão para tratar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_trata_Click(object sender, EventArgs e)
        {
            TrataImagens();
        }

        /// <summary>
        /// Evento chamado quando se clica no botão para selecionar o diretório da pasta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_folder_Click(object sender, EventArgs e)
        {
            OpenDirectoryFile();
        }

        #endregion Eventos

        #region Constutores

        public Form1()
        {
            InitializeComponent();
        }

        #endregion Constutores

        #region Métodos 

        /// <summary>
        /// Método que abre diálogo para seleção do caminho das imagens
        /// </summary>
        public void OpenDirectoryFile()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                this.tbx_folder.Text = dialog.SelectedPath.ToString();
            }
        }

        /// <summary>
        /// Método que verifica se o caminho selecionado existe
        /// </summary>
        /// <param name="caminho">Caminho</param>
        /// <returns>True - Existe; False - Não existe</returns>
        public bool ValidaPath(string caminho, out string mensagem)
        {
            mensagem = "";
            if (string.IsNullOrEmpty(caminho))
            {
                mensagem = "Campo de caminho vazio!";
                return false;
            }

            if(string.IsNullOrEmpty(tbx_height.Text))
            {
                mensagem = "Campo de height vazio!";
                return false;
            }

            if (string.IsNullOrEmpty(tbx_width.Text))
            {
                mensagem = "Campo de width vazio!";
                return false;
            }

            try
            {
                bool retorno = System.IO.Directory.Exists(caminho);
                if (!retorno) mensagem = "Diretório " + caminho + "não existe";
                return retorno;
            }
            catch(Exception e)
            {
                mensagem = "Diretório " + caminho + "não existe";
                return false;
            }
        }

        /// <summary>
        /// Método que faz o tratamento da imagem
        /// </summary>
        public void TrataImagens()
        {
            string men = "";

            if (!ValidaPath(tbx_folder.Text, out men))
            {
                MessageBox.Show(men,"Atenção");
                return;
            }

            DirectoryInfo directory = new DirectoryInfo(tbx_folder.Text);
            string mensagemErro = "";

            this.Hide();
            int total = 0;
            foreach (FileInfo arq in directory.GetFiles())
            {
                if (arq.Extension == ".jpg" || arq.Extension == ".JPG" || arq.Extension == ".png" || arq.Extension == ".PNG")
                {
                    total++;
                }
            }
            BarraDeCarregamento tela = new BarraDeCarregamento(total);
            tela.Show();

            directory = null;
            directory = new DirectoryInfo(tbx_folder.Text);
            
            foreach (FileInfo arq in directory.GetFiles())
            {
                if (arq.Extension == ".jpg" || arq.Extension == ".JPG" || arq.Extension == ".png" || arq.Extension == ".PNG")
                {
                    tela.AvancaBarra(1);

                    if (TrataImagem(arq, 
                                    int.Parse(tbx_width.Text), 
                                    int.Parse(tbx_height.Text), 
                                    ckb_transparent.Checked, 
                                    ref mensagemErro))
                    {
                        sucesso++;
                    }
                    else
                    {
                        erro++;
                        lista_errados.Add(arq.FullName);
                        lista_errados_motivo.Add(mensagemErro);
                    }
                }
            }
            tela.Close();
            tela.Dispose();
            this.Show();
            string mensagem = "Total: " + (sucesso + erro).ToString() + "\n\n";
            mensagem+= "Imagens Tratadas: " + sucesso + "\n\n";

            foreach (string mens in lista_errados)
                mensagem += "Imagens com erro: " + mens;

            MessageBox.Show(mensagem);
            
        }

        /// <summary>
        /// Método que trata a imagem e copia para a pasta de saída
        /// </summary>
        /// <param name="arq">Imagem a ser editada</param>
        /// <param name="width">Define  o Width da imagem de saída</param>
        /// <param name="height">Define o height da imagem de saída</param>
        /// <param name="transparent">Identifica se deve deixar a imagem com o fundo transparent ou não</param>
        /// <returns>True - Sucesso; False - Erro</returns>
        public bool TrataImagem(FileInfo arq, int width, int height, bool transparent, ref string mensagemErro)
        {
            mensagemErro = "";
            try
            {
                ImageMagick.MagickImage img = new ImageMagick.MagickImage(arq);

                if (transparent)
                {
                    img.ColorFuzz = new Percentage(10);
                    // -transparent white
                    img.Transparent(MagickColors.White);
                }

                img.Resize(width, height);
                img.Write(caminhoSaida + arq.Name.Replace(".", width.ToString() + "x" + height.ToString() + ".").Replace(".jpg", ".png"));

                return true;
            }
            catch(Exception e)
            {
                mensagemErro = "Erro ao tratar a imagem " + arq.FullName + ". Erro " + e.Message;
                return false;
            }
        }

        #endregion Métodos 
    }
}
