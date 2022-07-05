Aplicação Funcional

Criado o Crud, todos os metodos funcionando CRIAR, EDITAR, LISTAR E DELETAR

Para utilizar a Aplicação é necessário:
-Visual Studio
-Sql Server

Para criar o Banco de dados é necessario mudar o caminho do Banco de Dados no Arquivo appsettings.json ("ConnectionStrings": {
    "DataBase": "Server= SUA.MAQUINA.AQUI; initial catalog = Database=NOME.DO.BANCO.QUE.DESEJA.CRIAR; Integrated Security = true"

Com o Visual Studio aberto, execute os seguintes comandos no Terminal do Nuget:

  add-migration CriandoTabelaDePessoas -Context NOME.DO.BANCO.CRIADO   - PARA CRIAR O BANCO DE DADOS
  
  Update-DataBase -Context NOME.DO.BANCO.CRIADO   - PARA ATUALIZAR O BANCO DE DADOS



