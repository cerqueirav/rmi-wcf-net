<div align="center">
    <h1 align="center">
        <img height="120" width="120" alt=".NET Core" src="https://seeklogo.com/images/C/c-sharp-c-logo-02F17714BA-seeklogo.com.png"/>
    </h1>
</div>

# RMI com WCF usando .NET

Este projeto é uma implementação de um sistema RMI (Remote Method Invocation) utilizando o WCF (Windows Communication Foundation) no ambiente .NET. O objetivo é demonstrar como realizar a comunicação entre processos por meio da invocação remota de métodos.

## Requisitos

Certifique-se de ter as seguintes ferramentas e componentes instalados em seu sistema:

- .NET Framework (versão compatível com o projeto)

## Executando o Server
Siga as etapas abaixo para configurar e executar o projeto:

- Abra o projeto no Visual Studio ou na sua IDE de preferência.
- Certifique-se de que as dependências do projeto estejam instaladas corretamente. Caso contrário, use o NuGet Package Manager para restaurar as dependências necessárias.
- Compile o projeto para garantir que não haja erros de compilação.
- Execute o projeto pressionando F5 ou usando a opção "Executar" na sua IDE.

## Executando o Client
Siga as etapas abaixo para configurar e executar o projeto:

- Abra o projeto no Visual Studio ou na sua IDE de preferência.
- Certifique-se de que as dependências do projeto estejam instaladas corretamente. Caso contrário, use o NuGet Package Manager para restaurar as dependências necessárias.
- Compile o projeto para garantir que não haja erros de compilação.
- Execute o projeto pressionando F5 ou usando a opção "Executar" na sua IDE.

 ## Funcionamento
O servidor implementa um ou mais serviços WCF que expõem os métodos que podem ser invocados remotamente pelos clientes. Esses métodos devem ser decorados com atributos adequados do WCF, como [ServiceContract] e [OperationContract].

O cliente utiliza o canal de comunicação fornecido pelo WCF para se conectar ao servidor e invocar os métodos remotos. Para isso, é necessário criar uma instância do cliente WCF e chamar os métodos expostos pelo servidor.

Certifique-se de configurar corretamente as configurações de comunicação, como o endereço do serviço WCF, o tipo de binding e o contrato.

 ## Contribuição
Sinta-se à vontade para contribuir com melhorias para este projeto. Você pode enviar pull requests com correções de bugs, novos recursos ou aprimoramentos da documentação.
