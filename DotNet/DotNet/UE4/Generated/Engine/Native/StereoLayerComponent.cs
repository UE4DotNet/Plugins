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
    [StructLayout( LayoutKind.Explicit, Size=784 )]
    internal unsafe struct StereoLayerComponent_fields {
        [FieldOffset(624)] public bool bLiveTexture;
        [FieldOffset(624)] public bool bSupportsDepth;
        [FieldOffset(624)] public bool bNoAlphaChannel;
        [FieldOffset(632)]  public IntPtr  Texture;
        [FieldOffset(640)]  public IntPtr  LeftTexture;
        [FieldOffset(648)] public bool bQuadPreserveTextureRatio;
        [FieldOffset(652)] public Vector2D QuadSize;
        [FieldOffset(660)] public Box2D UVRect;
        [FieldOffset(680)] public float CylinderRadius;
        [FieldOffset(684)] public float CylinderOverlayArc;
        [FieldOffset(688)] public int CylinderHeight;
        [FieldOffset(692)] public byte StereoLayerType;
        [FieldOffset(693)] public byte StereoLayerShape;
        [FieldOffset(696)] public int Priority;
    }
    internal unsafe struct StereoLayerComponent_methods {
        internal struct GetPriority_method {
            static internal IntPtr GetPriority_ptr;
            static GetPriority_method() {
                GetPriority_ptr = Main.GetMethodUFunction(StereoLayerComponent.StaticClass, "GetPriority");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPriority_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetQuadSize_method {
            static internal IntPtr GetQuadSize_ptr;
            static GetQuadSize_method() {
                GetQuadSize_ptr = Main.GetMethodUFunction(StereoLayerComponent.StaticClass, "GetQuadSize");
            }

            internal static unsafe Vector2D Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetQuadSize_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+0));
            }
        }
        internal struct GetTexture_method {
            static internal IntPtr GetTexture_ptr;
            static GetTexture_method() {
                GetTexture_ptr = Main.GetMethodUFunction(StereoLayerComponent.StaticClass, "GetTexture");
            }

            internal static unsafe Texture Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetTexture_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetUVRect_method {
            static internal IntPtr GetUVRect_ptr;
            static GetUVRect_method() {
                GetUVRect_ptr = Main.GetMethodUFunction(StereoLayerComponent.StaticClass, "GetUVRect");
            }

            internal static unsafe Box2D Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetUVRect_ptr, new IntPtr(p)); ;
                return *((Box2D*)(b+0));
            }
        }
        internal struct MarkTextureForUpdate_method {
            static internal IntPtr MarkTextureForUpdate_ptr;
            static MarkTextureForUpdate_method() {
                MarkTextureForUpdate_ptr = Main.GetMethodUFunction(StereoLayerComponent.StaticClass, "MarkTextureForUpdate");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, MarkTextureForUpdate_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPriority_method {
            static internal IntPtr SetPriority_ptr;
            static SetPriority_method() {
                SetPriority_ptr = Main.GetMethodUFunction(StereoLayerComponent.StaticClass, "SetPriority");
            }

            internal static unsafe void Invoke(IntPtr obj, int InPriority) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = InPriority;
                Main.GetProcessEvent(obj, SetPriority_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetQuadSize_method {
            static internal IntPtr SetQuadSize_ptr;
            static SetQuadSize_method() {
                SetQuadSize_ptr = Main.GetMethodUFunction(StereoLayerComponent.StaticClass, "SetQuadSize");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D InQuadSize) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = InQuadSize;
                Main.GetProcessEvent(obj, SetQuadSize_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTexture_method {
            static internal IntPtr SetTexture_ptr;
            static SetTexture_method() {
                SetTexture_ptr = Main.GetMethodUFunction(StereoLayerComponent.StaticClass, "SetTexture");
            }

            internal static unsafe void Invoke(IntPtr obj, Texture InTexture) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InTexture;
                Main.GetProcessEvent(obj, SetTexture_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetUVRect_method {
            static internal IntPtr SetUVRect_ptr;
            static SetUVRect_method() {
                SetUVRect_ptr = Main.GetMethodUFunction(StereoLayerComponent.StaticClass, "SetUVRect");
            }

            internal static unsafe void Invoke(IntPtr obj, Box2D InUVRect) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Box2D*)(b+0)) = InUVRect;
                Main.GetProcessEvent(obj, SetUVRect_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct StereoLayerComponent_events {
    }
}
