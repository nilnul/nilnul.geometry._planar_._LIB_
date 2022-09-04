using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation.be_
{

	

	/// <summary>
	/// </summary>
	public class GtNegPi :

		rotation.BeI
	{
		public bool be(RotationI1 obj)
		{
			return obj.quantity.ToReal() > -nilnul.num.real_.TauX.Half;
		}
		static public GtNegPi Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<GtNegPi>.Instance;
			}
		}
	}
}