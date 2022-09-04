
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;


namespace nilnul.geometry.planar.point
{
	[Obsolete(nameof(Eq2))]
	public class Eq1
		: nilnul.EqA<Point>, IEqualityComparer<Point>
	{

		static public Eq1 Singleton = SingletonByDefault<Eq1>.Instance;

		static public bool Eval(Point a, Point b)
		{
			return
				nilnul.num.real.Eq.Singleton.Equals(

				a.x, b.x
				) &&
				nilnul.num.real.Eq.Singleton.Equals(

				a.y, b.y
				);
		}



		public override bool Equals(Point x, Point y)
		{
			return Eval(x, y);
			//throw new NotImplementedException();
		}

		public override int GetHashCode(Point obj)
		{
			return obj.x.GetHashCode() ^ obj.y.GetHashCode();

			//throw new NotImplementedException();
		}
	}




}
