using nilnul.geometry.planar._angle_;
using nilnul.geometry.planar._ray_;
using nilnul.geometry.planar.point;
using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	/// <summary>
	/// angle has the inital ray, and a rotation.
	/// The terminal ray can be computated.
	/// 
	/// </summary>
	public interface IAngleD:_angle_.IInitialD, _angle_.IAzimuthD
	{
	}


}
