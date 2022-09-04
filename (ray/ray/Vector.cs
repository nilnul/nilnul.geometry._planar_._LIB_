using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.ray
{
	static public class _VectorX
	{
		static public planar.IVector Vector(planar.RayI ray) {
			return new planar.Vector1(
				nilnul.num.real.op_.unary_.Cos.Singleton.op(
					ray.rotation.quantity
				)
				,
				nilnul.num.real.op_.unary_.Sin.Singleton.op(
					ray.rotation.quantity
				)
			);
		}

		static public planar.vect_.Nonnil VectorNonnil(planar.RayI ray) {
			return new planar.vect_.Nonnil(
				nilnul.num.real.op_.unary_.Cos.Singleton.op(
					ray.rotation.quantity
				)
				,
				nilnul.num.real.op_.unary_.Sin.Singleton.op(
					ray.rotation.quantity
				)
			);
		}

		static public planar.VectorDbl Vector(planar.IRayDbl ray) {
			return new planar.VectorDbl(
				Math.Cos(
					ray.rotation
				)
				,
				Math.Sin(
					ray.rotation
				)
			);
		}


		static public planar.vect_.NonnilDbl VectorNonnil(planar.IRayDbl ray) {
			return new planar.vect_.NonnilDbl(
				Math.Cos(
					ray.rotation
				)
				,
				Math.Sin(
					ray.rotation
				)
			);
		}



	}
}
