# 🧮 Numero Primo - Projeto Windows Forms (.NET 10)

## 📋 Descrição Detalhada do Projeto

O projeto **NumeroPrimo** é uma aplicação Windows Forms desenvolvida em **C# .NET 10**, cujo objetivo é verificar se um número informado pelo usuário é primo. O projeto foi estruturado para demonstrar, de forma didática e prática, os principais **princípios de orientação a objetos (POO)** e a aplicação de **padrões de projeto** além dos conceitos já detalhados em Calculadora.md (como responsabilidade única, encapsulamento e construtores).

---

## 🏗️ Arquitetura e Organização

A solução está dividida em camadas e classes especializadas:

```
NumeroPrimo/
├── Form1.cs              # Interface gráfica (View)
├── Form1.Designer.cs     # Configuração dos componentes visuais
├── modelo/
│   ├── absPropriedades.cs # Classe base abstrata para propriedades comuns
│   ├── Controle.cs        # Controlador do fluxo de validação e verificação
│   ├── Validacao.cs       # Validação e conversão de entrada
│   └── Primo.cs           # Lógica de verificação de número primo
```

---

## ⚙️ Princípios de Orientação a Objetos Aplicados

### 1. **Herança e Abstração**
A herança é um dos pilares da POO e permite criar uma hierarquia de classes, promovendo reuso e especialização. No projeto, a classe abstrata `absPropriedades` define propriedades comuns (`Numero`, `Num`, `Mensagem`) e serve como base para todas as classes de domínio. Isso garante que todas as classes compartilhem uma interface comum e reduz duplicidade de código.

**Exemplo:**
```csharp
public abstract class absPropriedades {
	public string Mensagem { get; set; }
	public string Numero { get; set; }
	public int Num { get; set; }
}

public class Controle : absPropriedades { ... }
public class Validacao : absPropriedades { ... }
public class Primo : absPropriedades { ... }
```

**Motivação:**
- Facilita manutenção: mudanças em propriedades comuns são feitas em um só lugar.
- Permite extensão: novas operações podem herdar de `absPropriedades`.

**Comparação:**
- Sem herança: cada classe teria que declarar e manter suas próprias propriedades, aumentando o risco de inconsistências.

### 2. **Polimorfismo**
Polimorfismo permite tratar objetos de diferentes classes derivadas como se fossem do tipo da classe base. No projeto, isso é útil para futuras extensões, onde métodos podem receber parâmetros do tipo `absPropriedades` e operar sobre qualquer classe derivada.

**Exemplo:**
```csharp
void ExibirMensagem(absPropriedades obj) {
	Console.WriteLine(obj.Mensagem);
}
```

**Motivação:**
- Permite código mais genérico e flexível.
- Facilita a adição de novas funcionalidades sem alterar código existente.

**Comparação:**
- Sem polimorfismo: cada tipo exigiria métodos e tratamentos separados.

### 3. **Imutabilidade Parcial e Estado Controlado**
O projeto controla o estado dos objetos por meio de métodos privados e propriedades públicas apenas para leitura. Isso impede alterações indevidas e garante que o objeto só mude de estado de forma controlada.

**Exemplo:**
```csharp
public class Controle : absPropriedades {
	public Controle(string numero) {
		this.Numero = numero;
		this.Executar();
	}
	private void Executar() { ... }
}
```

**Motivação:**
- Garante previsibilidade e segurança.
- Evita bugs causados por alterações externas inesperadas.

**Comparação:**
- Sem controle de estado: qualquer parte do código poderia modificar propriedades a qualquer momento, tornando o sistema instável.

### 4. **Baixo Acoplamento e Alta Coesão**
Baixo acoplamento significa que as classes dependem minimamente umas das outras. Alta coesão significa que cada classe tem uma única responsabilidade bem definida.

**Exemplo:**
- `Validacao` só valida dados, `Primo` só verifica primalidade, `Controle` só orquestra o fluxo.

**Motivação:**
- Facilita manutenção, testes e evolução do sistema.
- Mudanças em uma classe dificilmente afetam outras.

**Comparação:**
- Alto acoplamento: mudanças em uma classe exigiriam alterações em várias outras.
- Baixa coesão: classes fariam muitas coisas diferentes, dificultando entendimento e manutenção.

---

## 🧩 Padrões de Projeto Utilizados

### **Padrão Template Method (Método Template)**
O Template Method define o esqueleto de um algoritmo em uma operação, delegando algumas etapas para subclasses. No projeto, o construtor de `Controle` define o fluxo principal (validar → verificar primo), enquanto as etapas específicas são implementadas em métodos privados das classes envolvidas.

**Exemplo:**
```csharp
public Controle(string numero) {
	this.Numero = numero;
	this.Executar(); // Template Method
}
private void Executar() {
	Validacao validacao = new Validacao(this.Numero);
	if (validacao.Mensagem == "") {
		Primo primo = new Primo(validacao.Num);
		this.Mensagem = primo.Mensagem;
	} else {
		this.Mensagem = validacao.Mensagem;
	}
}
```

**Motivação:**
- Garante um fluxo fixo e padronizado.
- Permite especialização de etapas sem alterar o fluxo principal.

**Comparação:**
- Sem Template Method: cada classe teria que implementar todo o fluxo, aumentando duplicidade e risco de erros.

### **Padrão Camada de Apresentação e Domínio**
O projeto adota o padrão de camadas, separando claramente a interface gráfica (Form1) da lógica de negócio (modelo). Isso facilita manutenção, testes e evolução da aplicação.

**Exemplo:**
- `Form1` apenas coleta dados e exibe resultados, sem lógica de validação ou cálculo.
- As classes de modelo (`Controle`, `Validacao`, `Primo`) concentram toda a lógica.

**Motivação:**
- Permite trocar a interface (ex: para web) sem alterar a lógica.
- Facilita testes automatizados da lógica de negócio.

**Comparação:**
- Sem camadas: a interface teria lógica de negócio misturada, dificultando manutenção e testes.

### **Padrão Facade (Fachada)**
O padrão Facade fornece uma interface simplificada para um subsistema complexo. No projeto, a classe `Controle` atua como fachada entre a interface e as operações internas.

**Exemplo:**
```csharp
// Interface gráfica
Controle controle = new Controle(txbNumero.Text);
lblResposta.Text = controle.Mensagem;
```
O formulário não precisa conhecer detalhes de validação ou cálculo, apenas usa a fachada.

**Motivação:**
- Reduz acoplamento entre interface e lógica.
- Centraliza o fluxo, facilitando manutenção e evolução.

**Comparação:**
- Sem Facade: a interface teria que instanciar e coordenar várias classes diretamente, aumentando a complexidade.

---

## 🔄 Fluxo de Execução

1. **Entrada do Usuário**: O usuário digita um número no campo de texto e clica em "Verificar Primo".
2. **Controle**: O evento de clique instancia a classe `Controle`, que inicia o fluxo de validação e verificação.
3. **Validação**: A classe `Validacao` tenta converter a entrada para inteiro e define mensagens de erro se necessário.
4. **Verificação de Primo**: Se a validação for bem-sucedida, a classe `Primo` executa o algoritmo de verificação e define a mensagem de resposta.
5. **Exibição**: O resultado é retornado ao formulário e exibido ao usuário.

---

## 🧠 Algoritmo de Verificação de Primo

- O algoritmo implementado na classe `Primo` verifica se o número é divisível por algum valor entre 2 e metade do número informado, otimizando o processo para evitar verificações desnecessárias.
- O laço é otimizado para pular números pares após o 2, tornando a verificação mais eficiente.

---

## 🛠️ Extensibilidade e Boas Práticas

- O uso de uma classe base abstrata permite fácil extensão para outros tipos de validação ou operações matemáticas.
- O padrão de fluxo automático via construtores garante que objetos estejam sempre em estado válido após a criação.
- O projeto pode ser facilmente adaptado para outros algoritmos numéricos apenas criando novas classes filhas de `absPropriedades`.

---

## 🚀 Tecnologias Utilizadas
- **.NET 10**
- **C#**
- **Windows Forms**

---

## 📚 Resumo dos Princípios e Padrões (não abordados em Calculadora.md)
| Princípio/Padrão         | Aplicação no Projeto NumeroPrimo |
|--------------------------|----------------------------------|
| **Herança/Abstração**    | Classe base abstrata para propriedades |
| **Polimorfismo**         | Possível manipulação por referência base |
| **Template Method**      | Fluxo fixo de execução no construtor |
| **Baixo Acoplamento**    | Classes independentes e coesas |
| **Camada de Domínio**    | Separação clara entre interface e lógica |
| **Facade**               | Classe Controle simplifica o uso da lógica |

---

## 👨‍💻 Autor
Desenvolvido como material didático para a disciplina de **Programação Orientada a Objetos em C#** - **DS23 Manhã - 1º Semestre 2026**
