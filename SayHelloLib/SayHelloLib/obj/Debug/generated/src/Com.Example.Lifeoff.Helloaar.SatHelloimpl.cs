using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Example.Lifeoff.Helloaar {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.lifeoff.helloaar']/class[@name='SatHelloimpl']"
	[global::Android.Runtime.Register ("com/example/lifeoff/helloaar/SatHelloimpl", DoNotGenerateAcw=true)]
	public partial class SatHelloimpl : global::Java.Lang.Object, global::Com.Example.Lifeoff.Helloaar.ISayHello {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/example/lifeoff/helloaar/SatHelloimpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SatHelloimpl); }
		}

		protected SatHelloimpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.lifeoff.helloaar']/class[@name='SatHelloimpl']/constructor[@name='SatHelloimpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SatHelloimpl ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SatHelloimpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_sayHello_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSayHello_Ljava_lang_String_Handler ()
		{
			if (cb_sayHello_Ljava_lang_String_ == null)
				cb_sayHello_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SayHello_Ljava_lang_String_);
			return cb_sayHello_Ljava_lang_String_;
		}

		static IntPtr n_SayHello_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Example.Lifeoff.Helloaar.SatHelloimpl __this = global::Java.Lang.Object.GetObject<global::Com.Example.Lifeoff.Helloaar.SatHelloimpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SayHello (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sayHello_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.lifeoff.helloaar']/class[@name='SatHelloimpl']/method[@name='sayHello' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sayHello", "(Ljava/lang/String;)Ljava/lang/String;", "GetSayHello_Ljava_lang_String_Handler")]
		public virtual unsafe string SayHello (string p0)
		{
			if (id_sayHello_Ljava_lang_String_ == IntPtr.Zero)
				id_sayHello_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sayHello", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sayHello_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sayHello", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
