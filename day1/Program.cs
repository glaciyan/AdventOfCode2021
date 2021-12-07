var input = new StreamReader("./input.txt");

var increases = 0;

var last = int.Parse(input.ReadLine()!);

while (!input.EndOfStream)
{
  var current = int.Parse(input.ReadLine()!);

  if (current > last) increases++;

  last = current;
}

Console.WriteLine(increases);