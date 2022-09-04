using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.grad.to_.point_
{
	public class Vector : PointI
	{
		public Point op(Grad arg)
		{
			return arg.Item2 - arg.Item1;// new Point();
			throw new NotImplementedException();
		}


		static public Vector Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Vector>.Instance;
			}
		}

	}
}
