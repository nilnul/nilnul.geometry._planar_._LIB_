namespace nilnul.geometry.planar.facet_.donut_
{
	/// <summary>
	/// vs: <see cref="facet_.IGon"/>:
	///		donut is holed. facet might be holed, or not
	///		donut is with only one hole. facet might be with multiple holes.
	///	common:
	///		the hole is empty; there are no other objects in the hole.
	///		For something in the hole is regarded as another object. We can use <see cref="facet_.gon.Nest"/> to represent such layout (one entity is in the other.)
	/// </summary>
	public interface IGon { }
}
