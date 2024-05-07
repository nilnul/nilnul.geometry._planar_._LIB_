using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	/// <summary>
	/// for each entity, establish a new coordinate system which is the world coordinates. the point would have a new coordinate in addition to old one. The point and the entity is physically intact.
	/// </summary>
	/// <see cref="geometry.linear.Vw"/>
	///		we may establish a new coordinates of an origin different from old one. <see cref="morph_.affine_.ITranslateOnly"/>
	///		we may flip the coordinates. <see cref="morph_.matrixed_.IScaleOnly"/>
	/// 
	public interface IVw
	{
	}
}
