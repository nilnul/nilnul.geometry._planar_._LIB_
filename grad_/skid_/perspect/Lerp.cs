using nilnul.geometry.planar.grad_.skid_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.skid_.perspect
{
	/// <summary>
	/// Linear intERPolation
	/// </summary>
	public class Lerp4dbl
		:
		nilnul.obj.Box1<
			planar.grad_.skid_.Wai4dbl
		>
	{
		public Lerp4dbl(Wai4dbl val) : base(val)
		{
		}

		

		public Point4dbl point(double t) {

			return boxed.basement + geometry.planar.vect.op_.unary_._ScaleX.Scale( boxed.vect , t );
			
		}
	}
}
