namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        { 
             if(Ligado) {
                Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone...");
                Aplicativos.Add(nomeApp);
            }

            else 
                Console.WriteLine("Não foi possível instalar o app, pois o celular está desligado");
        }
    }
}