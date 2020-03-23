using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace lab1
{
   
    class Program
    {
        static void Method1(int n, List<string> logs)
        {
            lock(logs)
            {
                logs.Add($"Start fir: 1 {DateTime.Now.ToString("hh:mm:s:ms")}  Numar natural dat = {n}");
            }
            int prime = PrimeNumber.Method1(n);
            lock(logs)
            {
                logs.Add($"End fir: 1 {DateTime.Now.ToString("hh:mm:s:ms")} Numar prim = {prime}");
            }
        }
        static void Method2(int n, List<string> logs)
        {
            lock (logs)
            {
                logs.Add($"Start fir: 2 {DateTime.Now.ToString("hh:mm:s:ms")}  Numar natural dat = {n}");
            }
            int prime = PrimeNumber.Method2(n);
            lock (logs)
            {
                logs.Add($"End fir: 2 {DateTime.Now.ToString("hh:mm:s:ms")} Numar prim = {prime}");
            }
        }

        static async Task Method1Async(int n, List<string> logs)
        {
            lock (logs)
            {
                logs.Add($"Start fir: 1 async {DateTime.Now.ToString("hh:mm:s:ms")}  Numar natural dat = {n}");
            }
            int prime = await Task.Run<int>(() => { return PrimeNumber.Method1(n); });
            lock (logs)
            {
                logs.Add($"End fir: 1 async {DateTime.Now.ToString("hh:mm:s:ms")} Numar prim = {prime}");
            }
        }
        static async Task Method2Async(int n, List<string> logs)
        {
            lock (logs)
            {
                logs.Add($"Start fir: 2 async {DateTime.Now.ToString("hh:mm:s:ms")}  Numar natural dat = {n}");
            }
            int prime = await Task.Run<int>(() => { return PrimeNumber.Method2(n); });
            lock (logs)
            {
                logs.Add($"End fir: 2 async {DateTime.Now.ToString("hh:mm:s:ms")} Numar prim = {prime}");
            }
        }
        static void printLogs(List<string> logs)
        {
            foreach (var text in logs)
            {
                Console.WriteLine(text);
            }
        }
        static async void callAsync(int n, List<string> logs)
        {
            logs = new List<string>();
            await Method1Async(n, logs);
            await Method2Async(n, logs);

            printLogs(logs);
        }
        static void Main(string[] args)
        {
            List<string> logs= new List<string>();

            int n = int.Parse(Console.ReadLine());
            callAsync(n, logs);
            Thread t = new Thread(() => Method1(n, logs));
            Thread t2 = new Thread(() => Method2(n, logs));
            t.Start();
            t2.Start();
            t.Join(); t2.Join();
            printLogs(logs);

           
            
        }
    }
}
