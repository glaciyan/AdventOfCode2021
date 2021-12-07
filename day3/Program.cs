// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Tracing;
using System.Text;

Console.WriteLine($"first {First()}");
Console.WriteLine($"second {Second()}");

static int First()
{
  var input = new StreamReader("./input.txt");
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

  var gammaRate = Convert.ToInt32(gammaRateStr, 2);
  var epsilonRate = Convert.ToInt32(InvertBinString(gammaRateStr), 2);

  return gammaRate * epsilonRate;
}

static int Second()
{

}

static string InvertBinString(string input)
{
  var builder = new StringBuilder(input.Length);

  foreach (var c in input)
  {
    builder.Append(c == '1' ? '0' : '1');
  }

  return builder.ToString();
}