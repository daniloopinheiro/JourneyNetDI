# Injeção de dependências

## Índice

1. [Visão Geral](#visão-geral)
2. [Instalação](#instalação)
3. [Como Usar](#Como-executar-o-projeto)
4. [Configuração](#configuração)
5. [Contribuições](#contribuições)
6. [Licença](#licença)
7. [Contato](#contato)

## Visão Geral

Explorando as opções *Transient, Scoped e Singleton*. Como evitar dependências fortes entre classes, utilizando injeção de dependência para manter o código modular e limpo. Importância de separar a criação de instâncias de classes, evitando acoplamentos desnecessários. Exploraremos a utilização de um serviço de injeção de dependência como um oráculo para gerenciar as dependências entre classes.

## Instalação

### Windows

#### .NET Framework

1. **Verificar a versão do Windows:**
   - Abra o "Painel de Controle" e vá para "Programas" > "Programas e Recursos". Lá você pode ver se o .NET Framework já está instalado e qual versão.

2. **Instalação:**
   - Para instalar o .NET Framework, baixe o instalador adequado para a versão do Windows no site da Microsoft (geralmente pode ser encontrado como um componente opcional no Windows Update).

#### .NET Core / .NET 5.0 e posteriores

1. **Baixar o instalador:**
   - Acesse o site [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download) e baixe o instalador do .NET Core ou .NET 5.0 (ou versão posterior).

2. **Executar o instalador:**
   - Execute o arquivo baixado e siga as instruções na tela para completar a instalação.

### macOS

#### .NET Core / .NET 5.0 e posteriores

1. **Baixar o instalador:**
   - Acesse o site [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download) e baixe o instalador do .NET Core ou .NET 5.0 (ou versão posterior) para macOS.

2. **Executar o instalador:**
   - Abra o arquivo baixado (.pkg) e siga as instruções na tela para completar a instalação.

### Linux

#### .NET Core / .NET 5.0 e posteriores

1. **Adicionar o repositório do .NET:**
   - Siga as instruções específicas para sua distribuição Linux no site da Microsoft [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).

2. **Instalar o .NET:**
   - Use os comandos apropriados para sua distribuição Linux para instalar o .NET Core ou .NET 5.0 e posteriores. Por exemplo, para Ubuntu:
     ```bash
     sudo apt-get update
     sudo apt-get install dotnet-sdk-5.0
     ```

3. **Verificar a instalação:**
   - Após a instalação, você pode verificar se o .NET foi instalado corretamente usando o comando:
     ```bash
     dotnet --version
     ```

### Observações gerais

- **Atualizações:** É recomendável manter o .NET atualizado para receber correções de segurança e novos recursos.
- **Documentação:** Para instruções detalhadas e específicas para diferentes versões e cenários, consulte a documentação oficial da Microsoft em [docs.microsoft.com/dotnet](https://docs.microsoft.com/dotnet).

Seguindo esses passos, você conseguirá instalar o .NET em diferentes sistemas operacionais de forma adequada.

## Como executar o projeto

- Utilizando VS, selecione em qual modo pretende executar o projeto:

![image](https://github.com/daniloopinheiro/journey-csharp-injecao-de-dependencias/assets/64677271/226e1912-bc53-4a7e-bb65-1f30dc937502)
![image](https://github.com/daniloopinheiro/journey-csharp-injecao-de-dependencias/assets/64677271/299c559f-569a-464a-96fb-f14880e6e49c)

- Obsesrvação que ficará de sua escolha; deixe uma das duas opções selecionada.

![image](https://github.com/daniloopinheiro/journey-csharp-injecao-de-dependencias/assets/64677271/5ecbc3b0-e9af-4f3c-a64a-51d1c57b0cce)

## Configuração

Conforme o projeto está, não há nenhuma necessidade de configurar; apenas verificar a versão do sdk em sua maquina que esteja instalado.

## Contribuições

1. **Testar e Reportar Problemas**: Se encontrar algum problema ou bug, por favor, abra uma nova issue descrevendo-o detalhadamente.

2. **Sugerir Melhorias**: Se tiver ideias para melhorar o projeto, sinta-se à vontade para abrir uma issue propondo suas sugestões.

3. **Enviar Pull Requests**: Se você é desenvolvedor e gostaria de contribuir com código, ficarei muito feliz em receber suas contribuições. Basta fazer um fork do repositório, implementar suas mudanças e enviar um pull request.

4. **Ajudar com Documentação**: Contribuições para a documentação também são muito bem-vindas! Se você encontrar partes da documentação que podem ser melhoradas ou novos recursos que precisam de documentação, fique à vontade para contribuir.

5. **Espalhar a Palavra**: Compartilhar este projeto com outras pessoas que possam se interessar ou se beneficiar dele também é uma grande forma de contribuição.

## Contato

https://github.com/daniloopinheiro

## Licença

Indique a licença sob a qual o seu projeto está disponível. Por exemplo, MIT, GPL, Apache, etc.
