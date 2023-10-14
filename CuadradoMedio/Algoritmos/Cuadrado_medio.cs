using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CuadradoMedio.Algoritmos
{
    public class Cuadrado_medio
    {
        public List<int> lista = new List<int>();
        public List<int> GenerarLista(int x0, int dig, int Total)
        {

            for (int i = 0; i < Total; i++)
            {
                // Calcular valores
                int x02 = x0 * x0;

                // Convertir a String para hacer substring 
                string x02_str = x02.ToString();

                // Hacer substring
                int inicio = (x02_str.Length - dig) / 2;
                string new_num_str = x02_str.Substring(inicio, dig);

                // Agregar el nuevo valor a la lista
                int new_num_int = int.Parse(new_num_str);
                lista.Add(new_num_int);

                if (new_num_int == 0)
                {
                    MessageBox.Show("Se llegó a un 0");
                    break;
                }
                else if (new_num_int == x0)
                {
                    MessageBox.Show("Se ha encontrado un ciclo");
                    break;
                }
                else
                {
                    x0 = new_num_int;
                }
            }
            return lista;
        }
    }
}







        


            
    


 

