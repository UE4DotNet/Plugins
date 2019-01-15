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
        ///<summary>Struct used to define information for terminal types, e.</summary>
        ///<remarks>
        ///g. types that can be contained
        ///by a container. Currently can represent strong/weak references to a type (only UObjects),
        ///a structure, or a primitive. Support for "Container of Containers" is done by wrapping
        ///a structure, rather than implicitly defining names for containers.
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=36 )]
        public unsafe struct EdGraphTerminalType {
            [FieldOffset(0)] public Name TerminalCategory;

            [FieldOffset(12)] public Name TerminalSubCategory;

            [FieldOffset(24)] byte TerminalSubCategoryObject; //TODO: weak object TWeakObjectPtr<UObject> TerminalSubCategoryObject

            [FieldOffset(32)] public bool bTerminalIsConst;

            [FieldOffset(33)] public bool bTerminalIsWeakPointer;

        }
}
