using nilnul.bit.var.str.be_;

namespace nilnul.geometry.planar.rotation_
{
	/// <summary>
	/// <see cref="planar.curl_.elbow"/>, where the rotation can be expressed as in: [0,pi] with (0,-pi), that is:  (-pi,pi]
	/// </summary>
	/// <remarks>
	/// as in <see cref = "System.Numerics.Complex.Phase" />, which is atan2(The atan2() function returns an angle value (in radians) between -pi and pi(inclusive of pi , but typically excluding -pi ). )	
	/// </remarks>
	/// alias:
	///		swirl
	///

	public interface IPhase : rotation_.geNegPi_.ILtPi { }


}
