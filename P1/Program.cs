namespace P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba su saldo inicial: ");
            int saldoInicial = int.Parse(Console.ReadLine());
            Cuenta objeto1 = new Cuenta(saldoInicial);

            Console.Write("Escriba el monto a acreditar: ");
            int acreditar = int.Parse(Console.ReadLine());
            objeto1.Credit(acreditar);

            Console.Write("Escriba el monto a cargar: ");
            int cargar = int.Parse(Console.ReadLine());
            objeto1.Cargar(cargar);

            Console.WriteLine("El saldo actual es: " + objeto1.ObtenerSaldo());
            Console.ReadLine();
        }
    }

    class Cuenta
    {
        private int saldoActual;

        public Cuenta(int saldoInicial)
        {
            if (saldoInicial >= 0)
            {
                saldoActual = saldoInicial;
            }
            else
            {
                saldoInicial = 0;
                Console.WriteLine("Error: el saldo inicial es inválido");
            }
        }

        public void Credit(int acreditar)
        {
            saldoActual += acreditar;
        }

        public void Cargar(int cargar)
        {
            if (saldoActual >= cargar)
            {
                saldoActual -= cargar;
            }
            else
            {
                Console.WriteLine("El monto a cargar excede el saldo de la cuenta.");
            }
        }

        public int ObtenerSaldo()
        {
            return saldoActual;
        }
    }
}
