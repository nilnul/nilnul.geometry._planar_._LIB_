using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.nonnil
{
	/// <summary>
	/// <seealso cref="planar.zone_.bloc_.ByVect4dbl"/>
	/// </summary>
	///
	[Obsolete(nameof(planar.zone_.bloc_.ByVect4dbl) )]
	public class Bloc4dbl
		:
		nilnul.obj.Box1<Vect4dblI>
		,
		nilnul.geometry.planar.zone_.IBloc

	{
		public Bloc4dbl(Vect4dblI val) : base(val)
		{
		}

	}
}
