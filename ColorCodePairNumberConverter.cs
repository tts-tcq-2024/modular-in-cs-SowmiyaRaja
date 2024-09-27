namespace TelCo.ColorCoder
{
  partial class Program
  {
    /// <summary>
    /// Given a pair number function returns the major and minor colors in that order
    /// </summary>
    /// <param name="pairNumber">Pair number of the color to be fetched</param>
    private static ColorPair GetColorFromPairNumber(int pairNumber)
    {
        // The function supports only 1 based index. Pair numbers valid are from 1 to 25
        int minorSize = colorMapMinor.Length;
        int majorSize = colorMapMajor.Length;
        if (pairNumber < 1 || pairNumber > minorSize * majorSize)
        {
            throw new ArgumentOutOfRangeException(
                string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
        }        
        int zeroBasedPairNumber = pairNumber - 1;
        int majorIndex = zeroBasedPairNumber / minorSize;
        int minorIndex = zeroBasedPairNumber % minorSize;

        ColorPair pair = new ColorPair() { majorColor = colorMapMajor[majorIndex],
            minorColor = colorMapMinor[minorIndex] };
        return pair;
    }
    /// <summary>
    /// Given the two colors the function returns the pair number corresponding to them
    /// </summary>
    /// <param name="pair">Color pair with major and minor color</param>
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
