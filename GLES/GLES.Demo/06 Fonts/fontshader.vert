precision highp float;

// uniforms. Like global variables for this shader
// these can be updated only when you are using the current program
uniform mat4 uModelview_matrix;
uniform mat4 uProjection_matrix;

// attributes. This is data sent for every vertex that you send
// to the shader.
attribute vec3 aVert;
attribute vec2 aTexCoord;

// varying. This is sent over to the fragment shader and interpolated
// between the different vertex values.
varying vec2 vTexCoord;

void main(void)
{
	// set the end position of the vertex.
	gl_Position = uProjection_matrix * uModelview_matrix * vec4(aVert, 1.0);
	
	// set the texture coordinate to go to the fragment shader.
	vTexCoord = aTexCoord;
}