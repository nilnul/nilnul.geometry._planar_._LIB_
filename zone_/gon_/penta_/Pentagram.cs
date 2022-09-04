using nilnul.geometry.planar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Sin = nilnul.geometry.planar.rotation.op_._SinX;

namespace nilnul.geometry.planar.zone_.gon_.pentagon_
{
	/// <summary>
	/// a decagon that looks like a star.
	/// </summary>
	/// <remarks>
	/// alias:
	///		pentacle
	/// </remarks>
	public  class Pentagram
	{
		public const double SmallInnerAngleInDegree = 36;
		public const double Big_Inner_Angle_In_Degree = 252;
		public const double Small_Inner_Angle_In_Radian = SmallInnerAngleInDegree / 180 * Math.PI;

		public const double Big_Inner_Angle_In_Radian = Big_Inner_Angle_In_Degree * _rotation.unit_.Degree.Radian_Per_Degree;

		public const double EdgeCenterAngle = regular_.Decagon.Edge_Center_Angle_In_Radian;
		public const double EdgeCenterAngle_In_Degree = regular_.Decagon.Edge_Center_Angle_In_Degree;	//36

		public static readonly double ShortRadius_Per_LongRadius = 1/ Sin.OfDeg(126) *Sin.OfDeg(18) ;


		public static IEnumerable<Point4dbl> CreateUnitPentagram(double radius) {
			var shortRadius = ShortRadius_Per_LongRadius * radius;


			double curRadius;
			double curDegree = 90;

			for (int i = 0; i < 10; i++,curDegree+=EdgeCenterAngle_In_Degree)
			{
				if (i%2==0)
				{
					curRadius = radius;

				}
				else
				{
					curRadius = shortRadius;
				}

				yield return point_.PolarDX.ToPointDbl(curRadius,curDegree);


			}



		}


	}
}
