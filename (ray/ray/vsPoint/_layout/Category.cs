using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.ray.vsPoint._layout
{
	/// <summary>
	/// how to drive the ship. 
	/// </summary>
	public enum Category
	{
		Origin		//stay where you are
			,
		Forward	//ship forward
		,
		Backward
			,
		Lift	//sounds like left	//ship to turn toward the upward direction of perpendicular ; on surface of ocean, we use the noraml cartesian coordiants, that is, turn counterClockwise
			,
		Retract	//restrict, reduce; reset, retract,rest, retract, 		//ship to turn downward the direction of perpendicular axis. normally, on surface of ocean, where we have y-axis point upwards when x-axis point left, this means turn clockwise

	}
}
