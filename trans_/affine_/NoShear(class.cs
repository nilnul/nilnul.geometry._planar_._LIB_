using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.trans_.affine_
{
	/// <summary>
	/// into bloc (nonrotate rect)
	/// 
	/// each direction is affined 1d independently. the new cordinates is still orthogonal. orthogonal is kept. axises are still orthogonal.
	/// </summary>
	/// <remarks>
	/// pan on the map.
	/// </remarks>
	static public class _NoShearX
	{
		static public Matrix Matrix(
			geometry.linear.grad_.nontrivia.map_.TgtGrad4Dbl horizon
			,
			geometry.linear.grad_.nontrivia.map_.TgtGrad4Dbl vertial
		)
		{
			return new Matrix(
				(float)horizon.scale, 0f
				,
				(float)vertial.scale, 0f
				,
				(float)horizon.shift
				, (float)vertial.shift

			);

		}
	}

	public class NoShear4Dbl: map_.Trans4dblI
	{

		public geometry.linear.grad_.nontrivia.map_.TgtGrad4Dbl horizon
		;
		public
			geometry.linear.grad_.nontrivia.map_.TgtGrad4Dbl vertical;
		public NoShear4Dbl(

			 geometry.linear.grad_.nontrivia.map_.TgtGrad4Dbl horizon0
			,
			geometry.linear.grad_.nontrivia.map_.TgtGrad4Dbl vertical0
		)
		{

			this.horizon = horizon0;
			this.vertical = vertical0;

		}

		public (double,double) trans(double x, double y) {
			return (this.horizon.trans(x), this.vertical.trans(y));
		}

		public Matrix affine {
			get {
				return _NoShearX.Matrix(
					this.horizon
					,
					this.vertical
				);
			}
		}

	}
}
