﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_de_Imagens.Visao
{
    public partial class BarraDeCarregamento : Form
    {
        #region Atributos e Propriedades

        int total = 0;
        
        #endregion Atributos e Propriedades

        #region Construtores

        public BarraDeCarregamento(int total)
        {
            this.total = total;
            InitializeComponent();
            InicializaForm();
        }

        #endregion Construtores

        #region Métodos

        public void InicializaForm()
        {
            AtualizaLabel();
            pgb_progresso.Maximum = total;
        }

        /// <summary>
        /// Método que atualiza a label em tela
        /// </summary>
        public void AtualizaLabel()
        {
            this.lbl_valor.Text = "Total: " + total.ToString();
        }

        /// <summary>
        /// Método que faz a barra avançar em valor vezes
        /// </summary>
        /// <param name="valor"></param>
        public void AvancaBarra(int valor)
        {
            pgb_progresso.Increment(valor);
        }

        #endregion Métodos
    }
}
