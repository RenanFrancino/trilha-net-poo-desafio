namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        // Construtor herdando de Smartphone
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // Implementação específica de instalar aplicativo
        public override void InstalarAplicativo(string Instagram)
        {
            Console.WriteLine($"Instalando o aplicativo {Instagram} no iPhone...");
        }
    }
}
