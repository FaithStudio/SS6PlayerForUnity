//
//	SpriteStudio5 Player for Unity
//
//	Copyright(C) Web Technology Corp.
//	All rights reserved.
//

struct	InputVS	{
	float4	vertex : POSITION;
	float4	color : COLOR0;
	float4	texcoord : TEXCOORD0;
};

struct	InputPS	{
#ifdef SV_POSITION
	float4	Position : SV_POSITION;
#else
	float4	Position : POSITION;
#endif
	float4	ColorMain : COLOR0;
	float4	Texture00UV : TEXCOORD0;
	float4	PositionDraw : TEXCOORD7;
};

InputPS	VS_main(InputVS Input)
{
	InputPS	Output;
	float4	Temp;

	Temp.xy = Input.texcoord.xy;
	Temp.z = 0.0f;
	Temp.w = 0.0f;
	Output.Texture00UV = Temp;

	Output.ColorMain = Input.color;

	Temp = Input.vertex;
	Temp = UnityObjectToClipPos(Temp);
	Output.PositionDraw = Temp;
	Output.Position = Temp;

	return Output;
}
