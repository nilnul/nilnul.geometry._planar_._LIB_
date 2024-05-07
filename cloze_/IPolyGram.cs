namespace nilnul.geometry.planar.cloze_
{
	/// <summary>
	/// the edges might, unlike in <see cref="IGon"/>, intersect;
	/// </summary>
	/// <remarks>
	/// as this is <see cref="ICloze"/>, those with edges unintersecting is put into <see cref="cycle_.IPolygon"/>;
	/// </remarks>
	public interface IPolyGram:ICloze { }
}
