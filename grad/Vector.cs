using nilnul.geometry.planar.grad_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad
{
	/// <summary>
	/// vector
	/// </summary>
	static public class _DisplaceX
	{
		//static public nilnul.geometry.planar.Vector4dblI Displace(this nilnul.geometry.planar.Grad4dblI grad) {
		//	return grad.vect;
		//}

		static public nilnul.geometry.planar.Vector4dblI Displace(this nilnul.geometry.planar.point.CoD grad) {
			return grad_._StepX.Vect(grad);
		}


		[Obsolete(nameof(Vect1))]
		static public VectorDbl Vect(Point4dblI a, Point4dblI b) => new planar.VectorDbl(

			b.x - a.x
			,
			b.y - a.y
		);

		static public Vect4dbl Vect1(Point4dblI a, Point4dblI b) => new planar.Vect4dbl(

			b.x - a.x
			,
			b.y - a.y
		);

		static public PointF VectAsPoint(PointF a, PointF b) => new PointF(

			b.X - a.X
			,
			b.Y - a.Y
		);

		public static Vect4dbl Vect(this Grad4dbl_byPointsI leg)
		{
			return  leg.finish.ToOrthogonal() -leg.basis;
		}

		public static Vect4dbl Vect(this grad_.skid_.ByPoints4Dbl leg)
		{
			return  Vect(
				(Grad4dbl_byPointsI)leg
			);
		}

		public static Vector4dblI Vect(point.CoD grad)
		{
			return Vect(grad.component, grad.component1)
			;// throw new NotImplementedException();
		}






	}
}
