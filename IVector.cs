using System;

namespace nilnul.geometry.planar
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		deviate
	///			,<see cref="geometry.planar.grad_.IDeviate"/>
	///		drift
	///		moor
	///		offset
	///		vect
	[Obsolete(nameof(IVect))]
	public interface IVector
	{
		planar.Point1 point { get; }
	}
}
