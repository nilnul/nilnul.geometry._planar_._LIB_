using nilnul.geometry.planar.tope_._bloc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon_.octa_
{

	/// <summary>
	/// 8-vertexes
	/// </summary>
	public interface IBidirectionalArrow
	{

	}
	/// <summary>
	/// note:
	///		for the size of the arrow, the width of the arrow is how much we extend the center span. So, to reduce confusing, we might visualize the arrow in our mind as horizontal such that:
	///			the length of the size is the length arrow
	///			the width of the size is the width (height on screen ) of the arrow
	/// </summary>
	public class BidirectionalArrow4Dbl

			:

			zone_._gon_.Vertexes4dblI
			,

			IBidirectionalArrow
	{

		/// <summary>
		/// must be nonnil to decide the direction of the arrow head.
		/// </summary>
		private planar.grad_.skid_.ByPoints4Dbl _grad;

		public planar.grad_.skid_.ByPoints4Dbl grad
		{
			get { return _grad; }
			set { _grad = value; }
		}

		private tope_. _bloc.SpreadDbl _arrowBounding;

		public tope_. _bloc.SpreadDbl arrowBounding
		{
			get { return _arrowBounding; }
			set { _arrowBounding = value; }
		}


		public BidirectionalArrow4Dbl(planar.grad_.skid_.ByPoints4Dbl grad, SpreadDbl arrowBounding)
		{
			this._grad = grad;
			this._arrowBounding = arrowBounding;
		}

		public BidirectionalArrow4Dbl(
			Point4dbl startOfInnerLine
			,
			Point4dbl endOfInnerLine
			,
			tope_._bloc.SpreadDbl arrowBounding
		)
		: this(
			  new grad_.skid_.ByPoints4Dbl(startOfInnerLine, endOfInnerLine)
			  ,
			  arrowBounding
		)
		{
		}



		public IEnumerable<Point4dbl> vertexesFroEnd
		{
			get
			{


				yield return this._grad.end.ToOrthogonal();
				//

				var vectorToTurn = new planar.vect_.Polar4dbl(
					this._grad.direction - nilnul.num.real_.TauX.QuarterD
					,
					this.arrowBounding.width.realee.ee / 2
				);

				yield return this._grad.end.ToOrthogonal() + vectorToTurn;

				yield return this._grad.end.ToOrthogonal() + new planar.vect_.Polar4dbl(
					this._grad.direction,
					this.arrowBounding.height.realee.ee
				);


				yield return this._grad.end.ToOrthogonal() - vectorToTurn;



				yield return this._grad.end.ToOrthogonal();


				yield return this._grad.begin.ToOrthogonal();

				///the other triangle
				///
				yield return this._grad.begin.ToOrthogonal() - vectorToTurn;


				yield return this._grad.begin.ToOrthogonal() - new planar.vect_.Polar4dbl(
this._grad.direction,
					this.arrowBounding.height.realee.ee
				);


				yield return this._grad.begin.ToOrthogonal() + vectorToTurn;
				/// note here we must line2 the grad.begin
				///
				yield return this._grad.begin.ToOrthogonal();
				/// here the digon will be repeated to the grad.end.

			}
		}
		public IEnumerable<Point4dblI> vertexes
		{
			get
			{
				return vertexesFroEnd;
			}
		}
		public IEnumerable<Point4dblI> vertexesFroBegin
		{
			get
			{

				yield return this._grad.begin;

				var vectorToTurn = new planar.vect_.Polar4dbl(
					this._grad.direction - nilnul.num.real_.TauX.QuarterD
					,
					this.arrowBounding.width.realee.ee / 2
				);

				///the other triangle
				///
				yield return new Point4dbl( this._grad.begin )- vectorToTurn;


				yield return new Point4dbl(this._grad.begin) - new planar.vect_.Polar4dbl(
this._grad.direction,
					this.arrowBounding.height.realee.ee
				);


				yield return new Point4dbl(this._grad.begin )+ vectorToTurn;


				yield return this._grad.end;
				//


				yield return new Point4dbl(this._grad.end) + vectorToTurn;

				yield return new Point4dbl(this._grad.end )+ new planar.vect_.Polar4dbl(
					this._grad.direction,
					this.arrowBounding.height.realee.ee
				);


				yield return this._grad.end.ToOrthogonal() - vectorToTurn;



				yield return this._grad.end;



			}
		}

		public planar.Point4dbl beginTip
		{
			get
			{
				var vect4arrowHead = new planar.vect_.Polar4dbl(
					grad.direction,
					arrowBounding.width.realee
				);
				return new Point4dbl( grad.begin) - vect4arrowHead;
				
			}

		}

		public planar.Point4dbl endTip
		{
			get
			{
				var vect4arrowHead = new planar.vect_.Polar4dbl(
					grad.direction,
					arrowBounding.width.realee
				);
				return
					grad_._StepX.End(
					grad.end , vect4arrowHead
					);
				
			}

		}
		static public BidirectionalArrow4Dbl OfTips(
			planar.Point4dbl start
			,
			planar.Point4dbl end
			,
			tope_._bloc.SpreadDbl arrowBounding


		)
		{

			var grad = new planar.grad_.skid_.ByPoints4Dbl(
				start, end
			);

			var vect4arrowHead = new planar.vect_.Polar4dbl(
				grad.direction
				,
				arrowBounding.width.realee
			);

			var innerStart = start + vect4arrowHead;
			var innerEnd = end - vect4arrowHead;

			return new BidirectionalArrow4Dbl(
				innerStart
				,
				innerEnd
				,
				arrowBounding

			);
		}

	}

}
