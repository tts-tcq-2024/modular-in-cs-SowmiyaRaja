using System;
using System.Drawing;
using System.Diagnostics;

namespace TelCo.ColorCoder
{
  partial class Program
  {
    /// <summary>
    /// Print the mapping between color-names to the corresponding numbers.
    /// </summary>
    private static string ReferenceManualGenerator()
    {
      int colorCode = 1;
      string manual = "_________________________________________\n";
      manual += String.Format("|{0}\t|{1}\t|{2}|\n", "Major Color", "Minor Color", "Pair No");
      Console.WriteLine();
      foreach(var majorColor in colorMapMajor)
      {
        foreach(var minorColor in colorMapMinor)
        {
          manual += String.Format("|{0}\t\t|{1}\t\t|{2}|\n", majorColor.Name, minorColor.Name, colorCode);
          colorCode++;
        }
      }
     Console.WriteLine(manual);
     return manual; 
    }
  }
}
