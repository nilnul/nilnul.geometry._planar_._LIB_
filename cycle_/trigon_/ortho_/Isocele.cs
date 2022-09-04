using nilnul.geometry.planar.point.trio.be_.tripod.vow;
using nilnul.geometry.planar.vect_.nontrivia_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.trigon_.ortho_
{
	/// <summary>
	/// establish the coordinate system such that:
	///		the origin is at the apex <see cref="nilnul.geometry.planar.zone_.trigon.Catheti"/>
	/// </summary>
	public class Isocele4dbl
		:
		nilnul.obj.Box1<
			planar.vect_.horizon_.Positive4dbl
		>
		,
		cycle_.Triangle4dblI
		,
		cloze_._trigon_.Vertexes4dblI
		,
		cycle_.trigon_.IByPrism
	{

		public Isocele4dbl(
			vect_.horizon_.Positive4dbl val

		) : base(val)
		{

		}
		public Isocele4dbl(double x):this(new vect_.horizon_. Positive4dbl(x))
		{

		}


		public Point4dblI alfa => point_.Origin4dbl.Singleton;

		public Point4dblI bravo => boxed.point;

		public Point4dblI charlie => planar.point.op_.unary_.flip_._Along45degX.Op_retClass(boxed.point);

		public EeD points => new EeD(alfa, bravo, charlie);

		public IEnumerable<Point4dblI> vertexes =>points.ee;

		public IEnumerable<Grad4dbl_byPointsI> grads => new Grad4dbl_byPointsI[] {
			new Grad4dbl_byPoints(alfa,bravo)
			,
			new Grad4dbl_byPoints(bravo,charlie)
			,
			new Grad4dbl_byPoints(charlie,alfa)
		};
	}
}
