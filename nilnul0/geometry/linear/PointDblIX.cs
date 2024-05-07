namespace nilnul.geometry.linear
{
	static public class PointDblIX
	{
		static public PointDbl ToClass(this PointDblI point) {
			if (point is PointDbl r)
			{
				return r;
			}
			return new PointDbl(
				point.coord
			);
		}
	}
}
