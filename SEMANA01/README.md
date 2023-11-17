Configurando o ambiente.

1-Problema: Como você pode verificar se o .NET SDK está corretamente instalado em 
seu sistema? Em um arquivo de texto ou Markdown, liste os comandos que podem 
ser usados para verificar a(s) versão(ões) do .NET SDK instalada(s), como remover e 
atualizar. quero respostas baseada na documentaçao

Para verificar a versão do .NET SDK Instalada basta digitar o seguinte comando no prompt.

dotnet --version

ParaListar todas as versões do .NET SDK Instaladas digite o comando.

dotnet --list-sdks

Este comando lista todas as versões do .NET SDK instaladas no seu sistema.

Verificar a Versão do .NET Runtime Instalada:

dotnet --list-runtimes
Este comando exibe informações sobre as versões do .NET Runtime instaladas no seu sistema.

Atualizar o .NET SDK:

dotnet --version
Para atualizar o .NET SDK, você pode visitar o site oficial do .NET SDK para baixar a versão mais recente e seguir as instruções de instalação. Dependendo do seu sistema operacional, os passos podem variar.

Remover uma Versão Específica do .NET SDK:

dotnet --uninstall-sdk <versão>
Substitua <versão> pela versão específica do .NET SDK que você deseja desinstalar. Certifique-se de substituir isso pela versão real que você deseja remover.