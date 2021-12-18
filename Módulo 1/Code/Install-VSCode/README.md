# Instalação do Visual Studio Code - Configuração
## O Visual Studio code é um dos editores de texto mais utilizado no mundo inteiro. 
#### Possui integração com diversas linguagem, além de ser completamente customizável.
<br/><br/>

# Requisitos de sistema
### O VSCode é extremamente leve que, e possui também sua versão web, que não necessita instalação.
 - #### Os requisitos mínimos para instalação do VSCode são baixos. Você precisa de um computador Intel Core i3, 8gb de RAM, e 128 gb de disco.
--- 
#### Mantenha seu computador sempre atualizado, utilizando Windows 10 ou superior.

<br/><br/>

# Instalação no Windows
- ### Basta acessar o site oficial do Visual Studio Code e realizar o download.
- ### Siga as instruções na tela e não se esqueça de marcar a opção "Add to Path" para adicionar o Visual Studio Code nas variáveis de ambiente. 
- ### feche todos os terminais e abra um novo, digitando o seguinte comando: `code --version`
- ### Se ocorreu tudo certo com o download, o terminal exibirá a versão atual do VSCode instalado em sua máquina.

<br/><br/>

# Instalação no Mac
- ### Basta acessar o site oficial do Visual Studio Code e realizar o download, clicando no botão "Download for Mac". 
- ### Abra o instalador e copie o Visual Studio para a pasta Applications no seu Mac.
- ### Para ter acesso ao comando *code* em seu terminal, adicione o Visual Studio ao PATH. Dessa forma, você poderá abrir pastas diretamente no Visual Studio Code.
  - ### Abra o VSCode, pressione F1, para abrir a tela de execução de comandos.
  - ### Procure por ***Shell Command: Install 'code' command in PATH*** para adicionar o Visual Studio Code ao PATH do seu sistema operacional.

<br/><br/>

# Instalação no Linux (Ubunto)
- ### Basta acessar o site oficial do Visual Studio Code e realizar o download, clicando no botão "Download for Linux". 
- ### Você receberá um pacote .deb na pasta Downloads.
- ### Abra um terminal e navegue até a pasta, executando o comando: `sudo apt install ./ARQUIVO_BAIXADO.deb`
- ### Se tudo ocorrer coretamente, a instalação foi realizada e o aplicativo aparecerá no menu de aplicativos.
- ### Para ter acesso ao comando *code* em seu terminal, adicione o Visual Studio ao PATH. Dessa forma, você poderá abrir pastas diretamente no Visual Studio Code.
  - ### Abra o VSCode, pressione F1, para abrir a tela de execução de comandos.
  - ### Procure por ***Shell Command: Install 'code' command in PATH*** para adicionar o Visual Studio Code ao PATH do seu sistema operacional.

<br/><br/>

# Configurações
- ### Como falei no início, o Visual Studio Code é completamente customizável, sendo assim, ele nos permite criar nossa propria configuração.
- ### Pressionando o botão CMD + Vírgula abrirá uma interface para configurção do editor.
- ### No canto superior direito dessa tela há um botão para abrir as configurações em JSON (Open Settings)
- ### Se quiser pode copiar nossas configurações para seu editor:
  - `{
    "workbench.colorTheme": "Dracula",
    "editor.suggestSelection": "first",
    "workbench.iconTheme": "vscode-icons",
    "editor.minimap.enabled": false,
    "terminal.integrated.cursorStyle": "line",
    "terminal.integrated.fontSize": 18,
    "git.enableSmartCommit": true,
    "git.autofetch": true,
    "vsintellicode.modify.editor.suggestSelection": "automaticallyOverrodeDefaultValue",
    "bracket-pair-colorizer-2.depreciation-notice": false,
    "terminal.integrated.fontFamily": "Source Code Pro",
    "editor.formatOnSave": true
}`
- ### Para que as configurações funcionem corretamente, você deve instalar as extensões e temas pendentes. Para realizar a instalação siga os passos a seguir.

<br/><br/>

# Temas e Extensões
- ### Você pode utilizar temas e fontes personalizadas no Visual Studio Code.
- ### Aconselhamos a instalação da extensão ***VS Code Icons***, para visualizar os icones da Solução com maior clareza.
- ### Por aqui, utilizamos o tema ***Dracula***. Os temas podem ser instalados também como uma extensão. 