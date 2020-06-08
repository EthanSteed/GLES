using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Facebook.Yoga;
using GLES.Shader;
using OpenTK.Graphics;
using OpenTK.Maths;

namespace GLES.Demo
{
    [Demo('z', "Demo using facebook yoga for layout")]
    public class YogaLayoutDemo : DemoBase
    {
        // create root layout
        YogaNode m_Root;

        BasicShader m_Shader;

        int m_CoordBuffer;

        /// <summary>
        /// Constructor
        /// </summary>
        public YogaLayoutDemo()
        {
            m_Shader = new BasicShader();

            m_Root = new YogaNode()
            {
                FlexDirection = YogaFlexDirection.Column,
                JustifyContent = YogaJustify.Center,
                AlignItems = YogaAlign.Center
            };
            
        }

        public override void Initialise()
        {
            // Initialise the basic shader.
            m_Shader.Initialise();

            // generate buffers for quad coordinates.
            GL.GenBuffers(1, out m_CoordBuffer);

            // create the UI
            CreateUIPanels();

            // update the layout and generate the coordinate buffers.
            UpdateLayout();

        }

        /// <summary>
        /// Create the UI Panel
        /// </summary>
        private void CreateUIPanels()
        {
            // create child nodes for that we add to root.
            YogaNode panel1 = new YogaNode()
            {
                Width = 50,
                Height = 50,
                Margin = 10
            };
            m_Root.AddChild(panel1);

            YogaNode panel2 = new YogaNode()
            {
                Width = 50,
                Height = 50,
                Margin = 10
            };
            m_Root.AddChild(panel2);

            YogaNode panel3 = new YogaNode()
            {
                Width = 50,
                Height = 50,
                Margin = 10
            };

            m_Root.AddChild(panel3);
        }

        /// <summary>
        /// Update the size of the quads.
        /// </summary>
        private void UpdateLayout()
        {
            // calculate the layout.
            m_Root.CalculateLayout();

            List<Vector3> pos = new List<Vector3>();
            List<Vector4> col = new List<Vector4>();

            List<Vector4> colors = new List<Vector4>()
            {
                new Vector4(1, 0, 0, 1),
                new Vector4(0, 1, 0, 1),
                new Vector4(0, 0, 1, 1),
                new Vector4(0, 1, 1, 1),
                new Vector4(1, 1, 0, 1),
                new Vector4(1, 1, 1, 1),
            };

            int colidx = 0;

            // add the panels
            foreach (YogaNode panel in m_Root)
            {
                // triangle 1
                pos.Add(new Vector3(panel.LayoutX,  panel.LayoutY +  panel.LayoutHeight, 0));
                col.Add(colors[colidx]);

                pos.Add(new Vector3(panel.LayoutX, panel.LayoutY, 0));
                col.Add(colors[colidx]);

                pos.Add(new Vector3(panel.LayoutX + panel.LayoutWidth, panel.LayoutY + panel.LayoutHeight, 0));
                col.Add(colors[colidx]);


                // triangle 2
                pos.Add(new Vector3(panel.LayoutX + panel.LayoutWidth,  panel.LayoutY + panel.LayoutHeight, 0));
                col.Add(colors[colidx]);

                pos.Add(new Vector3(panel.LayoutX, panel.LayoutY, 0));
                col.Add(colors[colidx]);

                pos.Add(new Vector3(panel.LayoutX + panel.LayoutWidth,  panel.LayoutY, 0));
                col.Add(colors[colidx]);

                colidx++;
            
            }

            // build up the data to send to the graphics card.
            float[] bufferdata = new float[(pos.Count * 3) + (col.Count * 4)];
            int bufidx = 0;
            for (int i=0; i < pos.Count; i++)
            {
                bufferdata[bufidx++] = pos[i].X;
                bufferdata[bufidx++] = pos[i].Y;
                bufferdata[bufidx++] = pos[i].Z;
                bufferdata[bufidx++] = col[i].X;
                bufferdata[bufidx++] = col[i].Y;
                bufferdata[bufidx++] = col[i].Z;
                bufferdata[bufidx++] = col[i].W;

            }

            // load data to the card.
            GL.BindBuffer(BufferTarget.ArrayBuffer, m_CoordBuffer);
            GL.BufferData(BufferTarget.ArrayBuffer, new IntPtr(bufferdata.Length * sizeof(float)), bufferdata, BufferUsage.DynamicDraw);            
        }
        
        /// <summary>
        /// Called when the window is resized.
        /// </summary>
        public override void OnResize(int width, int height)
        {
            m_ProjectionMatrix = Matrix4.CreateOrthographicOffCenter(0f, width, height, -50, -100.0f, 100.0f);

            GL.Viewport(0, 0, width, height);

            m_Root.Width = width;
            m_Root.Height = height;

            UpdateLayout();
        }

        /// <summary>
        /// Render
        /// </summary>
        public override void Render()
        {
            // reset the model view matrix.
            m_ModelViewMatrix = Matrix4.Identity;

            // begin using the shader. 
            m_Shader.Begin();

            // update the model and projection matrix
            m_Shader.UpdateProjectionMatrix(m_ProjectionMatrix);
            m_Shader.UpdateModelViewMatrix(m_ModelViewMatrix);

            // ensure vertex and color attrib arrays are enabled.
            GL.EnableVertexAttribArray(m_Shader.VertexAttribLocation);
            GL.EnableVertexAttribArray(m_Shader.ColorAttribLocation);

            GL.BindBuffer(BufferTarget.ArrayBuffer, m_CoordBuffer);
            GL.VertexAttribPointer(m_Shader.VertexAttribLocation, 3, VertexAttribPointerType.Float, true, (7 * sizeof(float)), 0);
            GL.VertexAttribPointer(m_Shader.ColorAttribLocation, 4, VertexAttribPointerType.Float, true, (7 * sizeof(float)), 3 * sizeof(float));
            
            // draw the traingles.
            GL.DrawArrays(BeginMode.Triangles, 0, m_Root.Count * 6);

            // finished with the shader.
            m_Shader.End();
      
        }

        /// <summary>
        /// Finish
        /// </summary>
        public override void Finish()
        {
            m_Shader.Finish();
            GL.DeleteBuffers(1, ref m_CoordBuffer);
            
        }


    }
}
