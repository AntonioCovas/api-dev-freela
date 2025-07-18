# DevFreela API


API RESTful construída em ASP.NET Core com arquitetura em camadas baseada em Clean Architecture. 


Este projeto é um sistema de gerenciamento de freelancers, onde é possível criar usuários (freelancers e contratantes), negociar projetos, adicionar comentários e controlar o andamento dos projetos.


O projeto em questão visa colocar em prática o que venho aprendendo na Formação .NET Expert da Next Wave Education.


> 🚧 Projeto em desenvolvimento! Próximo passo: implementação de persistência com Entity Framework Core.

---

## 📂 Estrutura da Solução

A solução está dividida em quatro projetos (class libraries), conforme o padrão Clean Architecture:

DevFreela

├ DevFreela.API → Camada de apresentação (Controllers, Models, Program)

├ DevFreela.Application → Casos de uso e regras de negócio (Services, DTOs, Interfaces)

├ DevFreela.Infrastructure→ Implementações de persistência e serviços externos (EF Core, Repositories)

├ DevFreela.Core → Entidades do domínio, enums, contratos, exceptions

---

## 🛠️ Tecnologias e Ferramentas

- .NET 8
- ASP.NET Core Web API
- C#
- Clean Architecture
- Injeção de Dependência (DI)
- Swagger / Swashbuckle
- Visual Studio 2022

---

## ✅ Funcionalidades Implementadas (ainda em fase inicial)

- [x] Criação de usuários
- [x] Criação, listagem e alteração de status de projetos
- [x] Criação de comentários em projetos
- [x] Listagem de habilidades de usuários freelancers
- [x] Camadas bem definidas utilizando abstrações via injeção de dependência
- [x] Documentação via Swagger

---

## 🔜 Próximos Passos

- [ ] Implementar persistência de dados com Entity Framework Core
- [ ] Criar banco de dados e migrations
- [ ] Implementar filters para validações e exceções

---

## 🚀 Como Executar o Projeto


1️⃣ Clone o repositório e rode o projeto localmente:

```bash
git clone https://github.com/AntonioCovas/api-dev-freela.git
cd DevFreela

dotnet build
dotnet run --project DevFreela.API
```

2️⃣ Acesse a documentação da API no navegador

https://localhost:{porta}/swagger (verifique a porta no console ao rodar o projeto)

---

## 🔌 Endpoints Principais

Acesse /swagger para visualizar todos os endpoints. Exemplos:

| Verbo HTTP | Rota                           | Descrição                     |
|------------|--------------------------------|-------------------------------|
| GET        | /api/projects                  | Lista todos os projetos       |
| POST       | /api/projects                  | Cria um novo projeto          |
| POST       | /api/users                     | Cadastra um novo usuário      |
| PUT        | /api/users/login               | Atualiza o login do usuário   |
| POST       | /api/projects/{id}/comments    | Adiciona comentário           |

---

## 📂 Organização das Camadas

Core

Contém as entidades do domínio (ex: User, Project), enums e exceções customizadas.


Application

Responsável pelas regras de negócio/casos de uso. Define os serviços (UserService, ProjectService), suas interfaces e os DTOs (InputModels e ViewModels).


Infrastructure

Implementação das interfaces de persistência e serviços. Contém o DbContext (a ser implementado com EF Core) e repositórios (ainda não implementados).


API

Camada de apresentação. Define os controllers que expõem os endpoints da aplicação. Também configura os serviços e o Swagger.

---

## 🧪 Testes

(Em breve)

---

## 🤝 Contribuições

Este projeto está sendo desenvolvido para fins de estudo e aprendizado, mas toda sugestão é bem-vinda!

---

## 👨‍💻 Autor

Desenvolvido por Antônio Covas

📧 Email: antoniocovasjr@gmail.com

🔗 LinkedIn: https://www.linkedin.com/in/antoniocovas/