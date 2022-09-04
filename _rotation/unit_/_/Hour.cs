using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._rotation.unit_
{
	/// <summary>
	/// one degree =  1/12 round.
	/// </summary>
	public class Hour : UnitI
	{

		public const double Radians_Per_Hour = Math.PI / 6;
		public const double Hours_Per_Radian = 6 / Math.PI;

		static public double Hours2Radians(double hours)
		{
			return hours *Radians_Per_Hour;
		}
		static public double Radians2Hours(double radian)
		{
			return radian * Hours_Per_Radian;
		}
		public Real asRadian => nilnul.num.real_.Tau.Singleton.ToReal()/12;


		static public Hour Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Hour>.Instance;
			}
		}

	}
}
