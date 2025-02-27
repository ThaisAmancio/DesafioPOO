namespace DesafioPOO.Models
{
    public class Nokia: Smartphone
    {
         public Nokia(string numero, string modelo, string imei, int memoria) 
                    : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando um aplicativo nesse aparelho");
            Thread.Sleep(1000);
            Console.WriteLine($"...");
            Thread.Sleep(1000);
            Console.WriteLine($"# {nomeApp} - instalado com sucesso");        
        }
    }
}