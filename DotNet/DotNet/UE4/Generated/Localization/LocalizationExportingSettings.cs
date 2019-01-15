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
        ///<summary>Localization Exporting Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=3 )]
        public unsafe struct LocalizationExportingSettings {
            [FieldOffset(0)] byte CollapseMode; //TODO: enum ELocalizedTextCollapseMode CollapseMode

            [FieldOffset(1)] public bool ShouldPersistCommentsOnExport;

            [FieldOffset(2)] public bool ShouldAddSourceLocationsAsComments;

        }
}
