using Amazon.S3;
using Lambda.Application.Services;
using Lambda.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Lambda.Application.Configuration
{
    public static class Setup
    {
        public static void ConfigServices(this IServiceCollection services)
        {
            services.AddSingleton<Startup>();
            services.AddSingleton<IAmazonS3, AmazonS3Client>();
            services.AddSingleton<IAwsS3Service, AwsS3Service>();
        }
    }
}
