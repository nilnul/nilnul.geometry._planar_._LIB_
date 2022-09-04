using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect.co.to_.real_
{
	public class InnerProduct : co.to_.RealI
	{
		public nilnul.num.RealI op(Duo arg)
		{
			return _InnerProductX.InnerProduct(arg.Item1,arg.Item2);
			throw new NotImplementedException();
		}


		public nilnul.num.RealI op(Point a, Point b) {
			return _InnerProductX.InnerProduct(a,b);
		}
		public num.RealI op(PointI x, PointI y)
		{
			return _InnerProductX.InnerProduct(x,y);
			throw new NotImplementedException();
		}
		public nilnul.num.RealI op(nilnul.num.RealI x, nilnul.num.RealI y) {
			return _InnerProductX.InnerProduct(x,y);
		}


		static public InnerProduct Singleton
		{
			get
			{
				return nilnul._obj.Singleton<InnerProduct>.Instance;
			}
		}

	}
}
