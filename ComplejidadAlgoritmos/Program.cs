using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Complejidad de algoritmos\n");
        //Console.WriteLine("Complejidad Big O(1)\n");

        ////var nombres = new List<string>() { "Ileny", "Alondra", "José", "Juan", "Alejandro", "Karla"};
        //var nombres = new List<string>();
        //var primero = (List<string> arreglo) => arreglo != null && arreglo.Count > 0 ?

        //                arreglo[1] : "Lista vacia";

        //Console.WriteLine(primero(nombres));


        Console.WriteLine("Complejidad Big O(1)\n");

        var nombres = new List<int>() { 45, 22, 53, 500, 2000, 10000, 0, 1};

        var numeroMayor = (List<int> arreglo) =>
        {
            if (arreglo == null || arreglo.Count == 0)
            {
                return 0;
            }
              int mayor = arreglo[0];
                for (int i = 0; i < arreglo.Count; i++)
                {
                    if (arreglo[i] > mayor)
                    {
                        mayor = arreglo[i];
                    }
                }
            
            return mayor;

        };

        int may = numeroMayor(nombres);
        Console.WriteLine("El número mayor es: " + may);



        Console.ReadKey();
    }
}