# 🧬 PrimoHeranca - Projeto Windows Forms (.NET 10)

## 📋 Descrição Detalhada do Projeto

O projeto **PrimoHeranca** é uma evolução do projeto de verificação de números primos, desenvolvido em **C# .NET 10** com Windows Forms, focado em demonstrar de forma prática e aprofundada os principais **princípios de orientação a objetos (POO)** e **padrões de projeto**. Aqui, o uso de **herança**, **sobrescrita (override)**, **construtores protegidos**, **polimorfismo** e **Template Method** é central, além da aplicação dos padrões **Facade** e de **camadas**.

---

## 🏗️ Arquitetura e Organização

```
PrimoHeranca/
├── Form1.cs              # Interface gráfica (View)
├── Form1.Designer.cs     # Configuração dos componentes visuais
├── modelo/
│   ├── absPropriedades.cs # Classe base abstrata com construtores protegidos e método virtual
│   ├── Controle.cs        # Fachada e orquestrador do fluxo
│   ├── Validacao.cs       # Validação e conversão de entrada
│   └── Primo.cs           # Lógica de verificação de número primo
```

---

## ⚙️ Princípios de Orientação a Objetos Aplicados

### 1. **Herança e Abstração Avançada**
A classe abstrata `absPropriedades` define propriedades e construtores protegidos, permitindo que apenas classes derivadas possam inicializá-la. O método `Executar()` é virtual, permitindo especialização nas subclasses.

**Exemplo:**
```csharp
public abstract class absPropriedades {
	protected absPropriedades(int num) { ... }
	protected absPropriedades(string numero) { ... }
	protected virtual void Executar() { }
}
```
**Motivação:**
- Permite criar um esqueleto de comportamento e forçar subclasses a especializarem etapas.
- Garante que apenas herdeiros possam instanciar e controlar o fluxo.

### 2. **Sobrescrita (Override) e Template Method**
As subclasses (`Controle`, `Validacao`, `Primo`) sobrescrevem o método `Executar()` para implementar etapas específicas do fluxo, seguindo o padrão Template Method.

**Exemplo:**
```csharp
public class Controle : absPropriedades {
	public Controle(string numero) : base(numero) { }
	protected override void Executar() {
		// Fluxo de validação e verificação
	}
}
```
**Motivação:**
- Permite que cada classe defina seu comportamento específico, mantendo o fluxo principal padronizado.

### 3. **Construtores Protegidos e Encadeamento**
Os construtores de `absPropriedades` são protegidos, forçando o uso apenas por herança. O construtor já chama o método `Executar()`, garantindo que o objeto esteja pronto para uso imediatamente após a criação.

**Exemplo:**
```csharp
protected absPropriedades(string numero) {
	this.numero = numero;
	this.Executar();
}
```
**Motivação:**
- Garante inicialização automática e correta do objeto.
- Evita uso incorreto por código externo.

### 4. **Polimorfismo**
Permite tratar objetos das subclasses como do tipo da classe base, facilitando extensões e generalizações futuras.

**Exemplo:**
```csharp
void Exibir(absPropriedades obj) {
	Console.WriteLine(obj.Mensagem);
}
```

### 5. **Baixo Acoplamento e Alta Coesão**
Cada classe tem uma responsabilidade única e interage apenas pelo necessário, facilitando manutenção, testes e evolução.

---

## 🧩 Padrões de Projeto Utilizados

### **Template Method (Método Template)**
O método `Executar()` é definido na classe base e sobrescrito nas subclasses, padronizando o fluxo e permitindo especialização.

**Exemplo:**
```csharp
protected override void Executar() {
	// Validação ou verificação de primo
}
```

### **Facade (Fachada)**
A classe `Controle` atua como fachada, centralizando o fluxo e simplificando a interface entre a camada de apresentação e as operações internas.

**Exemplo:**
```csharp
Controle controle = new Controle(txbNumero.Text);
lblResultado.Text = controle.Mensagem;
```

### **Padrão de Camadas**
Separação clara entre interface (Form1) e lógica de negócio (modelo), permitindo evolução independente e facilitando testes.

---

## 🔄 Fluxo de Execução Detalhado

1. **Entrada do Usuário**: O usuário digita um número e clica em "Verificar".
2. **Fachada/Controle**: O formulário instancia `Controle`, que herda de `absPropriedades` e executa o fluxo.
3. **Validação**: `Controle` instancia `Validacao`, que converte e valida a entrada.
4. **Verificação de Primo**: Se válido, instancia `Primo`, que executa o algoritmo de primalidade.
5. **Exibição**: O resultado é retornado ao formulário e exibido ao usuário.

---

## 🧠 Algoritmo de Verificação de Primo

O algoritmo em `Primo` verifica divisibilidade de 2 até metade do número, otimizando para pular pares após 2. O resultado é atribuído à propriedade `Mensagem`.

---

## 🛠️ Extensibilidade e Boas Práticas

- Novas operações podem ser criadas herdando de `absPropriedades` e sobrescrevendo `Executar()`.
- O fluxo automático via construtores e Template Method garante objetos sempre prontos e padronizados.
- O uso de protected e override reforça encapsulamento e especialização.

---

## 🚀 Tecnologias Utilizadas
- **.NET 10**
- **C#**
- **Windows Forms**

---

## 📚 Resumo dos Princípios e Padrões
| Princípio/Padrão         | Aplicação no Projeto PrimoHeranca |
|--------------------------|-----------------------------------|
| **Herança/Abstração**    | Classe base abstrata, construtores protegidos |
| **Override/Template**    | Método Executar sobrescrito nas subclasses |
| **Polimorfismo**         | Manipulação genérica por referência base |
| **Facade**               | Classe Controle centraliza o fluxo |
| **Camadas**              | Separação entre interface e lógica |
| **Baixo Acoplamento**    | Classes independentes e coesas |

---

## 👨‍💻 Autor
Desenvolvido como material didático para a disciplina de **Programação Orientada a Objetos em C#** - **DS23 Manhã - 1º Semestre 2026**
