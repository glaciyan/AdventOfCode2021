using day2;

Console.WriteLine($"Solution for first challenge is {First()}");

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