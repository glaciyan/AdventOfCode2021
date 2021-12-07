// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Text;

var stopwatch = new Stopwatch();
stopwatch.Start();

Console.WriteLine($"first {First()}");
Console.WriteLine($"second {Second()}");

Console.WriteLine($"finished in {stopwatch.Elapsed.Milliseconds}ms");

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
    gammaRateStr += MostCommonBit(diagnostics, i);
  }

  var gammaRate = Convert.ToInt32(gammaRateStr, 2);
  var epsilonRate = Convert.ToInt32(InvertBinString(gammaRateStr), 2);

  return gammaRate * epsilonRate;
}

static int Second()
{
  var input = new StreamReader("./input.txt");
  var diagnostics = new List<string>();
  while (!input.EndOfStream)
  {
    diagnostics.Add(input.ReadLine()!);
  }

  var oxygenRating = new List<string>(diagnostics);

  var oxPos = 0;
  while (oxygenRating.Count > 1)
  {
    var mostCommon = MostCommonBit(oxygenRating, oxPos);
    oxygenRating.RemoveAll((ox) => ox[oxPos] != mostCommon);
    oxPos++;
  }


  var co2Rating = new List<string>(diagnostics);

  var co2Pos = 0;
  while (co2Rating.Count > 1)
  {
    var mostCommon = MostCommonBit(co2Rating, co2Pos);
    co2Rating.RemoveAll((co) => co[co2Pos] == mostCommon);
    co2Pos++;
  }

  return Convert.ToInt32(oxygenRating[0], 2) * Convert.ToInt32(co2Rating[0], 2);
}

static char MostCommonBit(List<string> list, int position)
{
  var ones = 0;

  foreach (var item in list)
  {
    if (item[position] == '1') ones++;
  }

  if (ones == list.Count - ones) return '1';

  return ones > list.Count - ones ? '1' : '0';
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