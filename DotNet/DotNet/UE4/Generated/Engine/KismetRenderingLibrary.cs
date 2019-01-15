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

#pragma warning disable CS0108
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Kismet Rendering Library</summary>
    public unsafe partial class KismetRenderingLibrary : BlueprintFunctionLibrary  {

        ///<summary>Returns a Canvas object that can be used to draw to the specified render target.</summary>
        ///<remarks>
        ///Canvas has functions like DrawMaterial with size parameters that can be used to draw to a specific area of a render target.
        ///Be sure to call EndDrawCanvasToRenderTarget to complete the rendering!
        ///</remarks>
        public static (Canvas, Vector2D, DrawToRenderTargetContext) BeginDrawCanvasToRenderTarget(UObject WorldContextObject, TextureRenderTarget2D TextureRenderTarget)  => 
            KismetRenderingLibrary_methods.BeginDrawCanvasToRenderTarget_method.Invoke(WorldContextObject, TextureRenderTarget);

        ///<summary>Break FSkelMeshSkinWeightInfo</summary>
        public static (int, byte, int, byte, int, byte, int, byte) BreakSkinWeightInfo(SkelMeshSkinWeightInfo InWeight)  => 
            KismetRenderingLibrary_methods.BreakSkinWeightInfo_method.Invoke(InWeight);

        ///<summary>Clears the specified render target with the given ClearColor.</summary>
        public static void ClearRenderTarget2D(UObject WorldContextObject, TextureRenderTarget2D TextureRenderTarget, LinearColor ClearColor)  => 
            KismetRenderingLibrary_methods.ClearRenderTarget2D_method.Invoke(WorldContextObject, TextureRenderTarget, ClearColor);

        ///<summary>Copies the contents of a render target to a UTexture2D</summary>
        ///<remarks>Only works in the editor</remarks>
        public static void ConvertRenderTargetToTexture2DEditorOnly(UObject WorldContextObject, TextureRenderTarget2D RenderTarget, Texture2D Texture)  => 
            KismetRenderingLibrary_methods.ConvertRenderTargetToTexture2DEditorOnly_method.Invoke(WorldContextObject, RenderTarget, Texture);

        ///<summary>Creates a new render target and initializes it to the specified dimensions</summary>
        public static TextureRenderTarget2D CreateRenderTarget2D(UObject WorldContextObject, int Width, int Height, byte Format)  => 
            KismetRenderingLibrary_methods.CreateRenderTarget2D_method.Invoke(WorldContextObject, Width, Height, Format);

        ///<summary>Renders a quad with the material applied to the specified render target.</summary>
        ///<remarks>
        ///This sets the render target even if it is already set, which is an expensive operation.
        ///Use BeginDrawCanvasToRenderTarget / EndDrawCanvasToRenderTarget instead if rendering multiple primitives to the same render target.
        ///</remarks>
        public static void DrawMaterialToRenderTarget(UObject WorldContextObject, TextureRenderTarget2D TextureRenderTarget, MaterialInterface Material)  => 
            KismetRenderingLibrary_methods.DrawMaterialToRenderTarget_method.Invoke(WorldContextObject, TextureRenderTarget, Material);

        ///<summary>Must be paired with a BeginDrawCanvasToRenderTarget to complete rendering to a render target.</summary>
        public static void EndDrawCanvasToRenderTarget(UObject WorldContextObject, DrawToRenderTargetContext Context)  => 
            KismetRenderingLibrary_methods.EndDrawCanvasToRenderTarget_method.Invoke(WorldContextObject, Context);

        ///<summary>Exports a render target as a HDR or PNG image onto the disk (depending on the format of the render target)</summary>
        public static void ExportRenderTarget(UObject WorldContextObject, TextureRenderTarget2D TextureRenderTarget, string FilePath, string FileName)  => 
            KismetRenderingLibrary_methods.ExportRenderTarget_method.Invoke(WorldContextObject, TextureRenderTarget, FilePath, FileName);

        ///<summary>Exports a Texture2D as a HDR image onto the disk.</summary>
        public static void ExportTexture2D(UObject WorldContextObject, Texture2D Texture, string FilePath, string FileName)  => 
            KismetRenderingLibrary_methods.ExportTexture2D_method.Invoke(WorldContextObject, Texture, FilePath, FileName);

        ///<summary>Imports a texture file from disk and creates Texture2D from it.</summary>
        public static Texture2D ImportFileAsTexture2D(UObject WorldContextObject, string Filename)  => 
            KismetRenderingLibrary_methods.ImportFileAsTexture2D_method.Invoke(WorldContextObject, Filename);

        ///<summary>Create FSkelMeshSkinWeightInfo</summary>
        public static SkelMeshSkinWeightInfo MakeSkinWeightInfo(int Bone0, byte Weight0, int Bone1, byte Weight1, int Bone2, byte Weight2, int Bone3, byte Weight3)  => 
            KismetRenderingLibrary_methods.MakeSkinWeightInfo_method.Invoke(Bone0, Weight0, Bone1, Weight1, Bone2, Weight2, Bone3, Weight3);

        ///<summary>Incredibly inefficient and slow operation! Read a value as sRGB color from a render target using integer pixel coordinates.</summary>
        ///<remarks>
        ///LDR render targets are assumed to be in sRGB space. HDR ones are assumed to be in linear space.
        ///Result is 8-bit per channel [0,255] BGRA in sRGB space.
        ///</remarks>
        public static Color ReadRenderTargetPixel(UObject WorldContextObject, TextureRenderTarget2D TextureRenderTarget, int X, int Y)  => 
            KismetRenderingLibrary_methods.ReadRenderTargetPixel_method.Invoke(WorldContextObject, TextureRenderTarget, X, Y);

        ///<summary>Incredibly inefficient and slow operation! Read a value as-is from a render target using integer pixel coordinates.</summary>
        public static LinearColor ReadRenderTargetRawPixel(UObject WorldContextObject, TextureRenderTarget2D TextureRenderTarget, int X, int Y)  => 
            KismetRenderingLibrary_methods.ReadRenderTargetRawPixel_method.Invoke(WorldContextObject, TextureRenderTarget, X, Y);

        ///<summary>Incredibly inefficient and slow operation! Read a value as-is color from a render target using UV [0,1]x[0,1] coordinates.</summary>
        public static LinearColor ReadRenderTargetRawUV(UObject WorldContextObject, TextureRenderTarget2D TextureRenderTarget, float U, float V)  => 
            KismetRenderingLibrary_methods.ReadRenderTargetRawUV_method.Invoke(WorldContextObject, TextureRenderTarget, U, V);

        ///<summary>Incredibly inefficient and slow operation! Read a value as sRGB color from a render target using UV [0,1]x[0,1] coordinates.</summary>
        ///<remarks>
        ///LDR render targets are assumed to be in sRGB space. HDR ones are assumed to be in linear space.
        ///Result is 8-bit per channel [0,255] BGRA in sRGB space.
        ///</remarks>
        public static Color ReadRenderTargetUV(UObject WorldContextObject, TextureRenderTarget2D TextureRenderTarget, float U, float V)  => 
            KismetRenderingLibrary_methods.ReadRenderTargetUV_method.Invoke(WorldContextObject, TextureRenderTarget, U, V);

        ///<summary>Manually releases GPU resources of a render target.</summary>
        ///<remarks>
        ///This is useful for blueprint creating a lot of render target that would
        ///normally be released too late by the garbage collector that can be problematic on platforms that have tight GPU memory constrains.
        ///</remarks>
        public static void ReleaseRenderTarget2D(TextureRenderTarget2D TextureRenderTarget)  => 
            KismetRenderingLibrary_methods.ReleaseRenderTarget2D_method.Invoke(TextureRenderTarget);

        ///<summary>Creates a new Static Texture from a Render Target 2D.</summary>
        ///<remarks>
        ///Render Target Must be power of two and use four channels.
        ///Only works in the editor
        ///</remarks>
        public static Texture2D RenderTargetCreateStaticTexture2DEditorOnly(TextureRenderTarget2D RenderTarget, string Name, byte CompressionSettings, byte MipSettings)  => 
            KismetRenderingLibrary_methods.RenderTargetCreateStaticTexture2DEditorOnly_method.Invoke(RenderTarget, Name, CompressionSettings, MipSettings);
        static KismetRenderingLibrary() {
            StaticClass = Main.GetClass("KismetRenderingLibrary");
        }
        internal unsafe KismetRenderingLibrary_fields* KismetRenderingLibrary_ptr => (KismetRenderingLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator KismetRenderingLibrary(IntPtr p) => UObject.Make<KismetRenderingLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static KismetRenderingLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static KismetRenderingLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
