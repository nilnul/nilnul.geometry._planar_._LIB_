using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.trigon
{
	/// <summary>
	/// a special case of <see cref="zone_.gon_.quad.Caliper"/>, as we can take the 4th point from the opposite edge, or from the extension of the opposite edge to make a convex quodrilater where one leg(two edge back and fouth are in the same line) is trivia.
	/// </summary>
	public class Caliper
		:
		nilnul.obj.Box_ofIn<zone_.TriangleDbl>
	{

		private nilnul.num.be_.le.vow.ee_.LeTwo _rayBase;
		public nilnul.num.be_.le.vow.ee_.LeTwo rayBase
		{
			get { return _rayBase; }
			set { _rayBase = value; }
		}

		/// <summary>
		/// from one point ,into a direction. The ray will intersect with the opposite edge's line (inside the edge, or outside at the extension).
		/// the two points connected is taken as the basis.
		/// then perpendicular to this ray, we place a caliber/clampRuler to measure the height.
		/// </summary>
		private double _dir;
		public double dir
		{
			get { return _dir; }
			set { _dir = value; }
		}

		public Caliper(in TriangleDbl val) : base(val)
		{
		}

		public Caliper(TriangleDbl x) : base(x)
		{
		}
	}
}