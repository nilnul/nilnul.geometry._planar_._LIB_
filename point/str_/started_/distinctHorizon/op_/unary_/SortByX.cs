using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.geometry.planar.points_.started_.distinctHorizon.op_.unary_
{
	public class SortByHorizonDbl
		:UnaryDblI
	{
	

		public DistinctHorizonDbl op(DistinctHorizonDbl arg)
		{
			return new DistinctHorizonDbl(
				 points.op_.unary_.SortDbl.CreateByHorizon().op(arg.ee)
			);
			//throw new NotImplementedException();
		}


		static public SortByHorizonDbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<SortByHorizonDbl>.Instance;
			}
		}


	}
}
