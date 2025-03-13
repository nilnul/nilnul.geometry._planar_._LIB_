using System;

namespace nilnul.geometry.planar.point.trio.be_
{
	[Obsolete(nameof(Steps),true)]
	public class Angulated_pivot1st :
		nilnul.geometry.planar.point.trio.Be
		,trio.BeDblI
	{
		public Angulated_pivot1st()
			: base(_Angulated_pivot1stX.Be)
		{

		}

		

		public bool be(TrioD obj)
		{
			return _Angulated_pivot1stX.Be(obj);
		}


		static public Angulated_pivot1st Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Angulated_pivot1st>.Instance;
			}
		}

	}



}
