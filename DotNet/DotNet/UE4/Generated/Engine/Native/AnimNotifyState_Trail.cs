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
    [StructLayout( LayoutKind.Explicit, Size=120 )]
    internal unsafe struct AnimNotifyState_Trail_fields {
        [FieldOffset(64)]  public IntPtr  PSTemplate;
        [FieldOffset(72)] public Name FirstSocketName;
        [FieldOffset(84)] public Name SecondSocketName;
        [FieldOffset(96)] public byte WidthScaleMode;
        [FieldOffset(100)] public Name WidthScaleCurve;
        [FieldOffset(112)] public bool bRecycleSpawnedSystems;
        [FieldOffset(112)] public bool bRenderGeometry;
        [FieldOffset(112)] public bool bRenderSpawnPoints;
        [FieldOffset(112)] public bool bRenderTangents;
        [FieldOffset(112)] public bool bRenderTessellation;
    }
    internal unsafe struct AnimNotifyState_Trail_methods {
    }
    internal unsafe struct AnimNotifyState_Trail_events {
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        internal unsafe struct OverridePSTemplate_event {
            private static DelegateHolder<NativeFuncDelegate> OverridePSTemplate_link;
            private static unsafe void OverridePSTemplate_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<AnimNotifyState_Trail>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OverridePSTemplate(UObject.Make<SkeletalMeshComponent>(*(IntPtr*)(b+0)), UObject.Make<AnimSequenceBase>(*(IntPtr*)(b+8)), UObject.Make<ParticleSystem>(*(IntPtr*)(b+16)));
            }
            internal static void Setup() {
                OverridePSTemplate_link = new DelegateHolder<NativeFuncDelegate>(OverridePSTemplate_process_event);
                var uf = Main.GetUFunction("OverridePSTemplate");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OverridePSTemplate_link.Delegate));
            }
        }
    }
}
