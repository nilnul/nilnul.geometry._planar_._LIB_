using nilnul.geometry.planar.cycle_.gon_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.line_.horizon.vsGrad.joints_
{
	/// <summary>
	/// max x of the intersected point if any;
	/// or null if there is no intersection;
	/// </summary>
	static public class _Max0nulX
	{

		public static double? _Max0nul_1basisAssumeNotAbove(
			double yOfLine
			,
			planar.Grad4dbl_byPointsI grad
		)
		{

			if (grad.basis.y < yOfLine)
			{
				if (grad.finish.y < yOfLine)
				{
					return null;
				}

				else if (grad.finish.y == yOfLine) /// grad pointing upwards , reach the ray
				{
					return grad.finish.x;
				}
				else ///finish.y > testPoint.y
					 /// grad pointing upward, cross the line
				{
					var crossed = planar.line_.horizon.vsGrad_.slid_.cross._IntersectedX._Eks_gradAssumeStep1cross(
						yOfLine
						,
						grad
					);

					return crossed;


				}
			}

			//else if (grad.basis.y == rayOrigin.y) //from the ray

			if (grad.finish.y == yOfLine)
			{
				var max = Math.Max(
grad.basis.x, grad.finish.x
				);

				return max;

			}
			return grad.basis.x;
		}


		public static double? Max0nul(
			 double lineY
			,
			planar.Grad4dbl_byPointsI grad
		)
		{

			if (grad.basis.y <= lineY)
			{
				return _Max0nul_1basisAssumeNotAbove(lineY, grad);

			}
			else ///grad.basis.y > lineY
			{
				return _Max0nul_1basisAssumeNotAbove(
					lineY
					,
					new planar.Grad4dbl_byPoints(
						planar.point.op_.unary_.flip_._AlongHorizonX.Op_retClass(
							grad.basis
							,
							lineY
						)
						,
						planar.point.op_.unary_.flip_._AlongHorizonX.Op_retClass(
							grad.finish
							,
							lineY
						)
					)
				);


			}
		}

	}
}
