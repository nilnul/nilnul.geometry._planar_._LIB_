namespace nilnul.geometry.planar.vect.vow.ee_
{
	public class VowNeo4Dbl<TVow> : Ee4dbl<TVow>
		where TVow : planar.vect.Vow4dblI,new()

	{
		public VowNeo4Dbl(Vect4dblI val) : base(val, 
				nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
		)
		{
		}
	}
}
