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
        ///<summary>This is a mapping table between bone in a particular skeletal mesh and bone of this skeleton set.</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct ReferencePose {
            [FieldOffset(0)] public Name PoseName;

            [FieldOffset(16)] byte ReferencePose_; //TODO: array TArray ReferencePose_

            [FieldOffset(32)] byte SourceReferenceMesh; //TODO: soft object TSoftObjectPtr<USkeletalMesh> SourceReferenceMesh

        }
}
