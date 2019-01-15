using System;
using System.Runtime.InteropServices;

namespace UE4.CoreUObject {
    [StructLayout(LayoutKind.Sequential)]
    public struct SubclassOf<T> where T:UObject {
        private IntPtr ClassPtr;

        public Class Class {
            get { return UObject.Make<Class>( ClassPtr ); }
            set {
                //TODO: validate value is subclass of T
                ClassPtr = value;
            }
        }

        public static implicit operator SubclassOf<T>(IntPtr p) =>
            new SubclassOf<T> {
                ClassPtr = p
            };

        public static implicit operator IntPtr(SubclassOf<T> s) =>
            //TODO: Validate that s is a subclass
            s.ClassPtr;

        public static implicit operator SubclassOf<T>(Class c) =>
            c.ObjPointer;

        public static implicit operator Class(SubclassOf<T> c) =>
            c.Class;

        //TODO: Add Implicit cast of UClass with validation
    }
}
