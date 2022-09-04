using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_.measured
{
	public class Speed4dbl
	{
		private measured.span.Distance4dblI _distance;

		public measured.span.Distance4dblI distance
		{
			get { return _distance; }
			set { _distance = value; } 
		}

		private nilnul.time.seg._measure.Unit4dblI  _duration;

		public nilnul.time.seg._measure.Unit4dblI duration
		{
			get { return _duration; }
			set { _duration = value; }
		}

		public Speed4dbl(measured.span.Distance4dblI distance,nilnul.time.seg._measure.Unit4dblI duration)
		{
			this._distance = distance;
			this._duration = duration;

		}


	}
}
