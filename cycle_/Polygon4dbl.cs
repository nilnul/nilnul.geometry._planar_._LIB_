using nilnul.geometry.planar.coil_.gon_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_
{
	/// <summary>
	/// the stokes area is positive.
	/// if it's negative, then the clozed surface is the outside, which is still a surface, but not a zone. As we are under the namespace of zone, hence this polygon here is always positive.
	/// </summary>
	public class Polygon4dbl
		:
		coil_.gon_.poly.be_.cycle.vow.Ee4dbl
		,
		Polygon4dblI
	{

		public Polygon4dbl(Poly4dbl val) : base(val)
		{
		}

		public Polygon4dbl(IEnumerable<Point4dblI> val) : base((val))
		{ }

		public Polygon4dbl(params Point4dblI[] val) : this((IEnumerable<Point4dblI>) (val))
		{ }

		public Polygon4dbl(params Point4dbl[] val) : this((IEnumerable<Point4dbl>) (val))
		{ }

		public Polygon4dbl(params (double, double)[] p1):this(p1.Select( t=>new Point4dbl(t)))
		{
		}


		static public Polygon4dbl Of(IEnumerable<Grad4dbl_byPointsI> grads)

		{
			nilnul.bit.vow_.True1.Vow(
				nilnul.geometry.planar.point.EqDbl.Singleton.Equals(
					grads.First().basis
					,
					grads.Last().finish
				)
			);

			return new Polygon4dbl(
				grads.Select(v=>v.basis)
			);
		}

		public static Polygon4dbl Of(Polygon4dblI val)
		{
			return val switch {
				Polygon4dbl p=>p,
				_=> new Polygon4dbl(val.vertexes)

			};
			//throw new NotImplementedException();
		}
		public static Polygon4dbl _OfCloze(IEnumerable<Point4dblI> val)
		{
			return new Polygon4dbl(
				cloze_._gon.vertexes.op_.unary_._DelNilGradEsX._DelNilGradEs_assumeCloze(val)
			);
			//throw new NotImplementedException();
		}

		public static Polygon4dbl Of(cloze_.Polygon4dblI val)
		{
			return _OfCloze(val.vertexes);
			//throw new NotImplementedException();
		}


		public IEnumerable<Point4dblI> vertexes => this.ee.ee.vertexes;

		public IEnumerable<Grad4dbl_byPointsI> grads {
			get {
				return cloze_.gon._Grads4dblX._Grads_ofStarted(vertexes);
			}
		}
	}
}
