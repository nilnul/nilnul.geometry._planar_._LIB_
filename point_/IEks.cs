namespace nilnul.geometry.planar.point_
{
	/// <summary>
	/// a point on the x-axis
	/// </summary>
	public interface IEks
		:
		planar.IPoint
	{
	}

	public interface Eks4dblI
		:
		Point4dblI
		,
		IEks { }
}