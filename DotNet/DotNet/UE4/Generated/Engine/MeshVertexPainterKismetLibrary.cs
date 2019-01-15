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
    ///<summary>Mesh Vertex Painter Kismet Library</summary>
    public unsafe partial class MeshVertexPainterKismetLibrary : BlueprintFunctionLibrary  {

        ///<summary>Paints vertex colors on a mesh component lerping from the start to the end color along the specified axis.</summary>
        public static void PaintVerticesLerpAlongAxis(StaticMeshComponent StaticMeshComponent, LinearColor StartColor, LinearColor EndColor, EVertexPaintAxis Axis, bool bConvertToSRGB)  => 
            MeshVertexPainterKismetLibrary_methods.PaintVerticesLerpAlongAxis_method.Invoke(StaticMeshComponent, StartColor, EndColor, Axis, bConvertToSRGB);

        ///<summary>Paints vertex colors on a mesh component in a specified color.</summary>
        public static void PaintVerticesSingleColor(StaticMeshComponent StaticMeshComponent, LinearColor FillColor, bool bConvertToSRGB)  => 
            MeshVertexPainterKismetLibrary_methods.PaintVerticesSingleColor_method.Invoke(StaticMeshComponent, FillColor, bConvertToSRGB);

        ///<summary>Removes vertex colors on a mesh component</summary>
        public static void RemovePaintedVertices(StaticMeshComponent StaticMeshComponent)  => 
            MeshVertexPainterKismetLibrary_methods.RemovePaintedVertices_method.Invoke(StaticMeshComponent);
        static MeshVertexPainterKismetLibrary() {
            StaticClass = Main.GetClass("MeshVertexPainterKismetLibrary");
        }
        internal unsafe MeshVertexPainterKismetLibrary_fields* MeshVertexPainterKismetLibrary_ptr => (MeshVertexPainterKismetLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MeshVertexPainterKismetLibrary(IntPtr p) => UObject.Make<MeshVertexPainterKismetLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MeshVertexPainterKismetLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MeshVertexPainterKismetLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
