namespace nilnul.geometry.planar
{
	/// <summary>
	/// 	/// 
	/// In comparision with Edge:
	///		edge's endpoints are different.
	///		seg's endpoint may be same.
	///	The order is not significant. If the order is meaningful, use Point.Duo
	///		
	/// mnemorics:
	///		seg is shorter.

	/// maybe the same points, no direction
	/// </summary>
	public interface TendI


	{
		nilnul.geometry.planar.point.Twin points { get; }
	}

}
