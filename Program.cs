using HayvanBakımıDb.Models;

namespace HayvanBakımıDb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sahip sahip = new Sahip();
            Hayvan hayvan = new Hayvan();

            sahip.Hayvanlar.Add(hayvan);
        }
    }
}