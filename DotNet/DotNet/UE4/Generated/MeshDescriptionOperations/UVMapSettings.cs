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


namespace UE4.MeshDescriptionOperations{
        ///<summary>UV map generation settings that are exposed to the user for scripting and through the editor</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct UVMapSettings {
            ///<summary>Length, width, height of the UV mapping gizmo</summary>
            [FieldOffset(0)] Vector Size;

            ///<summary>Tiling of the UV mapping</summary>
            [FieldOffset(12)] Vector2D UVTile;

            ///<summary>Position of the UV mapping gizmo</summary>
            [FieldOffset(20)] Vector Position;

            ///<summary>Rotation of the UV mapping gizmo (angles in degrees)</summary>
            [FieldOffset(32)] Rotator Rotation;

            ///<summary>Scale of the UV mapping gizmo</summary>
            [FieldOffset(44)] Vector Scale;

        }
}
