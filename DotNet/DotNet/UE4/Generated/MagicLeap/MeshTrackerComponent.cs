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
using UE4.MagicLeap.Native;
using UE4.MRMesh;
using UE4.Engine;

namespace UE4.MagicLeap {
    ///<summary>
    ///The MeshTrackerComponent class manages requests for environmental mesh data, processes the results and provides
    ///them to the calling system.
    ///</summary>
    ///<remarks>
    ///The calling system is able request environmental mesh data within a specified area.
    ///Various other search criteria can be set via this class's public properties.  Mesh data requests are processed
    ///on a separate thread.  Once a mesh data request has been processed the calling system will be notified via an
    ///FOnMeshTrackerUpdated broadcast.
    ///</remarks>
    public unsafe partial class MeshTrackerComponent : SceneComponent  {

        ///<summary>Sets the procedural mesh component that will store and display the environmental mesh results.</summary>
        ///<remarks>
        ///@param InMRMeshPtr The procedural mesh component to store the query result in.
        ///</remarks>
        public void ConnectMRMesh(MRMeshComponent InMRMeshPtr)  => 
            MeshTrackerComponent_methods.ConnectMRMesh_method.Invoke(ObjPointer, InMRMeshPtr);

        ///<summary>Unlinks the current procedural mesh component from the mesh tracking system.</summary>
        ///<remarks>
        ///@param InMRMeshPtr The procedural mesh component to unlink from the mesh tracking system.
        ///</remarks>
        public void DisconnectMRMesh(MRMeshComponent InMRMeshPtr)  => 
            MeshTrackerComponent_methods.DisconnectMRMesh_method.Invoke(ObjPointer, InMRMeshPtr);
         //TODO: multicast delegate FOnMeshTrackerUpdated OnMeshTrackerUpdated
        public bool ScanWorld {
            get {return Main.GetGetBoolPropertyByName(this, "ScanWorld"); }
            set {Main.SetGetBoolPropertyByName(this, "ScanWorld", value); }
        }
         //TODO: enum EMeshType MeshType
        ///<summary>Bounding box for the mesh scan. The mesh will be scanned for only within this box.</summary>
        public unsafe BoxComponent BoundingVolume {
            get {return MeshTrackerComponent_ptr->BoundingVolume;}
            set {MeshTrackerComponent_ptr->BoundingVolume = value;}
        }
         //TODO: enum EMeshLOD LevelOfDetail
        ///<summary>The perimeter (in Unreal Units) of gaps to be filled. 0 means do not fill. A good value is 300cm.</summary>
        public unsafe float PerimeterOfGapsToFill {
            get {return MeshTrackerComponent_ptr->PerimeterOfGapsToFill;}
            set {MeshTrackerComponent_ptr->PerimeterOfGapsToFill = value;}
        }
        public bool Planarize {
            get {return Main.GetGetBoolPropertyByName(this, "Planarize"); }
            set {Main.SetGetBoolPropertyByName(this, "Planarize", value); }
        }
        ///<summary>
        ///Any section that is disconnected from the main mesh and has an area (in Unreal Units squared)
        ///          less than this value will be removed.
        ///</summary>
        ///<remarks>0 means do not remove disconnected sections. A good value is 50cm.</remarks>
        public unsafe float DisconnectedSectionArea {
            get {return MeshTrackerComponent_ptr->DisconnectedSectionArea;}
            set {MeshTrackerComponent_ptr->DisconnectedSectionArea = value;}
        }
        public bool RequestNormals {
            get {return Main.GetGetBoolPropertyByName(this, "RequestNormals"); }
            set {Main.SetGetBoolPropertyByName(this, "RequestNormals", value); }
        }
        public bool RequestVertexConfidence {
            get {return Main.GetGetBoolPropertyByName(this, "RequestVertexConfidence"); }
            set {Main.SetGetBoolPropertyByName(this, "RequestVertexConfidence", value); }
        }
         //TODO: enum EMLMeshVertexColorMode VertexColorMode
         //TODO: array not UObject TArray BlockVertexColors
        ///<summary>Color mapped to confidence value of zero.</summary>
        public unsafe LinearColor VertexColorFromConfidenceZero {
            get {return MeshTrackerComponent_ptr->VertexColorFromConfidenceZero;}
            set {MeshTrackerComponent_ptr->VertexColorFromConfidenceZero = value;}
        }
        ///<summary>Color mapped to confidence value of one.</summary>
        public unsafe LinearColor VertexColorFromConfidenceOne {
            get {return MeshTrackerComponent_ptr->VertexColorFromConfidenceOne;}
            set {MeshTrackerComponent_ptr->VertexColorFromConfidenceOne = value;}
        }
        public bool RemoveOverlappingTriangles {
            get {return Main.GetGetBoolPropertyByName(this, "RemoveOverlappingTriangles"); }
            set {Main.SetGetBoolPropertyByName(this, "RemoveOverlappingTriangles", value); }
        }
        ///<summary>MRMeshComponent can render and provide collision based on the Mesh data.</summary>
        public unsafe MRMeshComponent MRMesh {
            get {return MeshTrackerComponent_ptr->MRMesh;}
            set {MeshTrackerComponent_ptr->MRMesh = value;}
        }
        static MeshTrackerComponent() {
            StaticClass = Main.GetClass("MeshTrackerComponent");
        }
        internal unsafe MeshTrackerComponent_fields* MeshTrackerComponent_ptr => (MeshTrackerComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MeshTrackerComponent(IntPtr p) => UObject.Make<MeshTrackerComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MeshTrackerComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MeshTrackerComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
