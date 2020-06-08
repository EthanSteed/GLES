precision highp float;

varying vec2 vTexCoord;

uniform sampler2D uTexSlot0;

uniform float uAlphaTest;


void main(void)
{		
	vec4 tex0 = texture2D(uTexSlot0, vec2(vTexCoord.s, vTexCoord.t));

	if (tex0.a >= uAlphaTest)
	{				
		gl_FragColor = vec4(0.0, 0.7, 0.0, tex0.a);	
	}
	else
	{
		if (tex0.a >= uAlphaTest - 0.05)
		{						
			gl_FragColor = vec4(1.0, 1.0, 1.0, 1.0);	
		}
		else
		{
			discard;
		}
	}
	
}