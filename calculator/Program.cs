namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinası");
            Console.Write("BİRİNCİ SAYIYI GİRİNİZ: ");
            int sayi1=int.Parse(Console.ReadLine());

            Console.Write("Lütfen bir işlem seçiniz(+) (-) (*) (/) (%) :  ");
            string islem = Console.ReadLine();

            Console.Write("ikinci sayıyı giriniz: ");
            int sayi2=int.Parse(Console.ReadLine());
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
            }
        }
    }
}