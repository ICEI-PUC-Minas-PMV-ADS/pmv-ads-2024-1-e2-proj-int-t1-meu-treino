# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

Nome: Lucas
<br>
Idade: 20 anos
<br>
Descrição da Persona:
<br>
Lucas é uma pessoa que gosta de musculação e está sempre em busca de maneiras inovadoras de aprimorar seus treinos, ele procura constantemente ferramentas que o ajudem a atingir seus objetivos.

Nome: Douglas
<br>
Idade: 20 anos
<br>
Descrição da Persona:
<br>
Douglas é uma pessoa que busca alcançar seu IMC ideal, porém lida com uma vida corrida e precisa de auxílio para montar seus treinos.

Nome: Natália
<br>
Idade: 23 anos
<br>
Descrição:
<br>
Natália está buscando um estilo de vida mais saudável e decidiu iniciar a academia, porém não tem muito conhecimento dos exercícios.

Nome: Alice <br>
Idade: 26 anos <br>
Descrição:
Alice é uma pessoa sedentária que busca mudar esse estilo de vida iniciando a academia, seu objetivo é encontrar algum aplicativo que a facilite a criar treinos sem que precise recorrer a um personal.

Nome: Adriana <br>
Idade: 25 anos <br>
Descrição: Adriana é apaixonada por musculação, mas recentemente percebeu que sua energia e desempenho nos treinos não eram mais os mesmos. Seu objetivo é encontrar algum aplicativo com treinamento adaptados aos seus objetivos e nível de condicionamento físico

Nome: Maria Augusta <br>
Idade: 35 anos <br>
Descrição: Sempre colocou as necessidades de sua família em primeiro lugar, mas recentemente percebeu que precisa dedicar mais tempo e atenção à sua própria saúde e bem-estar.



## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Usuário| Gostaria de visualizar algo que possa me auxiliar nos movimentos dos exercício           |  Para que eu possa executá-los corretamente               |
|Usuário| Gostaria de encontrar novos exercícios de maneira fácil.                | Para que eu consiga diversificar meus treinos. |
|Usuário| Eu como usuário gostaria de conseguir ter um direcionamento para oque fazer em meus treinos diários. |  Para que eu tenha um direção de como devo prosseguir com meu treino |
|Usuário| Eu como usuário gostaria de ter um acompanhamento da minha evolução.                | Para que eu possa alcançar meu objetivo de saúde ideal. |
|Usuário| Eu, como usuário iniciante em musculação, gostaria de ter acesso a um guia simples e claro | Para começar as atividades físicas. |
|Usuário| Eu, como usuário iniciante em musculação, gostaria de ter acesso fácil aos treinos rápidos | Para poder realizá-los em casa. |
|Usuário| Eu como usuário gostaria de encontrar exercícios específicos para cada grupo muscular.| Para poder criar treinos mais específicos. |
|Usuário| Eu como usuário gostaria de ter acesso a informações sobre cada exercício. | Para direcionar meu treino para meus objetivos. |
|Usuário| Eu, como usuária, gostaria de encontrar exercícios para o meu tipo de nível de condicionamento físico. | Para alcançar meu objetivo de saúde ideal. |
|Usuário| Eu, como usuária, gostaria de encontrar exercícios adaptados ao meu objetivo pessoal. | Para alcançar mais resultados. | 
Usuário| Eu, como usuária, quero  encontrar treinos curtos e eficazes que possa fazer  | para me manter ativa e saudável.
Usuário| Eu, como usuária, preciso adaptar os exercícios à minha agenda. | para garantir que estou fazendo escolhas realistas e sustentáveis em relação ao meu programa de exercícios.



## Requisitos

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve ter uma avaliação para cada exercício. | BAIXA |
|RF-002| A aplicação deve permitir ao usuário calcular seu IMC. | ALTA  |
|RF-003| A aplicação deve permitir incluir exercícios ao favorito. | MÉDIA  |
|RF-004| A aplicação deve apresentar uma lista de exercícios de alguns grupos musculares, incluindo nome, descrição e imagem/ilustração. | ALTA  |
|RF-005| A aplicação deve ter a capacidade de pesquisar exercícios por nome, grupo muscular ou equipamento necessário. | MÉDIA| 
|RF-006| A administração deve ter a capacidade de adicionar, editar ou remover exercícios. | ALTA|
|RF-007| A aplicação deve ter um painel de administração.  | ALTA|
|RF-008| A aplicação deve permitir ao usuário registrar seu peso.| ALTA|
|RF-009| A aplicação deve permitir ao usuário acompanhar o progresso de seu peso.  | ALTA|
|RF-010| A aplicação deve permitir ao usuário editar seu perfil. | BAIXA|

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser responsiva. | ALTA | 
|RNF-002| A aplicação deve ser acessível e fácil de usar em dispositivos móveis, como smartphones e tablets. |  ALTA |
|RNF-003| A aplicação deve ser compatível com as versões mais recentes dos navegadores Google Chrome e Microsoft Edge. |  ALTA |
|RNF-004| A aplicação deve garantir um carregamento rápido das imagens, mesmo em conexões de internet mais lentas. | MÉDIA | 
|RNF-005| A aplicação deve ter uma interface simples que permita aos usuários encontrar facilmente as informações desejadas. | ALTA |
|RNF-006| Atender aos padrões MVC. | ALTA |

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O site deve se concentrar exclusivamente em conteúdo relacionado à musculação, incluindo treinamento, equipamentos|
|RE-02| O site deve ser projetado para atender às necessidades de iniciantes que  estão aptos a treinar e que queiram praticar atividades físicas |
|RE-03| O conteúdo do site deve ser preciso, relevante e baseado em evidências científicas, fornecendo informações úteis e confiáveis sobre treinamento de musculação e saúde. |
|RE-04| O projeto deverá ser entregue até o final do semestre letivo, não podendo extrapolar a data final |
|RE-05| A equipe de projeto será restrita aos membros do grupo. |
|RE-06| O site deve ser otimizado para dispositivos móveis e oferecer uma experiência de usuário consistente em diferentes tamanhos de tela e dispositivos. |


## Diagrama de Casos de Uso

![Diagrama de casos de Uso](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-meu-treino/blob/main/docs/img/Diagrama%20De%20Caso%20Uso.jpg)

