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


namespace UE4.BlueprintGraph{
        ///<summary>Optional Pin from Property</summary>
        [StructLayout( LayoutKind.Explicit, Size=72 )]
        public unsafe struct OptionalPinFromProperty {
            [FieldOffset(0)] public Name PropertyName;

            [FieldOffset(16)] byte PropertyFriendlyName; //TODO: string FString PropertyFriendlyName

            [FieldOffset(32)] byte PropertyTooltip; //TODO: text FText PropertyTooltip

            [FieldOffset(56)] public Name CategoryName;

            [FieldOffset(68)] public bool bShowPin;

            [FieldOffset(68)] public bool bCanToggleVisibility;

            [FieldOffset(68)] public bool bPropertyIsCustomized;

            [FieldOffset(68)] public bool bHasOverridePin;

            [FieldOffset(68)] public bool bIsMarkedForAdvancedDisplay;

            [FieldOffset(68)] public bool bIsOverrideEnabled;

            [FieldOffset(68)] public bool bIsSetValuePinVisible;

            [FieldOffset(68)] public bool bIsOverridePinVisible;

        }
}
