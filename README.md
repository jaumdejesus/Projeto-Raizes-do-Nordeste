Multi-Channel & Multi-Unit OMS API
Este projeto consiste em uma API de um Order Management System (OMS) robusto, projetado para gerenciar operações de vendas em múltiplas 
unidades físicas (lojas/unidades) e através de múltiplos canais (App, Web, Totem). A arquitetura foca em escalabilidade, integridade de dados e 
separação de responsabilidades.

Principais Funcionalidades
Gestão Multi-Unidade: Controle de estoque e precificação diferenciada por unidade física.
Venda Multi-Canal: Rastreamento da origem de cada pedido para análise de performance por canal.
Programa de Fidelidade: Cálculo automatizado de pontos para clientes fidelizados.
Segurança: Autenticação e autorização via JWT (JSON Web Token).
Arquitetura Limpa: Implementação utilizando DTOs, Service Layer e Transaction Pattern para garantir a consistência das vendas.

Stack Tecnológica
Linguagem: C# / .NET (ou Java, conforme sua implementação atual)
ORM: Entity Framework Core
Autenticação: JWT Bearer
Banco de Dados: PostgreSQL / SQL Server
Documentação: Swagger (OpenAPI)

Modelo de Dados
O banco de dados foi modelado para suportar relações complexas entre produtos e unidades, garantindo que o estoque seja isolado por localidade.
erDiagram
    CLIENTE ||--o{ PEDIDO : realiza
    UNIDADE ||--o{ PEDIDO : processa
    UNIDADE ||--o{ PRODUTO_UNIDADE : possui
    PRODUTO ||--o{ PRODUTO_UNIDADE : distribuido_em
    CATEGORIA_PRODUTO ||--o{ PRODUTO : classifica
    PEDIDO ||--o{ ITEM_PEDIDO : contem
    CANAL_PEDIDO ||--o{ PEDIDO : via
    STATUS_PEDIDO ||--o{ PEDIDO : estado

Estrutura da Solução
A API segue o padrão de camadas para facilitar a manutenção e evolução:
Controllers: Endpoints enxutos que gerenciam as requisições HTTP.
Services: Camada onde reside toda a regra de negócio (baixa de estoque, cálculo de fidelidade, validações).
DTOs (Data Transfer Objects): Objetos de transporte para garantir que a API exponha apenas os dados necessários.
Repositories: Abstração do acesso ao banco de dados através do EF Core.

Principais Endpoints
Autenticação
POST /auth/login - Gera o token JWT para acesso.

Catálogo e Estoque
GET /unidades/{id}/estoque - Lista produtos e preços disponíveis em uma unidade específica.

PATCH /produtos/estoque - Atualiza a quantidade ou preço de um produto em uma unidade.

Vendas
POST /pedidos - Cria um novo pedido, valida estoque e processa a transação.

GET /pedidos/{id} - Retorna os detalhes completos de uma venda.

Como Executar o Projeto
Clone o repositório:
git clone https://github.com/jaumdejesus/Projeto-Raizes-do-Nordeste.git

Configure o Banco de Dados:
Atualize a Connection String via secret manager.

Rode as Migrations:
dotnet ef database update

Desenvolvido por João Victor de Jesus Guimarães

