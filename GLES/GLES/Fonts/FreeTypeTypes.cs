using System;
using System.Runtime.InteropServices;

namespace GLES.Fonts
{
    /// <summary>
    /// Class to hold the glyph data.
    /// </summary>
    public class GlyphInfo
	{
		public GlyphInfo(int advx, int advy)
        {
			AdvanceX = advx / 64;
			AdvanceY = advy / 64;

			BitmapData = new byte[] { };
        }

		public byte[] BitmapData { get; set; }

		public int X { get; set; }

		public int Y { get; set; }

		public int Width { get; set; }

		public int Height { get; set; }

		public int AdvanceX { get; set; }

		public int AdvanceY { get; set; }
	}

	/// <summary>
	/// Load flags we are using.
	/// </summary>
	public enum LoadFlags : int
    {
		Render = 0x000004
	}

	/// <summary>
	/// An enumeration type used to describe the format of pixels in a given bitmap. 
	/// Note that additional formats may be added in the future.
	/// </summary>
	public enum PixelMode : byte
	{
		/// <summary>
		/// Value 0 is reserved.
		/// </summary>
		None = 0,

		/// <summary>
		/// A monochrome bitmap, using 1 bit per pixel. Note that pixels are stored in most-significant order (MSB),
		/// which means that the left-most pixel in a byte has value 128.
		/// </summary>
		Mono,

		/// <summary>
		/// An 8-bit bitmap, generally used to represent anti-aliased glyph images. Each pixel is stored in one byte.
		/// Note that the number of ‘gray’ levels is stored in the ‘num_grays’ field of the <see cref="FTBitmap"/>
		/// structure (it generally is 256).
		/// </summary>
		Gray,

		/// <summary>
		/// A 2-bit per pixel bitmap, used to represent embedded anti-aliased bitmaps in font files according to the
		/// OpenType specification. We haven't found a single font using this format, however.
		/// </summary>
		Gray2,

		/// <summary>
		/// A 4-bit per pixel bitmap, representing embedded anti-aliased bitmaps in font files according to the
		/// OpenType specification. We haven't found a single font using this format, however.
		/// </summary>
		Gray4,

		/// <summary>
		/// An 8-bit bitmap, representing RGB or BGR decimated glyph images used for display on LCD displays; the
		/// bitmap is three times wider than the original glyph image. See also <see cref="RenderMode.Lcd"/>.
		/// </summary>
		Lcd,

		/// <summary>
		/// An 8-bit bitmap, representing RGB or BGR decimated glyph images used for display on rotated LCD displays;
		/// the bitmap is three times taller than the original glyph image. See also
		/// <see cref="RenderMode.VerticalLcd"/>.
		/// </summary>
		VerticalLcd,

		/// <summary>
		/// An image with four 8-bit channels per pixel, representing a color image (such as emoticons) with alpha
		/// channel. For each pixel, the format is BGRA, which means, the blue channel comes first in memory. The color
		/// channels are pre-multiplied and in the sRGB colorspace. For example, full red at half-translucent opacity
		/// will be represented as ‘00,00,80,80’, not ‘00,00,FF,80’.
		/// </summary>
		/// <seealso cref="LoadFlags.Color"/>
		Bgra
	}

	#region C# versions of the C data structures that we need in order to read out the glyph image data.

	/// <summary>
	/// Internally represents a Face.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	internal struct FaceRec
	{
		internal IntPtr num_faces;

		internal IntPtr face_index;

		internal IntPtr face_flags;

		internal IntPtr style_flags;

		internal IntPtr num_glyphs;

		internal IntPtr family_name;

		internal IntPtr style_name;

		internal int num_fixed_sizes;

		internal IntPtr available_sizes;

		internal int num_charmaps;

		internal IntPtr charmaps;

		internal GenericRec generic;

		internal BBox bbox;

		internal ushort units_per_EM;

		internal short ascender;

		internal short descender;

		internal short height;

		internal short max_advance_width;

		internal short max_advance_height;

		internal short underline_position;

		internal short underline_thickness;

		/// <summary>
		/// Glyph contains the structure that has the data we want.
		/// </summary>
		internal IntPtr glyph;

		internal IntPtr size;

		internal IntPtr charmap;

		internal IntPtr driver;

		internal IntPtr memory;

		internal IntPtr stream;

		internal IntPtr sizes_list;

		internal GenericRec autohint;

		internal IntPtr extensions;

		internal IntPtr @internal;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GenericRec
	{
		internal IntPtr data;

		internal IntPtr finalizer;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct BBox
    {
		internal IntPtr xMin;

		internal IntPtr yMin;

		internal IntPtr xMax;

		internal IntPtr yMax;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GlyphSlotRec
	{
		internal IntPtr library;

		internal IntPtr face;

		internal IntPtr next;

		internal uint reserved;

		internal GenericRec generic;

		internal GlyphMetricsRec metrics;

		internal IntPtr linearHoriAdvance;

		internal IntPtr linearVertAdvance;

		internal IntPtr advancex;

		internal IntPtr advancey;

		internal uint format;

		internal BitmapRec bitmap;

		internal int bitmap_left;

		internal int bitmap_top;

		internal OutlineRec outline;

		internal uint num_subglyphs;

		internal IntPtr subglyphs;

		internal IntPtr control_data;

		internal IntPtr control_len;

		internal IntPtr lsb_delta;

		internal IntPtr rsb_delta;

		internal IntPtr other;

		private IntPtr @internal;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GlyphMetricsRec
	{
		internal IntPtr width;

		internal IntPtr height;

		internal IntPtr horiBearingX;

		internal IntPtr horiBearingY;

		internal IntPtr horiAdvance;

		internal IntPtr vertBearingX;

		internal IntPtr vertBearingY;

		internal IntPtr vertAdvance;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct BitmapRec
	{
		internal int rows;

		internal int width;

		internal int pitch;

		internal IntPtr buffer;

		internal short num_grays;

		internal PixelMode pixel_mode;

		internal byte palette_mode;

		internal IntPtr palette;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct OutlineRec
	{
		internal short n_contours;

		internal short n_points;

		internal IntPtr points;

		internal IntPtr tags;

		internal IntPtr contours;

		internal Int32 flags;
	}

	#endregion


}
