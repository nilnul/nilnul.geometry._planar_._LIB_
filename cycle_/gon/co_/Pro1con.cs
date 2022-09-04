using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon.co_
{
	/// <summary>
	/// one is facade, the other is back/contrary/reverse/flipside.
	/// this when intersects, is subtraction.
	/// </summary>
	public  class Pro1con4Dbl
	{
		private planar.cycle_.gon_.Facade4dbl _outer;

		public planar.cycle_.gon_.Facade4dbl outer
		{
			get { return _outer; }
			set { _outer = value; }
		}

		private planar.cycle_.gon_.Antiwise4dbl _inner;

		public planar.cycle_.gon_.Antiwise4dbl inner
		{
			get { return _inner; }
			set { _inner = value; }
		}

		public Pro1con4Dbl(
			planar.cycle_.gon_.Facade4dbl facade
			,
			planar.cycle_.gon_.Antiwise4dbl inner
		)
		{
			_outer = facade;
			_inner = inner;
		}
	}
}
