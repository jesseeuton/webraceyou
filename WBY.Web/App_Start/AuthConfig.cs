using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using Microsoft.Web.WebPages.OAuth;

namespace WBY.Web
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            //OAuthWebSecurity.RegisterMicrosoftClient(
            //    clientId: "",
            //    clientSecret: "");

            //OAuthWebSecurity.RegisterTwitterClient(
            //    consumerKey: "",
            //    consumerSecret: "");

            OAuthWebSecurity.RegisterFacebookClient(
                appId: "1493484167598579",
                appSecret: "bd780536fce2b01a0be115418cc2f30e");

            //OAuthWebSecurity.RegisterGoogleClient();
            //id: 1090206438122-b55ffcsv0u4d5rg1vc32t4rrjdphio1t.apps.googleusercontent.com
            //secret: EkZpmSn8dS6XUXVzOZSNNaSO
        }
    }
}
