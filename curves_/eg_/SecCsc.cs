using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curves_.eg_
{
	/// <summary>
	/// x**2+ y**2 =(xy)**2
	/// ,
	/// timeishly
	///		, sec(t), csc(t)
	/// </summary>
	internal class SecCsc
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="t"></param>
		/// <returns>
		/// (1,-inf) when t=0-
		/// 
		/// (1,inf) when t=0+
		///		the curve in quadrant1st
		/// (inf,1) when t=tau/4-
		/// 
		/// (-inf,1) when t=tau/4+
		///		quardrant2nd
		/// (-1,inf) when t = tau/2-
		/// 
		/// (-1,-inf) when t = tau/2+
		///		quadrant3rd
		/// (-inf,-1) when t = 3tau/4-
		///
		/// (inf,-1) when t = 3tau/4+
		///		the curve in quadrant4th
		/// (1,-inf) when t=0-
		/// 
		/// (1,inf) when t=0+
		/// </returns>
		static public (double, double) _Complex0ext_0time(double t)
		{
			return (
				1 /
				Math.Cos(t)
				,
				1 / Math.Sin(t)
			);
		}
	}
}
