
#nullable enable

namespace Moonshot
{
    public partial interface IMoonshotClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}