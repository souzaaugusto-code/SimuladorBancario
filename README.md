# 💳 Simulador Bancário


Projeto desenvolvido com o objetivo de praticar conceitos de Programação Orientada a Objetos (POO) utilizando C#.

O sistema simula operações bancárias básicas com dois tipos de conta:

* Conta Corrente
* Conta Poupança

## Funcionalidades

### Conta Corrente

* Depósito
* Saque
* Uso de limite (cheque especial)
* Exibição de saldo e limite disponível

### Conta Poupança

* Depósito
* Saque
* Aplicação de rendimento
* Simulação de rendimento ao longo dos meses

## Conceitos aplicados

Durante o desenvolvimento deste projeto foram praticados conceitos importantes de C# e POO, como:

* Classes e Objetos
* Encapsulamento
* Herança
* Abstração
* Polimorfismo
* Métodos virtuais (`virtual`)
* Sobrescrita de métodos (`override`)
* Uso de `base`
* Construtores
* Properties
* Geração de identificadores únicos com `Guid`

## Estrutura do projeto

* `Conta` → Classe abstrata base com comportamentos comuns
* `ContaCorrente` → Especialização com suporte a limite
* `ContaPoupanca` → Especialização com rendimento
* `Program` → Demonstração de uso das classes


## Objetivo

Criado para consolidar fundamentos de orientação a objetos por meio de um cenário prático.
