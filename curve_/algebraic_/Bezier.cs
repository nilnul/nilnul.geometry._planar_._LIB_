using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.algebraic_
{

	/// <summary>
	/// 
	/// </summary>
	/// can be regarded as the weighted mean of the points;
	public class Bezier4dbl
		:
		nilnul.obj.Box1<
			planar.point.str_.Started4dbl
		>
	{
		public Bezier4dbl(planar.point.str_.Started4dbl val) : base(val)
		{
		}

		public IEnumerable<Point4dblI>  points
		{
			get { return this.boxed; }
		}

		/// in binomial form.
		/// t, (1-t)
		/// eg:
		///		At + B(1-t)
		///		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="t"></param>
		/// <param name="complement">
		/// from 1 to 0.
		/// </param>
		/// <returns></returns>
		public Point4dbl _interpolate_assumeProbComplemented(double t, double complement)
		{
			var r = new Point4dbl();

			var combinates = new nilnul.num.str_.started_.Combinates(
				this.boxed.Count()
			).ToArray();

			var count = this.boxed.Count();

			var poly = new nilnul.num.real.seq_.str_.Polyn4dbl(t,count).ToArray();

			//var complement = 1 - t;

			var complementPolyReversed = new nilnul.num.real.seq_.str_.Polyn4dbl(complement,count).Reverse().ToArray();


			for (int i = 0; i < count; i++)
			{
				r += (
					(double) (combinates[i].toBigint().en)
				)
				*poly[i]* complementPolyReversed[i]     // Bernstein Basis, sum to 1, meaning that a convex hull. Bernstein basis is the coordinates in polynomial space.


				* this.boxed.ElementAt(i).ToOrthogonal()
				;
			}
			return r;


		}


	}
}
