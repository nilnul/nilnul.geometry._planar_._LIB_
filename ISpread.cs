namespace nilnul.geometry.planar
{
	/// the encircling curve can be positivewise, or negativewise.
	/// corresponding to one of the two sides of the surface.
	/// <summary>
	/// no singular point. no singular curve.
	/// 2d for every point.  This might be simple, or not
	/// </summary>
	/// <remarks>
	///		This is continuous. for noncontinous ones, see <see cref="ISpatter"/>
	///		the <see cref="planar.coil_.polygon_.hex_.Annulus"/>'s direction will means the "inside" or outside a curve.
	/// </remarks>
	/// alias
	/// :
	///		spread
	///			,roadable
	///		region
	///		face means there might be holes;
	///		facet
	///		plank
	///	
	public interface ISpread :
		//drawable_.connected_.IConduitable
		//,
		//connected_.IConduitable
		//,
		//manifold_.IDimTwo
		//,
		splash_.IRoadable
		//, ITract/// <see cref="planar.drawable_.connected_.IBroadable"/>
	//,
	//sub_.connected_.IRoadable

	{
	}

}
