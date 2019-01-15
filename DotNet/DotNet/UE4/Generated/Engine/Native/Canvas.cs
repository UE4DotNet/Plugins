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
    [StructLayout( LayoutKind.Explicit, Size=752 )]
    internal unsafe struct Canvas_fields {
        [FieldOffset(56)] public float OrgX;
        [FieldOffset(60)] public float OrgY;
        [FieldOffset(64)] public float ClipX;
        [FieldOffset(68)] public float ClipY;
        [FieldOffset(72)] public Color DrawColor;
        [FieldOffset(76)] public bool bCenterX;
        [FieldOffset(76)] public bool bCenterY;
        [FieldOffset(76)] public bool bNoSmooth;
        [FieldOffset(80)] public int SizeX;
        [FieldOffset(84)] public int SizeY;
        [FieldOffset(96)] public Plane ColorModulate;
        [FieldOffset(112)]  public IntPtr  DefaultTexture;
        [FieldOffset(120)]  public IntPtr  GradientTexture0;
        [FieldOffset(128)]  public IntPtr  ReporterGraph;
    }
    internal unsafe struct Canvas_methods {
        internal struct K2_Deproject_method {
            static internal IntPtr K2_Deproject_ptr;
            static K2_Deproject_method() {
                K2_Deproject_ptr = Main.GetMethodUFunction(Canvas.StaticClass, "K2_Deproject");
            }

            internal static unsafe (Vector, Vector) Invoke(IntPtr obj, Vector2D ScreenPosition) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = ScreenPosition;
                Main.GetProcessEvent(obj, K2_Deproject_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+8)),*((Vector*)(b+20)));
            }
        }
        internal struct K2_DrawBorder_method {
            static internal IntPtr K2_DrawBorder_ptr;
            static K2_DrawBorder_method() {
                K2_DrawBorder_ptr = Main.GetMethodUFunction(Canvas.StaticClass, "K2_DrawBorder");
            }

            internal static unsafe void Invoke(IntPtr obj, Texture BorderTexture, Texture BackgroundTexture, Texture LeftBorderTexture, Texture RightBorderTexture, Texture TopBorderTexture, Texture BottomBorderTexture, Vector2D ScreenPosition, Vector2D ScreenSize, Vector2D CoordinatePosition, Vector2D CoordinateSize, LinearColor RenderColor, Vector2D BorderScale, Vector2D BackgroundScale, float Rotation, Vector2D PivotPoint, Vector2D CornerSize) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = BorderTexture;
                *((IntPtr*)(b+8)) = BackgroundTexture;
                *((IntPtr*)(b+16)) = LeftBorderTexture;
                *((IntPtr*)(b+24)) = RightBorderTexture;
                *((IntPtr*)(b+32)) = TopBorderTexture;
                *((IntPtr*)(b+40)) = BottomBorderTexture;
                *((Vector2D*)(b+48)) = ScreenPosition;
                *((Vector2D*)(b+56)) = ScreenSize;
                *((Vector2D*)(b+64)) = CoordinatePosition;
                *((Vector2D*)(b+72)) = CoordinateSize;
                *((LinearColor*)(b+80)) = RenderColor;
                *((Vector2D*)(b+96)) = BorderScale;
                *((Vector2D*)(b+104)) = BackgroundScale;
                *((float*)(b+112)) = Rotation;
                *((Vector2D*)(b+116)) = PivotPoint;
                *((Vector2D*)(b+124)) = CornerSize;
                Main.GetProcessEvent(obj, K2_DrawBorder_ptr, new IntPtr(p)); ;
            }
        }
        internal struct K2_DrawBox_method {
            static internal IntPtr K2_DrawBox_ptr;
            static K2_DrawBox_method() {
                K2_DrawBox_ptr = Main.GetMethodUFunction(Canvas.StaticClass, "K2_DrawBox");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D ScreenPosition, Vector2D ScreenSize, float Thickness, LinearColor RenderColor) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = ScreenPosition;
                *((Vector2D*)(b+8)) = ScreenSize;
                *((float*)(b+16)) = Thickness;
                *((LinearColor*)(b+20)) = RenderColor;
                Main.GetProcessEvent(obj, K2_DrawBox_ptr, new IntPtr(p)); ;
            }
        }
        internal struct K2_DrawLine_method {
            static internal IntPtr K2_DrawLine_ptr;
            static K2_DrawLine_method() {
                K2_DrawLine_ptr = Main.GetMethodUFunction(Canvas.StaticClass, "K2_DrawLine");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D ScreenPositionA, Vector2D ScreenPositionB, float Thickness, LinearColor RenderColor) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = ScreenPositionA;
                *((Vector2D*)(b+8)) = ScreenPositionB;
                *((float*)(b+16)) = Thickness;
                *((LinearColor*)(b+20)) = RenderColor;
                Main.GetProcessEvent(obj, K2_DrawLine_ptr, new IntPtr(p)); ;
            }
        }
        internal struct K2_DrawMaterial_method {
            static internal IntPtr K2_DrawMaterial_ptr;
            static K2_DrawMaterial_method() {
                K2_DrawMaterial_ptr = Main.GetMethodUFunction(Canvas.StaticClass, "K2_DrawMaterial");
            }

            internal static unsafe void Invoke(IntPtr obj, MaterialInterface RenderMaterial, Vector2D ScreenPosition, Vector2D ScreenSize, Vector2D CoordinatePosition, Vector2D CoordinateSize, float Rotation, Vector2D PivotPoint) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = RenderMaterial;
                *((Vector2D*)(b+8)) = ScreenPosition;
                *((Vector2D*)(b+16)) = ScreenSize;
                *((Vector2D*)(b+24)) = CoordinatePosition;
                *((Vector2D*)(b+32)) = CoordinateSize;
                *((float*)(b+40)) = Rotation;
                *((Vector2D*)(b+44)) = PivotPoint;
                Main.GetProcessEvent(obj, K2_DrawMaterial_ptr, new IntPtr(p)); ;
            }
        }
        internal struct K2_DrawMaterialTriangle_method {
            static internal IntPtr K2_DrawMaterialTriangle_ptr;
            static K2_DrawMaterialTriangle_method() {
                K2_DrawMaterialTriangle_ptr = Main.GetMethodUFunction(Canvas.StaticClass, "K2_DrawMaterialTriangle");
            }

            internal static unsafe void Invoke(IntPtr obj, MaterialInterface RenderMaterial, byte Triangles /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = RenderMaterial;
                throw new NotImplementedException(); //TODO: array TArray Triangles
                Main.GetProcessEvent(obj, K2_DrawMaterialTriangle_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Triangles
            }
        }
        internal struct K2_DrawPolygon_method {
            static internal IntPtr K2_DrawPolygon_ptr;
            static K2_DrawPolygon_method() {
                K2_DrawPolygon_ptr = Main.GetMethodUFunction(Canvas.StaticClass, "K2_DrawPolygon");
            }

            internal static unsafe void Invoke(IntPtr obj, Texture RenderTexture, Vector2D ScreenPosition, Vector2D Radius, int NumberOfSides, LinearColor RenderColor) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = RenderTexture;
                *((Vector2D*)(b+8)) = ScreenPosition;
                *((Vector2D*)(b+16)) = Radius;
                *((int*)(b+24)) = NumberOfSides;
                *((LinearColor*)(b+28)) = RenderColor;
                Main.GetProcessEvent(obj, K2_DrawPolygon_ptr, new IntPtr(p)); ;
            }
        }
        internal struct K2_DrawText_method {
            static internal IntPtr K2_DrawText_ptr;
            static K2_DrawText_method() {
                K2_DrawText_ptr = Main.GetMethodUFunction(Canvas.StaticClass, "K2_DrawText");
            }

            internal static unsafe void Invoke(IntPtr obj, Font RenderFont, string RenderText, Vector2D ScreenPosition, LinearColor RenderColor, float Kerning, LinearColor ShadowColor, Vector2D ShadowOffset, bool bCentreX, bool bCentreY, bool bOutlined, LinearColor OutlineColor) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = RenderFont;
                var RenderText_handle = GCHandle.Alloc(RenderText, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = RenderText_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = RenderText.Length;
                *(int*)(b+IntPtr.Size+4+8) = RenderText.Length;
                *((Vector2D*)(b+24)) = ScreenPosition;
                *((LinearColor*)(b+32)) = RenderColor;
                *((float*)(b+48)) = Kerning;
                *((LinearColor*)(b+52)) = ShadowColor;
                *((Vector2D*)(b+68)) = ShadowOffset;
                *((bool*)(b+76)) = bCentreX;
                *((bool*)(b+77)) = bCentreY;
                *((bool*)(b+78)) = bOutlined;
                *((LinearColor*)(b+80)) = OutlineColor;
                Main.GetProcessEvent(obj, K2_DrawText_ptr, new IntPtr(p)); ;
                RenderText_handle.Free();
            }
        }
        internal struct K2_DrawTexture_method {
            static internal IntPtr K2_DrawTexture_ptr;
            static K2_DrawTexture_method() {
                K2_DrawTexture_ptr = Main.GetMethodUFunction(Canvas.StaticClass, "K2_DrawTexture");
            }

            internal static unsafe void Invoke(IntPtr obj, Texture RenderTexture, Vector2D ScreenPosition, Vector2D ScreenSize, Vector2D CoordinatePosition, Vector2D CoordinateSize, LinearColor RenderColor, byte BlendMode, float Rotation, Vector2D PivotPoint) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = RenderTexture;
                *((Vector2D*)(b+8)) = ScreenPosition;
                *((Vector2D*)(b+16)) = ScreenSize;
                *((Vector2D*)(b+24)) = CoordinatePosition;
                *((Vector2D*)(b+32)) = CoordinateSize;
                *((LinearColor*)(b+40)) = RenderColor;
                *(b+56) = BlendMode;
                *((float*)(b+60)) = Rotation;
                *((Vector2D*)(b+64)) = PivotPoint;
                Main.GetProcessEvent(obj, K2_DrawTexture_ptr, new IntPtr(p)); ;
            }
        }
        internal struct K2_DrawTriangle_method {
            static internal IntPtr K2_DrawTriangle_ptr;
            static K2_DrawTriangle_method() {
                K2_DrawTriangle_ptr = Main.GetMethodUFunction(Canvas.StaticClass, "K2_DrawTriangle");
            }

            internal static unsafe void Invoke(IntPtr obj, Texture RenderTexture, byte Triangles /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = RenderTexture;
                throw new NotImplementedException(); //TODO: array TArray Triangles
                Main.GetProcessEvent(obj, K2_DrawTriangle_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Triangles
            }
        }
        internal struct K2_Project_method {
            static internal IntPtr K2_Project_ptr;
            static K2_Project_method() {
                K2_Project_ptr = Main.GetMethodUFunction(Canvas.StaticClass, "K2_Project");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Vector WorldLocation) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = WorldLocation;
                Main.GetProcessEvent(obj, K2_Project_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
        internal struct K2_StrLen_method {
            static internal IntPtr K2_StrLen_ptr;
            static K2_StrLen_method() {
                K2_StrLen_ptr = Main.GetMethodUFunction(Canvas.StaticClass, "K2_StrLen");
            }

            internal static unsafe Vector2D Invoke(IntPtr obj, Font RenderFont, string RenderText) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = RenderFont;
                var RenderText_handle = GCHandle.Alloc(RenderText, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = RenderText_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = RenderText.Length;
                *(int*)(b+IntPtr.Size+4+8) = RenderText.Length;
                Main.GetProcessEvent(obj, K2_StrLen_ptr, new IntPtr(p)); ;
                RenderText_handle.Free();
                return *((Vector2D*)(b+24));
            }
        }
        internal struct K2_TextSize_method {
            static internal IntPtr K2_TextSize_ptr;
            static K2_TextSize_method() {
                K2_TextSize_ptr = Main.GetMethodUFunction(Canvas.StaticClass, "K2_TextSize");
            }

            internal static unsafe Vector2D Invoke(IntPtr obj, Font RenderFont, string RenderText, Vector2D Scale) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = RenderFont;
                var RenderText_handle = GCHandle.Alloc(RenderText, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = RenderText_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = RenderText.Length;
                *(int*)(b+IntPtr.Size+4+8) = RenderText.Length;
                *((Vector2D*)(b+24)) = Scale;
                Main.GetProcessEvent(obj, K2_TextSize_ptr, new IntPtr(p)); ;
                RenderText_handle.Free();
                return *((Vector2D*)(b+32));
            }
        }
    }
    internal unsafe struct Canvas_events {
    }
}
