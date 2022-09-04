using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_._trigon_
{

	/// <summary>
	/// we use A\B\C to denote the three vertexes. And the edge opposite to each vertex is named as:a/b/c. That is :
	///		a for BC
	///		b for CA
	///		c for AB
	///		
	/// </summary>
	public interface  Edges4dblI
		:_gon_.Opposite2alfa4DblI
		,
		_gon_.Opposite2beta4DblI
		,
		_gon_.Opposite2charlie4DblI
	{
		 

	}
}
