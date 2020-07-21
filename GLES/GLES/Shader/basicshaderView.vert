precision highp float;

// uniforms. Like global variables for this shader
// these can be updated only when you are using the current program
uniform mat4 uModelview_matrix;
uniform mat4 uProjection_matrix;
uniform mat4 uView_matrix;

// attributes. This is data sent for every vertex that you send
// to the shader.
attribute vec3 aVert;
attribute vec4 aColor;

// varying. This is sent over to the fragment shader and interpolated
// between the different vertex values.
varying vec4 vColor;

void main(void)
{
	// set the end position of the vertex.
	gl_Position =  uProjection_matrix * uView_matrix * uModelview_matrix * vec4(aVert, 1.0);
	
	// set the color to go to the fragment shader.
	vColor = aColor;
}