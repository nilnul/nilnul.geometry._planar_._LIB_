namespace nilnul.geometry.planar.cycle_
{
	/// under <see cref="cycle_"/> is the primary place to define <see cref="ITriangle"/> as we need to define/reiify something to ignore properly/rigourously.
	/// the default placement of a trigon is :
	///		the bottom line is from 0 to a positive number along the axis.
	///		the apex point is in the <see cref="surface_.bisect_.WaiPositive"/>
	/// <summary>
	/// trigon is a zone. Triangle is a curve.
	/// excluding trivia cases
	/// 
	/// </summary>
	/// <remarks>
	/// nomenclature:
	///		trigon:
	///			as in trigonometrics
	///			<seealso cref="nameof(planar.zone_.gon_.ITri)"/>, but here -"gon" means: angled/angular, or not in a line.
	///				
	/// </remarks>
	///

	public interface ITriangle :
		ICycle {}
}
