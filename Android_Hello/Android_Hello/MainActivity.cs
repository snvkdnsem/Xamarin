using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Text;
using System;
using Android.Content;
using System.Collections.Generic;

namespace Android_Hello
{
    //Label: 핸드폰 상단의 타이틀
    [Activity(Label = "Xamarin Android", MainLauncher = true)]
    public class MainActivity : Activity
    {
        static readonly List<string> phoneNumbers = new List<string>();
        //OnCreate: 콜백메소드, 필수
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button callHistoryButton = FindViewById<Button>(Resource.Id.CallHistoryButton);
            callHistoryButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(CallHistoryActivity));//명시적 intent이다

                intent.PutStringArrayListExtra("phone_numbers", phoneNumbers);
                StartActivity(intent);
            };

            EditText phoneNumberText = FindViewById<EditText>(Resource.Id.PhoneNumberText);

            //Resource.Id : Resource.Designer.cs파일에 Resource, Id, CallButton을 만들어 준다.
            //전화걸기 버튼
            Button callButton = FindViewById<Button>(Resource.Id.CallButton);

            //callButton을 비활성화
            callButton.Enabled = false;


            phoneNumberText.TextChanged +=
                (object sender, TextChangedEventArgs e) =>
                {
                    if (!string.IsNullOrWhiteSpace(phoneNumberText.Text))
                        callButton.Enabled = true;
                    else
                        callButton.Enabled = false;
                };

            callButton.Click += (object sender, EventArgs e) =>
            {
                //Make a Call 버튼 클릭시 전화를 건다.
                var callDialog = new Android.App.AlertDialog.Builder(this);
                callDialog.SetMessage("Call " + phoneNumberText.Text + "?");

                //"Call"을 클릭하는 경우
                // 전화걸기 위한 인텐트 생성
                callDialog.SetNeutralButton("Call", delegate
                {
                    phoneNumbers.Add(phoneNumberText.Text);
                    callHistoryButton.Enabled = true;

                    // 안드로이드 시스템 앱을 부를 때 Intent를 쓴다.
                    // 인텐트는 액티비디의 전환이 일어날 때 호출하거나 메시지를 전달하는 매개체
                    // 암시적 인텐트 : 전환될 곳을 직접 지정하지 않고 액션을 적어서 사용한다.
                    // 명시적 인텐트 : 전환될 액티비티를 직접 적어서 표현하는 방법을 사용한다.
                    var callIntent = new Intent(Intent.ActionCall); // Intent.ActionCall => 암시적 인텐트
                    callIntent.SetData(Android.Net.Uri.Parse("tel:" + phoneNumberText.Text));
                    StartActivity(callIntent);
                });

                //Cancel을 클릭하는 경우
                callDialog.SetNegativeButton("Cancel", delegate { }); //현재 delegate에 아무작성이 안되어 있으므로 cancel누르면 아무 작용을 안한다.

                callDialog.Show();
            };
        }
    }
}

