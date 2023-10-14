using CuadradoMedio.Algoritmos;

namespace CuadradoMedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x0 = Convert.ToInt32(textBox1.Text);
            int dig = textBox1.Text.Length;
            int Total = Convert.ToInt32(textBox2.Text);

            Cuadrado_medio algoritmo = new Cuadrado_medio();
            List<int> lista = algoritmo.GenerarLista(x0, dig, Total);
            llenarGrid(algoritmo.lista);

        }
        public void llenarGrid(List<int> lista)
        {
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Id");
            dataGridView1.Columns.Add(numeroColumna2, "Valor");

            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i + 1).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i].ToString();

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}