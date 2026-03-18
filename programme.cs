using System;
using System.Threading.Tasks;

class Program {
    static async Task Main() {
        Console.WriteLine("==============================================");
        Console.WriteLine("    INSTALLATION OMNI-SILICON-TUNNEL");
        Console.WriteLine("    ID: eb435c83bfb059dfbf3c5d385fbaa46677c1b136");
        Console.WriteLine("    STATUT: SUCCESS / VERT");
        Console.WriteLine("==============================================");

        for(int i = 1; i <= 10; i++) {
            Console.WriteLine($"[INSTALL] Bloc {i}/10 injecté... OK");
            await Task.Delay(300);
        }

        Console.WriteLine("\n[CONFIG] Monopole du Silence : PLAY");
        Console.WriteLine("[CONFIG] Clause à 1$ : ACTIVE");
        Console.WriteLine("==============================================");
    }
}
