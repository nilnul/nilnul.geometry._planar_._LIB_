using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.set.op_.binary_.minkowski_
{
	/// <summary>
	/// note: this is different from <see cref="Minus"/>.
	/// </summary>
	/// <seealso cref="Erosion"/>
	 class Diff
		:
		Binary4dblI
	{
		public Set4dbl op(Set4dbl par, Set4dbl par1)
		{

			throw new NotImplementedException();
		}

		static public Diff Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Diff>.Instance;
			}
		}

	}
}
