# QA_Test_Portfolio  - Testes Automatizados com Playwright

Repositório de testes automatizados desenvolvidos como parte do meu portfólio de QA.

## Sobre

Testes E2E do meu portfólio pessoal ([adriandotnet.com](https://adriandotnet.com)) utilizando **Playwright** com **C#** e **NUnit**.

## Tecnologias

- C# | .NET10

- Playwright

- NUnit

## Testes implementados

- Carregamento da página inicial

- Exibição do nome no hero

- Links do GitHub e LinkedIn visíveis e com abertura em nova aba

- Seção de projetos visível

- Projeto principal listado corretamente

## Resultado final

✅ 12 de 12 testes aprovados

## Como rodar

```bash

# Instalar dependências

dotnet restore

# Instalar browsers do Playwright

pwsh -File "Portfolio Teste/bin/Debug/net10.0/playwright.ps1" install

# Rodar os testes

dotnet test

```
