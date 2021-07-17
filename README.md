#🎶 API Cifras Club

<p align="center">
  <a href="#-tecnologias">✨ Tecnologias</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-projeto">💻 Projeto</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-como-executar"> 🚀Como executar</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-funcionamento-da-API"> 🔥 Funcionamento da API</a>
</p>
  
![image](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![image](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)

API Rest para músicas do aplicativo desenvolvido Cifras Club

## ✨ Tecnologias

Esse projeto foi desenvolvido com as seguintes tecnologias:

- [.NET](https://www.microsoft.com/pt-br/download/details.aspx?id=30653)
- [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/)
- [Visual Studio 2019](https://visualstudio.microsoft.com/pt-br/downloads/)

## 💻 Projeto

A API foi desenvolvido no curso Projeto e Engenharia de Software, na qual será utilado no desenvolvimento do software Cifras Club.
A API Rest Cifras Club recebe requisições do Front-End e direciona para tratamento no Back-End, na qual foi implementada um  simples CRUD para demostração do funcionamento.

## 🚀 Como executar

- Clone o repositório
- Execute a solução na IDE
- API funcionando

## 🔥 Funcionamento da API

- https://localhost:XXXX/
  - /api/musicas
    - Faz um GET de todas as músicas presente no servidor
  - /api/musicas/X
    - X é o id da música, deve ser um inteiro, retorna os dados da música
  - api/musica/?ano=Y
    - Y deve ser inteiro, retorna todas as músicas desse ano Y
  - api/musica/?nome=Y
    - Y deve ser string, retorna todas as músicas que possuem esse nome
  - api/musica/?banda=Y
    - Y deve ser string, retorna todas as músicas que possuem esse banda
  - api/musica/?compositor=Y
    - Y deve ser string, retorna todas as músicas que possuem esse compositor

Feito com ❤️ por 
  - ELTON RAFAEL COSTA DA SILVA 👏
  - DANIEL SILVA SANTIAGO 👏
  - KAIO VICTOR DA COSTA MENEZES 👏
  - JOAO LUIZ DA CUNHA CAMELO ANJOS 👏
  - JOAO VITOR MACHADO PINHEIRO 👏

Obrigado a todos! 💖
