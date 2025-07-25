﻿using Editor_de_Imagens.Visao;
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
    public partial class FO_Principal : Form
    {
        #region Atributos e propriedades

        public string caminhoSaida;

        public int sucesso = 0, erro = 0;

        public List<string> lista_errados = new List<string>();
        public List<string> lista_errados_motivo = new List<string>();

        public enum TipoFolder
        {
            // Caminho de imput
            INPUT = 0,
            // Caminho de output
            OUTPUT = 1
        }

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
            OpenDirectoryFile(TipoFolder.INPUT);
        }

        /// <summary>
        /// Evento disparado no clique do botão de seleção de arquivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_file_Click(object sender, EventArgs e)
        {
            OpenFileSelected();
        }

        /// <summary>
        /// Evento chamado quando se clica no botão para selecionar o diretório da pasta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_folder_out_Click(object sender, EventArgs e)
        {
            OpenDirectoryFile(TipoFolder.OUTPUT);
        }

        #endregion Eventos

        #region Constutores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        public FO_Principal()
        {
            InitializeComponent();
            InicializaTela();
        }

        #endregion Constutores

        #region Métodos 

        /// <summary>
        /// Método que inicializa a tela
        /// </summary>
        public void InicializaTela()
        {
            this.cbx_tipos.SelectedIndex = 0;
            caminhoSaida = AppDomain.CurrentDomain.BaseDirectory.ToString() + "OUT";
            this.txb_folder_output.Text = caminhoSaida;
        }

        /// <summary>
        /// Método que abre a sel~eção de arquivo
        /// </summary>
        public void OpenFileSelected()
        {
            OpenFileDialog dialog_f = new OpenFileDialog();
            dialog_f.Title = "Seleção da imagem para alteração!";

            if (dialog_f.ShowDialog() == DialogResult.OK)
                this.tbx_file_in.Text = dialog_f.FileName.ToString();
        }

        /// <summary>
        /// Método que abre diálogo para seleção do caminho das imagens
        /// </summary>
        public void OpenDirectoryFile(TipoFolder tipo)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                if (tipo == TipoFolder.INPUT)
                    this.tbx_folder.Text = dialog.SelectedPath.ToString();
                else
                {
                    this.txb_folder_output.Text = dialog.SelectedPath.ToString();
                    caminhoSaida = dialog.SelectedPath.ToString();
                }
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

            if(string.IsNullOrEmpty(tbx_height.Text) && !this.ckb_criarImagensPadrao.Checked)
            {
                mensagem = "Campo de height vazio!";
                return false;
            }

            if (string.IsNullOrEmpty(tbx_width.Text) && !this.ckb_criarImagensPadrao.Checked)
            {
                mensagem = "Campo de width vazio!";
                return false;
            }

            try
            {
                bool retorno = System.IO.Directory.Exists(caminho);
                if (!retorno)
                {
                    retorno = File.Exists(caminho);
                    if (!retorno)
                    {
                        mensagem = "Diretório " + caminho + "não existe";
                    }
                }

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

            if (!ValidaPath(string.IsNullOrEmpty(tbx_folder.Text) ? tbx_file_in.Text : tbx_folder.Text, out men))
            {
                MessageBox.Show(men,"Atenção");
                return;
            }

            List<FileInfo> files = new List<FileInfo>();
            if (!string.IsNullOrEmpty(tbx_folder.Text))
            {
                DirectoryInfo directory = new DirectoryInfo(tbx_folder.Text);
                files = directory.GetFiles().ToList();
            }
            if (!string.IsNullOrEmpty(tbx_file_in.Text))
            {
                files.Add(new FileInfo(tbx_file_in.Text));
            }
            
            string mensagemErro = "";

            this.Hide();
            int total = 0;
            foreach (FileInfo arq in files)
            {
                if (arq.Extension == ".jpg" || arq.Extension == ".JPG" || 
                    arq.Extension == ".png" || arq.Extension == ".PNG" ||
                    arq.Extension == ".jpeg" || arq.Extension == ".JPEG" ||
                    arq.Extension == ".ico" || arq.Extension == ".ICO")
                {
                    total++;
                }
            }

            BarraDeCarregamento tela = new BarraDeCarregamento(total);
            tela.Show();

            sucesso = erro = 0;
            foreach (FileInfo arq in files)
            {
                if (arq.Extension == ".jpg" || arq.Extension == ".JPG" ||
                    arq.Extension == ".png" || arq.Extension == ".PNG" ||
                    arq.Extension == ".jpeg" || arq.Extension == ".JPEG" ||
                    arq.Extension == ".ico" || arq.Extension == ".ICO")
                {
                    tela.AvancaBarra(1);

                    if (ckb_criarImagensPadrao.Checked)
                    {
                        if (TrataImagemPadrao(arq, ref mensagemErro))
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
                    else
                    {
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
            }

            tela.Close();
            tela.Dispose();
            total = 0;
            this.Show();
            string mensagem = "Total: " + (sucesso + erro).ToString() + "\n\n";
            mensagem+= "Imagens Tratadas: " + sucesso + "\n\n";

            foreach (string mens in lista_errados)
                mensagem += "Imagens com erro: " + mens;

            MessageBox.Show(mensagem);
        }

        public bool TrataImagemPadrao(FileInfo arq, ref string mensagemErro)
        {
            bool retorno = true;

            retorno &= TrataImagem(arq, 600, 800, false, arq.Name.Split('.')[0] + "-large.png", ref mensagemErro);
            retorno &= TrataImagem(arq, 600, 800, false, arq.Name.Split('.')[0] + "-large.webp", ref mensagemErro);
            retorno &= TrataImagem(arq, 200, 270, false, arq.Name.Split('.')[0] + "-medium.png", ref mensagemErro);
            retorno &= TrataImagem(arq, 200, 270, false, arq.Name.Split('.')[0] + "-medium.webp", ref mensagemErro);
            retorno &= TrataImagem(arq, false, arq.Name.Split('.')[0] + "-original.png", ref mensagemErro);
            retorno &= TrataImagem(arq, false, arq.Name.Split('.')[0] + "-original.webp", ref mensagemErro);
            retorno &= TrataImagem(arq, 53, 74, false, arq.Name.Split('.')[0] + "-small.png", ref mensagemErro);
            retorno &= TrataImagem(arq, 53, 74, false, arq.Name.Split('.')[0] + "-small.webp", ref mensagemErro);

            return retorno;
        }

        /// <summary>
        /// Método que trata a imagem e copia para a pasta de saída
        /// </summary>
        /// <param name="arq">Imagem a ser editada</param>
        /// <param name="saida">nome do arquivo de saída</param>
        /// <param name="transparent">Identifica se deve deixar a imagem com o fundo transparent ou não</param>
        /// <returns>True - Sucesso; False - Erro</returns>
        public bool TrataImagem(FileInfo arq, bool transparent, string saida, ref string mensagemErro)
        {
            return TrataImagem(arq, 0, 0, transparent, saida, ref mensagemErro);
        }

        /// <summary>
        /// Método que trata a imagem e copia para a pasta de saída
        /// </summary>
        /// <param name="arq">Imagem a ser editada</param>
        /// <param name="width">Define  o Width da imagem de saída</param>
        /// <param name="height">Define o height da imagem de saída</param>
        /// <param name="saida">nome do arquivo de saída</param>
        /// <param name="transparent">Identifica se deve deixar a imagem com o fundo transparent ou não</param>
        /// <returns>True - Sucesso; False - Erro</returns>
        public bool TrataImagem(FileInfo arq, int width, int height, bool transparent, string saida, ref string mensagemErro)
        {
            mensagemErro = "";
            try
            {
                MagickImage img = new MagickImage(arq);

                if (transparent)
                {
                    img.ColorFuzz = new Percentage(10);
                    // -transparent white
                    img.Transparent(MagickColors.White);
                }

                if(width > 0)
                {
                    img.Resize((uint)width, (uint)height);
                }

                img.Write(caminhoSaida + "\\" + saida);

                return true;
            }
            catch (Exception e)
            {
                mensagemErro = "Erro ao tratar a imagem " + arq.FullName + ". Erro " + e.Message;
                return false;
            }
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
            return TrataImagem(arq, width, height, transparent, arq.Name.Replace(arq.Extension, width.ToString() + "x" + height.ToString()) + cbx_tipos.SelectedItem.ToString(), ref mensagemErro);
        }

        #endregion Métodos 
    }
}
