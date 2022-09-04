using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.lead.vsPoint.layout_
{
	/// <summary>
	/// the point with reference to a direction.
	/// </summary>
	/// <remarks>
	///	alias:
	///		dash
	///		route
	///		track
	///		way
	///		path
	///		course
	///		channel
	/// </remarks>
	static public class _ByAngleX
	{
		static public bool? Eval(
			grad_.Arrow arrow
			,
			nilnul.geometry.planar.Point1 point
		) {

			var rotation= nilnul.geometry.planar.grad_.skid.co._TurnX.Direction(
				arrow,
				new grad_.Arrow(
					arrow.start
					,point
				)
				
			);
			return
				nilnul.num.real.Comparer.Singleton.bitNul(rotation, nilnul.num.real_.TauX.Half)
			;
			
		}

	}
}
