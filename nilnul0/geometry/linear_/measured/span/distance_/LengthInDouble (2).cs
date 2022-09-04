namespace nilnul.length
{
	public partial class LengthInDouble:LengthI
	{
		public double magnitude { get; set; }
		public UnitI unit { get; set; }

		public LengthInDouble(double magnitude,UnitI unit)
		{
			this.magnitude = magnitude;
			this.unit = unit;
		}

		public override string ToString()
		{
			return magnitude+unit.ToString();
		}
					
	}
}
