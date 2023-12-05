
class Program
{
    static void Main()
    {
        Console.WriteLine("Numero de Universidades:");
        int Unis = int.Parse(Console.ReadLine());
        int UA = 0;
        int UR = 0;
        int UE = 0;
        for (int i = 0; i < Unis; i++)
        {
            List<int> U = Universidades();
            UA += U[0];
            UR += U[1];
            if (U[0] == U[1])
            {
                UE += U[3];
            }
        }
        Console.WriteLine($"Universidades que aceptan: {UA}");
        Console.WriteLine($"Universidades que rechazan: {UR}");
        Console.WriteLine($"Universidades con empate: {UE}");
    }

    static List<int> Universidades()
    {
        Console.Write("Nombre Universidad: ");
        string Name = Console.ReadLine();
        string Voto = " ";
        int Apr = 0;
        int rech = 0;
        int blancos = 0;
        int nulos = 0;
        List<int> Unis = new List<int>();

        while (Voto != "X")
        {
            Console.Write("Voto: ");
            Voto = Console.ReadLine();
            switch (Voto)
            {
                case "A":
                    Apr += 1;
                    continue;
                case "R":
                    rech += 1;
                    continue;
                case "N":
                    nulos += 1;
                    continue;
                case "B":
                    blancos += 1;
                    continue;
                case "X":
                    break;
            }
            Console.WriteLine($"{Name}: {Apr} aceptan, {rech} rechazan, {blancos} blancos, {nulos} nulos");
            Unis.Add(Apr);
            Unis.Add(rech);
            Unis.Add(nulos);
            Unis.Add(blancos);
        }
        return Unis;
    }


}
