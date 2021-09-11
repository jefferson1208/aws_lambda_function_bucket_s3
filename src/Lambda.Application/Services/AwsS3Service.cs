using Amazon.S3;
using Amazon.S3.Model;
using Lambda.Domain.Interfaces;
using System.IO;
using System.Threading.Tasks;

namespace Lambda.Application.Services
{
    public class AwsS3Service : IAwsS3Service
    {
        private readonly IAmazonS3 _s3Client;

        public AwsS3Service(IAmazonS3 s3Client)
        {
            _s3Client = s3Client;
        }

        public async Task<string> BuscarArquivoJson(string bucketName, string key)
        {
            var request = new GetObjectRequest { BucketName = bucketName, Key = key };
            var result = string.Empty;

            using (var response = await _s3Client.GetObjectAsync(request))
            {
                using(var reader = new StreamReader(response.ResponseStream))
                {
                    result = reader.ReadToEnd();
                }
            }

            return result;
        }
    }
}
