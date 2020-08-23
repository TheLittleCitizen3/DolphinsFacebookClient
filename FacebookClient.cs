using System;
using System.Collections.Generic;
using System.Text;
using MamaFacebook;
using MamaFacebook.Abstract;

namespace DolphinFacebook
{
    class FacebookClient : IFacebookClient
    {
        public event Action<string> NewWallPost;
        IDisplay Display;

        public FacebookClient(IDisplay display)
        {
            Display = display;
        }

        public void Subscribe(IFacebookClient publisher)
        {
            publisher.NewWallPost += Display.DisplayWallPost;
        }

        public void Unsubscribe(IFacebookClient publisher)
        {
            publisher.NewWallPost -= Display.DisplayWallPost;
        }

        public void WriteNewWallPost(string wallPost)
        {
            Display.DisplayWallPost(wallPost);
            NewWallPost?.Invoke(wallPost);
        }
    }
}
