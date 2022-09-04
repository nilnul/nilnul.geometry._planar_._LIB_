using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.geometry.planar.zone_.gon_.hepta_._arrow.triviable_
{

	public class Rightward
	{
		private planar.tope_._bloc.SpreadDbl  _tail;
		public planar.tope_._bloc.SpreadDbl tail
		{
			get { return _tail; }
			set { _tail = value; }
		}

		private planar.tope_._bloc.SpreadDbl _headIncrement;

		public planar.tope_._bloc.SpreadDbl headIncrement
		{
			get { return _headIncrement; }
			set { _headIncrement = value; }
		}
		private double _tailHalfHeight;

		private double _tailHalfHeightNeg;
		private double _headHeightHalf;

		public Rightward(

		 planar.tope_._bloc.SpreadDbl tail_
			,
		 planar.tope_._bloc.SpreadDbl headIncrement_

		)
		{
			this._tail = tail_;
			this._headIncrement = headIncrement_;

			_tailHalfHeight = _tail.height.realee / 2;

			_tailHalfHeightNeg = -_tailHalfHeight;


			var headIncrementHeightHalf = _headIncrement.height.realee / 2;
			_headHeightHalf = _tailHalfHeight + headIncrementHeightHalf ;

		}

		public double totalLength {
			get {
				return _tail.width.realee.ee + _headIncrement.width.realee;
			}
		}
		
		public IEnumerable<Point4dblI> vertexes
		{
			get
			{

				var downLeft = new Point4dbl(0, _tailHalfHeightNeg);
				yield return downLeft;

				var tailRightDown =  new Point4dbl( _tail.width.realee, _tailHalfHeightNeg );
				yield return tailRightDown;

				var lowest =new Point4dbl(
					_tail.width.realee
					,
					_tailHalfHeightNeg

					-_headHeightHalf
				);
				yield return lowest;

				/// the tip point
				yield return new Point4dbl(
					_tail.width.realee + _headIncrement.width.realee.ee
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
