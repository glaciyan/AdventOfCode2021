using System.Diagnostics;
using day2;

var stopwatch = new Stopwatch();
stopwatch.Start();

Console.WriteLine($"first {First()}");
Console.WriteLine($"second {Second()}");

Console.WriteLine($"finished in {stopwatch.Elapsed.Milliseconds}ms");

static int First()
{
  var input = new StreamReader("./input.txt");

  var subPos = new SubPosition();

  while (!input.EndOfStream)
  {
    var command = input.ReadLine();
    subPos.RunCommand(command!);
  }

  return subPos.Multiplied;
}


static int Second()
{
  var input = new StreamReader("./input.txt");

  var subPos = new SubPositionVer2();

  while (!input.EndOfStream)
  {
    var command = input.ReadLine();
    subPos.RunCommand(command!);
  }

  return subPos.Multiplied;
}
