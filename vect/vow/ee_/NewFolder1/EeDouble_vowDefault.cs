using System;

namespace nilnul.geometry.planar.vect.vow
{
	[Obsolete(nameof(vect.vow.ee_))]
	public class EeDouble_vowDefault<TVow> : EeDouble<TVow>
		where TVow : planar.vect.VowDoubleI,new()

	{
		public EeDouble_vowDefault(Vector4dblI val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
