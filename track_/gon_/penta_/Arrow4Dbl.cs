﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.trac_.gon_.penta_
{

	/// <summary>
	/// a line with an arrowhead; the head is not trivia.
	/// Note this is not a <see cref="IHeptagon"/>, as the line is a line,not a rect.
	/// </summary>
	public class Arrow4Dbl
		:
		
		cloze_._gon_.Vertexes4dblI
		//,

		//IArrow
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

		private tope_._bloc.size_.Spanned4dbl _arrowBounding;

		public tope_._bloc.size_.Spanned4dbl arrowBounding
		{
			get { return _arrowBounding; }
			set { _arrowBounding = value; }
		}


		public Arrow4Dbl(planar.grad_.skid_.ByPoints4Dbl grad, tope_._bloc.size_.Spanned4dbl arrowBounding)
		{
			this._grad = grad;
			this._arrowBounding = arrowBounding;
		}


		public IEnumerable<Point4dblI> vertexes {
			get {
				yield return this._grad.begin.ToOrthogonal();
				yield return this._grad.end.ToOrthogonal();
				//

				var vectorToTurn = new planar.vect_.Polar4dbl(
					this._grad.direction - nilnul.num.real_.TauX.QuarterD
					,
					this.arrowBounding.width.dblen.ee/2
				);

				yield return new planar.VectorDbl( this._grad.end.ToOrthogonal()) + vectorToTurn;

				yield return this._grad.end.ToOrthogonal() + new planar.vect_.Polar4dbl(
this._grad.direction,
					this.arrowBounding.height.dblen.ee
				);


				yield return  this._grad.end.ToOrthogonal() - vectorToTurn;


				
			}
		}


	}

}