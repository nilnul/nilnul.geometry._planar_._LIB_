using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.geometry.planar.trac_.gon_.hepta_._arrow.headTope_.perspect_
{

	public class Smallward
	{
		private planar.grad_.skid_.Wai4dbl _tail;

		public planar.grad_.skid_.Wai4dbl tail
		{
			get { return _tail; }
			set { _tail = value; }
		}

		private planar.tope_._bloc.SpreadDbl _headBound;

		public planar.tope_._bloc.SpreadDbl headBound
		{
			get { return _headBound; }
			set { _headBound = value; }
		}

		public Smallward()
		{

		}

		public XElement draw() {
			var orient = this._tail.beBigward;
			planar.Point4dbl[] points;
			if (orient)
			{
				var trigon = new planar.zone_.trigon_.isoscele_.arrow_.perspect_.Bigward(
					this._tail.end
					,
					this._headBound
				);

				 points = new[] { trigon.leftBase, trigon.rightBase, trigon.vortex };

			}
			else
			{
				var trigon = new planar.zone_.trigon_.isoscele_.arrow_.perspect_.Bigward(
					this._tail.end
					,
					this._headBound
				);

				 points = new[] { trigon.leftBase, trigon.rightBase, trigon.vortex };

			}


			return new XElement(
				"path"
				,
				new XAttribute(
					"d"
					,
					nilnul.characters.map_.xmL_.attr_._White2spaceX.White2space(
						$@"
							M {this.tail.basement.ToTxt_bare()}
							L {this.tail.end.ToTxt_bare()}
							L {points[0].ToTxt_bare()}
							L {points[1].ToTxt_bare()}
							L {points[2].ToTxt_bare()}

							Z

						"
					)
				)
			);
		}

	}
}
