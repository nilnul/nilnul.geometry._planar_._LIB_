using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_._gon_
{

	/// <summary>
	/// we use A\B\C to denote the three vertexes. And the edge opposite to each vertex is named as:a/b/c. That is :
	///		a for BC
	///		b for CA
	///		c for AB
	///		
	/// </summary>
	public interface  Opposite2charlie4DblI
	{
		 geometry.planar.Grad4dbl_byPointsI opposite2charlie { get; }
		

	}
}
