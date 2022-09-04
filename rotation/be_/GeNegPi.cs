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
	public class GeNegPi :

		rotation.BeI
	{
		public bool be(RotationI1 obj)
		{
			return obj.quantity.ToReal() >= -nilnul.num.real_.TauX.Half;
		}
		static public GeNegPi Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<GeNegPi>.Instance;
			}
		}
	}
}