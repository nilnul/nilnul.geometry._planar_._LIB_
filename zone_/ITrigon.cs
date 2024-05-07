using nilnul.geometry.dimed;

namespace nilnul.geometry.planar.zone_
{
	/// <summary>
	/// trigon is a zone. Triangle is a curve.
	/// excluding trivia cases
	/// 
	/// </summary>
	/// <remarks>
	/// This is the strictest/strongest definition of a trigon and gives as much info as possible. So most descriptors of trigon is placed herethence.
	/// </remarks>
	/// nomenclature:
	///		trigon:
	///			as in trigonometrics
	///			<seealso cref="nameof(planar.zone_.gon_.ITri)"/>, but here -"gon" means: angled/angular, or not in a line.
	///			vs: triangle
	///				trigon emphasis the inner area
	///				triangle emphsis the sides (of each angle obviously)
	///				
	/// 
	///

	public interface ITrigon :
		planar.zone_.gon_.ITri
		,
		ISimplex
	{}


}
