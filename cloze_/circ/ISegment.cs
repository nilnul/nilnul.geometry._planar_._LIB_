namespace nilnul.geometry.planar.cloze_.circ
{
	/// <summary>
	/// a part (including a point, or the full circle) of the circle.
	/// if it's full circle, it's regarded as a func:
	///		complex (t); so even the end point is incident with the start point, it's still 1d. and the 1d moves intersecting with itself.
	/// </summary>
	/// vs:
	///		
	internal class ISegment
		:planar.ITraverse
	{
	}

}
