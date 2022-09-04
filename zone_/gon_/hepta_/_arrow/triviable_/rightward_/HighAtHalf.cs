using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.geometry.planar.zone_.gon_.hepta_._arrow.triviable_.rightward_
{

	public class HighAtHalf
	{
		private planar.tope_._bloc.SpreadDbl  _tailHalfHigh;
		public planar.tope_._bloc.SpreadDbl tailHalfHigh
		{
			get { return _tailHalfHigh; }
			set { _tailHalfHigh = value; }
		}

		private planar.tope_._bloc.SpreadDbl _headIncrementHalves;

		public planar.tope_._bloc.SpreadDbl headIncrementHalves
		{
			get { return _headIncrementHalves; }
			set { _headIncrementHalves = value; }
		}

		private double _tailHalfHeightNeg;
		private double _headHeightHalf;

		public HighAtHalf(

		 planar.tope_._bloc.SpreadDbl tailHalfHigh_
			,
		 planar.tope_._bloc.SpreadDbl headIncrementHalves_

		)
		{
			this._tailHalfHigh = tailHalfHigh_;
			this._headIncrementHalves = headIncrementHalves_;


			_tailHalfHeightNeg = -_tailHalfHigh.height.realee.ee;


			_headHeightHalf = _tailHalfHigh.height.realee.ee + _headIncrementHalves.height.realee.ee ;


		}

		
		public IEnumerable<Point4dblI> vertexes
		{
			get
			{

				var downLeft = new Point4dbl(0, _tailHalfHeightNeg);
				yield return downLeft;

				var tailRightDown =  new Point4dbl( _tailHalfHigh.width.realee, _tailHalfHeightNeg );
				yield return tailRightDown;

				var lowest =new Point4dbl(
					_tailHalfHigh.width.realee
					,
					_tailHalfHeightNeg

					-_headHeightHalf
				);
				yield return lowest;

				/// the tip point
				yield return new Point4dbl(
					_tailHalfHigh.width.realee + _headIncrementHalves.width.realee.ee
					,
					0
				);

				yield return planar.point.op_.unary_.flip_._AlongHorizonX.Op_retClass(
					lowest
				);

				yield return planar.point.op_.unary_.flip_._AlongHorizonX.Op_retClass(
					tailRightDown
				);

				yield return planar.point.op_.unary_.flip_._AlongHorizonX.Op_retClass(
					downLeft
				);


			}
		}


		public XElement draw() {

			return cloze_.gon._DrawX.El(
				this.vertexes
			);
		}

	}
}
