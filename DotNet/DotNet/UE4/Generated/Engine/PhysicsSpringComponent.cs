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

#pragma warning disable CS0108
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Note: this component is still work in progress.</summary>
    ///<remarks>
    ///Uses raycast springs for simple vehicle forces
    ///   Used with objects that have physics to create a spring down the X direction
    ///   ie. point X in the direction you want generate spring.
    ///</remarks>
    public unsafe partial class PhysicsSpringComponent : SceneComponent  {

        ///<summary>Returns the spring compression as a normalized scalar along spring direction.</summary>
        ///<remarks>
        ///0 implies spring is at rest
        ///1 implies fully compressed
        ///</remarks>
        public float GetNormalizedCompressionScalar()  => 
            PhysicsSpringComponent_methods.GetNormalizedCompressionScalar_method.Invoke(ObjPointer);

        ///<summary>Returns the spring current end point in world space.</summary>
        public Vector GetSpringCurrentEndPoint()  => 
            PhysicsSpringComponent_methods.GetSpringCurrentEndPoint_method.Invoke(ObjPointer);

        ///<summary>Returns the spring direction from start to resting point</summary>
        public Vector GetSpringDirection()  => 
            PhysicsSpringComponent_methods.GetSpringDirection_method.Invoke(ObjPointer);

        ///<summary>Returns the spring resting point in world space.</summary>
        public Vector GetSpringRestingPoint()  => 
            PhysicsSpringComponent_methods.GetSpringRestingPoint_method.Invoke(ObjPointer);
        ///<summary>Specifies how much strength the spring has. The higher the SpringStiffness the more force the spring can push on a body with.</summary>
        public unsafe float SpringStiffness {
            get {return PhysicsSpringComponent_ptr->SpringStiffness;}
            set {PhysicsSpringComponent_ptr->SpringStiffness = value;}
        }
        ///<summary>Specifies how quickly the spring can absorb energy of a body. The higher the damping the less oscillation</summary>
        public unsafe float SpringDamping {
            get {return PhysicsSpringComponent_ptr->SpringDamping;}
            set {PhysicsSpringComponent_ptr->SpringDamping = value;}
        }
        ///<summary>Determines how long the spring will be along the X-axis at rest. The spring will apply 0 force on a body when it's at rest.</summary>
        public unsafe float SpringLengthAtRest {
            get {return PhysicsSpringComponent_ptr->SpringLengthAtRest;}
            set {PhysicsSpringComponent_ptr->SpringLengthAtRest = value;}
        }
        ///<summary>Determines the radius of the spring.</summary>
        public unsafe float SpringRadius {
            get {return PhysicsSpringComponent_ptr->SpringRadius;}
            set {PhysicsSpringComponent_ptr->SpringRadius = value;}
        }
        ///<summary>Strength of thrust force applied to the base object.</summary>
        public unsafe byte SpringChannel {
            get {return PhysicsSpringComponent_ptr->SpringChannel;}
            set {PhysicsSpringComponent_ptr->SpringChannel = value;}
        }
        public bool bIgnoreSelf {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnoreSelf"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnoreSelf", value); }
        }
        ///<summary>The current compression of the spring. A spring at rest will have SpringCompression 0.</summary>
        public unsafe float SpringCompression {
            get {return PhysicsSpringComponent_ptr->SpringCompression;}
        }
        static PhysicsSpringComponent() {
            StaticClass = Main.GetClass("PhysicsSpringComponent");
        }
        internal unsafe PhysicsSpringComponent_fields* PhysicsSpringComponent_ptr => (PhysicsSpringComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PhysicsSpringComponent(IntPtr p) => UObject.Make<PhysicsSpringComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PhysicsSpringComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PhysicsSpringComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
