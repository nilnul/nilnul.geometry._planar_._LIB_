using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.lead.vsPoint._layout
{

	/// <summary>
	/// when curves spins anti-clockwise, the direction is cannonical. the internal is called internal
	/// </summary>
	public enum Sign
	{
		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		///	aliase:
		///		brunt
		///
		/// Retract //restrict, reduce; reset, retract,rest, retract, 		//ship to turn downward the direction of perpendicular axis.
		/// normally, on surface of ocean, where we have y-axis point upwards when x-axis point left, this means turn clockwise
		/// 
		///	nomenclature:
		///		same initial as "right"
		///		as leeway is where the lead protects and gives, "restrict" is what the lead protects against, where in-city dwellers cannot go due to danger.
		///
		/// ///Restrict, same initial as right; 
		/// </remarks>
		Restrict		
			,
		Incident

		,
		/// <summary>
		/// Interior//left (when arrow point up) //
		/// </summary>
		/// <remarks>
		///
		/// /// same initial letter as Left;  Lift  :sounds like left	//ship to turn toward the upward direction of perpendicular ; on surface of ocean, we use the noraml cartesian coordiants, that is, turn counterClockwise
		///
		///
		/// re: x-axis,
		///		the y-axis, as an emergency semaphore lighting guide,  points for evacuees to where the leeway is
		/// </remarks>
		Leeway 
		


	}
}
