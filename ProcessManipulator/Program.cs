
using System.Diagnostics;

Console.WriteLine(value: "***** Fun with Processes *****\n");
ListAllRunningProcesses();

static void ListAllRunningProcesses()
{
    IOrderedEnumerable<Process>? runningProcs = from proc
                       in Process.GetProcesses(machineName: ".")
                                                orderby proc.Id
                                                select proc;

    foreach (Process p in runningProcs) {
        string info = $"-> PID: {p.Id}\tName: {p.ProcessName}";
        Console.WriteLine(info);
    }
}