namespace nilnul.geometry.planar.troll_
{
	/// <summary>
	/// <see cref="planar.Point4dbl"/>
	/// </summary>
	public class Point :
		INilLong
		,
		_troll_.Fn4dblI
	{
		C _point;
		public Point(C point)
		{
				_point = point;
		}
		public C locus(double time)
		{
			return _point;
		}
	}
}
