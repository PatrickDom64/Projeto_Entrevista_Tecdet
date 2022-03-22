using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Projeto_Entrevista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void bt_Abrir_Click(object sender, EventArgs e)
        {
            AbrirArquivo();
        }
        public void AbrirArquivo()
        {
            //Abrir o openfiledialog
            openFileDialog1.Title = "Abrir Arquivo";
            openFileDialog1.InitialDirectory = @"C:\Users\patrick.silva\Documents\Jsons";
            openFileDialog1.Filter = "json files (*.json) | *json| All files (*.*)|*.*";

            DialogResult dr = openFileDialog1.ShowDialog();

            //Ler o arquivo selecionado
            StreamReader r = new StreamReader(openFileDialog1.FileName);
            string jsonString = r.ReadToEnd();

            //Mostrar o arquivo bruto json e o caminho do diretorio para o textBox(tx_dir)
            tx_mostrarJsonBruto.Text = jsonString.ToString();
            tx_dir.Text = openFileDialog1.InitialDirectory.ToString();

            //Desserialização Json
            Passagem passagemDesserializacao = JsonConvert.DeserializeObject<Passagem>(jsonString);

            //Mostrar itens desserializado
            tx_Placa.Text = passagemDesserializacao.Placa;
            tx_Data.Text = passagemDesserializacao.Data;
            tx_Hora.Text = passagemDesserializacao.Hora;
            tx_Equipamento.Text = passagemDesserializacao.Equipamento.ToString();
            tx_Faixa.Text = passagemDesserializacao.Faixa.ToString();
        }

        public void bt_Enviar_Click(object sender, EventArgs e)
        {
            //Passando o Json Desserializado para o Banco
            Passagem passagem = new Passagem(tx_Placa.Text, tx_Data.Text, tx_Hora.Text, Convert.ToInt32(tx_Equipamento.Text), Convert.ToInt32(tx_Faixa.Text));
            Banco.InserirPassagem(passagem);

            //Labels recebendo os contadores de passagens lidas e não lidas
            Lb_Lido.Text = GlobalContador.lido.ToString();
            Lb_NãoLido.Text = GlobalContador.naoLido.ToString();
        }

    }
}
