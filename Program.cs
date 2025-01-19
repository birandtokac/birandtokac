using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        TahminEtmeOyunu();

    }

    public static void TahminEtmeOyunu(){
        // Deneme sayısı belirlemek amaçlı bir sayı belirliyorum
        int Hak = 7;

        // 1 ile 100 arasında rastgele bir sayı üretir.
        Random random = new Random();
        int RandomVal = random.Next(1,101);

        
        Console.WriteLine("Rasgele bir sayıyı tahmin etme oyununua hoş geldiniz.");
        Console.WriteLine("5 hakkınız olacak ve tahminlerinizin sonunda sayının seçilmiş sayıdan büyük mü küçük mü olduğu belirtilecektir.");

        while (Hak > 0)
        {

            //Her yanlış denemede Hakkımız 1 düşecek.
            Hak--;

            // Kullanıcıdan tahmin alırız
            Console.WriteLine("Bir sayı tahmin edin (1-100 arası): ");
            int SelectedVal = 0;
            SelectedVal = Convert.ToInt32(Console.ReadLine());

            //Eğer tahmin doğruysa çalışacak
            if(SelectedVal == RandomVal){
                Console.WriteLine("Doğru tahmin ettiniz. Tebrikler.");
                break;
            }
            //Eğer Hakkımız 0'sa alttaki sorgulara girmeden çıksın
            else if(Hak == 0){
                Console.WriteLine("Kaybettiniz.");
                Console.WriteLine("Rasgele sayı: "+RandomVal);
                break;
            }
            else if(SelectedVal > RandomVal)
            {
            Console.WriteLine("Daha küçük bir sayı tahmin etmelisiniz.");
            }
            else {
            Console.WriteLine("Daha büyük bir sayı tahmin etmelisiniz.");
            }





            
            
            
        }
        
    }

}