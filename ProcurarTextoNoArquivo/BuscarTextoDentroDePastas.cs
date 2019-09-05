using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProcurarTextoNoArquivo
{
    public partial class BuscarTextoDentroDePastas : Form
    {
        List<ArquivoEncontrado> linhasEncontradas;
        public BuscarTextoDentroDePastas()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos()) return;
            linhasEncontradas = new List<ArquivoEncontrado>();
            dtgArquivos.Rows.Clear();

            var pastas = Directory.GetDirectories(txtCaminho.Text.Trim(), "*", SearchOption.AllDirectories);

            pastas = pastas.Where(p => !p.EndsWith("bin") 
            && !p.EndsWith("release") 
            && !p.EndsWith("Properties")
            && !p.EndsWith("obj")
            && !p.EndsWith("Debug")

            && !p.Contains("obj")
            && !p.Contains("bin")

            && !p.Contains(".svn")
            && !p.Contains(".vs")
            && !p.Contains("x86")
            && !p.Contains("packages")
            && !p.Contains("Office11")
            && !p.Contains("v16")).ToArray();

            foreach (var pasta in pastas)
            {
                ProcurarArquivos(pasta, txtProcura.Text.Trim());
            }

            //dtgArquivos.DataSource = linhasEncontradas;
            dtgArquivos.Refresh();
        }

        private bool ValidarCampos()
        {
            var notificacoes = new List<string>();

            if (String.IsNullOrWhiteSpace(txtCaminho.Text))
                notificacoes.Add("Caminho obrigatório para fazer a pesquisa");

            if (String.IsNullOrEmpty(txtProcura.Text))
                notificacoes.Add("Algum texto deve ser informado para pesquisar");

            if (!string.IsNullOrWhiteSpace(txtProcura.Text) && !Directory.Exists(txtCaminho.Text.Trim()))
                notificacoes.Add("Caminho informado não encontrado");

            if (notificacoes.Any()) MessageBox.Show(notificacoes.Aggregate((A, B) => A + ", " + B), "Avisos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return notificacoes.Any();
        }

        private void ProcurarArquivos(string caminho, string parametro)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(caminho);
                FileInfo[] files = directoryInfo.GetFiles();

                int atual = 0;
                int total = files.Count();

                string caminhoArquivo = string.Empty;
                StringBuilder sb;

                List<string> linhas;
                string linhaAlterada;

                foreach (var file in files)
                {
                    atual++;
                    caminhoArquivo = file.FullName;

                    Utilitarios.GeradorArquivo geradorArquivo = new Utilitarios.GeradorArquivo(caminhoArquivo);
                    sb = geradorArquivo.LerArquivoTextoStringBuilder();

                    linhas = TransformarEmLista(sb.ToString());
                    linhaAlterada = string.Empty;

                    foreach (var linha in linhas)
                    {
                        if (linha.ToUpper().Contains(parametro.ToUpper()))
                        {
                            //linhasEncontradas.Add(new ArquivoEncontrado(linha.Trim(), file.Name, linhas.IndexOf(linha) + 1, Path.GetExtension($"{caminho}\\{file}")));
                            dtgArquivos.Rows.Add(file.Name, linhas.IndexOf(linha) + 1, Path.GetExtension($"{caminho}\\{file}"), linha.Trim(), $"{caminho}\\{file}", VerificarDePara(linha.ToUpper()));
                            var teste = VerificarDePara(linha.ToUpper());
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }


            string VerificarDePara(string linha)
            {
                switch (VerificarContains(linha))
                {
                    case "ITEM": return "ITEM -> MERCADORIA";
                    case "VESSEL_DETAILS": return "VESSEL_DETAILS -> ESCALA";
                    case "VESSELDETAILS": return "VESSEL_DETAILS -> ESCALA";
                    case "VESVOYAGE": return "VES_VOYAGE -> ESCALA";
                    case "VES_VOYAGE": return "VES_VOYAGE -> ESCALA";
                    case "VESSEL": return "VESSEL -> NAVIO";
                    case "ITEM_REEFER": return "ITEM_REEFER -> MERCADORIA";                    
                    case "ITEM_SEAL": return "ITEM_SEAL -> AMR_LACRE_MERCADORIA";
                    case "ITEMSEAL": return "ITEM_SEAL -> AMR_LACRE_MERCADORIA";
                    case "ITEM_OOG": return "ITEM_OOG -> EXCESSO";
                    case "ITEMOOG": return "ITEM_OOG -> EXCESSO";
                    case "ITEM_LOCATION": return "ITEM_LOCATION -> AMR_LOCALIZACAO_MERCADORIA";
                    case "ITEMLOCATION": return "ITEM_LOCATION -> AMR_LOCALIZACAO_MERCADORIA";
                    case "BOOKINGS": return "BOOKINGS -> BOOKING + ITEM_BOOKING";
                    case "PORTCODE": return "PORTCODE -> PORTO";
                    default: return "";
                }
                
            }

            string VerificarContains(string linha)
            {
                var tabelasTops = new List<string>
                {
                    "VESVOYAGE",
                    "VES_VOYAGE",
                    "BOOKINGS",
                    "ITEM_REEFER",
                    "ITEM_SEAL",
                    "ITEMSEAL",
                    "ITEM_LOCATION",
                    "ITEMLOCATION",
                    "ITEM_OOG",
                    "ITEMOOG",
                    "ITEM",
                    "VESSEL_DETAILS",
                    "ITEM_REEFER",
                    "VESSEL",
                    "PORTCODE"
                };

                foreach (var tabelaTops in tabelasTops)
                {                                                                                                                                              
                    if (linha.Contains(tabelaTops))
                        return tabelaTops;
                }

                return "";
            }
        }

        private List<string> TransformarEmLista(string texto)
        {

            return texto.Replace("\n", "").Split('\r').ToList();
        }

        private void DtgArquivos_DoubleClick(object sender, EventArgs e)
        {
            try
            {                
                int indice = dtgArquivos.SelectedRows[0].Index;
                if (indice > -1)
                {
                    string arquivo = dtgArquivos.Rows[indice].Cells["CaminhoArquivo"].Value.ToString();
                    try
                    {
                        System.Diagnostics.Process.Start("notepad++", arquivo);
                    }
                    catch (Win32Exception)
                    {
                        System.Diagnostics.Process.Start("notepad", arquivo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    public class ArquivoEncontrado
    {
        public ArquivoEncontrado(string textoLinha, string nomeArquivo, int linha, string extensao)
        {
            TextoLinha = textoLinha;
            NomeArquivo = nomeArquivo;
            Linha = linha;
            Extensao = extensao;
        }

        public string TextoLinha { get; set; }
        public string NomeArquivo { get; set; }
        public int Linha { get; set; }
        public string Extensao { get; set; }
    }
}
