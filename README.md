# 📱 Calculadora - Aplicação Windows Forms (.NET 8)

## 📋 Descrição

Aplicação de calculadora desenvolvida em **C# .NET 8** utilizando **Windows Forms**, implementando conceitos fundamentais de **Programação Orientada a Objetos (POO)** como responsabilidade única, encapsulamento, propriedades e construtores.

---

## 🏗️ Arquitetura do Projeto

O projeto está organizado em duas camadas principais:

```
Calculadora/
├── apresentacao/
│   ├── Form1.cs              # Interface gráfica (View)
│   ├── Form1.Designer.cs     # Configuração dos componentes visuais
│   └── Form1.resx            # Recursos do formulário
└── modelo/
    ├── Controle.cs           # Controlador principal
    ├── Validacao.cs          # Validação de dados
    └── Calculos.cs           # Operações matemáticas
```

---

## 🔄 Fluxo de Dados do Programa

O fluxo de dados segue o padrão **MVC simplificado** (Model-View-Controller):

### Detalhamento do Fluxo:

1. **Entrada do Usuário**: O usuário digita dois números nos campos de texto e clica em um botão de operação (+, -, *, /)
2. **Captura na View**: O `Form1` captura o evento de clique e chama o método `Executar()`
3. **Criação do Controle**: Instancia a classe `Controle` passando os valores dos TextBoxes e a operação
4. **Validação**: A classe `Controle` cria uma instância de `Validacao` que:
   - Converte as strings em números double
   - Verifica divisão por zero
   - Captura exceções de conversão
5. **Cálculo**: Se a validação for bem-sucedida, cria uma instância de `Calculos` que executa a operação
6. **Retorno**: O resultado (ou mensagem de erro) é retornado para o `Form1` através da propriedade `Mensagem`
7. **Exibição**: O `lblResultado` exibe o resultado final

---

## 🎨 Componentes Visuais (Interface)

### **TextBox: `txbPrimeiroNumero`**
- **Função**: Campo de entrada para o primeiro número da operação
- **Localização**: Linha 1 do formulário
- **Características**: Aceita entrada de texto que será validada e convertida para número

### **TextBox: `txbSegundoNumero`**
- **Função**: Campo de entrada para o segundo número da operação
- **Localização**: Linha 2 do formulário
- **Características**: Aceita entrada de texto que será validada e convertida para número

### **Label: `lblPrimeiroNumero`**
- **Função**: Rótulo descritivo "Digite o primeiro número"
- **Localização**: Acima do primeiro TextBox
- **Características**: Orientação visual para o usuário

### **Label: `lblSegundoNumero`**
- **Função**: Rótulo descritivo "Digite o segundo número"
- **Localização**: Acima do segundo TextBox
- **Características**: Orientação visual para o usuário

### **Button: `btnSomar`**
- **Função**: Executa a operação de **adição** (+)
- **Evento**: `btnSomar_Click` → chama `Executar("+")`
- **Localização**: Primeira linha de botões (esquerda)

### **Button: `btnSubtrair`**
- **Função**: Executa a operação de **subtração** (-)
- **Evento**: `btnSubtrair_Click` → chama `Executar("-")`
- **Localização**: Primeira linha de botões (direita)

### **Button: `btnMultiplicar`**
- **Função**: Executa a operação de **multiplicação** (*)
- **Evento**: `btnMultiplicar_Click` → chama `Executar("*")`
- **Localização**: Segunda linha de botões (esquerda)

### **Button: `btnDividir`**
- **Função**: Executa a operação de **divisão** (/)
- **Evento**: `btnDividir_Click` → chama `Executar("/")`
- **Localização**: Segunda linha de botões (direita)

### **Label: `lblResultado`**
- **Função**: Exibe o resultado da operação ou mensagens de erro
- **Localização**: Parte inferior do formulário
- **Características**: Conteúdo dinâmico atualizado após cada operação

---

## 🎯 Conceito: Responsabilidade Única (SRP - Single Responsibility Principle)

O **Princípio da Responsabilidade Única** estabelece que **cada classe deve ter uma única responsabilidade** ou motivo para mudar. Este projeto aplica rigorosamente este conceito:

### **Classe `Form1` (Apresentação)**
- **Responsabilidade**: Gerenciar a interface gráfica e eventos do usuário
- **Não faz**: Validação, cálculos ou lógica de negócio
- **Apenas**: Captura entrada, delega processamento e exibe resultados

```csharp
// ✅ Responsabilidade única: Interface com usuário
private void Executar(String op)
{
    Controle controle = new Controle(txbPrimeiroNumero.Text, txbSegundoNumero.Text, op);
    lblResultado.Text = controle.Mensagem;
}
```

### **Classe `Controle` (Controlador)**
- **Responsabilidade**: Coordenar o fluxo entre validação e cálculo
- **Não faz**: Interface, validação de dados ou operações matemáticas
- **Apenas**: Orquestra as chamadas entre `Validacao` e `Calculos`

```csharp
// ✅ Responsabilidade única: Coordenação
private void Validar()
{
    Validacao validacao = new Validacao(num1, num2, op);
    if (validacao.Mensagem.Equals(""))
    {
        Calculos calculos = new Calculos(validacao.N1, validacao.N2, op);
        this.mensagem = calculos.Resultado.ToString();
    }
}
```

### **Classe `Validacao` (Modelo)**
- **Responsabilidade**: Validar e converter os dados de entrada
- **Não faz**: Cálculos ou interface
- **Apenas**: Converte strings para double, valida divisão por zero e trata exceções

```csharp
// ✅ Responsabilidade única: Validação de dados
private void Validar()
{
    n1 = Convert.ToDouble(num1);
    n2 = Convert.ToDouble(num2);
    if (op.Equals("/") && n2 == 0.0)
        this.mensagem = "Não é possível dividir por zero.";
}
```

### **Classe `Calculos` (Modelo)**
- **Responsabilidade**: Executar operações matemáticas
- **Não faz**: Validação ou interface
- **Apenas**: Realiza as quatro operações básicas

```csharp
// ✅ Responsabilidade única: Operações matemáticas
private void Calcular()
{
    if (op.Equals("+")) resultado = n1 + n2;
    if (op.Equals("-")) resultado = n1 - n2;
    if (op.Equals("*")) resultado = n1 * n2;
    if (op.Equals("/")) resultado = n1 / n2;
}
```

### **Benefícios da Responsabilidade Única neste Projeto:**
✅ **Manutenibilidade**: Alterações em cálculos não afetam validação  
✅ **Testabilidade**: Cada classe pode ser testada isoladamente  
✅ **Reusabilidade**: A classe `Calculos` pode ser usada em outros projetos  
✅ **Clareza**: Fica evidente onde cada funcionalidade está implementada  

---

## 🔒 Conceito: Encapsulamento

**Encapsulamento** é o princípio de **ocultar detalhes internos** de uma classe e expor apenas o necessário através de uma interface controlada. Este projeto demonstra encapsulamento através de:

### **1. Atributos Private (Dados Internos Protegidos)**

```csharp
// ❌ Não acessível fora da classe
private Double n1;
private Double n2;
private String op;
private Double resultado;
```

**Por que usar `private`?**
- Protege os dados de modificações externas não controladas
- Evita inconsistências (ex: alguém alterar `resultado` sem executar o cálculo)
- Permite mudanças internas sem afetar código externo

### **2. Propriedades Public (Interface Controlada)**

```csharp
// ✅ Acesso controlado somente leitura
public Double Resultado
{
    get { return resultado; }
}
```

**Características das Propriedades:**
- **Somente leitura** (`get` apenas): Expõe dados sem permitir modificação externa
- **Validação**: Pode incluir lógica de validação no `set` (quando necessário)
- **Flexibilidade**: Permite mudar implementação interna sem afetar código que usa a classe

### **3. Métodos Private (Lógica Interna Oculta)**

```csharp
// ❌ Método privado: lógica interna
private void Calcular()
{
    if (op.Equals("+")) resultado = n1 + n2;
    // ...
}
```

**Por que métodos privados?**
- Usuários da classe não precisam saber **como** o cálculo é feito
- Podem ser refatorados sem afetar código externo
- Reduzem a superfície pública da classe

### **Comparação: Com vs. Sem Encapsulamento**

#### ❌ **SEM Encapsulamento (Má Prática)**
```csharp
public class CalculosMal
{
    public double n1;      // Público: pode ser alterado por qualquer código
    public double n2;
    public double resultado;
    
    // Qualquer código pode fazer:
    // calc.resultado = 999; // Resultado incorreto!
}
```

#### ✅ **COM Encapsulamento (Boa Prática)**
```csharp
public class Calculos
{
    private double n1;     // Privado: protegido
    private double n2;
    private double resultado;
    
    public Calculos(double n1, double n2, string op)
    {
        this.n1 = n1;
        this.n2 = n2;
        this.op = op;
        Calcular();        // Garante que resultado seja calculado
    }
    
    public double Resultado { get => resultado; } // Somente leitura
}
```

### **Exemplos de Encapsulamento no Projeto**

#### **Classe `Validacao`**
```csharp
private Double n1;           // ❌ Não acessível externamente
private String mensagem;     // ❌ Não acessível externamente

public double N1            // ✅ Acesso somente leitura
{
    get => n1;
}

public String Mensagem      // ✅ Acesso somente leitura
{
    get => mensagem;
}
```

**Benefício**: Garante que `n1` e `mensagem` só sejam definidos pela validação interna, não por código externo.

#### **Classe `Controle`**
```csharp
private String num1;         // ❌ Dados internos protegidos
private String num2;
private String op;
private String mensagem;

public Controle(String num1, String num2, String op)  // ✅ Inicialização controlada
{
    this.num1 = num1.Replace(".", ",");
    this.num2 = num2.Replace(".", ",");
    this.op = op;
    Validar();               // Processamento automático
}

public string Mensagem { get => mensagem; }  // ✅ Somente leitura
```

**Benefício**: Usuários da classe não podem criar um objeto `Controle` sem passar pelos processos de validação e cálculo.

### **Vantagens do Encapsulamento neste Projeto:**
✅ **Segurança**: Dados não podem ser corrompidos externamente  
✅ **Consistência**: Estado interno sempre válido  
✅ **Manutenção**: Mudanças internas não afetam código externo  
✅ **Legibilidade**: Interface pública clara e simples  

---

## 🏗️ Conceito: Métodos Construtores

Um **construtor** é um método especial que é executado **automaticamente** quando um objeto é criado. Ele **inicializa o estado** do objeto.

### **Características dos Construtores**

```csharp
public class Calculos
{
    // Construtor: mesmo nome da classe, sem tipo de retorno
    public Calculos(double n1, double n2, string op)
    {
        this.n1 = n1;
        this.n2 = n2;
        this.op = op;
        Calcular();  // Executa cálculo automaticamente
    }
}
```

**Características:**
1. **Mesmo nome da classe**: `Calculos`
2. **Sem tipo de retorno**: Nem void
3. **Executado automaticamente**: Na criação do objeto com `new`
4. **Inicializa atributos**: Define valores iniciais
5. **Pode chamar métodos**: Como `Calcular()`

### **Construtores no Projeto**

#### **1. Classe `Controle`**
```csharp
public Controle(String num1, String num2, String op)
{
    // Normaliza formato decimal
    this.num1 = num1.Replace(".", ",");
    this.num2 = num2.Replace(".", ",");
    this.op = op;
    
    // Inicia processo de validação e cálculo
    Validar();
}
```

**Responsabilidades:**
- ✅ Recebe os dados da interface
- ✅ Normaliza formato de números (ponto → vírgula)
- ✅ Inicia automaticamente a validação
- ✅ Garante que o objeto está pronto para uso

**Uso:**
```csharp
// Ao criar o objeto, tudo é processado automaticamente
Controle controle = new Controle("10.5", "2.3", "+");
// Após esta linha, controle.Mensagem já contém o resultado!
```

#### **2. Classe `Validacao`**
```csharp
public Validacao(String num1, String num2, String op)
{
    this.num1 = num1;
    this.num2 = num2;
    this.op = op;
    
    // Executa validação automaticamente
    Validar();
}
```

**Responsabilidades:**
- ✅ Armazena os dados recebidos
- ✅ Executa validação imediatamente
- ✅ Converte strings para double
- ✅ Define mensagens de erro se necessário

**Uso:**
```csharp
Validacao validacao = new Validacao("15", "3", "/");
// Após esta linha, validacao.N1, validacao.N2 e validacao.Mensagem estão prontos
```

#### **3. Classe `Calculos`**
```csharp
public Calculos(double n1, double n2, string op)
{
    this.n1 = n1;
    this.n2 = n2;
    this.op = op;
    
    // Executa cálculo automaticamente
    Calcular();
}
```

**Responsabilidades:**
- ✅ Recebe números já validados
- ✅ Executa a operação matemática
- ✅ Armazena o resultado
- ✅ Garante que `Resultado` está disponível imediatamente

**Uso:**
```csharp
Calculos calculos = new Calculos(10.0, 5.0, "*");
// Após esta linha, calculos.Resultado já contém 50.0
```

### **Por que Usar Construtores?**

#### ❌ **SEM Construtor (Má Prática)**
```csharp
public class CalculosMal
{
    public double n1;
    public double n2;
    public double resultado;
    
    public void Calcular()
    {
        resultado = n1 + n2;
    }
}

// Uso: múltiplas etapas, propenso a erros
CalculosMal calc = new CalculosMal();
calc.n1 = 10;           // Pode esquecer de definir
calc.n2 = 5;            // Ordem pode ser confusa
calc.Calcular();        // Pode esquecer de chamar
double res = calc.resultado;  // Pode usar antes de calcular!
```

#### ✅ **COM Construtor (Boa Prática)**
```csharp
public class Calculos
{
    private double n1;
    private double n2;
    private double resultado;
    
    public Calculos(double n1, double n2, string op)
    {
        this.n1 = n1;
        this.n2 = n2;
        this.op = op;
        Calcular();  // Garante execução
    }
    
    public double Resultado { get => resultado; }
}

// Uso: uma linha, sem erros
Calculos calc = new Calculos(10, 5, "+");
double res = calc.Resultado;  // Sempre válido!
```

### **Palavra-chave `this`**

Em todos os construtores do projeto, usamos `this`:

```csharp
public Calculos(double n1, double n2, string op)
{
    this.n1 = n1;   // this.n1 = atributo da classe
                     // n1 (direita) = parâmetro do construtor
    this.n2 = n2;
    this.op = op;
}
```

**`this` serve para:**
- Diferenciar **atributos da classe** (`this.n1`) de **parâmetros** (`n1`)
- Deixar claro que estamos acessando membros do objeto atual
- Evitar conflitos de nomes

### **Vantagens dos Construtores neste Projeto:**
✅ **Garantia de Inicialização**: Objeto sempre criado em estado válido  
✅ **Simplicidade**: Uma linha cria e processa o objeto  
✅ **Segurança**: Impossível usar objeto sem inicializar  
✅ **Encadeamento**: Construtores chamam métodos que preparam o objeto  
✅ **Imutabilidade**: Atributos private + construtor = dados protegidos  

---

## 🚀 Tecnologias Utilizadas

- **.NET 8** - Framework de desenvolvimento
- **C#** - Linguagem de programação
- **Windows Forms** - Interface gráfica
- **Visual Studio 2022** - IDE

---

## 📦 Como Executar

1. Clone o repositório:
```bash
git clone https://github.com/Reverdan/DS23_Noite_POOC-_1sem26.git
```

2. Abra o projeto no Visual Studio 2022

3. Compile e execute (F5)

---

## 📚 Conceitos de POO Aplicados

| Conceito | Aplicação no Projeto |
|----------|---------------------|
| **Responsabilidade Única** | Cada classe tem uma única responsabilidade bem definida |
| **Encapsulamento** | Atributos private com propriedades public somente leitura |
| **Construtores** | Inicialização automática e execução de lógica de inicialização |
| **Separação de Camadas** | Apresentação (View) separada do Modelo (Model) e Controle (Controller) |

---

## 👨‍💻 Autor

Desenvolvido como material didático para a disciplina de **Programação Orientada a Objetos em C#** - **DS23 Noite - 1º Semestre 2026**

---

## 📄 Licença

Este projeto é de uso educacional.
