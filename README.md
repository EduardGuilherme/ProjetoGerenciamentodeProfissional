# Gerenciamento de Profissionais
Este é um projeto de sistema de gerenciamento de profissionais, desenvolvido em ASP.NET Core 
com integração ao banco de dados, para cadastrar, listar, atualizar e excluir profissionais e 
suas especialidades. 

## 📋 Funcionalidades
Cadastro de Profissionais: Inserção de novos profissionais, associando-os a uma especialidade.
Listagem de Profissionais: Exibição de todos os profissionais cadastrados no sistema.
Atualização de Profissionais: Edição dos dados de um profissional existente.
Exclusão de Profissionais: Remoção de um profissional do sistema.
Gerenciamento de Especialidades: Cadastro pré-definido de especialidades médicas e de outras áreas de atuação.
## 🛠️ Tecnologias Utilizadas
ASP.NET Core: Framework para o desenvolvimento do backend.
Entity Framework Core: Para mapeamento objeto-relacional (ORM).
SQL Server/SQLite: Banco de dados para armazenamento das informações.
Bootstrap: Framework CSS para estilização do frontend.
JavaScript: Para operações dinâmicas e chamadas à API.
JSON: Formato para troca de dados entre frontend e backend.
## 📂 Estrutura do Projeto
Controllers: Controladores para gerenciar as requisições da API.
ProfissionalController: Gerencia as operações relacionadas aos profissionais.
Models: Modelos de dados representando as entidades do sistema.
Profissional
Especialidade
Repository: Implementação de lógica para acessar e manipular os dados no banco.
IProfissionalRepository
ProfissionalRepository
Frontend: Interface HTML com formulários e funcionalidades dinâmicas para interação com a API.

## 🚀 Como Executar

### Clone o repositório:
git clone https://github.com/seu-usuario/gerenciamentodeprofissionais.git
cd gerenciamentodeprofissionais

### Configure o banco de dados:
Altere as configurações de conexão em appsettings.json.

### Restaure as dependências e compile:
dotnet restore
dotnet build

### Execute as migrações (caso esteja utilizando Entity Framework):
dotnet ef database update

### Inicie o servidor:
dotnet run
### Acesse o sistema no navegador:
Abra o Index.html que se encontra no projeto e execute ele após executar o Asp.net core

acesse para testar as rotas 
https://localhost:7197

### 📄 Endpoints da API
Profissionais
GET /api/Profissional: Retorna a lista de todos os profissionais.
GET /api/Profissional/{id}: Retorna os dados de um profissional pelo ID.
POST /api/Profissional: Cadastra um novo profissional.
PUT /api/Profissional/{id}: Atualiza os dados de um profissional existente.
DELETE /api/Profissional/{id}: Remove um profissional pelo ID.

✨ Como Contribuir
Faça um fork do projeto.
Crie uma branch com sua feature:

git checkout -b minha-feature
Commit suas mudanças:

git commit -m 'Minha nova feature'
Envie a branch para o repositório remoto:

git push origin minha-feature
Abra um Pull Request no repositório original.
# 📷 Imagem de Demonstração
![Imagens do projeto](https://private-user-images.githubusercontent.com/54726712/389346935-b71d6a4f-1002-4765-8c30-78ce68c305ee.PNG?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3MzI1MDM2NTUsIm5iZiI6MTczMjUwMzM1NSwicGF0aCI6Ii81NDcyNjcxMi8zODkzNDY5MzUtYjcxZDZhNGYtMTAwMi00NzY1LThjMzAtNzhjZTY4YzMwNWVlLlBORz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNDExMjUlMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjQxMTI1VDAyNTU1NVomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPWFhZjgzNDA2NzU0MjA2YjM3Mzc0Yzk5ZTJkODMxNWJlN2Q4ZDRhMTYwZTcxOWY5OGEzNzE0Y2ZjNzUyNThiMmMmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0In0.wf7kE6BHj7soWMOhMYPW2Q9zagNI7FwQhlEhNpccdIA) ![teste02](https://private-user-images.githubusercontent.com/54726712/389346937-c57c0452-b752-4d0d-a49e-4caa376341ec.PNG?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3MzI1MDM2NTUsIm5iZiI6MTczMjUwMzM1NSwicGF0aCI6Ii81NDcyNjcxMi8zODkzNDY5MzctYzU3YzA0NTItYjc1Mi00ZDBkLWE0OWUtNGNhYTM3NjM0MWVjLlBORz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNDExMjUlMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjQxMTI1VDAyNTU1NVomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPTJkMTEyZWQxNzQ4ZTc1ZjhlOTI0NTg5NzcyZmQ0MjAzNDM3NzBmNTM2ZDZmNzhjYThjYTA0ZDIxZTM4ZGVmOTEmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0In0.J-PoJikY7-AoLZFfBSWj8keoMbk1gQuZKqcZNxgNcQo)

# 📧 Contato
Autor: Eduardo Guilherme dos Santos Junior
LinkedIn: linkedin.com/in/eduardguilherme
Email: eduardoguilherme@example.com
