namespace nilnul.geometry
{
	public class Kilometer : UnitI
	{
		private static readonly Kilometer instance = new Kilometer();

		private Kilometer() { }

		public static Kilometer Instance
		{
			get
			{
				return instance;
			}


		}

		public override string ToString()
		{
			return "km";
		}
	}
}
