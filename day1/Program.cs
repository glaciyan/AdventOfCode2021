using System.Diagnostics;

var stopwatch = new Stopwatch();
stopwatch.Start();

Console.WriteLine($"first {First()}");
Console.WriteLine($"second {Second()}");

Console.WriteLine($"finished in {stopwatch.Elapsed.Milliseconds}ms");


int First()
{
  var input = new StreamReader("./input.txt");
  var increases = 0;

  var last = int.Parse(input.ReadLine()!);

  while (!input.EndOfStream)
  {
    var current = int.Parse(input.ReadLine()!);

    if (current > last) increases++;

    last = current;
  }

  return increases;
}

// second
int Second()
{
  var input = new StreamReader("./input.txt");
  var numbers = new List<int>();

  while (!input.EndOfStream)
  {
    numbers.Add(int.Parse(input.ReadLine()!));
  }

  var increases = 0;

  var previous = numbers[0] + numbers[1] + numbers[2];

  for (int i = 1; i < numbers.Count; i++)
  {
    // Stop when there aren't enough measurements left to create a new three-measurement sum.
    if (i + 3 > numbers.Count) break;

    var sum = numbers[i] + numbers[i + 1] + numbers[i + 2];

    if (sum > previous) increases++;

    previous = sum;
  }

  return increases;
}