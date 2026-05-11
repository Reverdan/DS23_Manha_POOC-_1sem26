# 📱 Calculadora - Aplicação Windows Forms (.NET 8)

## 📝 Descrição Detalhada do Projeto

O projeto **Calculadora** é uma aplicação desktop desenvolvida em **C# .NET 8** utilizando **Windows Forms**. Ele serve como base didática para a introdução dos pilares da **Programação Orientada a Objetos (POO)**, focando na separação de responsabilidades, proteção de dados e automação de processos internos.

A calculadora realiza as quatro operações básicas (soma, subtração, multiplicação e divisão), incluindo tratamento de erros para entradas inválidas e prevenção de divisão por zero.

---

## 🏗️ Arquitetura e Organização

O projeto adota uma estrutura organizada em camadas, separando a interface do usuário da lógica de processamento:

```
Calculadora/
├── apresentacao/
│   ├── Form1.cs              # Interface gráfica (View)
│   ├── Form1.Designer.cs     # Configuração dos componentes visuais
│   └── Form1.resx            # Recursos do formulário
└── modelo/
    ├── Controle.cs           # Controlador e Orquestrador (Fachada)
    ├── Validacao.cs          # Lógica de validação e conversão
    └── Calculos.cs           # Operações matemáticas puras
```

---

## ⚙️ Princípios de Orientação a Objetos Aplicados

### 1. **Responsabilidade Única (SRP - Single Responsibility Principle)**
Este é o conceito mais forte do projeto. Cada classe possui uma única função clara no sistema, o que facilita a manutenção e evita que o código se torne um "emaranhado" difícil de depurar.

- **`Form1`**: Apenas coleta os dados da tela e exibe o resultado final. Não sabe como calcular nem como validar.
- **`Controle`**: Atua como o "cérebro" do fluxo. Coordena quando a validação deve ocorrer e quando o cálculo deve ser chamado.
- **`Validacao`**: Especializada em transformar strings em números e verificar se os dados são operáveis (ex: impedir divisão por zero).
- **`Calculos`**: Contém apenas a matemática pura. Recebe números prontos e devolve o resultado.

### 2. **Encapsulamento**
O encapsulamento protege a integridade dos dados, impedindo que partes externas do programa modifiquem atributos de forma indevida. No projeto, isso é feito através de:

- **Atributos Privados**: Variáveis como `n1`, `n2` e `resultado` são `private`.
- **Propriedades Somente-Leitura**: O acesso aos resultados é feito via propriedades públicas com apenas o método `get`, garantindo que o valor não seja alterado externamente.

**Exemplo:**
```csharp
private Double resultado; // Protegido internamente
public Double Resultado   // Exposto externamente apenas para leitura
{
    get { return resultado; }
}
```

### 3. **Métodos Construtores e Automação**
Os construtores são usados para garantir que um objeto nasça com todos os dados necessários e já inicie seu processamento automaticamente.

- Quando o `Controle` é instanciado, seu construtor já chama o método `Validar()`.
- Quando o `Calculos` é instanciado, seu construtor já executa o método `Calcular()`.

Isso garante que, ao criar o objeto, o resultado já esteja disponível imediatamente, sem a necessidade de chamar múltiplos métodos manualmente na interface.

---

## 🧩 Padrões de Projeto Utilizados

### **Padrão Facade (Fachada)**
A classe `Controle` simplifica o uso do sistema para a interface gráfica. O formulário não precisa conhecer as classes `Validacao` ou `Calculos`; ele interage apenas com a "fachada" `Controle`.

### **Padrão de Camadas (Model-View-Controller)**
Embora simplificado, o projeto separa a **View** (`Form1`) do **Model** (`Validacao`, `Calculos`) através de um **Controller** (`Controle`), seguindo as melhores práticas de arquitetura de software.

---

## 🚀 Tecnologias Utilizadas

- **C#** - Linguagem de programação robusta e moderna.
- **.NET 8** - Plataforma de execução multiplataforma da Microsoft.
- **Windows Forms** - Tecnologia para criação de interfaces desktop nativas.

---

## 👨‍💻 Autor

Desenvolvido como material didático para a disciplina de **Programação Orientada a Objetos em C#** - **DS23 Manhã - 1º Semestre 2026**
