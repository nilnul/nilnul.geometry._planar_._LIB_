using nilnul.geometry.planar.point.str_;
using nilnul.geometry.planar.trav_.piecewise_._polyseg_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_
{
	public class Polygon4dbl
		: nilnul.obj.Box1<
			planar.point.str_.Started4dbl
		>
		,
		Polygon4dblI
	{
		public Polygon4dbl(Started4dbl val) : base(val)
		{
		}

		public Polygon4dbl(IEnumerable<Point4dblI> enumerable)
			:this(new Started4dbl(enumerable) )
		{
		}

		public Polygon4dbl(IEnumerable<Complex> enumerable):this(
			enumerable.Select(c=> new Point4dbl(c) )
		)
		{
		}

		public IEnumerable<planar.Grad4dbl_byPointsI> grads
		{
			get
			{

				return gon._Grads4dblX._Grads_ofStarted(
					this.boxed
				);

				



			}
		}

		public IEnumerable<Point4dblI> vertexes => boxed;

	
	}
}
