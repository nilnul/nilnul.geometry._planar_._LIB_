namespace nilnul.geometry.planar
{
	/*length is defined before geometry._linear,
	but after length is established, area is established hence. So area is not defined before "_planar", rather behind it, in other words, "planar.Arear"
		 */
	/// <summary>
	/// with unit. nonneg. This is a measure on <see cref="zone"/>. For measure on any <see cref="geometry.planar.ISub"/>, use a general measure.
	/// </summary>
	public interface IArea
		:nilnul.obj.IMeasure

	{ }
}
