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
using UE4.StatsViewer.Native;

namespace UE4.StatsViewer {
    ///<summary>Statistics page for primitives.</summary>
    public unsafe partial class PrimitiveStats : UObject  {
         //TODO: weak object TWeakObjectPtr<UObject> UObject
         //TODO: array not UObject TArray Actors
         //TODO: string FString Type
        ///<summary>Number of occurrences in map</summary>
        public unsafe int Count {
            get {return PrimitiveStats_ptr->Count;}
            set {PrimitiveStats_ptr->Count = value;}
        }
        ///<summary>Section count of mesh</summary>
        public unsafe int Sections {
            get {return PrimitiveStats_ptr->Sections;}
            set {PrimitiveStats_ptr->Sections = value;}
        }
        ///<summary>Hardware instances</summary>
        public unsafe int HWInstances {
            get {return PrimitiveStats_ptr->HWInstances;}
            set {PrimitiveStats_ptr->HWInstances = value;}
        }
        ///<summary>Instanced section count of mesh</summary>
        public unsafe int InstSections {
            get {return PrimitiveStats_ptr->InstSections;}
            set {PrimitiveStats_ptr->InstSections = value;}
        }
        ///<summary>Triangle count of mesh</summary>
        public unsafe int Triangles {
            get {return PrimitiveStats_ptr->Triangles;}
            set {PrimitiveStats_ptr->Triangles = value;}
        }
        ///<summary>Triangle count of all mesh occurances (Count * Tris)</summary>
        public unsafe int InstTriangles {
            get {return PrimitiveStats_ptr->InstTriangles;}
            set {PrimitiveStats_ptr->InstTriangles = value;}
        }
        ///<summary>Resource size in KB</summary>
        public unsafe float ResourceSize {
            get {return PrimitiveStats_ptr->ResourceSize;}
            set {PrimitiveStats_ptr->ResourceSize = value;}
        }
        ///<summary>Vertex color stat for static and skeletal meshes in KB</summary>
        public unsafe float VertexColorMem {
            get {return PrimitiveStats_ptr->VertexColorMem;}
            set {PrimitiveStats_ptr->VertexColorMem = value;}
        }
        ///<summary>Per component vertex color stat for static meshes in KB</summary>
        public unsafe float InstVertexColorMem {
            get {return PrimitiveStats_ptr->InstVertexColorMem;}
            set {PrimitiveStats_ptr->InstVertexColorMem = value;}
        }
        ///<summary>Average number of lightmap lights relevant to each instance</summary>
        public unsafe int LightsLM {
            get {return PrimitiveStats_ptr->LightsLM;}
            set {PrimitiveStats_ptr->LightsLM = value;}
        }
        ///<summary>Average number of other lights relevant to each instance</summary>
        public unsafe float LightsOther {
            get {return PrimitiveStats_ptr->LightsOther;}
            set {PrimitiveStats_ptr->LightsOther = value;}
        }
        ///<summary>(Avg OL + Avg LM) / Count</summary>
        public unsafe float LightsTotal {
            get {return PrimitiveStats_ptr->LightsTotal;}
            set {PrimitiveStats_ptr->LightsTotal = value;}
        }
        ///<summary>Avg OL * Sections</summary>
        public unsafe float ObjLightCost {
            get {return PrimitiveStats_ptr->ObjLightCost;}
            set {PrimitiveStats_ptr->ObjLightCost = value;}
        }
        ///<summary>Light map data in KB</summary>
        public unsafe float LightMapData {
            get {return PrimitiveStats_ptr->LightMapData;}
            set {PrimitiveStats_ptr->LightMapData = value;}
        }
        ///<summary>Light/shadow map resolution</summary>
        public unsafe float LMSMResolution {
            get {return PrimitiveStats_ptr->LMSMResolution;}
            set {PrimitiveStats_ptr->LMSMResolution = value;}
        }
        ///<summary>Minimum radius of bounding sphere of instance in map</summary>
        public unsafe float RadiusMin {
            get {return PrimitiveStats_ptr->RadiusMin;}
            set {PrimitiveStats_ptr->RadiusMin = value;}
        }
        ///<summary>Maximum radius of bounding sphere of instance in map</summary>
        public unsafe float RadiusMax {
            get {return PrimitiveStats_ptr->RadiusMax;}
            set {PrimitiveStats_ptr->RadiusMax = value;}
        }
        ///<summary>Average radius of bounding sphere of instance in map</summary>
        public unsafe float RadiusAvg {
            get {return PrimitiveStats_ptr->RadiusAvg;}
            set {PrimitiveStats_ptr->RadiusAvg = value;}
        }
        static PrimitiveStats() {
            StaticClass = Main.GetClass("PrimitiveStats");
        }
        internal unsafe PrimitiveStats_fields* PrimitiveStats_ptr => (PrimitiveStats_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PrimitiveStats(IntPtr p) => UObject.Make<PrimitiveStats>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PrimitiveStats DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PrimitiveStats New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
