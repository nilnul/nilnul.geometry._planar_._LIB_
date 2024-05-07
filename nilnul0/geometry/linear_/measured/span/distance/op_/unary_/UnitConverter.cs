namespace nilnul.geometry
{
    /// <summary>
    /// this converts from one unit to another
    /// </summary>
   public partial class UnitConverter
    {
       static public double InchToMeter(double inches) {
           return inches * 2.54 / 100;
       }
    }
}
