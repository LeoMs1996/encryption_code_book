using System.IO;
using System.Threading.Tasks;
using Windows.Storage;
using encryption_code_book.ViewModel;

namespace encryption_code_book.Model
{
    public class KeySecret : NotifyProperty
    {
        public KeySecret()
        {
            AreNewEncrypt = true;
        }

        public string Key
        {
            set;
            get;
        }

        public bool AreNewEncrypt
        {
            set;
            get;
        }

        public string Name
        {
            set;
            get;
        }

        public string ComfirmKey
        {
            set;
            get;
        }

        public StorageFile File
        {
            set;
            get;
        }

        public async Task Read(StorageFile file)
        {
            try
            {
                byte[] buffer = new byte[AccountGoverment.View.Account.ComfirmkeyLength];

                using (Stream stream = await file.OpenStreamForReadAsync())
                {
                    stream.Read(buffer, 0, AccountGoverment.View.Account.ComfirmkeyLength);
                }

                ComfirmKey = AccountGoverment.View.Account.Encod.GetString(buffer);
                File = file;
                AreNewEncrypt = false;
            }
            catch
            {
                
            }
        }

        public void Storage()
        {
            
        }
    }
}