namespace nilnul.geometry.planar.chase_.convex.io.be_
{
	/// <summary>
	/// the incoming and outgoing ray cross;
	/// </summary>
	/// <remarks>
	/// if it's cross, that means :
	///		when the chase is part of a zone border, if an inner point radiates out passing cross this chase at a certain direction,  the shadow of chase point on the radiation, can go big, small, big,small, thus not convex.
	///		, we need to cut the chase by the orthic line of the radial.
	/// </remarks>
	internal class Cross
	{
	}

}
