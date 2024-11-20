namespace diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] sayilar = new int[5];
            for (int i = 0; i < 5; i++)
             
            {
                Console.WriteLine((i + 1).ToString() + "Sayıyı Giriniz");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            int enbuyuk;
            enbuyuk = sayilar[0];
            for (int i = 1; i < 5; i++)
            {
                if (enbuyuk < sayilar[i])
                {
                    enbuyuk = sayilar[i];
                }
            }
                Console.WriteLine(enbuyuk);
                Console.ReadLine(); 
        }
    }
}
