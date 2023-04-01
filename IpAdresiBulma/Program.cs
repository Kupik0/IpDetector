using System.Net;

internal class Program
{
    static void Main(string[] args)
    {
        do
        {
            try
            {
                Console.WriteLine("Girmek İstediğiniz Url'yi giriniz:");
                string Host = Console.ReadLine().ToString();

                IPHostEntry hostname = Dns.GetHostByName(Host);

                IPAddress[] ip = hostname.AddressList;

                Console.WriteLine("İşlem başarılı ip: " + ip[0].ToString());

                Console.WriteLine("\n");

            }
            catch (Exception ex)
            {
                Console.WriteLine("İşlem Başarısız Hata Kodu : {0}", ex.ToString);
                Console.WriteLine("\n");
            }


        } while (true);

    }

}