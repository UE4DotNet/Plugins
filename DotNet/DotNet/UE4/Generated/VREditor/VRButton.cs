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


namespace UE4.VREditor{
        ///<summary>Structure to keep track of all relevant interaction and animation elements of a VR Button</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct VRButton {
            [FieldOffset(0)] 
            private IntPtr  ButtonWidget_field;
            ///<summary>Pointer to button</summary>
            public VREditorWidgetComponent ButtonWidget {
                get {return ButtonWidget_field;}
                set {ButtonWidget_field = value;}
            }

        }
}
