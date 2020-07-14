precision highp float;

varying vec2 vTexCoord;
varying vec4 vColor;

uniform sampler2D uTexSlot0;
uniform sampler2D uTexSlot3;
//old: vec2(vTexCoord.s, vTexCoord.t) vec4(tex0.b, tex0.g, tex0.r, tex0.a)

void main(void)
{		
	vec4 tex0 = texture2D(uTexSlot0, vec2(vTexCoord.s, vTexCoord.t));
	vec4 tex3 = texture2D(uTexSlot3, vec2(vTexCoord.s, vTexCoord.t));

	gl_FragColor = vec4(0, 0, 0, 0);//vColor;  //vec4(tex0.b, tex0.g, tex0.r, tex0.a);
		
}