using nilnul.num.real_;

namespace nilnul.geometry.planar.sub._area.unit_
{
	public class EngAsSqInchEs4Dbl
		:
		Eng4dblI
		,
		_eng_.SqInch4DblI
	{
		private double _sqInchEs;

		public double sqInchEs
		{
			get { return _sqInchEs; }
			set { _sqInchEs = value; }
		}

		public PositiveDblI magnitude => new PositiveDbl(
			_sqInchEs
			*
			EngAsSqInch4Dbl.Singleton.magnitude.dblen.ee
		);

		public EngAsSqInchEs4Dbl(
			nilnul.num.real_.PositiveDblI x
		)
		{
			_sqInchEs = x.dblen.ee;
		}

		public EngAsSqInchEs4Dbl(
			nilnul.num.real_.PositiveDbl x
		)
		:
		this(
			(nilnul.num.real_.PositiveDblI)x
		)
		{
		}

		public EngAsSqInchEs4Dbl(double x):this(new nilnul.num.real_.PositiveDbl(x))
		{
		}
	}
}
