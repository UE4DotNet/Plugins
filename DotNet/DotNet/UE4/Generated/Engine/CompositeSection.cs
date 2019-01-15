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
        ///<summary>Section data for each track.</summary>
        ///<remarks>
        ///Reference of data will be stored in the child class for the way they want
        ///AnimComposite vs AnimMontage have different requirement for the actual data reference
        ///This only contains composite section information. (vertical sequences)
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=96 )]
        public unsafe struct CompositeSection {
            [FieldOffset(48)] public Name SectionName;

            [FieldOffset(64)] public Name NextSectionName;

            [FieldOffset(80)] byte MetaData; //TODO: array TArray MetaData

        }
}
