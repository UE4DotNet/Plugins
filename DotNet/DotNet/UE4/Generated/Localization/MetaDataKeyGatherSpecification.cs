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


namespace UE4.Localization{
        ///<summary>Meta Data Key Gather Specification</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct MetaDataKeyGatherSpecification {
            ///<summary>The metadata key for which values will be gathered as text.</summary>
            [FieldOffset(0)] MetaDataKeyName MetaDataKey;

            [FieldOffset(16)] byte TextNamespace; //TODO: string FString TextNamespace

            ///<summary>The pattern which will be formatted to form the localization key for the metadata value gathered as text.</summary>
            ///<remarks>
            ///Placeholder - Description
            ///      {FieldPath} - The fully qualified name of the object upon which the metadata resides.
            ///      {MetaDataValue} - The value associated with the metadata key.
            ///</remarks>
            [FieldOffset(32)] MetaDataTextKeyPattern TextKeyPattern;

        }
}
