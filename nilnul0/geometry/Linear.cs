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
	/// 1d. 
	/// </summary>
	/// <remarks>
	/// </remarks>
	public interface ILinear:
		nilnul.geometry.IOriginal	//share the same origin
	{
	}
}
