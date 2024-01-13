using System;
using canalLock;

var canalGate = new CanalLock();

Console.WriteLine(canalGate);

Console.WriteLine("=============================================");
Console.WriteLine("Test invalid commands");
// Open "wrong" gate (2 tests)
try
{
    canalGate = new CanalLock();
    canalGate.SetHighGate(open: true);
}
catch (InvalidOperationException)
{
    Console.WriteLine("Invalid operation: Can't open the high gate.Water is low.");
}
Console.WriteLine($"Try to open upper gate: {canalGate}");