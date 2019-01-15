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


namespace UE4.UMG{
        ///<summary>
        ///The state passed into OnPaint that we can expose as a single painting structure to blueprints to
        ///allow script code to override OnPaint behavior.
        ///</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct NamedSlotBinding {
            [FieldOffset(0)] public Name Name;

            [FieldOffset(16)] 
            private IntPtr  Content_field;
            ///<summary>Content</summary>
            public Widget Content {
                get {return Content_field;}
                set {Content_field = value;}
            }

        }
}
