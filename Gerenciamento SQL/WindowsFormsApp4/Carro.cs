using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp4
{
    internal class Carro
    {
        SqlConnection conn = new SqlConnection("Data Source=DUDZ;Initial Catalog=master;Integrated Security=True");
        SqlCommand cmd;
 
        public static int counter = 0;
        public int ID;

        public Carro()
        {
            counter++;
            this.ID = counter;
        }

        /// <summary>
        /// Registra uma instância do carro, adicionando um ao contador que é passado ao ID, e depois adiciona alguns itens ao ListView
        /// <summary>
        public void Registrar_carro(ListView listView1, string txtboxplaca)
        {
            foreach (ListViewItem lvi in listView1.Items)
            {
                if (lvi.SubItems[1].Text == txtboxplaca && lvi.SubItems[6].Text == "sim")
                {
                    MessageBox.Show("Veículo já registrado");
                    return;
                }
            }

            try
            {
                conn.Open();
                cmd = new SqlCommand("INSERT INTO lista_carro(ID, placa, hora_entrada, hora_saida, permanencia, valor_cobrado, estacionado) VALUES (@id, @placa, @hora_entrada, @hora_saida, @permanencia, @valor_cobrado, @estacionado);", conn);
                cmd.Parameters.AddWithValue("@id", counter);
                cmd.Parameters.AddWithValue("@placa", txtboxplaca);
                cmd.Parameters.AddWithValue("@hora_entrada", Convert.ToString(DateTime.Now));
                cmd.Parameters.AddWithValue("@hora_saida", "Estacionado");
                cmd.Parameters.AddWithValue("@permanencia", "Estacionado");
                cmd.Parameters.AddWithValue("@valor_cobrado", "0,00");
                cmd.Parameters.AddWithValue("@estacionado", "sim");
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception  e){ MessageBox.Show("Banco de dados existente, pressione importar" + e.Message); return; }



            ListViewItem item = new ListViewItem(Convert.ToString(this.ID));
            item.SubItems.Add(txtboxplaca);
            item.SubItems.Add(Convert.ToString(DateTime.Now));
            item.SubItems.Add("Estacionado");
            item.SubItems.Add("Estacionado");
            item.SubItems.Add("0,00");
            item.SubItems.Add("sim");
            listView1.Items.Add(item);            
            Form1.vagas--;

            

            
        }

    }
}
