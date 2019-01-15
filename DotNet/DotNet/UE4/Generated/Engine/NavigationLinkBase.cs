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
        ///<summary>Navigation Link Base</summary>
        [StructLayout( LayoutKind.Explicit, Size=72 )]
        public unsafe struct NavigationLinkBase {
            [FieldOffset(0)] public float LeftProjectHeight;

            [FieldOffset(4)] public float MaxFallDownLength;

            [FieldOffset(8)] public byte Direction;

            [FieldOffset(16)] public float SnapRadius;

            [FieldOffset(20)] public float SnapHeight;

            ///<summary>restrict area only to specified agents</summary>
            [FieldOffset(24)] NavAgentSelector SupportedAgents;

            [FieldOffset(28)] public bool bSupportsAgent0;

            [FieldOffset(28)] public bool bSupportsAgent1;

            [FieldOffset(28)] public bool bSupportsAgent2;

            [FieldOffset(28)] public bool bSupportsAgent3;

            [FieldOffset(28)] public bool bSupportsAgent4;

            [FieldOffset(28)] public bool bSupportsAgent5;

            [FieldOffset(28)] public bool bSupportsAgent6;

            [FieldOffset(28)] public bool bSupportsAgent7;

            [FieldOffset(29)] public bool bSupportsAgent8;

            [FieldOffset(29)] public bool bSupportsAgent9;

            [FieldOffset(29)] public bool bSupportsAgent10;

            [FieldOffset(29)] public bool bSupportsAgent11;

            [FieldOffset(29)] public bool bSupportsAgent12;

            [FieldOffset(29)] public bool bSupportsAgent13;

            [FieldOffset(29)] public bool bSupportsAgent14;

            [FieldOffset(29)] public bool bSupportsAgent15;

            [FieldOffset(32)] byte Description; //TODO: string FString Description

            [FieldOffset(48)] public bool bUseSnapHeight;

            [FieldOffset(48)] public bool bSnapToCheapestArea;

            [FieldOffset(48)] public bool bCustomFlag0;

            [FieldOffset(48)] public bool bCustomFlag1;

            [FieldOffset(48)] public bool bCustomFlag2;

            [FieldOffset(48)] public bool bCustomFlag3;

            [FieldOffset(48)] public bool bCustomFlag4;

            [FieldOffset(48)] public bool bCustomFlag5;

            [FieldOffset(49)] public bool bCustomFlag6;

            [FieldOffset(49)] public bool bCustomFlag7;

            ///<summary>Area type of this link (empty = default)</summary>
            public SubclassOf<NavAreaBase> AreaClass {
                get {return AreaClass_class; }
                set {AreaClass_class = value; }
            }
            [FieldOffset(56)] private IntPtr AreaClass_class;

        }
}
