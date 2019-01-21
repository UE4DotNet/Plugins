// Copyright 2018 by JCoder58.  See License.txt for license
// Auto-generated --- Do not modify.
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UE4.Core;
using UE4.CoreUObject;
using UE4.CoreUObject.Native;
using UE4.InputCore;
using UE4.Native;


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=2224 )]
    internal unsafe struct SceneCaptureComponent2D_fields {
        [FieldOffset(792)] public byte ProjectionType;
        [FieldOffset(796)] public float FOVAngle;
        [FieldOffset(800)] public float OrthoWidth;
        [FieldOffset(808)]  public IntPtr  TextureTarget;
        [FieldOffset(816)] public byte CaptureSource;
        [FieldOffset(817)] public byte CompositeMode;
        [FieldOffset(832)] public PostProcessSettings PostProcessSettings;
        [FieldOffset(2112)] public float PostProcessBlendWeight;
        [FieldOffset(2116)] public bool bUseCustomProjectionMatrix;
        [FieldOffset(2128)] public Matrix CustomProjectionMatrix;
        [FieldOffset(2192)] public bool bEnableClipPlane;
        [FieldOffset(2196)] public Vector ClipPlaneBase;
        [FieldOffset(2208)] public Vector ClipPlaneNormal;
        [FieldOffset(2220)] public bool bCameraCutThisFrame;
    }
    internal unsafe struct SceneCaptureComponent2D_methods {
        internal struct AddOrUpdateBlendable_method {
            static internal IntPtr AddOrUpdateBlendable_ptr;
            static AddOrUpdateBlendable_method() {
                AddOrUpdateBlendable_ptr = Main.GetMethodUFunction(SceneCaptureComponent2D.StaticClass, "AddOrUpdateBlendable");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InBlendableObject /*TODO: interface TScriptInterface */, float InWeight) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: interface TScriptInterface InBlendableObject
                *((float*)(b+16)) = InWeight;
                Main.GetProcessEvent(obj, AddOrUpdateBlendable_ptr, new IntPtr(p)); ;
                 //TODO: interface TScriptInterface InBlendableObject
            }
        }
        internal struct CaptureScene_method {
            static internal IntPtr CaptureScene_ptr;
            static CaptureScene_method() {
                CaptureScene_ptr = Main.GetMethodUFunction(SceneCaptureComponent2D.StaticClass, "CaptureScene");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, CaptureScene_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct SceneCaptureComponent2D_events {
    }
}
