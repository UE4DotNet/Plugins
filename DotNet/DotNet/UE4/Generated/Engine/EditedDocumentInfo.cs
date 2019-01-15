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
        ///<summary>Edited Document Info</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct EditedDocumentInfo {
            ///<summary>Edited object</summary>
            [FieldOffset(0)] SoftObjectPath EditedObjectPath;

            ///<summary>Saved view position</summary>
            [FieldOffset(32)] Vector2D SavedViewOffset;

            [FieldOffset(40)] public float SavedZoomAmount;

        }
}
