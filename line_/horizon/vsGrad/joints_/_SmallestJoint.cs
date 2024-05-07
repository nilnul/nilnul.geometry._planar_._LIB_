using nilnul.geometry.planar.cycle_.gon_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.line_.horizon.vsGrad
{
	/// <summary>
	/// 
	/// </summary>
	static public class _MaxX
	{

		public static double? _SmallestJoint_gradBasisAssumeNotAbove(
			double yOfRay
			,
			planar.Grad4dbl_byPointsI grad
		)
		{

			if (grad.basis.y < yOfRay)
			{
				if (grad.finish.y < yOfRay)
				{
					return null;
				}

				else if (grad.finish.y == yOfRay) /// grad pointing upwards , reach the ray
				{
					return grad.finish.x;
				}
				else ///finish.y > testPoint.y
					 /// grad pointing upward, cross the line
				{
					var crossed = planar.line_.horizon.vsGrad_.slid_.cross._IntersectedX._Eks_gradAssumeStep1cross(
						yOfRay
						,
						grad
					);

					return crossed;


				}
			}

			//else if (grad.basis.y == rayOrigin.y) //from the ray

			if (grad.finish.y == yOfRay)
			{
				var min = Math.Min(
grad.basis.x, grad.finish.x
				);

				return min;

			}
			return grad.basis.x;
		}


		public static double? SmallestJoint(
			 double yOfLead
			,
			planar.Grad4dbl_byPointsI grad
		)
		{

			if (grad.basis.y <= yOfLead)
			{
				return _SmallestJoint_gradBasisAssumeNotAbove(yOfLead, grad);

			}
			else ///grad.basis.y > leadY
			{
				return _SmallestJoint_gradBasisAssumeNotAbove(
					yOfLead
					,
					new planar.Grad4dbl_byPoints(
						planar.point.op_.unary_.flip_._AlongHorizonX.Op_retClass(
							grad.basis
							,
							yOfLead
						)
						,
						planar.point.op_.unary_.flip_._AlongHorizonX.Op_retClass(
							grad.finish
							,
							yOfLead
						)
					)
				);


			}
		}

	}
}
