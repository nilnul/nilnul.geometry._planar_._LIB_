namespace nilnul.geometry.planar.troll_
{
	/// <summary>
	/// it's not a fixed point, which can be hosted within <see cref="nilnul.geometry.IOriginal"/>. This cannot be hosted in <see cref="nilnul.geometry.IOriginal"/>, but is a distorted of <see cref="nilnul.geometry.ILinear"/> into <see cref="nilnul.geometry.IPlanar"/>
	/// <see cref="planar.ICurve"/>
	/// </summary>
	/// <remarks>
	///the range is also continuous.
	/// </remarks>
	/// alias:
	///		unpoint
	///		unconstant
	public interface IUnpoint:ITroll,_unpoint.INonnilLong
	{
	}


}
