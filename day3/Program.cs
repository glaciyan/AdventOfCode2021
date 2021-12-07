// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Tracing;

Console.WriteLine($"first {First()}");

static uint First()
{
  var input = new StreamReader("./testInput.txt");
  var diagnostics = new List<string>();
  while (!input.EndOfStream)
  {
    diagnostics.Add(input.ReadLine()!);
  }

  var gammaRateStr = "";

  for (int i = 0; i < diagnostics[0].Length; i++)
  {
    var ones = 0;

    foreach (var diagnostic in diagnostics)
    {
      if (diagnostic[i] == '1') ones++;
    }

    gammaRateStr += ones > diagnostics.Count / 2 ? "1" : "0";
  }

  var gammaRate = Convert.ToUInt32(gammaRateStr, 2);

  return gammaRate * ~gammaRate;
}