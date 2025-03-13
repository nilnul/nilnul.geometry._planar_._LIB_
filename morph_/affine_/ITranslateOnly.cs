using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_.affine_
{
	/// <see cref="_affine_.ICoordinate"/>, here we can only use coordinate by putting newCoord at the left.
	/// This is in fact a 3d transformation; the new (x',y', 1) is a point on plane at z=1, with reference of the new basis (I,J, [dx,dy,1] ). the transformed coord is the old coord, which is by reference to the old basis(I,J,K): x'+dx, y'+dy, 1, as the planar old coords at z=0 is mapped to the new coord (x',y',1)
	/// <summary>
	/// move; shift; drift; displace; deviate;
	/// </summary>
	/// 
	public interface ITranslateOnly
	{
		
	}


}
