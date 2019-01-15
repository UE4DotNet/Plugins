using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

using UE4.Core;
using UE4.Native;
using UE4.InputCore;

namespace UE4.Engine {
    /// <summary>
    /// Delegate signature for Axis Handlers
    /// </summary>
    /// <param name="AxisValue">"Value" to pass to the axis.  This value will be the device-dependent, so a mouse will report absolute change since the last update, 
    ///      a joystick will report total displacement from the center, etc.  </param>
    public delegate void AxisDelegate( float AxisValue );
    public delegate void ActionDelegate( Key key );

    internal delegate void BindAxisFunction( IntPtr gameInstance, IntPtr inputComponent, Name AxisName );
    internal delegate void BindActionFunction( IntPtr gameInstance, IntPtr inputComponent, Name ActionName, EInputEvent InputEvent );

    internal delegate void AxisEventFunction(Name name, float axisValue );
    internal delegate void ActionEventFunction( Name name, Key key, EInputEvent InputEvent );

    public partial class InputComponent : ActorComponent {
        private unsafe InputNative* Native => Local.NativeInput;

        private static Dictionary<Name, AxisDelegate> AxisBindings = new Dictionary<Name, AxisDelegate>();
        private static Dictionary<Tuple<Name,EInputEvent>,ActionDelegate> ActionBindings = new Dictionary<Tuple<Name, EInputEvent>, ActionDelegate>();

        public unsafe void BindAxis(Name AxisName, AxisDelegate Handler) {
            var func = Marshal.GetDelegateForFunctionPointer<BindAxisFunction>(Native->BindAxisFunction);
            func( Main.GameInstance, this, AxisName );
            AxisBindings.Add( AxisName, Handler );
        }

        public unsafe void BindAction(Name ActionName, EInputEvent InputEvent, ActionDelegate Handler) {
            var func = Marshal.GetDelegateForFunctionPointer<BindActionFunction>(Native->BindActionFunction);
            func( Main.GameInstance, this, ActionName, InputEvent );
            var key = new Tuple<Name,EInputEvent>(ActionName, InputEvent);
            ActionBindings.Add( key, Handler );
        }

        private static void OnAxisEvent(Name axisName, float axisValue) {
            if (AxisBindings.TryGetValue( axisName, out AxisDelegate func ))
                func( axisValue );
        }

        private static void OnActionEvent(Name actionName, Key key, EInputEvent InputEvent) {
            var bindingKey = new Tuple<Name, EInputEvent>(actionName, InputEvent);
            if (ActionBindings.TryGetValue( bindingKey, out ActionDelegate func ))
                func( key );
        }

        private unsafe struct Local {
            public static InputNative* NativeInput;

            public static DelegateHolder<AxisEventFunction> AxisEventHandler;
            public static DelegateHolder<ActionEventFunction> ActionEventHandler;

            static Local() {
                NativeInput = (InputNative*) Interfaces.Get( Core.Name.Make( "Input" ) ).ToPointer();
                Debug.Assert( NativeInput != null );
                NativeInput->Validate();
                AxisEventHandler = new DelegateHolder<AxisEventFunction>( OnAxisEvent );
                NativeInput->AxisEventFunction = Marshal.GetFunctionPointerForDelegate(AxisEventHandler.Delegate);
                ActionEventHandler = new DelegateHolder<ActionEventFunction>( OnActionEvent );
                NativeInput->ActionEventFunction = Marshal.GetFunctionPointerForDelegate( ActionEventHandler.Delegate );
            }
        }


        [StructLayout( LayoutKind.Sequential, Pack = 0 )]
        internal struct InputNative {
            uint StartGuardian;
            uint SizeOfShared;
            int FNameID;

            internal IntPtr BindAxisFunction;
            internal IntPtr BindActionFunction;
            internal IntPtr AxisEventFunction;
            internal IntPtr ActionEventFunction;

            uint EndGuardian;

            public void Validate() {
                var size = Marshal.SizeOf<InputNative>();
                Debug.Assert( StartGuardian == 0x12345678 &&
                    EndGuardian == 0x87654321 &&
                    SizeOfShared == size
                    );
            }
        }
    }
}
