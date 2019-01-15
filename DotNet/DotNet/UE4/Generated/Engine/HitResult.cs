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


namespace UE4.Engine{
        ///<summary>Structure containing information about one hit of a trace, such as point of impact and surface normal at that point.</summary>
        [StructLayout( LayoutKind.Explicit, Size=144 )]
        public unsafe struct HitResult {
            [FieldOffset(0)] public bool bBlockingHit;

            [FieldOffset(0)] public bool bStartPenetrating;

            [FieldOffset(4)] public int FaceIndex;

            [FieldOffset(8)] public float Time;

            [FieldOffset(12)] public float Distance;

            ///<summary>The location in world space where the moving shape would end up against the impacted object, if there is a hit.</summary>
            ///<remarks>
            ///Equal to the point of impact for line tests.
            ///Example: for a sphere trace test, this is the point where the center of the sphere would be located when it touched the other object.
            ///For swept movement (but not queries) this may not equal the final location of the shape since hits are pulled back slightly to prevent precision issues from overlapping another surface.
            ///</remarks>
            [FieldOffset(16)] Vector_NetQuantize Location;

            ///<summary>Location in world space of the actual contact of the trace shape (box, sphere, ray, etc) with the impacted object.</summary>
            ///<remarks>
            ///Example: for a sphere trace test, this is the point where the surface of the sphere touches the other object.
            ///@note: In the case of initial overlap (bStartPenetrating=true), ImpactPoint will be the same as Location because there is no meaningful single impact point to report.
            ///</remarks>
            [FieldOffset(28)] Vector_NetQuantize ImpactPoint;

            ///<summary>Normal of the hit in world space, for the object that was swept.</summary>
            ///<remarks>
            ///Equal to ImpactNormal for line tests.
            ///This is computed for capsules and spheres, otherwise it will be the same as ImpactNormal.
            ///Example: for a sphere trace test, this is a normalized vector pointing in towards the center of the sphere at the point of impact.
            ///</remarks>
            [FieldOffset(40)] Vector_NetQuantizeNormal Normal;

            ///<summary>Normal of the hit in world space, for the object that was hit by the sweep, if any.</summary>
            ///<remarks>
            ///For example if a box hits a flat plane, this is a normalized vector pointing out from the plane.
            ///In the case of impact with a corner or edge of a surface, usually the "most opposing" normal (opposed to the query direction) is chosen.
            ///</remarks>
            [FieldOffset(52)] Vector_NetQuantizeNormal ImpactNormal;

            ///<summary>Start location of the trace.</summary>
            ///<remarks>For example if a sphere is swept against the world, this is the starting location of the center of the sphere.</remarks>
            [FieldOffset(64)] Vector_NetQuantize TraceStart;

            ///<summary>End location of the trace; this is NOT where the impact occurred (if any), but the furthest point in the attempted sweep.</summary>
            ///<remarks>For example if a sphere is swept against the world, this would be the center of the sphere if there was no blocking hit.</remarks>
            [FieldOffset(76)] Vector_NetQuantize TraceEnd;

            [FieldOffset(88)] public float PenetrationDepth;

            [FieldOffset(92)] public int Item;

            [FieldOffset(96)] byte PhysMaterial; //TODO: weak object TWeakObjectPtr<UPhysicalMaterial> PhysMaterial

            [FieldOffset(104)] byte Actor; //TODO: weak object TWeakObjectPtr<AActor> Actor

            [FieldOffset(112)] byte Component; //TODO: weak object TWeakObjectPtr<UPrimitiveComponent> Component

            [FieldOffset(120)] public Name BoneName;

            [FieldOffset(132)] public Name MyBoneName;

        }
}
