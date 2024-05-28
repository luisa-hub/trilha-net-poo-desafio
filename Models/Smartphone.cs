using System.Security.Cryptography.X509Certificates;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set;}
        private string IMEI { get; set;}
        private int Memoria { get; set; }

        public bool Ligado {get; set;}
        public IList<string> Aplicativos{get; set;}

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            Ligado = false;
            Aplicativos = new List<string>();
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
            Ligado = true;
        }

        public void Desligar() {
            Console.WriteLine("Desligando...");
            Ligado = false;
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void ListarAplicativos(){

            if(Aplicativos.Count == 0){
                Console.WriteLine("Sem aplicativos instalados mostrar no momento");
                return;
            }

            foreach (var aplicativo in Aplicativos)
            {
                Console.WriteLine(aplicativo);
            }
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}