namespace nilnul.geometry.planar.curve_
{
	/// <summary>
	/// anchored. start from one point, not from inf.
	/// </summary>
	/// infinite continuous <see cref="obj.IStream"/>
	/// alias:
	///		affine
	///		radiate
	///		
	public interface ITraject:ICurve,curve_.infinite_.IInfiniteOnBothEnds
	{ }


}
