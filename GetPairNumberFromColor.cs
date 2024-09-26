namespace TelCo.ColorCoder
{
  partial class Program
  {
    /// <summary>
    /// Given the two colors the function returns the pair number corresponding to them
    /// </summary>
    /// <param name="pair">Color pair with major and minor color</param>
    /// <returns></returns>
    private static int GetPairNumberFromColor(ColorPair pair)
    {
        int majorIndex = -1;
        majorIndex = Array.IndexOf(colorMapMajor, pair.majorColor);        
        int minorIndex = -1;
        minorIndex = Array.IndexOf(colorMapMinor, pair.minorColor);
        
        if (majorIndex == -1 || minorIndex == -1)
        {
            throw new ArgumentException(
                string.Format("Unknown Colors: {0}", pair.ToString()));
        }
        // (Note: +1 in compute is because pair number is 1 based, not zero)
        return (majorIndex * colorMapMinor.Length) + (minorIndex + 1);
    }
  }
}
