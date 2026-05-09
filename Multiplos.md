# 🧩 Multiplos - Projeto Windows Forms com Múltiplos Formulários

## 📋 Descrição

O projeto **Multiplos** é uma aplicação Windows Forms em **C#** que reúne **três funcionalidades diferentes em uma única aplicação**:

- verificação de número primo;
- cálculo de fatorial;
- classificação de triângulos.

O ponto central deste projeto não é repetir os conceitos já detalhados nos outros documentos, como separação em camadas, herança, fachada, validação e polimorfismo. O diferencial aqui é mostrar **como organizar uma aplicação com vários formulários** e como o formulário principal coordena a abertura de telas especializadas.

---

## 🏗️ Estrutura do Projeto

```text
Multiplos/
├── Program.cs
├── apresentacao/
│   ├── Form1.cs                 # formulário principal com menu
│   ├── frmPrimo.cs              # tela da operação de primo
│   ├── frmFatorial.cs           # tela da operação de fatorial
│   └── frmTriangulos.cs         # tela da operação de triângulos
└── Modelo/
    ├── absPropriedades.cs       # base abstrata comum
    ├── IntMetodos.cs            # contrato com Executar()
    ├── Controle.cs              # fachada da camada de negócio
    ├── Validacao.cs             # valida números e lados
    ├── Primo.cs                 # regra para número primo
    ├── Fatorial.cs              # regra do fatorial
    └── Triangulo.cs             # classificação do triângulo
```

---

## 🎯 O que este projeto acrescenta em relação aos anteriores

Nos projetos anteriores, cada aplicação tinha **uma tela principal dedicada a uma única tarefa**. Em `Multiplos`, a aplicação passa a atuar como um **hub**:

- `Form1` funciona como tela de navegação;
- cada operação foi isolada em um formulário próprio;
- o usuário entra pela janela principal e escolhe qual ferramenta deseja usar;
- a camada de modelo continua separada, mas agora é reutilizada por mais de uma tela dentro da mesma aplicação.

Isso ensina um passo importante em Windows Forms: **nem toda aplicação precisa resolver tudo em uma única janela**. Quando a interface cresce, faz mais sentido dividir responsabilidades visuais em formulários menores e mais específicos.

---

## 🖥️ Papel de cada formulário

### `Form1` como formulário principal

`Form1` é a janela aberta em `Program.cs` com `Application.Run(new Form1())`. Isso faz dela a **janela principal do ciclo de vida da aplicação**.

Sua responsabilidade não é calcular ou validar dados. Ela apenas:

- exibe o menu principal;
- reage aos cliques do usuário;
- instancia a janela correta;
- transfere o foco para o formulário especializado.

Na prática, `Form1` funciona como uma tela de entrada da aplicação, concentrando a navegação.

### `frmPrimo`

É a tela dedicada apenas à verificação de primalidade. Ela coleta o valor digitado, cria `Controle` e chama `VerificarPrimo(...)`.

### `frmFatorial`

É a tela dedicada apenas ao cálculo do fatorial. Ela coleta a entrada, instancia `Controle` e chama `CalcularFatorial(...)`.

### `frmTriangulos`

É a tela voltada para um caso com **três entradas**. O formulário recebe três lados, delega ao `Controle` e chama `VerificarTriangulo(...)`.

Esse terceiro caso é importante porque mostra que a aplicação não está presa a uma única assinatura de entrada. Cada formulário pode ter sua própria interface e ainda assim conversar com a mesma camada de orquestração.

---

## 🔄 Fluxo geral da aplicação

O fluxo do projeto pode ser entendido em dois níveis.

### 1. Fluxo entre formulários

1. A aplicação inicia em `Form1`.
2. O usuário escolhe uma opção do menu.
3. `Form1` cria o formulário correspondente.
4. A nova janela é exibida ao usuário.
5. Após o fechamento da janela secundária, o controle volta para `Form1`.

### 2. Fluxo interno de cada operação

1. O usuário preenche os campos do formulário específico.
2. O clique no botão cria um objeto `Controle`.
3. `Controle` chama a validação adequada.
4. Se a entrada for válida, `Controle` instancia a classe de regra correspondente.
5. A mensagem final é devolvida ao formulário.
6. O formulário exibe o resultado em `lblResposta`.

O ganho didático é claro: o projeto separa **navegação entre telas** de **execução da regra de negócio**.

---

## 🧭 Multi-formulários em Windows Forms

Em Windows Forms, uma aplicação pode ter:

- um formulário principal;
- formulários auxiliares;
- formulários abertos de forma modal ou não modal.

O projeto `Multiplos` é um exemplo direto desse modelo, porque existe uma janela principal e três janelas secundárias.

### Por que usar vários formulários?

Separar a interface em várias janelas traz algumas vantagens:

- evita concentrar muitos campos e botões em uma única tela;
- melhora a organização visual da aplicação;
- permite que cada formulário tenha foco em uma única tarefa;
- facilita manutenção da interface;
- reduz a chance de misturar eventos de funcionalidades diferentes.

Em vez de um formulário grande com controles para primo, fatorial e triângulos ao mesmo tempo, o projeto distribui essas tarefas em telas menores.

---

## 🔐 Modal e não modal em C# Windows Forms

Este é o principal conceito novo que o projeto evidencia na camada de apresentação.

### O que é uma janela modal

Uma janela **modal** bloqueia a interação com as outras janelas da aplicação enquanto estiver aberta. O usuário precisa concluir ou fechar essa janela antes de voltar à anterior.

Em Windows Forms, isso normalmente é feito com:

```csharp
frm.ShowDialog();
```

Quando `ShowDialog()` é usado:

- a janela chamada ganha foco exclusivo;
- a janela anterior fica inacessível enquanto a nova estiver aberta;
- o código só continua depois que a janela modal é fechada.

### O que é uma janela não modal

Uma janela **não modal** permite que o usuário continue interagindo com a janela principal e com outras janelas ao mesmo tempo.

Em Windows Forms, isso normalmente é feito com:

```csharp
frm.Show();
```

Quando `Show()` é usado:

- a nova janela é aberta sem bloquear a anterior;
- o usuário pode alternar livremente entre as telas;
- o fluxo do método chamador não fica esperando o fechamento da janela.

---

## ✅ Como o projeto usa formulários modais

No projeto `Multiplos`, os três formulários secundários são abertos com `ShowDialog()`. Isso significa que a navegação foi implementada no modo **modal**.

### Abertura de `frmPrimo`

```csharp
private void tsmPrimo_Click(object sender, EventArgs e)
{
    frmPrimo frmP = new frmPrimo();
    this.Visible = false;
    frmP.ShowDialog();
    this.Visible = true;
}
```

Nesse caso, além do uso de `ShowDialog()`, o formulário principal é escondido com `this.Visible = false` antes da abertura e exibido novamente depois do fechamento.

Esse comportamento cria um efeito de navegação mais forte:

- o menu principal desaparece temporariamente;
- o usuário fica concentrado apenas na tela de número primo;
- ao fechar `frmPrimo`, a janela principal reaparece.

### Abertura de `frmTriangulos` e `frmFatorial`

```csharp
frmTriangulos frmT = new frmTriangulos();
frmT.ShowDialog();

frmFatorial frmF = new frmFatorial();
frmF.ShowDialog();
```

Aqui também há uso modal, mas sem ocultar `Form1`. Na prática:

- `Form1` continua existindo ao fundo;
- o usuário não consegue interagir com ele enquanto a janela modal estiver aberta;
- após o fechamento, o foco volta para a janela principal.

---

## ⚖️ Diferença prática entre modal e não modal

### Modal (`ShowDialog`)

- Obriga o usuário a concluir uma etapa antes de voltar.
- É útil para operações pequenas e focadas.
- Evita que duas telas da mesma aplicação sejam usadas ao mesmo tempo.
- Simplifica o controle de fluxo da navegação.

### Não modal (`Show`)

- Permite várias janelas abertas simultaneamente.
- É útil quando o usuário precisa comparar informações entre telas.
- Exige mais cuidado com foco, estado da interface e duplicidade de janelas.
- Pode deixar a aplicação mais flexível, mas também mais complexa de controlar.

---

## 🧠 Por que o uso modal faz sentido neste projeto

Para este projeto didático, `ShowDialog()` é uma escolha coerente porque cada tela representa uma **atividade isolada**:

- calcular um fatorial;
- verificar um primo;
- classificar um triângulo.

Nenhuma dessas tarefas precisa ficar aberta ao mesmo tempo que outra para o exercício funcionar. Por isso, abrir as telas de forma modal reduz a complexidade da navegação e torna o comportamento mais previsível para quem está aprendendo.

Se a escolha fosse por janelas não modais, o usuário poderia abrir várias instâncias de `frmPrimo`, `frmFatorial` e `frmTriangulos` ao mesmo tempo. Isso não é necessariamente errado, mas exigiria discutir gerenciamento de múltiplas janelas, sincronização visual e prevenção de duplicidade, o que desviaria o foco principal do projeto.

---

## 🧪 Reaproveitamento da camada de modelo

Outro aspecto importante é que, embora existam várias telas, a lógica de negócio permanece centralizada.

`Controle` funciona como ponto único de orquestração e oferece três operações públicas:

- `CalcularFatorial(string numero1)`;
- `VerificarPrimo(string numero1)`;
- `VerificarTriangulo(string numero1, string numero2, string numero3)`.

Isso mostra que a aplicação cresce em interface sem precisar duplicar a lógica em cada formulário. Cada tela apenas chama o método apropriado.

Esse reuso mantém a aplicação organizada:

- a apresentação decide **qual operação** o usuário quer;
- `Controle` decide **qual fluxo interno** deve executar;
- as classes `Fatorial`, `Primo` e `Triangulo` executam a regra específica.

---

## 🧵 Diferença entre navegação e processamento

Um erro comum em aplicações com vários formulários é deixar a janela principal acumular lógica demais. O projeto evita isso razoavelmente bem.

`Form1` não valida números, não calcula fatorial e não classifica triângulos. Ela apenas navega. Já os formulários secundários fazem a ponte entre a entrada do usuário e o `Controle`.

Essa distinção é importante:

- **navegação** pertence à camada visual;
- **processamento** pertence à camada de modelo.

Quando o aluno entende essa diferença, fica mais fácil evoluir o sistema depois, por exemplo adicionando um quarto formulário sem reescrever a lógica existente.

---

## 📌 Síntese do aprendizado específico deste projeto

O projeto `Multiplos` é relevante porque introduz, de forma prática, quatro ideias de interface que não estavam no centro dos outros exemplos:

1. uma única aplicação pode conter várias ferramentas independentes;
2. um formulário principal pode servir apenas para navegação;
3. formulários secundários podem ser especializados por tarefa;
4. a escolha entre `ShowDialog()` e `Show()` muda diretamente a experiência de uso.

Em resumo, o foco didático aqui é menos “como calcular” e mais “como organizar a aplicação quando existem várias telas”.

---

## 👨‍💻 Autor

Desenvolvido como material didático para a disciplina de **Programação Orientada a Objetos em C#** - **DS23 Manhã - 1º Semestre 2026**