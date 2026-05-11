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

## 🏛️ Gestão de Múltiplos Formulários: Perspectivas Teóricas e Práticas

A arquitetura de aplicações multi-janelas em C# (Windows Forms) fundamenta-se na distinção entre duas modas de interação: **Modal** e **Modeless** (Não Modal). Essa escolha impacta diretamente o fluxo de controle da aplicação e a experiência do usuário (UX).

### 1. Taxonomia de Interfaces: Modal vs. Modeless

#### A. O Método `Show()` (Interface Modeless)
A chamada ao método `.Show()` instancia o formulário em modo **não-bloqueante**. Academicamente, isso significa que o encadeamento de execução (thread) do formulário chamador não é interrompido.
- **Concorrência de Interface**: O usuário pode alternar o foco entre o formulário principal e o secundário livremente.
- **Assincronismo Procedural**: O código subsequente à chamada `.Show()` é executado imediatamente, sem aguardar o fechamento da nova janela.
- **Ciclo de Vida**: O gerenciamento de memória e o descarte (`Dispose`) do formulário são geralmente delegados ao próprio objeto ao ser encerrado.

#### B. O Método `ShowDialog()` (Interface Modal)
O método `.ShowDialog()` implementa uma interface **modal**, estabelecendo um estado de interrupção no fluxo de trabalho da janela ancestral.
- **Natureza Bloqueante**: A execução do código no formulário chamador é suspensa na linha da chamada até que o formulário modal seja fechado ou escondido.
- **Hierarquia e Foco**: A janela modal retém a exclusividade da interação do usuário. É impossível interagir com o "Parent Form" enquanto o "Child Form" estiver ativo.
- **Comunicação via `DialogResult`**: Diferente do modo não-modal, o `ShowDialog` retorna um enumerador (`DialogResult.OK`, `DialogResult.Cancel`), permitindo que o formulário chamador tome decisões baseadas na ação do usuário na janela secundária.

---

### 2. Análise Técnica de Implementação

No contexto deste projeto, optou-se predominantemente pelo uso de **Interfaces Modais** para garantir a linearidade dos cálculos e evitar estados de inconsistência onde múltiplos cálculos concorrentes poderiam confundir o usuário.

**Exemplo de Implementação com Controle de Visibilidade:**

```csharp
private void tsmPrimo_Click(object sender, EventArgs e)
{
    // Instanciação: Alocação de memória para o novo objeto de interface
    frmPrimo frmP = new frmPrimo(); 
    
    // Ocultação do Contexto Ancestral: Melhora a carga cognitiva do usuário
    this.Visible = false;     
    
    // Chamada Modal: O fluxo de execução para aqui até que frmP seja encerrado
    frmP.ShowDialog();        
    
    // Retorno de Fluxo: Após o fechamento de frmP, a execução retoma
    this.Visible = true;      
}
```

### 3. Considerações sobre Gestão de Recursos

Em aplicações de alta complexidade, o uso de `ShowDialog()` impõe uma responsabilidade adicional ao desenvolvedor: o **Descarte Explícito**. Enquanto formulários `Show()` limpam seus recursos automaticamente, formulários exibidos via `ShowDialog()` permanecem na memória mesmo após fechados, permitindo que o desenvolvedor acesse propriedades e resultados do formulário encerrado. Recomenda-se o uso do padrão `using` para garantir a liberação de memória (Garbage Collection):

```csharp
using (frmFatorial frmF = new frmFatorial())
{
    if (frmF.ShowDialog() == DialogResult.OK)
    {
        // Processar resultados
    }
} // frmF é descartado automaticamente aqui
```

---

## ⚙️ Paradigmas de Orientação a Objetos Aplicados

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
