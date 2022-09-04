using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.vow
{
	public class Ee<TVow> : nilnul.obj.vow.Ee1<planar.IVector, TVow>
		where TVow : planar.vect.VowI
	{
		public Ee(IVector val, TVow vow) : base(val, vow)
		{
		}
	}




	public class Ee_vowDefault<TVow> : Ee<TVow>
		where TVow : planar.vect.VowI,new()

	{
		public Ee_vowDefault(IVector val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}

	public class Ee : Ee<planar.vect.VowI>
	{
		public Ee(IVector val, VowI vow) : base(val, vow)
		{
		}
	}
}
