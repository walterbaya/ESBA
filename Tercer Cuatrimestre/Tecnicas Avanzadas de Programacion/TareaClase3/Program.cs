namespace Walter_Baya
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteBanco clienteBanco = new ClienteBanco(1.5f, 1000);
            clienteBanco.showMonthDebt();
        }
    }

    //Todos los métodos de la clase van a ser estaticos, ya que no se va a crear una clase matematica.
    class Matematica
    {
        //Escribir un método que permita el ingreso de tres números enteros e informe cuál es el más grande.
        public static int biggerBetweenThree() {
            int max = 0;
            for (int i = 0; i < 3; i++) {

                Console.Write("Ingrese numero");

                int num = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    max = num;
                }
                else {
                    max = (num > max) ? num : max;
                }
            }
            return max;
        }

        //Calcular a^b por productos sucesivos y lo devuelve en un res que es de salida.

        public static void pow(double a, int b, out double res) {
            res = a;
            for (int i = 1; i < b; i++) {
                res *= a;            
            } 
        }

        //Escribir un programa que pida el ingreso de un número entero positivo e informe si el número es primo o no.

        public static bool isAPrimeNumber(int number){
            bool c = true;
            for (int i = 2; i <= Math.Sqrt(number) && c; i++) {
                c = (number % i == 0) ? false : true;
            }
            return c;
        }

        //Escribir un programa que liste todos los números primos entre 1 y un n dado. (n entero positivo). 

        public static void listAllPrimes(int n) {
            for (int i = 2; i < n; i++)
            {
                if (isAPrimeNumber(i)) {
                    Console.WriteLine(i);
                }
            }
        }    
    
    }

    class ClienteBanco {
        private float interestRate = 1.5f;
        private float totalDebt = 1000f;
        private float totalPayment = 0f;

        public ClienteBanco(float interestRate, float totalDebt)
        {
            interestRate = this.interestRate;
            totalDebt = this.totalDebt;
        }
        public void showMonthDebt() {

            float interestRateAux = interestRate;
            float totalDebtAux = totalDebt;
            float totalPaymentAux = totalPayment;

            Console.Write("Ingrese pago: ");
            float payment = float.Parse(Console.ReadLine());

            int i = 1;
            while (totalDebtAux > 0) {
                float interestAux = totalDebtAux * (interestRate / 100f);
                totalDebtAux = (totalDebtAux + interestAux) - payment;
                totalPaymentAux += payment;

                Console.Write("Mes: " + i + "\t\tSaldo: " + totalDebtAux.ToString("c2") + "\t\tTotal pagado: " + totalPaymentAux.ToString("c2") + "\n");
                i++;
            }

        
        }
    }

}


