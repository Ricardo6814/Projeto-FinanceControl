# 📊 Projeto FinanceControl

> Um sistema simples de controle financeiro pessoal, desenvolvido em C# com ASP.NET Core e Entity Framework Core.

---

## 🚀 Sobre o Projeto

O **FinanceControl** é uma API REST que permite o gerenciamento de transações financeiras, oferecendo operações de **CRUD** (Criar, Ler, Atualizar, Deletar) de forma simples e eficiente.

Este projeto foi criado com foco educacional, para praticar conceitos de backend, banco de dados com Entity Framework e documentação de API com Swagger.

---

## 🛠️ Tecnologias Utilizadas

- ✅ C# (.NET 7)
- ✅ ASP.NET Core Web API
- ✅ Entity Framework Core
- ✅ SQLite
- ✅ Swagger / OpenAPI

---

## 📂 Estrutura do Projeto

Projeto-FinanceControl
│
├── Controllers
│ └── TransacoesController.cs
│
├── Data
│ └── AppDbContext.cs
│
├── Models
│ └── Transacao.cs
│
├── appsettings.json
├── Program.cs
└── Projeto-FinanceControl.csproj

---

## 💾 Configuração do Banco de Dados

O projeto usa um banco de dados **SQLite**. Ao executar o projeto, será criado um arquivo chamado:

FinanceControl.db

Dentro da raiz do projeto.

---

## ⚙️ Como Executar o Projeto Localmente

### Pré-requisitos:

- .NET 7 SDK instalado  
- Visual Studio, VS Code ou outro editor de sua preferência

### Passos:

1. Clone o repositório:

```bash

git clone https://github.com/Ricardo6814/Projeto-FinanceControl.git

2. Navegue até a pasta do projeto:
cd Projeto-FinanceControl

3. Restaure os pacotes:
dotnet restore

4. Rode as migrações (se necessário):
dotnet ef migrations add InitialCreate
dotnet ef database update

5. Execute a aplicação:
dotnet run

Acessando o Swagger (Documentação Interativa)
https://localhost:port/swagger
