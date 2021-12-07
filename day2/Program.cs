using day2;

Console.WriteLine($"Solution for first challenge is {First()}");
Console.WriteLine($"Solution for second challenge is {Second()}");

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
