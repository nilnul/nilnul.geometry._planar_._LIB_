using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.drawable_.tape
{
	/// <summary>
	/// a tape projected to two points
	/// </summary>
	public class Projected
		: nilnul.obj.Box_pub<drawable_.Tape4dbl>
	{

		private nilnul.num.real_.NonnegOfDouble _projectile;

		public nilnul.num.real_.NonnegOfDouble projectile
		{
			get { return _projectile; }
			set { _projectile = value; }
		}

		private nilnul.num.real_.NonnegOfDouble _eave;

		public nilnul.num.real_.NonnegOfDouble eave
		{
			get { return _eave; }
			set { _eave = value; }
		}


		public Projected(Tape4dbl val) : base(val)
		{

		}





	}
}
