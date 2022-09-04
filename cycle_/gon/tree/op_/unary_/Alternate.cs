using nilnul.rel_.net_._tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon.tree.op_.unary_
{
	static public class _AlternateX
	{
		/// <summary>
		/// for odd layered, reverse it
		/// </summary>
		/// <param name="tree"></param>
		/// <returns></returns>
		public static Unconstrained<Polygon4dblI> Op(Unconstrained<Polygon4dblI> tree)
		{
			
			return 	Op(tree, false);
			



			//throw new NotImplementedException();
		}

		private static Unconstrained<Polygon4dblI> Op(Unconstrained<Polygon4dblI> item, bool toReverse)
		{

				return new Unconstrained<Polygon4dblI>(
					toReverse?new planar.cycle_.Polygon4dbl(item.root.vertexes.Reverse()): item.root
					,
					item.children.Select(c=> Op(c,!toReverse) ).ToList()
				);
		
		}

	
	}
}
