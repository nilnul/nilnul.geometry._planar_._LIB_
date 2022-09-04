using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar_.measured._bloc
{
	public interface SizeI1
		:ISize
	{
		nilnul.geometry.linear_.measured.span.DistanceI width { get; }
		nilnul.geometry.linear_.measured.span.DistanceI height { get; }



	}

	public class Size1 : SizeI1
	{
		private nilnul.geometry.linear_.measured.span.DistanceI _width;

		public nilnul.geometry.linear_.measured.span.DistanceI width
		{
			get { return _width; }
			set { _width = value; }
		}

		private nilnul.geometry.linear_.measured.span.DistanceI _height;

		public nilnul.geometry.linear_.measured.span.DistanceI height
		{
			get { return _height; }
			set { _height = value; }
		}


		public Size1(nilnul.geometry.linear_.measured.span.DistanceI width, nilnul.geometry.linear_.measured.span.DistanceI height)
		{
			_width = width;
			_height = height;
		}





		public override string ToString()
		{
			return $"{_width.ToString()}*{_height.ToString()}";
		}


	}

}
