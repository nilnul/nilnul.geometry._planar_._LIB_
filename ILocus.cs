using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar
{
	/// <summary>
	/// track
	/// </summary>
	/// alias:
	///		track
	///		traject
	///		locus
	///			"l" is also the initial of "linear"
	public interface ILocus
		:
		curl.IUnDirected
		,
		ILapse
		,
		ITrail
		, manifold_.IDimOne
	{
	}
}