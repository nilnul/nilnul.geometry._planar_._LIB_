using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._rotation.unit_
{
	/// <summary>
	/// one degree =  1/360 round.
	/// </summary>
	public class Degree : UnitI
	{

		public const double Radian_Per_Degree = 1 / Degree_Per_Radian;
		public const double Degree_Per_Radian = 180 / Math.PI;

		static public double Degree2Radian(double degree)
		{
			return degree / 180 * Math.PI;
		}
		static public double Radian2Degree(double radian)
		{
			return radian / Math.PI * 180;
		}
		public Real asRadian => nilnul.num.real_.Tau.Singleton.ToReal()/360;


		static public Degree Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Degree>.Instance;
			}
		}

	}
}
