using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_._trigon_
{

	/// <summary>
	/// now that we know for sure the three points can not be incident, then we can name them separately.
	/// we use A\B\C to denote the three vertexes. And the edge opposite to each vertex is named as:a/b/c. That is :
	///		a for BC
	///		b for CA
	///		c for AB
	///		
	/// </summary>
	public interface Vertexes4dblI
		: point._trio_.Vertexes4dblI
	{
		

	}
}
