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
using UE4.EditableMesh.Native;
using UE4.MeshDescription;
using UE4.Engine;

namespace UE4.EditableMesh {
    ///<summary>Editable Mesh</summary>
    public unsafe partial class EditableMesh : UObject  {

        ///<summary>@return      Returns true if there are any existing tracked changes that can be undo right now</summary>
        public bool AnyChangesToUndo()  => 
            EditableMesh_methods.AnyChangesToUndo_method.Invoke(ObjPointer);

        ///<summary>Assign Polygons to Polygon Groups</summary>
        public void AssignPolygonsToPolygonGroups(byte PolygonGroupForPolygons /*TODO: array TArray */, bool bDeleteOrphanedPolygonGroups)  => 
            EditableMesh_methods.AssignPolygonsToPolygonGroups_method.Invoke(ObjPointer, PolygonGroupForPolygons, bDeleteOrphanedPolygonGroups);

        ///<summary>Bevel Polygons</summary>
        public (IReadOnlyCollection<PolygonID>, IReadOnlyCollection<PolygonID>) BevelPolygons(byte PolygonIDs /*TODO: array TArray */, float BevelFixedDistance, float BevelProgressTowardCenter)  => 
            EditableMesh_methods.BevelPolygons_method.Invoke(ObjPointer, PolygonIDs, BevelFixedDistance, BevelProgressTowardCenter);

        ///<summary>Change Polygons Vertex Instances</summary>
        public void ChangePolygonsVertexInstances(byte VertexInstancesForPolygons /*TODO: array TArray */)  => 
            EditableMesh_methods.ChangePolygonsVertexInstances_method.Invoke(ObjPointer, VertexInstancesForPolygons);

        ///<summary>Commit</summary>
        public void Commit()  => 
            EditableMesh_methods.Commit_method.Invoke(ObjPointer);

        ///<summary>Commit Instance</summary>
        public UE4.EditableMesh.EditableMesh CommitInstance(PrimitiveComponent ComponentToInstanceTo)  => 
            EditableMesh_methods.CommitInstance_method.Invoke(ObjPointer, ComponentToInstanceTo);

        ///<summary>Compute Barycentric Weight for Point on Polygon</summary>
        public (MeshTriangle, Vector, bool) ComputeBarycentricWeightForPointOnPolygon(PolygonID PolygonID, Vector PointOnPolygon)  => 
            EditableMesh_methods.ComputeBarycentricWeightForPointOnPolygon_method.Invoke(ObjPointer, PolygonID, PointOnPolygon);

        ///<summary>Compute Bounding Box</summary>
        public Box ComputeBoundingBox()  => 
            EditableMesh_methods.ComputeBoundingBox_method.Invoke(ObjPointer);

        ///<summary>Compute Bounding Box and Sphere</summary>
        public BoxSphereBounds ComputeBoundingBoxAndSphere()  => 
            EditableMesh_methods.ComputeBoundingBoxAndSphere_method.Invoke(ObjPointer);

        ///<summary>Compute Polygon Center</summary>
        public Vector ComputePolygonCenter(PolygonID PolygonID)  => 
            EditableMesh_methods.ComputePolygonCenter_method.Invoke(ObjPointer, PolygonID);

        ///<summary>Compute Polygon Normal</summary>
        public Vector ComputePolygonNormal(PolygonID PolygonID)  => 
            EditableMesh_methods.ComputePolygonNormal_method.Invoke(ObjPointer, PolygonID);

        ///<summary>Compute Polygon Plane</summary>
        public Plane ComputePolygonPlane(PolygonID PolygonID)  => 
            EditableMesh_methods.ComputePolygonPlane_method.Invoke(ObjPointer, PolygonID);

        ///<summary>Compute Polygons Shared Edges</summary>
        public IReadOnlyCollection<EdgeID> ComputePolygonsSharedEdges(byte PolygonIDs /*TODO: array TArray */)  => 
            EditableMesh_methods.ComputePolygonsSharedEdges_method.Invoke(ObjPointer, PolygonIDs);

        ///<summary>Compute Polygon Triangulation</summary>
        public IReadOnlyCollection<MeshTriangle> ComputePolygonTriangulation(PolygonID PolygonID)  => 
            EditableMesh_methods.ComputePolygonTriangulation_method.Invoke(ObjPointer, PolygonID);

        ///<summary>Create Edges</summary>
        public IReadOnlyCollection<EdgeID> CreateEdges(byte EdgesToCreate /*TODO: array TArray */)  => 
            EditableMesh_methods.CreateEdges_method.Invoke(ObjPointer, EdgesToCreate);

        ///<summary>Create Empty Vertex Range</summary>
        public IReadOnlyCollection<VertexID> CreateEmptyVertexRange(int NumVerticesToCreate)  => 
            EditableMesh_methods.CreateEmptyVertexRange_method.Invoke(ObjPointer, NumVerticesToCreate);

        ///<summary>Create Missing Polygon Hole Edges</summary>
        public IReadOnlyCollection<EdgeID> CreateMissingPolygonHoleEdges(PolygonID PolygonID, int HoleNumber)  => 
            EditableMesh_methods.CreateMissingPolygonHoleEdges_method.Invoke(ObjPointer, PolygonID, HoleNumber);

        ///<summary>Create Missing Polygon Perimeter Edges</summary>
        public IReadOnlyCollection<EdgeID> CreateMissingPolygonPerimeterEdges(PolygonID PolygonID)  => 
            EditableMesh_methods.CreateMissingPolygonPerimeterEdges_method.Invoke(ObjPointer, PolygonID);

        ///<summary>Create Polygon Groups</summary>
        public IReadOnlyCollection<PolygonGroupID> CreatePolygonGroups(byte PolygonGroupsToCreate /*TODO: array TArray */)  => 
            EditableMesh_methods.CreatePolygonGroups_method.Invoke(ObjPointer, PolygonGroupsToCreate);

        ///<summary>Create Polygons</summary>
        public (IReadOnlyCollection<PolygonID>, IReadOnlyCollection<EdgeID>) CreatePolygons(byte PolygonsToCreate /*TODO: array TArray */)  => 
            EditableMesh_methods.CreatePolygons_method.Invoke(ObjPointer, PolygonsToCreate);

        ///<summary>Create Vertex Instances</summary>
        public IReadOnlyCollection<VertexInstanceID> CreateVertexInstances(byte VertexInstancesToCreate /*TODO: array TArray */)  => 
            EditableMesh_methods.CreateVertexInstances_method.Invoke(ObjPointer, VertexInstancesToCreate);

        ///<summary>Create Vertices</summary>
        public IReadOnlyCollection<VertexID> CreateVertices(byte VerticesToCreate /*TODO: array TArray */)  => 
            EditableMesh_methods.CreateVertices_method.Invoke(ObjPointer, VerticesToCreate);

        ///<summary>Delete Edge and Connected Polygons</summary>
        public void DeleteEdgeAndConnectedPolygons(EdgeID EdgeID, bool bDeleteOrphanedEdges, bool bDeleteOrphanedVertices, bool bDeleteOrphanedVertexInstances, bool bDeleteEmptyPolygonGroups)  => 
            EditableMesh_methods.DeleteEdgeAndConnectedPolygons_method.Invoke(ObjPointer, EdgeID, bDeleteOrphanedEdges, bDeleteOrphanedVertices, bDeleteOrphanedVertexInstances, bDeleteEmptyPolygonGroups);

        ///<summary>Delete Edges</summary>
        public void DeleteEdges(byte EdgeIDsToDelete /*TODO: array TArray */, bool bDeleteOrphanedVertices)  => 
            EditableMesh_methods.DeleteEdges_method.Invoke(ObjPointer, EdgeIDsToDelete, bDeleteOrphanedVertices);

        ///<summary>Delete Orphan Vertices</summary>
        public void DeleteOrphanVertices(byte VertexIDsToDelete /*TODO: array TArray */)  => 
            EditableMesh_methods.DeleteOrphanVertices_method.Invoke(ObjPointer, VertexIDsToDelete);

        ///<summary>Delete Polygon Groups</summary>
        public void DeletePolygonGroups(byte PolygonGroupIDs /*TODO: array TArray */)  => 
            EditableMesh_methods.DeletePolygonGroups_method.Invoke(ObjPointer, PolygonGroupIDs);

        ///<summary>Delete Polygons</summary>
        public void DeletePolygons(byte PolygonIDsToDelete /*TODO: array TArray */, bool bDeleteOrphanedEdges, bool bDeleteOrphanedVertices, bool bDeleteOrphanedVertexInstances, bool bDeleteEmptyPolygonGroups)  => 
            EditableMesh_methods.DeletePolygons_method.Invoke(ObjPointer, PolygonIDsToDelete, bDeleteOrphanedEdges, bDeleteOrphanedVertices, bDeleteOrphanedVertexInstances, bDeleteEmptyPolygonGroups);

        ///<summary>Delete Vertex and Connected Edges and Polygons</summary>
        public void DeleteVertexAndConnectedEdgesAndPolygons(VertexID VertexID, bool bDeleteOrphanedEdges, bool bDeleteOrphanedVertices, bool bDeleteOrphanedVertexInstances, bool bDeleteEmptyPolygonGroups)  => 
            EditableMesh_methods.DeleteVertexAndConnectedEdgesAndPolygons_method.Invoke(ObjPointer, VertexID, bDeleteOrphanedEdges, bDeleteOrphanedVertices, bDeleteOrphanedVertexInstances, bDeleteEmptyPolygonGroups);

        ///<summary>Delete Vertex Instances</summary>
        public void DeleteVertexInstances(byte VertexInstanceIDsToDelete /*TODO: array TArray */, bool bDeleteOrphanedVertices)  => 
            EditableMesh_methods.DeleteVertexInstances_method.Invoke(ObjPointer, VertexInstanceIDsToDelete, bDeleteOrphanedVertices);

        ///<summary>End Modification</summary>
        public void EndModification(bool bFromUndo)  => 
            EditableMesh_methods.EndModification_method.Invoke(ObjPointer, bFromUndo);

        ///<summary>Extend Edges</summary>
        public IReadOnlyCollection<EdgeID> ExtendEdges(byte EdgeIDs /*TODO: array TArray */, bool bWeldNeighbors)  => 
            EditableMesh_methods.ExtendEdges_method.Invoke(ObjPointer, EdgeIDs, bWeldNeighbors);

        ///<summary>Extend Vertices</summary>
        public IReadOnlyCollection<VertexID> ExtendVertices(byte VertexIDs /*TODO: array TArray */, bool bOnlyExtendClosestEdge, Vector ReferencePosition)  => 
            EditableMesh_methods.ExtendVertices_method.Invoke(ObjPointer, VertexIDs, bOnlyExtendClosestEdge, ReferencePosition);

        ///<summary>Extrude Polygons</summary>
        public IReadOnlyCollection<PolygonID> ExtrudePolygons(byte Polygons /*TODO: array TArray */, float ExtrudeDistance, bool bKeepNeighborsTogether)  => 
            EditableMesh_methods.ExtrudePolygons_method.Invoke(ObjPointer, Polygons, ExtrudeDistance, bKeepNeighborsTogether);

        ///<summary>Find Polygon Hole Edge Number for Vertices</summary>
        public int FindPolygonHoleEdgeNumberForVertices(PolygonID PolygonID, int HoleNumber, VertexID EdgeVertexID0, VertexID EdgeVertexID1)  => 
            EditableMesh_methods.FindPolygonHoleEdgeNumberForVertices_method.Invoke(ObjPointer, PolygonID, HoleNumber, EdgeVertexID0, EdgeVertexID1);

        ///<summary>Find Polygon Hole Vertex Number for Vertex</summary>
        public int FindPolygonHoleVertexNumberForVertex(PolygonID PolygonID, int HoleNumber, VertexID VertexID)  => 
            EditableMesh_methods.FindPolygonHoleVertexNumberForVertex_method.Invoke(ObjPointer, PolygonID, HoleNumber, VertexID);

        ///<summary>Find Polygon Loop</summary>
        public (IReadOnlyCollection<EdgeID>, IReadOnlyCollection<EdgeID>, IReadOnlyCollection<EdgeID>, IReadOnlyCollection<PolygonID>) FindPolygonLoop(EdgeID EdgeID)  => 
            EditableMesh_methods.FindPolygonLoop_method.Invoke(ObjPointer, EdgeID);

        ///<summary>Find Polygon Perimeter Edge Number for Vertices</summary>
        public int FindPolygonPerimeterEdgeNumberForVertices(PolygonID PolygonID, VertexID EdgeVertexID0, VertexID EdgeVertexID1)  => 
            EditableMesh_methods.FindPolygonPerimeterEdgeNumberForVertices_method.Invoke(ObjPointer, PolygonID, EdgeVertexID0, EdgeVertexID1);

        ///<summary>Find Polygon Perimeter Vertex Number for Vertex</summary>
        public int FindPolygonPerimeterVertexNumberForVertex(PolygonID PolygonID, VertexID VertexID)  => 
            EditableMesh_methods.FindPolygonPerimeterVertexNumberForVertex_method.Invoke(ObjPointer, PolygonID, VertexID);

        ///<summary>Flip Polygons</summary>
        public void FlipPolygons(byte PolygonIDs /*TODO: array TArray */)  => 
            EditableMesh_methods.FlipPolygons_method.Invoke(ObjPointer, PolygonIDs);

        ///<summary>Generate Polygon Tangents and Normals</summary>
        public void GeneratePolygonTangentsAndNormals(byte PolygonIDs /*TODO: array TArray */)  => 
            EditableMesh_methods.GeneratePolygonTangentsAndNormals_method.Invoke(ObjPointer, PolygonIDs);

        ///<summary>Returns the indexed polygon connected to this edge</summary>
        public PolygonID GetEdgeConnectedPolygon(EdgeID EdgeID, int ConnectedPolygonNumber)  => 
            EditableMesh_methods.GetEdgeConnectedPolygon_method.Invoke(ObjPointer, EdgeID, ConnectedPolygonNumber);

        ///<summary>Returns the number of polygons connected to this edge</summary>
        public int GetEdgeConnectedPolygonCount(EdgeID EdgeID)  => 
            EditableMesh_methods.GetEdgeConnectedPolygonCount_method.Invoke(ObjPointer, EdgeID);

        ///<summary>Get Edge Connected Polygons</summary>
        public IReadOnlyCollection<PolygonID> GetEdgeConnectedPolygons(EdgeID EdgeID)  => 
            EditableMesh_methods.GetEdgeConnectedPolygons_method.Invoke(ObjPointer, EdgeID);

        ///<summary>Returns the number of edges in this mesh</summary>
        public int GetEdgeCount()  => 
            EditableMesh_methods.GetEdgeCount_method.Invoke(ObjPointer);

        ///<summary>Get Edge Loop Elements</summary>
        public IReadOnlyCollection<EdgeID> GetEdgeLoopElements(EdgeID EdgeID)  => 
            EditableMesh_methods.GetEdgeLoopElements_method.Invoke(ObjPointer, EdgeID);

        ///<summary>Get Edge That Connects Vertices</summary>
        public EdgeID GetEdgeThatConnectsVertices(VertexID VertexID0, VertexID VertexID1)  => 
            EditableMesh_methods.GetEdgeThatConnectsVertices_method.Invoke(ObjPointer, VertexID0, VertexID1);

        ///<summary>Returns the given indexed vertex for this edge. EdgeVertexNumber must be 0 or 1.</summary>
        public VertexID GetEdgeVertex(EdgeID EdgeID, int EdgeVertexNumber)  => 
            EditableMesh_methods.GetEdgeVertex_method.Invoke(ObjPointer, EdgeID, EdgeVertexNumber);

        ///<summary>Get Edge Vertices</summary>
        public (VertexID, VertexID) GetEdgeVertices(EdgeID EdgeID)  => 
            EditableMesh_methods.GetEdgeVertices_method.Invoke(ObjPointer, EdgeID);

        ///<summary>Get First Valid Polygon Group</summary>
        public PolygonGroupID GetFirstValidPolygonGroup()  => 
            EditableMesh_methods.GetFirstValidPolygonGroup_method.Invoke(ObjPointer);

        ///<summary>Returns the polygon group this polygon is assigned to</summary>
        public PolygonGroupID GetGroupForPolygon(PolygonID PolygonID)  => 
            EditableMesh_methods.GetGroupForPolygon_method.Invoke(ObjPointer, PolygonID);

        ///<summary>Get Polygon Adjacent Polygons</summary>
        public IReadOnlyCollection<PolygonID> GetPolygonAdjacentPolygons(PolygonID PolygonID)  => 
            EditableMesh_methods.GetPolygonAdjacentPolygons_method.Invoke(ObjPointer, PolygonID);

        ///<summary>Returns the number of polygons in this mesh</summary>
        public int GetPolygonCount()  => 
            EditableMesh_methods.GetPolygonCount_method.Invoke(ObjPointer);

        ///<summary>Returns the number of polygons in this polygon group</summary>
        public int GetPolygonCountInGroup(PolygonGroupID PolygonGroupID)  => 
            EditableMesh_methods.GetPolygonCountInGroup_method.Invoke(ObjPointer, PolygonGroupID);

        ///<summary>Returns the number of polygon groups in this mesh</summary>
        public int GetPolygonGroupCount()  => 
            EditableMesh_methods.GetPolygonGroupCount_method.Invoke(ObjPointer);

        ///<summary>Returns the number of hole contours this polygon has</summary>
        public int GetPolygonHoleCount(PolygonID PolygonID)  => 
            EditableMesh_methods.GetPolygonHoleCount_method.Invoke(ObjPointer, PolygonID);

        ///<summary>Get Polygon Hole Edge</summary>
        public EdgeID GetPolygonHoleEdge(PolygonID PolygonID, int HoleNumber, int HoleEdgeNumber)  => 
            EditableMesh_methods.GetPolygonHoleEdge_method.Invoke(ObjPointer, PolygonID, HoleNumber, HoleEdgeNumber);

        ///<summary>Get Polygon Hole Edge Count</summary>
        public int GetPolygonHoleEdgeCount(PolygonID PolygonID, int HoleNumber)  => 
            EditableMesh_methods.GetPolygonHoleEdgeCount_method.Invoke(ObjPointer, PolygonID, HoleNumber);

        ///<summary>Get Polygon Hole Edges</summary>
        public IReadOnlyCollection<EdgeID> GetPolygonHoleEdges(PolygonID PolygonID, int HoleNumber)  => 
            EditableMesh_methods.GetPolygonHoleEdges_method.Invoke(ObjPointer, PolygonID, HoleNumber);

        ///<summary>Returns the indexed vertex on the given hole contour of the polygon</summary>
        public VertexID GetPolygonHoleVertex(PolygonID PolygonID, int HoleNumber, int PolygonVertexNumber)  => 
            EditableMesh_methods.GetPolygonHoleVertex_method.Invoke(ObjPointer, PolygonID, HoleNumber, PolygonVertexNumber);

        ///<summary>Returns the number of vertices on the indexed hole contour for this polygon</summary>
        public int GetPolygonHoleVertexCount(PolygonID PolygonID, int HoleNumber)  => 
            EditableMesh_methods.GetPolygonHoleVertexCount_method.Invoke(ObjPointer, PolygonID, HoleNumber);

        ///<summary>Returns the indexed vertex instance on the given hole contour of the polygon</summary>
        public VertexInstanceID GetPolygonHoleVertexInstance(PolygonID PolygonID, int HoleNumber, int PolygonVertexNumber)  => 
            EditableMesh_methods.GetPolygonHoleVertexInstance_method.Invoke(ObjPointer, PolygonID, HoleNumber, PolygonVertexNumber);

        ///<summary>Get Polygon Hole Vertex Instances</summary>
        public IReadOnlyCollection<VertexInstanceID> GetPolygonHoleVertexInstances(PolygonID PolygonID, int HoleNumber)  => 
            EditableMesh_methods.GetPolygonHoleVertexInstances_method.Invoke(ObjPointer, PolygonID, HoleNumber);

        ///<summary>Get Polygon Hole Vertices</summary>
        public IReadOnlyCollection<VertexID> GetPolygonHoleVertices(PolygonID PolygonID, int HoleNumber)  => 
            EditableMesh_methods.GetPolygonHoleVertices_method.Invoke(ObjPointer, PolygonID, HoleNumber);

        ///<summary>Returns the given indexed polygon in this polygon group</summary>
        public PolygonID GetPolygonInGroup(PolygonGroupID PolygonGroupID, int PolygonNumber)  => 
            EditableMesh_methods.GetPolygonInGroup_method.Invoke(ObjPointer, PolygonGroupID, PolygonNumber);

        ///<summary>Get Polygon Perimeter Edge</summary>
        public (bool, EdgeID) GetPolygonPerimeterEdge(PolygonID PolygonID, int PerimeterEdgeNumber)  => 
            EditableMesh_methods.GetPolygonPerimeterEdge_method.Invoke(ObjPointer, PolygonID, PerimeterEdgeNumber);

        ///<summary>Get Polygon Perimeter Edge Count</summary>
        public int GetPolygonPerimeterEdgeCount(PolygonID PolygonID)  => 
            EditableMesh_methods.GetPolygonPerimeterEdgeCount_method.Invoke(ObjPointer, PolygonID);

        ///<summary>Get Polygon Perimeter Edges</summary>
        public IReadOnlyCollection<EdgeID> GetPolygonPerimeterEdges(PolygonID PolygonID)  => 
            EditableMesh_methods.GetPolygonPerimeterEdges_method.Invoke(ObjPointer, PolygonID);

        ///<summary>Returns the indexed vertex on this polygon's perimeter</summary>
        public VertexID GetPolygonPerimeterVertex(PolygonID PolygonID, int PolygonVertexNumber)  => 
            EditableMesh_methods.GetPolygonPerimeterVertex_method.Invoke(ObjPointer, PolygonID, PolygonVertexNumber);

        ///<summary>Returns the number of vertices on this polygon's perimeter</summary>
        public int GetPolygonPerimeterVertexCount(PolygonID PolygonID)  => 
            EditableMesh_methods.GetPolygonPerimeterVertexCount_method.Invoke(ObjPointer, PolygonID);

        ///<summary>Returns the indexed vertex instance on this polygon's perimeter</summary>
        public VertexInstanceID GetPolygonPerimeterVertexInstance(PolygonID PolygonID, int PolygonVertexNumber)  => 
            EditableMesh_methods.GetPolygonPerimeterVertexInstance_method.Invoke(ObjPointer, PolygonID, PolygonVertexNumber);

        ///<summary>Get Polygon Perimeter Vertex Instances</summary>
        public IReadOnlyCollection<VertexInstanceID> GetPolygonPerimeterVertexInstances(PolygonID PolygonID)  => 
            EditableMesh_methods.GetPolygonPerimeterVertexInstances_method.Invoke(ObjPointer, PolygonID);

        ///<summary>Get Polygon Perimeter Vertices</summary>
        public IReadOnlyCollection<VertexID> GetPolygonPerimeterVertices(PolygonID PolygonID)  => 
            EditableMesh_methods.GetPolygonPerimeterVertices_method.Invoke(ObjPointer, PolygonID);

        ///<summary>Returns the indexed triangle of the triangulated polygon</summary>
        public MeshTriangle GetPolygonTriangulatedTriangle(PolygonID PolygonID, int PolygonTriangleNumber)  => 
            EditableMesh_methods.GetPolygonTriangulatedTriangle_method.Invoke(ObjPointer, PolygonID, PolygonTriangleNumber);

        ///<summary>Returns the number of triangles which make up this polygon</summary>
        public int GetPolygonTriangulatedTriangleCount(PolygonID PolygonID)  => 
            EditableMesh_methods.GetPolygonTriangulatedTriangleCount_method.Invoke(ObjPointer, PolygonID);

        ///<summary>Get Subdivision Count</summary>
        public int GetSubdivisionCount()  => 
            EditableMesh_methods.GetSubdivisionCount_method.Invoke(ObjPointer);

        ///<summary>Get Subdivision Limit Data</summary>
        public void GetSubdivisionLimitData(SubdivisionLimitData ReturnValue)  => 
            EditableMesh_methods.GetSubdivisionLimitData_method.Invoke(ObjPointer, ReturnValue);

        ///<summary>Get Texture Coordinate Count</summary>
        public int GetTextureCoordinateCount()  => 
            EditableMesh_methods.GetTextureCoordinateCount_method.Invoke(ObjPointer);

        ///<summary>Get Vertex Adjacent Vertices</summary>
        public IReadOnlyCollection<VertexID> GetVertexAdjacentVertices(VertexID VertexID)  => 
            EditableMesh_methods.GetVertexAdjacentVertices_method.Invoke(ObjPointer, VertexID);

        ///<summary>Returns the requested edge connected to this vertex</summary>
        public EdgeID GetVertexConnectedEdge(VertexID VertexID, int ConnectedEdgeNumber)  => 
            EditableMesh_methods.GetVertexConnectedEdge_method.Invoke(ObjPointer, VertexID, ConnectedEdgeNumber);

        ///<summary>Returns the number of edges connected to this vertex</summary>
        public int GetVertexConnectedEdgeCount(VertexID VertexID)  => 
            EditableMesh_methods.GetVertexConnectedEdgeCount_method.Invoke(ObjPointer, VertexID);

        ///<summary>Get Vertex Connected Edges</summary>
        public IReadOnlyCollection<EdgeID> GetVertexConnectedEdges(VertexID VertexID)  => 
            EditableMesh_methods.GetVertexConnectedEdges_method.Invoke(ObjPointer, VertexID);

        ///<summary>Get Vertex Connected Polygons</summary>
        public IReadOnlyCollection<PolygonID> GetVertexConnectedPolygons(VertexID VertexID)  => 
            EditableMesh_methods.GetVertexConnectedPolygons_method.Invoke(ObjPointer, VertexID);

        ///<summary>Returns the number of vertices in this mesh</summary>
        public int GetVertexCount()  => 
            EditableMesh_methods.GetVertexCount_method.Invoke(ObjPointer);

        ///<summary>Returns the indexed polygon connected to this vertex instance</summary>
        public PolygonID GetVertexInstanceConnectedPolygon(VertexInstanceID VertexInstanceID, int ConnectedPolygonNumber)  => 
            EditableMesh_methods.GetVertexInstanceConnectedPolygon_method.Invoke(ObjPointer, VertexInstanceID, ConnectedPolygonNumber);

        ///<summary>Returns the number of polygons connected to this vertex instance</summary>
        public int GetVertexInstanceConnectedPolygonCount(VertexInstanceID VertexInstanceID)  => 
            EditableMesh_methods.GetVertexInstanceConnectedPolygonCount_method.Invoke(ObjPointer, VertexInstanceID);

        ///<summary>Get Vertex Instance Connected Polygons</summary>
        public IReadOnlyCollection<PolygonID> GetVertexInstanceConnectedPolygons(VertexInstanceID VertexInstanceID)  => 
            EditableMesh_methods.GetVertexInstanceConnectedPolygons_method.Invoke(ObjPointer, VertexInstanceID);

        ///<summary>Returns the number of vertex instances in this mesh</summary>
        public int GetVertexInstanceCount()  => 
            EditableMesh_methods.GetVertexInstanceCount_method.Invoke(ObjPointer);

        ///<summary>Returns the vertex ID which the given vertex instance is instancing</summary>
        public VertexID GetVertexInstanceVertex(VertexInstanceID VertexInstanceID)  => 
            EditableMesh_methods.GetVertexInstanceVertex_method.Invoke(ObjPointer, VertexInstanceID);

        ///<summary>Get Vertex Pair Edge</summary>
        public (bool, EdgeID) GetVertexPairEdge(VertexID VertexID, VertexID NextVertexID)  => 
            EditableMesh_methods.GetVertexPairEdge_method.Invoke(ObjPointer, VertexID, NextVertexID);

        ///<summary>Initialize Adapters</summary>
        public void InitializeAdapters()  => 
            EditableMesh_methods.InitializeAdapters_method.Invoke(ObjPointer);

        ///<summary>Insert Edge Loop</summary>
        public IReadOnlyCollection<EdgeID> InsertEdgeLoop(EdgeID EdgeID, byte Splits /*TODO: array TArray */)  => 
            EditableMesh_methods.InsertEdgeLoop_method.Invoke(ObjPointer, EdgeID, Splits);

        ///<summary>Insert Polygon Perimeter Vertices</summary>
        public void InsertPolygonPerimeterVertices(PolygonID PolygonID, int InsertBeforeVertexNumber, byte VerticesToInsert /*TODO: array TArray */)  => 
            EditableMesh_methods.InsertPolygonPerimeterVertices_method.Invoke(ObjPointer, PolygonID, InsertBeforeVertexNumber, VerticesToInsert);

        ///<summary>Inset Polygons</summary>
        public (IReadOnlyCollection<PolygonID>, IReadOnlyCollection<PolygonID>) InsetPolygons(byte PolygonIDs /*TODO: array TArray */, float InsetFixedDistance, float InsetProgressTowardCenter, EInsetPolygonsMode Mode)  => 
            EditableMesh_methods.InsetPolygons_method.Invoke(ObjPointer, PolygonIDs, InsetFixedDistance, InsetProgressTowardCenter, Mode);

        ///<summary>Invalid Edge ID</summary>
        public static EdgeID InvalidEdgeID()  => 
            EditableMesh_methods.InvalidEdgeID_method.Invoke();

        ///<summary>Invalid Polygon Group ID</summary>
        public static PolygonGroupID InvalidPolygonGroupID()  => 
            EditableMesh_methods.InvalidPolygonGroupID_method.Invoke();

        ///<summary>Invalid Polygon ID</summary>
        public static PolygonID InvalidPolygonID()  => 
            EditableMesh_methods.InvalidPolygonID_method.Invoke();

        ///<summary>Statics</summary>
        public static VertexID InvalidVertexID()  => 
            EditableMesh_methods.InvalidVertexID_method.Invoke();

        ///<summary>@return      Returns true if StartModification() was called and the mesh is able to be modified currently.  Remember to call EndModification() when finished.</summary>
        public bool IsBeingModified()  => 
            EditableMesh_methods.IsBeingModified_method.Invoke(ObjPointer);

        ///<summary>Is Committed</summary>
        public bool IsCommitted()  => 
            EditableMesh_methods.IsCommitted_method.Invoke(ObjPointer);

        ///<summary>Is Committed as Instance</summary>
        public bool IsCommittedAsInstance()  => 
            EditableMesh_methods.IsCommittedAsInstance_method.Invoke(ObjPointer);

        ///<summary>@return      Returns true if compaction is enabled on this mesh</summary>
        public bool IsCompactAllowed()  => 
            EditableMesh_methods.IsCompactAllowed_method.Invoke(ObjPointer);

        ///<summary>Returns whether the given vertex ID is orphaned</summary>
        public bool IsOrphanedVertex(VertexID VertexID)  => 
            EditableMesh_methods.IsOrphanedVertex_method.Invoke(ObjPointer, VertexID);

        ///<summary>Is Previewing Subdivisions</summary>
        public bool IsPreviewingSubdivisions()  => 
            EditableMesh_methods.IsPreviewingSubdivisions_method.Invoke(ObjPointer);

        ///<summary>@return      Returns true if our octree spatial database is enabled for this mesh</summary>
        public bool IsSpatialDatabaseAllowed()  => 
            EditableMesh_methods.IsSpatialDatabaseAllowed_method.Invoke(ObjPointer);

        ///<summary>@return      Returns true if undo tracking is enabled on this mesh</summary>
        public bool IsUndoAllowed()  => 
            EditableMesh_methods.IsUndoAllowed_method.Invoke(ObjPointer);

        ///<summary>Returns whether the given edge ID is valid</summary>
        public bool IsValidEdge(EdgeID EdgeID)  => 
            EditableMesh_methods.IsValidEdge_method.Invoke(ObjPointer, EdgeID);

        ///<summary>Returns whether the given polygon ID is valid</summary>
        public bool IsValidPolygon(PolygonID PolygonID)  => 
            EditableMesh_methods.IsValidPolygon_method.Invoke(ObjPointer, PolygonID);

        ///<summary>Returns whether the given polygon group ID is valid</summary>
        public bool IsValidPolygonGroup(PolygonGroupID PolygonGroupID)  => 
            EditableMesh_methods.IsValidPolygonGroup_method.Invoke(ObjPointer, PolygonGroupID);

        ///<summary>Returns whether the given vertex ID is valid</summary>
        public bool IsValidVertex(VertexID VertexID)  => 
            EditableMesh_methods.IsValidVertex_method.Invoke(ObjPointer, VertexID);

        ///<summary>Make Edge ID</summary>
        public static EdgeID MakeEdgeID(int EdgeIndex)  => 
            EditableMesh_methods.MakeEdgeID_method.Invoke(EdgeIndex);

        ///<summary>Make Polygon Group ID</summary>
        public static PolygonGroupID MakePolygonGroupID(int PolygonGroupIndex)  => 
            EditableMesh_methods.MakePolygonGroupID_method.Invoke(PolygonGroupIndex);

        ///<summary>Make Polygon ID</summary>
        public static PolygonID MakePolygonID(int PolygonIndex)  => 
            EditableMesh_methods.MakePolygonID_method.Invoke(PolygonIndex);

        ///<summary>Make Vertex ID</summary>
        public static VertexID MakeVertexID(int VertexIndex)  => 
            EditableMesh_methods.MakeVertexID_method.Invoke(VertexIndex);

        ///<summary>Move Vertices</summary>
        public void MoveVertices(byte VerticesToMove /*TODO: array TArray */)  => 
            EditableMesh_methods.MoveVertices_method.Invoke(ObjPointer, VerticesToMove);

        ///<summary>Propagate Instance Changes</summary>
        public void PropagateInstanceChanges()  => 
            EditableMesh_methods.PropagateInstanceChanges_method.Invoke(ObjPointer);

        ///<summary>Quadrangulate Mesh</summary>
        public IReadOnlyCollection<PolygonID> QuadrangulateMesh()  => 
            EditableMesh_methods.QuadrangulateMesh_method.Invoke(ObjPointer);

        ///<summary>Rebuild Render Mesh</summary>
        public void RebuildRenderMesh()  => 
            EditableMesh_methods.RebuildRenderMesh_method.Invoke(ObjPointer);

        ///<summary>Remove Polygon Perimeter Vertices</summary>
        public void RemovePolygonPerimeterVertices(PolygonID PolygonID, int FirstVertexNumberToRemove, int NumVerticesToRemove, bool bDeleteOrphanedVertexInstances)  => 
            EditableMesh_methods.RemovePolygonPerimeterVertices_method.Invoke(ObjPointer, PolygonID, FirstVertexNumberToRemove, NumVerticesToRemove, bDeleteOrphanedVertexInstances);

        ///<summary>Revert</summary>
        public void Revert()  => 
            EditableMesh_methods.Revert_method.Invoke(ObjPointer);

        ///<summary>Revert Instance</summary>
        public UE4.EditableMesh.EditableMesh RevertInstance()  => 
            EditableMesh_methods.RevertInstance_method.Invoke(ObjPointer);

        ///<summary>Search Spatial Database for Polygons Potentially Intersecting Line Segment</summary>
        public IReadOnlyCollection<PolygonID> SearchSpatialDatabaseForPolygonsPotentiallyIntersectingLineSegment(Vector LineSegmentStart, Vector LineSegmentEnd)  => 
            EditableMesh_methods.SearchSpatialDatabaseForPolygonsPotentiallyIntersectingLineSegment_method.Invoke(ObjPointer, LineSegmentStart, LineSegmentEnd);

        ///<summary>
        ///Sets whether the mesh can be sporadically compacted as modifications are performed
        ///@
        ///</summary>
        ///<remarks>param       bInAllowCompact         True if compaction is enabled on this mesh.</remarks>
        public void SetAllowCompact(bool bInAllowCompact)  => 
            EditableMesh_methods.SetAllowCompact_method.Invoke(ObjPointer, bInAllowCompact);

        ///<summary>Sets whether this mesh should automatically generate and maintain an octree spatial database.</summary>
        ///<remarks>
        ///Certain queries may only be
        ///supported when the mesh has an octree generated.  The octree is never saved or loaded, and always generated on demand.  This
        ///feature adds significant overhead to editable mesh initialization and modification, so only use it if you really need to.
        ///
        ///@param       bInAllowSpatialDatabase         True if an octree should be generated and maintained for this mesh.
        ///</remarks>
        public void SetAllowSpatialDatabase(bool bInAllowSpatialDatabase)  => 
            EditableMesh_methods.SetAllowSpatialDatabase_method.Invoke(ObjPointer, bInAllowSpatialDatabase);

        ///<summary>
        ///Sets whether undo is allowed on this mesh
        ///@
        ///</summary>
        ///<remarks>param       bInAllowUndo    True if undo features are enabled on this mesh.  You're only allowed to call MakeUndo() if this is set to true.</remarks>
        public void SetAllowUndo(bool bInAllowUndo)  => 
            EditableMesh_methods.SetAllowUndo_method.Invoke(ObjPointer, bInAllowUndo);

        ///<summary>Set Edges Attributes</summary>
        public void SetEdgesAttributes(byte AttributesForEdges /*TODO: array TArray */)  => 
            EditableMesh_methods.SetEdgesAttributes_method.Invoke(ObjPointer, AttributesForEdges);

        ///<summary>Set Edges Crease Sharpness</summary>
        public void SetEdgesCreaseSharpness(byte EdgeIDs /*TODO: array TArray */, byte EdgesNewCreaseSharpness /*TODO: array TArray */)  => 
            EditableMesh_methods.SetEdgesCreaseSharpness_method.Invoke(ObjPointer, EdgeIDs, EdgesNewCreaseSharpness);

        ///<summary>Set Edges Hardness</summary>
        public void SetEdgesHardness(byte EdgeIDs /*TODO: array TArray */, byte EdgesNewIsHard /*TODO: array TArray */)  => 
            EditableMesh_methods.SetEdgesHardness_method.Invoke(ObjPointer, EdgeIDs, EdgesNewIsHard);

        ///<summary>Set Edges Hardness Automatically</summary>
        public void SetEdgesHardnessAutomatically(byte EdgeIDs /*TODO: array TArray */, float MaxDotProductForSoftEdge)  => 
            EditableMesh_methods.SetEdgesHardnessAutomatically_method.Invoke(ObjPointer, EdgeIDs, MaxDotProductForSoftEdge);

        ///<summary>@todo mesheditor: Not used for anything yet.  Remove it?  Use it during import/convert?</summary>
        public void SetEdgesVertices(byte VerticesForEdges /*TODO: array TArray */)  => 
            EditableMesh_methods.SetEdgesVertices_method.Invoke(ObjPointer, VerticesForEdges);

        ///<summary>Set Polygons Vertex Attributes</summary>
        public void SetPolygonsVertexAttributes(byte VertexAttributesForPolygons /*TODO: array TArray */)  => 
            EditableMesh_methods.SetPolygonsVertexAttributes_method.Invoke(ObjPointer, VertexAttributesForPolygons);

        ///<summary>Set Subdivision Count</summary>
        public void SetSubdivisionCount(int NewSubdivisionCount)  => 
            EditableMesh_methods.SetSubdivisionCount_method.Invoke(ObjPointer, NewSubdivisionCount);

        ///<summary>Set Texture Coordinate Count</summary>
        public void SetTextureCoordinateCount(int NumTexCoords)  => 
            EditableMesh_methods.SetTextureCoordinateCount_method.Invoke(ObjPointer, NumTexCoords);

        ///<summary>Set Vertex Instances Attributes</summary>
        public void SetVertexInstancesAttributes(byte AttributesForVertexInstances /*TODO: array TArray */)  => 
            EditableMesh_methods.SetVertexInstancesAttributes_method.Invoke(ObjPointer, AttributesForVertexInstances);

        ///<summary>Set Vertices Attributes</summary>
        public void SetVerticesAttributes(byte AttributesForVertices /*TODO: array TArray */)  => 
            EditableMesh_methods.SetVerticesAttributes_method.Invoke(ObjPointer, AttributesForVertices);

        ///<summary>Set Vertices Corner Sharpness</summary>
        public void SetVerticesCornerSharpness(byte VertexIDs /*TODO: array TArray */, byte VerticesNewCornerSharpness /*TODO: array TArray */)  => 
            EditableMesh_methods.SetVerticesCornerSharpness_method.Invoke(ObjPointer, VertexIDs, VerticesNewCornerSharpness);

        ///<summary>Split Edge</summary>
        public IReadOnlyCollection<VertexID> SplitEdge(EdgeID EdgeID, byte Splits /*TODO: array TArray */)  => 
            EditableMesh_methods.SplitEdge_method.Invoke(ObjPointer, EdgeID, Splits);

        ///<summary>Split Polygons</summary>
        public IReadOnlyCollection<EdgeID> SplitPolygons(byte PolygonsToSplit /*TODO: array TArray */)  => 
            EditableMesh_methods.SplitPolygons_method.Invoke(ObjPointer, PolygonsToSplit);

        ///<summary>Start Modification</summary>
        public void StartModification(EMeshModificationType MeshModificationType, EMeshTopologyChange MeshTopologyChange)  => 
            EditableMesh_methods.StartModification_method.Invoke(ObjPointer, MeshModificationType, MeshTopologyChange);

        ///<summary>Tessellate Polygons</summary>
        public IReadOnlyCollection<PolygonID> TessellatePolygons(byte PolygonIDs /*TODO: array TArray */, ETriangleTessellationMode TriangleTessellationMode)  => 
            EditableMesh_methods.TessellatePolygons_method.Invoke(ObjPointer, PolygonIDs, TriangleTessellationMode);

        ///<summary>Triangulate Polygons</summary>
        public IReadOnlyCollection<PolygonID> TriangulatePolygons(byte PolygonIDs /*TODO: array TArray */)  => 
            EditableMesh_methods.TriangulatePolygons_method.Invoke(ObjPointer, PolygonIDs);

        ///<summary>Try to Remove Polygon Edge</summary>
        public (bool, PolygonID) TryToRemovePolygonEdge(EdgeID EdgeID)  => 
            EditableMesh_methods.TryToRemovePolygonEdge_method.Invoke(ObjPointer, EdgeID);

        ///<summary>Try to Remove Vertex</summary>
        public (bool, EdgeID) TryToRemoveVertex(VertexID VertexID)  => 
            EditableMesh_methods.TryToRemoveVertex_method.Invoke(ObjPointer, VertexID);

        ///<summary>Weld Vertices</summary>
        public VertexID WeldVertices(byte VertexIDs /*TODO: array TArray */)  => 
            EditableMesh_methods.WeldVertices_method.Invoke(ObjPointer, VertexIDs);
        ///<summary>Adapters registered with this editable mesh</summary>
        public ObjectArrayField<EditableMeshAdapter> Adapters{ get {
            if(Adapters_store == null) Adapters_store = new ObjectArrayField<EditableMeshAdapter> (&EditableMesh_ptr->Adapters);
            return Adapters_store;
        } }
        private ObjectArrayField<EditableMeshAdapter> Adapters_store;

        ///<summary>The number of texture coordinates stored on the vertices of this mesh</summary>
        public unsafe int TextureCoordinateCount {
            get {return EditableMesh_ptr->TextureCoordinateCount;}
        }
        ///<summary>Counter to determine when we should compact data</summary>
        public unsafe int PendingCompactCounter {
            get {return EditableMesh_ptr->PendingCompactCounter;}
            set {EditableMesh_ptr->PendingCompactCounter = value;}
        }
        ///<summary>How many levels to subdivide this mesh.  Zero will turn off subdivisions</summary>
        public unsafe int SubdivisionCount {
            get {return EditableMesh_ptr->SubdivisionCount;}
        }
        static EditableMesh() {
            StaticClass = Main.GetClass("EditableMesh");
        }
        internal unsafe EditableMesh_fields* EditableMesh_ptr => (EditableMesh_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditableMesh(IntPtr p) => UObject.Make<EditableMesh>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditableMesh DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditableMesh New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
