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
        ///<summary>@</summary>
        ///<remarks>
        ///TODO: this can encapsulate globally defined fields as well (like with native
        ///       delegate signatures); consider renaming to FFieldReference
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct MemberReference {
            [FieldOffset(0)] 
            private IntPtr  MemberParent_field;
            ///<summary>Most often the Class that this member is defined in.</summary>
            ///<remarks>
            ///Could be a UPackage
            ///if it is a native delegate signature function (declared globally). Should
            ///be NULL if bSelfContext is true.
            ///</remarks>
            public UObject MemberParent {
                get {return MemberParent_field;}
                set {MemberParent_field = value;}
            }

            [FieldOffset(8)] byte MemberScope; //TODO: string FString MemberScope

            [FieldOffset(24)] public Name MemberName;

            ///<summary>The Guid of the variable</summary>
            [FieldOffset(36)] FGuid MemberGuid;

            [FieldOffset(52)] public bool bSelfContext;

            [FieldOffset(53)] public bool bWasDeprecated;

        }
}
