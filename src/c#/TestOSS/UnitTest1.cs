using GeneralUpdate.Core.OSS;
using GeneralUpdate.OSS;
using GeneralUpdate.OSS.Domain.Entity;
using GeneralUpdate.OSS.OSSStrategys;

namespace TestOSS
{
    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {
            GeneralUpdateOSS.Download += OnOSSDownload;
            GeneralUpdateOSS.UnZipCompleted += OnOSSUnZipCompleted;
            GeneralUpdateOSS.UnZipProgress += OnOSSUnZipProgress;
            await GeneralUpdateOSS.Start<OSSStrategy>(new ParamsOSS("", "", "", ""));
        }

        private void OnOSSUnZipProgress(object sender, GeneralUpdate.Zip.Events.BaseUnZipProgressEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnOSSUnZipCompleted(object sender, GeneralUpdate.Zip.Events.BaseCompleteEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnOSSDownload(object sender, GeneralUpdate.OSS.Events.OSSDownloadArgs e)
        {
            throw new NotImplementedException();
        }
    }
}