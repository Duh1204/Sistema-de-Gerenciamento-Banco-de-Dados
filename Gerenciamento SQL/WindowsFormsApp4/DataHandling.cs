using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronXL;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp4
{
    internal class DataHandling
    {
        SqlConnection conn = new SqlConnection("Data Source=DUDZ;Initial Catalog=master;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adapter;
        DataSet ds;

        /// <summary>
        /// Exporta todos os items do ListView para um arquivo do excel
        /// <summary>
        public void Export(ListView listView1)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
            int linha = 2, coluna = 1;

            ws.Cells[1, 1] = listView1.Columns[0].Text;
            ws.Cells[1, 2] = listView1.Columns[1].Text;
            ws.Cells[1, 3] = listView1.Columns[2].Text;
            ws.Cells[1, 4] = listView1.Columns[3].Text;
            ws.Cells[1, 5] = listView1.Columns[4].Text;
            ws.Cells[1, 6] = listView1.Columns[5].Text;
            ws.Cells[1, 7] = listView1.Columns[6].Text;

            foreach (ListViewItem lvi in listView1.Items)
            {
                coluna = 1;
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    ws.Cells[linha, coluna] = lvs.Text;
                    coluna++;
                }

                linha++;
            }
        }

        /// <summary>
        /// Importa todos os items para um ListView de um arquivo do excel
        /// <summary>
        public void Importar(ListView listView1)
        {
            Carro.counter = 0;
            conn.Open();
            ds = new DataSet();
            cmd = new SqlCommand("SELECT * FROM lista_carro;", conn);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();

            for (int i = 0; i <= dt.Rows.Count-1; i++)
            {
                listView1.Items.Add(dt.Rows[i].ItemArray[0].ToString());                
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
            }

            int estacionados = 0;
            Form1.vagas = 50;

            foreach (ListViewItem lvi in listView1.Items)
            {
                Carro.counter++;
                if (lvi.SubItems[6].Text == "sim")
                {
                    estacionados++;                    

                }
            }
            Form1.vagas -= estacionados;
            

        }

    }
}
