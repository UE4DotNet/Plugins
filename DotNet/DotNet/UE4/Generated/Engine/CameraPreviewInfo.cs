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
        ///<summary>Preview APawn class for this track</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct CameraPreviewInfo {
            ///<summary>Pawn Class</summary>
            public SubclassOf<Pawn> PawnClass {
                get {return PawnClass_class; }
                set {PawnClass_class = value; }
            }
            [FieldOffset(0)] private IntPtr PawnClass_class;

            [FieldOffset(8)] 
            private IntPtr  AnimSeq_field;
            ///<summary>Anim Seq</summary>
            public AnimSequence AnimSeq {
                get {return AnimSeq_field;}
                set {AnimSeq_field = value;}
            }

            ///<summary>for now this is read-only. It has maintenance issue to be resolved if I enable this.</summary>
            [FieldOffset(16)] Vector Location;

            ///<summary>Rotation</summary>
            [FieldOffset(28)] Rotator Rotation;

            [FieldOffset(40)] 
            private IntPtr  PawnInst_field;
            ///<summary>APawn Inst - CameraAnimInst doesn't really exist in editor *</summary>
            public Pawn PawnInst {
                get {return PawnInst_field;}
                set {PawnInst_field = value;}
            }

        }
}
