using MamaFacebook.Abstract;
using System;

namespace DolphinFacebook
{
    class Program
    {
        static void Main(string[] args)
        {
            IFacebookClientFactory facebookClientFactory = new FaceBookClientFactory();
            IDisplay display = new DisplayWallPost();
            IFacebookClient client1 = facebookClientFactory.CreateClient(display);
            IDisplay display1 = new DisplayWallPost1();
            IFacebookClient client2 = facebookClientFactory.CreateClient(display1);

            client1.Subscribe(client2);
            client2.WriteNewWallPost("first post from client 2");
            client1.Unsubscribe(client2);
            client2.WriteNewWallPost("sec post");
        }
    }
}
