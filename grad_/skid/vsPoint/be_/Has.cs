using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.grad_.skid.vsPoint.be_
{


	/// <summary>
	/// colinear and inbetween the end points
	/// </summary>
	static public  class Segment_LengthPositive

	{

		
		static public bool contains(
			this grad_.Arrow arrow
			,
			planar.Point1 p

		)
		{
			if (planar.line.be_.HasPointX.Bit(arrow.points,p))
			{
				return grad_.skid.vsPoint_.colinear.be_._ArrowHasPointX._ofColinear(arrow,p);

			}
			return false;



		}


	}
}
