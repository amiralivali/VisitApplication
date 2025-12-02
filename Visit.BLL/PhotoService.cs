using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Visit.DAL;
using Visit.Shared;

namespace Visit.BLL
{
    public class PhotoService
    {
        private readonly IAmazonS3 _s3Client;
        public PhotoService()
        {
            var config = new AmazonS3Config
            {
                ServiceURL = Constance.ServiceURL,
                ForcePathStyle = true, // برای Arvan ضروریه
                AuthenticationRegion = "ir-thr-at1"
            };
            var credentials = new BasicAWSCredentials(Constance.AccessKey, Constance.SecretKey);
            _s3Client = new AmazonS3Client(credentials, config);
        }
        public async Task<OprationResult<string>> SaveAsync(string filePath)
        {
            try
            {
                string objectKey = Path.GetFileName(filePath).Replace(" ", "_");

                var putRequest = new PutObjectRequest
                {
                    BucketName = Constance.BucketName,
                    Key = objectKey,
                    FilePath = filePath,
                    CannedACL = S3CannedACL.PublicRead // فایل Public بشه
                };

                await _s3Client.PutObjectAsync(putRequest);

                string fileUrl = $"{Constance.ServiceURL}/{Constance.BucketName}/{objectKey}";
                return OprationResult<string>.Success(fileUrl);
            }
            catch (Exception ex)
            {
                await ex.AddLogAsync();
                return OprationResult<string>.RunTimeError();
            }
        }
    }
}

