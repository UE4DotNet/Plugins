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
    ///<summary>Importance Sampling Library</summary>
    public unsafe partial class ImportanceSamplingLibrary : BlueprintFunctionLibrary  {

        ///<summary>
        ///Get texture used to create an ImportanceTexture object
        ///@
        ///</summary>
        ///<remarks>
        ///param ImportanceTexture - The source ImportanceTexture object
        ///@outparam Texture - Texture object for this ImportanceTexture.
        ///@param WeightingFunc - How to turn the texture data into probability weights
        ///@return new ImportanceTexture object for use with ImportanceSample
        ///</remarks>
        public static (Texture2D, byte) BreakImportanceTexture(ImportanceTexture ImportanceTexture)  => 
            ImportanceSamplingLibrary_methods.BreakImportanceTexture_method.Invoke(ImportanceTexture);

        ///<summary>Distribute sample points proportional to Texture2D luminance.</summary>
        ///<remarks>
        ///@param Rand - Random 2D point with components evenly distributed between 0 and 1
        ///@param Samples - Total number of samples that will be used
        ///@param Intensity - Total intensity for light
        ///@outparam SamplePosition - Importance sampled 2D output texture coordinate (0-1)
        ///@outparam SampleColor - Representative color near Position from MIP level for SampleSize
        ///@outparam SampleIntensity - Intensity of individual points, scaled by probability and number of samples
        ///@outparam SampleSize - Local density of points near Position (scaled for 1x1 texture space)
        ///</remarks>
        public static (Vector2D, LinearColor, float, float) ImportanceSample(ImportanceTexture Texture, Vector2D Rand, int Samples, float Intensity)  => 
            ImportanceSamplingLibrary_methods.ImportanceSample_method.Invoke(Texture, Rand, Samples, Intensity);

        ///<summary>
        ///Create an FImportanceTexture object for texture-driven importance sampling from a 2D RGBA8 texture
        ///@
        ///</summary>
        ///<remarks>
        ///param Texture - Texture object to use. Must be RGBA8 format.
        ///@param WeightingFunc - How to turn the texture data into probability weights
        ///@return new ImportanceTexture object for use with ImportanceSample
        ///</remarks>
        public static ImportanceTexture MakeImportanceTexture(Texture2D Texture, byte WeightingFunc)  => 
            ImportanceSamplingLibrary_methods.MakeImportanceTexture_method.Invoke(Texture, WeightingFunc);

        ///<summary>@</summary>
        ///<remarks>
        ///param Index - Which sequential point
        ///@param NumCells - Size of cell grid, 1 to 32768. Rounded up to the next power of two
        ///@param PreviousValue - The Sobol value for Index-1
        ///@return Sobol-distributed random 2D position in the same grid cell
        ///</remarks>
        public static Vector2D NextSobolCell2D(int Index, int NumCells, Vector2D PreviousValue)  => 
            ImportanceSamplingLibrary_methods.NextSobolCell2D_method.Invoke(Index, NumCells, PreviousValue);

        ///<summary>@</summary>
        ///<remarks>
        ///param Index - Which sequential point
        ///@param NumCells - Size of cell grid, 1 to 1024. Rounded up to the next power of two
        ///@param PreviousValue - The Sobol value for Index-1
        ///@return Sobol-distributed random 3D position in the same grid cell
        ///</remarks>
        public static Vector NextSobolCell3D(int Index, int NumCells, Vector PreviousValue)  => 
            ImportanceSamplingLibrary_methods.NextSobolCell3D_method.Invoke(Index, NumCells, PreviousValue);

        ///<summary>@</summary>
        ///<remarks>
        ///param Index - Which sequential point
        ///@param Dimension - Which Sobol dimension (0 to 15)
        ///@param PreviousValue - The Sobol value for Index-1
        ///@return Sobol-distributed random number between 0 and 1
        ///</remarks>
        public static float NextSobolFloat(int Index, int Dimension, float PreviousValue)  => 
            ImportanceSamplingLibrary_methods.NextSobolFloat_method.Invoke(Index, Dimension, PreviousValue);

        ///<summary>@</summary>
        ///<remarks>
        ///param Index - Which sequential point in the cell (starting at 0)
        ///@param NumCells - Size of cell grid, 1 to 32768. Rounded up to the next power of two
        ///@param Cell - Give a point from this integer grid cell
        ///@param Seed - Random 2D seed (components in the range 0-1) to randomize across multiple sequences
        ///@return Sobol-distributed random 2D position in the given grid cell
        ///</remarks>
        public static Vector2D RandomSobolCell2D(int Index, int NumCells, Vector2D Cell, Vector2D Seed)  => 
            ImportanceSamplingLibrary_methods.RandomSobolCell2D_method.Invoke(Index, NumCells, Cell, Seed);

        ///<summary>@</summary>
        ///<remarks>
        ///param Index - Which sequential point in the cell (starting at 0)
        ///@param NumCells - Size of cell grid, 1 to 1024. Rounded up to the next power of two
        ///@param Cell - Give a point from this integer grid cell
        ///@param Seed - Random 3D seed (components in the range 0-1) to randomize across multiple sequences
        ///@return Sobol-distributed random 3D vector in the given grid cell
        ///</remarks>
        public static Vector RandomSobolCell3D(int Index, int NumCells, Vector Cell, Vector Seed)  => 
            ImportanceSamplingLibrary_methods.RandomSobolCell3D_method.Invoke(Index, NumCells, Cell, Seed);

        ///<summary>@</summary>
        ///<remarks>
        ///param Index - Which sequential point
        ///@param Dimension - Which Sobol dimension (0 to 15)
        ///@param Seed - Random seed (in the range 0-1) to randomize across multiple sequences
        ///@return Sobol-distributed random number between 0 and 1
        ///</remarks>
        public static float RandomSobolFloat(int Index, int Dimension, float Seed)  => 
            ImportanceSamplingLibrary_methods.RandomSobolFloat_method.Invoke(Index, Dimension, Seed);
        static ImportanceSamplingLibrary() {
            StaticClass = Main.GetClass("ImportanceSamplingLibrary");
        }
        internal unsafe ImportanceSamplingLibrary_fields* ImportanceSamplingLibrary_ptr => (ImportanceSamplingLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ImportanceSamplingLibrary(IntPtr p) => UObject.Make<ImportanceSamplingLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ImportanceSamplingLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ImportanceSamplingLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
