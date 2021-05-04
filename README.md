# Marcos Cesar Ribeiro Ferrare - 03/05/2021

## Desafio Prático

- Projeto foi criado no dotnet core 3.1
- Projeto foi separado em 4 classlib e uma webapi:

1. Application - API
2. CrossCutting - Responsável por injetar as dependencias
3. Data - Responsável pela Infraestrutura Do Banco
4. Domain- Responsável pelo Dominio
5. Service - Responsável pelos services ou serviços que serão usados no controller

#### Foi disponibilizado um docker-compose com o container do postgres, para iniciar o container com o banco rodar:

```
docker-compose up -d
```

#### Migrations está presente usando entity framework core, rodar para atualizar o banco:

```
dotnet ef database update
```

## Desafio Teórico

#### Perguntas e respostas

```bash
# 1º:
C - É uma modelagem de software focada em resolver problemas na complexidade do negócio.
```

```bash
# 2º:
A - O teste é realizado antes de criar o código real a ser testado.
```

```bash
# 3º:
CORRETO
```

```bash
# 4º:
B - DISTINCT
```

```bash
# 5º:
Isso no meu ponto de vista depende do negócio, há bancos não relacionais que não fica a critério do ID ser incremental ou aplica-se um GUID.
Agora se eu estiver trabalhando com banco relacional e minha regra não envolve GUID nas chaves primárias,
eu costumo e acho boa prática ser incremental
```

```bash
# 6º:
C - select * from produto as p left join fotoProduto as fp on p.primaryKey = fp.produtoId
```

```bash
# 7º:
NOSQL(NO Sequence Query Language) São bancos não relacionais, onde por performance tabelas não se relacionam otimizando as consultas.
Geralmente são orientados em documentos(armazenado os objetos em documentos)
O mais popular que conheço é o MongoDB

```

```bash
# 8º:
NOSQL tem um performance melhor, mas acredito que e tomada de decisão partindo do meu ponto de vista seria pensando na minha base e no projeto.
Se meu projeto depende de uma base com muita informação, muitas tabelas eu ainda opto pelo relacional.
```

```bash
# 9º:
B - Local
```

```bash
# 10º:
Verdadeiro
```

```
# 11º:
D - "String fora do padrão"
```

```bash
# 12º:
H - Nenhuma das anteriores
```

```bash
# 13º:
A - Sobrecarga
```

```bash
# 14º:
int A = 1;
int B = 5;

A = A + B;
B = A - B;
A = A - B;

Console.WriteLine(A);
Console.WriteLine(B);
```

```bash
# 15º:
NET Framework é usado para desenvolvimento de na plataforma Windows.
NET Core é usada para criar aplicações para qualquer ambiente cross-plataform.
```

```bash
# 16º:
paises.Find(p => p == "Brasil")
```

```bash
# 17º:
V
F
V
F
V
```

```bash
# 18º:
Multithreads podem atender várias solicitações caso CPU tiver mais que um núcleo, já que é possível executar várias threads simultaneamente.
singlethread, onde o rodam solicitações em uma única thread.
```

```bash
# 19º:
B - Local
```

```bash
# 20º:
Verdadeiro
```

```
# 21º:
C - para interceptar os request
D - para interceptar os response
```

```bash
# 22º:
A - Single Thread
```

```bash
# 23º:
A - V8
```

```bash
# 24º:
E - JavaScript
```

````bash
# 25º:
B - Node é focado em migrar JavaScript do frontend para o backend```
```bash
# 26º:
Angular é um framework, pois disponibiliza todo um ecosistema para desenvolvimento de uma aplicação front-end
````

```bash
# 27º:
Componentes são encapsulamento de "blocos" para reutilização em toda a aplicação. Você cria um trecho que pode ser importado e reutilizado
em qualquer parte da aplicação, esses componentes também aceitam parâmetros.
```

```bash
# 28º:
C - para dividir em colunas uma linha
```

```bash
# 29º:
D - São Pré-processadores de CSS
```

```bash
# 30º:
B - Ordenar uma DIV para a esquerda ou direta
```

```bash
# 31º:
D - É uma lib para manipular o DOM da página
```

```bash
# 32º:
A - Caso o HTML de um site tenha um erro de Sintaxe ele não sera exibido no Browser
```

```bash
# 33º:
B - Para o Browser carregar mais rápido uma pagina
```
