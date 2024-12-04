# CI/CD Workflow

Este repositório contém uma implementação de CI/CD utilizando GitHub Actions para automatizar a atualização de uma aplicação C# com uma página HTML e um banco de dados PostgreSQL. O workflow gerencia duas branches principais (dev e main) e aplica migrações automaticamente no banco de dados.
Para isso, foram criados 2 sites separados no Azure e 2 bancos de dados no supabase. Assim, temos um ambiente para produção e outro para desenvolvimento.

## 🛠️ Configuração do Workflow
1. **Atualização Automática:**

- **Branch dev**: O workflow é disparado em cada pull request ou push, compilando o projeto e atualizando o banco.
- **Branch main**: Executa diariamente às 19 horas para deploy automático e migração do banco.

2. **Banco de Dados:**

Realiza migrações automáticas no banco PostgreSQL usando Entity Framework Core, onde todas as mudanças são aplicadas no CI/CD.
Para que as migrações sejam realizadas, caso necessário, crie a migração com: 
```
dotnet ef migrations add <NomeDaMigracao>
```

3. **Arquivo do Workflow**
O arquivo do workflow está localizado em .github/workflows

## 🔑 Chaves secretas
Para que os 2 bancos e 2 sites sejam atualizados automaticamente, foram criadas chaves secretas separadas para cada banco e cada workflow recebe sua respectiva chave.

- AZURE_STATIC_WEB_APPS_API_TOKEN: Token para autenticação no Azure Static Web Apps.
- DB_CONNECTION_MAIN / DB_CONNECTION_DEV: String de conexão com o banco de dados PostgreSQL.

## 💻 Como o Processo Funciona
1. Build e Deploy:
O código HTML é enviado para o Azure Static Web Apps.

2. Compilação e Migração:
O projeto C# é compilado e a aplicação de migrações no banco de dados é feita automaticamente com o comando dotnet run.

3. Agendamento:
A atualização do sistema ocorre todos os dias às 19 horas, garantindo que o ambiente de produção esteja sempre atualizado.
