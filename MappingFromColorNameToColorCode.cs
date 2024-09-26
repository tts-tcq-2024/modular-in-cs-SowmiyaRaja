using System;
using System.Drawing;
using System.Diagnostics;

namespace TelCo.ColorCoder
{
  partial class Program
  {
    private static void MappingFromColorNameToColorCode()
    {
      int colorCode = 1;
      Console.WriteLine("________________________________________");
      Console.WriteLine(String.Format("|{0}\t\t|{1}\t\t|{2}|", "Major Color", "Minor Color", "Pair No"));
      foreach(var majorColor in colorMapMajor)
      {
        foreach(var minorColor in colorMapMinor)
        {
          Console.WriteLine(String.Format("|{0}\t|{1}\t|{2}|", majorColor.Name, minorColor.Name, colorCode));
          colorCode++;
        }
      }
    }
  }
}
