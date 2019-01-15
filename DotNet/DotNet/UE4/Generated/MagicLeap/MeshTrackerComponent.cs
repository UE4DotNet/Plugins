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

        ///<summary>Force an update on a non-live updating mesh tracker.</summary>
        public bool ForceMeshUpdate()  => 
            MeshTrackerComponent_methods.ForceMeshUpdate_method.Invoke(ObjPointer);
         //TODO: multicast delegate FOnMeshTrackerUpdated OnMeshTrackerUpdated
        public bool ScanWorld {
            get {return Main.GetGetBoolPropertyByName(this, "ScanWorld"); }
            set {Main.SetGetBoolPropertyByName(this, "ScanWorld", value); }
        }
         //TODO: enum EMeshType MeshType
        ///<summary>Specifies the time (in seconds) to query if new mesh data is available.</summary>
        ///<remarks>Decreasing this time may give more mesh data, but may degrade performance. Use 0 to turn off auto updating.</remarks>
        public unsafe float MeshingPollTime {
            get {return MeshTrackerComponent_ptr->MeshingPollTime;}
            set {MeshTrackerComponent_ptr->MeshingPollTime = value;}
        }
        ///<summary>Bounding box for the mesh scan. The mesh will be scanned for only within this box.</summary>
        public unsafe BoxComponent BoundingVolume {
            get {return MeshTrackerComponent_ptr->BoundingVolume;}
            set {MeshTrackerComponent_ptr->BoundingVolume = value;}
        }
        public bool IgnoreBoundingVolume {
            get {return Main.GetGetBoolPropertyByName(this, "IgnoreBoundingVolume"); }
            set {Main.SetGetBoolPropertyByName(this, "IgnoreBoundingVolume", value); }
        }
        ///<summary>Maximum number of triangles allowed for the mesh in Full mode, or per mesh block in Blocks mode.</summary>
        ///<remarks>
        ///Use 0 to turn off simplification.
        ///Setting this to a reasonably high enough number because of target hardware limitation. It is recommended to leave this number as low as possible but never 0.
        ///</remarks>
        public unsafe int TargetNumberTriangles {
            get {return MeshTrackerComponent_ptr->TargetNumberTriangles;}
            set {MeshTrackerComponent_ptr->TargetNumberTriangles = value;}
        }
        public bool FillGaps {
            get {return Main.GetGetBoolPropertyByName(this, "FillGaps"); }
            set {Main.SetGetBoolPropertyByName(this, "FillGaps", value); }
        }
        ///<summary>The perimeter (in Unreal Units) of gaps to be filled.</summary>
        public unsafe float PerimeterOfGapsToFill {
            get {return MeshTrackerComponent_ptr->PerimeterOfGapsToFill;}
            set {MeshTrackerComponent_ptr->PerimeterOfGapsToFill = value;}
        }
        public bool Planarize {
            get {return Main.GetGetBoolPropertyByName(this, "Planarize"); }
            set {Main.SetGetBoolPropertyByName(this, "Planarize", value); }
        }
        public bool RemoveDisconnectedSections {
            get {return Main.GetGetBoolPropertyByName(this, "RemoveDisconnectedSections"); }
            set {Main.SetGetBoolPropertyByName(this, "RemoveDisconnectedSections", value); }
        }
        ///<summary>Any section that is disconnected from the main mesh and has an area (in Unreal Units squared) less than this value will be removed.</summary>
        public unsafe float DisconnectedSectionArea {
            get {return MeshTrackerComponent_ptr->DisconnectedSectionArea;}
            set {MeshTrackerComponent_ptr->DisconnectedSectionArea = value;}
        }
        ///<summary>Minimum distance that a bounding box has to move to cause a rescan.</summary>
        public unsafe float MinDistanceRescan {
            get {return MeshTrackerComponent_ptr->MinDistanceRescan;}
            set {MeshTrackerComponent_ptr->MinDistanceRescan = value;}
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
