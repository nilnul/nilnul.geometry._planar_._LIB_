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
	///			,loc
	///		local
	///		locale
	///		locality
	///		locator
	///		location
	///
	///;
	///vs:
	///		<see cref="nilnul.num.real.IFunc"/>, the tgt of which is scalar, not complex a vector;
	///		
	/// <see cref="_sub.ILocus"/>
	///	
	public interface ILocus
		:
		nilnul.num.complex.of_.IOfReal
		,
		curl.IUnDirected
		,
		ILapse
		,
		ITrail
		,
		manifold_.IDimOne
	{
	}
}