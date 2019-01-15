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
    [StructLayout( LayoutKind.Explicit, Size=1248 )]
    internal unsafe struct HUD_fields {
        [FieldOffset(1008)]  public IntPtr  PlayerOwner;
        [FieldOffset(1016)] public bool bLostFocusPaused;
        [FieldOffset(1016)] public bool bShowHUD;
        [FieldOffset(1016)] public bool bShowDebugInfo;
        [FieldOffset(1020)] public int CurrentTargetIndex;
        [FieldOffset(1024)] public bool bShowHitBoxDebugInfo;
        [FieldOffset(1024)] public bool bShowOverlays;
        [FieldOffset(1024)] public bool bEnableDebugTextShadow;
        [FieldOffset(1032)] public NativeArray PostRenderedActors;
        [FieldOffset(1056)] public NativeArray DebugDisplay;
        [FieldOffset(1072)] public NativeArray ToggledDebugCategories;
        [FieldOffset(1088)]  public IntPtr  Canvas;
        [FieldOffset(1096)]  public IntPtr  DebugCanvas;
        [FieldOffset(1104)] public NativeArray DebugTextList;
        [FieldOffset(1120)] public IntPtr ShowDebugTargetDesiredClass;
        [FieldOffset(1128)]  public IntPtr  ShowDebugTargetActor;
    }
    internal unsafe struct HUD_methods {
        internal struct AddHitBox_method {
            static internal IntPtr AddHitBox_ptr;
            static AddHitBox_method() {
                AddHitBox_ptr = Main.GetMethodUFunction(HUD.StaticClass, "AddHitBox");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D Position, Vector2D Size, Name InName, bool bConsumesInput, int Priority) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = Position;
                *((Vector2D*)(b+8)) = Size;
                *((Name*)(b+16)) = InName;
                *((bool*)(b+28)) = bConsumesInput;
                *((int*)(b+32)) = Priority;
                Main.GetProcessEvent(obj, AddHitBox_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Deproject_method {
            static internal IntPtr Deproject_ptr;
            static Deproject_method() {
                Deproject_ptr = Main.GetMethodUFunction(HUD.StaticClass, "Deproject");
            }

            internal static unsafe (Vector, Vector) Invoke(IntPtr obj, float ScreenX, float ScreenY) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = ScreenX;
                *((float*)(b+4)) = ScreenY;
                Main.GetProcessEvent(obj, Deproject_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+8)),*((Vector*)(b+20)));
            }
        }
        internal struct DrawLine_method {
            static internal IntPtr DrawLine_ptr;
            static DrawLine_method() {
                DrawLine_ptr = Main.GetMethodUFunction(HUD.StaticClass, "DrawLine");
            }

            internal static unsafe void Invoke(IntPtr obj, float StartScreenX, float StartScreenY, float EndScreenX, float EndScreenY, LinearColor LineColor, float LineThickness) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = StartScreenX;
                *((float*)(b+4)) = StartScreenY;
                *((float*)(b+8)) = EndScreenX;
                *((float*)(b+12)) = EndScreenY;
                *((LinearColor*)(b+16)) = LineColor;
                *((float*)(b+32)) = LineThickness;
                Main.GetProcessEvent(obj, DrawLine_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawMaterial_method {
            static internal IntPtr DrawMaterial_ptr;
            static DrawMaterial_method() {
                DrawMaterial_ptr = Main.GetMethodUFunction(HUD.StaticClass, "DrawMaterial");
            }

            internal static unsafe void Invoke(IntPtr obj, MaterialInterface Material, float ScreenX, float ScreenY, float ScreenW, float ScreenH, float MaterialU, float MaterialV, float MaterialUWidth, float MaterialVHeight, float Scale, bool bScalePosition, float Rotation, Vector2D RotPivot) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Material;
                *((float*)(b+8)) = ScreenX;
                *((float*)(b+12)) = ScreenY;
                *((float*)(b+16)) = ScreenW;
                *((float*)(b+20)) = ScreenH;
                *((float*)(b+24)) = MaterialU;
                *((float*)(b+28)) = MaterialV;
                *((float*)(b+32)) = MaterialUWidth;
                *((float*)(b+36)) = MaterialVHeight;
                *((float*)(b+40)) = Scale;
                *((bool*)(b+44)) = bScalePosition;
                *((float*)(b+48)) = Rotation;
                *((Vector2D*)(b+52)) = RotPivot;
                Main.GetProcessEvent(obj, DrawMaterial_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawMaterialSimple_method {
            static internal IntPtr DrawMaterialSimple_ptr;
            static DrawMaterialSimple_method() {
                DrawMaterialSimple_ptr = Main.GetMethodUFunction(HUD.StaticClass, "DrawMaterialSimple");
            }

            internal static unsafe void Invoke(IntPtr obj, MaterialInterface Material, float ScreenX, float ScreenY, float ScreenW, float ScreenH, float Scale, bool bScalePosition) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Material;
                *((float*)(b+8)) = ScreenX;
                *((float*)(b+12)) = ScreenY;
                *((float*)(b+16)) = ScreenW;
                *((float*)(b+20)) = ScreenH;
                *((float*)(b+24)) = Scale;
                *((bool*)(b+28)) = bScalePosition;
                Main.GetProcessEvent(obj, DrawMaterialSimple_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawMaterialTriangle_method {
            static internal IntPtr DrawMaterialTriangle_ptr;
            static DrawMaterialTriangle_method() {
                DrawMaterialTriangle_ptr = Main.GetMethodUFunction(HUD.StaticClass, "DrawMaterialTriangle");
            }

            internal static unsafe void Invoke(IntPtr obj, MaterialInterface Material, Vector2D V0_Pos, Vector2D V1_Pos, Vector2D V2_Pos, Vector2D V0_UV, Vector2D V1_UV, Vector2D V2_UV, LinearColor V0_Color, LinearColor V1_Color, LinearColor V2_Color) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Material;
                *((Vector2D*)(b+8)) = V0_Pos;
                *((Vector2D*)(b+16)) = V1_Pos;
                *((Vector2D*)(b+24)) = V2_Pos;
                *((Vector2D*)(b+32)) = V0_UV;
                *((Vector2D*)(b+40)) = V1_UV;
                *((Vector2D*)(b+48)) = V2_UV;
                *((LinearColor*)(b+56)) = V0_Color;
                *((LinearColor*)(b+72)) = V1_Color;
                *((LinearColor*)(b+88)) = V2_Color;
                Main.GetProcessEvent(obj, DrawMaterialTriangle_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawRect_method {
            static internal IntPtr DrawRect_ptr;
            static DrawRect_method() {
                DrawRect_ptr = Main.GetMethodUFunction(HUD.StaticClass, "DrawRect");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor RectColor, float ScreenX, float ScreenY, float ScreenW, float ScreenH) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = RectColor;
                *((float*)(b+16)) = ScreenX;
                *((float*)(b+20)) = ScreenY;
                *((float*)(b+24)) = ScreenW;
                *((float*)(b+28)) = ScreenH;
                Main.GetProcessEvent(obj, DrawRect_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawText_method {
            static internal IntPtr DrawText_ptr;
            static DrawText_method() {
                DrawText_ptr = Main.GetMethodUFunction(HUD.StaticClass, "DrawText");
            }

            internal static unsafe void Invoke(IntPtr obj, string Text, LinearColor TextColor, float ScreenX, float ScreenY, Font Font, float Scale, bool bScalePosition) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Text_handle = GCHandle.Alloc(Text, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Text_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Text.Length;
                *(int*)(b+IntPtr.Size+4+0) = Text.Length;
                *((LinearColor*)(b+16)) = TextColor;
                *((float*)(b+32)) = ScreenX;
                *((float*)(b+36)) = ScreenY;
                *((IntPtr*)(b+40)) = Font;
                *((float*)(b+48)) = Scale;
                *((bool*)(b+52)) = bScalePosition;
                Main.GetProcessEvent(obj, DrawText_ptr, new IntPtr(p)); ;
                Text_handle.Free();
            }
        }
        internal struct DrawTexture_method {
            static internal IntPtr DrawTexture_ptr;
            static DrawTexture_method() {
                DrawTexture_ptr = Main.GetMethodUFunction(HUD.StaticClass, "DrawTexture");
            }

            internal static unsafe void Invoke(IntPtr obj, Texture Texture, float ScreenX, float ScreenY, float ScreenW, float ScreenH, float TextureU, float TextureV, float TextureUWidth, float TextureVHeight, LinearColor TintColor, byte BlendMode, float Scale, bool bScalePosition, float Rotation, Vector2D RotPivot) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Texture;
                *((float*)(b+8)) = ScreenX;
                *((float*)(b+12)) = ScreenY;
                *((float*)(b+16)) = ScreenW;
                *((float*)(b+20)) = ScreenH;
                *((float*)(b+24)) = TextureU;
                *((float*)(b+28)) = TextureV;
                *((float*)(b+32)) = TextureUWidth;
                *((float*)(b+36)) = TextureVHeight;
                *((LinearColor*)(b+40)) = TintColor;
                *(b+56) = BlendMode;
                *((float*)(b+60)) = Scale;
                *((bool*)(b+64)) = bScalePosition;
                *((float*)(b+68)) = Rotation;
                *((Vector2D*)(b+72)) = RotPivot;
                Main.GetProcessEvent(obj, DrawTexture_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawTextureSimple_method {
            static internal IntPtr DrawTextureSimple_ptr;
            static DrawTextureSimple_method() {
                DrawTextureSimple_ptr = Main.GetMethodUFunction(HUD.StaticClass, "DrawTextureSimple");
            }

            internal static unsafe void Invoke(IntPtr obj, Texture Texture, float ScreenX, float ScreenY, float Scale, bool bScalePosition) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Texture;
                *((float*)(b+8)) = ScreenX;
                *((float*)(b+12)) = ScreenY;
                *((float*)(b+16)) = Scale;
                *((bool*)(b+20)) = bScalePosition;
                Main.GetProcessEvent(obj, DrawTextureSimple_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetActorsInSelectionRectangle_method {
            static internal IntPtr GetActorsInSelectionRectangle_ptr;
            static GetActorsInSelectionRectangle_method() {
                GetActorsInSelectionRectangle_ptr = Main.GetMethodUFunction(HUD.StaticClass, "GetActorsInSelectionRectangle");
            }

            internal static unsafe IReadOnlyCollection<Actor> Invoke(IntPtr obj, SubclassOf<Actor> ClassFilter, Vector2D FirstPoint, Vector2D SecondPoint, bool bIncludeNonCollidingComponents, bool bActorMustBeFullyEnclosed) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ClassFilter;
                *((Vector2D*)(b+8)) = FirstPoint;
                *((Vector2D*)(b+16)) = SecondPoint;
                *((bool*)(b+40)) = bIncludeNonCollidingComponents;
                *((bool*)(b+41)) = bActorMustBeFullyEnclosed;
                Main.GetProcessEvent(obj, GetActorsInSelectionRectangle_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutActors
                return UObject.ToUObjectCollection<Actor>(b+24);
            }
        }
        internal struct GetOwningPawn_method {
            static internal IntPtr GetOwningPawn_ptr;
            static GetOwningPawn_method() {
                GetOwningPawn_ptr = Main.GetMethodUFunction(HUD.StaticClass, "GetOwningPawn");
            }

            internal static unsafe Pawn Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetOwningPawn_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetOwningPlayerController_method {
            static internal IntPtr GetOwningPlayerController_ptr;
            static GetOwningPlayerController_method() {
                GetOwningPlayerController_ptr = Main.GetMethodUFunction(HUD.StaticClass, "GetOwningPlayerController");
            }

            internal static unsafe PlayerController Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetOwningPlayerController_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetTextSize_method {
            static internal IntPtr GetTextSize_ptr;
            static GetTextSize_method() {
                GetTextSize_ptr = Main.GetMethodUFunction(HUD.StaticClass, "GetTextSize");
            }

            internal static unsafe (float, float) Invoke(IntPtr obj, string Text, Font Font, float Scale) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Text_handle = GCHandle.Alloc(Text, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Text_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Text.Length;
                *(int*)(b+IntPtr.Size+4+0) = Text.Length;
                *((IntPtr*)(b+24)) = Font;
                *((float*)(b+32)) = Scale;
                Main.GetProcessEvent(obj, GetTextSize_ptr, new IntPtr(p)); ;
                Text_handle.Free();
                return (*((float*)(b+16)),*((float*)(b+20)));
            }
        }
        internal struct Project_method {
            static internal IntPtr Project_ptr;
            static Project_method() {
                Project_ptr = Main.GetMethodUFunction(HUD.StaticClass, "Project");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Vector Location) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Location;
                Main.GetProcessEvent(obj, Project_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
    }
    internal unsafe struct HUD_events {
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct ReceiveDrawHUD_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveDrawHUD_link;
            private static unsafe void ReceiveDrawHUD_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<HUD>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveDrawHUD(*(int*)(b+0), *(int*)(b+4));
            }
            internal static void Setup() {
                ReceiveDrawHUD_link = new DelegateHolder<NativeFuncDelegate>(ReceiveDrawHUD_process_event);
                var uf = Main.GetUFunction("ReceiveDrawHUD");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveDrawHUD_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=12 )]
        internal unsafe struct ReceiveHitBoxBeginCursorOver_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveHitBoxBeginCursorOver_link;
            private static unsafe void ReceiveHitBoxBeginCursorOver_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<HUD>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveHitBoxBeginCursorOver(*(Name*)(b+0));
            }
            internal static void Setup() {
                ReceiveHitBoxBeginCursorOver_link = new DelegateHolder<NativeFuncDelegate>(ReceiveHitBoxBeginCursorOver_process_event);
                var uf = Main.GetUFunction("ReceiveHitBoxBeginCursorOver");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveHitBoxBeginCursorOver_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=12 )]
        internal unsafe struct ReceiveHitBoxClick_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveHitBoxClick_link;
            private static unsafe void ReceiveHitBoxClick_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<HUD>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveHitBoxClick(*(Name*)(b+0));
            }
            internal static void Setup() {
                ReceiveHitBoxClick_link = new DelegateHolder<NativeFuncDelegate>(ReceiveHitBoxClick_process_event);
                var uf = Main.GetUFunction("ReceiveHitBoxClick");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveHitBoxClick_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=12 )]
        internal unsafe struct ReceiveHitBoxEndCursorOver_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveHitBoxEndCursorOver_link;
            private static unsafe void ReceiveHitBoxEndCursorOver_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<HUD>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveHitBoxEndCursorOver(*(Name*)(b+0));
            }
            internal static void Setup() {
                ReceiveHitBoxEndCursorOver_link = new DelegateHolder<NativeFuncDelegate>(ReceiveHitBoxEndCursorOver_process_event);
                var uf = Main.GetUFunction("ReceiveHitBoxEndCursorOver");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveHitBoxEndCursorOver_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=12 )]
        internal unsafe struct ReceiveHitBoxRelease_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveHitBoxRelease_link;
            private static unsafe void ReceiveHitBoxRelease_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<HUD>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveHitBoxRelease(*(Name*)(b+0));
            }
            internal static void Setup() {
                ReceiveHitBoxRelease_link = new DelegateHolder<NativeFuncDelegate>(ReceiveHitBoxRelease_process_event);
                var uf = Main.GetUFunction("ReceiveHitBoxRelease");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveHitBoxRelease_link.Delegate));
            }
        }
    }
}
