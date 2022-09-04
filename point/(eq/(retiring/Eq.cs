using nilnul.geometry.planar._point;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;


namespace nilnul.geometry.planar.point
{
	[Obsolete()]
	public class Eq
		: nilnul.EqA<PointD>,  IEqualityComparer<PointD>
	{

		static public Eq Singleton = SingletonByDefault<Eq>.Instance;

		static public bool Eval(PointD x, PointD y)
		{
			return x.x == y.x && x.y == y.y;
		}



		public override bool Equals(PointD x, PointD y)
		{
			return Eval(x, y);
			throw new NotImplementedException();
		}

		public override int GetHashCode(PointD obj)
		{
			return obj.x.GetHashCode() ^ obj.y.GetHashCode();

			throw new NotImplementedException();
		}
	}


	public class Ne
	{


		static public bool Eval(PointD x, PointD y)
		{
			return !Eq.Singleton.Equals(x, y);
		}


	
	}


}
