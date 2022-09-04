using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon_.hepta_._arrow0
{

	/// <summary>
	///		this is not implementable as we cannot decide the orientation if the line is trivia
	/// </summary>
	public class Trivia4dbl
		:
		
		tope_._polygon_.Vertexes4dblI 
		//,

		//IArrow
	{

		/// <summary>
		/// must be nonnil to decide the direction of the arrow head.
		/// </summary>
		private planar.Grad4dbl_byPoints _grad;

		public planar.Grad4dbl_byPoints grad
		{
			get { return _grad; }
			set { _grad = value; }
		}

		private tope_._bloc.SpreadDbl _arrowBounding;

		public tope_._bloc.SpreadDbl arrowBounding
		{
			get { return _arrowBounding; }
			set { _arrowBounding = value; }
		}


		public Trivia4dbl(planar.Grad4dbl_byPoints  grad, tope_._bloc.SpreadDbl arrowBounding)
		{
			this._grad = grad;
			this._arrowBounding = arrowBounding;
		}


		public IEnumerable<Point4dblI> vertexes {
			get {
				yield return this._grad.basis.ToOrthogonal();
				yield return this._grad.finish.ToOrthogonal();
				//

				var vectorToTurn = new planar.vect_.Polar4dbl(
					this._grad.Direction() .direction - nilnul.num.real_.TauX.QuarterD
					,
					this.arrowBounding.width.realee.ee/2
				);

				yield return new planar.VectorDbl( this._grad.end.ToOrthogonal()) + vectorToTurn;

				yield return this._grad.end.ToOrthogonal() + new planar.vect_.Polar4dbl(
this._grad.direction,
					this.arrowBounding.height.realee.ee
				);


				yield return  this._grad.end.ToOrthogonal() - vectorToTurn;


				
			}
		}


	}

}
