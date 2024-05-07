using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_.affine_
{
	/// <summary>
	/// into bloc (nonrotate rect)
	/// 
	/// each direction is affined 1d independently. the new cordinates is still orthogonal. orthogonal is kept. axises are still orthogonal.
	/// </summary>
	/// <remarks>
	/// pan on the map.
	/// </remarks>
	static public class _ShearlessX
	{
		static public Matrix Matrix(
			geometry.linear.morph_.Affine4dbl horizon
			,
			geometry.linear.morph_.Affine4dbl vertial
		)
		{
			return new Matrix(
				(float)horizon.scale, 0f
				,
				0f, (float)vertial.scale
				,
				(float)horizon.shift, (float)vertial.shift

			);

		}
	}

	public class Shearless4Dbl: _morph_.OfCoord4DblI
	{

		public geometry.linear.morph_.Affine4dbl horizon
		;
		public
			geometry.linear.morph_.Affine4dbl vertical;

		public Shearless4Dbl(

			 geometry.linear.morph_.Affine4dbl horizon0
			,
			geometry.linear.morph_.Affine4dbl vertical0
		)
		{

			this.horizon = horizon0;
			this.vertical = vertical0;

		}

		public Shearless4Dbl(double scale, double shift, double scaleY, double shiftY )
			:this(
				 new linear.morph_.Affine4dbl(scale,shift)
				 ,
				 new linear.morph_.Affine4dbl(scaleY,shiftY)
			)
		{
				
		}

		public Shearless4Dbl():this(
			1,0,1,0
		)
		{
				
		}

		public (double,double) morph(double x, double y) {
			return (
				this.horizon.op(x),
				this.vertical.op(y)
			);
		}

		static public Shearless4Dbl OfBlok2bloc(
			geometry.planar.zone_.Bloc8dbl old
			,
			geometry.planar.tope_.BlocDbl tgt

		) {

			return new Shearless4Dbl(
				 linear.morph_.Affine4dbl.OfShafts(
					 old.anchor.x, old.size.width.dblen.ee
					 ,
					 tgt.anchor.x, tgt.size1.width.realee.ee
					
				)
				 ,

				 linear.morph_.Affine4dbl.OfShafts(
					 old.anchor.y, old.size.height.dblen.ee
					 ,
					 tgt.anchor.y, tgt.size1.height.realee.ee
					
				)

			);
		}
		static public Shearless4Dbl OfBlok2bloc(
			geometry.planar.tope_.BlocDbl old
			,
			geometry.planar.tope_.BlocDbl tgt

		) {

			return OfBlok2bloc(
				new zone_.Bloc8dbl(old)
				,
				tgt

			);
		}


		public Matrix affine {
			get {
				return _ShearlessX.Matrix(
					this.horizon
					,
					this.vertical
				);
			}
		}

	}
}
