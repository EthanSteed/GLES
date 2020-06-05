using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK.Graphics;

namespace GLES.Fonts
{
    /// <summary>
    /// Bindings for free type.
    /// </summary>
    public static class FreeType
    {
        private const string DLL_NAME = "freetype6";

        private const int SUCCESS = 0;

        //
        // we have to keep hold of lib and face when making calls to the library.
        //
        static IntPtr m_Lib = IntPtr.Zero;
        static IntPtr m_Face = IntPtr.Zero;

        /// <summary>
        /// Loads a font.
        /// </summary>
        public static bool TryLoadFont(string filepath, int pt, uint dpx = 96, uint dpy = 96)
        {
            int err = SUCCESS;

            if (m_Lib == IntPtr.Zero)
            {
                err = FT_Init_FreeType(out m_Lib);
            }

            if (err == SUCCESS)
            {
                // tidy up.
                if (m_Face != IntPtr.Zero)
                {
                    FT_Done_Face(m_Face);
                    m_Face = IntPtr.Zero;                    
                }

                err = FT_New_Face(m_Lib, filepath, 0, out m_Face);
            }

            if (err == SUCCESS)
            {
                // set char size
                err = FT_Set_Char_Size(m_Face, (IntPtr)0, (IntPtr)(pt * 64), dpx, dpy);
            }

            return err == SUCCESS;
        }

        /// <summary>
        /// Try set character size
        /// </summary>
        public static bool TrySetCharSize(int pt, uint dpx = 300, uint dpy = 300)
        {
            bool success = false;

            if (m_Face != IntPtr.Zero)
            {
                success = FT_Set_Char_Size(m_Face, (IntPtr)0, (IntPtr)(pt * 64), dpx, dpy) == SUCCESS;
            }

            return success;
        }

        /// <summary>
        /// Try and get the bitmap for the given character. (String so we can have unicode)
        /// </summary>
        public static bool TryGetCharBitmap(char c, out GlyphInfo glyphinfo)
        {
            bool success = false;
            glyphinfo = null;

            if (m_Face != IntPtr.Zero)
            {
                // load char with Render
                int err = FT_Load_Char(m_Face, c, (int)LoadFlags.Render);

                if (err == SUCCESS)
                {
                    // get face rec.
                    FaceRec f = (FaceRec)Marshal.PtrToStructure(m_Face, typeof(FaceRec));
                    
                    // get the glyph slot.
                    GlyphSlotRec glyph = (GlyphSlotRec)Marshal.PtrToStructure(f.glyph, typeof(GlyphSlotRec));

                    // get the glyph info.
                    glyphinfo = new GlyphInfo((int)glyph.advancex, (int)glyph.advancey);
                    
                    // see if any bitmap data available.
                    if (glyph.bitmap.buffer != IntPtr.Zero)
                    {
                        // get the bitmap data.
                        byte[] bmpdata = new byte[glyph.bitmap.rows * glyph.bitmap.pitch];
                        Marshal.Copy(glyph.bitmap.buffer, bmpdata, 0, bmpdata.Length);

                        glyphinfo.BitmapData = bmpdata;
                        glyphinfo.X = glyph.bitmap_left;
                        glyphinfo.Y = glyph.bitmap_top;
                        glyphinfo.Width = glyph.bitmap.width;
                        glyphinfo.Height = glyph.bitmap.rows;
                    }

                    success = true;

                }
            }

            return success;
        }


        /// <summary>
        /// Finish
        /// </summary>
        /// <returns></returns>
        public static void Finish()
        {
            if (m_Face != IntPtr.Zero)
            {
                FT_Done_Face(m_Face);
                m_Face = IntPtr.Zero;
            }

            if (m_Lib != IntPtr.Zero)
            {
                FT_Done_Library(m_Lib);
                m_Lib = IntPtr.Zero;
            }
        }


        #region Minimal Import list required to get glyph bitmap out

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        private static extern int FT_Init_FreeType(out IntPtr alibrary);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int FT_Done_Library(IntPtr library);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        private static extern int FT_New_Face(IntPtr library, string filepathname, int face_index, out IntPtr aface);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int FT_Done_Face(IntPtr face);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        private static extern int FT_Set_Char_Size(IntPtr face, IntPtr char_width, IntPtr char_height, uint horz_resolution, uint vert_resolution);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int FT_Load_Char(IntPtr face, uint char_code, int load_flags);

        #endregion

    }
}
