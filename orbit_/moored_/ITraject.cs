namespace nilnul.geometry.planar.orbit_.moored_
{
	/// <summary>
	/// anchored. start from one point, not from inf.
	/// </summary>
	/// <remarks>
	/// for locus:
	/// fixed til time a. that is:
	/// when it's in (-inf, a], it's a fixed point. otherwise, it may move.
	/// </remarks>
	/// alias:
	///		open end (close start);
	///		infinite continuous <see cref="obj.IStream"/>
	///		affine
	///		radiate
	///		
	public interface ITraject:orbit_.IInfiniteOnOneEndOnly
	{ }


}
