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

using UE4.Engine;

namespace UE4.UnrealEd{
        ///<summary>Struct Variable Description</summary>
        [StructLayout( LayoutKind.Explicit, Size=208 )]
        public unsafe struct StructVariableDescription {
            [FieldOffset(0)] public Name VarName;

            ///<summary>Var Guid</summary>
            [FieldOffset(12)] FGuid VarGuid;

            [FieldOffset(32)] byte FriendlyName; //TODO: string FString FriendlyName

            [FieldOffset(48)] byte DefaultValue; //TODO: string FString DefaultValue

            [FieldOffset(64)] public Name Category;

            [FieldOffset(76)] public Name SubCategory;

            [FieldOffset(88)] byte SubCategoryObject; //TODO: soft object TSoftObjectPtr<UObject> SubCategoryObject

            ///<summary>Pin Value Type</summary>
            [FieldOffset(136)] EdGraphTerminalType PinValueType;

            [FieldOffset(172)] byte ContainerType; //TODO: enum EPinContainerType ContainerType

            [FieldOffset(173)] public bool bInvalidMember;

            [FieldOffset(173)] public bool bDontEditoOnInstance;

            [FieldOffset(173)] public bool bEnableMultiLineText;

            [FieldOffset(173)] public bool bEnable3dWidget;

            [FieldOffset(176)] byte CurrentDefaultValue; //TODO: string FString CurrentDefaultValue

            [FieldOffset(192)] byte ToolTip; //TODO: string FString ToolTip

        }
}
