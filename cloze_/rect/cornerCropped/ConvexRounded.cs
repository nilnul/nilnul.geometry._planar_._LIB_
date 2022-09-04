using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.rect.cornerCropped
{
	/// <summary>
	/// a <seealso cref="nameof(ICross)"/>, with the convex corner rounded. Some cross road is designed as such, in order for vehicles to have a round angle of view and a round moving trail.
	/// </summary>
	public class ConcaveRounded
	{
		private planar.Point4dblI _starter;

		public planar.Point4dblI starter
		{
			get { return _starter; }
			set { _starter = value; }
		}

		private planar.Vect4dblI _vectTop;

		public planar.Vect4dblI vectTop
		{
			get { return _vectTop; }
			set { _vectTop = value; }
		}


		private num.real_.NonnegOfDoubleI _cornerDownward;
		public num.real_.NonnegOfDoubleI cornerDownward
		{
			get { return _cornerDownward; }
			set { _cornerDownward = value; }
		}


		




		private num.real_.NonnegOfDoubleI _radius;

		public num.real_.NonnegOfDoubleI radius
		{
			get { return _radius; }
			set { _radius = value; }
		}

		

		private num.real_.NonnegOfDoubleI _cornerRightward;

		public num.real_.NonnegOfDoubleI cornerRightward
		{
			get { return _cornerRightward; }
			set { _cornerRightward = value; }
		}

		

		
		private num.real_.NonnegOfDoubleI _verticalEdgeRemain;

		public num.real_.NonnegOfDoubleI verticalEdgeRemain
		{
			get { return _verticalEdgeRemain; }
			set { _verticalEdgeRemain = value; }
		}








	}
}
