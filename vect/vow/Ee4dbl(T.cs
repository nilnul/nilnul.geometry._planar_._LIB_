namespace nilnul.geometry.planar.vect.vow
{
	public class Ee4dbl<TVow>
		:
		nilnul.obj.vow.Ee1<planar.Vect4dblI, TVow>

		where TVow : planar.vect.Vow4dblI
	{
		public Ee4dbl(Vect4dblI val, TVow vow) : base(val, vow)
		{
		}
	}
}
