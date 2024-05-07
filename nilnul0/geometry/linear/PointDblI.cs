using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

namespace nilnul.geometry.linear
{


	public interface PointDblI:nilnul.geometry.trivia.PointI
	{
		/// <summary>
		/// named such as to be extended in 2d, where we add a "y", and then in 3d, where we furthe as a "z"
		/// </summary>
		double coord { get; }

	}
}
