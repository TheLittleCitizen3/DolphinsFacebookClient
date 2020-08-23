using MamaFacebook.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DolphinFacebook
{
    class FaceBookClientFactory : IFacebookClientFactory
    {
        public IFacebookClient CreateClient(IDisplay display)
        {
            return new FacebookClient(display);
        }
    }
}
