using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tend_.edge.kakeya_
{
	/// <summary>
	/// Besicovitch showed that there are Besicovitch sets of measure zero.
	/// </summary>
	/// <remarks>
	/// Sprounting the Perron tree:
	/// a method for constructing a Kakeya set of small measure.
	/// 
	///
	/// basis: we  can just use two triangles, dividing our triangle and overlapping the pieces to get a smaller set. # the overlapping part can reduce the area (overlapping is counted only once)
	///
	///  then:  we cat the triangle into eight or 2^n, and each can be appied the above method. 
	///
	/// The method can be used to construct an arbitrarily small set by cutting up the original triangle to  2^{n} pieces.
	///
	/// We can also do this recursively on the bisected skew triangle.
	/// </remarks>
	/// alias:
	///		Besicovitch set
	class IBesicovitch
	{
    }
}
