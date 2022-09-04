using System;

namespace nilnul.geometry.linear.vect.co.sig_
{
	public class Perpend : SigI
	{
		public bool? sign(Duo obj)
		{
			return _PerpendX.Re(obj.Item1,obj.Item2);
			//throw new NotImplementedException();
		}
		public bool? sign(PointI x, PointI y)
		{
			return _PerpendX.Re(x,y);

		}

		public bool? sign(Point x, Point y) {
			return _PerpendX.Re(x,y);
		}
		public bool? sign(VectI basis, VectI obj)
		{
			return sign(basis.end,obj.end);
			//throw new NotImplementedException();
		}

		public bool? sign(Vector basis, Vector obj)
		{
			return sign(basis.end,obj.end);
			//throw new NotImplementedException();
		}


		public bool? sign(Co obj)
		{
			return _PerpendX.Re(obj.Item1,obj.Item2);

			//throw new NotImplementedException();
		}

		static public Perpend Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Perpend>.Instance;
			}
		}

	}
}
