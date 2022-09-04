using nilnul.num.real_;

namespace nilnul.geometry.planar.sub._area.unit_
{
	public class EngAsSqInch4Dbl
		:
		Eng4dblI
	{
		private PositiveDbl _magnitude = new PositiveDbl(
			nilnul.num.real.op_.unary_.Square.Singleton.op(
				linear_._measured.unit_.EngAsInch4Dbl.Meters_Per_This
			)
		);

		public PositiveDblI magnitude => _magnitude;


		static public EngAsSqInch4Dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<EngAsSqInch4Dbl>.Instance;
			}
		}

	}
}
