namespace nilnul.geometry.planar.morph_._rebase_
{
	/// <summary>
	/// put the coord:P , as a row, to the left  of the matrix:M
	/// ,: PM
	/// = (x,y) {row0, row1} 
	/// = x row0 + y row1
	/// , which means x,y are regarded as the coords, so they are the new, not old, coords
	/// 
	/// </summary>
	/// <remarks>
	/// new coords as input; output: oldCoords
	/// </remarks>
	/// alias:
	///		ordinate
	///		compose of the two basis into a vect, an inversion of decompose <see cref="vect.IDichnotomy"/>
	class ICoordinate
	{
    }
}
