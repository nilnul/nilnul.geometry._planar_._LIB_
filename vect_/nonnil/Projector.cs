using nilnul.geometry.planar.vect;
using nilnul.geometry.planar.vect.op_.unary_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.nonnil
{

	public class Projector4dbl
		:
		nilnul.obj.Box_ofIn<planar.vect_.Nonnil4dblI>
	{

		public Projector4dbl(in Nonnil4dblI val) : base(val)
		{
			_length = val.Distance();

			_unitalProjector = new unital.Projector4dbl(
				val.Scale(1/_length)
			); 

		

		}

		private vect_.Nonnil4dblI _nonnil;
		public vect_.Nonnil4dblI nonnil {
			get { return _nonnil; }
		}

		public Projector4dbl(Nonnil4dblI x) : this(in x)
		{
		}

		private vect_.unital.Projector4dbl _unitalProjector;

		public vect_.unital.Projector4dbl unitalProjector
		{
			get { return _unitalProjector; }
		}

		public double _length;
		public double length {
			get {

				return _length;
				//return vect._MagnitudeX.Magnitude(boxed);
			}
		}
		public Vect4dblI unital {
			get {
				return _unitalProjector.unital;
			}
		}

		public double scalar(
				Vect4dblI x
			)
		{
			return _unitalProjector.scalar(x);
			//return vect.co.to_.real_._DotProductX.Dbl(unital,x);
		}

		public Vect4dbl project(
				Vect4dblI x
			)
		{
			return _nonnil.Scale(
				x.Dot(this._nonnil) / _nonnil.Dot(_nonnil)
			);
			//same as:
			//return _unitalProjector.project(x);


			//return vect.co.to_.real_._DotProductX.Dbl(unital,x);

		}

	}
}
