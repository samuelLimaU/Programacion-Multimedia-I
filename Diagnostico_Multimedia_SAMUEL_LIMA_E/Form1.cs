using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagnostico_Multimedia_SAMUEL_LIMA_E
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // funcion que genera todos los primos hasta un limite
        // usando la criba de erostenes
        static List<int> GenerarPrimosBase(int limite)
        {
            // true es primo, false no lo es
            bool[] esPrimo = new bool[limite + 1];

            // todos los numeros ≥ 2 como posibles primos
            for (int i = 2; i <= limite; i++)
                esPrimo[i] = true;

            // aplicar la criba de 
            // recorrer cada numero p desde 2 hasta raiz 2 del limtie
            for (int p = 2; p * p <= limite; p++)
            {
                // si p esta como primo
                if (esPrimo[p])
                {
                    // se marca todos los multiplos de p a partir de p*p como no primos
                    for (int m = p * p; m <= limite; m += p)
                        esPrimo[m] = false;
                }
            }

            // lista para almacenar los primos encontrados
            List<int> primos = new List<int>();
            for (int i = 2; i <= limite; i++)
                if (esPrimo[i])
                    primos.Add(i);

            return primos;
            //se devuelve la lista con los primos
        }

        // criba segmentada para contar primos
        static long ContarPrimosSegmentado(long L, long R)
        {
            // limite superior es menor que 2, no hay primos en el rango
            if (R < 2) return 0;

            // limite inferior es menor que 2, lo ajustamos a 2
            // porque 1 no se considera primo
            if (L < 2) L = 2;

            // tamano del bloque
            // bloques grandes = mas memoria pero menos iteraciones
            int bloque = 500_000_000;
            long contador = 0; // Contador de primos encontrados

            // obtener los primos base hasta raiz 2 de 2 usando la criba simple
            int limiteBase = (int)Math.Floor(Math.Sqrt(R));
            List<int> primosBase = GenerarPrimosBase(limiteBase);

            // preocesar el rango L R en bloques
            for (long low = L; low <= R; low += bloque)
            {
                // define el limite superior del bloque actual
                long high = Math.Min(low + bloque - 1, R);

                // array booleano indica si un numero dentro del bloque es primo
                bool[] esPrimoSegmento = new bool[high - low + 1];

                for (int i = 0; i < esPrimoSegmento.Length; i++)
                    esPrimoSegmento[i] = true;

                // marca multiplos de cada primo base en el bloque actual
                foreach (int p in primosBase)
                {
                    // calcula el primer multiplo de p dentro del bloque
                    long inicio = Math.Max((long)p * p, ((low + p - 1) / p) * p);

                    // marca todos los multiplos de p como no primos
                    for (long m = inicio; m <= high; m += p)
                        esPrimoSegmento[m - low] = false;
                }

                // contar los primos en el bloque
                for (long i = low; i <= high; i++)
                    if (esPrimoSegmento[i - low])
                        contador++;
            }

            // devolvert el total de primos encontrados en todo el rango
            return contador;
        }


        private async void btn_aceptar_Click(object sender, EventArgs e)
        {

            Stopwatch sw = new Stopwatch();

            sw.Start(); // inicia el cronometro

            if (!long.TryParse(int_inicio.Text, out long L) ||
                !long.TryParse(int_fin.Text, out long R))
            {
                MessageBox.Show("Introduce valores numéricos válidos.");
                return;
            }

            if (L == 0 && R == 0)
            {
                lbl_numeros.Text = "Chaudo";
                return;
            }

            lbl_numeros.Text = "Calculando...";

            // ejecuta en segundo plano para no congelar la UI
            long cantidad = await Task.Run(() => ContarPrimosSegmentado(L, R));

            sw.Stop(); // Detiene el cronometro

            lbl_tiempo.Text = $"La ejecución duró {sw.ElapsedMilliseconds} ms";

            lbl_numeros.Text = cantidad.ToString();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            int_inicio.Text = "";
            int_fin.Text = "";
            lbl_numeros.Text = "";
            //borrar las entradas y salidas
        }
    }
}
