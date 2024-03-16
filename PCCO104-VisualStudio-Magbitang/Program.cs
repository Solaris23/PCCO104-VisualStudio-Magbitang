namespace PCCO104_VisualStudio_Magbitang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            String[] names = { "name1", "name2" };

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}
