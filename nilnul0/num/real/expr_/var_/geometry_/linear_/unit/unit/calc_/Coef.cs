using nilnul.geometry.linear_._measured.unit.calc_.indic;

namespace nilnul.geometry.linear_._measured.unit.calc_
{
	public class Coef :
		nilnul.obj.Box1<double>
		,
		Calc4dblI

	{
		public Coef(double val) : base(val)
		{
		}

		public Prod4dbl toIndics()
		{
			return new Prod4dbl();
			//throw new System.NotImplementedException();
		}
	}
}
