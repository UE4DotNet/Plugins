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
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct KismetRenderingLibrary_fields {
    }
    internal unsafe struct KismetRenderingLibrary_methods {
        internal struct BeginDrawCanvasToRenderTarget_method {
            static internal IntPtr BeginDrawCanvasToRenderTarget_ptr;
            static BeginDrawCanvasToRenderTarget_method() {
                BeginDrawCanvasToRenderTarget_ptr = Main.GetMethodUFunction(KismetRenderingLibrary.StaticClass, "BeginDrawCanvasToRenderTarget");
            }

            internal static unsafe (Canvas, Vector2D, DrawToRenderTargetContext) Invoke(UObject WorldContextObject, TextureRenderTarget2D TextureRenderTarget) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = TextureRenderTarget;
                Main.GetProcessEvent(KismetRenderingLibrary.DefaultObject, BeginDrawCanvasToRenderTarget_ptr, new IntPtr(p)); ;
                return (*((IntPtr*)(b+16)),*((Vector2D*)(b+24)),*((DrawToRenderTargetContext*)(b+32)));
            }
        }
        internal struct BreakSkinWeightInfo_method {
            static internal IntPtr BreakSkinWeightInfo_ptr;
            static BreakSkinWeightInfo_method() {
                BreakSkinWeightInfo_ptr = Main.GetMethodUFunction(KismetRenderingLibrary.StaticClass, "BreakSkinWeightInfo");
            }

            internal static unsafe (int, byte, int, byte, int, byte, int, byte) Invoke(SkelMeshSkinWeightInfo InWeight) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SkelMeshSkinWeightInfo*)(b+0)) = InWeight;
                Main.GetProcessEvent(KismetRenderingLibrary.DefaultObject, BreakSkinWeightInfo_ptr, new IntPtr(p)); ;
                return (*((int*)(b+40)),*(b+44),*((int*)(b+48)),*(b+52),*((int*)(b+56)),*(b+60),*((int*)(b+64)),*(b+68));
            }
        }
        internal struct ClearRenderTarget2D_method {
            static internal IntPtr ClearRenderTarget2D_ptr;
            static ClearRenderTarget2D_method() {
                ClearRenderTarget2D_ptr = Main.GetMethodUFunction(KismetRenderingLibrary.StaticClass, "ClearRenderTarget2D");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, TextureRenderTarget2D TextureRenderTarget, LinearColor ClearColor) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = TextureRenderTarget;
                *((LinearColor*)(b+16)) = ClearColor;
                Main.GetProcessEvent(KismetRenderingLibrary.DefaultObject, ClearRenderTarget2D_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ConvertRenderTargetToTexture2DEditorOnly_method {
            static internal IntPtr ConvertRenderTargetToTexture2DEditorOnly_ptr;
            static ConvertRenderTargetToTexture2DEditorOnly_method() {
                ConvertRenderTargetToTexture2DEditorOnly_ptr = Main.GetMethodUFunction(KismetRenderingLibrary.StaticClass, "ConvertRenderTargetToTexture2DEditorOnly");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, TextureRenderTarget2D RenderTarget, Texture2D Texture) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = RenderTarget;
                *((IntPtr*)(b+16)) = Texture;
                Main.GetProcessEvent(KismetRenderingLibrary.DefaultObject, ConvertRenderTargetToTexture2DEditorOnly_ptr, new IntPtr(p)); ;
            }
        }
        internal struct CreateRenderTarget2D_method {
            static internal IntPtr CreateRenderTarget2D_ptr;
            static CreateRenderTarget2D_method() {
                CreateRenderTarget2D_ptr = Main.GetMethodUFunction(KismetRenderingLibrary.StaticClass, "CreateRenderTarget2D");
            }

            internal static unsafe TextureRenderTarget2D Invoke(UObject WorldContextObject, int Width, int Height, byte Format) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((int*)(b+8)) = Width;
                *((int*)(b+12)) = Height;
                *(b+16) = Format;
                Main.GetProcessEvent(KismetRenderingLibrary.DefaultObject, CreateRenderTarget2D_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+24));
            }
        }
        internal struct DrawMaterialToRenderTarget_method {
            static internal IntPtr DrawMaterialToRenderTarget_ptr;
            static DrawMaterialToRenderTarget_method() {
                DrawMaterialToRenderTarget_ptr = Main.GetMethodUFunction(KismetRenderingLibrary.StaticClass, "DrawMaterialToRenderTarget");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, TextureRenderTarget2D TextureRenderTarget, MaterialInterface Material) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = TextureRenderTarget;
                *((IntPtr*)(b+16)) = Material;
                Main.GetProcessEvent(KismetRenderingLibrary.DefaultObject, DrawMaterialToRenderTarget_ptr, new IntPtr(p)); ;
            }
        }
        internal struct EndDrawCanvasToRenderTarget_method {
            static internal IntPtr EndDrawCanvasToRenderTarget_ptr;
            static EndDrawCanvasToRenderTarget_method() {
                EndDrawCanvasToRenderTarget_ptr = Main.GetMethodUFunction(KismetRenderingLibrary.StaticClass, "EndDrawCanvasToRenderTarget");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, DrawToRenderTargetContext Context) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((DrawToRenderTargetContext*)(b+8)) = Context;
                Main.GetProcessEvent(KismetRenderingLibrary.DefaultObject, EndDrawCanvasToRenderTarget_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ExportRenderTarget_method {
            static internal IntPtr ExportRenderTarget_ptr;
            static ExportRenderTarget_method() {
                ExportRenderTarget_ptr = Main.GetMethodUFunction(KismetRenderingLibrary.StaticClass, "ExportRenderTarget");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, TextureRenderTarget2D TextureRenderTarget, string FilePath, string FileName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = TextureRenderTarget;
                var FilePath_handle = GCHandle.Alloc(FilePath, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = FilePath_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = FilePath.Length;
                *(int*)(b+IntPtr.Size+4+16) = FilePath.Length;
                var FileName_handle = GCHandle.Alloc(FileName, GCHandleType.Pinned);
                *(IntPtr*)(b+32) = FileName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+32) = FileName.Length;
                *(int*)(b+IntPtr.Size+4+32) = FileName.Length;
                Main.GetProcessEvent(KismetRenderingLibrary.DefaultObject, ExportRenderTarget_ptr, new IntPtr(p)); ;
                FilePath_handle.Free();
                FileName_handle.Free();
            }
        }
        internal struct ExportTexture2D_method {
            static internal IntPtr ExportTexture2D_ptr;
            static ExportTexture2D_method() {
                ExportTexture2D_ptr = Main.GetMethodUFunction(KismetRenderingLibrary.StaticClass, "ExportTexture2D");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Texture2D Texture, string FilePath, string FileName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = Texture;
                var FilePath_handle = GCHandle.Alloc(FilePath, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = FilePath_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = FilePath.Length;
                *(int*)(b+IntPtr.Size+4+16) = FilePath.Length;
                var FileName_handle = GCHandle.Alloc(FileName, GCHandleType.Pinned);
                *(IntPtr*)(b+32) = FileName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+32) = FileName.Length;
                *(int*)(b+IntPtr.Size+4+32) = FileName.Length;
                Main.GetProcessEvent(KismetRenderingLibrary.DefaultObject, ExportTexture2D_ptr, new IntPtr(p)); ;
                FilePath_handle.Free();
                FileName_handle.Free();
            }
        }
        internal struct ImportBufferAsTexture2D_method {
            static internal IntPtr ImportBufferAsTexture2D_ptr;
            static ImportBufferAsTexture2D_method() {
                ImportBufferAsTexture2D_ptr = Main.GetMethodUFunction(KismetRenderingLibrary.StaticClass, "ImportBufferAsTexture2D");
            }

            internal static unsafe Texture2D Invoke(UObject WorldContextObject, byte Buffer /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                throw new NotImplementedException(); //TODO: array TArray Buffer
                Main.GetProcessEvent(KismetRenderingLibrary.DefaultObject, ImportBufferAsTexture2D_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Buffer
                return *((IntPtr*)(b+24));
            }
        }
        internal struct ImportFileAsTexture2D_method {
            static internal IntPtr ImportFileAsTexture2D_ptr;
            static ImportFileAsTexture2D_method() {
                ImportFileAsTexture2D_ptr = Main.GetMethodUFunction(KismetRenderingLibrary.StaticClass, "ImportFileAsTexture2D");
            }

            internal static unsafe Texture2D Invoke(UObject WorldContextObject, string Filename) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                var Filename_handle = GCHandle.Alloc(Filename, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = Filename_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = Filename.Length;
                *(int*)(b+IntPtr.Size+4+8) = Filename.Length;
                Main.GetProcessEvent(KismetRenderingLibrary.DefaultObject, ImportFileAsTexture2D_ptr, new IntPtr(p)); ;
                Filename_handle.Free();
                return *((IntPtr*)(b+24));
            }
        }
        internal struct MakeSkinWeightInfo_method {
            static internal IntPtr MakeSkinWeightInfo_ptr;
            static MakeSkinWeightInfo_method() {
                MakeSkinWeightInfo_ptr = Main.GetMethodUFunction(KismetRenderingLibrary.StaticClass, "MakeSkinWeightInfo");
            }

            internal static unsafe SkelMeshSkinWeightInfo Invoke(int Bone0, byte Weight0, int Bone1, byte Weight1, int Bone2, byte Weight2, int Bone3, byte Weight3) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Bone0;
                *(b+4) = Weight0;
                *((int*)(b+8)) = Bone1;
                *(b+12) = Weight1;
                *((int*)(b+16)) = Bone2;
                *(b+20) = Weight2;
                *((int*)(b+24)) = Bone3;
                *(b+28) = Weight3;
                Main.GetProcessEvent(KismetRenderingLibrary.DefaultObject, MakeSkinWeightInfo_ptr, new IntPtr(p)); ;
                return *((SkelMeshSkinWeightInfo*)(b+32));
            }
        }
        internal struct ReadRenderTargetPixel_method {
            static internal IntPtr ReadRenderTargetPixel_ptr;
            static ReadRenderTargetPixel_method() {
                ReadRenderTargetPixel_ptr = Main.GetMethodUFunction(KismetRenderingLibrary.StaticClass, "ReadRenderTargetPixel");
            }

            internal static unsafe Color Invoke(UObject WorldContextObject, TextureRenderTarget2D TextureRenderTarget, int X, int Y) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = TextureRenderTarget;
                *((int*)(b+16)) = X;
                *((int*)(b+20)) = Y;
                Main.GetProcessEvent(KismetRenderingLibrary.DefaultObject, ReadRenderTargetPixel_ptr, new IntPtr(p)); ;
                return *((Color*)(b+24));
            }
        }
        internal struct ReadRenderTargetRawPixel_method {
            static internal IntPtr ReadRenderTargetRawPixel_ptr;
            static ReadRenderTargetRawPixel_method() {
                ReadRenderTargetRawPixel_ptr = Main.GetMethodUFunction(KismetRenderingLibrary.StaticClass, "ReadRenderTargetRawPixel");
            }

            internal static unsafe LinearColor Invoke(UObject WorldContextObject, TextureRenderTarget2D TextureRenderTarget, int X, int Y) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = TextureRenderTarget;
                *((int*)(b+16)) = X;
                *((int*)(b+20)) = Y;
                Main.GetProcessEvent(KismetRenderingLibrary.DefaultObject, ReadRenderTargetRawPixel_ptr, new IntPtr(p)); ;
                return *((LinearColor*)(b+24));
            }
        }
        internal struct ReadRenderTargetRawUV_method {
            static internal IntPtr ReadRenderTargetRawUV_ptr;
            static ReadRenderTargetRawUV_method() {
                ReadRenderTargetRawUV_ptr = Main.GetMethodUFunction(KismetRenderingLibrary.StaticClass, "ReadRenderTargetRawUV");
            }

            internal static unsafe LinearColor Invoke(UObject WorldContextObject, TextureRenderTarget2D TextureRenderTarget, float U, float V) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = TextureRenderTarget;
                *((float*)(b+16)) = U;
                *((float*)(b+20)) = V;
                Main.GetProcessEvent(KismetRenderingLibrary.DefaultObject, ReadRenderTargetRawUV_ptr, new IntPtr(p)); ;
                return *((LinearColor*)(b+24));
            }
        }
        internal struct ReadRenderTargetUV_method {
            static internal IntPtr ReadRenderTargetUV_ptr;
            static ReadRenderTargetUV_method() {
                ReadRenderTargetUV_ptr = Main.GetMethodUFunction(KismetRenderingLibrary.StaticClass, "ReadRenderTargetUV");
            }

            internal static unsafe Color Invoke(UObject WorldContextObject, TextureRenderTarget2D TextureRenderTarget, float U, float V) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = TextureRenderTarget;
                *((float*)(b+16)) = U;
                *((float*)(b+20)) = V;
                Main.GetProcessEvent(KismetRenderingLibrary.DefaultObject, ReadRenderTargetUV_ptr, new IntPtr(p)); ;
                return *((Color*)(b+24));
            }
        }
        internal struct ReleaseRenderTarget2D_method {
            static internal IntPtr ReleaseRenderTarget2D_ptr;
            static ReleaseRenderTarget2D_method() {
                ReleaseRenderTarget2D_ptr = Main.GetMethodUFunction(KismetRenderingLibrary.StaticClass, "ReleaseRenderTarget2D");
            }

            internal static unsafe void Invoke(TextureRenderTarget2D TextureRenderTarget) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = TextureRenderTarget;
                Main.GetProcessEvent(KismetRenderingLibrary.DefaultObject, ReleaseRenderTarget2D_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RenderTargetCreateStaticTexture2DEditorOnly_method {
            static internal IntPtr RenderTargetCreateStaticTexture2DEditorOnly_ptr;
            static RenderTargetCreateStaticTexture2DEditorOnly_method() {
                RenderTargetCreateStaticTexture2DEditorOnly_ptr = Main.GetMethodUFunction(KismetRenderingLibrary.StaticClass, "RenderTargetCreateStaticTexture2DEditorOnly");
            }

            internal static unsafe Texture2D Invoke(TextureRenderTarget2D RenderTarget, string Name, byte CompressionSettings, byte MipSettings) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = RenderTarget;
                var Name_handle = GCHandle.Alloc(Name, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = Name_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = Name.Length;
                *(int*)(b+IntPtr.Size+4+8) = Name.Length;
                *(b+24) = CompressionSettings;
                *(b+25) = MipSettings;
                Main.GetProcessEvent(KismetRenderingLibrary.DefaultObject, RenderTargetCreateStaticTexture2DEditorOnly_ptr, new IntPtr(p)); ;
                Name_handle.Free();
                return *((IntPtr*)(b+32));
            }
        }
    }
    internal unsafe struct KismetRenderingLibrary_events {
    }
}
