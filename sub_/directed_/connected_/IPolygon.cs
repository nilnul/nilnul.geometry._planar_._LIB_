namespace nilnul.geometry.planar.sub_.directed_.connected_
{
	/// <summary>
	/// a series of points.
	///
	/// 
	/// excluding: 
	///		trivia situation
	///			1)remove consecutive identical points.
	///				1.1) nonconsecutive identical points are also removed. As two nonconsective identitcal points closed a polygon alread; containing two nonconsective identitial points means we have multiple polygons, not a single polygon here we are processing.
	///			2) points count>=3
	///		(for those, use point.str. or Points)
	///		
	///	including:
	///		edges may cross each other.
	///			for example: the pentagram
	///	Note: 
	///		the path has direction.
	///			anticlockwise is positive. see: Rotation.
	/// 
	/// </summary>
	///
	public interface IPolygon : IEmpty0cloze
	{

	}
}
