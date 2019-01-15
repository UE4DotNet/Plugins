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
        ///<summary>Simple Member Reference</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct SimpleMemberReference {
            [FieldOffset(0)] 
            private IntPtr  MemberParent_field;
            ///<summary>Most often the Class that this member is defined in.</summary>
            ///<remarks>
            ///Could be a UPackage
            ///if it is a native delegate signature function (declared globally).
            ///</remarks>
            public UObject MemberParent {
                get {return MemberParent_field;}
                set {MemberParent_field = value;}
            }

            [FieldOffset(8)] public Name MemberName;

            ///<summary>The Guid of the member</summary>
            [FieldOffset(20)] FGuid MemberGuid;

        }
}
