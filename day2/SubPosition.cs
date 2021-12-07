using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace day2
{
  public class SubPosition
  {
    public int Horizontal { get; set; }
    public int Depth { get; set; }
    public int Multiplied => Horizontal * Depth;

    public SubPosition(int horizontal = 0, int depth = 0)
    {
      Horizontal = horizontal;
      Depth = depth;
    }

    public void RunCommand(string command)
    {
      var split = command.Split(' ');

      var direction = split[0];
      var amount = int.Parse(split[1]);

      switch (direction)
      {
        case "forward":
          Forward(amount);
          break;
        case "down":
          Down(amount);
          break;
        case "up":
          Up(amount);
          break;
      }
    }

    public void Forward(int amount)
    {
      Horizontal += amount;
    }

    public void Down(int amount)
    {
      Depth += amount;
    }

    public void Up(int amount)
    {
      Depth -= amount;
    }

    public override string ToString()
    {
      return $"h: {Horizontal}, d: {Depth}";
    }
  }
}