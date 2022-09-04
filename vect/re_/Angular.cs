using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.re_
{
	/// <summary>
	/// not on the same line
	/// </summary>
	public class Angular : ReI
	{
		public bool re(VectorI vector1, VectorI vector2)
		{

			return nilnul.num.real.be_.Nil.Singleton.be(
				nilnul.geometry.planar.vect.co._CrossProductX.AreaOfParallelogram(vector1,vector2)
			);

			//throw new NotImplementedException();
		}

		public bool re(Vector1 point1, Vector1 point2) {
			return re(point1 as VectorI, point2 as VectorI);
		}


		public bool re(PointI1 point1, PointI1 point2)
		{
			return re( new Vector1(point1), new Vector1(point2));

			//throw new NotImplementedException();
		}

		public bool re(Point1 point1, Point1 point2)
		{
			return re( new Vector1(point1), new Vector1(point2));

		}


		static public Angular Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Angular>.Instance;
			}
		}

	}
}
