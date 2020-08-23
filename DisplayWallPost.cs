using MamaFacebook.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DolphinFacebook
{
    class DisplayWallPost : IDisplay
    {
        void IDisplay.DisplayWallPost(string wallPost)
        {
            Console.WriteLine($"The post is: {wallPost}");
        }
    }
}
