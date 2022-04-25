using HashidsNet;
using sallys_collection.Models.Data;

namespace sallys_collection.Helpers
{
    public static class EncryptionHelper
    {
        private const int MinHashLength = 7;

        public static string EncryptId(int id)
        {
            try
            {
                var hashid = new Hashids(AppConstants.EncryptionSalt, MinHashLength);
                return hashid.Encode(id);
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public static int DecryptId(string encodedId)
        {
            try
            {
                var hashid = new Hashids(AppConstants.EncryptionSalt, MinHashLength);
                return hashid.Decode(encodedId)[0];
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
