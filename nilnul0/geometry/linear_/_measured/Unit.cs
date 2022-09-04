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
	public class Unit :
		nilnul.obj._measure.Unit,

		 UnitI
	{




		public override string ToString()
		{
			return "m";
		}

		static public Unit Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Unit>.Instance;
			}
		}


		

	}





}
