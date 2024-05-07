using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.gon_.quad_
{
	/// <summary>
	/// traezoid that can be:
	///		,trivia, like four same points
	///		
	///		, regressed, like points: a,a,b,b, or  a,a,b,c or  points: a,b,b,a, where a!=b
	///		, trigon, like points: a,a,b,c
	///	 or nonsimples ones.
	/// </summary>
	/// alias:
	///		梯形
	///		trapezium
	///		trapezoid
	///		trape
	public interface ITrapezoid:ITetragon
	{
	}
}
