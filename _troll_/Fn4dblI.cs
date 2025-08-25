using System.Numerics;

namespace nilnul.geometry.planar._troll_
{
	public interface Fn4dblI
	{
		///en.wikipedia.org/wiki/Space-filling_curve
		/// Jordan in 1887 introduced the following rigorous definition, which has since been adopted as the precise description of the notion of a curve:
		///A curve (with endpoints) is a continuous function whose domain is the unit interval [0, 1].
		///It is also possible to define curves without endpoints to be a continuous function on the real line (or on the open unit interval (0, 1)).
		///
		/// here, we define curve as a continuous funciton:
		///		real -> complex
		///		,interpreted as: time-> complex
		/// <summary>
		/// for any time in the <see cref="interval"/>, return a point.
		/// </summary>
		/// <param name="time">
		/// in <see cref="interval"/>
		/// </param>
		/// <returns></returns>
		Complex locus(double time);

	}


}
