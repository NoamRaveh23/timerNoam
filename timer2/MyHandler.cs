using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace timer2
{
    public class MyHandler : Handler
    {
        Context context;
        TextView tvResult;

        [System.Obsolete]
        public MyHandler(Context context, TextView tv)
        {
            this.context = context;
            this.tvResult = tv;
        }
        public override void HandleMessage(Message msg)
        {
            this.tvResult.Text = "" + msg.Arg1;
        }
    }
}