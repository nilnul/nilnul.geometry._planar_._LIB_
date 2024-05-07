using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry
{
	/// as <see cref="nilnul.ITime"/> is a 1d real axis, the 1d geometry would be trivia when it comes to adding some new concepts. And should it be a separate project, we might package it every time it updates before being installed here.
	/// Hence we merged linear into 2d geometry.
	/// <summary>
	/// with invariant timeAxis in background context, this visualizes the dynamics of 1d (a real number) change. 
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// vs:
	///		nilnul.num.real, whileas this takes time axis as a contextual invariant|fixed|insensitive|oneWay information that is not visualized here. So this follows nilnul.num.real;
	/// 
	public interface ILinear:
		nilnul.geometry.IOriginal	//share the same origin
	{
	}
}
