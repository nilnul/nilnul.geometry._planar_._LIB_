using nilnul.geometry.planar.cloze_;
using nilnul.rel_.net_._tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.facet_.gon
{
	/// <summary>
	/// each hole of the gon can constrain  another set of <see cref="facet_.gon"/>. The nested can still be represented by a single polyline by conduit inner facet to outer facet with a conduit; note the conduit inside a facet is a cut to pass out bubbles, while the conduit inside a hole is a cut to connect the inner surrounded stuff.
	/// But this is not prefered as:
	///		we can separately handle them
	///		there will be a line in the hollowed area. For <see cref="facet_.IGon"/>, the line hides in where is not hollow; but for hollowed area, the line is not hidden well.
	/// </summary>
	public class Nest
		: IEnumerable<facet_.Gon4dbl>
	{
		private facet_.Gon4dbl _outer;

		public facet_.Gon4dbl outer
		{
			get { return _outer; }
			set { _outer = value; }
		}

		private IEnumerable<(cycle_.gon_.Antiwise4dbl, IEnumerable<Nest>)> _inners;

		public IEnumerable<(cycle_.gon_.Antiwise4dbl, IEnumerable<Nest>)> inners
		{
			get { return _inners; }
			set { _inners = value; }
		}

		Nest(
		   facet_.Gon4dbl outer
		   ,
IEnumerable<(cycle_.gon_.Antiwise4dbl, IEnumerable<Nest>)> inners

	   )
		{
			this._outer = outer;
			this._inners = inners;

		}




		public static Nest Of(nilnul.rel_.net_._tree.Unconstrained<cycle_.Polygon4dblI> n)
		{
			var contour = n.root;
			var children = n.children.Select(c => c.root);

			return new Nest(
				new facet_.Gon4dbl(contour, children)
				,
				n.children.Where(
					outerChild => outerChild.children.Any()
				).Select(
					outerChild => (
						new cycle_.gon_.Antiwise4dbl(
						outerChild.root
						)
						,
						outerChild.children.Select(
							innerContour => Of(innerContour)
						)
					)
				)
			);


		}

		public IEnumerator<Gon4dbl> GetEnumerator()
		{
			yield return this._outer;
			foreach (var innerNestedS in this.inners.Select(x=>x.Item2))
			{
				foreach (var innerNested in innerNestedS)
				{
					foreach (var item2 in innerNested)
					{
						yield return item2;
					}
				}
			}


			//throw new NotImplementedException();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			//throw new NotImplementedException();
		}
	}
}
