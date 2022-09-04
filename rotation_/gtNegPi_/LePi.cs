using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation_.gtNegPi_
{
	public class LePi : planar.rotation.be.en_.BeDefaulted<planar.rotation.be_.gtNegPi_.LePi>
	{
		public LePi(RotationI1 val) : base(val)
		{
		}
		public LePi(nilnul.num.RealI x):this( new planar.Rotation1(x))
		{

		}
	}
}
