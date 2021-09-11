using Lambda.Domain.Interfaces;
using System.Threading.Tasks;
using static Amazon.S3.Util.S3EventNotification;

namespace Lambda.Application
{
    public class Startup
    {
        private readonly IAwsS3Service _awsS3Service;

        public Startup(IAwsS3Service awsS3Service)
        {
            _awsS3Service = awsS3Service;
        }

        public async Task<string> BuscarArquivo(S3Entity entity)
        {
            return await _awsS3Service.BuscarArquivoJson(entity.Bucket.Name, entity.Object.Key);
        }
    }
}
