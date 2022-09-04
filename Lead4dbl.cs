using nilnul.geometry.planar.grad_;
using nilnul.geometry.planar.grad_.skid_;

namespace nilnul.geometry.planar
{
	public class Lead4dbl
		:
		nilnul.obj.Box1<
		grad_.Nonnil4dblI
	>
		,
		ILeadDbl
		,
		_lead_.AzimuthI
	{
		public Lead4dbl(Nonnil4dblI val) : base(val)
		{
		}

		public Lead4dbl(Point4dbl a, Point4dbl b):this(
			new planar.grad_.skid_.ByPoints4Dbl(a,b)
		)
		{
		}

		public ByPoints4Dbl arrow =>  ByPoints4Dbl.Of(this.boxed);

		public double azimuth => arrow.azimuth;
	}


}
