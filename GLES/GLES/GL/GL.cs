using OpenTK.Maths;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenTK.Graphics
{
    public partial class GL
    {

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Select active texture unit
        /// </summary>
        /// <param name="texture"> 
        /// Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least 8. texture must be one of Texture, where i ranges from 0 to (MaxCombinedTextureImageUnits - 1). The initial value is Texture0.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glActiveTexture")]
        public static extern void ActiveTexture(All texture);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Select active texture unit
        /// </summary>
        /// <param name="texture"> 
        /// Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least 8. texture must be one of Texture, where i ranges from 0 to (MaxCombinedTextureImageUnits - 1). The initial value is Texture0.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glActiveTexture")]
        public static extern void ActiveTexture(TextureUnit texture);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Attach a shader object to a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to which a shader object will be attached.
        /// </param>
        /// <param name="shader"> 
        /// Specifies the shader object that is to be attached.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glAttachShader")]
        public static extern void AttachShader(Int32 program, Int32 shader);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Attach a shader object to a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to which a shader object will be attached.
        /// </param>
        /// <param name="shader"> 
        /// Specifies the shader object that is to be attached.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glAttachShader")]
        public static extern void AttachShader(UInt32 program, UInt32 shader);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Associate a generic vertex attribute index with a named attribute variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the handle of the program object in which the association is to be made.
        /// </param>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be bound.
        /// </param>
        /// <param name="name"> 
        /// Specifies a null terminated string containing the name of the vertex shader attribute variable to which index is to be bound.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBindAttribLocation")]
        public static extern void BindAttribLocation(Int32 program, Int32 index, String name);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Associate a generic vertex attribute index with a named attribute variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the handle of the program object in which the association is to be made.
        /// </param>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be bound.
        /// </param>
        /// <param name="name"> 
        /// Specifies a null terminated string containing the name of the vertex shader attribute variable to which index is to be bound.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBindAttribLocation")]
        public static extern void BindAttribLocation(UInt32 program, UInt32 index, String name);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Bind a named buffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target to which the buffer object is bound. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="buffer"> 
        /// Specifies the name of a buffer object.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBindBuffer")]
        public static extern void BindBuffer(All target, Int32 buffer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Bind a named buffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target to which the buffer object is bound. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="buffer"> 
        /// Specifies the name of a buffer object.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBindBuffer")]
        public static extern void BindBuffer(All target, UInt32 buffer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Bind a named buffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target to which the buffer object is bound. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="buffer"> 
        /// Specifies the name of a buffer object.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBindBuffer")]
        public static extern void BindBuffer(BufferTarget target, Int32 buffer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Bind a named buffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target to which the buffer object is bound. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="buffer"> 
        /// Specifies the name of a buffer object.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBindBuffer")]
        public static extern void BindBuffer(BufferTarget target, UInt32 buffer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Bind a named framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target to which the framebuffer object is bound. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="framebuffer"> 
        /// Specifies the name of a framebuffer object.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBindFramebuffer")]
        public static extern void BindFramebuffer(All target, Int32 framebuffer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Bind a named framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target to which the framebuffer object is bound. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="framebuffer"> 
        /// Specifies the name of a framebuffer object.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBindFramebuffer")]
        public static extern void BindFramebuffer(All target, UInt32 framebuffer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Bind a named framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target to which the framebuffer object is bound. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="framebuffer"> 
        /// Specifies the name of a framebuffer object.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBindFramebuffer")]
        public static extern void BindFramebuffer(FramebufferTarget target, Int32 framebuffer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Bind a named framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target to which the framebuffer object is bound. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="framebuffer"> 
        /// Specifies the name of a framebuffer object.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBindFramebuffer")]
        public static extern void BindFramebuffer(FramebufferTarget target, UInt32 framebuffer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Bind a named renderbuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target to which the renderbuffer object is bound. The symbolic constant must be Renderbuffer.
        /// </param>
        /// <param name="renderbuffer"> 
        /// Specifies the name of a renderbuffer object.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBindRenderbuffer")]
        public static extern void BindRenderbuffer(All target, Int32 renderbuffer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Bind a named renderbuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target to which the renderbuffer object is bound. The symbolic constant must be Renderbuffer.
        /// </param>
        /// <param name="renderbuffer"> 
        /// Specifies the name of a renderbuffer object.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBindRenderbuffer")]
        public static extern void BindRenderbuffer(All target, UInt32 renderbuffer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Bind a named renderbuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target to which the renderbuffer object is bound. The symbolic constant must be Renderbuffer.
        /// </param>
        /// <param name="renderbuffer"> 
        /// Specifies the name of a renderbuffer object.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBindRenderbuffer")]
        public static extern void BindRenderbuffer(RenderbufferTarget target, Int32 renderbuffer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Bind a named renderbuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target to which the renderbuffer object is bound. The symbolic constant must be Renderbuffer.
        /// </param>
        /// <param name="renderbuffer"> 
        /// Specifies the name of a renderbuffer object.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBindRenderbuffer")]
        public static extern void BindRenderbuffer(RenderbufferTarget target, UInt32 renderbuffer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Bind a named texture to a texturing target
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target of the active texture unit to which the texture is bound. Must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="texture"> 
        /// Specifies the name of a texture.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBindTexture")]
        public static extern void BindTexture(All target, Int32 texture);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Bind a named texture to a texturing target
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target of the active texture unit to which the texture is bound. Must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="texture"> 
        /// Specifies the name of a texture.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBindTexture")]
        public static extern void BindTexture(All target, UInt32 texture);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Bind a named texture to a texturing target
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target of the active texture unit to which the texture is bound. Must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="texture"> 
        /// Specifies the name of a texture.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBindTexture")]
        public static extern void BindTexture(TextureTarget target, Int32 texture);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Bind a named texture to a texturing target
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target of the active texture unit to which the texture is bound. Must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="texture"> 
        /// Specifies the name of a texture.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBindTexture")]
        public static extern void BindTexture(TextureTarget target, UInt32 texture);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set the blend color
        /// </summary>
        /// <param name="red"> 
        /// specify the components of BlendColor
        /// </param>
        /// <param name="green"> 
        /// specify the components of BlendColor
        /// </param>
        /// <param name="blue"> 
        /// specify the components of BlendColor
        /// </param>
        /// <param name="alpha"> 
        /// specify the components of BlendColor
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBlendColor")]
        public static extern void BlendColor(Single red, Single green, Single blue, Single alpha);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the equation used for both the RGB blend equation and the Alpha blend equation
        /// </summary>
        /// <param name="mode"> 
        /// specifies how source and destination colors are combined. It must be FuncAdd, FuncSubtract, or FuncReverseSubtract.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBlendEquation")]
        public static extern void BlendEquation(All mode);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the equation used for both the RGB blend equation and the Alpha blend equation
        /// </summary>
        /// <param name="mode"> 
        /// specifies how source and destination colors are combined. It must be FuncAdd, FuncSubtract, or FuncReverseSubtract.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBlendEquation")]
        public static extern void BlendEquation(BlendEquationMode mode);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set the RGB blend equation and the alpha blend equation separately
        /// </summary>
        /// <param name="modeRGB"> 
        /// specifies the RGB blend equation, how the red, green, and blue components of the source and destination colors are combined. It must be FuncAdd, FuncSubtract, or FuncReverseSubtract.
        /// </param>
        /// <param name="modeAlpha"> 
        /// specifies the alpha blend equation, how the alpha component of the source and destination colors are combined. It must be FuncAdd, FuncSubtract, or FuncReverseSubtract.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBlendEquationSeparate")]
        public static extern void BlendEquationSeparate(All modeRGB, All modeAlpha);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set the RGB blend equation and the alpha blend equation separately
        /// </summary>
        /// <param name="modeRGB"> 
        /// specifies the RGB blend equation, how the red, green, and blue components of the source and destination colors are combined. It must be FuncAdd, FuncSubtract, or FuncReverseSubtract.
        /// </param>
        /// <param name="modeAlpha"> 
        /// specifies the alpha blend equation, how the alpha component of the source and destination colors are combined. It must be FuncAdd, FuncSubtract, or FuncReverseSubtract.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBlendEquationSeparate")]
        public static extern void BlendEquationSeparate(BlendEquationMode modeRGB, BlendEquationMode modeAlpha);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify pixel arithmetic
        /// </summary>
        /// <param name="sfactor"> 
        /// Specifies how the red, green, blue, and alpha source blending factors are computed. The following symbolic constants are accepted: Zero, One, SrcColor, OneMinusSrcColor, DstColor, OneMinusDstColor, SrcAlpha, OneMinusSrcAlpha, DstAlpha, OneMinusDstAlpha, ConstantColor, OneMinusConstantColor, ConstantAlpha, OneMinusConstantAlpha, and SrcAlphaSaturate. The initial value is One.
        /// </param>
        /// <param name="dfactor"> 
        /// Specifies how the red, green, blue, and alpha destination blending factors are computed. The following symbolic constants are accepted: Zero, One, SrcColor, OneMinusSrcColor, DstColor, OneMinusDstColor, SrcAlpha, OneMinusSrcAlpha, DstAlpha, OneMinusDstAlpha. ConstantColor, OneMinusConstantColor, ConstantAlpha, and OneMinusConstantAlpha. The initial value is Zero.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBlendFunc")]
        public static extern void BlendFunc(All sfactor, All dfactor);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify pixel arithmetic
        /// </summary>
        /// <param name="sfactor"> 
        /// Specifies how the red, green, blue, and alpha source blending factors are computed. The following symbolic constants are accepted: Zero, One, SrcColor, OneMinusSrcColor, DstColor, OneMinusDstColor, SrcAlpha, OneMinusSrcAlpha, DstAlpha, OneMinusDstAlpha, ConstantColor, OneMinusConstantColor, ConstantAlpha, OneMinusConstantAlpha, and SrcAlphaSaturate. The initial value is One.
        /// </param>
        /// <param name="dfactor"> 
        /// Specifies how the red, green, blue, and alpha destination blending factors are computed. The following symbolic constants are accepted: Zero, One, SrcColor, OneMinusSrcColor, DstColor, OneMinusDstColor, SrcAlpha, OneMinusSrcAlpha, DstAlpha, OneMinusDstAlpha. ConstantColor, OneMinusConstantColor, ConstantAlpha, and OneMinusConstantAlpha. The initial value is Zero.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBlendFunc")]
        public static extern void BlendFunc(BlendingFactorSrc sfactor, BlendingFactorDest dfactor);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify pixel arithmetic for RGB and alpha components separately
        /// </summary>
        /// <param name="sfactorRGB"> 
        /// Specifies how the red, green, and blue blending factors are computed. The following symbolic constants are accepted: Zero, One, SrcColor, OneMinusSrcColor, DstColor, OneMinusDstColor, SrcAlpha, OneMinusSrcAlpha, DstAlpha, OneMinusDstAlpha, ConstantColor, OneMinusConstantColor, ConstantAlpha, OneMinusConstantAlpha, and SrcAlphaSaturate. The initial value is One.
        /// </param>
        /// <param name="dfactorRGB"> 
        /// Specifies how the red, green, and blue destination blending factors are computed. The following symbolic constants are accepted: Zero, One, SrcColor, OneMinusSrcColor, DstColor, OneMinusDstColor, SrcAlpha, OneMinusSrcAlpha, DstAlpha, OneMinusDstAlpha. ConstantColor, OneMinusConstantColor, ConstantAlpha, and OneMinusConstantAlpha. The initial value is Zero.
        /// </param>
        /// <param name="sfactorAlpha"> 
        /// Specified how the alpha source blending factor is computed.  The same symbolic constants are accepted as for srcRGB. The initial value is One.
        /// </param>
        /// <param name="dfactorAlpha"> 
        /// Specified how the alpha destination blending factor is computed.  The same symbolic constants are accepted as for dstRGB. The initial value is Zero.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBlendFuncSeparate")]
        public static extern void BlendFuncSeparate(All sfactorRGB, All dfactorRGB, All sfactorAlpha, All dfactorAlpha);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify pixel arithmetic for RGB and alpha components separately
        /// </summary>
        /// <param name="sfactorRGB"> 
        /// Specifies how the red, green, and blue blending factors are computed. The following symbolic constants are accepted: Zero, One, SrcColor, OneMinusSrcColor, DstColor, OneMinusDstColor, SrcAlpha, OneMinusSrcAlpha, DstAlpha, OneMinusDstAlpha, ConstantColor, OneMinusConstantColor, ConstantAlpha, OneMinusConstantAlpha, and SrcAlphaSaturate. The initial value is One.
        /// </param>
        /// <param name="dfactorRGB"> 
        /// Specifies how the red, green, and blue destination blending factors are computed. The following symbolic constants are accepted: Zero, One, SrcColor, OneMinusSrcColor, DstColor, OneMinusDstColor, SrcAlpha, OneMinusSrcAlpha, DstAlpha, OneMinusDstAlpha. ConstantColor, OneMinusConstantColor, ConstantAlpha, and OneMinusConstantAlpha. The initial value is Zero.
        /// </param>
        /// <param name="sfactorAlpha"> 
        /// Specified how the alpha source blending factor is computed.  The same symbolic constants are accepted as for srcRGB. The initial value is One.
        /// </param>
        /// <param name="dfactorAlpha"> 
        /// Specified how the alpha destination blending factor is computed.  The same symbolic constants are accepted as for dstRGB. The initial value is Zero.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBlendFuncSeparate")]
        public static extern void BlendFuncSeparate(BlendingFactorSrc sfactorRGB, BlendingFactorDest dfactorRGB, BlendingFactorSrc sfactorAlpha, BlendingFactorDest dfactorAlpha);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Create and initialize a buffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="size"> 
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">[length: size] 
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Null if no data is to be copied.
        /// </param>
        /// <param name="usage"> 
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be StreamDraw, StaticDraw, or DynamicDraw.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBufferData")]
        public static extern void BufferData(All target, IntPtr size, IntPtr data, All usage);

        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBufferData")]
        public static extern void BufferData(BufferTarget target, IntPtr size, [InAttribute, OutAttribute] float[] data, BufferUsage usage);

        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBufferData")]
        public static extern void BufferData(BufferTarget target, IntPtr size, [InAttribute, OutAttribute] Vector2[] data, BufferUsage usage);

        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBufferData")]
        public static extern void BufferData(BufferTarget target, IntPtr size, [InAttribute, OutAttribute] Vector3[] data, BufferUsage usage);

        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBufferData")]
        public static extern void BufferData(BufferTarget target, IntPtr size, [InAttribute, OutAttribute] Vector4[] data, BufferUsage usage);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Create and initialize a buffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="size"> 
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">[length: size] 
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Null if no data is to be copied.
        /// </param>
        /// <param name="usage"> 
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be StreamDraw, StaticDraw, or DynamicDraw.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBufferData")]
        public static extern void BufferData(BufferTarget target, IntPtr size, IntPtr data, BufferUsage usage);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Create and initialize a buffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="size"> 
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">[length: size] 
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Null if no data is to be copied.
        /// </param>
        /// <param name="usage"> 
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be StreamDraw, StaticDraw, or DynamicDraw.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBufferData")]
        public static extern void BufferData(BufferTarget target, IntPtr size, IntPtr data, BufferUsageHint usage);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Update a subset of a buffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="offset"> 
        /// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
        /// </param>
        /// <param name="size"> 
        /// Specifies the size in bytes of the data store region being replaced.
        /// </param>
        /// <param name="data">[length: size] 
        /// Specifies a pointer to the new data that will be copied into the data store.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glBufferSubData")]
        public static extern void BufferSubData(BufferTarget target, IntPtr offset, IntPtr size, IntPtr data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the framebuffer completeness status of a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target framebuffer object. The symbolic constant must be Framebuffer.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glCheckFramebufferStatus")]
        public static extern FramebufferErrorCode CheckFramebufferStatus(All target);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the framebuffer completeness status of a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target framebuffer object. The symbolic constant must be Framebuffer.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glCheckFramebufferStatus")]
        public static extern FramebufferErrorCode CheckFramebufferStatus(FramebufferTarget target);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Clear buffers to preset values
        /// </summary>
        /// <param name="mask"> 
        /// Bitwise OR of masks that indicate the buffers to be cleared. The three masks are ColorBufferBit, DepthBufferBit, and StencilBufferBit.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glClear")]
        public static extern void Clear(All mask);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Clear buffers to preset values
        /// </summary>
        /// <param name="mask"> 
        /// Bitwise OR of masks that indicate the buffers to be cleared. The three masks are ColorBufferBit, DepthBufferBit, and StencilBufferBit.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glClear")]
        public static extern void Clear(ClearBufferMask mask);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify clear values for the color buffers
        /// </summary>
        /// <param name="red"> 
        /// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0.
        /// </param>
        /// <param name="green"> 
        /// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0.
        /// </param>
        /// <param name="blue"> 
        /// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0.
        /// </param>
        /// <param name="alpha"> 
        /// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glClearColor")]
        public static extern void ClearColor(Single red, Single green, Single blue, Single alpha);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the clear value for the depth buffer
        /// </summary>
        /// <param name="d"> 
        /// Specifies the depth value used when the depth buffer is cleared. The initial value is 1.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glClearDepthf")]
        public static extern void ClearDepth(Single d);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the clear value for the stencil buffer
        /// </summary>
        /// <param name="s"> 
        /// Specifies the index used when the stencil buffer is cleared. The initial value is 0.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glClearStencil")]
        public static extern void ClearStencil(Int32 s);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Enable and disable writing of frame buffer color components
        /// </summary>
        /// <param name="red"> 
        /// Specify whether red, green, blue, and alpha can or cannot be written into the frame buffer. The initial values are all True, indicating that the color components can be written.
        /// </param>
        /// <param name="green"> 
        /// Specify whether red, green, blue, and alpha can or cannot be written into the frame buffer. The initial values are all True, indicating that the color components can be written.
        /// </param>
        /// <param name="blue"> 
        /// Specify whether red, green, blue, and alpha can or cannot be written into the frame buffer. The initial values are all True, indicating that the color components can be written.
        /// </param>
        /// <param name="alpha"> 
        /// Specify whether red, green, blue, and alpha can or cannot be written into the frame buffer. The initial values are all True, indicating that the color components can be written.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glColorMask")]
        public static extern void ColorMask(bool red, bool green, bool blue, bool alpha);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Compile a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the shader object to be compiled.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glCompileShader")]
        public static extern void CompileShader(Int32 shader);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Compile a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the shader object to be compiled.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glCompileShader")]
        public static extern void CompileShader(UInt32 shader);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image. All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glCompressedTexImage2D")]
        public static extern void CompressedTexImage2D(All target, Int32 level, All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image. All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glCompressedTexImage2D")]
        public static extern void CompressedTexImage2D(TextureTarget target, Int32 level, PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image. All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glCompressedTexImage2D")]
        public static extern void CompressedTexImage2D(TextureTarget2d target, Int32 level, CompressedInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glCompressedTexSubImage2D")]
        public static extern void CompressedTexSubImage2D(All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, All format, Int32 imageSize, IntPtr data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glCompressedTexSubImage2D")]
        public static extern void CompressedTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, Int32 imageSize, IntPtr data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glCompressedTexSubImage2D")]
        public static extern void CompressedTexSubImage2D(TextureTarget2d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, Int32 imageSize, IntPtr data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Copy pixels into a 2D texture image
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the internal format of the texture. Must be one of the following symbolic constants: Alpha, Luminance, LuminanceAlpha, Rgb, or Rgba.
        /// </param>
        /// <param name="x"> 
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="y"> 
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image. All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glCopyTexImage2D")]
        public static extern void CopyTexImage2D(All target, Int32 level, All internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Copy pixels into a 2D texture image
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the internal format of the texture. Must be one of the following symbolic constants: Alpha, Luminance, LuminanceAlpha, Rgb, or Rgba.
        /// </param>
        /// <param name="x"> 
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="y"> 
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image. All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glCopyTexImage2D")]
        public static extern void CopyTexImage2D(TextureTarget target, Int32 level, PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Copy pixels into a 2D texture image
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the internal format of the texture. Must be one of the following symbolic constants: Alpha, Luminance, LuminanceAlpha, Rgb, or Rgba.
        /// </param>
        /// <param name="x"> 
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="y"> 
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image. All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glCopyTexImage2D")]
        public static extern void CopyTexImage2D(TextureTarget2d target, Int32 level, TextureCopyComponentCount internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Copy a two-dimensional texture subimage
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="x"> 
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="y"> 
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glCopyTexSubImage2D")]
        public static extern void CopyTexSubImage2D(All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Copy a two-dimensional texture subimage
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="x"> 
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="y"> 
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glCopyTexSubImage2D")]
        public static extern void CopyTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Copy a two-dimensional texture subimage
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="x"> 
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="y"> 
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glCopyTexSubImage2D")]
        public static extern void CopyTexSubImage2D(TextureTarget2d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Create a program object
        /// </summary>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glCreateProgram")]
        public static extern Int32 CreateProgram();

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Create a shader object
        /// </summary>
        /// <param name="type"> 
        /// Specifies the type of shader to be created. Must be either VertexShader or FragmentShader.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glCreateShader")]
        public static extern Int32 CreateShader(All type);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Create a shader object
        /// </summary>
        /// <param name="type"> 
        /// Specifies the type of shader to be created. Must be either VertexShader or FragmentShader.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glCreateShader")]
        public static extern Int32 CreateShader(ShaderType type);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify whether front- or back-facing polygons can be culled
        /// </summary>
        /// <param name="mode"> 
        /// Specifies whether front- or back-facing polygons are candidates for culling. Symbolic constants Front, Back, and FrontAndBack are accepted. The initial value is Back.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glCullFace")]
        public static extern void CullFace(All mode);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify whether front- or back-facing polygons can be culled
        /// </summary>
        /// <param name="mode"> 
        /// Specifies whether front- or back-facing polygons are candidates for culling. Symbolic constants Front, Back, and FrontAndBack are accepted. The initial value is Back.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glCullFace")]
        public static extern void CullFace(CullFaceMode mode);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="buffers">[length: n] 
        /// Specifies an array of buffer objects to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteBuffers")]
        public static extern void DeleteBuffer(Int32 buffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="buffers">[length: n] 
        /// Specifies an array of buffer objects to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteBuffers")]
        public static extern void DeleteBuffer(UInt32 buffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of buffer objects to be deleted.
        /// </param>
        /// <param name="buffers">[length: n] 
        /// Specifies an array of buffer objects to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteBuffers")]
        public static extern void DeleteBuffers(Int32 n, Int32[] buffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of buffer objects to be deleted.
        /// </param>
        /// <param name="buffers">[length: n] 
        /// Specifies an array of buffer objects to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteBuffers")]
        public static extern void DeleteBuffers(Int32 n, ref Int32 buffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of buffer objects to be deleted.
        /// </param>
        /// <param name="buffers">[length: n] 
        /// Specifies an array of buffer objects to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteBuffers")]
        public static extern unsafe void DeleteBuffers(Int32 n, Int32* buffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of buffer objects to be deleted.
        /// </param>
        /// <param name="buffers">[length: n] 
        /// Specifies an array of buffer objects to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteBuffers")]
        public static extern void DeleteBuffers(Int32 n, UInt32[] buffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of buffer objects to be deleted.
        /// </param>
        /// <param name="buffers">[length: n] 
        /// Specifies an array of buffer objects to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteBuffers")]
        public static extern void DeleteBuffers(Int32 n, ref UInt32 buffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of buffer objects to be deleted.
        /// </param>
        /// <param name="buffers">[length: n] 
        /// Specifies an array of buffer objects to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteBuffers")]
        public static extern unsafe void DeleteBuffers(Int32 n, UInt32* buffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named framebuffer objects
        /// </summary>
        /// <param name="framebuffers">[length: n] 
        /// Specifies an array of framebuffer objects to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteFramebuffers")]
        public static extern void DeleteFramebuffer(Int32 framebuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named framebuffer objects
        /// </summary>
        /// <param name="framebuffers">[length: n] 
        /// Specifies an array of framebuffer objects to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteFramebuffers")]
        public static extern void DeleteFramebuffer(UInt32 framebuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named framebuffer objects
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of framebuffer objects to be deleted.
        /// </param>
        /// <param name="framebuffers">[length: n] 
        /// Specifies an array of framebuffer objects to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteFramebuffers")]
        public static extern void DeleteFramebuffers(Int32 n, Int32[] framebuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named framebuffer objects
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of framebuffer objects to be deleted.
        /// </param>
        /// <param name="framebuffers">[length: n] 
        /// Specifies an array of framebuffer objects to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteFramebuffers")]
        public static extern void DeleteFramebuffers(Int32 n, ref Int32 framebuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named framebuffer objects
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of framebuffer objects to be deleted.
        /// </param>
        /// <param name="framebuffers">[length: n] 
        /// Specifies an array of framebuffer objects to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteFramebuffers")]
        public static extern unsafe void DeleteFramebuffers(Int32 n, Int32* framebuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named framebuffer objects
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of framebuffer objects to be deleted.
        /// </param>
        /// <param name="framebuffers">[length: n] 
        /// Specifies an array of framebuffer objects to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteFramebuffers")]
        public static extern void DeleteFramebuffers(Int32 n, UInt32[] framebuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named framebuffer objects
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of framebuffer objects to be deleted.
        /// </param>
        /// <param name="framebuffers">[length: n] 
        /// Specifies an array of framebuffer objects to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteFramebuffers")]
        public static extern void DeleteFramebuffers(Int32 n, ref UInt32 framebuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named framebuffer objects
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of framebuffer objects to be deleted.
        /// </param>
        /// <param name="framebuffers">[length: n] 
        /// Specifies an array of framebuffer objects to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteFramebuffers")]
        public static extern unsafe void DeleteFramebuffers(Int32 n, UInt32* framebuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteProgram")]
        public static extern void DeleteProgram(Int32 program);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteProgram")]
        public static extern void DeleteProgram(UInt32 program);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named renderbuffer objects
        /// </summary>
        /// <param name="renderbuffers">[length: n] 
        /// Specifies an array of renderbuffer objects to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteRenderbuffers")]
        public static extern void DeleteRenderbuffer(Int32 renderbuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named renderbuffer objects
        /// </summary>
        /// <param name="renderbuffers">[length: n] 
        /// Specifies an array of renderbuffer objects to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteRenderbuffers")]
        public static extern void DeleteRenderbuffer(UInt32 renderbuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named renderbuffer objects
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of renderbuffer objects to be deleted.
        /// </param>
        /// <param name="renderbuffers">[length: n] 
        /// Specifies an array of renderbuffer objects to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteRenderbuffers")]
        public static extern void DeleteRenderbuffers(Int32 n, Int32[] renderbuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named renderbuffer objects
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of renderbuffer objects to be deleted.
        /// </param>
        /// <param name="renderbuffers">[length: n] 
        /// Specifies an array of renderbuffer objects to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteRenderbuffers")]
        public static extern void DeleteRenderbuffers(Int32 n, ref Int32 renderbuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named renderbuffer objects
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of renderbuffer objects to be deleted.
        /// </param>
        /// <param name="renderbuffers">[length: n] 
        /// Specifies an array of renderbuffer objects to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteRenderbuffers")]
        public static extern unsafe void DeleteRenderbuffers(Int32 n, Int32* renderbuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named renderbuffer objects
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of renderbuffer objects to be deleted.
        /// </param>
        /// <param name="renderbuffers">[length: n] 
        /// Specifies an array of renderbuffer objects to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteRenderbuffers")]
        public static extern void DeleteRenderbuffers(Int32 n, UInt32[] renderbuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named renderbuffer objects
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of renderbuffer objects to be deleted.
        /// </param>
        /// <param name="renderbuffers">[length: n] 
        /// Specifies an array of renderbuffer objects to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteRenderbuffers")]
        public static extern void DeleteRenderbuffers(Int32 n, ref UInt32 renderbuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named renderbuffer objects
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of renderbuffer objects to be deleted.
        /// </param>
        /// <param name="renderbuffers">[length: n] 
        /// Specifies an array of renderbuffer objects to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteRenderbuffers")]
        public static extern unsafe void DeleteRenderbuffers(Int32 n, UInt32* renderbuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the shader object to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteShader")]
        public static extern void DeleteShader(Int32 shader);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the shader object to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteShader")]
        public static extern void DeleteShader(UInt32 shader);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named textures
        /// </summary>
        /// <param name="textures">[length: n] 
        /// Specifies an array of textures to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteTextures")]
        public static extern void DeleteTexture(Int32 textures);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named textures
        /// </summary>
        /// <param name="textures">[length: n] 
        /// Specifies an array of textures to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteTextures")]
        public static extern void DeleteTexture(UInt32 textures);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named textures
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of textures to be deleted.
        /// </param>
        /// <param name="textures">[length: n] 
        /// Specifies an array of textures to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteTextures")]
        public static extern void DeleteTextures(Int32 n, Int32[] textures);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named textures
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of textures to be deleted.
        /// </param>
        /// <param name="textures">[length: n] 
        /// Specifies an array of textures to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteTextures")]
        public static extern void DeleteTextures(Int32 n, ref Int32 textures);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named textures
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of textures to be deleted.
        /// </param>
        /// <param name="textures">[length: n] 
        /// Specifies an array of textures to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteTextures")]
        public static extern unsafe void DeleteTextures(Int32 n, Int32* textures);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named textures
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of textures to be deleted.
        /// </param>
        /// <param name="textures">[length: n] 
        /// Specifies an array of textures to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteTextures")]
        public static extern void DeleteTextures(Int32 n, UInt32[] textures);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named textures
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of textures to be deleted.
        /// </param>
        /// <param name="textures">[length: n] 
        /// Specifies an array of textures to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteTextures")]
        public static extern void DeleteTextures(Int32 n, ref UInt32 textures);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Delete named textures
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of textures to be deleted.
        /// </param>
        /// <param name="textures">[length: n] 
        /// Specifies an array of textures to be deleted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDeleteTextures")]
        public static extern unsafe void DeleteTextures(Int32 n, UInt32* textures);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value used for depth buffer comparisons
        /// </summary>
        /// <param name="func"> 
        /// Specifies the depth comparison function. Symbolic constants Never, Less, Equal, Lequal, Greater, Notequal, Gequal, and Always are accepted. The initial value is Less.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDepthFunc")]
        public static extern void DepthFunc(All func);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value used for depth buffer comparisons
        /// </summary>
        /// <param name="func"> 
        /// Specifies the depth comparison function. Symbolic constants Never, Less, Equal, Lequal, Greater, Notequal, Gequal, and Always are accepted. The initial value is Less.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDepthFunc")]
        public static extern void DepthFunc(DepthFunction func);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Enable or disable writing into the depth buffer
        /// </summary>
        /// <param name="flag"> 
        /// Specifies whether the depth buffer is enabled for writing. If flag is False, depth buffer writing is disabled. Otherwise, it is enabled. Initially, depth buffer writing is enabled.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDepthMask")]
        public static extern void DepthMask(bool flag);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify mapping of depth values from normalized device coordinates to window coordinates
        /// </summary>
        /// <param name="n"> 
        /// Specifies the mapping of the near clipping plane to window coordinates. The initial value is 0.
        /// </param>
        /// <param name="f"> 
        /// Specifies the mapping of the far clipping plane to window coordinates. The initial value is 1.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDepthRangef")]
        public static extern void DepthRange(Single n, Single f);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Detach a shader object from a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object from which to detach the shader object.
        /// </param>
        /// <param name="shader"> 
        /// Specifies the shader object to be detached.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDetachShader")]
        public static extern void DetachShader(Int32 program, Int32 shader);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Detach a shader object from a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object from which to detach the shader object.
        /// </param>
        /// <param name="shader"> 
        /// Specifies the shader object to be detached.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDetachShader")]
        public static extern void DetachShader(UInt32 program, UInt32 shader);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="cap"></param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDisable")]
        public static extern void Disable(All cap);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="cap"></param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDisable")]
        public static extern void Disable(EnableCap cap);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="index"></param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDisableVertexAttribArray")]
        public static extern void DisableVertexAttribArray(Int32 index);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="index"></param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDisableVertexAttribArray")]
        public static extern void DisableVertexAttribArray(UInt32 index);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="first"> 
        /// Specifies the starting index in the enabled arrays.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of indices to be rendered.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDrawArrays")]
        public static extern void DrawArrays(All mode, Int32 first, Int32 count);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="first"> 
        /// Specifies the starting index in the enabled arrays.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of indices to be rendered.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDrawArrays")]
        public static extern void DrawArrays(BeginMode mode, Int32 first, Int32 count);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="first"> 
        /// Specifies the starting index in the enabled arrays.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of indices to be rendered.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDrawArrays")]
        public static extern void DrawArrays(PrimitiveType mode, Int32 first, Int32 count);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type"> 
        /// Specifies the type of the values in indices. Must be UnsignedByte or UnsignedShort.
        /// </param>
        /// <param name="indices">[length: count,type] 
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDrawElements")]
        /*
        public static extern void DrawElements(All mode, Int32 count, All type, IntPtr indices);
     
        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type"> 
        /// Specifies the type of the values in indices. Must be UnsignedByte or UnsignedShort.
        /// </param>
        /// <param name="indices">[length: count,type] 
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDrawElements")]
        */
        public static extern void DrawElements(BeginMode mode, Int32 count, DrawElementsType type, IntPtr indices);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type"> 
        /// Specifies the type of the values in indices. Must be UnsignedByte or UnsignedShort.
        /// </param>
        /// <param name="indices">[length: count,type] 
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glDrawElements")]
        public static extern void DrawElements(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Enable or disable server-side GL capabilities
        /// </summary>
        /// <param name="cap"> 
        /// Specifies a symbolic constant indicating a GL capability.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glEnable")]
        public static extern void Enable(All cap);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Enable or disable server-side GL capabilities
        /// </summary>
        /// <param name="cap"> 
        /// Specifies a symbolic constant indicating a GL capability.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glEnable")]
        public static extern void Enable(EnableCap cap);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Enable or disable a generic vertex attribute array
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be enabled or disabled.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glEnableVertexAttribArray")]
        public static extern void EnableVertexAttribArray(Int32 index);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Enable or disable a generic vertex attribute array
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be enabled or disabled.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glEnableVertexAttribArray")]
        public static extern void EnableVertexAttribArray(UInt32 index);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Block until all GL execution is complete
        /// </summary>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glFinish")]
        public static extern void Finish();

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Force execution of GL commands in finite time
        /// </summary>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glFlush")]
        public static extern void Flush();

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Attach a renderbuffer object to a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the framebuffer target. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="attachment"> 
        /// Specifies the attachment point to which renderbuffer should be attached. Must be one of the following symbolic constants: ColorAttachment0, DepthAttachment, or StencilAttachment.
        /// </param>
        /// <param name="renderbuffertarget"> 
        /// Specifies the renderbuffer target. The symbolic constant must be Renderbuffer.
        /// </param>
        /// <param name="renderbuffer"> 
        /// Specifies the renderbuffer object that is to be attached.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glFramebufferRenderbuffer")]
        public static extern void FramebufferRenderbuffer(All target, All attachment, All renderbuffertarget, Int32 renderbuffer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Attach a renderbuffer object to a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the framebuffer target. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="attachment"> 
        /// Specifies the attachment point to which renderbuffer should be attached. Must be one of the following symbolic constants: ColorAttachment0, DepthAttachment, or StencilAttachment.
        /// </param>
        /// <param name="renderbuffertarget"> 
        /// Specifies the renderbuffer target. The symbolic constant must be Renderbuffer.
        /// </param>
        /// <param name="renderbuffer"> 
        /// Specifies the renderbuffer object that is to be attached.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glFramebufferRenderbuffer")]
        public static extern void FramebufferRenderbuffer(All target, All attachment, All renderbuffertarget, UInt32 renderbuffer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Attach a renderbuffer object to a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the framebuffer target. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="attachment"> 
        /// Specifies the attachment point to which renderbuffer should be attached. Must be one of the following symbolic constants: ColorAttachment0, DepthAttachment, or StencilAttachment.
        /// </param>
        /// <param name="renderbuffertarget"> 
        /// Specifies the renderbuffer target. The symbolic constant must be Renderbuffer.
        /// </param>
        /// <param name="renderbuffer"> 
        /// Specifies the renderbuffer object that is to be attached.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glFramebufferRenderbuffer")]
        public static extern void FramebufferRenderbuffer(FramebufferTarget target, All attachment, RenderbufferTarget renderbuffertarget, Int32 renderbuffer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Attach a renderbuffer object to a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the framebuffer target. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="attachment"> 
        /// Specifies the attachment point to which renderbuffer should be attached. Must be one of the following symbolic constants: ColorAttachment0, DepthAttachment, or StencilAttachment.
        /// </param>
        /// <param name="renderbuffertarget"> 
        /// Specifies the renderbuffer target. The symbolic constant must be Renderbuffer.
        /// </param>
        /// <param name="renderbuffer"> 
        /// Specifies the renderbuffer object that is to be attached.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glFramebufferRenderbuffer")]
        public static extern void FramebufferRenderbuffer(FramebufferTarget target, All attachment, RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Attach a renderbuffer object to a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the framebuffer target. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="attachment"> 
        /// Specifies the attachment point to which renderbuffer should be attached. Must be one of the following symbolic constants: ColorAttachment0, DepthAttachment, or StencilAttachment.
        /// </param>
        /// <param name="renderbuffertarget"> 
        /// Specifies the renderbuffer target. The symbolic constant must be Renderbuffer.
        /// </param>
        /// <param name="renderbuffer"> 
        /// Specifies the renderbuffer object that is to be attached.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glFramebufferRenderbuffer")]
        public static extern void FramebufferRenderbuffer(FramebufferTarget target, FramebufferSlot attachment, RenderbufferTarget renderbuffertarget, Int32 renderbuffer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Attach a renderbuffer object to a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the framebuffer target. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="attachment"> 
        /// Specifies the attachment point to which renderbuffer should be attached. Must be one of the following symbolic constants: ColorAttachment0, DepthAttachment, or StencilAttachment.
        /// </param>
        /// <param name="renderbuffertarget"> 
        /// Specifies the renderbuffer target. The symbolic constant must be Renderbuffer.
        /// </param>
        /// <param name="renderbuffer"> 
        /// Specifies the renderbuffer object that is to be attached.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glFramebufferRenderbuffer")]
        public static extern void FramebufferRenderbuffer(FramebufferTarget target, FramebufferSlot attachment, RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Attach a texture image to a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the framebuffer target. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="attachment"> 
        /// Specifies the attachment point to which an image from texture should be attached. Must be one of the following symbolic constants: ColorAttachment0, DepthAttachment, or StencilAttachment.
        /// </param>
        /// <param name="textarget"> 
        /// Specifies the texture target. Must be one of the following symbolic constants: Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="texture"> 
        /// Specifies the texture object whose image is to be attached.
        /// </param>
        /// <param name="level"> 
        /// Specifies the mipmap level of the texture image to be attached, which must be 0.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glFramebufferTexture2D")]
        public static extern void FramebufferTexture2D(All target, All attachment, All textarget, Int32 texture, Int32 level);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Attach a texture image to a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the framebuffer target. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="attachment"> 
        /// Specifies the attachment point to which an image from texture should be attached. Must be one of the following symbolic constants: ColorAttachment0, DepthAttachment, or StencilAttachment.
        /// </param>
        /// <param name="textarget"> 
        /// Specifies the texture target. Must be one of the following symbolic constants: Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="texture"> 
        /// Specifies the texture object whose image is to be attached.
        /// </param>
        /// <param name="level"> 
        /// Specifies the mipmap level of the texture image to be attached, which must be 0.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glFramebufferTexture2D")]
        public static extern void FramebufferTexture2D(All target, All attachment, All textarget, UInt32 texture, Int32 level);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Attach a texture image to a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the framebuffer target. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="attachment"> 
        /// Specifies the attachment point to which an image from texture should be attached. Must be one of the following symbolic constants: ColorAttachment0, DepthAttachment, or StencilAttachment.
        /// </param>
        /// <param name="textarget"> 
        /// Specifies the texture target. Must be one of the following symbolic constants: Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="texture"> 
        /// Specifies the texture object whose image is to be attached.
        /// </param>
        /// <param name="level"> 
        /// Specifies the mipmap level of the texture image to be attached, which must be 0.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glFramebufferTexture2D")]
        public static extern void FramebufferTexture2D(FramebufferTarget target, All attachment, TextureTarget textarget, Int32 texture, Int32 level);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Attach a texture image to a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the framebuffer target. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="attachment"> 
        /// Specifies the attachment point to which an image from texture should be attached. Must be one of the following symbolic constants: ColorAttachment0, DepthAttachment, or StencilAttachment.
        /// </param>
        /// <param name="textarget"> 
        /// Specifies the texture target. Must be one of the following symbolic constants: Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="texture"> 
        /// Specifies the texture object whose image is to be attached.
        /// </param>
        /// <param name="level"> 
        /// Specifies the mipmap level of the texture image to be attached, which must be 0.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glFramebufferTexture2D")]
        public static extern void FramebufferTexture2D(FramebufferTarget target, All attachment, TextureTarget textarget, UInt32 texture, Int32 level);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Attach a texture image to a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the framebuffer target. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="attachment"> 
        /// Specifies the attachment point to which an image from texture should be attached. Must be one of the following symbolic constants: ColorAttachment0, DepthAttachment, or StencilAttachment.
        /// </param>
        /// <param name="textarget"> 
        /// Specifies the texture target. Must be one of the following symbolic constants: Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="texture"> 
        /// Specifies the texture object whose image is to be attached.
        /// </param>
        /// <param name="level"> 
        /// Specifies the mipmap level of the texture image to be attached, which must be 0.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glFramebufferTexture2D")]
        public static extern void FramebufferTexture2D(FramebufferTarget target, All attachment, TextureTarget2d textarget, Int32 texture, Int32 level);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Attach a texture image to a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the framebuffer target. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="attachment"> 
        /// Specifies the attachment point to which an image from texture should be attached. Must be one of the following symbolic constants: ColorAttachment0, DepthAttachment, or StencilAttachment.
        /// </param>
        /// <param name="textarget"> 
        /// Specifies the texture target. Must be one of the following symbolic constants: Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="texture"> 
        /// Specifies the texture object whose image is to be attached.
        /// </param>
        /// <param name="level"> 
        /// Specifies the mipmap level of the texture image to be attached, which must be 0.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glFramebufferTexture2D")]
        public static extern void FramebufferTexture2D(FramebufferTarget target, All attachment, TextureTarget2d textarget, UInt32 texture, Int32 level);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Attach a texture image to a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the framebuffer target. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="attachment"> 
        /// Specifies the attachment point to which an image from texture should be attached. Must be one of the following symbolic constants: ColorAttachment0, DepthAttachment, or StencilAttachment.
        /// </param>
        /// <param name="textarget"> 
        /// Specifies the texture target. Must be one of the following symbolic constants: Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="texture"> 
        /// Specifies the texture object whose image is to be attached.
        /// </param>
        /// <param name="level"> 
        /// Specifies the mipmap level of the texture image to be attached, which must be 0.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glFramebufferTexture2D")]
        public static extern void FramebufferTexture2D(FramebufferTarget target, FramebufferSlot attachment, TextureTarget textarget, Int32 texture, Int32 level);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Attach a texture image to a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the framebuffer target. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="attachment"> 
        /// Specifies the attachment point to which an image from texture should be attached. Must be one of the following symbolic constants: ColorAttachment0, DepthAttachment, or StencilAttachment.
        /// </param>
        /// <param name="textarget"> 
        /// Specifies the texture target. Must be one of the following symbolic constants: Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="texture"> 
        /// Specifies the texture object whose image is to be attached.
        /// </param>
        /// <param name="level"> 
        /// Specifies the mipmap level of the texture image to be attached, which must be 0.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glFramebufferTexture2D")]
        public static extern void FramebufferTexture2D(FramebufferTarget target, FramebufferSlot attachment, TextureTarget textarget, UInt32 texture, Int32 level);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Define front- and back-facing polygons
        /// </summary>
        /// <param name="mode"> 
        /// Specifies the orientation of front-facing polygons. Cw and Ccw are accepted. The initial value is Ccw.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glFrontFace")]
        public static extern void FrontFace(All mode);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Define front- and back-facing polygons
        /// </summary>
        /// <param name="mode"> 
        /// Specifies the orientation of front-facing polygons. Cw and Ccw are accepted. The initial value is Ccw.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glFrontFace")]
        public static extern void FrontFace(FrontFaceDirection mode);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of buffer object names to be generated.
        /// </param>
        /// <param name="buffers">[length: n] 
        /// Specifies an array in which the generated buffer object names are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenBuffers")]
        public static extern void GenBuffers(Int32 n, [OutAttribute] Int32[] buffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of buffer object names to be generated.
        /// </param>
        /// <param name="buffers">[length: n] 
        /// Specifies an array in which the generated buffer object names are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenBuffers")]
        public static extern void GenBuffers(Int32 n, [OutAttribute] out Int32 buffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of buffer object names to be generated.
        /// </param>
        /// <param name="buffers">[length: n] 
        /// Specifies an array in which the generated buffer object names are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenBuffers")]
        public static extern unsafe void GenBuffers(Int32 n, [OutAttribute] Int32* buffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of buffer object names to be generated.
        /// </param>
        /// <param name="buffers">[length: n] 
        /// Specifies an array in which the generated buffer object names are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenBuffers")]
        public static extern void GenBuffers(Int32 n, [OutAttribute] UInt32[] buffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of buffer object names to be generated.
        /// </param>
        /// <param name="buffers">[length: n] 
        /// Specifies an array in which the generated buffer object names are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenBuffers")]
        public static extern void GenBuffers(Int32 n, [OutAttribute] out UInt32 buffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of buffer object names to be generated.
        /// </param>
        /// <param name="buffers">[length: n] 
        /// Specifies an array in which the generated buffer object names are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenBuffers")]
        public static extern unsafe void GenBuffers(Int32 n, [OutAttribute] UInt32* buffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate a complete set of mipmaps for a texture object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the texture target of the active texture unit to which the texture object is bound whose mipmaps will be generated.  Must be one of the following symbolic constants: Texture2D or TextureCubeMap.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenerateMipmap")]
        public static extern void GenerateMipmap(All target);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate a complete set of mipmaps for a texture object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the texture target of the active texture unit to which the texture object is bound whose mipmaps will be generated.  Must be one of the following symbolic constants: Texture2D or TextureCubeMap.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenerateMipmap")]
        public static extern void GenerateMipmap(TextureTarget target);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate framebuffer object names
        /// </summary>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenFramebuffers")]
        public static extern Int32 GenFramebuffer();

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate framebuffer object names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of framebuffer object names to be generated.
        /// </param>
        /// <param name="framebuffers">[length: n] 
        /// Specifies an array in which the generated framebuffer object names are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenFramebuffers")]
        public static extern void GenFramebuffers(Int32 n, [OutAttribute] Int32[] framebuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate framebuffer object names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of framebuffer object names to be generated.
        /// </param>
        /// <param name="framebuffers">[length: n] 
        /// Specifies an array in which the generated framebuffer object names are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenFramebuffers")]
        public static extern void GenFramebuffers(Int32 n, [OutAttribute] out Int32 framebuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate framebuffer object names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of framebuffer object names to be generated.
        /// </param>
        /// <param name="framebuffers">[length: n] 
        /// Specifies an array in which the generated framebuffer object names are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenFramebuffers")]
        public static extern unsafe void GenFramebuffers(Int32 n, [OutAttribute] Int32* framebuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate framebuffer object names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of framebuffer object names to be generated.
        /// </param>
        /// <param name="framebuffers">[length: n] 
        /// Specifies an array in which the generated framebuffer object names are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenFramebuffers")]
        public static extern void GenFramebuffers(Int32 n, [OutAttribute] UInt32[] framebuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate framebuffer object names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of framebuffer object names to be generated.
        /// </param>
        /// <param name="framebuffers">[length: n] 
        /// Specifies an array in which the generated framebuffer object names are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenFramebuffers")]
        public static extern void GenFramebuffers(Int32 n, [OutAttribute] out UInt32 framebuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate framebuffer object names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of framebuffer object names to be generated.
        /// </param>
        /// <param name="framebuffers">[length: n] 
        /// Specifies an array in which the generated framebuffer object names are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenFramebuffers")]
        public static extern unsafe void GenFramebuffers(Int32 n, [OutAttribute] UInt32* framebuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate renderbuffer object names
        /// </summary>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenRenderbuffers")]
        public static extern Int32 GenRenderbuffer();

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate renderbuffer object names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of renderbuffer object names to be generated.
        /// </param>
        /// <param name="renderbuffers">[length: n] 
        /// Specifies an array in which the generated renderbuffer object names are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenRenderbuffers")]
        public static extern void GenRenderbuffers(Int32 n, [OutAttribute] Int32[] renderbuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate renderbuffer object names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of renderbuffer object names to be generated.
        /// </param>
        /// <param name="renderbuffers">[length: n] 
        /// Specifies an array in which the generated renderbuffer object names are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenRenderbuffers")]
        public static extern void GenRenderbuffers(Int32 n, [OutAttribute] out Int32 renderbuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate renderbuffer object names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of renderbuffer object names to be generated.
        /// </param>
        /// <param name="renderbuffers">[length: n] 
        /// Specifies an array in which the generated renderbuffer object names are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenRenderbuffers")]
        public static extern unsafe void GenRenderbuffers(Int32 n, [OutAttribute] Int32* renderbuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate renderbuffer object names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of renderbuffer object names to be generated.
        /// </param>
        /// <param name="renderbuffers">[length: n] 
        /// Specifies an array in which the generated renderbuffer object names are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenRenderbuffers")]
        public static extern void GenRenderbuffers(Int32 n, [OutAttribute] UInt32[] renderbuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate renderbuffer object names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of renderbuffer object names to be generated.
        /// </param>
        /// <param name="renderbuffers">[length: n] 
        /// Specifies an array in which the generated renderbuffer object names are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenRenderbuffers")]
        public static extern void GenRenderbuffers(Int32 n, [OutAttribute] out UInt32 renderbuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate renderbuffer object names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of renderbuffer object names to be generated.
        /// </param>
        /// <param name="renderbuffers">[length: n] 
        /// Specifies an array in which the generated renderbuffer object names are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenRenderbuffers")]
        public static extern unsafe void GenRenderbuffers(Int32 n, [OutAttribute] UInt32* renderbuffers);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate texture names
        /// </summary>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenTextures")]
        public static extern Int32 GenTexture();

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate texture names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of texture names to be generated.
        /// </param>
        /// <param name="textures">[length: n] 
        /// Specifies an array in which the generated texture names are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenTextures")]
        public static extern void GenTextures(Int32 n, [OutAttribute] Int32[] textures);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate texture names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of texture names to be generated.
        /// </param>
        /// <param name="textures">[length: n] 
        /// Specifies an array in which the generated texture names are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenTextures")]
        public static extern void GenTextures(Int32 n, [OutAttribute] out Int32 textures);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate texture names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of texture names to be generated.
        /// </param>
        /// <param name="textures">[length: n] 
        /// Specifies an array in which the generated texture names are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenTextures")]
        public static extern unsafe void GenTextures(Int32 n, [OutAttribute] Int32* textures);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate texture names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of texture names to be generated.
        /// </param>
        /// <param name="textures">[length: n] 
        /// Specifies an array in which the generated texture names are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenTextures")]
        public static extern void GenTextures(Int32 n, [OutAttribute] UInt32[] textures);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate texture names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of texture names to be generated.
        /// </param>
        /// <param name="textures">[length: n] 
        /// Specifies an array in which the generated texture names are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenTextures")]
        public static extern void GenTextures(Int32 n, [OutAttribute] out UInt32 textures);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Generate texture names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of texture names to be generated.
        /// </param>
        /// <param name="textures">[length: n] 
        /// Specifies an array in which the generated texture names are stored.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGenTextures")]
        public static extern unsafe void GenTextures(Int32 n, [OutAttribute] UInt32* textures);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return information about an active attribute variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="index"> 
        /// Specifies the index of the attribute variable to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than Null is passed.
        /// </param>
        /// <param name="size">[length: 1] 
        /// Returns the size of the attribute variable.
        /// </param>
        /// <param name="type">[length: 1] 
        /// Returns the data type of the attribute variable.
        /// </param>
        /// <param name="name">[length: bufSize] 
        /// Returns a null terminated string containing the name of the attribute variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetActiveAttrib")]
        public static extern void GetActiveAttrib(Int32 program, Int32 index, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] out Int32 size, [OutAttribute] out ActiveAttribType type, [OutAttribute] StringBuilder name);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return information about an active attribute variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="index"> 
        /// Specifies the index of the attribute variable to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than Null is passed.
        /// </param>
        /// <param name="size">[length: 1] 
        /// Returns the size of the attribute variable.
        /// </param>
        /// <param name="type">[length: 1] 
        /// Returns the data type of the attribute variable.
        /// </param>
        /// <param name="name">[length: bufSize] 
        /// Returns a null terminated string containing the name of the attribute variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetActiveAttrib")]
        public static extern void GetActiveAttrib(Int32 program, Int32 index, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] out Int32 size, [OutAttribute] out All type, [OutAttribute] StringBuilder name);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return information about an active attribute variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="index"> 
        /// Specifies the index of the attribute variable to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than Null is passed.
        /// </param>
        /// <param name="size">[length: 1] 
        /// Returns the size of the attribute variable.
        /// </param>
        /// <param name="type">[length: 1] 
        /// Returns the data type of the attribute variable.
        /// </param>
        /// <param name="name">[length: bufSize] 
        /// Returns a null terminated string containing the name of the attribute variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetActiveAttrib")]
        public static extern unsafe void GetActiveAttrib(Int32 program, Int32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] ActiveAttribType* type, [OutAttribute] StringBuilder name);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return information about an active attribute variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="index"> 
        /// Specifies the index of the attribute variable to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than Null is passed.
        /// </param>
        /// <param name="size">[length: 1] 
        /// Returns the size of the attribute variable.
        /// </param>
        /// <param name="type">[length: 1] 
        /// Returns the data type of the attribute variable.
        /// </param>
        /// <param name="name">[length: bufSize] 
        /// Returns a null terminated string containing the name of the attribute variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetActiveAttrib")]
        public static extern unsafe void GetActiveAttrib(Int32 program, Int32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] All* type, [OutAttribute] StringBuilder name);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return information about an active attribute variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="index"> 
        /// Specifies the index of the attribute variable to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than Null is passed.
        /// </param>
        /// <param name="size">[length: 1] 
        /// Returns the size of the attribute variable.
        /// </param>
        /// <param name="type">[length: 1] 
        /// Returns the data type of the attribute variable.
        /// </param>
        /// <param name="name">[length: bufSize] 
        /// Returns a null terminated string containing the name of the attribute variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetActiveAttrib")]
        public static extern void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] out Int32 size, [OutAttribute] out ActiveAttribType type, [OutAttribute] StringBuilder name);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return information about an active attribute variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="index"> 
        /// Specifies the index of the attribute variable to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than Null is passed.
        /// </param>
        /// <param name="size">[length: 1] 
        /// Returns the size of the attribute variable.
        /// </param>
        /// <param name="type">[length: 1] 
        /// Returns the data type of the attribute variable.
        /// </param>
        /// <param name="name">[length: bufSize] 
        /// Returns a null terminated string containing the name of the attribute variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetActiveAttrib")]
        public static extern void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] out Int32 size, [OutAttribute] out All type, [OutAttribute] StringBuilder name);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return information about an active attribute variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="index"> 
        /// Specifies the index of the attribute variable to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than Null is passed.
        /// </param>
        /// <param name="size">[length: 1] 
        /// Returns the size of the attribute variable.
        /// </param>
        /// <param name="type">[length: 1] 
        /// Returns the data type of the attribute variable.
        /// </param>
        /// <param name="name">[length: bufSize] 
        /// Returns a null terminated string containing the name of the attribute variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetActiveAttrib")]
        public static extern unsafe void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] ActiveAttribType* type, [OutAttribute] StringBuilder name);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return information about an active attribute variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="index"> 
        /// Specifies the index of the attribute variable to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than Null is passed.
        /// </param>
        /// <param name="size">[length: 1] 
        /// Returns the size of the attribute variable.
        /// </param>
        /// <param name="type">[length: 1] 
        /// Returns the data type of the attribute variable.
        /// </param>
        /// <param name="name">[length: bufSize] 
        /// Returns a null terminated string containing the name of the attribute variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetActiveAttrib")]
        public static extern unsafe void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] All* type, [OutAttribute] StringBuilder name);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return information about an active uniform variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="index"> 
        /// Specifies the index of the uniform variable to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than Null is passed.
        /// </param>
        /// <param name="size">[length: 1] 
        /// Returns the size of the uniform variable.
        /// </param>
        /// <param name="type">[length: 1] 
        /// Returns the data type of the uniform variable.
        /// </param>
        /// <param name="name">[length: bufSize] 
        /// Returns a null terminated string containing the name of the uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetActiveUniform")]
        public static extern void GetActiveUniform(Int32 program, Int32 index, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] out Int32 size, [OutAttribute] out ActiveUniformType type, [OutAttribute] StringBuilder name);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return information about an active uniform variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="index"> 
        /// Specifies the index of the uniform variable to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than Null is passed.
        /// </param>
        /// <param name="size">[length: 1] 
        /// Returns the size of the uniform variable.
        /// </param>
        /// <param name="type">[length: 1] 
        /// Returns the data type of the uniform variable.
        /// </param>
        /// <param name="name">[length: bufSize] 
        /// Returns a null terminated string containing the name of the uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetActiveUniform")]
        public static extern void GetActiveUniform(Int32 program, Int32 index, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] out Int32 size, [OutAttribute] out All type, [OutAttribute] StringBuilder name);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return information about an active uniform variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="index"> 
        /// Specifies the index of the uniform variable to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than Null is passed.
        /// </param>
        /// <param name="size">[length: 1] 
        /// Returns the size of the uniform variable.
        /// </param>
        /// <param name="type">[length: 1] 
        /// Returns the data type of the uniform variable.
        /// </param>
        /// <param name="name">[length: bufSize] 
        /// Returns a null terminated string containing the name of the uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetActiveUniform")]
        public static extern unsafe void GetActiveUniform(Int32 program, Int32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] ActiveUniformType* type, [OutAttribute] StringBuilder name);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return information about an active uniform variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="index"> 
        /// Specifies the index of the uniform variable to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than Null is passed.
        /// </param>
        /// <param name="size">[length: 1] 
        /// Returns the size of the uniform variable.
        /// </param>
        /// <param name="type">[length: 1] 
        /// Returns the data type of the uniform variable.
        /// </param>
        /// <param name="name">[length: bufSize] 
        /// Returns a null terminated string containing the name of the uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetActiveUniform")]
        public static extern unsafe void GetActiveUniform(Int32 program, Int32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] All* type, [OutAttribute] StringBuilder name);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return information about an active uniform variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="index"> 
        /// Specifies the index of the uniform variable to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than Null is passed.
        /// </param>
        /// <param name="size">[length: 1] 
        /// Returns the size of the uniform variable.
        /// </param>
        /// <param name="type">[length: 1] 
        /// Returns the data type of the uniform variable.
        /// </param>
        /// <param name="name">[length: bufSize] 
        /// Returns a null terminated string containing the name of the uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetActiveUniform")]
        public static extern void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] out Int32 size, [OutAttribute] out ActiveUniformType type, [OutAttribute] StringBuilder name);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return information about an active uniform variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="index"> 
        /// Specifies the index of the uniform variable to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than Null is passed.
        /// </param>
        /// <param name="size">[length: 1] 
        /// Returns the size of the uniform variable.
        /// </param>
        /// <param name="type">[length: 1] 
        /// Returns the data type of the uniform variable.
        /// </param>
        /// <param name="name">[length: bufSize] 
        /// Returns a null terminated string containing the name of the uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetActiveUniform")]
        public static extern void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] out Int32 size, [OutAttribute] out All type, [OutAttribute] StringBuilder name);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return information about an active uniform variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="index"> 
        /// Specifies the index of the uniform variable to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than Null is passed.
        /// </param>
        /// <param name="size">[length: 1] 
        /// Returns the size of the uniform variable.
        /// </param>
        /// <param name="type">[length: 1] 
        /// Returns the data type of the uniform variable.
        /// </param>
        /// <param name="name">[length: bufSize] 
        /// Returns a null terminated string containing the name of the uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetActiveUniform")]
        public static extern unsafe void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] ActiveUniformType* type, [OutAttribute] StringBuilder name);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return information about an active uniform variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="index"> 
        /// Specifies the index of the uniform variable to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than Null is passed.
        /// </param>
        /// <param name="size">[length: 1] 
        /// Returns the size of the uniform variable.
        /// </param>
        /// <param name="type">[length: 1] 
        /// Returns the data type of the uniform variable.
        /// </param>
        /// <param name="name">[length: bufSize] 
        /// Returns a null terminated string containing the name of the uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetActiveUniform")]
        public static extern unsafe void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] All* type, [OutAttribute] StringBuilder name);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the handles of the shader objects attached to a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="maxCount"> 
        /// Specifies the size of the array for storing the returned object names.
        /// </param>
        /// <param name="count">[length: 1] 
        /// Returns the number of names actually returned in shaders.
        /// </param>
        /// <param name="shaders">[length: maxCount] 
        /// Specifies an array that is used to return the names of attached shader objects.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetAttachedShaders")]
        public static extern void GetAttachedShaders(Int32 program, Int32 maxCount, [OutAttribute] out Int32 count, [OutAttribute] Int32[] shaders);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the handles of the shader objects attached to a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="maxCount"> 
        /// Specifies the size of the array for storing the returned object names.
        /// </param>
        /// <param name="count">[length: 1] 
        /// Returns the number of names actually returned in shaders.
        /// </param>
        /// <param name="shaders">[length: maxCount] 
        /// Specifies an array that is used to return the names of attached shader objects.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetAttachedShaders")]
        public static extern void GetAttachedShaders(Int32 program, Int32 maxCount, [OutAttribute] out Int32 count, [OutAttribute] out Int32 shaders);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the handles of the shader objects attached to a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="maxCount"> 
        /// Specifies the size of the array for storing the returned object names.
        /// </param>
        /// <param name="count">[length: 1] 
        /// Returns the number of names actually returned in shaders.
        /// </param>
        /// <param name="shaders">[length: maxCount] 
        /// Specifies an array that is used to return the names of attached shader objects.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetAttachedShaders")]
        public static extern unsafe void GetAttachedShaders(Int32 program, Int32 maxCount, [OutAttribute] Int32* count, [OutAttribute] Int32* shaders);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the handles of the shader objects attached to a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="maxCount"> 
        /// Specifies the size of the array for storing the returned object names.
        /// </param>
        /// <param name="count">[length: 1] 
        /// Returns the number of names actually returned in shaders.
        /// </param>
        /// <param name="shaders">[length: maxCount] 
        /// Specifies an array that is used to return the names of attached shader objects.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetAttachedShaders")]
        public static extern void GetAttachedShaders(UInt32 program, Int32 maxCount, [OutAttribute] out Int32 count, [OutAttribute] UInt32[] shaders);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the handles of the shader objects attached to a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="maxCount"> 
        /// Specifies the size of the array for storing the returned object names.
        /// </param>
        /// <param name="count">[length: 1] 
        /// Returns the number of names actually returned in shaders.
        /// </param>
        /// <param name="shaders">[length: maxCount] 
        /// Specifies an array that is used to return the names of attached shader objects.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetAttachedShaders")]
        public static extern void GetAttachedShaders(UInt32 program, Int32 maxCount, [OutAttribute] out Int32 count, [OutAttribute] out UInt32 shaders);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the handles of the shader objects attached to a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="maxCount"> 
        /// Specifies the size of the array for storing the returned object names.
        /// </param>
        /// <param name="count">[length: 1] 
        /// Returns the number of names actually returned in shaders.
        /// </param>
        /// <param name="shaders">[length: maxCount] 
        /// Specifies an array that is used to return the names of attached shader objects.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetAttachedShaders")]
        public static extern unsafe void GetAttachedShaders(UInt32 program, Int32 maxCount, [OutAttribute] Int32* count, [OutAttribute] UInt32* shaders);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the location of an attribute variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="name"> 
        /// Points to a null terminated string containing the name of the attribute variable whose location is to be queried.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetAttribLocation")]
        public static extern Int32 GetAttribLocation(Int32 program, String name);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the location of an attribute variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="name"> 
        /// Points to a null terminated string containing the name of the attribute variable whose location is to be queried.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetAttribLocation")]
        public static extern Int32 GetAttribLocation(UInt32 program, String name);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="pname"></param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetBooleanv")]
        public static extern bool GetBoolean(All pname);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="pname"></param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetBooleanv")]
        public static extern bool GetBoolean(GetPName pname);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetBooleanv")]
        public static extern void GetBoolean(All pname, [OutAttribute] bool[] data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetBooleanv")]
        public static extern void GetBoolean(All pname, [OutAttribute] out bool data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetBooleanv")]
        public static extern unsafe void GetBoolean(All pname, [OutAttribute] bool* data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetBooleanv")]
        public static extern void GetBoolean(GetPName pname, [OutAttribute] bool[] data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetBooleanv")]
        public static extern void GetBoolean(GetPName pname, [OutAttribute] out bool data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetBooleanv")]
        public static extern unsafe void GetBoolean(GetPName pname, [OutAttribute] bool* data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return parameters of a buffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a buffer object parameter. Accepted values are BufferSize or BufferUsage.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetBufferParameteriv")]
        public static extern void GetBufferParameter(All target, All pname, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return parameters of a buffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a buffer object parameter. Accepted values are BufferSize or BufferUsage.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetBufferParameteriv")]
        public static extern void GetBufferParameter(All target, All pname, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return parameters of a buffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a buffer object parameter. Accepted values are BufferSize or BufferUsage.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetBufferParameteriv")]
        public static extern unsafe void GetBufferParameter(All target, All pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return parameters of a buffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a buffer object parameter. Accepted values are BufferSize or BufferUsage.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetBufferParameteriv")]
        public static extern void GetBufferParameter(BufferTarget target, BufferParameterName pname, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return parameters of a buffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a buffer object parameter. Accepted values are BufferSize or BufferUsage.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetBufferParameteriv")]
        public static extern void GetBufferParameter(BufferTarget target, BufferParameterName pname, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return parameters of a buffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a buffer object parameter. Accepted values are BufferSize or BufferUsage.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetBufferParameteriv")]
        public static extern unsafe void GetBufferParameter(BufferTarget target, BufferParameterName pname, [OutAttribute] Int32* @params);













        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return error information
        /// </summary>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetError")]
        public static extern ErrorCode GetError();

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="pname"></param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetFloatv")]
        public static extern Single GetFloat(All pname);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="pname"></param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetFloatv")]
        public static extern Single GetFloat(GetPName pname);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetFloatv")]
        public static extern void GetFloat(All pname, [OutAttribute] Single[] data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetFloatv")]
        public static extern void GetFloat(All pname, [OutAttribute] out Single data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetFloatv")]
        public static extern unsafe void GetFloat(All pname, [OutAttribute] Single* data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetFloatv")]
        public static extern void GetFloat(GetPName pname, [OutAttribute] Single[] data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetFloatv")]
        public static extern void GetFloat(GetPName pname, [OutAttribute] out Single data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetFloatv")]
        public static extern unsafe void GetFloat(GetPName pname, [OutAttribute] Single* data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return attachment parameters of a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target framebuffer object. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="attachment"> 
        /// Specifies the symbolic name of a framebuffer object attachment point. Accepted values are ColorAttachment0, DepthAttachment, and StencilAttachment.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a framebuffer object attachment parameter. Accepted values are FramebufferAttachmentObjectType, FramebufferAttachmentObjectName, FramebufferAttachmentTextureLevel, and FramebufferAttachmentTextureCubeMapFace.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public static extern void GetFramebufferAttachmentParameter(All target, All attachment, All pname, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return attachment parameters of a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target framebuffer object. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="attachment"> 
        /// Specifies the symbolic name of a framebuffer object attachment point. Accepted values are ColorAttachment0, DepthAttachment, and StencilAttachment.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a framebuffer object attachment parameter. Accepted values are FramebufferAttachmentObjectType, FramebufferAttachmentObjectName, FramebufferAttachmentTextureLevel, and FramebufferAttachmentTextureCubeMapFace.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public static extern void GetFramebufferAttachmentParameter(All target, All attachment, All pname, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return attachment parameters of a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target framebuffer object. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="attachment"> 
        /// Specifies the symbolic name of a framebuffer object attachment point. Accepted values are ColorAttachment0, DepthAttachment, and StencilAttachment.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a framebuffer object attachment parameter. Accepted values are FramebufferAttachmentObjectType, FramebufferAttachmentObjectName, FramebufferAttachmentTextureLevel, and FramebufferAttachmentTextureCubeMapFace.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public static extern unsafe void GetFramebufferAttachmentParameter(All target, All attachment, All pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return attachment parameters of a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target framebuffer object. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="attachment"> 
        /// Specifies the symbolic name of a framebuffer object attachment point. Accepted values are ColorAttachment0, DepthAttachment, and StencilAttachment.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a framebuffer object attachment parameter. Accepted values are FramebufferAttachmentObjectType, FramebufferAttachmentObjectName, FramebufferAttachmentTextureLevel, and FramebufferAttachmentTextureCubeMapFace.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public static extern void GetFramebufferAttachmentParameter(FramebufferTarget target, All attachment, FramebufferParameterName pname, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return attachment parameters of a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target framebuffer object. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="attachment"> 
        /// Specifies the symbolic name of a framebuffer object attachment point. Accepted values are ColorAttachment0, DepthAttachment, and StencilAttachment.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a framebuffer object attachment parameter. Accepted values are FramebufferAttachmentObjectType, FramebufferAttachmentObjectName, FramebufferAttachmentTextureLevel, and FramebufferAttachmentTextureCubeMapFace.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public static extern void GetFramebufferAttachmentParameter(FramebufferTarget target, All attachment, FramebufferParameterName pname, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return attachment parameters of a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target framebuffer object. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="attachment"> 
        /// Specifies the symbolic name of a framebuffer object attachment point. Accepted values are ColorAttachment0, DepthAttachment, and StencilAttachment.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a framebuffer object attachment parameter. Accepted values are FramebufferAttachmentObjectType, FramebufferAttachmentObjectName, FramebufferAttachmentTextureLevel, and FramebufferAttachmentTextureCubeMapFace.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public static extern unsafe void GetFramebufferAttachmentParameter(FramebufferTarget target, All attachment, FramebufferParameterName pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return attachment parameters of a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target framebuffer object. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="attachment"> 
        /// Specifies the symbolic name of a framebuffer object attachment point. Accepted values are ColorAttachment0, DepthAttachment, and StencilAttachment.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a framebuffer object attachment parameter. Accepted values are FramebufferAttachmentObjectType, FramebufferAttachmentObjectName, FramebufferAttachmentTextureLevel, and FramebufferAttachmentTextureCubeMapFace.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public static extern void GetFramebufferAttachmentParameter(FramebufferTarget target, FramebufferSlot attachment, FramebufferParameterName pname, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return attachment parameters of a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target framebuffer object. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="attachment"> 
        /// Specifies the symbolic name of a framebuffer object attachment point. Accepted values are ColorAttachment0, DepthAttachment, and StencilAttachment.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a framebuffer object attachment parameter. Accepted values are FramebufferAttachmentObjectType, FramebufferAttachmentObjectName, FramebufferAttachmentTextureLevel, and FramebufferAttachmentTextureCubeMapFace.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public static extern void GetFramebufferAttachmentParameter(FramebufferTarget target, FramebufferSlot attachment, FramebufferParameterName pname, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return attachment parameters of a framebuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target framebuffer object. The symbolic constant must be Framebuffer.
        /// </param>
        /// <param name="attachment"> 
        /// Specifies the symbolic name of a framebuffer object attachment point. Accepted values are ColorAttachment0, DepthAttachment, and StencilAttachment.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a framebuffer object attachment parameter. Accepted values are FramebufferAttachmentObjectType, FramebufferAttachmentObjectName, FramebufferAttachmentTextureLevel, and FramebufferAttachmentTextureCubeMapFace.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public static extern unsafe void GetFramebufferAttachmentParameter(FramebufferTarget target, FramebufferSlot attachment, FramebufferParameterName pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="pname"></param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetIntegerv")]
        public static extern Int32 GetInteger(All pname);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="pname"></param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetIntegerv")]
        public static extern Int32 GetInteger(GetPName pname);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetIntegerv")]
        public static extern void GetInteger(All pname, [OutAttribute] Int32[] data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetIntegerv")]
        public static extern void GetInteger(All pname, [OutAttribute] out Int32 data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetIntegerv")]
        public static extern unsafe void GetInteger(All pname, [OutAttribute] Int32* data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetIntegerv")]
        public static extern void GetInteger(GetPName pname, [OutAttribute] Int32[] data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetIntegerv")]
        public static extern void GetInteger(GetPName pname, [OutAttribute] out Int32 data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetIntegerv")]
        public static extern unsafe void GetInteger(GetPName pname, [OutAttribute] Int32* data);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the information log for a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object whose information log is to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the size of the character buffer for storing the returned information log.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the length of the string returned in infoLog (excluding the null terminator).
        /// </param>
        /// <param name="infoLog">[length: bufSize] 
        /// Specifies an array of characters that is used to return the information log.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetProgramInfoLog")]
        public static extern void GetProgramInfoLog(Int32 program, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] StringBuilder infoLog);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the information log for a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object whose information log is to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the size of the character buffer for storing the returned information log.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the length of the string returned in infoLog (excluding the null terminator).
        /// </param>
        /// <param name="infoLog">[length: bufSize] 
        /// Specifies an array of characters that is used to return the information log.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetProgramInfoLog")]
        public static extern unsafe void GetProgramInfoLog(Int32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the information log for a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object whose information log is to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the size of the character buffer for storing the returned information log.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the length of the string returned in infoLog (excluding the null terminator).
        /// </param>
        /// <param name="infoLog">[length: bufSize] 
        /// Specifies an array of characters that is used to return the information log.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetProgramInfoLog")]
        public static extern void GetProgramInfoLog(UInt32 program, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] StringBuilder infoLog);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the information log for a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object whose information log is to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the size of the character buffer for storing the returned information log.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the length of the string returned in infoLog (excluding the null terminator).
        /// </param>
        /// <param name="infoLog">[length: bufSize] 
        /// Specifies an array of characters that is used to return the information log.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetProgramInfoLog")]
        public static extern unsafe void GetProgramInfoLog(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are DeleteStatus, LinkStatus, ValidateStatus, InfoLogLength, AttachedShaders, ActiveAttributes, ActiveAttributeMaxLength, ActiveUniforms, ActiveUniformMaxLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetProgramiv")]
        public static extern void GetProgram(Int32 program, All pname, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are DeleteStatus, LinkStatus, ValidateStatus, InfoLogLength, AttachedShaders, ActiveAttributes, ActiveAttributeMaxLength, ActiveUniforms, ActiveUniformMaxLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetProgramiv")]
        public static extern void GetProgram(Int32 program, All pname, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are DeleteStatus, LinkStatus, ValidateStatus, InfoLogLength, AttachedShaders, ActiveAttributes, ActiveAttributeMaxLength, ActiveUniforms, ActiveUniformMaxLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetProgramiv")]
        public static extern unsafe void GetProgram(Int32 program, All pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are DeleteStatus, LinkStatus, ValidateStatus, InfoLogLength, AttachedShaders, ActiveAttributes, ActiveAttributeMaxLength, ActiveUniforms, ActiveUniformMaxLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetProgramiv")]
        public static extern void GetProgram(Int32 program, GetProgramParameterName pname, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are DeleteStatus, LinkStatus, ValidateStatus, InfoLogLength, AttachedShaders, ActiveAttributes, ActiveAttributeMaxLength, ActiveUniforms, ActiveUniformMaxLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetProgramiv")]
        public static extern void GetProgram(Int32 program, GetProgramParameterName pname, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are DeleteStatus, LinkStatus, ValidateStatus, InfoLogLength, AttachedShaders, ActiveAttributes, ActiveAttributeMaxLength, ActiveUniforms, ActiveUniformMaxLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetProgramiv")]
        public static extern unsafe void GetProgram(Int32 program, GetProgramParameterName pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are DeleteStatus, LinkStatus, ValidateStatus, InfoLogLength, AttachedShaders, ActiveAttributes, ActiveAttributeMaxLength, ActiveUniforms, ActiveUniformMaxLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetProgramiv")]
        public static extern void GetProgram(Int32 program, ProgramParameter pname, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are DeleteStatus, LinkStatus, ValidateStatus, InfoLogLength, AttachedShaders, ActiveAttributes, ActiveAttributeMaxLength, ActiveUniforms, ActiveUniformMaxLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetProgramiv")]
        public static extern void GetProgram(Int32 program, ProgramParameter pname, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are DeleteStatus, LinkStatus, ValidateStatus, InfoLogLength, AttachedShaders, ActiveAttributes, ActiveAttributeMaxLength, ActiveUniforms, ActiveUniformMaxLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetProgramiv")]
        public static extern unsafe void GetProgram(Int32 program, ProgramParameter pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are DeleteStatus, LinkStatus, ValidateStatus, InfoLogLength, AttachedShaders, ActiveAttributes, ActiveAttributeMaxLength, ActiveUniforms, ActiveUniformMaxLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetProgramiv")]
        public static extern void GetProgram(UInt32 program, All pname, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are DeleteStatus, LinkStatus, ValidateStatus, InfoLogLength, AttachedShaders, ActiveAttributes, ActiveAttributeMaxLength, ActiveUniforms, ActiveUniformMaxLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetProgramiv")]
        public static extern void GetProgram(UInt32 program, All pname, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are DeleteStatus, LinkStatus, ValidateStatus, InfoLogLength, AttachedShaders, ActiveAttributes, ActiveAttributeMaxLength, ActiveUniforms, ActiveUniformMaxLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetProgramiv")]
        public static extern unsafe void GetProgram(UInt32 program, All pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are DeleteStatus, LinkStatus, ValidateStatus, InfoLogLength, AttachedShaders, ActiveAttributes, ActiveAttributeMaxLength, ActiveUniforms, ActiveUniformMaxLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetProgramiv")]
        public static extern void GetProgram(UInt32 program, GetProgramParameterName pname, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are DeleteStatus, LinkStatus, ValidateStatus, InfoLogLength, AttachedShaders, ActiveAttributes, ActiveAttributeMaxLength, ActiveUniforms, ActiveUniformMaxLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetProgramiv")]
        public static extern void GetProgram(UInt32 program, GetProgramParameterName pname, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are DeleteStatus, LinkStatus, ValidateStatus, InfoLogLength, AttachedShaders, ActiveAttributes, ActiveAttributeMaxLength, ActiveUniforms, ActiveUniformMaxLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetProgramiv")]
        public static extern unsafe void GetProgram(UInt32 program, GetProgramParameterName pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are DeleteStatus, LinkStatus, ValidateStatus, InfoLogLength, AttachedShaders, ActiveAttributes, ActiveAttributeMaxLength, ActiveUniforms, ActiveUniformMaxLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetProgramiv")]
        public static extern void GetProgram(UInt32 program, ProgramParameter pname, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are DeleteStatus, LinkStatus, ValidateStatus, InfoLogLength, AttachedShaders, ActiveAttributes, ActiveAttributeMaxLength, ActiveUniforms, ActiveUniformMaxLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetProgramiv")]
        public static extern void GetProgram(UInt32 program, ProgramParameter pname, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are DeleteStatus, LinkStatus, ValidateStatus, InfoLogLength, AttachedShaders, ActiveAttributes, ActiveAttributeMaxLength, ActiveUniforms, ActiveUniformMaxLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetProgramiv")]
        public static extern unsafe void GetProgram(UInt32 program, ProgramParameter pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return parameters of a renderbuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target renderbuffer object. The symbolic constant must be Renderbuffer.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a renderbuffer object parameter. Accepted values are RenderbufferWidth, RenderbufferHeight, RenderbufferInternalFormat, RenderbufferRedSize, RenderbufferGreenSize, RenderbufferBlueSize, RenderbufferAlphaSize, RenderbufferDepthSize, or RenderbufferStencilSize.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetRenderbufferParameteriv")]
        public static extern void GetRenderbufferParameter(All target, All pname, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return parameters of a renderbuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target renderbuffer object. The symbolic constant must be Renderbuffer.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a renderbuffer object parameter. Accepted values are RenderbufferWidth, RenderbufferHeight, RenderbufferInternalFormat, RenderbufferRedSize, RenderbufferGreenSize, RenderbufferBlueSize, RenderbufferAlphaSize, RenderbufferDepthSize, or RenderbufferStencilSize.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetRenderbufferParameteriv")]
        public static extern void GetRenderbufferParameter(All target, All pname, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return parameters of a renderbuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target renderbuffer object. The symbolic constant must be Renderbuffer.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a renderbuffer object parameter. Accepted values are RenderbufferWidth, RenderbufferHeight, RenderbufferInternalFormat, RenderbufferRedSize, RenderbufferGreenSize, RenderbufferBlueSize, RenderbufferAlphaSize, RenderbufferDepthSize, or RenderbufferStencilSize.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetRenderbufferParameteriv")]
        public static extern unsafe void GetRenderbufferParameter(All target, All pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return parameters of a renderbuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target renderbuffer object. The symbolic constant must be Renderbuffer.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a renderbuffer object parameter. Accepted values are RenderbufferWidth, RenderbufferHeight, RenderbufferInternalFormat, RenderbufferRedSize, RenderbufferGreenSize, RenderbufferBlueSize, RenderbufferAlphaSize, RenderbufferDepthSize, or RenderbufferStencilSize.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetRenderbufferParameteriv")]
        public static extern void GetRenderbufferParameter(RenderbufferTarget target, RenderbufferParameterName pname, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return parameters of a renderbuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target renderbuffer object. The symbolic constant must be Renderbuffer.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a renderbuffer object parameter. Accepted values are RenderbufferWidth, RenderbufferHeight, RenderbufferInternalFormat, RenderbufferRedSize, RenderbufferGreenSize, RenderbufferBlueSize, RenderbufferAlphaSize, RenderbufferDepthSize, or RenderbufferStencilSize.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetRenderbufferParameteriv")]
        public static extern void GetRenderbufferParameter(RenderbufferTarget target, RenderbufferParameterName pname, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return parameters of a renderbuffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target renderbuffer object. The symbolic constant must be Renderbuffer.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a renderbuffer object parameter. Accepted values are RenderbufferWidth, RenderbufferHeight, RenderbufferInternalFormat, RenderbufferRedSize, RenderbufferGreenSize, RenderbufferBlueSize, RenderbufferAlphaSize, RenderbufferDepthSize, or RenderbufferStencilSize.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetRenderbufferParameteriv")]
        public static extern unsafe void GetRenderbufferParameter(RenderbufferTarget target, RenderbufferParameterName pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the information log for a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the shader object whose information log is to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the size of the character buffer for storing the returned information log.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the length of the string returned in infoLog (excluding the null terminator).
        /// </param>
        /// <param name="infoLog">[length: bufSize] 
        /// Specifies an array of characters that is used to return the information log.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderInfoLog")]
        public static extern void GetShaderInfoLog(Int32 shader, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] StringBuilder infoLog);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the information log for a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the shader object whose information log is to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the size of the character buffer for storing the returned information log.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the length of the string returned in infoLog (excluding the null terminator).
        /// </param>
        /// <param name="infoLog">[length: bufSize] 
        /// Specifies an array of characters that is used to return the information log.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderInfoLog")]
        public static extern unsafe void GetShaderInfoLog(Int32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the information log for a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the shader object whose information log is to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the size of the character buffer for storing the returned information log.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the length of the string returned in infoLog (excluding the null terminator).
        /// </param>
        /// <param name="infoLog">[length: bufSize] 
        /// Specifies an array of characters that is used to return the information log.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderInfoLog")]
        public static extern void GetShaderInfoLog(UInt32 shader, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] StringBuilder infoLog);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the information log for a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the shader object whose information log is to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the size of the character buffer for storing the returned information log.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the length of the string returned in infoLog (excluding the null terminator).
        /// </param>
        /// <param name="infoLog">[length: bufSize] 
        /// Specifies an array of characters that is used to return the information log.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderInfoLog")]
        public static extern unsafe void GetShaderInfoLog(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the shader object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are ShaderType, DeleteStatus, CompileStatus, InfoLogLength, ShaderSourceLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderiv")]
        public static extern void GetShader(Int32 shader, All pname, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the shader object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are ShaderType, DeleteStatus, CompileStatus, InfoLogLength, ShaderSourceLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderiv")]
        public static extern void GetShader(Int32 shader, All pname, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the shader object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are ShaderType, DeleteStatus, CompileStatus, InfoLogLength, ShaderSourceLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderiv")]
        public static extern unsafe void GetShader(Int32 shader, All pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the shader object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are ShaderType, DeleteStatus, CompileStatus, InfoLogLength, ShaderSourceLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderiv")]
        public static extern void GetShader(Int32 shader, ShaderParameter pname, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the shader object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are ShaderType, DeleteStatus, CompileStatus, InfoLogLength, ShaderSourceLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderiv")]
        public static extern void GetShader(Int32 shader, ShaderParameter pname, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the shader object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are ShaderType, DeleteStatus, CompileStatus, InfoLogLength, ShaderSourceLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderiv")]
        public static extern unsafe void GetShader(Int32 shader, ShaderParameter pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the shader object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are ShaderType, DeleteStatus, CompileStatus, InfoLogLength, ShaderSourceLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderiv")]
        public static extern void GetShader(UInt32 shader, All pname, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the shader object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are ShaderType, DeleteStatus, CompileStatus, InfoLogLength, ShaderSourceLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderiv")]
        public static extern void GetShader(UInt32 shader, All pname, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the shader object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are ShaderType, DeleteStatus, CompileStatus, InfoLogLength, ShaderSourceLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderiv")]
        public static extern unsafe void GetShader(UInt32 shader, All pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the shader object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are ShaderType, DeleteStatus, CompileStatus, InfoLogLength, ShaderSourceLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderiv")]
        public static extern void GetShader(UInt32 shader, ShaderParameter pname, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the shader object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are ShaderType, DeleteStatus, CompileStatus, InfoLogLength, ShaderSourceLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderiv")]
        public static extern void GetShader(UInt32 shader, ShaderParameter pname, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a parameter from a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the shader object to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the object parameter. Accepted symbolic names are ShaderType, DeleteStatus, CompileStatus, InfoLogLength, ShaderSourceLength.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the requested object parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderiv")]
        public static extern unsafe void GetShader(UInt32 shader, ShaderParameter pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the range and precision for different shader numeric formats
        /// </summary>
        /// <param name="shadertype"> 
        /// Specifies the type of shader to query. Must be either VertexShader or FragmentShader.
        /// </param>
        /// <param name="precisiontype"> 
        /// Specifies the numeric format to query, corresponding to a shader precision qualifier and variable type. Must be one of LowFloat, MediumFloat, HighFloat, LowInt, MediumInt, or HighInt.
        /// </param>
        /// <param name="range">[length: 2] 
        /// Specifies a pointer to the two-element array in which the log sub 2 of the minimum and maximum representable magnitudes of the format are returned.
        /// </param>
        /// <param name="precision">[length: 2] 
        /// Specifies a pointer to the location in which the log sub 2 of the precision of the format is returned.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderPrecisionFormat")]
        public static extern void GetShaderPrecisionFormat(All shadertype, All precisiontype, [OutAttribute] Int32[] range, [OutAttribute] Int32[] precision);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the range and precision for different shader numeric formats
        /// </summary>
        /// <param name="shadertype"> 
        /// Specifies the type of shader to query. Must be either VertexShader or FragmentShader.
        /// </param>
        /// <param name="precisiontype"> 
        /// Specifies the numeric format to query, corresponding to a shader precision qualifier and variable type. Must be one of LowFloat, MediumFloat, HighFloat, LowInt, MediumInt, or HighInt.
        /// </param>
        /// <param name="range">[length: 2] 
        /// Specifies a pointer to the two-element array in which the log sub 2 of the minimum and maximum representable magnitudes of the format are returned.
        /// </param>
        /// <param name="precision">[length: 2] 
        /// Specifies a pointer to the location in which the log sub 2 of the precision of the format is returned.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderPrecisionFormat")]
        public static extern void GetShaderPrecisionFormat(All shadertype, All precisiontype, [OutAttribute] out Int32 range, [OutAttribute] out Int32 precision);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the range and precision for different shader numeric formats
        /// </summary>
        /// <param name="shadertype"> 
        /// Specifies the type of shader to query. Must be either VertexShader or FragmentShader.
        /// </param>
        /// <param name="precisiontype"> 
        /// Specifies the numeric format to query, corresponding to a shader precision qualifier and variable type. Must be one of LowFloat, MediumFloat, HighFloat, LowInt, MediumInt, or HighInt.
        /// </param>
        /// <param name="range">[length: 2] 
        /// Specifies a pointer to the two-element array in which the log sub 2 of the minimum and maximum representable magnitudes of the format are returned.
        /// </param>
        /// <param name="precision">[length: 2] 
        /// Specifies a pointer to the location in which the log sub 2 of the precision of the format is returned.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderPrecisionFormat")]
        public static extern unsafe void GetShaderPrecisionFormat(All shadertype, All precisiontype, [OutAttribute] Int32* range, [OutAttribute] Int32* precision);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the range and precision for different shader numeric formats
        /// </summary>
        /// <param name="shadertype"> 
        /// Specifies the type of shader to query. Must be either VertexShader or FragmentShader.
        /// </param>
        /// <param name="precisiontype"> 
        /// Specifies the numeric format to query, corresponding to a shader precision qualifier and variable type. Must be one of LowFloat, MediumFloat, HighFloat, LowInt, MediumInt, or HighInt.
        /// </param>
        /// <param name="range">[length: 2] 
        /// Specifies a pointer to the two-element array in which the log sub 2 of the minimum and maximum representable magnitudes of the format are returned.
        /// </param>
        /// <param name="precision">[length: 2] 
        /// Specifies a pointer to the location in which the log sub 2 of the precision of the format is returned.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderPrecisionFormat")]
        public static extern void GetShaderPrecisionFormat(ShaderType shadertype, ShaderPrecision precisiontype, [OutAttribute] Int32[] range, [OutAttribute] Int32[] precision);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the range and precision for different shader numeric formats
        /// </summary>
        /// <param name="shadertype"> 
        /// Specifies the type of shader to query. Must be either VertexShader or FragmentShader.
        /// </param>
        /// <param name="precisiontype"> 
        /// Specifies the numeric format to query, corresponding to a shader precision qualifier and variable type. Must be one of LowFloat, MediumFloat, HighFloat, LowInt, MediumInt, or HighInt.
        /// </param>
        /// <param name="range">[length: 2] 
        /// Specifies a pointer to the two-element array in which the log sub 2 of the minimum and maximum representable magnitudes of the format are returned.
        /// </param>
        /// <param name="precision">[length: 2] 
        /// Specifies a pointer to the location in which the log sub 2 of the precision of the format is returned.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderPrecisionFormat")]
        public static extern void GetShaderPrecisionFormat(ShaderType shadertype, ShaderPrecision precisiontype, [OutAttribute] out Int32 range, [OutAttribute] out Int32 precision);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the range and precision for different shader numeric formats
        /// </summary>
        /// <param name="shadertype"> 
        /// Specifies the type of shader to query. Must be either VertexShader or FragmentShader.
        /// </param>
        /// <param name="precisiontype"> 
        /// Specifies the numeric format to query, corresponding to a shader precision qualifier and variable type. Must be one of LowFloat, MediumFloat, HighFloat, LowInt, MediumInt, or HighInt.
        /// </param>
        /// <param name="range">[length: 2] 
        /// Specifies a pointer to the two-element array in which the log sub 2 of the minimum and maximum representable magnitudes of the format are returned.
        /// </param>
        /// <param name="precision">[length: 2] 
        /// Specifies a pointer to the location in which the log sub 2 of the precision of the format is returned.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderPrecisionFormat")]
        public static extern unsafe void GetShaderPrecisionFormat(ShaderType shadertype, ShaderPrecision precisiontype, [OutAttribute] Int32* range, [OutAttribute] Int32* precision);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the source code string from a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the shader object to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the size of the character buffer for storing the returned source code string.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the length of the string returned in source (excluding the null terminator).
        /// </param>
        /// <param name="source">[length: bufSize] 
        /// Specifies an array of characters that is used to return the source code string.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderSource")]
        public static extern void GetShaderSource(Int32 shader, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] StringBuilder source);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the source code string from a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the shader object to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the size of the character buffer for storing the returned source code string.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the length of the string returned in source (excluding the null terminator).
        /// </param>
        /// <param name="source">[length: bufSize] 
        /// Specifies an array of characters that is used to return the source code string.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderSource")]
        public static extern unsafe void GetShaderSource(Int32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder source);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the source code string from a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the shader object to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the size of the character buffer for storing the returned source code string.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the length of the string returned in source (excluding the null terminator).
        /// </param>
        /// <param name="source">[length: bufSize] 
        /// Specifies an array of characters that is used to return the source code string.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderSource")]
        public static extern void GetShaderSource(UInt32 shader, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] StringBuilder source);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the source code string from a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the shader object to be queried.
        /// </param>
        /// <param name="bufSize"> 
        /// Specifies the size of the character buffer for storing the returned source code string.
        /// </param>
        /// <param name="length">[length: 1] 
        /// Returns the length of the string returned in source (excluding the null terminator).
        /// </param>
        /// <param name="source">[length: bufSize] 
        /// Specifies an array of characters that is used to return the source code string.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetShaderSource")]
        public static extern unsafe void GetShaderSource(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder source);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a string describing the current GL connection
        /// </summary>
        /// <param name="name"> 
        /// Specifies a symbolic constant, one of Vendor, Renderer, Version, ShadingLanguageVersion, or Extensions.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetString")]
        public static extern String GetString(All name);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a string describing the current GL connection
        /// </summary>
        /// <param name="name"> 
        /// Specifies a symbolic constant, one of Vendor, Renderer, Version, ShadingLanguageVersion, or Extensions.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetString")]
        public static extern String GetString(StringName name);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetTexParameterfv")]
        public static extern void GetTexParameter(All target, All pname, [OutAttribute] Single[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetTexParameterfv")]
        public static extern void GetTexParameter(All target, All pname, [OutAttribute] out Single @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetTexParameterfv")]
        public static extern unsafe void GetTexParameter(All target, All pname, [OutAttribute] Single* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetTexParameterfv")]
        public static extern void GetTexParameter(TextureTarget target, GetTextureParameter pname, [OutAttribute] Single[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetTexParameterfv")]
        public static extern void GetTexParameter(TextureTarget target, GetTextureParameter pname, [OutAttribute] out Single @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetTexParameterfv")]
        public static extern unsafe void GetTexParameter(TextureTarget target, GetTextureParameter pname, [OutAttribute] Single* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetTexParameterfv")]
        public static extern void GetTexParameter(TextureTarget target, GetTextureParameterName pname, [OutAttribute] Single[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetTexParameterfv")]
        public static extern void GetTexParameter(TextureTarget target, GetTextureParameterName pname, [OutAttribute] out Single @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetTexParameterfv")]
        public static extern unsafe void GetTexParameter(TextureTarget target, GetTextureParameterName pname, [OutAttribute] Single* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetTexParameteriv")]
        public static extern void GetTexParameter(All target, All pname, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetTexParameteriv")]
        public static extern void GetTexParameter(All target, All pname, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetTexParameteriv")]
        public static extern unsafe void GetTexParameter(All target, All pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetTexParameteriv")]
        public static extern void GetTexParameter(TextureTarget target, GetTextureParameter pname, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetTexParameteriv")]
        public static extern void GetTexParameter(TextureTarget target, GetTextureParameter pname, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetTexParameteriv")]
        public static extern unsafe void GetTexParameter(TextureTarget target, GetTextureParameter pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetTexParameteriv")]
        public static extern void GetTexParameter(TextureTarget target, GetTextureParameterName pname, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetTexParameteriv")]
        public static extern void GetTexParameter(TextureTarget target, GetTextureParameterName pname, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetTexParameteriv")]
        public static extern unsafe void GetTexParameter(TextureTarget target, GetTextureParameterName pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the value of a uniform variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be queried.
        /// </param>
        /// <param name="@params">[length: program, location] 
        /// Returns the value of the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetUniformfv")]
        public static extern void GetUniform(Int32 program, Int32 location, [OutAttribute] Single[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the value of a uniform variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be queried.
        /// </param>
        /// <param name="@params">[length: program, location] 
        /// Returns the value of the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetUniformfv")]
        public static extern void GetUniform(Int32 program, Int32 location, [OutAttribute] out Single @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the value of a uniform variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be queried.
        /// </param>
        /// <param name="@params">[length: program, location] 
        /// Returns the value of the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetUniformfv")]
        public static extern unsafe void GetUniform(Int32 program, Int32 location, [OutAttribute] Single* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the value of a uniform variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be queried.
        /// </param>
        /// <param name="@params">[length: program, location] 
        /// Returns the value of the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetUniformfv")]
        public static extern void GetUniform(UInt32 program, Int32 location, [OutAttribute] Single[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the value of a uniform variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be queried.
        /// </param>
        /// <param name="@params">[length: program, location] 
        /// Returns the value of the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetUniformfv")]
        public static extern void GetUniform(UInt32 program, Int32 location, [OutAttribute] out Single @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the value of a uniform variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be queried.
        /// </param>
        /// <param name="@params">[length: program, location] 
        /// Returns the value of the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetUniformfv")]
        public static extern unsafe void GetUniform(UInt32 program, Int32 location, [OutAttribute] Single* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the value of a uniform variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be queried.
        /// </param>
        /// <param name="@params">[length: program, location] 
        /// Returns the value of the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetUniformiv")]
        public static extern void GetUniform(Int32 program, Int32 location, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the value of a uniform variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be queried.
        /// </param>
        /// <param name="@params">[length: program, location] 
        /// Returns the value of the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetUniformiv")]
        public static extern void GetUniform(Int32 program, Int32 location, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the value of a uniform variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be queried.
        /// </param>
        /// <param name="@params">[length: program, location] 
        /// Returns the value of the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetUniformiv")]
        public static extern unsafe void GetUniform(Int32 program, Int32 location, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the value of a uniform variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be queried.
        /// </param>
        /// <param name="@params">[length: program, location] 
        /// Returns the value of the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetUniformiv")]
        public static extern void GetUniform(UInt32 program, Int32 location, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the value of a uniform variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be queried.
        /// </param>
        /// <param name="@params">[length: program, location] 
        /// Returns the value of the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetUniformiv")]
        public static extern void GetUniform(UInt32 program, Int32 location, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the value of a uniform variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be queried.
        /// </param>
        /// <param name="@params">[length: program, location] 
        /// Returns the value of the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetUniformiv")]
        public static extern unsafe void GetUniform(UInt32 program, Int32 location, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the location of a uniform variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="name"> 
        /// Points to a null terminated string containing the name of the uniform variable whose location is to be queried.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetUniformLocation")]
        public static extern Int32 GetUniformLocation(Int32 program, String name);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the location of a uniform variable
        /// </summary>
        /// <param name="program"> 
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="name"> 
        /// Points to a null terminated string containing the name of the uniform variable whose location is to be queried.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetUniformLocation")]
        public static extern Int32 GetUniformLocation(UInt32 program, String name);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are VertexAttribArrayBufferBinding, VertexAttribArrayEnabled, VertexAttribArraySize, VertexAttribArrayStride, VertexAttribArrayType, VertexAttribArrayNormalized, or CurrentVertexAttrib.
        /// </param>
        /// <param name="@params">[length: 4] 
        /// Returns the requested data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribfv")]
        public static extern void GetVertexAttrib(Int32 index, All pname, [OutAttribute] Single[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are VertexAttribArrayBufferBinding, VertexAttribArrayEnabled, VertexAttribArraySize, VertexAttribArrayStride, VertexAttribArrayType, VertexAttribArrayNormalized, or CurrentVertexAttrib.
        /// </param>
        /// <param name="@params">[length: 4] 
        /// Returns the requested data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribfv")]
        public static extern void GetVertexAttrib(Int32 index, All pname, [OutAttribute] out Single @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are VertexAttribArrayBufferBinding, VertexAttribArrayEnabled, VertexAttribArraySize, VertexAttribArrayStride, VertexAttribArrayType, VertexAttribArrayNormalized, or CurrentVertexAttrib.
        /// </param>
        /// <param name="@params">[length: 4] 
        /// Returns the requested data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribfv")]
        public static extern unsafe void GetVertexAttrib(Int32 index, All pname, [OutAttribute] Single* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are VertexAttribArrayBufferBinding, VertexAttribArrayEnabled, VertexAttribArraySize, VertexAttribArrayStride, VertexAttribArrayType, VertexAttribArrayNormalized, or CurrentVertexAttrib.
        /// </param>
        /// <param name="@params">[length: 4] 
        /// Returns the requested data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribfv")]
        public static extern void GetVertexAttrib(Int32 index, VertexAttribParameter pname, [OutAttribute] Single[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are VertexAttribArrayBufferBinding, VertexAttribArrayEnabled, VertexAttribArraySize, VertexAttribArrayStride, VertexAttribArrayType, VertexAttribArrayNormalized, or CurrentVertexAttrib.
        /// </param>
        /// <param name="@params">[length: 4] 
        /// Returns the requested data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribfv")]
        public static extern void GetVertexAttrib(Int32 index, VertexAttribParameter pname, [OutAttribute] out Single @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are VertexAttribArrayBufferBinding, VertexAttribArrayEnabled, VertexAttribArraySize, VertexAttribArrayStride, VertexAttribArrayType, VertexAttribArrayNormalized, or CurrentVertexAttrib.
        /// </param>
        /// <param name="@params">[length: 4] 
        /// Returns the requested data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribfv")]
        public static extern unsafe void GetVertexAttrib(Int32 index, VertexAttribParameter pname, [OutAttribute] Single* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are VertexAttribArrayBufferBinding, VertexAttribArrayEnabled, VertexAttribArraySize, VertexAttribArrayStride, VertexAttribArrayType, VertexAttribArrayNormalized, or CurrentVertexAttrib.
        /// </param>
        /// <param name="@params">[length: 4] 
        /// Returns the requested data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribfv")]
        public static extern void GetVertexAttrib(UInt32 index, All pname, [OutAttribute] Single[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are VertexAttribArrayBufferBinding, VertexAttribArrayEnabled, VertexAttribArraySize, VertexAttribArrayStride, VertexAttribArrayType, VertexAttribArrayNormalized, or CurrentVertexAttrib.
        /// </param>
        /// <param name="@params">[length: 4] 
        /// Returns the requested data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribfv")]
        public static extern void GetVertexAttrib(UInt32 index, All pname, [OutAttribute] out Single @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are VertexAttribArrayBufferBinding, VertexAttribArrayEnabled, VertexAttribArraySize, VertexAttribArrayStride, VertexAttribArrayType, VertexAttribArrayNormalized, or CurrentVertexAttrib.
        /// </param>
        /// <param name="@params">[length: 4] 
        /// Returns the requested data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribfv")]
        public static extern unsafe void GetVertexAttrib(UInt32 index, All pname, [OutAttribute] Single* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are VertexAttribArrayBufferBinding, VertexAttribArrayEnabled, VertexAttribArraySize, VertexAttribArrayStride, VertexAttribArrayType, VertexAttribArrayNormalized, or CurrentVertexAttrib.
        /// </param>
        /// <param name="@params">[length: 4] 
        /// Returns the requested data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribfv")]
        public static extern void GetVertexAttrib(UInt32 index, VertexAttribParameter pname, [OutAttribute] Single[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are VertexAttribArrayBufferBinding, VertexAttribArrayEnabled, VertexAttribArraySize, VertexAttribArrayStride, VertexAttribArrayType, VertexAttribArrayNormalized, or CurrentVertexAttrib.
        /// </param>
        /// <param name="@params">[length: 4] 
        /// Returns the requested data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribfv")]
        public static extern void GetVertexAttrib(UInt32 index, VertexAttribParameter pname, [OutAttribute] out Single @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are VertexAttribArrayBufferBinding, VertexAttribArrayEnabled, VertexAttribArraySize, VertexAttribArrayStride, VertexAttribArrayType, VertexAttribArrayNormalized, or CurrentVertexAttrib.
        /// </param>
        /// <param name="@params">[length: 4] 
        /// Returns the requested data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribfv")]
        public static extern unsafe void GetVertexAttrib(UInt32 index, VertexAttribParameter pname, [OutAttribute] Single* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are VertexAttribArrayBufferBinding, VertexAttribArrayEnabled, VertexAttribArraySize, VertexAttribArrayStride, VertexAttribArrayType, VertexAttribArrayNormalized, or CurrentVertexAttrib.
        /// </param>
        /// <param name="@params">[length: 4] 
        /// Returns the requested data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribiv")]
        public static extern void GetVertexAttrib(Int32 index, All pname, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are VertexAttribArrayBufferBinding, VertexAttribArrayEnabled, VertexAttribArraySize, VertexAttribArrayStride, VertexAttribArrayType, VertexAttribArrayNormalized, or CurrentVertexAttrib.
        /// </param>
        /// <param name="@params">[length: 4] 
        /// Returns the requested data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribiv")]
        public static extern void GetVertexAttrib(Int32 index, All pname, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are VertexAttribArrayBufferBinding, VertexAttribArrayEnabled, VertexAttribArraySize, VertexAttribArrayStride, VertexAttribArrayType, VertexAttribArrayNormalized, or CurrentVertexAttrib.
        /// </param>
        /// <param name="@params">[length: 4] 
        /// Returns the requested data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribiv")]
        public static extern unsafe void GetVertexAttrib(Int32 index, All pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are VertexAttribArrayBufferBinding, VertexAttribArrayEnabled, VertexAttribArraySize, VertexAttribArrayStride, VertexAttribArrayType, VertexAttribArrayNormalized, or CurrentVertexAttrib.
        /// </param>
        /// <param name="@params">[length: 4] 
        /// Returns the requested data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribiv")]
        public static extern void GetVertexAttrib(Int32 index, VertexAttribParameter pname, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are VertexAttribArrayBufferBinding, VertexAttribArrayEnabled, VertexAttribArraySize, VertexAttribArrayStride, VertexAttribArrayType, VertexAttribArrayNormalized, or CurrentVertexAttrib.
        /// </param>
        /// <param name="@params">[length: 4] 
        /// Returns the requested data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribiv")]
        public static extern void GetVertexAttrib(Int32 index, VertexAttribParameter pname, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are VertexAttribArrayBufferBinding, VertexAttribArrayEnabled, VertexAttribArraySize, VertexAttribArrayStride, VertexAttribArrayType, VertexAttribArrayNormalized, or CurrentVertexAttrib.
        /// </param>
        /// <param name="@params">[length: 4] 
        /// Returns the requested data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribiv")]
        public static extern unsafe void GetVertexAttrib(Int32 index, VertexAttribParameter pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are VertexAttribArrayBufferBinding, VertexAttribArrayEnabled, VertexAttribArraySize, VertexAttribArrayStride, VertexAttribArrayType, VertexAttribArrayNormalized, or CurrentVertexAttrib.
        /// </param>
        /// <param name="@params">[length: 4] 
        /// Returns the requested data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribiv")]
        public static extern void GetVertexAttrib(UInt32 index, All pname, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are VertexAttribArrayBufferBinding, VertexAttribArrayEnabled, VertexAttribArraySize, VertexAttribArrayStride, VertexAttribArrayType, VertexAttribArrayNormalized, or CurrentVertexAttrib.
        /// </param>
        /// <param name="@params">[length: 4] 
        /// Returns the requested data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribiv")]
        public static extern void GetVertexAttrib(UInt32 index, All pname, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are VertexAttribArrayBufferBinding, VertexAttribArrayEnabled, VertexAttribArraySize, VertexAttribArrayStride, VertexAttribArrayType, VertexAttribArrayNormalized, or CurrentVertexAttrib.
        /// </param>
        /// <param name="@params">[length: 4] 
        /// Returns the requested data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribiv")]
        public static extern unsafe void GetVertexAttrib(UInt32 index, All pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are VertexAttribArrayBufferBinding, VertexAttribArrayEnabled, VertexAttribArraySize, VertexAttribArrayStride, VertexAttribArrayType, VertexAttribArrayNormalized, or CurrentVertexAttrib.
        /// </param>
        /// <param name="@params">[length: 4] 
        /// Returns the requested data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribiv")]
        public static extern void GetVertexAttrib(UInt32 index, VertexAttribParameter pname, [OutAttribute] Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are VertexAttribArrayBufferBinding, VertexAttribArrayEnabled, VertexAttribArraySize, VertexAttribArrayStride, VertexAttribArrayType, VertexAttribArrayNormalized, or CurrentVertexAttrib.
        /// </param>
        /// <param name="@params">[length: 4] 
        /// Returns the requested data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribiv")]
        public static extern void GetVertexAttrib(UInt32 index, VertexAttribParameter pname, [OutAttribute] out Int32 @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are VertexAttribArrayBufferBinding, VertexAttribArrayEnabled, VertexAttribArraySize, VertexAttribArrayStride, VertexAttribArrayType, VertexAttribArrayNormalized, or CurrentVertexAttrib.
        /// </param>
        /// <param name="@params">[length: 4] 
        /// Returns the requested data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribiv")]
        public static extern unsafe void GetVertexAttrib(UInt32 index, VertexAttribParameter pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the address of the specified generic vertex attribute pointer
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be returned.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the generic vertex attribute parameter to be returned. Must be VertexAttribArrayPointer.
        /// </param>
        /// <param name="pointer">[length: 1] 
        /// Returns the pointer value.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribPointerv")]
        public static extern void GetVertexAttribPointer(Int32 index, All pname, [OutAttribute] IntPtr pointer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the address of the specified generic vertex attribute pointer
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be returned.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the generic vertex attribute parameter to be returned. Must be VertexAttribArrayPointer.
        /// </param>
        /// <param name="pointer">[length: 1] 
        /// Returns the pointer value.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribPointerv")]
        public static extern void GetVertexAttribPointer(Int32 index, VertexAttribPointerParameter pname, [OutAttribute] IntPtr pointer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the address of the specified generic vertex attribute pointer
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be returned.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the generic vertex attribute parameter to be returned. Must be VertexAttribArrayPointer.
        /// </param>
        /// <param name="pointer">[length: 1] 
        /// Returns the pointer value.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribPointerv")]
        public static extern void GetVertexAttribPointer(UInt32 index, All pname, [OutAttribute] IntPtr pointer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Return the address of the specified generic vertex attribute pointer
        /// </summary>
        /// <param name="index"> 
        /// Specifies the generic vertex attribute parameter to be returned.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the generic vertex attribute parameter to be returned. Must be VertexAttribArrayPointer.
        /// </param>
        /// <param name="pointer">[length: 1] 
        /// Returns the pointer value.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glGetVertexAttribPointerv")]
        public static extern void GetVertexAttribPointer(UInt32 index, VertexAttribPointerParameter pname, [OutAttribute] IntPtr pointer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify implementation-specific hints
        /// </summary>
        /// <param name="target"> 
        /// Specifies a symbolic constant indicating the behavior to be controlled. GenerateMipmapHint is accepted.
        /// </param>
        /// <param name="mode"> 
        /// Specifies a symbolic constant indicating the desired behavior. Fastest, Nicest, and DontCare are accepted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glHint")]
        public static extern void Hint(All target, All mode);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify implementation-specific hints
        /// </summary>
        /// <param name="target"> 
        /// Specifies a symbolic constant indicating the behavior to be controlled. GenerateMipmapHint is accepted.
        /// </param>
        /// <param name="mode"> 
        /// Specifies a symbolic constant indicating the desired behavior. Fastest, Nicest, and DontCare are accepted.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glHint")]
        public static extern void Hint(HintTarget target, HintMode mode);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Determine if a name corresponds to a buffer object
        /// </summary>
        /// <param name="buffer"> 
        /// Specifies a value that may be the name of a buffer object.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glIsBuffer")]
        public static extern bool IsBuffer(Int32 buffer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Determine if a name corresponds to a buffer object
        /// </summary>
        /// <param name="buffer"> 
        /// Specifies a value that may be the name of a buffer object.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glIsBuffer")]
        public static extern bool IsBuffer(UInt32 buffer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Test whether a capability is enabled
        /// </summary>
        /// <param name="cap"> 
        /// Specifies a symbolic constant indicating a GL capability.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glIsEnabled")]
        public static extern bool IsEnabled(All cap);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Test whether a capability is enabled
        /// </summary>
        /// <param name="cap"> 
        /// Specifies a symbolic constant indicating a GL capability.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glIsEnabled")]
        public static extern bool IsEnabled(EnableCap cap);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Determine if a name corresponds to a framebuffer object
        /// </summary>
        /// <param name="framebuffer"> 
        /// Specifies a value that may be the name of a framebuffer object.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glIsFramebuffer")]
        public static extern bool IsFramebuffer(Int32 framebuffer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Determine if a name corresponds to a framebuffer object
        /// </summary>
        /// <param name="framebuffer"> 
        /// Specifies a value that may be the name of a framebuffer object.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glIsFramebuffer")]
        public static extern bool IsFramebuffer(UInt32 framebuffer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Determine if a name corresponds to a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies a potential program object.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glIsProgram")]
        public static extern bool IsProgram(Int32 program);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Determine if a name corresponds to a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies a potential program object.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glIsProgram")]
        public static extern bool IsProgram(UInt32 program);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Determine if a name corresponds to a renderbuffer object
        /// </summary>
        /// <param name="renderbuffer"> 
        /// Specifies a value that may be the name of a renderbuffer object.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glIsRenderbuffer")]
        public static extern bool IsRenderbuffer(Int32 renderbuffer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Determine if a name corresponds to a renderbuffer object
        /// </summary>
        /// <param name="renderbuffer"> 
        /// Specifies a value that may be the name of a renderbuffer object.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glIsRenderbuffer")]
        public static extern bool IsRenderbuffer(UInt32 renderbuffer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Determine if a name corresponds to a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies a potential shader object.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glIsShader")]
        public static extern bool IsShader(Int32 shader);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Determine if a name corresponds to a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies a potential shader object.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glIsShader")]
        public static extern bool IsShader(UInt32 shader);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Determine if a name corresponds to a texture
        /// </summary>
        /// <param name="texture"> 
        /// Specifies a value that may be the name of a texture.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glIsTexture")]
        public static extern bool IsTexture(Int32 texture);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Determine if a name corresponds to a texture
        /// </summary>
        /// <param name="texture"> 
        /// Specifies a value that may be the name of a texture.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glIsTexture")]
        public static extern bool IsTexture(UInt32 texture);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the width of rasterized lines
        /// </summary>
        /// <param name="width"> 
        /// Specifies the width of rasterized lines. The initial value is 1.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glLineWidth")]
        public static extern void LineWidth(Single width);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Link a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the handle of the program object to be linked.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glLinkProgram")]
        public static extern void LinkProgram(Int32 program);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Link a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the handle of the program object to be linked.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glLinkProgram")]
        public static extern void LinkProgram(UInt32 program);


        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set pixel storage modes
        /// </summary>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the parameter to be set. One value affects the packing of pixel data into memory: PackAlignment. The other affects the unpacking of pixel data from memory: UnpackAlignment.
        /// </param>
        /// <param name="param"> 
        /// Specifies the value that pname is set to.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glPixelStorei")]
        public static extern void PixelStore(All pname, Int32 param);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set pixel storage modes
        /// </summary>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the parameter to be set. One value affects the packing of pixel data into memory: PackAlignment. The other affects the unpacking of pixel data from memory: UnpackAlignment.
        /// </param>
        /// <param name="param"> 
        /// Specifies the value that pname is set to.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glPixelStorei")]
        public static extern void PixelStore(PixelStoreParameter pname, Int32 param);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set the scale and units used to calculate depth values
        /// </summary>
        /// <param name="factor"> 
        /// Specifies a scale factor that is used to create a variable depth offset for each polygon. The initial value is 0.
        /// </param>
        /// <param name="units"> 
        /// Is multiplied by an implementation-specific value to create a constant depth offset. The initial value is 0.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glPolygonOffset")]
        public static extern void PolygonOffset(Single factor, Single units);




        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x"> 
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </param>
        /// <param name="y"> 
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </param>
        /// <param name="width"> 
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </param>
        /// <param name="height"> 
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, and Rgba.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. Must be one of UnsignedByte, UnsignedShort565, UnsignedShort4444, or UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Returns the pixel data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glReadPixels")]
        public static extern void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, All format, All type, [OutAttribute] IntPtr pixels);

       /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x"> 
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </param>
        /// <param name="y"> 
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </param>
        /// <param name="width"> 
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </param>
        /// <param name="height"> 
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, and Rgba.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. Must be one of UnsignedByte, UnsignedShort565, UnsignedShort4444, or UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Returns the pixel data.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glReadPixels")]
        public static extern void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, PixelFormat format, PixelType type, [OutAttribute] IntPtr pixels);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Release resources allocated by the shader compiler
        /// </summary>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glReleaseShaderCompiler")]
        public static extern void ReleaseShaderCompiler();

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Create and initialize a renderbuffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the renderbuffer target.  The symbolic constant must be Renderbuffer.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the color-renderable, depth-renderable, or stencil-renderable format of the renderbuffer. Must be one of the following symbolic constants: Rgba4, Rgb565, Rgb5A1, DepthComponent16, or StencilIndex8.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the renderbuffer in pixels.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the renderbuffer in pixels.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glRenderbufferStorage")]
        public static extern void RenderbufferStorage(All target, All internalformat, Int32 width, Int32 height);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Create and initialize a renderbuffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the renderbuffer target.  The symbolic constant must be Renderbuffer.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the color-renderable, depth-renderable, or stencil-renderable format of the renderbuffer. Must be one of the following symbolic constants: Rgba4, Rgb565, Rgb5A1, DepthComponent16, or StencilIndex8.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the renderbuffer in pixels.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the renderbuffer in pixels.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glRenderbufferStorage")]
        public static extern void RenderbufferStorage(RenderbufferTarget target, RenderbufferInternalFormat internalformat, Int32 width, Int32 height);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify multisample coverage parameters
        /// </summary>
        /// <param name="value"> 
        /// Specify a single floating-point sample coverage value.  The value is clamped to the range [0 ,1]. The initial value is 1.0.
        /// </param>
        /// <param name="invert"> 
        /// Specify a single boolean value representing if the coverage masks should be inverted.  True and False are accepted.  The initial value is False.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glSampleCoverage")]
        public static extern void SampleCoverage(Single value, bool invert);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Define the scissor box
        /// </summary>
        /// <param name="x"> 
        /// Specify the lower left corner of the scissor box. Initially (0, 0).
        /// </param>
        /// <param name="y"> 
        /// Specify the lower left corner of the scissor box. Initially (0, 0).
        /// </param>
        /// <param name="width"> 
        /// Specify the width and height of the scissor box. When a GL context is first attached to a window, width and height are set to the dimensions of that window.
        /// </param>
        /// <param name="height"> 
        /// Specify the width and height of the scissor box. When a GL context is first attached to a window, width and height are set to the dimensions of that window.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glScissor")]
        public static extern void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Load a precompiled shader binary
        /// </summary>
        /// <param name="count"> 
        /// Specifies the number of shader object handles present in shaders.
        /// </param>
        /// <param name="shaders">[length: count] 
        /// Specifies a pointer to an array of shader object handles into which the shader binary will be loaded.
        /// </param>
        /// <param name="binaryformat"> 
        /// Specifies the shader binary format.
        /// </param>
        /// <param name="binary">[length: length] 
        /// Specifies a pointer to the shader binary data in client memory.
        /// </param>
        /// <param name="length"> 
        /// Specifies the length of the shader binary data in bytes.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glShaderBinary")]
        public static extern void ShaderBinary(Int32 count, Int32[] shaders, All binaryformat, IntPtr binary, Int32 length);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Load a precompiled shader binary
        /// </summary>
        /// <param name="count"> 
        /// Specifies the number of shader object handles present in shaders.
        /// </param>
        /// <param name="shaders">[length: count] 
        /// Specifies a pointer to an array of shader object handles into which the shader binary will be loaded.
        /// </param>
        /// <param name="binaryformat"> 
        /// Specifies the shader binary format.
        /// </param>
        /// <param name="binary">[length: length] 
        /// Specifies a pointer to the shader binary data in client memory.
        /// </param>
        /// <param name="length"> 
        /// Specifies the length of the shader binary data in bytes.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glShaderBinary")]
        public static extern void ShaderBinary(Int32 count, Int32[] shaders, ShaderBinaryFormat binaryformat, IntPtr binary, Int32 length);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Load a precompiled shader binary
        /// </summary>
        /// <param name="count"> 
        /// Specifies the number of shader object handles present in shaders.
        /// </param>
        /// <param name="shaders">[length: count] 
        /// Specifies a pointer to an array of shader object handles into which the shader binary will be loaded.
        /// </param>
        /// <param name="binaryformat"> 
        /// Specifies the shader binary format.
        /// </param>
        /// <param name="binary">[length: length] 
        /// Specifies a pointer to the shader binary data in client memory.
        /// </param>
        /// <param name="length"> 
        /// Specifies the length of the shader binary data in bytes.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glShaderBinary")]
        public static extern void ShaderBinary(Int32 count, ref Int32 shaders, All binaryformat, IntPtr binary, Int32 length);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Load a precompiled shader binary
        /// </summary>
        /// <param name="count"> 
        /// Specifies the number of shader object handles present in shaders.
        /// </param>
        /// <param name="shaders">[length: count] 
        /// Specifies a pointer to an array of shader object handles into which the shader binary will be loaded.
        /// </param>
        /// <param name="binaryformat"> 
        /// Specifies the shader binary format.
        /// </param>
        /// <param name="binary">[length: length] 
        /// Specifies a pointer to the shader binary data in client memory.
        /// </param>
        /// <param name="length"> 
        /// Specifies the length of the shader binary data in bytes.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glShaderBinary")]
        public static extern void ShaderBinary(Int32 count, ref Int32 shaders, ShaderBinaryFormat binaryformat, IntPtr binary, Int32 length);

         /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Load a precompiled shader binary
        /// </summary>
        /// <param name="count"> 
        /// Specifies the number of shader object handles present in shaders.
        /// </param>
        /// <param name="shaders">[length: count] 
        /// Specifies a pointer to an array of shader object handles into which the shader binary will be loaded.
        /// </param>
        /// <param name="binaryformat"> 
        /// Specifies the shader binary format.
        /// </param>
        /// <param name="binary">[length: length] 
        /// Specifies a pointer to the shader binary data in client memory.
        /// </param>
        /// <param name="length"> 
        /// Specifies the length of the shader binary data in bytes.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glShaderBinary")]
        public static extern unsafe void ShaderBinary(Int32 count, Int32* shaders, All binaryformat, IntPtr binary, Int32 length);

     
        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Load a precompiled shader binary
        /// </summary>
        /// <param name="count"> 
        /// Specifies the number of shader object handles present in shaders.
        /// </param>
        /// <param name="shaders">[length: count] 
        /// Specifies a pointer to an array of shader object handles into which the shader binary will be loaded.
        /// </param>
        /// <param name="binaryformat"> 
        /// Specifies the shader binary format.
        /// </param>
        /// <param name="binary">[length: length] 
        /// Specifies a pointer to the shader binary data in client memory.
        /// </param>
        /// <param name="length"> 
        /// Specifies the length of the shader binary data in bytes.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glShaderBinary")]
        public static extern unsafe void ShaderBinary(Int32 count, Int32* shaders, ShaderBinaryFormat binaryformat, IntPtr binary, Int32 length);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Load a precompiled shader binary
        /// </summary>
        /// <param name="count"> 
        /// Specifies the number of shader object handles present in shaders.
        /// </param>
        /// <param name="shaders">[length: count] 
        /// Specifies a pointer to an array of shader object handles into which the shader binary will be loaded.
        /// </param>
        /// <param name="binaryformat"> 
        /// Specifies the shader binary format.
        /// </param>
        /// <param name="binary">[length: length] 
        /// Specifies a pointer to the shader binary data in client memory.
        /// </param>
        /// <param name="length"> 
        /// Specifies the length of the shader binary data in bytes.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glShaderBinary")]
        public static extern void ShaderBinary(Int32 count, UInt32[] shaders, All binaryformat, IntPtr binary, Int32 length);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Load a precompiled shader binary
        /// </summary>
        /// <param name="count"> 
        /// Specifies the number of shader object handles present in shaders.
        /// </param>
        /// <param name="shaders">[length: count] 
        /// Specifies a pointer to an array of shader object handles into which the shader binary will be loaded.
        /// </param>
        /// <param name="binaryformat"> 
        /// Specifies the shader binary format.
        /// </param>
        /// <param name="binary">[length: length] 
        /// Specifies a pointer to the shader binary data in client memory.
        /// </param>
        /// <param name="length"> 
        /// Specifies the length of the shader binary data in bytes.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glShaderBinary")]
        public static extern void ShaderBinary(Int32 count, UInt32[] shaders, ShaderBinaryFormat binaryformat, IntPtr binary, Int32 length);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Load a precompiled shader binary
        /// </summary>
        /// <param name="count"> 
        /// Specifies the number of shader object handles present in shaders.
        /// </param>
        /// <param name="shaders">[length: count] 
        /// Specifies a pointer to an array of shader object handles into which the shader binary will be loaded.
        /// </param>
        /// <param name="binaryformat"> 
        /// Specifies the shader binary format.
        /// </param>
        /// <param name="binary">[length: length] 
        /// Specifies a pointer to the shader binary data in client memory.
        /// </param>
        /// <param name="length"> 
        /// Specifies the length of the shader binary data in bytes.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glShaderBinary")]
        public static extern void ShaderBinary(Int32 count, ref UInt32 shaders, All binaryformat, IntPtr binary, Int32 length);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Load a precompiled shader binary
        /// </summary>
        /// <param name="count"> 
        /// Specifies the number of shader object handles present in shaders.
        /// </param>
        /// <param name="shaders">[length: count] 
        /// Specifies a pointer to an array of shader object handles into which the shader binary will be loaded.
        /// </param>
        /// <param name="binaryformat"> 
        /// Specifies the shader binary format.
        /// </param>
        /// <param name="binary">[length: length] 
        /// Specifies a pointer to the shader binary data in client memory.
        /// </param>
        /// <param name="length"> 
        /// Specifies the length of the shader binary data in bytes.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glShaderBinary")]
        public static extern void ShaderBinary(Int32 count, ref UInt32 shaders, ShaderBinaryFormat binaryformat, IntPtr binary, Int32 length);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Load a precompiled shader binary
        /// </summary>
        /// <param name="count"> 
        /// Specifies the number of shader object handles present in shaders.
        /// </param>
        /// <param name="shaders">[length: count] 
        /// Specifies a pointer to an array of shader object handles into which the shader binary will be loaded.
        /// </param>
        /// <param name="binaryformat"> 
        /// Specifies the shader binary format.
        /// </param>
        /// <param name="binary">[length: length] 
        /// Specifies a pointer to the shader binary data in client memory.
        /// </param>
        /// <param name="length"> 
        /// Specifies the length of the shader binary data in bytes.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glShaderBinary")]
        public static extern unsafe void ShaderBinary(Int32 count, UInt32* shaders, All binaryformat, IntPtr binary, Int32 length);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Load a precompiled shader binary
        /// </summary>
        /// <param name="count"> 
        /// Specifies the number of shader object handles present in shaders.
        /// </param>
        /// <param name="shaders">[length: count] 
        /// Specifies a pointer to an array of shader object handles into which the shader binary will be loaded.
        /// </param>
        /// <param name="binaryformat"> 
        /// Specifies the shader binary format.
        /// </param>
        /// <param name="binary">[length: length] 
        /// Specifies a pointer to the shader binary data in client memory.
        /// </param>
        /// <param name="length"> 
        /// Specifies the length of the shader binary data in bytes.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glShaderBinary")]
        public static extern unsafe void ShaderBinary(Int32 count, UInt32* shaders, ShaderBinaryFormat binaryformat, IntPtr binary, Int32 length);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Replace the source code in a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the handle of the shader object whose source code is to be replaced.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements in the string and length arrays.
        /// </param>
        /// <param name="@string">[length: count] 
        /// Specifies an array of pointers to strings containing the source code to be loaded into the shader.
        /// </param>
        /// <param name="length">[length: count] 
        /// Specifies an array of string lengths.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glShaderSource")]
        public static extern void ShaderSource(Int32 shader, Int32 count, String[] @string, Int32[] length);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Replace the source code in a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the handle of the shader object whose source code is to be replaced.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements in the string and length arrays.
        /// </param>
        /// <param name="@string">[length: count] 
        /// Specifies an array of pointers to strings containing the source code to be loaded into the shader.
        /// </param>
        /// <param name="length">[length: count] 
        /// Specifies an array of string lengths.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glShaderSource")]
        public static extern void ShaderSource(Int32 shader, Int32 count, String[] @string, ref Int32 length);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Replace the source code in a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the handle of the shader object whose source code is to be replaced.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements in the string and length arrays.
        /// </param>
        /// <param name="@string">[length: count] 
        /// Specifies an array of pointers to strings containing the source code to be loaded into the shader.
        /// </param>
        /// <param name="length">[length: count] 
        /// Specifies an array of string lengths.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glShaderSource")]
        public static extern unsafe void ShaderSource(Int32 shader, Int32 count, String[] @string, Int32* length);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Replace the source code in a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the handle of the shader object whose source code is to be replaced.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements in the string and length arrays.
        /// </param>
        /// <param name="@string">[length: count] 
        /// Specifies an array of pointers to strings containing the source code to be loaded into the shader.
        /// </param>
        /// <param name="length">[length: count] 
        /// Specifies an array of string lengths.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glShaderSource")]
        public static extern void ShaderSource(UInt32 shader, Int32 count, String[] @string, Int32[] length);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Replace the source code in a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the handle of the shader object whose source code is to be replaced.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements in the string and length arrays.
        /// </param>
        /// <param name="@string">[length: count] 
        /// Specifies an array of pointers to strings containing the source code to be loaded into the shader.
        /// </param>
        /// <param name="length">[length: count] 
        /// Specifies an array of string lengths.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glShaderSource")]
        public static extern void ShaderSource(UInt32 shader, Int32 count, String[] @string, ref Int32 length);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Replace the source code in a shader object
        /// </summary>
        /// <param name="shader"> 
        /// Specifies the handle of the shader object whose source code is to be replaced.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements in the string and length arrays.
        /// </param>
        /// <param name="@string">[length: count] 
        /// Specifies an array of pointers to strings containing the source code to be loaded into the shader.
        /// </param>
        /// <param name="length">[length: count] 
        /// Specifies an array of string lengths.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glShaderSource")]
        public static extern unsafe void ShaderSource(UInt32 shader, Int32 count, String[] @string, Int32* length);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set front and back function and reference value for stencil testing
        /// </summary>
        /// <param name="func"> 
        /// Specifies the test function. Eight symbolic constants are valid: Never, Less, Lequal, Greater, Gequal, Equal, Notequal, and Always. The initial value is Always.
        /// </param>
        /// <param name="@ref"> 
        /// Specifies the reference value for the stencil test. ref is clamped to the range [0, 2 sup n - 1], where  is the number of bitplanes in the stencil buffer. The initial value is 0.
        /// </param>
        /// <param name="mask"> 
        /// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glStencilFunc")]
        public static extern void StencilFunc(All func, Int32 @ref, Int32 mask);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set front and back function and reference value for stencil testing
        /// </summary>
        /// <param name="func"> 
        /// Specifies the test function. Eight symbolic constants are valid: Never, Less, Lequal, Greater, Gequal, Equal, Notequal, and Always. The initial value is Always.
        /// </param>
        /// <param name="@ref"> 
        /// Specifies the reference value for the stencil test. ref is clamped to the range [0, 2 sup n - 1], where  is the number of bitplanes in the stencil buffer. The initial value is 0.
        /// </param>
        /// <param name="mask"> 
        /// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glStencilFunc")]
        public static extern void StencilFunc(All func, Int32 @ref, UInt32 mask);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set front and back function and reference value for stencil testing
        /// </summary>
        /// <param name="func"> 
        /// Specifies the test function. Eight symbolic constants are valid: Never, Less, Lequal, Greater, Gequal, Equal, Notequal, and Always. The initial value is Always.
        /// </param>
        /// <param name="@ref"> 
        /// Specifies the reference value for the stencil test. ref is clamped to the range [0, 2 sup n - 1], where  is the number of bitplanes in the stencil buffer. The initial value is 0.
        /// </param>
        /// <param name="mask"> 
        /// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glStencilFunc")]
        public static extern void StencilFunc(StencilFunction func, Int32 @ref, Int32 mask);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set front and back function and reference value for stencil testing
        /// </summary>
        /// <param name="func"> 
        /// Specifies the test function. Eight symbolic constants are valid: Never, Less, Lequal, Greater, Gequal, Equal, Notequal, and Always. The initial value is Always.
        /// </param>
        /// <param name="@ref"> 
        /// Specifies the reference value for the stencil test. ref is clamped to the range [0, 2 sup n - 1], where  is the number of bitplanes in the stencil buffer. The initial value is 0.
        /// </param>
        /// <param name="mask"> 
        /// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glStencilFunc")]
        public static extern void StencilFunc(StencilFunction func, Int32 @ref, UInt32 mask);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set front and/or back function and reference value for stencil testing
        /// </summary>
        /// <param name="face"> 
        /// Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: Front, Back, and FrontAndBack.
        /// </param>
        /// <param name="func"> 
        /// Specifies the test function. Eight symbolic constants are valid: Never, Less, Lequal, Greater, Gequal, Equal, Notequal, and Always. The initial value is Always.
        /// </param>
        /// <param name="@ref"> 
        /// Specifies the reference value for the stencil test. ref is clamped to the range [0, 2 sup n - 1], where  is the number of bitplanes in the stencil buffer. The initial value is 0.
        /// </param>
        /// <param name="mask"> 
        /// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glStencilFuncSeparate")]
        public static extern void StencilFuncSeparate(All face, All func, Int32 @ref, Int32 mask);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set front and/or back function and reference value for stencil testing
        /// </summary>
        /// <param name="face"> 
        /// Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: Front, Back, and FrontAndBack.
        /// </param>
        /// <param name="func"> 
        /// Specifies the test function. Eight symbolic constants are valid: Never, Less, Lequal, Greater, Gequal, Equal, Notequal, and Always. The initial value is Always.
        /// </param>
        /// <param name="@ref"> 
        /// Specifies the reference value for the stencil test. ref is clamped to the range [0, 2 sup n - 1], where  is the number of bitplanes in the stencil buffer. The initial value is 0.
        /// </param>
        /// <param name="mask"> 
        /// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glStencilFuncSeparate")]
        public static extern void StencilFuncSeparate(All face, All func, Int32 @ref, UInt32 mask);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set front and/or back function and reference value for stencil testing
        /// </summary>
        /// <param name="face"> 
        /// Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: Front, Back, and FrontAndBack.
        /// </param>
        /// <param name="func"> 
        /// Specifies the test function. Eight symbolic constants are valid: Never, Less, Lequal, Greater, Gequal, Equal, Notequal, and Always. The initial value is Always.
        /// </param>
        /// <param name="@ref"> 
        /// Specifies the reference value for the stencil test. ref is clamped to the range [0, 2 sup n - 1], where  is the number of bitplanes in the stencil buffer. The initial value is 0.
        /// </param>
        /// <param name="mask"> 
        /// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glStencilFuncSeparate")]
        public static extern void StencilFuncSeparate(CullFaceMode face, StencilFunction func, Int32 @ref, Int32 mask);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set front and/or back function and reference value for stencil testing
        /// </summary>
        /// <param name="face"> 
        /// Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: Front, Back, and FrontAndBack.
        /// </param>
        /// <param name="func"> 
        /// Specifies the test function. Eight symbolic constants are valid: Never, Less, Lequal, Greater, Gequal, Equal, Notequal, and Always. The initial value is Always.
        /// </param>
        /// <param name="@ref"> 
        /// Specifies the reference value for the stencil test. ref is clamped to the range [0, 2 sup n - 1], where  is the number of bitplanes in the stencil buffer. The initial value is 0.
        /// </param>
        /// <param name="mask"> 
        /// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glStencilFuncSeparate")]
        public static extern void StencilFuncSeparate(CullFaceMode face, StencilFunction func, Int32 @ref, UInt32 mask);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set front and/or back function and reference value for stencil testing
        /// </summary>
        /// <param name="face"> 
        /// Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: Front, Back, and FrontAndBack.
        /// </param>
        /// <param name="func"> 
        /// Specifies the test function. Eight symbolic constants are valid: Never, Less, Lequal, Greater, Gequal, Equal, Notequal, and Always. The initial value is Always.
        /// </param>
        /// <param name="@ref"> 
        /// Specifies the reference value for the stencil test. ref is clamped to the range [0, 2 sup n - 1], where  is the number of bitplanes in the stencil buffer. The initial value is 0.
        /// </param>
        /// <param name="mask"> 
        /// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glStencilFuncSeparate")]
        public static extern void StencilFuncSeparate(StencilFace face, StencilFunction func, Int32 @ref, Int32 mask);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set front and/or back function and reference value for stencil testing
        /// </summary>
        /// <param name="face"> 
        /// Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: Front, Back, and FrontAndBack.
        /// </param>
        /// <param name="func"> 
        /// Specifies the test function. Eight symbolic constants are valid: Never, Less, Lequal, Greater, Gequal, Equal, Notequal, and Always. The initial value is Always.
        /// </param>
        /// <param name="@ref"> 
        /// Specifies the reference value for the stencil test. ref is clamped to the range [0, 2 sup n - 1], where  is the number of bitplanes in the stencil buffer. The initial value is 0.
        /// </param>
        /// <param name="mask"> 
        /// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glStencilFuncSeparate")]
        public static extern void StencilFuncSeparate(StencilFace face, StencilFunction func, Int32 @ref, UInt32 mask);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Control the front and back writing of individual bits in the stencil planes
        /// </summary>
        /// <param name="mask"> 
        /// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1's.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glStencilMask")]
        public static extern void StencilMask(Int32 mask);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Control the front and back writing of individual bits in the stencil planes
        /// </summary>
        /// <param name="mask"> 
        /// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1's.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glStencilMask")]
        public static extern void StencilMask(UInt32 mask);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Control the front and/or back writing of individual bits in the stencil planes
        /// </summary>
        /// <param name="face"> 
        /// Specifies whether the front and/or back stencil writemask is updated. Three symbolic constants are valid: Front, Back, and FrontAndBack.
        /// </param>
        /// <param name="mask"> 
        /// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1's.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glStencilMaskSeparate")]
        public static extern void StencilMaskSeparate(All face, Int32 mask);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Control the front and/or back writing of individual bits in the stencil planes
        /// </summary>
        /// <param name="face"> 
        /// Specifies whether the front and/or back stencil writemask is updated. Three symbolic constants are valid: Front, Back, and FrontAndBack.
        /// </param>
        /// <param name="mask"> 
        /// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1's.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glStencilMaskSeparate")]
        public static extern void StencilMaskSeparate(All face, UInt32 mask);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Control the front and/or back writing of individual bits in the stencil planes
        /// </summary>
        /// <param name="face"> 
        /// Specifies whether the front and/or back stencil writemask is updated. Three symbolic constants are valid: Front, Back, and FrontAndBack.
        /// </param>
        /// <param name="mask"> 
        /// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1's.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glStencilMaskSeparate")]
        public static extern void StencilMaskSeparate(CullFaceMode face, Int32 mask);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Control the front and/or back writing of individual bits in the stencil planes
        /// </summary>
        /// <param name="face"> 
        /// Specifies whether the front and/or back stencil writemask is updated. Three symbolic constants are valid: Front, Back, and FrontAndBack.
        /// </param>
        /// <param name="mask"> 
        /// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1's.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glStencilMaskSeparate")]
        public static extern void StencilMaskSeparate(CullFaceMode face, UInt32 mask);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Control the front and/or back writing of individual bits in the stencil planes
        /// </summary>
        /// <param name="face"> 
        /// Specifies whether the front and/or back stencil writemask is updated. Three symbolic constants are valid: Front, Back, and FrontAndBack.
        /// </param>
        /// <param name="mask"> 
        /// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1's.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glStencilMaskSeparate")]
        public static extern void StencilMaskSeparate(StencilFace face, Int32 mask);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Control the front and/or back writing of individual bits in the stencil planes
        /// </summary>
        /// <param name="face"> 
        /// Specifies whether the front and/or back stencil writemask is updated. Three symbolic constants are valid: Front, Back, and FrontAndBack.
        /// </param>
        /// <param name="mask"> 
        /// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1's.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glStencilMaskSeparate")]
        public static extern void StencilMaskSeparate(StencilFace face, UInt32 mask);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set front and back stencil test actions
        /// </summary>
        /// <param name="fail"> 
        /// Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: Keep, Zero, Replace, Incr, IncrWrap, Decr, DecrWrap, and Invert. The initial value is Keep.
        /// </param>
        /// <param name="zfail"> 
        /// Specifies the stencil action when the stencil test passes, but the depth test fails. dpfail accepts the same symbolic constants as sfail. The initial value is Keep.
        /// </param>
        /// <param name="zpass"> 
        /// Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and either there is no depth buffer or depth testing is not enabled. dppass accepts the same symbolic constants as sfail. The initial value is Keep.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glStencilOp")]
        public static extern void StencilOp(All fail, All zfail, All zpass);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set front and back stencil test actions
        /// </summary>
        /// <param name="fail"> 
        /// Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: Keep, Zero, Replace, Incr, IncrWrap, Decr, DecrWrap, and Invert. The initial value is Keep.
        /// </param>
        /// <param name="zfail"> 
        /// Specifies the stencil action when the stencil test passes, but the depth test fails. dpfail accepts the same symbolic constants as sfail. The initial value is Keep.
        /// </param>
        /// <param name="zpass"> 
        /// Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and either there is no depth buffer or depth testing is not enabled. dppass accepts the same symbolic constants as sfail. The initial value is Keep.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glStencilOp")]
        public static extern void StencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set front and/or back stencil test actions
        /// </summary>
        /// <param name="face"> 
        /// Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: Front, Back, and FrontAndBack.
        /// </param>
        /// <param name="sfail"> 
        /// Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: Keep, Zero, Replace, Incr, IncrWrap, Decr, DecrWrap, and Invert. The initial value is Keep.
        /// </param>
        /// <param name="dpfail"> 
        /// Specifies the stencil action when the stencil test passes, but the depth test fails. dpfail accepts the same symbolic constants as sfail. The initial value is Keep.
        /// </param>
        /// <param name="dppass"> 
        /// Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and either there is no depth buffer or depth testing is not enabled. dppass accepts the same symbolic constants as sfail. The initial value is Keep.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glStencilOpSeparate")]
        public static extern void StencilOpSeparate(All face, All sfail, All dpfail, All dppass);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set front and/or back stencil test actions
        /// </summary>
        /// <param name="face"> 
        /// Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: Front, Back, and FrontAndBack.
        /// </param>
        /// <param name="sfail"> 
        /// Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: Keep, Zero, Replace, Incr, IncrWrap, Decr, DecrWrap, and Invert. The initial value is Keep.
        /// </param>
        /// <param name="dpfail"> 
        /// Specifies the stencil action when the stencil test passes, but the depth test fails. dpfail accepts the same symbolic constants as sfail. The initial value is Keep.
        /// </param>
        /// <param name="dppass"> 
        /// Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and either there is no depth buffer or depth testing is not enabled. dppass accepts the same symbolic constants as sfail. The initial value is Keep.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glStencilOpSeparate")]
        public static extern void StencilOpSeparate(CullFaceMode face, StencilOp sfail, StencilOp dpfail, StencilOp dppass);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set front and/or back stencil test actions
        /// </summary>
        /// <param name="face"> 
        /// Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: Front, Back, and FrontAndBack.
        /// </param>
        /// <param name="sfail"> 
        /// Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: Keep, Zero, Replace, Incr, IncrWrap, Decr, DecrWrap, and Invert. The initial value is Keep.
        /// </param>
        /// <param name="dpfail"> 
        /// Specifies the stencil action when the stencil test passes, but the depth test fails. dpfail accepts the same symbolic constants as sfail. The initial value is Keep.
        /// </param>
        /// <param name="dppass"> 
        /// Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and either there is no depth buffer or depth testing is not enabled. dppass accepts the same symbolic constants as sfail. The initial value is Keep.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glStencilOpSeparate")]
        public static extern void StencilOpSeparate(StencilFace face, StencilOp sfail, StencilOp dpfail, StencilOp dppass);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the internal format of the texture. Must be one of the following symbolic constants: Alpha, Luminance, LuminanceAlpha, Rgb, Rgba.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the texel data.  Must match internalformat. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the texel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glTexImage2D")]
        public static extern void TexImage2D(All target, Int32 level, All internalformat, Int32 width, Int32 height, Int32 border, All format, All type, IntPtr pixels);

          /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the internal format of the texture. Must be one of the following symbolic constants: Alpha, Luminance, LuminanceAlpha, Rgb, Rgba.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the texel data.  Must match internalformat. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the texel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glTexImage2D")]
        public static extern void TexImage2D(TextureTarget target, Int32 level, PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, PixelFormat format, PixelType type, IntPtr pixels);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the internal format of the texture. Must be one of the following symbolic constants: Alpha, Luminance, LuminanceAlpha, Rgb, Rgba.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the texel data.  Must match internalformat. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the texel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glTexImage2D")]
        public static extern void TexImage2D(TextureTarget2d target, Int32 level, TextureComponentCount internalformat, Int32 width, Int32 height, Int32 border, PixelFormat format, PixelType type, IntPtr pixels);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit, which must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: TextureMinFilter, TextureMagFilter, TextureWrapS, or TextureWrapT.
        /// </param>
        /// <param name="param"> 
        /// Specifies the value of pname.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glTexParameterf")]
        public static extern void TexParameter(All target, All pname, Single param);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit, which must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: TextureMinFilter, TextureMagFilter, TextureWrapS, or TextureWrapT.
        /// </param>
        /// <param name="param"> 
        /// Specifies the value of pname.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glTexParameterf")]
        public static extern void TexParameter(TextureTarget target, TextureParameterName pname, Single param);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit, which must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: TextureMinFilter, TextureMagFilter, TextureWrapS, or TextureWrapT.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Specifies the value of pname.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glTexParameterfv")]
        public static extern void TexParameter(All target, All pname, Single[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit, which must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: TextureMinFilter, TextureMagFilter, TextureWrapS, or TextureWrapT.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Specifies the value of pname.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glTexParameterfv")]
        public static extern unsafe void TexParameter(All target, All pname, Single* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit, which must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: TextureMinFilter, TextureMagFilter, TextureWrapS, or TextureWrapT.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Specifies the value of pname.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glTexParameterfv")]
        public static extern void TexParameter(TextureTarget target, TextureParameterName pname, Single[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit, which must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: TextureMinFilter, TextureMagFilter, TextureWrapS, or TextureWrapT.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Specifies the value of pname.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glTexParameterfv")]
        public static extern unsafe void TexParameter(TextureTarget target, TextureParameterName pname, Single* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit, which must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: TextureMinFilter, TextureMagFilter, TextureWrapS, or TextureWrapT.
        /// </param>
        /// <param name="param"> 
        /// Specifies the value of pname.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glTexParameteri")]
        public static extern void TexParameter(All target, All pname, Int32 param);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit, which must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: TextureMinFilter, TextureMagFilter, TextureWrapS, or TextureWrapT.
        /// </param>
        /// <param name="param"> 
        /// Specifies the value of pname.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glTexParameteri")]
        public static extern void TexParameter(TextureTarget target, TextureParameterName pname, Int32 param);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit, which must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: TextureMinFilter, TextureMagFilter, TextureWrapS, or TextureWrapT.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Specifies the value of pname.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glTexParameteriv")]
        public static extern void TexParameter(All target, All pname, Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit, which must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: TextureMinFilter, TextureMagFilter, TextureWrapS, or TextureWrapT.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Specifies the value of pname.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glTexParameteriv")]
        public static extern unsafe void TexParameter(All target, All pname, Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit, which must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: TextureMinFilter, TextureMagFilter, TextureWrapS, or TextureWrapT.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Specifies the value of pname.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glTexParameteriv")]
        public static extern void TexParameter(TextureTarget target, TextureParameterName pname, Int32[] @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit, which must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: TextureMinFilter, TextureMagFilter, TextureWrapS, or TextureWrapT.
        /// </param>
        /// <param name="@params">[length: pname] 
        /// Specifies the value of pname.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glTexParameteriv")]
        public static extern unsafe void TexParameter(TextureTarget target, TextureParameterName pname, Int32* @params);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glTexSubImage2D")]
        public static extern void TexSubImage2D(All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, All format, All type, IntPtr pixels);

   

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glTexSubImage2D")]
        public static extern void TexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glTexSubImage2D")]
        public static extern void TexSubImage2D(TextureTarget2d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="v0"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform1f")]
        public static extern void Uniform1(Int32 location, Single v0);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="value">[length: count*1] 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform1fv")]
        public static extern void Uniform1(Int32 location, Int32 count, Single[] value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="value">[length: count*1] 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform1fv")]
        public static extern void Uniform1(Int32 location, Int32 count, ref Single value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="value">[length: count*1] 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform1fv")]
        public static extern unsafe void Uniform1(Int32 location, Int32 count, Single* value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="v0"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform1i")]
        public static extern void Uniform1(Int32 location, Int32 v0);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="value">[length: count*1] 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform1iv")]
        public static extern void Uniform1(Int32 location, Int32 count, Int32[] value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="value">[length: count*1] 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform1iv")]
        public static extern void Uniform1(Int32 location, Int32 count, ref Int32 value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="value">[length: count*1] 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform1iv")]
        public static extern unsafe void Uniform1(Int32 location, Int32 count, Int32* value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="v0"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v1"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform2f")]
        public static extern void Uniform2(Int32 location, Single v0, Single v1);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="value">[length: count*2] 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform2fv")]
        public static extern void Uniform2(Int32 location, Int32 count, Single[] value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="value">[length: count*2] 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform2fv")]
        public static extern void Uniform2(Int32 location, Int32 count, ref Single value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="value">[length: count*2] 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform2fv")]
        public static extern unsafe void Uniform2(Int32 location, Int32 count, Single* value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="v0"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v1"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform2i")]
        public static extern void Uniform2(Int32 location, Int32 v0, Int32 v1);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="value">[length: count*2] 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform2iv")]
        public static extern void Uniform2(Int32 location, Int32 count, Int32[] value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="value">[length: count*2] 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform2iv")]
        public static extern unsafe void Uniform2(Int32 location, Int32 count, Int32* value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="v0"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v1"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v2"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform3f")]
        public static extern void Uniform3(Int32 location, Single v0, Single v1, Single v2);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="value">[length: count*3] 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform3fv")]
        public static extern void Uniform3(Int32 location, Int32 count, Single[] value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="value">[length: count*3] 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform3fv")]
        public static extern void Uniform3(Int32 location, Int32 count, ref Single value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="value">[length: count*3] 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform3fv")]
        public static extern unsafe void Uniform3(Int32 location, Int32 count, Single* value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="v0"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v1"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v2"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform3i")]
        public static extern void Uniform3(Int32 location, Int32 v0, Int32 v1, Int32 v2);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="value">[length: count*3] 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform3iv")]
        public static extern void Uniform3(Int32 location, Int32 count, Int32[] value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="value">[length: count*3] 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform3iv")]
        public static extern void Uniform3(Int32 location, Int32 count, ref Int32 value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="value">[length: count*3] 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform3iv")]
        public static extern unsafe void Uniform3(Int32 location, Int32 count, Int32* value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="v0"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v1"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v2"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v3"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform4f")]
        public static extern void Uniform4(Int32 location, Single v0, Single v1, Single v2, Single v3);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="value">[length: count*4] 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform4fv")]
        public static extern void Uniform4(Int32 location, Int32 count, Single[] value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="value">[length: count*4] 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform4fv")]
        public static extern void Uniform4(Int32 location, Int32 count, ref Single value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="value">[length: count*4] 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform4fv")]
        public static extern unsafe void Uniform4(Int32 location, Int32 count, Single* value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="v0"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v1"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v2"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v3"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform4i")]
        public static extern void Uniform4(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="value">[length: count*4] 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform4iv")]
        public static extern void Uniform4(Int32 location, Int32 count, Int32[] value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="value">[length: count*4] 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform4iv")]
        public static extern void Uniform4(Int32 location, Int32 count, ref Int32 value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a uniform variable for the current program object
        /// </summary>
        /// <param name="location"> 
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count"> 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="value">[length: count*4] 
        /// Specifies the new values to be used for the specified uniform variable.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniform4iv")]
        public static extern unsafe void Uniform4(Int32 location, Int32 count, Int32* value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="location"></param>
        /// <param name="count"></param>
        /// <param name="transpose"></param>
        /// <param name="value">[length: count*4]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniformMatrix2fv")]
        public static extern void UniformMatrix2(Int32 location, Int32 count, bool transpose, Single[] value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="location"></param>
        /// <param name="count"></param>
        /// <param name="transpose"></param>
        /// <param name="value">[length: count*4]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniformMatrix2fv")]
        public static extern void UniformMatrix2(Int32 location, Int32 count, bool transpose, ref Single value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="location"></param>
        /// <param name="count"></param>
        /// <param name="transpose"></param>
        /// <param name="value">[length: count*4]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniformMatrix2fv")]
        public static extern unsafe void UniformMatrix2(Int32 location, Int32 count, bool transpose, Single* value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="location"></param>
        /// <param name="count"></param>
        /// <param name="transpose"></param>
        /// <param name="value">[length: count*9]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniformMatrix3fv")]
        public static extern void UniformMatrix3(Int32 location, Int32 count, bool transpose, Single[] value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="location"></param>
        /// <param name="count"></param>
        /// <param name="transpose"></param>
        /// <param name="value">[length: count*9]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniformMatrix3fv")]
        public static extern void UniformMatrix3(Int32 location, Int32 count, bool transpose, ref Single value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="location"></param>
        /// <param name="count"></param>
        /// <param name="transpose"></param>
        /// <param name="value">[length: count*9]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniformMatrix3fv")]
        public static extern unsafe void UniformMatrix3(Int32 location, Int32 count, bool transpose, Single* value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="location"></param>
        /// <param name="count"></param>
        /// <param name="transpose"></param>
        /// <param name="value">[length: count*16]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniformMatrix4fv")]
        public static extern void UniformMatrix4(Int32 location, Int32 count, bool transpose, Single[] value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="location"></param>
        /// <param name="count"></param>
        /// <param name="transpose"></param>
        /// <param name="value">[length: count*16]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniformMatrix4fv")]
        public static extern void UniformMatrix4(Int32 location, Int32 count, bool transpose, ref Single value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]</summary>
        /// <param name="location"></param>
        /// <param name="count"></param>
        /// <param name="transpose"></param>
        /// <param name="value">[length: count*16]</param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUniformMatrix4fv")]
        public static extern unsafe void UniformMatrix4(Int32 location, Int32 count, bool transpose, Single* value);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Install a program object as part of current rendering state
        /// </summary>
        /// <param name="program"> 
        /// Specifies the handle of the program object whose executables are to be used as part of current rendering state.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUseProgram")]
        public static extern void UseProgram(Int32 program);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Install a program object as part of current rendering state
        /// </summary>
        /// <param name="program"> 
        /// Specifies the handle of the program object whose executables are to be used as part of current rendering state.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glUseProgram")]
        public static extern void UseProgram(UInt32 program);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Validate a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the handle of the program object to be validated.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glValidateProgram")]
        public static extern void ValidateProgram(Int32 program);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Validate a program object
        /// </summary>
        /// <param name="program"> 
        /// Specifies the handle of the program object to be validated.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glValidateProgram")]
        public static extern void ValidateProgram(UInt32 program);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="x"> 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib1f")]
        public static extern void VertexAttrib1(Int32 index, Single x);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="x"> 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib1f")]
        public static extern void VertexAttrib1(UInt32 index, Single x);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">[length: 1] 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib1fv")]
        public static extern void VertexAttrib1(Int32 index, Single[] v);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">[length: 1] 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib1fv")]
        public static extern unsafe void VertexAttrib1(Int32 index, Single* v);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">[length: 1] 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib1fv")]
        public static extern void VertexAttrib1(UInt32 index, Single[] v);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">[length: 1] 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib1fv")]
        public static extern unsafe void VertexAttrib1(UInt32 index, Single* v);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="x"> 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        /// <param name="y"> 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib2f")]
        public static extern void VertexAttrib2(Int32 index, Single x, Single y);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="x"> 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        /// <param name="y"> 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib2f")]
        public static extern void VertexAttrib2(UInt32 index, Single x, Single y);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">[length: 2] 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib2fv")]
        public static extern void VertexAttrib2(Int32 index, Single[] v);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">[length: 2] 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib2fv")]
        public static extern void VertexAttrib2(Int32 index, ref Single v);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">[length: 2] 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib2fv")]
        public static extern unsafe void VertexAttrib2(Int32 index, Single* v);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">[length: 2] 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib2fv")]
        public static extern void VertexAttrib2(UInt32 index, Single[] v);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">[length: 2] 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib2fv")]
        public static extern void VertexAttrib2(UInt32 index, ref Single v);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">[length: 2] 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib2fv")]
        public static extern unsafe void VertexAttrib2(UInt32 index, Single* v);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="x"> 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        /// <param name="y"> 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        /// <param name="z"> 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib3f")]
        public static extern void VertexAttrib3(Int32 index, Single x, Single y, Single z);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="x"> 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        /// <param name="y"> 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        /// <param name="z"> 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib3f")]
        public static extern void VertexAttrib3(UInt32 index, Single x, Single y, Single z);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">[length: 3] 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib3fv")]
        public static extern void VertexAttrib3(Int32 index, Single[] v);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">[length: 3] 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib3fv")]
        public static extern void VertexAttrib3(Int32 index, ref Single v);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">[length: 3] 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib3fv")]
        public static extern unsafe void VertexAttrib3(Int32 index, Single* v);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">[length: 3] 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib3fv")]
        public static extern void VertexAttrib3(UInt32 index, Single[] v);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">[length: 3] 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib3fv")]
        public static extern void VertexAttrib3(UInt32 index, ref Single v);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">[length: 3] 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib3fv")]
        public static extern unsafe void VertexAttrib3(UInt32 index, Single* v);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="x"> 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        /// <param name="y"> 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        /// <param name="z"> 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        /// <param name="w"> 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib4f")]
        public static extern void VertexAttrib4(Int32 index, Single x, Single y, Single z, Single w);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="x"> 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        /// <param name="y"> 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        /// <param name="z"> 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        /// <param name="w"> 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib4f")]
        public static extern void VertexAttrib4(UInt32 index, Single x, Single y, Single z, Single w);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">[length: 4] 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib4fv")]
        public static extern void VertexAttrib4(Int32 index, Single[] v);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">[length: 4] 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib4fv")]
        public static extern void VertexAttrib4(Int32 index, ref Single v);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">[length: 4] 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib4fv")]
        public static extern unsafe void VertexAttrib4(Int32 index, Single* v);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">[length: 4] 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib4fv")]
        public static extern void VertexAttrib4(UInt32 index, Single[] v);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">[length: 4] 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib4fv")]
        public static extern void VertexAttrib4(UInt32 index, ref Single v);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Specify the value of a generic vertex attribute
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">[length: 4] 
        /// Specifies the new values to be used for the specified vertex attribute.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttrib4fv")]
        public static extern unsafe void VertexAttrib4(UInt32 index, Single* v);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Define an array of generic vertex attribute data
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="size"> 
        /// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each component in the array. Symbolic constants Byte, UnsignedByte, Short, UnsignedShort, Fixed, or Float are accepted. The initial value is Float.
        /// </param>
        /// <param name="normalized"> 
        /// Specifies whether fixed-point data values should be normalized (True) or converted directly as fixed-point values (False) when they are accessed.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive generic vertex attributes. If stride is 0, the generic vertex attributes are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first component of the first generic vertex attribute in the array. The initial value is 0.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttribPointer")]
        public static extern void VertexAttribPointer(Int32 index, Int32 size, All type, bool normalized, Int32 stride, IntPtr pointer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Define an array of generic vertex attribute data
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="size"> 
        /// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each component in the array. Symbolic constants Byte, UnsignedByte, Short, UnsignedShort, Fixed, or Float are accepted. The initial value is Float.
        /// </param>
        /// <param name="normalized"> 
        /// Specifies whether fixed-point data values should be normalized (True) or converted directly as fixed-point values (False) when they are accessed.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive generic vertex attributes. If stride is 0, the generic vertex attributes are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first component of the first generic vertex attribute in the array. The initial value is 0.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttribPointer")]
        public static extern void VertexAttribPointer(Int32 index, Int32 size, VertexAttribPointerType type, bool normalized, Int32 stride, IntPtr pointer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Define an array of generic vertex attribute data
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="size"> 
        /// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each component in the array. Symbolic constants Byte, UnsignedByte, Short, UnsignedShort, Fixed, or Float are accepted. The initial value is Float.
        /// </param>
        /// <param name="normalized"> 
        /// Specifies whether fixed-point data values should be normalized (True) or converted directly as fixed-point values (False) when they are accessed.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive generic vertex attributes. If stride is 0, the generic vertex attributes are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first component of the first generic vertex attribute in the array. The initial value is 0.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttribPointer")]
        public static extern void VertexAttribPointer(UInt32 index, Int32 size, All type, bool normalized, Int32 stride, IntPtr pointer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Define an array of generic vertex attribute data
        /// </summary>
        /// <param name="index"> 
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="size"> 
        /// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each component in the array. Symbolic constants Byte, UnsignedByte, Short, UnsignedShort, Fixed, or Float are accepted. The initial value is Float.
        /// </param>
        /// <param name="normalized"> 
        /// Specifies whether fixed-point data values should be normalized (True) or converted directly as fixed-point values (False) when they are accessed.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive generic vertex attributes. If stride is 0, the generic vertex attributes are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first component of the first generic vertex attribute in the array. The initial value is 0.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glVertexAttribPointer")]
        public static extern void VertexAttribPointer(UInt32 index, Int32 size, VertexAttribPointerType type, bool normalized, Int32 stride, IntPtr pointer);

        /// <summary>[requires: v2.0 or ES_VERSION_2_0]
        /// Set the viewport
        /// </summary>
        /// <param name="x"> 
        /// Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0,0).
        /// </param>
        /// <param name="y"> 
        /// Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0,0).
        /// </param>
        /// <param name="width"> 
        /// Specify the width and height of the viewport. When a GL context is first attached to a window, width and height are set to the dimensions of that window.
        /// </param>
        /// <param name="height"> 
        /// Specify the width and height of the viewport. When a GL context is first attached to a window, width and height are set to the dimensions of that window.
        /// </param>
        [DllImportAttribute("libGLESv2.dll", EntryPoint = "glViewport")]
        public static extern void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
    }
}
