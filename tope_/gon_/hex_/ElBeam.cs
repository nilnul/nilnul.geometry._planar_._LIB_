using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tope_.polygon_.hex_
{
	public class ElBeam4Dbl : Simple4dblI
	{

		private nilnul.num.real_.nonneg.co.be_.ge.vow.Ee _horizons;

		public nilnul.num.real_.nonneg.co.be_.ge.vow.Ee horizons
		{
			get { return _horizons; }
			set { _horizons = value; }
		}


		private nilnul.num.real_.nonneg.co.be_.ge.vow.Ee _verticals;

		public nilnul.num.real_.nonneg.co.be_.ge.vow.Ee verticals
		{
			get { return _verticals; }
			set { _verticals = value; }
		}

		public IEnumerable<Point4dblI> vertexes  {
			get {
				yield return planar.Point4dbl.CreateZero();


				yield return new planar.point_.Horizon4dbl(
					_horizons.ee.component.realee.ee

				);

				var verticalDif =
					_verticals.ee.component.realee.ee
					- verticals.ee.component1.realee.ee
				;

				yield return new  planar.Point4dbl(
					_horizons.ee.component.realee.ee
					,
					verticalDif

				);

				var horizonDif = _horizons.ee.component.realee.ee
					-
					_horizons.ee.component1.realee.ee
				;

				yield return  new planar.Point4dbl(
					horizonDif
					,
					verticalDif
				);

				yield return new planar.Point4dbl(
					horizonDif
					,
					_verticals.ee.component.realee.ee
				);

				yield return  new planar.point_.Vertical4dbl(
					_verticals.ee.component.realee.ee
				);
				







			}
		}

		public ElBeam4Dbl(
			nilnul.num.real_.nonneg.co.be_.ge.vow.Ee horizons
			,
			nilnul.num.real_.nonneg.co.be_.ge.vow.Ee verticals
		)
		{
			this._horizons = horizons;
			this._verticals = verticals;
		}

		public ElBeam4Dbl(double x, double x1, double y, double y1)
			:this(
				 new num.real_.nonneg.co.be_.ge.vow.Ee( new num.real_.nonneg.CoDbl( x,x1))
				 ,
				 new num.real_.nonneg.co.be_.ge.vow.Ee(
					 new num.real_.nonneg.CoDbl( y,y1)
					)
			)
		{

		}


	}
}
