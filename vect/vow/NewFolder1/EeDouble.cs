using System;

namespace nilnul.geometry.planar.vect.vow
{
	[Obsolete(nameof(vect.vow.Ee4dbl))]
	public class EeDouble<TVow> : nilnul.obj.vow.Ee1<planar.Vector4dblI, TVow>
		where TVow : planar.vect.VowDoubleI
	{
		public EeDouble(Vector4dblI val, TVow vow) : base(val, vow)
		{
		}
	}
}
