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


namespace UE4.ProceduralMeshComponent{
        ///<summary>One section of the procedural mesh. Each material has its own section.</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct ProcMeshSection {
            [FieldOffset(0)] byte ProcVertexBuffer; //TODO: array TArray ProcVertexBuffer

            [FieldOffset(16)] byte ProcIndexBuffer; //TODO: array TArray ProcIndexBuffer

            ///<summary>Local bounding box of section</summary>
            [FieldOffset(32)] Box SectionLocalBox;

            [FieldOffset(60)] public bool bEnableCollision;

            [FieldOffset(61)] public bool bSectionVisible;

        }
}
