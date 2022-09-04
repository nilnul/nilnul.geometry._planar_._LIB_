using nilnul.num.real_;

namespace nilnul.geometry.linear_._measured.unit_
{
	public class EngAsInch4Dbl :
		Unit4dblA
	{

		public const double Meters_Per_This = 2.54;
		public EngAsInch4Dbl() : base(Meters_Per_This)
		{
		}


		static public EngAsInch4Dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<EngAsInch4Dbl>.Instance;
			}
		}

	}
}
