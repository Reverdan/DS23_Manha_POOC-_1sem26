# 🌡️ TemperaturaFC - Projeto Windows Forms (.NET 10)

## 📋 Descrição Detalhada do Projeto

O projeto **TemperaturaFC** converte temperaturas entre Fahrenheit e Celsius, utilizando **C# .NET 10** e Windows Forms. O foco está na aplicação avançada de **polimorfismo de métodos e objetos**, princípios **SOLID** e padrões de projeto como **Template Method**, **Facade** e **camadas**.

---

## 🏗️ Arquitetura e Organização

```
TemperaturaFC/
├── Form1.cs              # Interface gráfica (View)
├── Form1.Designer.cs     # Configuração dos componentes visuais
├── modelo/
│   ├── absPropriedades.cs # Classe base abstrata, métodos abstratos e construtores sobrecarregados
│   ├── Controle.cs        # Fachada e orquestrador do fluxo
│   ├── Validacao.cs       # Validação e conversão de entrada
│   ├── Conversao.cs       # Lógica de conversão de temperatura
│   └── intMetodos.cs      # Interface para métodos obrigatórios
```

---

## ⚙️ Polimorfismo de Métodos e Objetos

### 1. **Polimorfismo de Métodos (Override)**
O método abstrato `Executar()` é sobrescrito (`override`) em cada subclasse, permitindo que cada uma implemente seu comportamento específico.

**Exemplo:**
```csharp
public abstract class absPropriedades : intMetodos {
	public abstract void Executar();
}
public class Validacao : absPropriedades {
	public override void Executar() { ... }
}
public class Conversao : absPropriedades {
	public override void Executar() { ... }
}
```

### 2. **Polimorfismo de Objetos**
O projeto utiliza referências do tipo da classe base (`absPropriedades`) para manipular objetos de diferentes subclasses, permitindo flexibilidade e extensibilidade.

**Exemplo:**
```csharp
absPropriedades validacao = new Validacao(temp);
absPropriedades conversao = new Conversao(tipo, validacao.Temperatura);
```
Isso permite que métodos e fluxos operem sobre diferentes tipos de objetos de forma genérica.

---

## 🧩 Padrões de Projeto Utilizados

### **Template Method**
O método `Executar()` define o esqueleto do algoritmo, sendo especializado nas subclasses. O construtor das classes base já chama `Executar()`, garantindo inicialização automática.

### **Facade (Fachada)**
A classe `Controle` centraliza o fluxo, simplificando a interface entre a camada de apresentação e as operações internas.

### **Padrão de Camadas**
Separação clara entre interface (Form1) e lógica de negócio (modelo), facilitando manutenção e testes.

---

## 🏛️ Princípios SOLID Aplicados

### **S - Single Responsibility Principle (SRP)**
Cada classe tem uma responsabilidade única: `Validacao` valida, `Conversao` converte, `Controle` orquestra.

### **O - Open/Closed Principle (OCP)**
As classes são abertas para extensão (novas conversões, validações), mas fechadas para modificação, graças ao uso de herança e métodos abstratos.

### **L - Liskov Substitution Principle (LSP)**
Qualquer subclasse de `absPropriedades` pode ser usada onde se espera um objeto da classe base, sem alterar o comportamento esperado.

### **I - Interface Segregation Principle (ISP)**
A interface `intMetodos` garante que apenas métodos relevantes sejam obrigatórios nas classes que a implementam.

### **D - Dependency Inversion Principle (DIP)**
O código depende de abstrações (`absPropriedades`, `intMetodos`), não de implementações concretas, facilitando testes e extensões.

---

## 🔄 Fluxo de Execução Detalhado

1. **Entrada do Usuário**: O usuário informa a temperatura e seleciona o tipo de conversão.
2. **Fachada/Controle**: O formulário instancia `Controle`, que herda de `absPropriedades` e executa o fluxo.
3. **Validação**: `Controle` instancia `Validacao` (via referência polimórfica), que valida e converte a entrada.
4. **Conversão**: Se válido, instancia `Conversao` (também via referência polimórfica), que executa a conversão.
5. **Exibição**: O resultado é retornado ao formulário e exibido ao usuário.

---

## 🛠️ Extensibilidade e Boas Práticas

- Novas conversões podem ser implementadas criando novas subclasses de `absPropriedades`.
- O uso de polimorfismo permite adicionar funcionalidades sem alterar o fluxo principal.
- O padrão de camadas e a aplicação de SOLID facilitam manutenção, testes e evolução do sistema.

---

## 🚀 Tecnologias Utilizadas
- **.NET 10**
- **C#**
- **Windows Forms**

---

## 📚 Resumo dos Princípios e Padrões
| Tema/Padrão              | Aplicação no Projeto TemperaturaFC |
|--------------------------|------------------------------------|
| **Polimorfismo Métodos** | Executar() sobrescrito nas subclasses |
| **Polimorfismo Objetos** | Referências da base para objetos diversos |
| **Template Method**      | Fluxo padronizado, especialização por override |
| **Facade**               | Classe Controle centraliza o fluxo |
| **Camadas**              | Separação entre interface e lógica |
| **SRP**                  | Cada classe tem uma responsabilidade |
| **OCP**                  | Fácil extensão sem modificar código existente |
| **LSP**                  | Substituição segura de subclasses |
| **ISP**                  | Interface define métodos essenciais |
| **DIP**                  | Dependência de abstrações |

---

## 👨‍💻 Autor
Desenvolvido como material didático para a disciplina de **Programação Orientada a Objetos em C#** - **DS23 Manhã - 1º Semestre 2026**
