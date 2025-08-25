using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._sub
{
	/// not: <see cref="nilnul.num.real.IFn"/> as the range is complex number, not real number;
	/// <summary>
	///  real -> complex
	/// as there is a bijection between a line and a plane, a locus can be used to describe a surface. (actually it can be used to define 3d soids). We can use as a "point cloud";
	/// eg:
	///		split a real number, say: 123.456
	///		,by odd even offset from the point,:
	///			13.5
	///			2.46
	///		
	/// But the mapping is not continuous.
	/// </summary>
	/// <remarks>
	/// this also acts as the top type of <see cref="nilnul._ral.IMapping"/> of real -> complex;
	/// 
	/// it can be incontinuous:
	///		<see cref="curve_.IPiecewise"/>
	///		pathological, eg:<see cref=""/>
	///	;
	///	this can represent <see cref="geometry.planar.ISub"/>
	/// </remarks>
	/// alias:
	///		locus
	///		fn
	///		orbit
	///		
	///		planet
	///		world
	///		universe
	///	vs:
	///		<see cref="nilnul.num.real.IFn"/>, the tgt of which is real whileas the tgt of this is complex;
	///	vs:
	///		<see cref="nilnul.num.complex.IFn"/>, the src of which is complex whileas the src of this is real, interpretable as time;
	///		
	public interface ILocus :
		nilnul._ral.IMapping	///<>
		, nilnul.num.complex.of_.IOfReal
		,
		nilnul.geometry.planar.ILocus

		///, nilnul.num.real.map
	{
	}


}
