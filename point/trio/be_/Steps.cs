using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.trio.be_
{

	//[Obsolete(nameof(_Angulated_pivot1stX) + ".  curve_.piecewise_.polystep_.Di can be less misleading; " + nameof(curve_.piecewise_.polystep_.IDi))]
	[Obsolete(nameof(grad_.step.co_.Chain))]
	public class Steps :
		nilnul.geometry.planar.point.trio.Be
		,trio.BeDblI
	{
		public Steps()
			: base(_StepsX.Be)
		{

		}

		static public Steps Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Steps>.Instance;
			}
		}

		public bool be(TrioD obj)
		{
			return _StepsX.Be(obj);
		}
	}



}
