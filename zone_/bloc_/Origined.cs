using nilnul.geometry.planar.tope_;
using nilnul.geometry.planar.tope_._bloc.size_;
using nilnul.geometry.planar.vect_;
using nilnul.num.real.bound_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.bloc_
{
	public class Originated4dbl
		:
		nilnul.obj.Box_pub<
			planar.tope_._bloc.size_.Spanned4dbl
		>
		,
		zone_.Polygon4dblI
		,
		drawable_._boundaried_.Boundary4dblI
		,
		tope_.Bloc4dbl_byBoundsI


	{
		public Originated4dbl(Spanned4dbl val) : base(val)
		{
		}

		public Originated4dbl(double v1, double v2)
			:this(new Spanned4dbl(v1,v2))
		{
		}

		public IEnumerable<Point4dblI> vertexes
		{
			get
			{
				yield return  Point4dbl.CreateZero();

				yield return new planar.point_.Horizon4dbl(
					this.boxed.width.dblen
				);
				yield return new Point4dbl(
					this.boxed.width.dblen,this.boxed.height.dblen
				);
				yield return new planar.point_.Vertical4dbl(
					this.boxed.height.dblen
				);



			}
		}

		public IEnumerable<Grad4dbl_byPointsI> grads
		{
			get
			{
				return cloze_.gon._Grads4dblX._Grads_ofStarted(vertexes);

			}
		}

		public Bloc4dbl_byBoundsI bounds =>  new bloc_.Originated4dbl(
			this.boxed
		)
			;

		public ClosedDbl boundX => new ClosedDbl(
			0,boxed.width.dblen
		);

		public ClosedDbl boundY => new num.real.bound_.closed_.NonegDbl(boxed.height.dblen);
	}
}
