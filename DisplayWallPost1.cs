using MamaFacebook.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DolphinFacebook
{
    class DisplayWallPost1 : IDisplay
    {
        void IDisplay.DisplayWallPost(string wallPost)
        {
            Console.WriteLine($"The post is: {wallPost} from client 2!");
        }
    }
}
