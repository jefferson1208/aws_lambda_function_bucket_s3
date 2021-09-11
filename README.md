# Aws Lambda Function - Trigger event bucket s3
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Neste exemplo, demostro como utilizar uma lambda function de forma simples.

O lambda recebe um evento (PUT) que ocorre numa determinada bucket do s3, captura o nome da bucket e o arquivo que chegou,
faz uma requisição para recuperar o arquivo e printa o conteúdo do arquivo, além de logar o tempo de execução no cloudwatch.

### Observação
É necessário configurar a trigger na bucket desejada através do console da aws.

### Pacotes Utilizados
```bash
Microsoft.Extensions.DependencyInjection
```

### Instalações
```bash
https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2017
```

### Template
```bash
AWS Lambda Project (.NET Core - C#)
Simple S3 Function
```
## Tecnologias
<div style="display: inline_block"><br>
  <img align="center" alt="Jeferson-Netcore" height="30" width="40" src="https://github.com/devicons/devicon/blob/master/icons/dotnetcore/dotnetcore-original.svg">
  <img align="center" alt="Jeferson-Csharp" height="30" width="40" src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg">
  <img align="center" alt="Jeferson-Aws" height="30" width="40" src="https://github.com/devicons/devicon/blob/master/icons/amazonwebservices/amazonwebservices-original-wordmark.svg">
</div>
