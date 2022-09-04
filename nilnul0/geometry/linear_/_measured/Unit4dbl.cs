namespace nilnul.geometry.linear_._measured
{
	/// <summary>
	/// meter
	/// </summary>
	/// <remarks>
	/// alias:
	///	translation:
	///			公尺
	/// </remarks>
	public class Unit4dbl :
		nilnul.obj._measure.Unit4dbl,

		 Unit4dblI
	{


		public override string ToString()
		{
			return "m";
		}

		static public Unit4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Unit4dbl>.Instance;
			}
		}


		

	}





}
