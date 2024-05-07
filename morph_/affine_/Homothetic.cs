using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;
using R = nilnul.num.RealI;


namespace nilnul.geometry.planar.morph_.affine_
{
	/// <summary>
	/// shift and scale
	/// </summary>
	public interface HomotheticI
	{
		nilnul.geometry.planar.PointI1 center { get; }
		R ratio { get; }
	}
	public class Homothetic : HomotheticI
	{

		private PointI1 _center;
		public PointI1 center
		{
			get
			{
				return _center;
				throw new NotImplementedException();
			}
		}

		private R _ratio;
		public R ratio
		{
			get
			{
				return _ratio;
				throw new NotImplementedException();
			}
		}

		public Homothetic(PointI1 center, R ratio)
		{
			_center = center;
			_ratio = ratio;
		}
	}
}
