Shader "Custom/WaveEffectShader"
{
    Properties
    {
        _MainTex("Texture", 2D) = "white" {}
        _Speed("Speed", Range(0.1, 10)) = 1.0
        _Amplitude("Amplitude", Range(0.1, 100)) = 10.0
    }

        SubShader
        {
            Tags { "RenderType" = "Transparent" "Queue" = "Transparent" }

            CGPROGRAM
            #pragma surface surf Lambert alpha

            struct Input
            {
                float2 uv_MainTex;
            };

            sampler2D _MainTex;
            float _Speed;
            float _Amplitude;

            void surf(Input IN, inout SurfaceOutputAlpha o)
            {
                float2 uv = IN.uv_MainTex;
                uv.y += sin(_Time.y * _Speed) * _Amplitude; // Apply the wave effect
                half4 c = tex2D(_MainTex, uv);
                o.Albedo = c.rgb;
                o.Alpha = c.a;
            }
            ENDCG
        }
            FallBack "Diffuse"
}
