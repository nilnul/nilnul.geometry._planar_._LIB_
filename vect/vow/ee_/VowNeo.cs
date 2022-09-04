using System;

namespace nilnul.geometry.planar.vect.vow.ee_
{
	[Obsolete(nameof(VowNeo4Dbl<TVow>))]
	public class VowNeo<TVow> : Ee4dbl<TVow>
		where TVow : planar.vect.Vow4dblI,new()

	{
		public VowNeo(Vect4dblI val) : base(val, 
				nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
		)
		{
		}
	}
}
