# GLES
Opengl ES with .Net Core playground

Framework for learning and experimenting with Opengl ES using C# and .Net Core

GLES contains bindings for GLES and Maths functions (from OpenTK) Plus a few helpers to handle loading shaders

GLES.Demo has examples of various techniques in OpenGL

GLES.PI is a Mono app that runs on the PI. You can build on windows and then copy the contents of the debug folder across on to the PI. You will need to add the libglPiContext.so into the same directory on the PI also. This creates a context on the PI directly with the broadcom chip. No X windows is required to run it.  

GLES.Win is a WPF .net core app that is used to display the GL ES surface. 

**Important  GLES.Win app must be run as x86 and you need to ensure libegl.dll and libglesv2.dll (Angle) are included in the debug folder (these are included in source control)



