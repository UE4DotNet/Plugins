using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using UE4.Core;
using UE4.CoreUObject;
using UE4.DotNet;
using UE4.Native;

namespace UE4 {
    public unsafe static class Main {
        /// <summary>
        /// Game Instance controls the main game state machine
        /// </summary>
        public static DotNetGameInstance GameInstance { get; private set; }

        internal static LogDelegate GetLogFunction =>
            SharedData->Log;

        internal static GetNameDelegate GetNameFunction =>
            SharedData->GetName;

        internal static ProcessEventDelegate GetProcessEvent =>
            SharedData->ProcessEvent;

        internal static GetUFunctionDelegate GetUFunction =>
            SharedData->GetUFunction;

        internal static GetUClassDelegate GetClass =>
            SharedData->GetUClass;

        internal static GetDefaultObjectDelegate GetDefaultObject =>
            SharedData->GetDefaultObject;

        internal static GetBoolPropertyByNameDelegate GetGetBoolPropertyByName =>
            SharedData->GetBoolPropertyByName;

        internal static SetBoolPropertyByNameDelegate SetGetBoolPropertyByName =>
            SharedData->SetBoolPropertyByName;

        internal static GetMethodUFunctionDelegate GetMethodUFunction =>
            SharedData->GetMethodUFunction;

        internal static NewObjectDelegate NewObject =>
            SharedData->NewObject;

        internal static GetTransientPackageDelegate GetTransientPackage =>
            SharedData->GetTransientPackage;

        internal static ShareOjectDelegate ShareObject =>
            SharedData->ShareObject;

        internal static ReleaseObjectDelegate ReleaseObject =>
            SharedData->ReleaseObject;

        public static int Start( string argument ) {
            IntPtr ptr = new IntPtr(long.Parse(argument));
            SharedData = (Shared*) ptr.ToPointer();
            SharedData->Validate();

            try {
                PushNameForCpp = new DelegateHolder<PushNameDelegate>( PushName );
                PushInterfaceForCpp = new DelegateHolder<PushInterfaceDelegate>( PushInterface );
                PushUObjectForCpp = new DelegateHolder<PushUObjectDelegate>( PushUObject );
                TestForCpp = new DelegateHolder<TestDelegate>( Test );
                DotNetCallForCpp = new DelegateHolder<DotNetCallDelegate>( DotNetCall );

                SharedData->SetPushNameFunction( Marshal.GetFunctionPointerForDelegate( PushNameForCpp.Delegate ) );
                SharedData->SetPushInterfaceFunction( Marshal.GetFunctionPointerForDelegate( PushInterfaceForCpp.Delegate ) );
                SharedData->SetTestFunction( Marshal.GetFunctionPointerForDelegate( TestForCpp.Delegate ) );
                SharedData->SetPushUObjectFunction( Marshal.GetFunctionPointerForDelegate( PushUObjectForCpp.Delegate ) );
                SharedData->SetDotNetCallFunction( Marshal.GetFunctionPointerForDelegate( DotNetCallForCpp.Delegate ) );
            } catch (Exception ex) {
                Debug.WriteLine( ex.ToString() );
            }
            Log.Display( "UE4 DotNet Started" );
            return 1234;
        }

        #region C++ Callable Functions
        private static void PushName( Name name, [MarshalAs( UnmanagedType.LPWStr )] string text ) {
            //Core.Name.Add( nameID, text );
        }

        private static void PushInterface( Name name, IntPtr interf ) {
            Interfaces.Add( name, interf );
        }

        private static void PushUObject( IntPtr UObject ) {
            
        }

        private static void Test( string argument ) {
            Debug.WriteLine( $"Test: {argument}" );
            //float value;
            //UE4DotNet.Native.Engine.KismetMathLibrary.Abs( -1.2f, out value );

            var ptr = GetUFunction("UserConstructionScript");
            //var func = new Function(ptr);
            //var flags = func.GetFlags();
        }


        private static unsafe IntPtr DotNetCall( int callType, IntPtr value ) {
            EDotNetCallType type = (EDotNetCallType) callType;
            switch (type) {
            case EDotNetCallType.SetGameInstance:
                GameInstance = UObject.Make<DotNetGameInstance>( value );
                break;
            case EDotNetCallType.LoadGameDLL:
                LoadDLL( new string( (char*) value.ToPointer() ) );
                break;
            case EDotNetCallType.CallStartFunction:
                char** paramPointers = (char**) value.ToPointer();
                var gameInstanceClass = new string(paramPointers[0]);
                var argument = new string(paramPointers[1]);
                IntPtr gameInstance = new IntPtr( paramPointers[2] );
                CallStartFunction( gameInstanceClass, argument, gameInstance );
                break;
            case EDotNetCallType.NewGame:
                Editor.NewGame();
                break;
            case EDotNetCallType.NewClass:
                Log.Display( "New Class" );
                break;
            case EDotNetCallType.BuildGame:
                Editor.BuildGame();
                break;
            case EDotNetCallType.PlayGame:
                Log.Display( "Play Game" );
                break;
            case EDotNetCallType.DebugGame:
                Log.Display( "Debug Game" );
                break;
            default:
                Log.Fatal( $"DotNetCall: Unknown call type: {callType}" );
                break;
            }
            return IntPtr.Zero;
        }

        private static void LoadDLL( string dllFileName ) {
            try {
                var path = UE4.Engine.KismetSystemLibrary.GetProjectDirectory();
                path += "/" + dllFileName;
                GameAssembly = Assembly.LoadFrom( path );
            } catch (Exception ex) {
                Log.Fatal( $"Loading '{dllFileName}' throw exception: {ex.ToString()}" );
            }
        }

        private static void CallStartFunction( string gameInstanceClass, string argument, IntPtr gameInsteance ) {
            try {
                var dir = Environment.CurrentDirectory;
                var classType = GameAssembly.GetType(gameInstanceClass);
                var baseType = classType.BaseType;
                var gameStart = classType.GetMethod("Start");

                if (classType != null && classType.IsSubclassOf( typeof( DotNetGameInstance ) )) {
                    GameInstance = (DotNetGameInstance) UObject.Make( gameInsteance, classType );
                    GameInstance.Start( argument );
                } else
                    Log.Fatal( $"Class {gameInstanceClass} not found or is not subclass of DotNetGameInstance" );
            } catch (Exception ex) {
                Log.Fatal( $"Calling '{gameInstanceClass}( \"{argument}\" );' threw exception {ex.ToString()}" );
            }
        }


        #endregion

        private static Assembly GameAssembly;

        private static DelegateHolder<PushNameDelegate> PushNameForCpp;
        private static DelegateHolder<PushInterfaceDelegate> PushInterfaceForCpp;
        private static DelegateHolder<PushUObjectDelegate> PushUObjectForCpp;
        private static DelegateHolder<TestDelegate> TestForCpp;
        private static DelegateHolder<DotNetCallDelegate> DotNetCallForCpp;

        private static Shared* SharedData;

    }
}
