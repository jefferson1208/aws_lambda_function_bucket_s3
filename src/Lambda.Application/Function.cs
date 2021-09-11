using Amazon.Lambda.Core;
using Amazon.Lambda.S3Events;
using Lambda.Application.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Lambda.Application
{
    public class Function
    {
        private IServiceCollection _services;
        private IServiceProvider _provider;
        private Startup _startup;

        public Function()
        {
            _services = new ServiceCollection();
        }


        public async Task<string> FunctionHandler(S3Event evnt, ILambdaContext context)
        {
            var tempoExecucao = System.Diagnostics.Stopwatch.StartNew();

            var s3Event = evnt.Records?[0].S3;
            Configurar();

            var arquivo = await _startup.BuscarArquivo(s3Event);

            context.Logger.Log($"Tempo de Execução: {tempoExecucao.Elapsed}");
            return arquivo;
        }

        private void Configurar()
        {
            _services.ConfigServices();
            _provider = _services.BuildServiceProvider();
            _startup = _provider.GetService<Startup>();
        }
    }
}
