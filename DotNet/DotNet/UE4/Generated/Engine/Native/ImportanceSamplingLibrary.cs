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
    internal unsafe struct ImportanceSamplingLibrary_fields {
    }
    internal unsafe struct ImportanceSamplingLibrary_methods {
        internal struct BreakImportanceTexture_method {
            static internal IntPtr BreakImportanceTexture_ptr;
            static BreakImportanceTexture_method() {
                BreakImportanceTexture_ptr = Main.GetMethodUFunction(ImportanceSamplingLibrary.StaticClass, "BreakImportanceTexture");
            }

            internal static unsafe (Texture2D, byte) Invoke(ImportanceTexture ImportanceTexture) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((ImportanceTexture*)(b+0)) = ImportanceTexture;
                Main.GetProcessEvent(ImportanceSamplingLibrary.DefaultObject, BreakImportanceTexture_ptr, new IntPtr(p)); ;
                return (*((IntPtr*)(b+80)),*(b+88));
            }
        }
        internal struct ImportanceSample_method {
            static internal IntPtr ImportanceSample_ptr;
            static ImportanceSample_method() {
                ImportanceSample_ptr = Main.GetMethodUFunction(ImportanceSamplingLibrary.StaticClass, "ImportanceSample");
            }

            internal static unsafe (Vector2D, LinearColor, float, float) Invoke(ImportanceTexture Texture, Vector2D Rand, int Samples, float Intensity) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((ImportanceTexture*)(b+0)) = Texture;
                *((Vector2D*)(b+80)) = Rand;
                *((int*)(b+88)) = Samples;
                *((float*)(b+92)) = Intensity;
                Main.GetProcessEvent(ImportanceSamplingLibrary.DefaultObject, ImportanceSample_ptr, new IntPtr(p)); ;
                return (*((Vector2D*)(b+96)),*((LinearColor*)(b+104)),*((float*)(b+120)),*((float*)(b+124)));
            }
        }
        internal struct MakeImportanceTexture_method {
            static internal IntPtr MakeImportanceTexture_ptr;
            static MakeImportanceTexture_method() {
                MakeImportanceTexture_ptr = Main.GetMethodUFunction(ImportanceSamplingLibrary.StaticClass, "MakeImportanceTexture");
            }

            internal static unsafe ImportanceTexture Invoke(Texture2D Texture, byte WeightingFunc) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Texture;
                *(b+8) = WeightingFunc;
                Main.GetProcessEvent(ImportanceSamplingLibrary.DefaultObject, MakeImportanceTexture_ptr, new IntPtr(p)); ;
                return *((ImportanceTexture*)(b+16));
            }
        }
        internal struct NextSobolCell2D_method {
            static internal IntPtr NextSobolCell2D_ptr;
            static NextSobolCell2D_method() {
                NextSobolCell2D_ptr = Main.GetMethodUFunction(ImportanceSamplingLibrary.StaticClass, "NextSobolCell2D");
            }

            internal static unsafe Vector2D Invoke(int Index, int NumCells, Vector2D PreviousValue) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Index;
                *((int*)(b+4)) = NumCells;
                *((Vector2D*)(b+8)) = PreviousValue;
                Main.GetProcessEvent(ImportanceSamplingLibrary.DefaultObject, NextSobolCell2D_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+16));
            }
        }
        internal struct NextSobolCell3D_method {
            static internal IntPtr NextSobolCell3D_ptr;
            static NextSobolCell3D_method() {
                NextSobolCell3D_ptr = Main.GetMethodUFunction(ImportanceSamplingLibrary.StaticClass, "NextSobolCell3D");
            }

            internal static unsafe Vector Invoke(int Index, int NumCells, Vector PreviousValue) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Index;
                *((int*)(b+4)) = NumCells;
                *((Vector*)(b+8)) = PreviousValue;
                Main.GetProcessEvent(ImportanceSamplingLibrary.DefaultObject, NextSobolCell3D_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+20));
            }
        }
        internal struct NextSobolFloat_method {
            static internal IntPtr NextSobolFloat_ptr;
            static NextSobolFloat_method() {
                NextSobolFloat_ptr = Main.GetMethodUFunction(ImportanceSamplingLibrary.StaticClass, "NextSobolFloat");
            }

            internal static unsafe float Invoke(int Index, int Dimension, float PreviousValue) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Index;
                *((int*)(b+4)) = Dimension;
                *((float*)(b+8)) = PreviousValue;
                Main.GetProcessEvent(ImportanceSamplingLibrary.DefaultObject, NextSobolFloat_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct RandomSobolCell2D_method {
            static internal IntPtr RandomSobolCell2D_ptr;
            static RandomSobolCell2D_method() {
                RandomSobolCell2D_ptr = Main.GetMethodUFunction(ImportanceSamplingLibrary.StaticClass, "RandomSobolCell2D");
            }

            internal static unsafe Vector2D Invoke(int Index, int NumCells, Vector2D Cell, Vector2D Seed) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Index;
                *((int*)(b+4)) = NumCells;
                *((Vector2D*)(b+8)) = Cell;
                *((Vector2D*)(b+16)) = Seed;
                Main.GetProcessEvent(ImportanceSamplingLibrary.DefaultObject, RandomSobolCell2D_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+24));
            }
        }
        internal struct RandomSobolCell3D_method {
            static internal IntPtr RandomSobolCell3D_ptr;
            static RandomSobolCell3D_method() {
                RandomSobolCell3D_ptr = Main.GetMethodUFunction(ImportanceSamplingLibrary.StaticClass, "RandomSobolCell3D");
            }

            internal static unsafe Vector Invoke(int Index, int NumCells, Vector Cell, Vector Seed) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Index;
                *((int*)(b+4)) = NumCells;
                *((Vector*)(b+8)) = Cell;
                *((Vector*)(b+20)) = Seed;
                Main.GetProcessEvent(ImportanceSamplingLibrary.DefaultObject, RandomSobolCell3D_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+32));
            }
        }
        internal struct RandomSobolFloat_method {
            static internal IntPtr RandomSobolFloat_ptr;
            static RandomSobolFloat_method() {
                RandomSobolFloat_ptr = Main.GetMethodUFunction(ImportanceSamplingLibrary.StaticClass, "RandomSobolFloat");
            }

            internal static unsafe float Invoke(int Index, int Dimension, float Seed) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Index;
                *((int*)(b+4)) = Dimension;
                *((float*)(b+8)) = Seed;
                Main.GetProcessEvent(ImportanceSamplingLibrary.DefaultObject, RandomSobolFloat_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
    }
    internal unsafe struct ImportanceSamplingLibrary_events {
    }
}
