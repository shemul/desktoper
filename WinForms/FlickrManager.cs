using System;
using System.Net;
using System.Windows;
using FlickrNet;

namespace WinForms
{
    public class FlickrManager
    {
        public const string ApiKey = "3a68f22971d8d66b521b362c312c175c";
        public const string SharedSecret = "b2acf0fb7910be24";

        public static Flickr GetInstance()
        {
            return new Flickr(ApiKey, SharedSecret);
        }

       

       

    }
}
