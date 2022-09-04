using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar_.ergo_.canvas_
{
	/// <summary>
	/// 
	/// by right-handed rule:
	///		the arm goes along with the linear_.axis.
	///			then the palm goes along with the vertical axis.
	///				hence, along with the vertical axis, we go from up to down
	/// </summary>
	/// <remarks>
	/// As  <see cref="nameof(geometry.linear_.ergo_.horizon_.ILeft2right)"/> is defined due to our eyes are at the levled , and our heart is at the left.
	///		and we are right handed, means, we start from lefthand (we cannot let the left hand unused all along), and end at the right hand.
	/// 
	/// alias:
	///		mirror, or a water surface as a mirror.
	///			main axis is the horizon axis
	///				as our eyes are at the save level. the angle of view is max along the horizon axis
	///				out heart is at left. so we go from left to right.
	///			assisstant axis is the vertical axis.
	///				we read from up to down.
	///					as our eyes are at our top.
	///					when we look into the mirror, we look from top to bottom
	///					
	///		
	///		book
	///		clock
	///			clock is designed using screen coordinates system:
	///				xAxis is from left to right
	///				yAxis is from up to down
	///				and the main axis is xAxis, as the hands go right and down from 0 to 3 o'clock. the arc is concave( if look from below.), not convex (so it goes horizontally first, and vertically second, not vice versa.)
	///	rotation:
	///	
	/// </remarks>
	public interface IScreen
	{
	}
}
