using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gons.of_
{
	/*
	TTF and CFF2 outlines have to be interpreted using the non-zero rule (based on winding number), whereas CFF outlines have to be interpreted using the even-odd rule (which doesn't care about winding in the slightest).


The OpenType spec itself allows for three possible cases:

CFF/Type2 outlines rely on crossing number, so any subpath B contained by outermost subpath A is a cutout, any subpath C inside subpath B is a fill, any subpath D inside C is a cutout, etc.
TTF outlines rely on path direction, so in the above example B is only a cutout for A if either A is defined clockwise and B is defined counter-clockwise.
SVG outlines rely on "literally whichever you want" because glyphs are specified using SVG1.1 documents which means that the fillrule attribute can be used to specify whether crossing (fillrule="evenodd") or direction (fillrule="nonzero") is used.


	for true type, docs.microsoft.com/en-us/typography/opentype/spec/ttch01#outlines
	,the filled is to the right, that is positive rotated as in screen, the y axis points down.

OpenType supports the TrueType glyph outline format, in which a glyph outline is described as second-order Bezier splines

	open types supersedes truetype, supported by both microsoft and apple.Support for both PostScript Type 1 or TrueType outlines
	 */
	class Glyph
	{
	}
}
