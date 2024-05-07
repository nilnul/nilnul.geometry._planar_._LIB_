namespace nilnul.geometry.planar
{
	/// <summary>
	/// a <see cref="planar.ICloze"/>, but direction is ignored.
	/// But this is not to say that this is a set.
	/// as for Lace shaped like the number: 8, regarding it as a set would mean to remove the second repeating of the middle point, and break the contiguous curve.
	/// </summary>
	/// alias:
	///		lasso
	///			it can be fasten to a point
	///			it can be tangled, self intersecting.
	///			it has no direction. you just fasten it in either or both direction, as you can use double/symmetric knot from two parallel run of rope.
	///		lace
	///		
	///		lac
	public interface ILasso
		:ILocus
		, trail_.IEndAtStart
		,
		ILap
	{

	}
}