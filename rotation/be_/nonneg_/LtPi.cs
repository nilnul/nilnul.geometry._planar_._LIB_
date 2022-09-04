using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation.be_.nonneg_
{


	/// <summary>
	/// </summary>
	public class LtPi :

		rotation.BeI
	{
		public bool be(RotationI1 obj)
		{

			return  nilnul.num.real.bound_._NonnegX.CreateOpen(
				nilnul.num.real_.TauX.Half
			).contains(obj.quantity);
		}
		static public LtPi Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<LtPi>.Instance;
			}
		}
	}
}