namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinası");
            Console.Write("BİRİNCİ SAYIYI GİRİNİZ: ");
            double sayi1=double.Parse(Console.ReadLine());

            Console.Write("Lütfen bir işlem seçiniz(+) (-) (*) (/) (%) :  ");
            string islem = Console.ReadLine();

            Console.Write("ikinci sayıyı giriniz: ");
            double sayi2=double.Parse(Console.ReadLine());


            switch (islem)
            {
                case "+":
                    Console.WriteLine( sayi1+sayi2);
                    break;

                case "-":
                    Console.WriteLine(sayi1 - sayi2);
                    break;
                case "*":
                    Console.WriteLine(sayi1 * sayi2);
                    break;
                case "/":
                    Console.WriteLine(sayi1 / sayi2);
                    break;
                case "%":
                    Console.WriteLine(sayi1 % sayi2);
                    break;

            }
        }
    }
}