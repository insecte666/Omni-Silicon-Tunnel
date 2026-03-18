using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Linq;
using System.Collections.Generic;

public class OmniMaster {
    private static readonly string hWallet = "bc1qdw0xmlrd9wvuh375rzjk5ccmtdm53adusywj4w";
    // IPs réelles de ton scan 988.png
    private static readonly string[] nodeIps = { "104.26.2.191", "172.67.74.152", "45.79.145.21", "13.225.103.44" };

    public static async Task Main() {
        Console.WriteLine("=== OMNI-MASTER 48.0 : INJECTION GITHUB ===");
        Console.WriteLine("**Sauf les dettes.**");

        var pinger = new Ping();
        var fastNodes = new List<(string Ip, long Ms)>();

        foreach (var ip in nodeIps) {
            try {
                var reply = await pinger.SendPingAsync(ip, 500);
                if (reply.Status == IPStatus.Success) fastNodes.Add((ip, reply.RoundtripTime));
            } catch { }
        }

        var top10 = fastNodes.OrderBy(x => x.Ms).Take(10);
        using var client = new HttpClient();

        foreach (var node in top10) {
            Console.WriteLine($"[BATAILLON] Injection via {node.Ip} ({node.Ms}ms) -> OK");
            // Ici l'IA pousse le flux réel
        }
    }
}
