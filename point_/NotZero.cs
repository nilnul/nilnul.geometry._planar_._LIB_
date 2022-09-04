using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.point.be_.nil;
using nilnul.geometry.planar.point.be_.nonnil.vow;
using nilnul.num;

namespace nilnul.geometry.planar.point_
{
	public interface NonnilI
		:PointI

	{
		nilnul.geometry.planar.point.be_.nonnil.vow.Ee pointee { get; }
	}
	public class Nonnil
		: 
		
		nilnul.geometry.planar.point.be_.nonnil.vow.Ee 
		,NonnilI

	{
		public Nonnil(PointI1 val) : base(val)
		{

		}

		public RealI x { get => this.ee.x;  }
		public RealI y { get => this.ee.y; }

		public Ee pointee => this;
	}
}
