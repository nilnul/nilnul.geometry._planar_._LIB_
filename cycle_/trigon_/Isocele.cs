using nilnul.geometry.planar.vect_.nontrivia_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.trigon_
{
	public class Prism4dbl
		:
		nilnul.obj.Box1<
			planar.vect_.nontrivia_.Horizon4dbl
		>
	{
		private planar.point_.PositiveWai4Dbl _apex;

		public planar.point_.PositiveWai4Dbl apex
		{
			get { return _apex; }
			set { _apex = value; }
		}

		public Prism4dbl(
			Horizon4dbl val
			,
planar.point_.PositiveWai4Dbl apex0

		) : base(val)
		{
			this._apex = apex0;
		}


	}
}
