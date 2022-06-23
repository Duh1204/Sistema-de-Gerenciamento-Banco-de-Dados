using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=DUDZ;Initial Catalog=master;Integrated Security=True");
        SqlCommand cmd;
        public static int default_vagas = 50;
        public static int preco = 5;
        public static int vagas = 50;

        public Form1()
        {
            InitializeComponent();
            lblvagas.Text = vagas.ToString();
        }

        /// <summary>
        /// Captura o conteúdo do textbox placa e cria uma instância da classe Carro
        /// <summary>
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (vagas != 0 && txtboxplaca.Text!="")
            {
                Carro carro = new Carro();
                carro.Registrar_carro(listView1, txtboxplaca.Text);                
                lblvagas.Text = vagas.ToString();
            }
            else
            {
                MessageBox.Show("Vaga indisponível");
            }
        }

        /// <summary>
        /// Saída de veículos e cálculo de preço
        /// <summary>
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem selected_item = listView1.SelectedItems[0];
            DateTime hora_entrada = Convert.ToDateTime(selected_item.SubItems[2].Text);
            TimeSpan permanencia = DateTime.Now - hora_entrada;
            double horas = Math.Ceiling(permanencia.TotalHours);
            double preco = horas * Form1.preco;

            if (preco > 0 && selected_item.SubItems[6].Text=="sim")
            {
                MessageBox.Show("Será cobrado " + preco + ",00 reais");
                selected_item.SubItems[3].Text = DateTime.Now.ToString();
                selected_item.SubItems[4].Text = permanencia.ToString("d'd 'hh'h 'mm'm 'ss's'");
                selected_item.SubItems[5].Text = preco.ToString() + ",00";
                selected_item.SubItems[6].Text = "não";
                vagas++;
                lblvagas.Text = vagas.ToString();
                conn.Open();
                cmd = new SqlCommand("UPDATE lista_carro set hora_saida=@hora_saida, permanencia=@permanencia, valor_cobrado=@valor_cobrado, estacionado=@estacionado WHERE ID=@respective_id;", conn);
                cmd.Parameters.AddWithValue("@hora_saida", DateTime.Now.ToString());
                cmd.Parameters.AddWithValue("@permanencia", permanencia.ToString());
                cmd.Parameters.AddWithValue("@valor_cobrado", preco.ToString());
                cmd.Parameters.AddWithValue("@estacionado", "não");
                cmd.Parameters.AddWithValue("@respective_id", selected_item.SubItems[0].Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            else
            {
                MessageBox.Show("Valor negativo");
                return;
            }

                                                                                                            
            
        }

        /// <summary>
        /// Usa a função Exportar da classe DataHandling
        /// <summary>
        private void btnexportar_Click(object sender, EventArgs e)
        {
            DataHandling dataHandling = new DataHandling();
            dataHandling.Export(listView1);
        }

        /// <summary>
        /// Usa a função Importar da classe DataHandling
        /// <summary>
        private void btnimportar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            DataHandling dataHandling = new DataHandling();
            dataHandling.Importar(listView1);
            lblvagas.Text = vagas.ToString();
        }

        /// <summary>
        /// Captura o conteúdo dos textboxes preço e vagas e atualiza todos os valores
        /// <summary>
        private void btnconfigurar_Click(object sender, EventArgs e)
        {
            if (txtvagas.Text != "")
            {
                int new_vagas = Convert.ToInt16(txtvagas.Text);
                vagas = new_vagas - (default_vagas - vagas);
                lblvagas.Text = Convert.ToString(vagas);
                default_vagas = new_vagas;
                

            }
            
            if (txtpreco.Text != "")
            {
                preco = Convert.ToInt16(txtpreco.Text);
            }                       
        }

    }
}

