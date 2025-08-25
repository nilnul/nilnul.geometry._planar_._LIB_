using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry._2d.point
{
	[Obsolete()]
	public  class Binary
	{
		private PointD _point;

		public PointD point
		{
			get { return _point; }
			set { _point = value; }
		}
		private PointD _point1;

		public PointD point1
		{
			get { return _point1; }
			set { _point1 = value; }
		}

		public Binary(
			PointD p,
			PointD p1
		)
		{
			this.point = p;
			this.point1 = p1;

		}

		

		public bool isReflexive() { 
			return nilnul.geometry._2d.PointD.Eq.Eval(point, point1);
			
		}

		static public bool TwoPointsSame(PointD x, PointD y) {
			return nilnul.geometry._2d.PointD.Eq.Eval(x, y);
		}

		static public bool TwoPointsSame(Pair twoPoints) {
			return TwoPointsSame(twoPoints.point, twoPoints.point1);
		}

		public class Eq:IEqualityComparer<Binary>
		{
			static public Eq Singleton = SingletonByDefault<Eq>.Instance;
			public bool Equals(Binary x, Binary y)
			{
				return geometry._2d.PointD.Eq.Eval(x.point, y.point) && geometry._2d.PointD.Eq.Eval(x.point1, y.point1);
				throw new NotImplementedException();
			}

			public int GetHashCode(Binary obj)
			{
						return geometry._2d.PointD.Eq.Singleton.GetHashCode() ^ geometry._2d.PointD.Eq.Singleton.GetHashCode();
		throw new NotImplementedException();
			}
		}
		
	}
}
