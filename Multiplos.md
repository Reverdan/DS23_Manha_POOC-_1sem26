# 🏁 Projeto Múltiplos - Múltiplos Formulários em C#

## 📝 Descrição Detalhada do Projeto

O projeto **Multiplos** é uma aplicação Windows Forms desenvolvida em **C# .NET 8** que demonstra como estruturar uma aplicação com **múltiplos formulários**. Diferente de projetos simples com apenas uma tela, este projeto utiliza um formulário principal que atua como menu, permitindo ao usuário navegar entre diferentes funcionalidades (Primalidade, Fatorial e Triângulos).

O foco principal é a **interação entre janelas**, o gerenciamento do **ciclo de vida dos formulários** e a organização do código em um ambiente multi-telas.

---

## 🏗️ Arquitetura e Organização

O projeto está organizado para suportar diversas interfaces independentes, todas conectadas por um menu central:

```
Multiplos/
├── apresentacao/
│   ├── Form1.cs             # Menu Principal (Janela Pai)
│   ├── frmPrimo.cs          # Tela de Verificação de Primos
│   ├── frmFatorial.cs       # Tela de Cálculo de Fatorial
│   └── frmTriangulos.cs     # Tela de Classificação de Triângulos
└── modelo/
    ├── absPropriedades.cs    # Base abstrata para todos os cálculos
    ├── Controle.cs          # Orquestrador central de funcionalidades
    ├── Validacao.cs         # Validação de dados genérica
    ├── Primo.cs             # Lógica específica de primos
    ├── Fatorial.cs          # Lógica específica de fatorial
    └── Triangulo.cs         # Lógica específica de triângulos
```

---

## 🖥️ Trabalho com Múltiplos Formulários

A aplicação utiliza o conceito de **formulários modais** para garantir que o usuário interaja com uma funcionalidade por vez.

### 1. Chamada de Formulários (`ShowDialog`)
Para abrir uma nova janela a partir do menu principal, o projeto utiliza o método `.ShowDialog()`. Este método abre o formulário de forma modal, o que significa que o usuário não pode interagir com a janela principal até que a janela aberta seja fechada.

**Exemplo de código no Menu Principal:**
```csharp
private void tsmPrimo_Click(object sender, EventArgs e)
{
    frmPrimo frmP = new frmPrimo(); // Instancia o formulário
    frmP.ShowDialog();               // Abre como janela modal
}
```

### 2. Controle de Visibilidade
Em algumas situações, como na abertura da tela de números primos, o projeto demonstra o controle de visibilidade da janela pai para limpar a área de trabalho do usuário:

```csharp
private void tsmPrimo_Click(object sender, EventArgs e)
{
    frmPrimo frmP = new frmPrimo();
    this.Visible = false;     // Esconde o menu principal
    frmP.ShowDialog();        // Exibe a tela de primos
    this.Visible = true;      // Mostra o menu principal novamente ao fechar
}
```

### 3. Organização via MenuStrip
A navegação é facilitada pelo uso do componente **MenuStrip**, que cria uma barra de menus profissional no topo da aplicação, permitindo acesso rápido a todas as funções sem poluir a interface.

---

## ⚙️ Conceitos de POO Aplicados

Mesmo com múltiplos formulários, o projeto mantém o rigor técnico da Orientação a Objetos:

- **Herança**: Uso de `absPropriedades` para garantir que todas as classes de lógica sigam o mesmo padrão de atributos (`Numero`, `Mensagem`).
- **Polimorfismo**: O `Controle` utiliza referências da classe base para manipular objetos de diferentes tipos de cálculo.
- **Encapsulamento**: Os formulários não acessam a lógica diretamente; eles dependem do `Controle` (Padrão Facade).

---

## 🔄 Fluxo de Navegação

1. **Início**: O programa inicia pelo `Form1` (Menu Principal).
2. **Seleção**: O usuário escolhe uma opção no menu superior.
3. **Abertura**: O formulário correspondente é instanciado e exibido.
4. **Execução**: O usuário realiza os cálculos na tela específica.
5. **Retorno**: Ao fechar a tela secundária, o controle volta automaticamente para o Menu Principal.

---

## 🚀 Tecnologias Utilizadas

- **C# / .NET 8**
- **Windows Forms** (Componentes: `MenuStrip`, `Form`, `Label`, `TextBox`, `Button`)
- **Visual Studio 2022**

---

## 👨‍💻 Autor

Desenvolvido como material didático para a disciplina de **Programação Orientada a Objetos em C#** - **DS23 Manhã - 1º Semestre 2026**
