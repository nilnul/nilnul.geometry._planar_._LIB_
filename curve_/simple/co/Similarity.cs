using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.simple.co
{
	/*
	1) compare the start-end vector; and align the two vector (rotate or scale; but not flip. flip will be embodied in the result as negative one )
	2) compare the "rotation" (a physically force to turn the growth from start point to end point) of each point.
		2.1) if the Pull-force is the same, then the curves are the same.
		2.2) if the twist/turn force is opposite, then the curves are flipped from on to the other.
		 */
	/// <summary>
	/// 
	///
	/// compute first order derivative: end point - start point.
	/// then compute second order derivative:
	/// ,...
	/// ,
	///  then the derivative ( a force to turn the head of the line) of each (possibly discretized) point.
	///		and then compare the drivatives. or compare the derivative of the derivatices, and so on.
	/// </summary>
	/// <remarks>
	///  note:
	///  1) curve may be rotated, translated, scaled.
	///  2) one curve may be part of the other. But in this type, we only compare the whole; the part of the other will be taken out and input here as a whole curve.
	/// </remarks>
	///
	class Similarity
	{
	}
}
