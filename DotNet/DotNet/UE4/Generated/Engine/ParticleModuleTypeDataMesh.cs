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
    ///<summary>Particle Module Type Data Mesh</summary>
    public unsafe partial class ParticleModuleTypeDataMesh : ParticleModuleTypeDataBase  {
        ///<summary>The static mesh to render at the particle positions</summary>
        public unsafe StaticMesh Mesh {
            get {return ParticleModuleTypeDataMesh_ptr->Mesh;}
            set {ParticleModuleTypeDataMesh_ptr->Mesh = value;}
        }
        public bool bUseStaticMeshLODs {
            get {return Main.GetGetBoolPropertyByName(this, "bUseStaticMeshLODs"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseStaticMeshLODs", value); }
        }
        ///<summary>use the static mesh's LOD setup and switch LODs based on largest particle's screen size</summary>
        public unsafe float LODSizeScale {
            get {return ParticleModuleTypeDataMesh_ptr->LODSizeScale;}
            set {ParticleModuleTypeDataMesh_ptr->LODSizeScale = value;}
        }
        public bool CastShadows {
            get {return Main.GetGetBoolPropertyByName(this, "CastShadows"); }
            set {Main.SetGetBoolPropertyByName(this, "CastShadows", value); }
        }
        public bool DoCollisions {
            get {return Main.GetGetBoolPropertyByName(this, "DoCollisions"); }
            set {Main.SetGetBoolPropertyByName(this, "DoCollisions", value); }
        }
        ///<summary>The alignment to use on the meshes emitted.</summary>
        ///<remarks>
        ///The RequiredModule->ScreenAlignment MUST be set to PSA_TypeSpecific to use.
        ///One of the following:
        ///PSMA_MeshFaceCameraWithRoll
        ///        Face the camera allowing for rotation around the mesh-to-camera FVector
        ///        (amount provided by the standard particle sprite rotation).
        ///PSMA_MeshFaceCameraWithSpin
        ///        Face the camera allowing for the mesh to rotate about the tangential axis.
        ///PSMA_MeshFaceCameraWithLockedAxis
        ///        Face the camera while maintaining the up FVector as the locked direction.
        ///</remarks>
        public unsafe byte MeshAlignment {
            get {return ParticleModuleTypeDataMesh_ptr->MeshAlignment;}
            set {ParticleModuleTypeDataMesh_ptr->MeshAlignment = value;}
        }
        public bool bOverrideMaterial {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideMaterial"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverrideMaterial", value); }
        }
        public bool bOverrideDefaultMotionBlurSettings {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideDefaultMotionBlurSettings"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverrideDefaultMotionBlurSettings", value); }
        }
        public bool bEnableMotionBlur {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableMotionBlur"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableMotionBlur", value); }
        }
        ///<summary>The 'pre' rotation pitch (in degrees) to apply to the static mesh used.</summary>
        public unsafe RawDistributionVector RollPitchYawRange {
            get {return ParticleModuleTypeDataMesh_ptr->RollPitchYawRange;}
            set {ParticleModuleTypeDataMesh_ptr->RollPitchYawRange = value;}
        }
        ///<summary>The axis to lock the mesh on.</summary>
        ///<remarks>
        ///This overrides TypeSpecific mesh alignment as well as the LockAxis module.
        ///        EPAL_NONE                -      No locking to an axis.
        ///        EPAL_X                   -      Lock the mesh X-axis facing towards +X.
        ///        EPAL_Y                   -      Lock the mesh X-axis facing towards +Y.
        ///        EPAL_Z                   -      Lock the mesh X-axis facing towards +Z.
        ///        EPAL_NEGATIVE_X  -      Lock the mesh X-axis facing towards -X.
        ///        EPAL_NEGATIVE_Y  -      Lock the mesh X-axis facing towards -Y.
        ///        EPAL_NEGATIVE_Z  -      Lock the mesh X-axis facing towards -Z.
        ///        EPAL_ROTATE_X    -      Ignored for mesh emitters. Treated as EPAL_NONE.
        ///        EPAL_ROTATE_Y    -      Ignored for mesh emitters. Treated as EPAL_NONE.
        ///        EPAL_ROTATE_Z    -      Ignored for mesh emitters. Treated as EPAL_NONE.
        ///</remarks>
        public unsafe byte AxisLockOption {
            get {return ParticleModuleTypeDataMesh_ptr->AxisLockOption;}
            set {ParticleModuleTypeDataMesh_ptr->AxisLockOption = value;}
        }
        public bool bCameraFacing {
            get {return Main.GetGetBoolPropertyByName(this, "bCameraFacing"); }
            set {Main.SetGetBoolPropertyByName(this, "bCameraFacing", value); }
        }
        ///<summary>
        ///The camera facing option to use:
        ///All camera facing options without locked axis assume X-axis will be facing the camera.
        ///</summary>
        ///<remarks>
        ///XAxisFacing_NoUp                                - X-axis camera facing, no attempt to face an axis up or down.
        ///        XAxisFacing_ZUp                                 - X-axis camera facing, Z-axis of the mesh should attempt to point up.
        ///        XAxisFacing_NegativeZUp                 - X-axis camera facing, Z-axis of the mesh should attempt to point down.
        ///        XAxisFacing_YUp                                 - X-axis camera facing, Y-axis of the mesh should attempt to point up.
        ///        XAxisFacing_NegativeYUp                 - X-axis camera facing, Y-axis of the mesh should attempt to point down.
        ///All axis-locked camera facing options assume the AxisLockOption is set. EPAL_NONE will be treated as EPAL_X.
        ///        LockedAxis_ZAxisFacing                  - X-axis locked on AxisLockOption axis, rotate Z-axis of the mesh to face towards camera.
        ///        LockedAxis_NegativeZAxisFacing  - X-axis locked on AxisLockOption axis, rotate Z-axis of the mesh to face away from camera.
        ///        LockedAxis_YAxisFacing                  - X-axis locked on AxisLockOption axis, rotate Y-axis of the mesh to face towards camera.
        ///        LockedAxis_NegativeYAxisFacing  - X-axis locked on AxisLockOption axis, rotate Y-axis of the mesh to face away from camera.
        ///All velocity-aligned options do NOT require the ScreenAlignment be set to PSA_Velocity.
        ///Doing so will result in additional work being performed... (it will orient the mesh twice).
        ///        VelocityAligned_ZAxisFacing         - X-axis aligned to the velocity, rotate the Z-axis of the mesh to face towards camera.
        ///        VelocityAligned_NegativeZAxisFacing - X-axis aligned to the velocity, rotate the Z-axis of the mesh to face away from camera.
        ///        VelocityAligned_YAxisFacing         - X-axis aligned to the velocity, rotate the Y-axis of the mesh to face towards camera.
        ///        VelocityAligned_NegativeYAxisFacing - X-axis aligned to the velocity, rotate the Y-axis of the mesh to face away from camera.
        ///</remarks>
        public unsafe byte CameraFacingOption {
            get {return ParticleModuleTypeDataMesh_ptr->CameraFacingOption;}
            set {ParticleModuleTypeDataMesh_ptr->CameraFacingOption = value;}
        }
        public bool bApplyParticleRotationAsSpin {
            get {return Main.GetGetBoolPropertyByName(this, "bApplyParticleRotationAsSpin"); }
            set {Main.SetGetBoolPropertyByName(this, "bApplyParticleRotationAsSpin", value); }
        }
        public bool bFaceCameraDirectionRatherThanPosition {
            get {return Main.GetGetBoolPropertyByName(this, "bFaceCameraDirectionRatherThanPosition"); }
            set {Main.SetGetBoolPropertyByName(this, "bFaceCameraDirectionRatherThanPosition", value); }
        }
        public bool bCollisionsConsiderPartilceSize {
            get {return Main.GetGetBoolPropertyByName(this, "bCollisionsConsiderPartilceSize"); }
            set {Main.SetGetBoolPropertyByName(this, "bCollisionsConsiderPartilceSize", value); }
        }
        static ParticleModuleTypeDataMesh() {
            StaticClass = Main.GetClass("ParticleModuleTypeDataMesh");
        }
        internal unsafe ParticleModuleTypeDataMesh_fields* ParticleModuleTypeDataMesh_ptr => (ParticleModuleTypeDataMesh_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleTypeDataMesh(IntPtr p) => UObject.Make<ParticleModuleTypeDataMesh>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleTypeDataMesh DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleTypeDataMesh New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
