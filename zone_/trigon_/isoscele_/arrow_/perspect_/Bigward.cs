//using nilnul.geometry.planar._bloc;
using nilnul.geometry.planar.tope_;
using nilnul.geometry.planar.tope_._bloc;
using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.geometry.planar.zone_.trigon_.isoscele_.arrow_.perspect_
{
	/// <summary>
	/// points to bigger along perspect axis
	/// </summary>
	public class Bigward
		//:
		//nilnul.obj.Box1<
		//	nilnul.num.real_.PositiveDbl
		//>
	{



		private nilnul.geometry.planar.tope_.BlocDbl _bloc;
			
		public nilnul.geometry.planar.tope_.BlocDbl bloc
		{
			get { return _bloc; }
			set { _bloc = value; }
		}




		public Bigward(nilnul.geometry.planar.tope_.BlocDbl val) 
		{
			this._bloc = val;
		}

		public Bigward(Point4dbl end, SpreadDbl headBound)
			:
			this(
				new BlocDbl(end,headBound)
		)
		{
		}

		public nilnul.geometry.planar.Point4dbl vortex
		{
			get {
				return  geometry.planar.vect_.horizon.TranslateX.Shift(
					_bloc.size1.width.realee.ee/2
					,
					this._bloc.point3
				)
				;
			}
		}

		public nilnul.geometry.planar.Point4dbl leftBase {
			get {
				return _bloc.point;
			}
		}


		public nilnul.geometry.planar.Point4dbl rightBase {
			get {
				return _bloc.point1;
			}
		}


		public XElement draw() {
			return new XElement(
				"path"
				,
				new XAttribute(
					"d"
					,
					nilnul.characters.map_.xmL_.attr_._White2spaceX.White2space(
						$@"
							M {this.leftBase.ToTxt_bare()}
							L {this.rightBase.ToTxt_bare()}
							L {this.vortex.ToTxt_bare()}
							Z

						"
					)
				)
			);
		}


	}
}
