using System;

namespace tpmodul5_103022300033
{
    public class HaloGeneric
    {
        public void SapaUser<T>(T user)
        {
            Console.WriteLine($"Halo user {user}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();
            string nama = "ilham";
            halo.SapaUser(nama);
        }
    }
}