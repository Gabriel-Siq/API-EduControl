# 🎓 API-EduControl — ASP.NET Web API Escalável

API desenvolvida para o gerenciamento de **Alunos**, **Cursos** e **Matrículas**, construída com foco em **arquitetura em camadas** e boas práticas de desenvolvimento.

## 🧩 Tecnologias Utilizadas
- **C# / .NET 8**
- **Entity Framework Core** com **Migrations**
- **SQL Server** para persistência de dados
- **Swagger** para documentação e testes de endpoints

## ⚙️ Principais Recursos
- Cadastro, atualização e exclusão de alunos e cursos  
- Associação de alunos a cursos (matrículas)  
- Estrutura organizada em camadas (Controllers, Services, Interfaces, Data, DTOs)  
- Conexão segura com banco SQL Server via Entity Framework  

## 📦 Arquitetura do Projeto
````
API-EduControl/
│
├── Controllers/
├── Data/
├── DTOs/
├── Interfaces/
├── Models/
└── Services/
````

## Objetivo
Facilitar o **acompanhamento e gerenciamento de matrículas** em cursos, fornecendo uma base sólida e escalável para futuras expansões do sistema.

## Iniciando o Projeto

Para executar o projeto **API-EduControl**, siga os passos abaixo:

1. **Verifique se possui o .NET 8 SDK** instalado na sua máquina.  
   - Você pode confirmar executando no terminal:
     ```bash
     dotnet --version
     ```

2. **Clone este repositório** para o seu computador:
   ```bash
   git clone https://github.com/SEU-USUARIO/API-EduControl.git.

3. **Abra o projeto na sua IDE de preferência** (Visual Studio ou Visual Studio Code).
4. **Configure a conexão com o banco de dados** no arquivo appsettings.json:
   ```bash
   "ConnectionStrings": {"DefaultConnection": "Server=SEU_SERVIDOR;Database=EduControl;Trusted_Connection=True;TrustServerCertificate=True;"}
   ```
5. **Aplique as migrations** para criar o banco de dados:
   - No terminal, execute:
     ```bash
     dotnet ef database update
     ```
6. **Execute o Projeto**:
   ```bash
   dotnet run
   ```
   Ou, se estiver usando o Visual Studio, pressione F5.
7. Após iniciar, acesse o **Swagger UI** para testar os endpoints:
    ```bash
    https://localhost:44334/swagger
    ```
    
## Funcionalidades do Projeto

O **API-EduControl** foi desenvolvido seguindo boas práticas de arquitetura e código, com foco em organização, escalabilidade e fácil manutenção.  

### Principais Recursos e Conceitos

- **Arquitetura em Camadas**: Separação entre responsabilidades — Controllers, Services, Interfaces, DTOs, Data e Models — garantindo organização e facilidade de manutenção.

- **Princípios SOLID**: O código segue os princípios de design **SOLID**, promovendo alta coesão, baixo acoplamento e maior facilidade de evolução.

- **Entity Framework Core**: Utilização do **Entity Framework Core** como ORM para mapeamento objeto-relacional, simplificando o acesso e manipulação dos dados no **SQL Server**.

- **Migrations Automatizadas**: Controle de versão do banco de dados através de **migrations**, permitindo atualizações e alterações estruturais seguras.

- **Injeção de Dependência (Dependency Injection)**: Utilização do container de injeção nativo do ASP.NET Core para gerenciar serviços e dependências de forma limpa e desacoplada.

- **ASP.NET Core Web API**: Implementação de uma API RESTful moderna utilizando o **.NET 8**, com endpoints organizados e documentados via **Swagger**.

- **CRUD Completo**: Implementação de operações **Create, Read, Update e Delete** para as entidades **Aluno** e **Curso**, com uso de **DTOs** para controle dos dados de entrada e saída.

- **Conexão Segura com SQL Server**: Comunicação direta com o banco de dados **EduControl** via autenticação do Windows e string de conexão configurável.

## 🛠️ Como Usar a API

O projeto **API-EduControl** fornece uma base pronta para construir APIs RESTful utilizando **ASP.NET Core 8** e **Entity Framework Core**. Você pode modificar e estender o código existente para atender às necessidades específicas da sua aplicação.  

A seguir, uma visão geral dos principais componentes e como eles se relacionam:

1. **Models (Modelos)**  
   - Contidos na pasta `/Models`  
   - Representam as entidades do domínio, como `Aluno` e `Curso`, sobre as quais serão realizadas operações CRUD.  
   - Atualize ou adicione novos modelos conforme necessário para o seu domínio.

2. **Data / Repositories (Repositórios)**  
   - Contidos na pasta `/Data` e implementados nos Services  
   - Encapsulam o acesso aos dados utilizando **Entity Framework Core**.  
   - Você pode modificar ou criar novos métodos de repositório para atender à estrutura das suas tabelas e entidades.

3. **Services (Serviços)**  
   - Contidos na pasta `/Services`  
   - Encapsulam a lógica de negócio e coordenam as operações nos repositórios.  
   - Atualize ou crie novos serviços para implementar regras de negócio e operações CRUD para suas entidades.

4. **Controllers (Controladores)**  
   - Contidos na pasta `/Controllers`  
   - Exponham os endpoints HTTP da API, tratando requisições e respostas.  
   - Implemente os métodos HTTP apropriados (**GET, POST, PUT, DELETE**) e interaja com os serviços para executar as operações desejadas.

---

💡 **Dica:**  
- Mantenha o uso de **DTOs** para entrada e saída de dados, garantindo segurança e desacoplamento entre API e banco de dados.  
- Teste os endpoints diretamente pelo **Swagger UI** ou com ferramentas como **Postman** para validar o funcionamento das rotas e payloads.
