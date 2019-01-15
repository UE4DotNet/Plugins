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

using UE4.MeshDescription;
using UE4.Engine;

namespace UE4.EditableMesh.Native {
    [StructLayout( LayoutKind.Explicit, Size=4224 )]
    internal unsafe struct EditableMesh_fields {
        [FieldOffset(3464)] public NativeArray Adapters;
        [FieldOffset(3480)] public int TextureCoordinateCount;
        [FieldOffset(3732)] public int PendingCompactCounter;
        [FieldOffset(3736)] public int SubdivisionCount;
    }
    internal unsafe struct EditableMesh_methods {
        internal struct AnyChangesToUndo_method {
            static internal IntPtr AnyChangesToUndo_ptr;
            static AnyChangesToUndo_method() {
                AnyChangesToUndo_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "AnyChangesToUndo");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, AnyChangesToUndo_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct AssignPolygonsToPolygonGroups_method {
            static internal IntPtr AssignPolygonsToPolygonGroups_ptr;
            static AssignPolygonsToPolygonGroups_method() {
                AssignPolygonsToPolygonGroups_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "AssignPolygonsToPolygonGroups");
            }

            internal static unsafe void Invoke(IntPtr obj, byte PolygonGroupForPolygons /*TODO: array TArray */, bool bDeleteOrphanedPolygonGroups) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray PolygonGroupForPolygons
                *((bool*)(b+16)) = bDeleteOrphanedPolygonGroups;
                Main.GetProcessEvent(obj, AssignPolygonsToPolygonGroups_ptr, new IntPtr(p)); ;
                 //TODO: array TArray PolygonGroupForPolygons
            }
        }
        internal struct BevelPolygons_method {
            static internal IntPtr BevelPolygons_ptr;
            static BevelPolygons_method() {
                BevelPolygons_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "BevelPolygons");
            }

            internal static unsafe (IReadOnlyCollection<PolygonID>, IReadOnlyCollection<PolygonID>) Invoke(IntPtr obj, byte PolygonIDs /*TODO: array TArray */, float BevelFixedDistance, float BevelProgressTowardCenter) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray PolygonIDs
                *((float*)(b+16)) = BevelFixedDistance;
                *((float*)(b+20)) = BevelProgressTowardCenter;
                Main.GetProcessEvent(obj, BevelPolygons_ptr, new IntPtr(p)); ;
                 //TODO: array TArray PolygonIDs
                 //TODO: array TArray OutNewCenterPolygonIDs
                 //TODO: array TArray OutNewSidePolygonIDs
                return (UObject.ToUnmangedCollection<PolygonID>(b+24),UObject.ToUnmangedCollection<PolygonID>(b+40));
            }
        }
        internal struct ChangePolygonsVertexInstances_method {
            static internal IntPtr ChangePolygonsVertexInstances_ptr;
            static ChangePolygonsVertexInstances_method() {
                ChangePolygonsVertexInstances_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "ChangePolygonsVertexInstances");
            }

            internal static unsafe void Invoke(IntPtr obj, byte VertexInstancesForPolygons /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray VertexInstancesForPolygons
                Main.GetProcessEvent(obj, ChangePolygonsVertexInstances_ptr, new IntPtr(p)); ;
                 //TODO: array TArray VertexInstancesForPolygons
            }
        }
        internal struct Commit_method {
            static internal IntPtr Commit_ptr;
            static Commit_method() {
                Commit_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "Commit");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Commit_ptr, new IntPtr(p)); ;
            }
        }
        internal struct CommitInstance_method {
            static internal IntPtr CommitInstance_ptr;
            static CommitInstance_method() {
                CommitInstance_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "CommitInstance");
            }

            internal static unsafe UE4.EditableMesh.EditableMesh Invoke(IntPtr obj, PrimitiveComponent ComponentToInstanceTo) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ComponentToInstanceTo;
                Main.GetProcessEvent(obj, CommitInstance_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct ComputeBarycentricWeightForPointOnPolygon_method {
            static internal IntPtr ComputeBarycentricWeightForPointOnPolygon_ptr;
            static ComputeBarycentricWeightForPointOnPolygon_method() {
                ComputeBarycentricWeightForPointOnPolygon_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "ComputeBarycentricWeightForPointOnPolygon");
            }

            internal static unsafe (MeshTriangle, Vector, bool) Invoke(IntPtr obj, PolygonID PolygonID, Vector PointOnPolygon) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                *((Vector*)(b+4)) = PointOnPolygon;
                Main.GetProcessEvent(obj, ComputeBarycentricWeightForPointOnPolygon_ptr, new IntPtr(p)); ;
                return (*((MeshTriangle*)(b+16)),*((Vector*)(b+28)),*((bool*)(b+40)));
            }
        }
        internal struct ComputeBoundingBox_method {
            static internal IntPtr ComputeBoundingBox_ptr;
            static ComputeBoundingBox_method() {
                ComputeBoundingBox_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "ComputeBoundingBox");
            }

            internal static unsafe Box Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ComputeBoundingBox_ptr, new IntPtr(p)); ;
                return *((Box*)(b+0));
            }
        }
        internal struct ComputeBoundingBoxAndSphere_method {
            static internal IntPtr ComputeBoundingBoxAndSphere_ptr;
            static ComputeBoundingBoxAndSphere_method() {
                ComputeBoundingBoxAndSphere_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "ComputeBoundingBoxAndSphere");
            }

            internal static unsafe BoxSphereBounds Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ComputeBoundingBoxAndSphere_ptr, new IntPtr(p)); ;
                return *((BoxSphereBounds*)(b+0));
            }
        }
        internal struct ComputePolygonCenter_method {
            static internal IntPtr ComputePolygonCenter_ptr;
            static ComputePolygonCenter_method() {
                ComputePolygonCenter_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "ComputePolygonCenter");
            }

            internal static unsafe Vector Invoke(IntPtr obj, PolygonID PolygonID) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                Main.GetProcessEvent(obj, ComputePolygonCenter_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+4));
            }
        }
        internal struct ComputePolygonNormal_method {
            static internal IntPtr ComputePolygonNormal_ptr;
            static ComputePolygonNormal_method() {
                ComputePolygonNormal_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "ComputePolygonNormal");
            }

            internal static unsafe Vector Invoke(IntPtr obj, PolygonID PolygonID) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                Main.GetProcessEvent(obj, ComputePolygonNormal_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+4));
            }
        }
        internal struct ComputePolygonPlane_method {
            static internal IntPtr ComputePolygonPlane_ptr;
            static ComputePolygonPlane_method() {
                ComputePolygonPlane_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "ComputePolygonPlane");
            }

            internal static unsafe Plane Invoke(IntPtr obj, PolygonID PolygonID) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                Main.GetProcessEvent(obj, ComputePolygonPlane_ptr, new IntPtr(p)); ;
                return *((Plane*)(b+16));
            }
        }
        internal struct ComputePolygonsSharedEdges_method {
            static internal IntPtr ComputePolygonsSharedEdges_ptr;
            static ComputePolygonsSharedEdges_method() {
                ComputePolygonsSharedEdges_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "ComputePolygonsSharedEdges");
            }

            internal static unsafe IReadOnlyCollection<EdgeID> Invoke(IntPtr obj, byte PolygonIDs /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray PolygonIDs
                Main.GetProcessEvent(obj, ComputePolygonsSharedEdges_ptr, new IntPtr(p)); ;
                 //TODO: array TArray PolygonIDs
                 //TODO: array TArray OutSharedEdgeIDs
                return UObject.ToUnmangedCollection<EdgeID>(b+16);
            }
        }
        internal struct ComputePolygonTriangulation_method {
            static internal IntPtr ComputePolygonTriangulation_ptr;
            static ComputePolygonTriangulation_method() {
                ComputePolygonTriangulation_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "ComputePolygonTriangulation");
            }

            internal static unsafe IReadOnlyCollection<MeshTriangle> Invoke(IntPtr obj, PolygonID PolygonID) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                Main.GetProcessEvent(obj, ComputePolygonTriangulation_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutTriangles
                return UObject.ToUnmangedCollection<MeshTriangle>(b+8);
            }
        }
        internal struct CreateEdges_method {
            static internal IntPtr CreateEdges_ptr;
            static CreateEdges_method() {
                CreateEdges_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "CreateEdges");
            }

            internal static unsafe IReadOnlyCollection<EdgeID> Invoke(IntPtr obj, byte EdgesToCreate /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray EdgesToCreate
                Main.GetProcessEvent(obj, CreateEdges_ptr, new IntPtr(p)); ;
                 //TODO: array TArray EdgesToCreate
                 //TODO: array TArray OutNewEdgeIDs
                return UObject.ToUnmangedCollection<EdgeID>(b+16);
            }
        }
        internal struct CreateEmptyVertexRange_method {
            static internal IntPtr CreateEmptyVertexRange_ptr;
            static CreateEmptyVertexRange_method() {
                CreateEmptyVertexRange_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "CreateEmptyVertexRange");
            }

            internal static unsafe IReadOnlyCollection<VertexID> Invoke(IntPtr obj, int NumVerticesToCreate) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = NumVerticesToCreate;
                Main.GetProcessEvent(obj, CreateEmptyVertexRange_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutNewVertexIDs
                return UObject.ToUnmangedCollection<VertexID>(b+8);
            }
        }
        internal struct CreateMissingPolygonHoleEdges_method {
            static internal IntPtr CreateMissingPolygonHoleEdges_ptr;
            static CreateMissingPolygonHoleEdges_method() {
                CreateMissingPolygonHoleEdges_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "CreateMissingPolygonHoleEdges");
            }

            internal static unsafe IReadOnlyCollection<EdgeID> Invoke(IntPtr obj, PolygonID PolygonID, int HoleNumber) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                *((int*)(b+4)) = HoleNumber;
                Main.GetProcessEvent(obj, CreateMissingPolygonHoleEdges_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutNewEdgeIDs
                return UObject.ToUnmangedCollection<EdgeID>(b+8);
            }
        }
        internal struct CreateMissingPolygonPerimeterEdges_method {
            static internal IntPtr CreateMissingPolygonPerimeterEdges_ptr;
            static CreateMissingPolygonPerimeterEdges_method() {
                CreateMissingPolygonPerimeterEdges_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "CreateMissingPolygonPerimeterEdges");
            }

            internal static unsafe IReadOnlyCollection<EdgeID> Invoke(IntPtr obj, PolygonID PolygonID) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                Main.GetProcessEvent(obj, CreateMissingPolygonPerimeterEdges_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutNewEdgeIDs
                return UObject.ToUnmangedCollection<EdgeID>(b+8);
            }
        }
        internal struct CreatePolygonGroups_method {
            static internal IntPtr CreatePolygonGroups_ptr;
            static CreatePolygonGroups_method() {
                CreatePolygonGroups_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "CreatePolygonGroups");
            }

            internal static unsafe IReadOnlyCollection<PolygonGroupID> Invoke(IntPtr obj, byte PolygonGroupsToCreate /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray PolygonGroupsToCreate
                Main.GetProcessEvent(obj, CreatePolygonGroups_ptr, new IntPtr(p)); ;
                 //TODO: array TArray PolygonGroupsToCreate
                 //TODO: array TArray OutNewPolygonGroupIDs
                return UObject.ToUnmangedCollection<PolygonGroupID>(b+16);
            }
        }
        internal struct CreatePolygons_method {
            static internal IntPtr CreatePolygons_ptr;
            static CreatePolygons_method() {
                CreatePolygons_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "CreatePolygons");
            }

            internal static unsafe (IReadOnlyCollection<PolygonID>, IReadOnlyCollection<EdgeID>) Invoke(IntPtr obj, byte PolygonsToCreate /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray PolygonsToCreate
                Main.GetProcessEvent(obj, CreatePolygons_ptr, new IntPtr(p)); ;
                 //TODO: array TArray PolygonsToCreate
                 //TODO: array TArray OutNewPolygonIDs
                 //TODO: array TArray OutNewEdgeIDs
                return (UObject.ToUnmangedCollection<PolygonID>(b+16),UObject.ToUnmangedCollection<EdgeID>(b+32));
            }
        }
        internal struct CreateVertexInstances_method {
            static internal IntPtr CreateVertexInstances_ptr;
            static CreateVertexInstances_method() {
                CreateVertexInstances_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "CreateVertexInstances");
            }

            internal static unsafe IReadOnlyCollection<VertexInstanceID> Invoke(IntPtr obj, byte VertexInstancesToCreate /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray VertexInstancesToCreate
                Main.GetProcessEvent(obj, CreateVertexInstances_ptr, new IntPtr(p)); ;
                 //TODO: array TArray VertexInstancesToCreate
                 //TODO: array TArray OutNewVertexInstanceIDs
                return UObject.ToUnmangedCollection<VertexInstanceID>(b+16);
            }
        }
        internal struct CreateVertices_method {
            static internal IntPtr CreateVertices_ptr;
            static CreateVertices_method() {
                CreateVertices_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "CreateVertices");
            }

            internal static unsafe IReadOnlyCollection<VertexID> Invoke(IntPtr obj, byte VerticesToCreate /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray VerticesToCreate
                Main.GetProcessEvent(obj, CreateVertices_ptr, new IntPtr(p)); ;
                 //TODO: array TArray VerticesToCreate
                 //TODO: array TArray OutNewVertexIDs
                return UObject.ToUnmangedCollection<VertexID>(b+16);
            }
        }
        internal struct DeleteEdgeAndConnectedPolygons_method {
            static internal IntPtr DeleteEdgeAndConnectedPolygons_ptr;
            static DeleteEdgeAndConnectedPolygons_method() {
                DeleteEdgeAndConnectedPolygons_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "DeleteEdgeAndConnectedPolygons");
            }

            internal static unsafe void Invoke(IntPtr obj, EdgeID EdgeID, bool bDeleteOrphanedEdges, bool bDeleteOrphanedVertices, bool bDeleteOrphanedVertexInstances, bool bDeleteEmptyPolygonGroups) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((EdgeID*)(b+0)) = EdgeID;
                *((bool*)(b+4)) = bDeleteOrphanedEdges;
                *((bool*)(b+5)) = bDeleteOrphanedVertices;
                *((bool*)(b+6)) = bDeleteOrphanedVertexInstances;
                *((bool*)(b+7)) = bDeleteEmptyPolygonGroups;
                Main.GetProcessEvent(obj, DeleteEdgeAndConnectedPolygons_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DeleteEdges_method {
            static internal IntPtr DeleteEdges_ptr;
            static DeleteEdges_method() {
                DeleteEdges_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "DeleteEdges");
            }

            internal static unsafe void Invoke(IntPtr obj, byte EdgeIDsToDelete /*TODO: array TArray */, bool bDeleteOrphanedVertices) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray EdgeIDsToDelete
                *((bool*)(b+16)) = bDeleteOrphanedVertices;
                Main.GetProcessEvent(obj, DeleteEdges_ptr, new IntPtr(p)); ;
                 //TODO: array TArray EdgeIDsToDelete
            }
        }
        internal struct DeleteOrphanVertices_method {
            static internal IntPtr DeleteOrphanVertices_ptr;
            static DeleteOrphanVertices_method() {
                DeleteOrphanVertices_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "DeleteOrphanVertices");
            }

            internal static unsafe void Invoke(IntPtr obj, byte VertexIDsToDelete /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray VertexIDsToDelete
                Main.GetProcessEvent(obj, DeleteOrphanVertices_ptr, new IntPtr(p)); ;
                 //TODO: array TArray VertexIDsToDelete
            }
        }
        internal struct DeletePolygonGroups_method {
            static internal IntPtr DeletePolygonGroups_ptr;
            static DeletePolygonGroups_method() {
                DeletePolygonGroups_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "DeletePolygonGroups");
            }

            internal static unsafe void Invoke(IntPtr obj, byte PolygonGroupIDs /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray PolygonGroupIDs
                Main.GetProcessEvent(obj, DeletePolygonGroups_ptr, new IntPtr(p)); ;
                 //TODO: array TArray PolygonGroupIDs
            }
        }
        internal struct DeletePolygons_method {
            static internal IntPtr DeletePolygons_ptr;
            static DeletePolygons_method() {
                DeletePolygons_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "DeletePolygons");
            }

            internal static unsafe void Invoke(IntPtr obj, byte PolygonIDsToDelete /*TODO: array TArray */, bool bDeleteOrphanedEdges, bool bDeleteOrphanedVertices, bool bDeleteOrphanedVertexInstances, bool bDeleteEmptyPolygonGroups) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray PolygonIDsToDelete
                *((bool*)(b+16)) = bDeleteOrphanedEdges;
                *((bool*)(b+17)) = bDeleteOrphanedVertices;
                *((bool*)(b+18)) = bDeleteOrphanedVertexInstances;
                *((bool*)(b+19)) = bDeleteEmptyPolygonGroups;
                Main.GetProcessEvent(obj, DeletePolygons_ptr, new IntPtr(p)); ;
                 //TODO: array TArray PolygonIDsToDelete
            }
        }
        internal struct DeleteVertexAndConnectedEdgesAndPolygons_method {
            static internal IntPtr DeleteVertexAndConnectedEdgesAndPolygons_ptr;
            static DeleteVertexAndConnectedEdgesAndPolygons_method() {
                DeleteVertexAndConnectedEdgesAndPolygons_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "DeleteVertexAndConnectedEdgesAndPolygons");
            }

            internal static unsafe void Invoke(IntPtr obj, VertexID VertexID, bool bDeleteOrphanedEdges, bool bDeleteOrphanedVertices, bool bDeleteOrphanedVertexInstances, bool bDeleteEmptyPolygonGroups) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((VertexID*)(b+0)) = VertexID;
                *((bool*)(b+4)) = bDeleteOrphanedEdges;
                *((bool*)(b+5)) = bDeleteOrphanedVertices;
                *((bool*)(b+6)) = bDeleteOrphanedVertexInstances;
                *((bool*)(b+7)) = bDeleteEmptyPolygonGroups;
                Main.GetProcessEvent(obj, DeleteVertexAndConnectedEdgesAndPolygons_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DeleteVertexInstances_method {
            static internal IntPtr DeleteVertexInstances_ptr;
            static DeleteVertexInstances_method() {
                DeleteVertexInstances_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "DeleteVertexInstances");
            }

            internal static unsafe void Invoke(IntPtr obj, byte VertexInstanceIDsToDelete /*TODO: array TArray */, bool bDeleteOrphanedVertices) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray VertexInstanceIDsToDelete
                *((bool*)(b+16)) = bDeleteOrphanedVertices;
                Main.GetProcessEvent(obj, DeleteVertexInstances_ptr, new IntPtr(p)); ;
                 //TODO: array TArray VertexInstanceIDsToDelete
            }
        }
        internal struct EndModification_method {
            static internal IntPtr EndModification_ptr;
            static EndModification_method() {
                EndModification_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "EndModification");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bFromUndo) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bFromUndo;
                Main.GetProcessEvent(obj, EndModification_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ExtendEdges_method {
            static internal IntPtr ExtendEdges_ptr;
            static ExtendEdges_method() {
                ExtendEdges_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "ExtendEdges");
            }

            internal static unsafe IReadOnlyCollection<EdgeID> Invoke(IntPtr obj, byte EdgeIDs /*TODO: array TArray */, bool bWeldNeighbors) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray EdgeIDs
                *((bool*)(b+16)) = bWeldNeighbors;
                Main.GetProcessEvent(obj, ExtendEdges_ptr, new IntPtr(p)); ;
                 //TODO: array TArray EdgeIDs
                 //TODO: array TArray OutNewExtendedEdgeIDs
                return UObject.ToUnmangedCollection<EdgeID>(b+24);
            }
        }
        internal struct ExtendVertices_method {
            static internal IntPtr ExtendVertices_ptr;
            static ExtendVertices_method() {
                ExtendVertices_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "ExtendVertices");
            }

            internal static unsafe IReadOnlyCollection<VertexID> Invoke(IntPtr obj, byte VertexIDs /*TODO: array TArray */, bool bOnlyExtendClosestEdge, Vector ReferencePosition) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray VertexIDs
                *((bool*)(b+16)) = bOnlyExtendClosestEdge;
                *((Vector*)(b+20)) = ReferencePosition;
                Main.GetProcessEvent(obj, ExtendVertices_ptr, new IntPtr(p)); ;
                 //TODO: array TArray VertexIDs
                 //TODO: array TArray OutNewExtendedVertexIDs
                return UObject.ToUnmangedCollection<VertexID>(b+32);
            }
        }
        internal struct ExtrudePolygons_method {
            static internal IntPtr ExtrudePolygons_ptr;
            static ExtrudePolygons_method() {
                ExtrudePolygons_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "ExtrudePolygons");
            }

            internal static unsafe IReadOnlyCollection<PolygonID> Invoke(IntPtr obj, byte Polygons /*TODO: array TArray */, float ExtrudeDistance, bool bKeepNeighborsTogether) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray Polygons
                *((float*)(b+16)) = ExtrudeDistance;
                *((bool*)(b+20)) = bKeepNeighborsTogether;
                Main.GetProcessEvent(obj, ExtrudePolygons_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Polygons
                 //TODO: array TArray OutNewExtrudedFrontPolygons
                return UObject.ToUnmangedCollection<PolygonID>(b+24);
            }
        }
        internal struct FindPolygonHoleEdgeNumberForVertices_method {
            static internal IntPtr FindPolygonHoleEdgeNumberForVertices_ptr;
            static FindPolygonHoleEdgeNumberForVertices_method() {
                FindPolygonHoleEdgeNumberForVertices_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "FindPolygonHoleEdgeNumberForVertices");
            }

            internal static unsafe int Invoke(IntPtr obj, PolygonID PolygonID, int HoleNumber, VertexID EdgeVertexID0, VertexID EdgeVertexID1) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                *((int*)(b+4)) = HoleNumber;
                *((VertexID*)(b+8)) = EdgeVertexID0;
                *((VertexID*)(b+12)) = EdgeVertexID1;
                Main.GetProcessEvent(obj, FindPolygonHoleEdgeNumberForVertices_ptr, new IntPtr(p)); ;
                return *((int*)(b+16));
            }
        }
        internal struct FindPolygonHoleVertexNumberForVertex_method {
            static internal IntPtr FindPolygonHoleVertexNumberForVertex_ptr;
            static FindPolygonHoleVertexNumberForVertex_method() {
                FindPolygonHoleVertexNumberForVertex_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "FindPolygonHoleVertexNumberForVertex");
            }

            internal static unsafe int Invoke(IntPtr obj, PolygonID PolygonID, int HoleNumber, VertexID VertexID) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                *((int*)(b+4)) = HoleNumber;
                *((VertexID*)(b+8)) = VertexID;
                Main.GetProcessEvent(obj, FindPolygonHoleVertexNumberForVertex_ptr, new IntPtr(p)); ;
                return *((int*)(b+12));
            }
        }
        internal struct FindPolygonLoop_method {
            static internal IntPtr FindPolygonLoop_ptr;
            static FindPolygonLoop_method() {
                FindPolygonLoop_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "FindPolygonLoop");
            }

            internal static unsafe (IReadOnlyCollection<EdgeID>, IReadOnlyCollection<EdgeID>, IReadOnlyCollection<EdgeID>, IReadOnlyCollection<PolygonID>) Invoke(IntPtr obj, EdgeID EdgeID) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((EdgeID*)(b+0)) = EdgeID;
                Main.GetProcessEvent(obj, FindPolygonLoop_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutEdgeLoopEdgeIDs
                 //TODO: array TArray OutFlippedEdgeIDs
                 //TODO: array TArray OutReversedEdgeIDPathToTake
                 //TODO: array TArray OutPolygonIDsToSplit
                return (UObject.ToUnmangedCollection<EdgeID>(b+8),UObject.ToUnmangedCollection<EdgeID>(b+24),UObject.ToUnmangedCollection<EdgeID>(b+40),UObject.ToUnmangedCollection<PolygonID>(b+56));
            }
        }
        internal struct FindPolygonPerimeterEdgeNumberForVertices_method {
            static internal IntPtr FindPolygonPerimeterEdgeNumberForVertices_ptr;
            static FindPolygonPerimeterEdgeNumberForVertices_method() {
                FindPolygonPerimeterEdgeNumberForVertices_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "FindPolygonPerimeterEdgeNumberForVertices");
            }

            internal static unsafe int Invoke(IntPtr obj, PolygonID PolygonID, VertexID EdgeVertexID0, VertexID EdgeVertexID1) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                *((VertexID*)(b+4)) = EdgeVertexID0;
                *((VertexID*)(b+8)) = EdgeVertexID1;
                Main.GetProcessEvent(obj, FindPolygonPerimeterEdgeNumberForVertices_ptr, new IntPtr(p)); ;
                return *((int*)(b+12));
            }
        }
        internal struct FindPolygonPerimeterVertexNumberForVertex_method {
            static internal IntPtr FindPolygonPerimeterVertexNumberForVertex_ptr;
            static FindPolygonPerimeterVertexNumberForVertex_method() {
                FindPolygonPerimeterVertexNumberForVertex_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "FindPolygonPerimeterVertexNumberForVertex");
            }

            internal static unsafe int Invoke(IntPtr obj, PolygonID PolygonID, VertexID VertexID) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                *((VertexID*)(b+4)) = VertexID;
                Main.GetProcessEvent(obj, FindPolygonPerimeterVertexNumberForVertex_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct FlipPolygons_method {
            static internal IntPtr FlipPolygons_ptr;
            static FlipPolygons_method() {
                FlipPolygons_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "FlipPolygons");
            }

            internal static unsafe void Invoke(IntPtr obj, byte PolygonIDs /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray PolygonIDs
                Main.GetProcessEvent(obj, FlipPolygons_ptr, new IntPtr(p)); ;
                 //TODO: array TArray PolygonIDs
            }
        }
        internal struct GeneratePolygonTangentsAndNormals_method {
            static internal IntPtr GeneratePolygonTangentsAndNormals_ptr;
            static GeneratePolygonTangentsAndNormals_method() {
                GeneratePolygonTangentsAndNormals_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GeneratePolygonTangentsAndNormals");
            }

            internal static unsafe void Invoke(IntPtr obj, byte PolygonIDs /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray PolygonIDs
                Main.GetProcessEvent(obj, GeneratePolygonTangentsAndNormals_ptr, new IntPtr(p)); ;
                 //TODO: array TArray PolygonIDs
            }
        }
        internal struct GetEdgeConnectedPolygon_method {
            static internal IntPtr GetEdgeConnectedPolygon_ptr;
            static GetEdgeConnectedPolygon_method() {
                GetEdgeConnectedPolygon_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetEdgeConnectedPolygon");
            }

            internal static unsafe PolygonID Invoke(IntPtr obj, EdgeID EdgeID, int ConnectedPolygonNumber) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((EdgeID*)(b+0)) = EdgeID;
                *((int*)(b+4)) = ConnectedPolygonNumber;
                Main.GetProcessEvent(obj, GetEdgeConnectedPolygon_ptr, new IntPtr(p)); ;
                return *((PolygonID*)(b+8));
            }
        }
        internal struct GetEdgeConnectedPolygonCount_method {
            static internal IntPtr GetEdgeConnectedPolygonCount_ptr;
            static GetEdgeConnectedPolygonCount_method() {
                GetEdgeConnectedPolygonCount_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetEdgeConnectedPolygonCount");
            }

            internal static unsafe int Invoke(IntPtr obj, EdgeID EdgeID) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((EdgeID*)(b+0)) = EdgeID;
                Main.GetProcessEvent(obj, GetEdgeConnectedPolygonCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+4));
            }
        }
        internal struct GetEdgeConnectedPolygons_method {
            static internal IntPtr GetEdgeConnectedPolygons_ptr;
            static GetEdgeConnectedPolygons_method() {
                GetEdgeConnectedPolygons_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetEdgeConnectedPolygons");
            }

            internal static unsafe IReadOnlyCollection<PolygonID> Invoke(IntPtr obj, EdgeID EdgeID) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((EdgeID*)(b+0)) = EdgeID;
                Main.GetProcessEvent(obj, GetEdgeConnectedPolygons_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutConnectedPolygonIDs
                return UObject.ToUnmangedCollection<PolygonID>(b+8);
            }
        }
        internal struct GetEdgeCount_method {
            static internal IntPtr GetEdgeCount_ptr;
            static GetEdgeCount_method() {
                GetEdgeCount_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetEdgeCount");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetEdgeCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetEdgeLoopElements_method {
            static internal IntPtr GetEdgeLoopElements_ptr;
            static GetEdgeLoopElements_method() {
                GetEdgeLoopElements_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetEdgeLoopElements");
            }

            internal static unsafe IReadOnlyCollection<EdgeID> Invoke(IntPtr obj, EdgeID EdgeID) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((EdgeID*)(b+0)) = EdgeID;
                Main.GetProcessEvent(obj, GetEdgeLoopElements_ptr, new IntPtr(p)); ;
                 //TODO: array TArray EdgeLoopIDs
                return UObject.ToUnmangedCollection<EdgeID>(b+8);
            }
        }
        internal struct GetEdgeThatConnectsVertices_method {
            static internal IntPtr GetEdgeThatConnectsVertices_ptr;
            static GetEdgeThatConnectsVertices_method() {
                GetEdgeThatConnectsVertices_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetEdgeThatConnectsVertices");
            }

            internal static unsafe EdgeID Invoke(IntPtr obj, VertexID VertexID0, VertexID VertexID1) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((VertexID*)(b+0)) = VertexID0;
                *((VertexID*)(b+4)) = VertexID1;
                Main.GetProcessEvent(obj, GetEdgeThatConnectsVertices_ptr, new IntPtr(p)); ;
                return *((EdgeID*)(b+8));
            }
        }
        internal struct GetEdgeVertex_method {
            static internal IntPtr GetEdgeVertex_ptr;
            static GetEdgeVertex_method() {
                GetEdgeVertex_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetEdgeVertex");
            }

            internal static unsafe VertexID Invoke(IntPtr obj, EdgeID EdgeID, int EdgeVertexNumber) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((EdgeID*)(b+0)) = EdgeID;
                *((int*)(b+4)) = EdgeVertexNumber;
                Main.GetProcessEvent(obj, GetEdgeVertex_ptr, new IntPtr(p)); ;
                return *((VertexID*)(b+8));
            }
        }
        internal struct GetEdgeVertices_method {
            static internal IntPtr GetEdgeVertices_ptr;
            static GetEdgeVertices_method() {
                GetEdgeVertices_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetEdgeVertices");
            }

            internal static unsafe (VertexID, VertexID) Invoke(IntPtr obj, EdgeID EdgeID) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((EdgeID*)(b+0)) = EdgeID;
                Main.GetProcessEvent(obj, GetEdgeVertices_ptr, new IntPtr(p)); ;
                return (*((VertexID*)(b+4)),*((VertexID*)(b+8)));
            }
        }
        internal struct GetFirstValidPolygonGroup_method {
            static internal IntPtr GetFirstValidPolygonGroup_ptr;
            static GetFirstValidPolygonGroup_method() {
                GetFirstValidPolygonGroup_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetFirstValidPolygonGroup");
            }

            internal static unsafe PolygonGroupID Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetFirstValidPolygonGroup_ptr, new IntPtr(p)); ;
                return *((PolygonGroupID*)(b+0));
            }
        }
        internal struct GetGroupForPolygon_method {
            static internal IntPtr GetGroupForPolygon_ptr;
            static GetGroupForPolygon_method() {
                GetGroupForPolygon_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetGroupForPolygon");
            }

            internal static unsafe PolygonGroupID Invoke(IntPtr obj, PolygonID PolygonID) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                Main.GetProcessEvent(obj, GetGroupForPolygon_ptr, new IntPtr(p)); ;
                return *((PolygonGroupID*)(b+4));
            }
        }
        internal struct GetPolygonAdjacentPolygons_method {
            static internal IntPtr GetPolygonAdjacentPolygons_ptr;
            static GetPolygonAdjacentPolygons_method() {
                GetPolygonAdjacentPolygons_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetPolygonAdjacentPolygons");
            }

            internal static unsafe IReadOnlyCollection<PolygonID> Invoke(IntPtr obj, PolygonID PolygonID) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                Main.GetProcessEvent(obj, GetPolygonAdjacentPolygons_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutAdjacentPolygons
                return UObject.ToUnmangedCollection<PolygonID>(b+8);
            }
        }
        internal struct GetPolygonCount_method {
            static internal IntPtr GetPolygonCount_ptr;
            static GetPolygonCount_method() {
                GetPolygonCount_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetPolygonCount");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPolygonCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetPolygonCountInGroup_method {
            static internal IntPtr GetPolygonCountInGroup_ptr;
            static GetPolygonCountInGroup_method() {
                GetPolygonCountInGroup_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetPolygonCountInGroup");
            }

            internal static unsafe int Invoke(IntPtr obj, PolygonGroupID PolygonGroupID) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((PolygonGroupID*)(b+0)) = PolygonGroupID;
                Main.GetProcessEvent(obj, GetPolygonCountInGroup_ptr, new IntPtr(p)); ;
                return *((int*)(b+4));
            }
        }
        internal struct GetPolygonGroupCount_method {
            static internal IntPtr GetPolygonGroupCount_ptr;
            static GetPolygonGroupCount_method() {
                GetPolygonGroupCount_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetPolygonGroupCount");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPolygonGroupCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetPolygonHoleCount_method {
            static internal IntPtr GetPolygonHoleCount_ptr;
            static GetPolygonHoleCount_method() {
                GetPolygonHoleCount_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetPolygonHoleCount");
            }

            internal static unsafe int Invoke(IntPtr obj, PolygonID PolygonID) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                Main.GetProcessEvent(obj, GetPolygonHoleCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+4));
            }
        }
        internal struct GetPolygonHoleEdge_method {
            static internal IntPtr GetPolygonHoleEdge_ptr;
            static GetPolygonHoleEdge_method() {
                GetPolygonHoleEdge_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetPolygonHoleEdge");
            }

            internal static unsafe EdgeID Invoke(IntPtr obj, PolygonID PolygonID, int HoleNumber, int HoleEdgeNumber) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                *((int*)(b+4)) = HoleNumber;
                *((int*)(b+8)) = HoleEdgeNumber;
                Main.GetProcessEvent(obj, GetPolygonHoleEdge_ptr, new IntPtr(p)); ;
                return *((EdgeID*)(b+12));
            }
        }
        internal struct GetPolygonHoleEdgeCount_method {
            static internal IntPtr GetPolygonHoleEdgeCount_ptr;
            static GetPolygonHoleEdgeCount_method() {
                GetPolygonHoleEdgeCount_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetPolygonHoleEdgeCount");
            }

            internal static unsafe int Invoke(IntPtr obj, PolygonID PolygonID, int HoleNumber) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                *((int*)(b+4)) = HoleNumber;
                Main.GetProcessEvent(obj, GetPolygonHoleEdgeCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetPolygonHoleEdges_method {
            static internal IntPtr GetPolygonHoleEdges_ptr;
            static GetPolygonHoleEdges_method() {
                GetPolygonHoleEdges_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetPolygonHoleEdges");
            }

            internal static unsafe IReadOnlyCollection<EdgeID> Invoke(IntPtr obj, PolygonID PolygonID, int HoleNumber) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                *((int*)(b+4)) = HoleNumber;
                Main.GetProcessEvent(obj, GetPolygonHoleEdges_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutHoleEdgeIDs
                return UObject.ToUnmangedCollection<EdgeID>(b+8);
            }
        }
        internal struct GetPolygonHoleVertex_method {
            static internal IntPtr GetPolygonHoleVertex_ptr;
            static GetPolygonHoleVertex_method() {
                GetPolygonHoleVertex_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetPolygonHoleVertex");
            }

            internal static unsafe VertexID Invoke(IntPtr obj, PolygonID PolygonID, int HoleNumber, int PolygonVertexNumber) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                *((int*)(b+4)) = HoleNumber;
                *((int*)(b+8)) = PolygonVertexNumber;
                Main.GetProcessEvent(obj, GetPolygonHoleVertex_ptr, new IntPtr(p)); ;
                return *((VertexID*)(b+12));
            }
        }
        internal struct GetPolygonHoleVertexCount_method {
            static internal IntPtr GetPolygonHoleVertexCount_ptr;
            static GetPolygonHoleVertexCount_method() {
                GetPolygonHoleVertexCount_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetPolygonHoleVertexCount");
            }

            internal static unsafe int Invoke(IntPtr obj, PolygonID PolygonID, int HoleNumber) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                *((int*)(b+4)) = HoleNumber;
                Main.GetProcessEvent(obj, GetPolygonHoleVertexCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetPolygonHoleVertexInstance_method {
            static internal IntPtr GetPolygonHoleVertexInstance_ptr;
            static GetPolygonHoleVertexInstance_method() {
                GetPolygonHoleVertexInstance_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetPolygonHoleVertexInstance");
            }

            internal static unsafe VertexInstanceID Invoke(IntPtr obj, PolygonID PolygonID, int HoleNumber, int PolygonVertexNumber) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                *((int*)(b+4)) = HoleNumber;
                *((int*)(b+8)) = PolygonVertexNumber;
                Main.GetProcessEvent(obj, GetPolygonHoleVertexInstance_ptr, new IntPtr(p)); ;
                return *((VertexInstanceID*)(b+12));
            }
        }
        internal struct GetPolygonHoleVertexInstances_method {
            static internal IntPtr GetPolygonHoleVertexInstances_ptr;
            static GetPolygonHoleVertexInstances_method() {
                GetPolygonHoleVertexInstances_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetPolygonHoleVertexInstances");
            }

            internal static unsafe IReadOnlyCollection<VertexInstanceID> Invoke(IntPtr obj, PolygonID PolygonID, int HoleNumber) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                *((int*)(b+4)) = HoleNumber;
                Main.GetProcessEvent(obj, GetPolygonHoleVertexInstances_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutHoleVertexInstanceIDs
                return UObject.ToUnmangedCollection<VertexInstanceID>(b+8);
            }
        }
        internal struct GetPolygonHoleVertices_method {
            static internal IntPtr GetPolygonHoleVertices_ptr;
            static GetPolygonHoleVertices_method() {
                GetPolygonHoleVertices_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetPolygonHoleVertices");
            }

            internal static unsafe IReadOnlyCollection<VertexID> Invoke(IntPtr obj, PolygonID PolygonID, int HoleNumber) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                *((int*)(b+4)) = HoleNumber;
                Main.GetProcessEvent(obj, GetPolygonHoleVertices_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutHoleVertexIDs
                return UObject.ToUnmangedCollection<VertexID>(b+8);
            }
        }
        internal struct GetPolygonInGroup_method {
            static internal IntPtr GetPolygonInGroup_ptr;
            static GetPolygonInGroup_method() {
                GetPolygonInGroup_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetPolygonInGroup");
            }

            internal static unsafe PolygonID Invoke(IntPtr obj, PolygonGroupID PolygonGroupID, int PolygonNumber) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonGroupID*)(b+0)) = PolygonGroupID;
                *((int*)(b+4)) = PolygonNumber;
                Main.GetProcessEvent(obj, GetPolygonInGroup_ptr, new IntPtr(p)); ;
                return *((PolygonID*)(b+8));
            }
        }
        internal struct GetPolygonPerimeterEdge_method {
            static internal IntPtr GetPolygonPerimeterEdge_ptr;
            static GetPolygonPerimeterEdge_method() {
                GetPolygonPerimeterEdge_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetPolygonPerimeterEdge");
            }

            internal static unsafe (bool, EdgeID) Invoke(IntPtr obj, PolygonID PolygonID, int PerimeterEdgeNumber) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                *((int*)(b+4)) = PerimeterEdgeNumber;
                Main.GetProcessEvent(obj, GetPolygonPerimeterEdge_ptr, new IntPtr(p)); ;
                return (*((bool*)(b+8)),*((EdgeID*)(b+12)));
            }
        }
        internal struct GetPolygonPerimeterEdgeCount_method {
            static internal IntPtr GetPolygonPerimeterEdgeCount_ptr;
            static GetPolygonPerimeterEdgeCount_method() {
                GetPolygonPerimeterEdgeCount_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetPolygonPerimeterEdgeCount");
            }

            internal static unsafe int Invoke(IntPtr obj, PolygonID PolygonID) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                Main.GetProcessEvent(obj, GetPolygonPerimeterEdgeCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+4));
            }
        }
        internal struct GetPolygonPerimeterEdges_method {
            static internal IntPtr GetPolygonPerimeterEdges_ptr;
            static GetPolygonPerimeterEdges_method() {
                GetPolygonPerimeterEdges_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetPolygonPerimeterEdges");
            }

            internal static unsafe IReadOnlyCollection<EdgeID> Invoke(IntPtr obj, PolygonID PolygonID) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                Main.GetProcessEvent(obj, GetPolygonPerimeterEdges_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutPolygonPerimeterEdgeIDs
                return UObject.ToUnmangedCollection<EdgeID>(b+8);
            }
        }
        internal struct GetPolygonPerimeterVertex_method {
            static internal IntPtr GetPolygonPerimeterVertex_ptr;
            static GetPolygonPerimeterVertex_method() {
                GetPolygonPerimeterVertex_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetPolygonPerimeterVertex");
            }

            internal static unsafe VertexID Invoke(IntPtr obj, PolygonID PolygonID, int PolygonVertexNumber) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                *((int*)(b+4)) = PolygonVertexNumber;
                Main.GetProcessEvent(obj, GetPolygonPerimeterVertex_ptr, new IntPtr(p)); ;
                return *((VertexID*)(b+8));
            }
        }
        internal struct GetPolygonPerimeterVertexCount_method {
            static internal IntPtr GetPolygonPerimeterVertexCount_ptr;
            static GetPolygonPerimeterVertexCount_method() {
                GetPolygonPerimeterVertexCount_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetPolygonPerimeterVertexCount");
            }

            internal static unsafe int Invoke(IntPtr obj, PolygonID PolygonID) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                Main.GetProcessEvent(obj, GetPolygonPerimeterVertexCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+4));
            }
        }
        internal struct GetPolygonPerimeterVertexInstance_method {
            static internal IntPtr GetPolygonPerimeterVertexInstance_ptr;
            static GetPolygonPerimeterVertexInstance_method() {
                GetPolygonPerimeterVertexInstance_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetPolygonPerimeterVertexInstance");
            }

            internal static unsafe VertexInstanceID Invoke(IntPtr obj, PolygonID PolygonID, int PolygonVertexNumber) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                *((int*)(b+4)) = PolygonVertexNumber;
                Main.GetProcessEvent(obj, GetPolygonPerimeterVertexInstance_ptr, new IntPtr(p)); ;
                return *((VertexInstanceID*)(b+8));
            }
        }
        internal struct GetPolygonPerimeterVertexInstances_method {
            static internal IntPtr GetPolygonPerimeterVertexInstances_ptr;
            static GetPolygonPerimeterVertexInstances_method() {
                GetPolygonPerimeterVertexInstances_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetPolygonPerimeterVertexInstances");
            }

            internal static unsafe IReadOnlyCollection<VertexInstanceID> Invoke(IntPtr obj, PolygonID PolygonID) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                Main.GetProcessEvent(obj, GetPolygonPerimeterVertexInstances_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutPolygonPerimeterVertexInstanceIDs
                return UObject.ToUnmangedCollection<VertexInstanceID>(b+8);
            }
        }
        internal struct GetPolygonPerimeterVertices_method {
            static internal IntPtr GetPolygonPerimeterVertices_ptr;
            static GetPolygonPerimeterVertices_method() {
                GetPolygonPerimeterVertices_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetPolygonPerimeterVertices");
            }

            internal static unsafe IReadOnlyCollection<VertexID> Invoke(IntPtr obj, PolygonID PolygonID) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                Main.GetProcessEvent(obj, GetPolygonPerimeterVertices_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutPolygonPerimeterVertexIDs
                return UObject.ToUnmangedCollection<VertexID>(b+8);
            }
        }
        internal struct GetPolygonTriangulatedTriangle_method {
            static internal IntPtr GetPolygonTriangulatedTriangle_ptr;
            static GetPolygonTriangulatedTriangle_method() {
                GetPolygonTriangulatedTriangle_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetPolygonTriangulatedTriangle");
            }

            internal static unsafe MeshTriangle Invoke(IntPtr obj, PolygonID PolygonID, int PolygonTriangleNumber) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                *((int*)(b+4)) = PolygonTriangleNumber;
                Main.GetProcessEvent(obj, GetPolygonTriangulatedTriangle_ptr, new IntPtr(p)); ;
                return *((MeshTriangle*)(b+8));
            }
        }
        internal struct GetPolygonTriangulatedTriangleCount_method {
            static internal IntPtr GetPolygonTriangulatedTriangleCount_ptr;
            static GetPolygonTriangulatedTriangleCount_method() {
                GetPolygonTriangulatedTriangleCount_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetPolygonTriangulatedTriangleCount");
            }

            internal static unsafe int Invoke(IntPtr obj, PolygonID PolygonID) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                Main.GetProcessEvent(obj, GetPolygonTriangulatedTriangleCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+4));
            }
        }
        internal struct GetSubdivisionCount_method {
            static internal IntPtr GetSubdivisionCount_ptr;
            static GetSubdivisionCount_method() {
                GetSubdivisionCount_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetSubdivisionCount");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetSubdivisionCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetSubdivisionLimitData_method {
            static internal IntPtr GetSubdivisionLimitData_ptr;
            static GetSubdivisionLimitData_method() {
                GetSubdivisionLimitData_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetSubdivisionLimitData");
            }

            internal static unsafe void Invoke(IntPtr obj, SubdivisionLimitData ReturnValue) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SubdivisionLimitData*)(b+0)) = ReturnValue;
                Main.GetProcessEvent(obj, GetSubdivisionLimitData_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetTextureCoordinateCount_method {
            static internal IntPtr GetTextureCoordinateCount_ptr;
            static GetTextureCoordinateCount_method() {
                GetTextureCoordinateCount_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetTextureCoordinateCount");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetTextureCoordinateCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetVertexAdjacentVertices_method {
            static internal IntPtr GetVertexAdjacentVertices_ptr;
            static GetVertexAdjacentVertices_method() {
                GetVertexAdjacentVertices_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetVertexAdjacentVertices");
            }

            internal static unsafe IReadOnlyCollection<VertexID> Invoke(IntPtr obj, VertexID VertexID) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((VertexID*)(b+0)) = VertexID;
                Main.GetProcessEvent(obj, GetVertexAdjacentVertices_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutAdjacentVertexIDs
                return UObject.ToUnmangedCollection<VertexID>(b+8);
            }
        }
        internal struct GetVertexConnectedEdge_method {
            static internal IntPtr GetVertexConnectedEdge_ptr;
            static GetVertexConnectedEdge_method() {
                GetVertexConnectedEdge_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetVertexConnectedEdge");
            }

            internal static unsafe EdgeID Invoke(IntPtr obj, VertexID VertexID, int ConnectedEdgeNumber) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((VertexID*)(b+0)) = VertexID;
                *((int*)(b+4)) = ConnectedEdgeNumber;
                Main.GetProcessEvent(obj, GetVertexConnectedEdge_ptr, new IntPtr(p)); ;
                return *((EdgeID*)(b+8));
            }
        }
        internal struct GetVertexConnectedEdgeCount_method {
            static internal IntPtr GetVertexConnectedEdgeCount_ptr;
            static GetVertexConnectedEdgeCount_method() {
                GetVertexConnectedEdgeCount_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetVertexConnectedEdgeCount");
            }

            internal static unsafe int Invoke(IntPtr obj, VertexID VertexID) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((VertexID*)(b+0)) = VertexID;
                Main.GetProcessEvent(obj, GetVertexConnectedEdgeCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+4));
            }
        }
        internal struct GetVertexConnectedEdges_method {
            static internal IntPtr GetVertexConnectedEdges_ptr;
            static GetVertexConnectedEdges_method() {
                GetVertexConnectedEdges_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetVertexConnectedEdges");
            }

            internal static unsafe IReadOnlyCollection<EdgeID> Invoke(IntPtr obj, VertexID VertexID) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((VertexID*)(b+0)) = VertexID;
                Main.GetProcessEvent(obj, GetVertexConnectedEdges_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutConnectedEdgeIDs
                return UObject.ToUnmangedCollection<EdgeID>(b+8);
            }
        }
        internal struct GetVertexConnectedPolygons_method {
            static internal IntPtr GetVertexConnectedPolygons_ptr;
            static GetVertexConnectedPolygons_method() {
                GetVertexConnectedPolygons_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetVertexConnectedPolygons");
            }

            internal static unsafe IReadOnlyCollection<PolygonID> Invoke(IntPtr obj, VertexID VertexID) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((VertexID*)(b+0)) = VertexID;
                Main.GetProcessEvent(obj, GetVertexConnectedPolygons_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutConnectedPolygonIDs
                return UObject.ToUnmangedCollection<PolygonID>(b+8);
            }
        }
        internal struct GetVertexCount_method {
            static internal IntPtr GetVertexCount_ptr;
            static GetVertexCount_method() {
                GetVertexCount_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetVertexCount");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetVertexCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetVertexInstanceConnectedPolygon_method {
            static internal IntPtr GetVertexInstanceConnectedPolygon_ptr;
            static GetVertexInstanceConnectedPolygon_method() {
                GetVertexInstanceConnectedPolygon_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetVertexInstanceConnectedPolygon");
            }

            internal static unsafe PolygonID Invoke(IntPtr obj, VertexInstanceID VertexInstanceID, int ConnectedPolygonNumber) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((VertexInstanceID*)(b+0)) = VertexInstanceID;
                *((int*)(b+4)) = ConnectedPolygonNumber;
                Main.GetProcessEvent(obj, GetVertexInstanceConnectedPolygon_ptr, new IntPtr(p)); ;
                return *((PolygonID*)(b+8));
            }
        }
        internal struct GetVertexInstanceConnectedPolygonCount_method {
            static internal IntPtr GetVertexInstanceConnectedPolygonCount_ptr;
            static GetVertexInstanceConnectedPolygonCount_method() {
                GetVertexInstanceConnectedPolygonCount_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetVertexInstanceConnectedPolygonCount");
            }

            internal static unsafe int Invoke(IntPtr obj, VertexInstanceID VertexInstanceID) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((VertexInstanceID*)(b+0)) = VertexInstanceID;
                Main.GetProcessEvent(obj, GetVertexInstanceConnectedPolygonCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+4));
            }
        }
        internal struct GetVertexInstanceConnectedPolygons_method {
            static internal IntPtr GetVertexInstanceConnectedPolygons_ptr;
            static GetVertexInstanceConnectedPolygons_method() {
                GetVertexInstanceConnectedPolygons_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetVertexInstanceConnectedPolygons");
            }

            internal static unsafe IReadOnlyCollection<PolygonID> Invoke(IntPtr obj, VertexInstanceID VertexInstanceID) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((VertexInstanceID*)(b+0)) = VertexInstanceID;
                Main.GetProcessEvent(obj, GetVertexInstanceConnectedPolygons_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutConnectedPolygonIDs
                return UObject.ToUnmangedCollection<PolygonID>(b+8);
            }
        }
        internal struct GetVertexInstanceCount_method {
            static internal IntPtr GetVertexInstanceCount_ptr;
            static GetVertexInstanceCount_method() {
                GetVertexInstanceCount_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetVertexInstanceCount");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetVertexInstanceCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetVertexInstanceVertex_method {
            static internal IntPtr GetVertexInstanceVertex_ptr;
            static GetVertexInstanceVertex_method() {
                GetVertexInstanceVertex_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetVertexInstanceVertex");
            }

            internal static unsafe VertexID Invoke(IntPtr obj, VertexInstanceID VertexInstanceID) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((VertexInstanceID*)(b+0)) = VertexInstanceID;
                Main.GetProcessEvent(obj, GetVertexInstanceVertex_ptr, new IntPtr(p)); ;
                return *((VertexID*)(b+4));
            }
        }
        internal struct GetVertexPairEdge_method {
            static internal IntPtr GetVertexPairEdge_ptr;
            static GetVertexPairEdge_method() {
                GetVertexPairEdge_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "GetVertexPairEdge");
            }

            internal static unsafe (bool, EdgeID) Invoke(IntPtr obj, VertexID VertexID, VertexID NextVertexID) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((VertexID*)(b+0)) = VertexID;
                *((VertexID*)(b+4)) = NextVertexID;
                Main.GetProcessEvent(obj, GetVertexPairEdge_ptr, new IntPtr(p)); ;
                return (*((bool*)(b+8)),*((EdgeID*)(b+12)));
            }
        }
        internal struct InitializeAdapters_method {
            static internal IntPtr InitializeAdapters_ptr;
            static InitializeAdapters_method() {
                InitializeAdapters_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "InitializeAdapters");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, InitializeAdapters_ptr, new IntPtr(p)); ;
            }
        }
        internal struct InsertEdgeLoop_method {
            static internal IntPtr InsertEdgeLoop_ptr;
            static InsertEdgeLoop_method() {
                InsertEdgeLoop_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "InsertEdgeLoop");
            }

            internal static unsafe IReadOnlyCollection<EdgeID> Invoke(IntPtr obj, EdgeID EdgeID, byte Splits /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((EdgeID*)(b+0)) = EdgeID;
                throw new NotImplementedException(); //TODO: array TArray Splits
                Main.GetProcessEvent(obj, InsertEdgeLoop_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Splits
                 //TODO: array TArray OutNewEdgeIDs
                return UObject.ToUnmangedCollection<EdgeID>(b+24);
            }
        }
        internal struct InsertPolygonPerimeterVertices_method {
            static internal IntPtr InsertPolygonPerimeterVertices_ptr;
            static InsertPolygonPerimeterVertices_method() {
                InsertPolygonPerimeterVertices_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "InsertPolygonPerimeterVertices");
            }

            internal static unsafe void Invoke(IntPtr obj, PolygonID PolygonID, int InsertBeforeVertexNumber, byte VerticesToInsert /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                *((int*)(b+4)) = InsertBeforeVertexNumber;
                throw new NotImplementedException(); //TODO: array TArray VerticesToInsert
                Main.GetProcessEvent(obj, InsertPolygonPerimeterVertices_ptr, new IntPtr(p)); ;
                 //TODO: array TArray VerticesToInsert
            }
        }
        internal struct InsetPolygons_method {
            static internal IntPtr InsetPolygons_ptr;
            static InsetPolygons_method() {
                InsetPolygons_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "InsetPolygons");
            }

            internal static unsafe (IReadOnlyCollection<PolygonID>, IReadOnlyCollection<PolygonID>) Invoke(IntPtr obj, byte PolygonIDs /*TODO: array TArray */, float InsetFixedDistance, float InsetProgressTowardCenter, EInsetPolygonsMode Mode) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray PolygonIDs
                *((float*)(b+16)) = InsetFixedDistance;
                *((float*)(b+20)) = InsetProgressTowardCenter;
                *(b+24) = (byte)Mode;
                Main.GetProcessEvent(obj, InsetPolygons_ptr, new IntPtr(p)); ;
                 //TODO: array TArray PolygonIDs
                 //TODO: array TArray OutNewCenterPolygonIDs
                 //TODO: array TArray OutNewSidePolygonIDs
                return (UObject.ToUnmangedCollection<PolygonID>(b+32),UObject.ToUnmangedCollection<PolygonID>(b+48));
            }
        }
        internal struct InvalidEdgeID_method {
            static internal IntPtr InvalidEdgeID_ptr;
            static InvalidEdgeID_method() {
                InvalidEdgeID_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "InvalidEdgeID");
            }

            internal static unsafe EdgeID Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(EditableMesh.DefaultObject, InvalidEdgeID_ptr, new IntPtr(p)); ;
                return *((EdgeID*)(b+0));
            }
        }
        internal struct InvalidPolygonGroupID_method {
            static internal IntPtr InvalidPolygonGroupID_ptr;
            static InvalidPolygonGroupID_method() {
                InvalidPolygonGroupID_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "InvalidPolygonGroupID");
            }

            internal static unsafe PolygonGroupID Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(EditableMesh.DefaultObject, InvalidPolygonGroupID_ptr, new IntPtr(p)); ;
                return *((PolygonGroupID*)(b+0));
            }
        }
        internal struct InvalidPolygonID_method {
            static internal IntPtr InvalidPolygonID_ptr;
            static InvalidPolygonID_method() {
                InvalidPolygonID_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "InvalidPolygonID");
            }

            internal static unsafe PolygonID Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(EditableMesh.DefaultObject, InvalidPolygonID_ptr, new IntPtr(p)); ;
                return *((PolygonID*)(b+0));
            }
        }
        internal struct InvalidVertexID_method {
            static internal IntPtr InvalidVertexID_ptr;
            static InvalidVertexID_method() {
                InvalidVertexID_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "InvalidVertexID");
            }

            internal static unsafe VertexID Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(EditableMesh.DefaultObject, InvalidVertexID_ptr, new IntPtr(p)); ;
                return *((VertexID*)(b+0));
            }
        }
        internal struct IsBeingModified_method {
            static internal IntPtr IsBeingModified_ptr;
            static IsBeingModified_method() {
                IsBeingModified_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "IsBeingModified");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsBeingModified_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsCommitted_method {
            static internal IntPtr IsCommitted_ptr;
            static IsCommitted_method() {
                IsCommitted_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "IsCommitted");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsCommitted_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsCommittedAsInstance_method {
            static internal IntPtr IsCommittedAsInstance_ptr;
            static IsCommittedAsInstance_method() {
                IsCommittedAsInstance_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "IsCommittedAsInstance");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsCommittedAsInstance_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsCompactAllowed_method {
            static internal IntPtr IsCompactAllowed_ptr;
            static IsCompactAllowed_method() {
                IsCompactAllowed_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "IsCompactAllowed");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsCompactAllowed_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsOrphanedVertex_method {
            static internal IntPtr IsOrphanedVertex_ptr;
            static IsOrphanedVertex_method() {
                IsOrphanedVertex_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "IsOrphanedVertex");
            }

            internal static unsafe bool Invoke(IntPtr obj, VertexID VertexID) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((VertexID*)(b+0)) = VertexID;
                Main.GetProcessEvent(obj, IsOrphanedVertex_ptr, new IntPtr(p)); ;
                return *((bool*)(b+4));
            }
        }
        internal struct IsPreviewingSubdivisions_method {
            static internal IntPtr IsPreviewingSubdivisions_ptr;
            static IsPreviewingSubdivisions_method() {
                IsPreviewingSubdivisions_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "IsPreviewingSubdivisions");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsPreviewingSubdivisions_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsSpatialDatabaseAllowed_method {
            static internal IntPtr IsSpatialDatabaseAllowed_ptr;
            static IsSpatialDatabaseAllowed_method() {
                IsSpatialDatabaseAllowed_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "IsSpatialDatabaseAllowed");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsSpatialDatabaseAllowed_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsUndoAllowed_method {
            static internal IntPtr IsUndoAllowed_ptr;
            static IsUndoAllowed_method() {
                IsUndoAllowed_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "IsUndoAllowed");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsUndoAllowed_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsValidEdge_method {
            static internal IntPtr IsValidEdge_ptr;
            static IsValidEdge_method() {
                IsValidEdge_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "IsValidEdge");
            }

            internal static unsafe bool Invoke(IntPtr obj, EdgeID EdgeID) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((EdgeID*)(b+0)) = EdgeID;
                Main.GetProcessEvent(obj, IsValidEdge_ptr, new IntPtr(p)); ;
                return *((bool*)(b+4));
            }
        }
        internal struct IsValidPolygon_method {
            static internal IntPtr IsValidPolygon_ptr;
            static IsValidPolygon_method() {
                IsValidPolygon_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "IsValidPolygon");
            }

            internal static unsafe bool Invoke(IntPtr obj, PolygonID PolygonID) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                Main.GetProcessEvent(obj, IsValidPolygon_ptr, new IntPtr(p)); ;
                return *((bool*)(b+4));
            }
        }
        internal struct IsValidPolygonGroup_method {
            static internal IntPtr IsValidPolygonGroup_ptr;
            static IsValidPolygonGroup_method() {
                IsValidPolygonGroup_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "IsValidPolygonGroup");
            }

            internal static unsafe bool Invoke(IntPtr obj, PolygonGroupID PolygonGroupID) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((PolygonGroupID*)(b+0)) = PolygonGroupID;
                Main.GetProcessEvent(obj, IsValidPolygonGroup_ptr, new IntPtr(p)); ;
                return *((bool*)(b+4));
            }
        }
        internal struct IsValidVertex_method {
            static internal IntPtr IsValidVertex_ptr;
            static IsValidVertex_method() {
                IsValidVertex_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "IsValidVertex");
            }

            internal static unsafe bool Invoke(IntPtr obj, VertexID VertexID) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((VertexID*)(b+0)) = VertexID;
                Main.GetProcessEvent(obj, IsValidVertex_ptr, new IntPtr(p)); ;
                return *((bool*)(b+4));
            }
        }
        internal struct MakeEdgeID_method {
            static internal IntPtr MakeEdgeID_ptr;
            static MakeEdgeID_method() {
                MakeEdgeID_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "MakeEdgeID");
            }

            internal static unsafe EdgeID Invoke(int EdgeIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = EdgeIndex;
                Main.GetProcessEvent(EditableMesh.DefaultObject, MakeEdgeID_ptr, new IntPtr(p)); ;
                return *((EdgeID*)(b+4));
            }
        }
        internal struct MakePolygonGroupID_method {
            static internal IntPtr MakePolygonGroupID_ptr;
            static MakePolygonGroupID_method() {
                MakePolygonGroupID_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "MakePolygonGroupID");
            }

            internal static unsafe PolygonGroupID Invoke(int PolygonGroupIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PolygonGroupIndex;
                Main.GetProcessEvent(EditableMesh.DefaultObject, MakePolygonGroupID_ptr, new IntPtr(p)); ;
                return *((PolygonGroupID*)(b+4));
            }
        }
        internal struct MakePolygonID_method {
            static internal IntPtr MakePolygonID_ptr;
            static MakePolygonID_method() {
                MakePolygonID_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "MakePolygonID");
            }

            internal static unsafe PolygonID Invoke(int PolygonIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PolygonIndex;
                Main.GetProcessEvent(EditableMesh.DefaultObject, MakePolygonID_ptr, new IntPtr(p)); ;
                return *((PolygonID*)(b+4));
            }
        }
        internal struct MakeVertexID_method {
            static internal IntPtr MakeVertexID_ptr;
            static MakeVertexID_method() {
                MakeVertexID_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "MakeVertexID");
            }

            internal static unsafe VertexID Invoke(int VertexIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = VertexIndex;
                Main.GetProcessEvent(EditableMesh.DefaultObject, MakeVertexID_ptr, new IntPtr(p)); ;
                return *((VertexID*)(b+4));
            }
        }
        internal struct MoveVertices_method {
            static internal IntPtr MoveVertices_ptr;
            static MoveVertices_method() {
                MoveVertices_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "MoveVertices");
            }

            internal static unsafe void Invoke(IntPtr obj, byte VerticesToMove /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray VerticesToMove
                Main.GetProcessEvent(obj, MoveVertices_ptr, new IntPtr(p)); ;
                 //TODO: array TArray VerticesToMove
            }
        }
        internal struct PropagateInstanceChanges_method {
            static internal IntPtr PropagateInstanceChanges_ptr;
            static PropagateInstanceChanges_method() {
                PropagateInstanceChanges_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "PropagateInstanceChanges");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, PropagateInstanceChanges_ptr, new IntPtr(p)); ;
            }
        }
        internal struct QuadrangulateMesh_method {
            static internal IntPtr QuadrangulateMesh_ptr;
            static QuadrangulateMesh_method() {
                QuadrangulateMesh_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "QuadrangulateMesh");
            }

            internal static unsafe IReadOnlyCollection<PolygonID> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, QuadrangulateMesh_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutNewPolygonIDs
                return UObject.ToUnmangedCollection<PolygonID>(b+0);
            }
        }
        internal struct RebuildRenderMesh_method {
            static internal IntPtr RebuildRenderMesh_ptr;
            static RebuildRenderMesh_method() {
                RebuildRenderMesh_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "RebuildRenderMesh");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, RebuildRenderMesh_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemovePolygonPerimeterVertices_method {
            static internal IntPtr RemovePolygonPerimeterVertices_ptr;
            static RemovePolygonPerimeterVertices_method() {
                RemovePolygonPerimeterVertices_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "RemovePolygonPerimeterVertices");
            }

            internal static unsafe void Invoke(IntPtr obj, PolygonID PolygonID, int FirstVertexNumberToRemove, int NumVerticesToRemove, bool bDeleteOrphanedVertexInstances) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((PolygonID*)(b+0)) = PolygonID;
                *((int*)(b+4)) = FirstVertexNumberToRemove;
                *((int*)(b+8)) = NumVerticesToRemove;
                *((bool*)(b+12)) = bDeleteOrphanedVertexInstances;
                Main.GetProcessEvent(obj, RemovePolygonPerimeterVertices_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Revert_method {
            static internal IntPtr Revert_ptr;
            static Revert_method() {
                Revert_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "Revert");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Revert_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RevertInstance_method {
            static internal IntPtr RevertInstance_ptr;
            static RevertInstance_method() {
                RevertInstance_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "RevertInstance");
            }

            internal static unsafe UE4.EditableMesh.EditableMesh Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, RevertInstance_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct SearchSpatialDatabaseForPolygonsPotentiallyIntersectingLineSegment_method {
            static internal IntPtr SearchSpatialDatabaseForPolygonsPotentiallyIntersectingLineSegment_ptr;
            static SearchSpatialDatabaseForPolygonsPotentiallyIntersectingLineSegment_method() {
                SearchSpatialDatabaseForPolygonsPotentiallyIntersectingLineSegment_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "SearchSpatialDatabaseForPolygonsPotentiallyIntersectingLineSegment");
            }

            internal static unsafe IReadOnlyCollection<PolygonID> Invoke(IntPtr obj, Vector LineSegmentStart, Vector LineSegmentEnd) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = LineSegmentStart;
                *((Vector*)(b+12)) = LineSegmentEnd;
                Main.GetProcessEvent(obj, SearchSpatialDatabaseForPolygonsPotentiallyIntersectingLineSegment_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutPolygons
                return UObject.ToUnmangedCollection<PolygonID>(b+24);
            }
        }
        internal struct SetAllowCompact_method {
            static internal IntPtr SetAllowCompact_ptr;
            static SetAllowCompact_method() {
                SetAllowCompact_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "SetAllowCompact");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInAllowCompact) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInAllowCompact;
                Main.GetProcessEvent(obj, SetAllowCompact_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAllowSpatialDatabase_method {
            static internal IntPtr SetAllowSpatialDatabase_ptr;
            static SetAllowSpatialDatabase_method() {
                SetAllowSpatialDatabase_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "SetAllowSpatialDatabase");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInAllowSpatialDatabase) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInAllowSpatialDatabase;
                Main.GetProcessEvent(obj, SetAllowSpatialDatabase_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAllowUndo_method {
            static internal IntPtr SetAllowUndo_ptr;
            static SetAllowUndo_method() {
                SetAllowUndo_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "SetAllowUndo");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInAllowUndo) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInAllowUndo;
                Main.GetProcessEvent(obj, SetAllowUndo_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetEdgesAttributes_method {
            static internal IntPtr SetEdgesAttributes_ptr;
            static SetEdgesAttributes_method() {
                SetEdgesAttributes_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "SetEdgesAttributes");
            }

            internal static unsafe void Invoke(IntPtr obj, byte AttributesForEdges /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray AttributesForEdges
                Main.GetProcessEvent(obj, SetEdgesAttributes_ptr, new IntPtr(p)); ;
                 //TODO: array TArray AttributesForEdges
            }
        }
        internal struct SetEdgesCreaseSharpness_method {
            static internal IntPtr SetEdgesCreaseSharpness_ptr;
            static SetEdgesCreaseSharpness_method() {
                SetEdgesCreaseSharpness_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "SetEdgesCreaseSharpness");
            }

            internal static unsafe void Invoke(IntPtr obj, byte EdgeIDs /*TODO: array TArray */, byte EdgesNewCreaseSharpness /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray EdgeIDs
                throw new NotImplementedException(); //TODO: array TArray EdgesNewCreaseSharpness
                Main.GetProcessEvent(obj, SetEdgesCreaseSharpness_ptr, new IntPtr(p)); ;
                 //TODO: array TArray EdgeIDs
                 //TODO: array TArray EdgesNewCreaseSharpness
            }
        }
        internal struct SetEdgesHardness_method {
            static internal IntPtr SetEdgesHardness_ptr;
            static SetEdgesHardness_method() {
                SetEdgesHardness_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "SetEdgesHardness");
            }

            internal static unsafe void Invoke(IntPtr obj, byte EdgeIDs /*TODO: array TArray */, byte EdgesNewIsHard /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray EdgeIDs
                throw new NotImplementedException(); //TODO: array TArray EdgesNewIsHard
                Main.GetProcessEvent(obj, SetEdgesHardness_ptr, new IntPtr(p)); ;
                 //TODO: array TArray EdgeIDs
                 //TODO: array TArray EdgesNewIsHard
            }
        }
        internal struct SetEdgesHardnessAutomatically_method {
            static internal IntPtr SetEdgesHardnessAutomatically_ptr;
            static SetEdgesHardnessAutomatically_method() {
                SetEdgesHardnessAutomatically_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "SetEdgesHardnessAutomatically");
            }

            internal static unsafe void Invoke(IntPtr obj, byte EdgeIDs /*TODO: array TArray */, float MaxDotProductForSoftEdge) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray EdgeIDs
                *((float*)(b+16)) = MaxDotProductForSoftEdge;
                Main.GetProcessEvent(obj, SetEdgesHardnessAutomatically_ptr, new IntPtr(p)); ;
                 //TODO: array TArray EdgeIDs
            }
        }
        internal struct SetEdgesVertices_method {
            static internal IntPtr SetEdgesVertices_ptr;
            static SetEdgesVertices_method() {
                SetEdgesVertices_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "SetEdgesVertices");
            }

            internal static unsafe void Invoke(IntPtr obj, byte VerticesForEdges /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray VerticesForEdges
                Main.GetProcessEvent(obj, SetEdgesVertices_ptr, new IntPtr(p)); ;
                 //TODO: array TArray VerticesForEdges
            }
        }
        internal struct SetPolygonsVertexAttributes_method {
            static internal IntPtr SetPolygonsVertexAttributes_ptr;
            static SetPolygonsVertexAttributes_method() {
                SetPolygonsVertexAttributes_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "SetPolygonsVertexAttributes");
            }

            internal static unsafe void Invoke(IntPtr obj, byte VertexAttributesForPolygons /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray VertexAttributesForPolygons
                Main.GetProcessEvent(obj, SetPolygonsVertexAttributes_ptr, new IntPtr(p)); ;
                 //TODO: array TArray VertexAttributesForPolygons
            }
        }
        internal struct SetSubdivisionCount_method {
            static internal IntPtr SetSubdivisionCount_ptr;
            static SetSubdivisionCount_method() {
                SetSubdivisionCount_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "SetSubdivisionCount");
            }

            internal static unsafe void Invoke(IntPtr obj, int NewSubdivisionCount) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = NewSubdivisionCount;
                Main.GetProcessEvent(obj, SetSubdivisionCount_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTextureCoordinateCount_method {
            static internal IntPtr SetTextureCoordinateCount_ptr;
            static SetTextureCoordinateCount_method() {
                SetTextureCoordinateCount_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "SetTextureCoordinateCount");
            }

            internal static unsafe void Invoke(IntPtr obj, int NumTexCoords) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = NumTexCoords;
                Main.GetProcessEvent(obj, SetTextureCoordinateCount_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVertexInstancesAttributes_method {
            static internal IntPtr SetVertexInstancesAttributes_ptr;
            static SetVertexInstancesAttributes_method() {
                SetVertexInstancesAttributes_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "SetVertexInstancesAttributes");
            }

            internal static unsafe void Invoke(IntPtr obj, byte AttributesForVertexInstances /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray AttributesForVertexInstances
                Main.GetProcessEvent(obj, SetVertexInstancesAttributes_ptr, new IntPtr(p)); ;
                 //TODO: array TArray AttributesForVertexInstances
            }
        }
        internal struct SetVerticesAttributes_method {
            static internal IntPtr SetVerticesAttributes_ptr;
            static SetVerticesAttributes_method() {
                SetVerticesAttributes_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "SetVerticesAttributes");
            }

            internal static unsafe void Invoke(IntPtr obj, byte AttributesForVertices /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray AttributesForVertices
                Main.GetProcessEvent(obj, SetVerticesAttributes_ptr, new IntPtr(p)); ;
                 //TODO: array TArray AttributesForVertices
            }
        }
        internal struct SetVerticesCornerSharpness_method {
            static internal IntPtr SetVerticesCornerSharpness_ptr;
            static SetVerticesCornerSharpness_method() {
                SetVerticesCornerSharpness_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "SetVerticesCornerSharpness");
            }

            internal static unsafe void Invoke(IntPtr obj, byte VertexIDs /*TODO: array TArray */, byte VerticesNewCornerSharpness /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray VertexIDs
                throw new NotImplementedException(); //TODO: array TArray VerticesNewCornerSharpness
                Main.GetProcessEvent(obj, SetVerticesCornerSharpness_ptr, new IntPtr(p)); ;
                 //TODO: array TArray VertexIDs
                 //TODO: array TArray VerticesNewCornerSharpness
            }
        }
        internal struct SplitEdge_method {
            static internal IntPtr SplitEdge_ptr;
            static SplitEdge_method() {
                SplitEdge_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "SplitEdge");
            }

            internal static unsafe IReadOnlyCollection<VertexID> Invoke(IntPtr obj, EdgeID EdgeID, byte Splits /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((EdgeID*)(b+0)) = EdgeID;
                throw new NotImplementedException(); //TODO: array TArray Splits
                Main.GetProcessEvent(obj, SplitEdge_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Splits
                 //TODO: array TArray OutNewVertexIDs
                return UObject.ToUnmangedCollection<VertexID>(b+24);
            }
        }
        internal struct SplitPolygons_method {
            static internal IntPtr SplitPolygons_ptr;
            static SplitPolygons_method() {
                SplitPolygons_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "SplitPolygons");
            }

            internal static unsafe IReadOnlyCollection<EdgeID> Invoke(IntPtr obj, byte PolygonsToSplit /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray PolygonsToSplit
                Main.GetProcessEvent(obj, SplitPolygons_ptr, new IntPtr(p)); ;
                 //TODO: array TArray PolygonsToSplit
                 //TODO: array TArray OutNewEdgeIDs
                return UObject.ToUnmangedCollection<EdgeID>(b+16);
            }
        }
        internal struct StartModification_method {
            static internal IntPtr StartModification_ptr;
            static StartModification_method() {
                StartModification_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "StartModification");
            }

            internal static unsafe void Invoke(IntPtr obj, EMeshModificationType MeshModificationType, EMeshTopologyChange MeshTopologyChange) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)MeshModificationType;
                *(b+1) = (byte)MeshTopologyChange;
                Main.GetProcessEvent(obj, StartModification_ptr, new IntPtr(p)); ;
            }
        }
        internal struct TessellatePolygons_method {
            static internal IntPtr TessellatePolygons_ptr;
            static TessellatePolygons_method() {
                TessellatePolygons_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "TessellatePolygons");
            }

            internal static unsafe IReadOnlyCollection<PolygonID> Invoke(IntPtr obj, byte PolygonIDs /*TODO: array TArray */, ETriangleTessellationMode TriangleTessellationMode) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray PolygonIDs
                *(b+16) = (byte)TriangleTessellationMode;
                Main.GetProcessEvent(obj, TessellatePolygons_ptr, new IntPtr(p)); ;
                 //TODO: array TArray PolygonIDs
                 //TODO: array TArray OutNewPolygonIDs
                return UObject.ToUnmangedCollection<PolygonID>(b+24);
            }
        }
        internal struct TriangulatePolygons_method {
            static internal IntPtr TriangulatePolygons_ptr;
            static TriangulatePolygons_method() {
                TriangulatePolygons_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "TriangulatePolygons");
            }

            internal static unsafe IReadOnlyCollection<PolygonID> Invoke(IntPtr obj, byte PolygonIDs /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray PolygonIDs
                Main.GetProcessEvent(obj, TriangulatePolygons_ptr, new IntPtr(p)); ;
                 //TODO: array TArray PolygonIDs
                 //TODO: array TArray OutNewTrianglePolygons
                return UObject.ToUnmangedCollection<PolygonID>(b+16);
            }
        }
        internal struct TryToRemovePolygonEdge_method {
            static internal IntPtr TryToRemovePolygonEdge_ptr;
            static TryToRemovePolygonEdge_method() {
                TryToRemovePolygonEdge_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "TryToRemovePolygonEdge");
            }

            internal static unsafe (bool, PolygonID) Invoke(IntPtr obj, EdgeID EdgeID) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((EdgeID*)(b+0)) = EdgeID;
                Main.GetProcessEvent(obj, TryToRemovePolygonEdge_ptr, new IntPtr(p)); ;
                return (*((bool*)(b+4)),*((PolygonID*)(b+8)));
            }
        }
        internal struct TryToRemoveVertex_method {
            static internal IntPtr TryToRemoveVertex_ptr;
            static TryToRemoveVertex_method() {
                TryToRemoveVertex_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "TryToRemoveVertex");
            }

            internal static unsafe (bool, EdgeID) Invoke(IntPtr obj, VertexID VertexID) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((VertexID*)(b+0)) = VertexID;
                Main.GetProcessEvent(obj, TryToRemoveVertex_ptr, new IntPtr(p)); ;
                return (*((bool*)(b+4)),*((EdgeID*)(b+8)));
            }
        }
        internal struct WeldVertices_method {
            static internal IntPtr WeldVertices_ptr;
            static WeldVertices_method() {
                WeldVertices_ptr = Main.GetMethodUFunction(EditableMesh.StaticClass, "WeldVertices");
            }

            internal static unsafe VertexID Invoke(IntPtr obj, byte VertexIDs /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray VertexIDs
                Main.GetProcessEvent(obj, WeldVertices_ptr, new IntPtr(p)); ;
                 //TODO: array TArray VertexIDs
                return *((VertexID*)(b+16));
            }
        }
    }
    internal unsafe struct EditableMesh_events {
    }
}
