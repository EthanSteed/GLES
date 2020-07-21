precision highp float;

varying vec4 vColor;

void main(void)
{	
	// set the color based on the varying color coming 
	// from the vertex shader. This will be interpolated between each vertex	
	gl_FragColor = vColor;

}