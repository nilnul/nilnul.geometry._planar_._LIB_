using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.trans_.rebase_.shear_
{


	public class Rotate
		:IRotate
	{

		/// <summary>
		/// new basis is in col. Thence this matrix multiplies coords from left while coords is at the right.
		/// </summary>
		/// <param name="rotationOfFigure"></param>
		/// <returns></returns>
		static public double[,] CreateMatrixFroRadian(double rotationOfFigure)
		{


			var cos = Math.Cos(rotationOfFigure);
			var sin = Math.Sin(rotationOfFigure);
			///(x,y)=(r*cos(a), r*sin(a))
			/// (x`,y`)=( r*cos(a+t), r*sin(a+t) ) = r*cos(a) cos(t) - r*sin(a) sin(t), r*sin(a)*cos(t)+r*cos(a)*sin(t)  = r*cos(a) cos(t) - r*sin(a) sin(t), r*cos(a)*sin(t) +r*sin(a)*cos(t) = x cos(t) - y * sin(t) , x*sin(t) +y*cos(t) = x * (cos(t), sin(t) ) + y * (-sin(t), cos(t))  
			return new double[2, 2] {
				{cos, -sin }
				,
				{ sin, cos}
			};

			/*Note that the two-dimensional case is the only non-trivial (i.e. not 1-dimensional) case where the rotation matrices group is commutative, so that it does not matter in which order multiple rotations are performed. An alternative convention uses rotating axes,[1] and the above matrices also represent a rotation of the axes clockwise through an angle θ.*/
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="rotation"></param>
		/// <returns></returns>
		static public double[,] CreateMatrixFroAxesRotation(double rotation) {

			return CreateMatrixFroRadian(
				-rotation
			);
		}
		static public double[,] CreateMatrixFroFigureRotationDegree(double rotationOfFigure) {


			return CreateMatrixFroRadian(
				nilnul.geometry.planar.rotation_.Degree.ToRadian(rotationOfFigure)
			);
		}


	}
}
