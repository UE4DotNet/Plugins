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
        ///<summary>Handles attachment replication to clients. Movement replication will not happen while AttachParent is non-nullptr</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct RepAttachment {
            [FieldOffset(0)] 
            private IntPtr  AttachParent_field;
            ///<summary>Attach Parent</summary>
            public Actor AttachParent {
                get {return AttachParent_field;}
                set {AttachParent_field = value;}
            }

            ///<summary>Location Offset</summary>
            [FieldOffset(8)] Vector_NetQuantize100 LocationOffset;

            ///<summary>Relative Scale 3D</summary>
            [FieldOffset(20)] Vector_NetQuantize100 RelativeScale3D;

            ///<summary>Rotation Offset</summary>
            [FieldOffset(32)] Rotator RotationOffset;

            [FieldOffset(44)] public Name AttachSocket;

            [FieldOffset(56)] 
            private IntPtr  AttachComponent_field;
            ///<summary>Attach Component</summary>
            public SceneComponent AttachComponent {
                get {return AttachComponent_field;}
                set {AttachComponent_field = value;}
            }

        }
}
