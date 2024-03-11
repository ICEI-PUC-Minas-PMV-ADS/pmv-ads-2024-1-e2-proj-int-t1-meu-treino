# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

Nome: Lucas
Idade: 20 anos
Descrição da Persona:
Lucas é uma pessoa que gosta de musculação e está sempre em busca de maneiras inovadoras de aprimorar seus treinos, ele procura constantemente ferramentas que o ajudem a atingir seus objetivos.

Nome: Douglas
Idade: 20 anos
Descrição da persona:
Douglas é uma pessoa que busca alcançar seu IMC ideal, porém lida com uma vida corrida e precisa de auxílio para montar seus treinos.

Nome: Natália
Idade: 23 anos
Descrição da persona:
Natália está buscando um estilo de vida mais saudável e decidiu iniciar a academia, porém não tem muito conhecimento dos exercícios.

Nome: Alice
Idade: 26 anos
Descrição:
Alice é uma pessoa sedentária que busca mudar esse estilo de vida iniciando a academia, seu objetivo é encontrar algum aplicativo que a facilite a criar treinos sem que precise recorrer a um personal.

Nome: Adriana
Idade: 25 anos
Descrição:
Adriana é apaixonada por musculação, mas recentemente percebeu que sua energia e desempenho nos treinos não eram mais os mesmos. Seu objetivo é encontrar algum aplicativo com treinamento adaptados aos seus objetivos e nível de condicionamento físico


> **Links Úteis REMOVER DEPOIS**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Usuário do sistema| gostaria de visualizar algo que possa me auxiliar nos movimentos dos exercício           |  para que eu possa executá-los corretamente               |
|Usuário do Sistema| gostaria de encontrar novos exercícios de maneira fácil.                | para que eu consiga diversificar meus treinos. |
|Usuário do sistema  | gostaria de conseguir ter um direcionamento.           |  para que eu possa fazer meus treinos diários corretamente.               |
|Usuário do sistema  | gostaria de ter um acompanhamento da minha evolução.           |  para que eu possa ter noção da evolução.              |
|Usuário do sistema  | gostaria de encontrar exercícios específicos para cada grupo muscular.           |  para que eu possa focar em pontos fracos.               |
|Usuário do sistema  | gostaria de ter acesso a informações sobre cada exercício.           |  para que eu possa entendelos corretamente.               |
|Usuário do sistema  | gostaria de ter acesso a um guia simples e claro.          |   para que eu possa começar as atividades físicas.               |
|Usuário do sistema  | gostaria de ter acesso fácil aos treinos rápidos que posso realizar em casa.           |  para que eu possa otimizar o meu tempo.               |
|Usuário do sistema  | gostaria de encontrar exercícios para o meu tipo de nível de condicionamento físico.           |  para que eu nao ultrapasse os limites de um iniciante.             |
|Usuário do sistema  | gostaria de encontrar exercícios adaptados ao meu objetivo pessoal.           |  para que eu possa executá-los da maneira mais rapido possivel.              |
|Usuário do sistema  | quero  encontrar treinos curtos e eficazes que possa fazer.           |  para me manter ativa e saudável.              |
|Usuário do sistema  |  preciso adaptar os exercícios à minha agenda.           |  para garantir que estou fazendo escolhas realistas e sustentáveis em relação ao meu programa de exercícios.            |


> **Links Úteis REMOVER DEPOIS**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação devera fazer autenticação e autorização dos usuários |  | 
|RF-002| O usuário deve ter acesso a informações sobre cada exercício, incluindo instruções de execução e dicas de forma correta.   | ALTA |
|RF-003| Apresentar uma lista de exercícios de alguns grupos musculares, incluindo nome, descrição e imagem/ilustração. | ALTA |
|RF-004| Capacidade de pesquisar exercícios por nome, grupo muscular ou equipamento necessário. | MÉDIA |
|RF-005| A administração deve ter a capacidade de adicionar, editar ou remover exercícios. | ALTA |
|RF-006| Deve ter um painel de administração |  |
|RF-007| Deve ter uma avaliação para cada exercício  | BAIXA |
|RF-008| A aplicação deve permitir ao usuário calcular seu IMC | ALTA  |
|RF-009| A aplicação deve permitir ao usuário registrar seu peso e acompanhar seu progresso | MÉDIA |
|RF-010| A aplicação deve permitir incluir exercícios ao favorito | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser responsiva | ALTA | 
|RNF-002| A aplicação deve ser acessível e fácil de usar em dispositivos móveis, como smartphones e tablets |  ALTA |
|RNF-003| A aplicação deve ser compatível com as versões mais recentes dos navegadores Google Chrome e Microsoft Edge | ALTA |
|RNF-004| A aplicação deve garantir um carregamento de no maximo 10 segundos, mesmo em conexões de internet mais lentas | MÉDIA |
|RNF-005| A aplicação deve ter uma interface simples que permita aos usuários encontrar facilmente as informações desejadas. | ALTA |
|RNF-006| Atender aos padrões MVC | MÉDIA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O site deve se concentrar exclusivamente em conteúdo relacionado à musculação, incluindo treinamento, equipamentos, |
|02| O site deve ser projetado para atender às necessidades de iniciantes que  estão aptos a treinar e que queiram praticar atividades físicas        |
|03| O conteúdo do site deve ser preciso, relevante e baseado em evidências científicas, fornecendo informações úteis e confiáveis sobre treinamento de musculação e saúde.        |
|04| O projeto deverá ser entregue até o final do semestre letivo, não podendo extrapolar a data final        |
|05| A equipe de projeto será restrita aos membros do grupo       |
|06| O site deve ser otimizado para dispositivos móveis e oferecer uma experiência de usuário consistente em diferentes tamanhos de tela e dispositivos.       |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
