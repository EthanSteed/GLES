precision highp float;

varying vec2 vTexCoord;

uniform sampler2D uTexSlot0;


void main(void)
{		
	vec4 tex0 = texture2D(uTexSlot0, vec2(vTexCoord.s, vTexCoord.t));

	gl_FragColor = vec4(tex0.b, tex0.g, tex0.r, 1);

}