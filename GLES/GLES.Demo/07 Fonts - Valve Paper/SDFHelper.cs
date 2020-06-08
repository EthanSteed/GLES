using System;

namespace GLES.Demo
{
    /// <summary>
    /// Signed Distance Field Helper
    /// </summary>
    public static class SDFHelper 
    {
        // The threshold to use for the incoming 256 grey scale. (127);
        public const int BINARY_THRESHOLD = 0x7F;

        /// <summary>
        /// Generates an SDF Texture - This uses the Dead REcoking Algorithm by G.J Grevera
        ///   https://perso.ensta-paris.fr/~manzaner/Download/IAD/Grevera_04.pdf        
        ///   Code follows the algorithm with only a few tweaks to make it easier to follow the white paper.
        ///   This could be condensed down further into a couple of common functions.
        ///   
        /// </summary>
        public static void GenerateSDFTexture(byte[] input, int width, int height, out float[,] output)
        {
            // converted input buffer from a 256 grey scale to a binary image.
            byte[,] I = new byte[width, height];

            // d - a 2D grey image of sizez x and y
            // p - for each pixel, the corresponding border point.
            float[,] d = new float[width, height];
            Point[,] p = new Point[width, height];

            float d1 = 1f;
            float d2 = (float)Math.Sqrt(2);


            //
            // Initialise d (and input array for convienence)
            //
            for (int y = 1; y < height; y++)
            {
                for (int x = 1; x < width; x++)
                {
                    // initialise d
                    d[x, y] = float.PositiveInfinity;
                    p[x, y] = new Point() { X = 0, Y = 0 };

                    // initialise input to a binary image.
                    I[x, y] = input[(y * width) + x] > BINARY_THRESHOLD ? (byte)1 : (byte)0;                    
                }
            }

            //
            // initialise immediate interior & exterior elements.
            //
            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width -1 ; x++)
                {
                    if (I[x-1,y  ] != I[x,y] || I[x+1,y] != I[x,y] ||
                        I[x  ,y-1] != I[x,y] || I[x,y+1] != I[x,y])
                    {
                        d[x, y] = 0;
                        p[x, y] = new Point() { X = x, Y = y };
                    }
                }
            }

            //
            // Perform first pass (forward)
            //
            for (int y = 1; y < height-1; y++)
            {
                for (int x = 1; x < width-1; x++)
                {
                    if (d[x-1,y-1] + d2 < d[x,y])
                    {
                        p[x, y] = p[x - 1, y - 1];
                        d[x, y] = CalcDistance(p,x,y);
                    }

                    if (d[x,y-1] + d1 < d[x,y])
                    {
                        p[x, y] = p[x, y - 1];
                        d[x, y] = CalcDistance(p, x, y);
                    }

                    if (d[x+1, y-1] + d2 < d[x,y])
                    {
                        p[x, y] = p[x + 1, y - 1];
                        d[x, y] = CalcDistance(p, x, y);
                    }

                    if (d[x-1,y] + d1 < d[x, y])
                    {
                        p[x, y] = p[x - 1, y];
                        d[x, y] = CalcDistance(p, x, y);
                    }
                }
            }

            //
            // Peform final pass (backward)
            //
            for (int y = 1; y < height-1; y++)
            {
                for (int x = 1; x < width-1; x++)
                {
                    if (d[x+1,y] + d1 < d[x, y])
                    {
                        p[x, y] = p[x + 1, y];
                        d[x, y] = CalcDistance(p, x, y);
                    }

                    if (d[x-1,y+1] + d2 < d[x, y])
                    {
                        p[x, y] = p[x - 1, y + 1];
                        d[x, y] = CalcDistance(p, x, y);
                    }

                    if (d[x,y+1] + d1 < d[x, y])
                    {
                        p[x, y] = p[x, y + 1];
                        d[x, y] = CalcDistance(p, x, y);
                    }

                    if (d[x+1,y+1]+d2 < d[x, y])
                    {
                        p[x, y] = p[x + 1, y + 1];
                        d[x, y] = CalcDistance(p, x, y);
                    }
                }
            }

            // indicate inside & outside
            for (int y = height-1; y > 0; y--)
            {
                for (int x = width-1; x > 0; x--)
                {
                    if (I[x,y] == 0)
                    {
                        d[x, y] = -d[x, y];
                    }
                }
            }

            // the output buffer containing the dead reckoning distances.
            output = d;
        }

        /// <summary>
        /// Calculate distance between x and y points.
        /// </summary>
        static float CalcDistance(Point[,] p, int x, int y)
        {
            int xd = x - p[x, y].X;
            int yd = y - p[x, y].Y;

            return (float)Math.Sqrt(Math.Pow(xd, 2) + Math.Pow(yd, 2));
        }


        /// <summary>
        /// Normalise the SDF distances into 0-255 alpha byte.
        /// </summary>
        public static byte[] NormaliseSDFTexture(float[,] sdf, int width, int height, int spread=3)
        {
            byte[] texture = new byte[width * height];

            // SDF algorithm needs a border.
            int margin = 3;

            for (int x = margin; x < width-margin; x++)
            {
                for (int y = margin; y < height-margin; y++)
                {
                    float dist = sdf[x, y];
                   
                    // clamp.
                    if (dist > spread) dist = spread;                    
                    if (dist < -spread) dist = -spread;

                    // scale to -1 to + 1
                    float scale = dist / spread;

                    // convert to 0 - 255
                    byte bval = (byte)(((scale + 1f) / 2f) * 255);

                    texture[y * width + x] = bval;
                }
            }

            return texture;
            
        }
        
        /// <summary>
        /// Struct for holding a point
        /// </summary>
        struct Point
        {
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X;
            public int Y;
        }

    }
}
