//Copyright (c) 2013 Qualcomm Austria Research Center GmbH.
//All Rights Reserved.
//Confidential and Proprietary - QUALCOMM Austria Research Center GmbH.
Shader "Custom/Text3D" {
    Properties {
        _MainTex ("Base (RGB)", 2D) = "white" {}
        _Color ("Text Color", Color) = (1,1,1,1)
    }

    SubShader {
        Tags { "Queue"="Geometry+1" "IgnoreProjector"="True" }
        Lighting Off Offset -1, -1 ZTest LEqual ZWrite On Fog { Mode Off }
        Blend SrcAlpha OneMinusSrcAlpha
        Pass {
            Color [_Color]
            SetTexture [_MainTex] {
                combine primary, texture * primary
            }
        }
    }


}
