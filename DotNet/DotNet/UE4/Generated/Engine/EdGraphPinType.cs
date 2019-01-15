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
        ///<summary>Struct used to define the type of information carried on this pin</summary>
        [StructLayout( LayoutKind.Explicit, Size=112 )]
        public unsafe struct EdGraphPinType {
            [FieldOffset(0)] public Name PinCategory;

            [FieldOffset(12)] public Name PinSubCategory;

            [FieldOffset(24)] byte PinSubCategoryObject; //TODO: weak object TWeakObjectPtr<UObject> PinSubCategoryObject

            ///<summary>Sub-category member reference</summary>
            [FieldOffset(32)] SimpleMemberReference PinSubCategoryMemberReference;

            ///<summary>Data used to determine value types when bIsMap is true</summary>
            [FieldOffset(72)] EdGraphTerminalType PinValueType;

            [FieldOffset(108)] byte ContainerType; //TODO: enum EPinContainerType ContainerType

            [FieldOffset(109)] public bool bIsReference;

            [FieldOffset(109)] public bool bIsConst;

            [FieldOffset(109)] public bool bIsWeakPointer;

        }
}
