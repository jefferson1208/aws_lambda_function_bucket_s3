using System.Threading.Tasks;

namespace Lambda.Domain.Interfaces
{
    public interface IAwsS3Service
    {
        public Task<string> BuscarArquivoJson(string bucketName, string key);
    }
}
