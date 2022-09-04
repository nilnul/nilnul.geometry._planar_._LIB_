using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation.vow
{
	public class Ee : nilnul.obj.vow.Ee1<planar.RotationI1>
	{
		public Ee(RotationI1 val, VowI2<RotationI1> vow) : base(val, vow)
		{
		}

		public Ee(RotationI1 val, planar.rotation.VowI vow):base(val,  vow)
		{

		}
	}
}
