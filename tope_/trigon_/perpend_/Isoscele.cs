using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tope_.trigon_.perpend_
{
	public class Isoscele4dbl
		:zone_._gon_.Vertexes4dblI
	{

		private geometry.planar.Grad4dbl_byPointsI _leg;

		public geometry.planar.Grad4dbl_byPointsI leg
		{
			get { return _leg; }
			set { _leg = value; }
		}

		private bool _rotationwise;

		public bool rotationwise
		{
			get { return _rotationwise; }
			set { _rotationwise = value; }
		}

		public Isoscele4dbl(geometry.planar.Grad4dbl_byPointsI leg,bool rotationwise)
		{
			this._leg = leg;
			this._rotationwise = rotationwise;
		}


		static public Isoscele4dbl OfFirstQuadrantSected( nilnul.num.real_.NonnegOfDouble length) {
			return new Isoscele4dbl(
				new grad_.originated_.Eks4dbl(length)
				,
				true
			);
		}

		static public Isoscele4dbl OfFirstQuadrantSected( double length) {
			return OfFirstQuadrantSected(new num.real_.NonnegOfDouble(length));
		}

		public nilnul.geometry.planar.Point4dbl otherPoint {
			get {
				var rotationVec = _rotationwise ? geometry.planar.vect_.norm_.Polar4dbl.OfQuarter() : vect_.norm_.Polar4dbl.OfNegQuarter();
				var legVect = nilnul.geometry.planar.grad._DisplaceX.Vect(_leg);

				var multi = legVect * rotationVec;

				return _leg.basis + multi;


			}
		}

		/// <summary>
		/// the apex is in the middle.
		/// make sure the vertexs is in the positive swirl
		/// </summary>
		public IEnumerable<Point4dblI> vertexes =>rotationwise?  new Point4dblI[] {
			this.otherPoint
			,
			_leg.basis
			,
			_leg.finish
			,
		}: new Point4dblI[] {
			_leg.finish
			,
			_leg.basis
			,
			this.otherPoint
			,
		};
	}
}
