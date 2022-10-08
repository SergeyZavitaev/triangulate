namespace ConsoleVS
{
    class Programm
    {

        static public void Main(string[] args)
        {
            Random rd = new Random();

            Triangles tris = new();
            
            tris.FillTriangle();
            Console.ReadLine();
            tris.PrintTriange();
            Console.ReadLine();
            tris.PrintTrisPaskalya();
            Console.ReadLine();
            tris.PrintTrisSerpinskogo();
            Console.ReadLine();
            tris.PrintEmptyTriange();
        }
    }
}