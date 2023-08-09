<!--
❗ ➤ References used in this Repository:
🔗 • https://github.com/piyushsuthar/github-readme-quotes
🔗 • https://github.com/kyechan99/capsule-render
🔗 • https://github.com/DenverCoder1/custom-icon-badges
🔗 • https://profilepicturemaker.com
🔗 • https://shields.io
🔗 • https://emoji.gg
🔗 • https://getemoji.com
-->

<div align="left">
  <img src="https://img.shields.io/github/license/juletopi/Linguagem_de_Programacao_Visual" alt="MITLiscence-badge">
</div>

<br>

<!-- PRESENTATION -->

<div align="center">
  <a href="https://github.com/juletopi/Linguagem_de_Programacao_Visual/blob/main/Assets/Images/WindowsForms-pic.png">
    <img src="https://user-images.githubusercontent.com/76459155/221386519-5f7aa521-6c02-4adb-a1ed-9c2e79e1454d.png" alt="VisualProgramming-pic" width="116px" title="Repositório de Linguagem de Programação Visual">
  </a>
  <h2 align="center">Linguagem de Programação Visual 📟</h2>
</div>

<div align="center">
 
  • Este é um repositório com os conteúdos de Linguagem de Programação Visual, \
  ministradas pelo professor [**Reinaldo Lima**](https://www.linkedin.com/in/reinaldo-lima-pereira-7b726856/), utilizando o **Visual Studio**, \
  a linguagem **CSharp** e a estrutura de interface do **Windows Forms** \
  como ferramentas de aprendizado.
 
</div>

<div align="center">
  <a href="https://visualstudio.microsoft.com/">
    <img src="https://img.shields.io/badge/Made%20with%20IDE:-Visual%20Studio%20-gray.svg?colorA=655BE1&amp;colorB=4F44D6&amp;style=for-the-badge" alt="VisualStudioIDE-badge" style="max-width: 100%;">
  </a>
  <a href="https://dotnet.microsoft.com/en-us/languages/csharp">
    <img src="https://img.shields.io/badge/Made%20with%20language:-CSharp%20-gray.svg?colorA=61c265&amp;colorB=4CAF50&amp;style=for-the-badge" alt="CSharpLanguage-badge" style="max-width: 100%;">
  </a>
</div>
<div align="center">
  <a href="https://learn.microsoft.com/en-us/visualstudio/ide/create-csharp-winform-visual-studio?view=vs-2022">
    <img src="https://img.shields.io/badge/Made%20with%20GUI:-Windows%20Forms-gray.svg?colorA=636363&amp;colorB=343434&amp;style=for-the-badge" alt="WindowsForms-badge" style="max-width: 100%;">
  </a>
</div>

<br>

<div align="center">
  <img width=100% align="center" src="https://capsule-render.vercel.app/api?type=rect&color=636363&height=4&section=header&%20render">
</div>

<br>

<div align="center">
 
  [![Readme Quotes](https://quotes-github-readme.vercel.app/api?type=horizontal&theme=dark&quote=Algumas%20pessoas%20pensam%20que%20design%20significa%20como%20ele%20se%20parece.%20Mas,%20é%20claro,%20se%20você%20cavar%20mais%20fundo,%20na%20verdade%20é%20como%20ele%20funciona.&author=Steve%20Jobs)](https://github.com/piyushsuthar/github-readme-quotes)
</div>

<!-- ABOUT TEACHER -->

<div align="left">

## 👨‍🏫 Professor:

<a href="https://github.com/juletopi/Linguagem_de_Programacao_Visual/blob/main/Assets/Images/ReinaldoLima-pic.png">
  <img align="left" height="135px" width="135px" alt="ReinaldoLima-pic" title="Professor Reinaldo Lima" src="https://user-images.githubusercontent.com/76459155/221387561-1a565eeb-2f3a-4524-bccf-5d0fcd03927f.png">
</a>
 
  **Reinaldo Lima - Professor de Informática | Professor de Curso Técnico, Superior e Pós-Graduação** \
  [**IFRO Campus Ji-Paraná**](https://portal.ifro.edu.br/ji-parana) • <i>Atuando desde Março de 2016</i> \
  Linguagens & Tecnologias: `C#` • `Windows Forms` • `Java` • `Delphi` \
  Contato: **[reinaldo.pereira@ifro.local](mailto:reinaldo.pereira@ifro.local)**
 
</div>

<br>

<div align="center">
  <img width=100% align="center" src="https://capsule-render.vercel.app/api?type=rect&color=636363&height=4&section=header&%20render">
</div>

<!-- LEARNED CONCEPTS -->

## 📚 Conceitos Aprendidos:

### 1. Ferramentas do Windows Forms e Criando uma Calculadora Simples

> <a href="https://github.com/juletopi/Linguagem_de_Programacao_Visual/blob/main/Assets/Images/JanelaCalculadoraSimples-pic.PNG"><img align="center" src="https://user-images.githubusercontent.com/76459155/222274248-4f711c97-50e6-4b9f-a779-18d0ad695f66.PNG" alt="JanelaCalculadoraSimples-pic" title="Calculadora Simples" style="width: 60%;"></a>

> [!NOTE]\
> *Retirado da aula de "[Calculadora_WinForms](https://github.com/juletopi/Linguagem_de_Programacao_Visual/blob/main/Calculadora_WinForms/Form1.cs)"*

<div align="left">
 
  Nesta aula foram aprendidos:
  - Conceitos básicos da ferramenta do Windows Forms
  - Criação labels, text-boxes e buttons com a Caixa de Ferramentas
  - Algoritmos simples de Soma, Subtração, Multiplicação e Divisão
</div>

```c#
private void btnSomar_Click(object sender, EventArgs e)
{
    lblResultadoNum.Text = (float.Parse(txtValor1.Text) + float.Parse(txtValor2.Text) + float.Parse(txtValor3.Text) + float.Parse(txtValor4.Text)).ToString();
}

private void btnSubtrair_Click(object sender, EventArgs e)
{
    lblResultadoNum.Text = (float.Parse(txtValor1.Text) - float.Parse(txtValor2.Text) - float.Parse(txtValor3.Text) - float.Parse(txtValor4.Text)).ToString();
}

private void btnMultiplicar_Click(object sender, EventArgs e)
{
    lblResultadoNum.Text = (float.Parse(txtValor1.Text) * float.Parse(txtValor2.Text) * float.Parse(txtValor3.Text) * float.Parse(txtValor4.Text)).ToString();
}

private void btnDividir_Click(object sender, EventArgs e)
{
    lblResultadoNum.Text = (float.Parse(txtValor1.Text) / float.Parse(txtValor2.Text) / float.Parse(txtValor3.Text) / float.Parse(txtValor4.Text)).ToString();
}

private void btnLimpar_Click(object sender, EventArgs e)
{
    txtValor1.Clear();
    txtValor2.Clear();
    txtValor3.Clear();
    txtValor4.Clear();
    txtValor1.Select();
    lblResultadoNum.Text = "0";
}
```

<div align="left">
  <h6><a href="#linguagem-de-programação-visual-"> Voltar para o início ↺</a></h6>
</div>

<div align="center">
  <img width=100% align="center" src="https://capsule-render.vercel.app/api?type=rect&color=636363&height=4&section=header&%20render">
</div>

### 2. Criando uma Calculadora de Desconto

> <a href="https://github.com/juletopi/Linguagem_de_Programacao_Visual/blob/main/Assets/Images/JanelaCalcDeDesconto-pic.PNG"><img align="center" src="https://user-images.githubusercontent.com/76459155/222634709-7ce89082-bb4b-4cf3-9578-cded6cf2e2ac.PNG" alt="JanelaCalcDeDesconto-pic" title="Calculadora de Desconto" style="width: 50%;"></a>

> [!NOTE]\
> *Retirado da aula de "[Calc_de_Desconto_WinForms](https://github.com/juletopi/Linguagem_de_Programacao_Visual/blob/main/Calc_de_Desconto_WinForms/Form1.cs)"*

<div align="left">
 
  Nesta aula foram aprendidos:
  - Criação labels, text-boxes e buttons com a Caixa de Ferramentas
  - Algoritmo matemático simples de aplicação de desconto em porcentagem
 
</div>

```c#
private void btnCalcularDesconto_Click(object sender, EventArgs e)
{
    double valorDaCompra = 0, percDeDesconto = 0, valorComDesconto = 0;

    valorDaCompra = Convert.ToDouble(txtValorDaCompra.Text);
    percDeDesconto = Convert.ToDouble(txtPercDeDesconto.Text);
    valorComDesconto = Convert.ToDouble(lblResultadoNum.Text);

    valorComDesconto = valorDaCompra - valorDaCompra * (percDeDesconto / 100);

    lblResultadoNum.Text = valorComDesconto.ToString("F");
}

    private void btnLimpar_Click(object sender, EventArgs e)
{
    txtPercDeDesconto.Clear();
    txtValorDaCompra.Clear();
    txtValorDaCompra.Select();
    lblResultadoNum.Text = "0";
}
```

<div align="left">
  <h6><a href="#linguagem-de-programação-visual-"> Voltar para o início ↺</a></h6>
</div>

<div align="center">
  <img width=100% align="center" src="https://capsule-render.vercel.app/api?type=rect&color=636363&height=4&section=header&%20render">
</div>

### 3. Criando um Menu de Seleção para abrir Novas Janelas

<div align="left">
 
  Nesta aula foram aprendidos:
  - Criação de novos formulários para criar novas janelas para acessar através dos botões
  - Linkar o acesso de uma janela a outra através do código
  - Criar um conversor de Hectares ⇆ Alqueires
  - Criar um conversor de Horas ⇆ Minutos
  - Criar um conversor de Metros ⇆ Km
  - Criar um conversor de Hectares ⟶ Km²

> ### O Menu Principal
> <a href="https://github.com/juletopi/Linguagem_de_Programacao_Visual/blob/main/Menu_de_Forms_WinForms/GUI%20Images/JanelaMenuPrincipaldeConversores-pic.PNG"><img align="center" src="https://github.com/juletopi/Linguagem_de_Programacao_Visual/assets/76459155/67d8238b-a908-45a4-b292-a5b62511f9f4" alt="JanelaMenuPrincipal-pic" title="Menu Principal" style="width: 50%;"></a>

> [!NOTE]\
> *Retirado da aula de "[Menu_de_Forms_WinForms](https://github.com/juletopi/Linguagem_de_Programacao_Visual/blob/main/Menu_de_Forms_WinForms/Form1.cs)"*

```c#
private void btnConversorHecteAlqu_Click(object sender, EventArgs e)
{
    FormConverterHecteAlqu form = new FormConverterHecteAlqu();
    form.ShowDialog();
}

private void btnConversorMetroseKilometros_Click(object sender, EventArgs e)
{
    FormConverterMetroseKilometros form = new FormConverterMetroseKilometros();
    form.ShowDialog();
}

private void btnConversorHoraseMinutos_Click(object sender, EventArgs e)
{
    FormConverterHoraseMinutos form = new FormConverterHoraseMinutos();
    form.ShowDialog();
}

private void btnConversorHecteKmQuadrado_Click(object sender, EventArgs e)
{
    FormConverterHecteKmQuadrado form = new FormConverterHecteKmQuadrado();
    form.ShowDialog();
}

private void linkJuletopi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
{
    string url = "https://github.com/juletopi";
    Process.Start(url);
}
```

> ### As Novas Janelas: Conversor de Hectares ⇆ Alqueires
> <a href="https://github.com/juletopi/Linguagem_de_Programacao_Visual/blob/main/Menu_de_Forms_WinForms/GUI%20Images/JanelaConversorHectaresAlqueires-pic.PNG"><img align="center" src="https://github.com/juletopi/Linguagem_de_Programacao_Visual/assets/76459155/410fa54c-d2a1-4782-95cd-1ce67659fac5" alt="JanelaConversorHectAlque-pic" title="Janela de Conversor de Hectares ⇆ Alqueires" style="width: 50%;"></a>

> [!NOTE]\
> *Retirado da aula de "[Menu_de_Forms_WinForms](https://github.com/juletopi/Linguagem_de_Programacao_Visual/blob/main/Menu_de_Forms_WinForms/Formularios/FormConverterHecParaAlq.cs)"*

```c#
private void btnConverterHectare_Click(object sender, EventArgs e)
{
    double valorHectare = 0, valorAlqueire = 0;

    valorHectare = Convert.ToDouble(txtValorHectare.Text);
    valorAlqueire = Convert.ToDouble(lblResultadoHectareParaAlqueire.Text);

    valorAlqueire = valorHectare * 2.42;

    lblResultadoHectareParaAlqueire.Text = valorAlqueire.ToString();
}

private void btnConverterAlquere_Click(object sender, EventArgs e)
{
    double valorHectare = 0, valorAlqueire = 0;

    valorAlqueire = Convert.ToDouble(txtValorAlqueire.Text);
    valorHectare = Convert.ToDouble(lblResultadoAlqueireParaHectare.Text);

    valorHectare = valorAlqueire / 2.42;

    lblResultadoAlqueireParaHectare.Text = valorHectare.ToString();
}

private void btnLimpar_Click(object sender, EventArgs e)
{
    txtValorHectare.Clear();
    txtValorAlqueire.Clear();
    txtValorHectare.Select();
    lblResultadoHectareParaAlqueire.Text = "0";
    lblResultadoAlqueireParaHectare.Text = "0";
}

private void linkJuletopi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
{
    string url = "https://github.com/juletopi";
    Process.Start(url);
}
```

> ### As Novas Janelas: Conversor de Metros ⇆ Km
> <a href="https://github.com/juletopi/Linguagem_de_Programacao_Visual/blob/main/Menu_de_Forms_WinForms/GUI%20Images/JanelaConversorMetrosKilometros-pic.PNG"><img align="center" src="https://github.com/juletopi/Linguagem_de_Programacao_Visual/assets/76459155/86032714-6a3a-4f17-b724-b03bcaf6c7cd" alt="JanelaConversorMetrosKm" title="Janela de Conversor de Metros ⇆ Km" style="width: 50%;"></a> 

> [!NOTE]\
> *Retirado da aula de "[Menu_de_Forms_WinForms](https://github.com/juletopi/Linguagem_de_Programacao_Visual/blob/main/Menu_de_Forms_WinForms/Formularios/FormConverterMetroseKilometros.cs)"*

```c#
private void btnConverterMetrosParaKm_Click(object sender, EventArgs e)
{
    double valorMetros = 0, valorQuilometros = 0;

    valorMetros = Convert.ToDouble(txtValorMetros.Text);
    valorQuilometros = Convert.ToDouble(lblResultadoMetrosParaKm.Text);

    valorQuilometros = valorMetros / 1000;

    lblResultadoMetrosParaKm.Text = valorQuilometros.ToString();
}

private void btnConverterKmParaMetros_Click(object sender, EventArgs e)
{
    double valorMetros = 0, valorQuilometros = 0;

    valorQuilometros = Convert.ToDouble(txtValorKm.Text);
    valorMetros = Convert.ToDouble(lblResultadoKmParaMetros.Text);

    valorMetros = valorQuilometros * 1000;

    lblResultadoKmParaMetros.Text = valorMetros.ToString();
}

private void btnLimpar_Click(object sender, EventArgs e)
{
    txtValorMetros.Clear();
    txtValorKm.Clear();
    txtValorMetros.Select();
    lblResultadoMetrosParaKm.Text = "0";
    lblResultadoKmParaMetros.Text = "0";
}

private void linkJuletopi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
{
    string url = "https://github.com/juletopi";
    Process.Start(url);
}
```

> ### As Novas Janelas: Conversor de Horas ⇆ Minutos
> <a href="https://github.com/juletopi/Linguagem_de_Programacao_Visual/blob/main/Menu_de_Forms_WinForms/GUI%20Images/JanelaConversorHorasMinutos-pic.PNG"><img align="center" src="https://github.com/juletopi/Linguagem_de_Programacao_Visual/assets/76459155/6ca87344-998b-4359-80b6-8e0ffd92cbc6" alt="JanelaConversorHorasMinutos-pic" title="Janela de Conversor de Horas ⇆ Minutos" style="width: 50%;"></a>

> [!NOTE]\
> *Retirado da aula de "[Menu_de_Forms_WinForms](https://github.com/juletopi/Linguagem_de_Programacao_Visual/blob/main/Menu_de_Forms_WinForms/Formularios/FormConverterHoraseMinutos.cs)"*

```c#
private void btnConverterHorasParaMinutos_Click(object sender, EventArgs e)
{
    double valorHoras = 0, valorMinutos = 0;

    valorHoras = Convert.ToDouble(txtValorHoras.Text);
    valorMinutos = Convert.ToDouble(lblResultadoHorasParaMinutos.Text);

    valorMinutos = valorHoras * 60;

    lblResultadoHorasParaMinutos.Text = valorMinutos.ToString();
}

private void btnConverteMinutosParaHoras_Click(object sender, EventArgs e)
{
    double valorHoras = 0, valorMinutos = 0;

    valorMinutos = Convert.ToDouble(txtValorMinutos.Text);
    valorHoras = Convert.ToDouble(lblResultadoMinutosParaHoras.Text);

    valorHoras = valorMinutos / 60;

    lblResultadoMinutosParaHoras.Text = valorHoras.ToString();
}

private void btnLimpar_Click(object sender, EventArgs e)
{
    txtValorHoras.Clear();
    txtValorMinutos.Clear();
    txtValorHoras.Select();
    lblResultadoHorasParaMinutos.Text = "0";
    lblResultadoMinutosParaHoras.Text = "0";
}

private void linkJuletopi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
{
    string url = "https://github.com/juletopi";
    Process.Start(url);
}
```

> ### As Novas Janelas: Conversor de Hectares ⟶ Km²
> <a href="https://github.com/juletopi/Linguagem_de_Programacao_Visual/blob/main/Menu_de_Forms_WinForms/GUI%20Images/JanelaConversorHectKmQuadrado-pic.PNG"><img align="center" src="https://github.com/juletopi/Linguagem_de_Programacao_Visual/assets/76459155/659a4b0f-8c38-4f06-b54b-dd95402be0ae" alt="JanelaConversorHectKmQuadrado-pic" title="Janela de Conversor de Hectares ⟶ Km²" style="width: 50%;"></a>

> [!NOTE]\
> *Retirado da aula de "[Menu_de_Forms_WinForms](https://github.com/juletopi/Linguagem_de_Programacao_Visual/blob/main/Menu_de_Forms_WinForms/Formularios/FormConverterHecteKmQuadrado.cs)"*

```c#
private void btnConverterHectParaKmQuadrado_Click(object sender, EventArgs e)
{
    double valorHectare = 0, valorKmQuadrado = 0;

    valorHectare = Convert.ToDouble(txtValorHectare.Text);
    valorKmQuadrado = Convert.ToDouble(lblResultadoHectParaKmQuadrado.Text);

    valorKmQuadrado = valorHectare * 0.0042;

    lblResultadoHectParaKmQuadrado.Text = valorKmQuadrado.ToString();
}

private void btnLimpar_Click(object sender, EventArgs e)
{
    txtValorHectare.Clear();
    txtValorHectare.Select();
    lblResultadoHectParaKmQuadrado.Text = "0";
}

private void linkJuletopi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
{
    string url = "https://github.com/juletopi";
    Process.Start(url);
}
```
 
</div>

<div align="left">
  <h6><a href="#linguagem-de-programação-visual-"> Voltar para o início ↺</a></h6>
</div>

<br>

<!-- THANK YOU, GOODBYE -->

----

<div align="center">
  <a href="https://github.com/juletopi/Linguagem_de_Programacao_Visual/blob/main/Assets/Images/ObrigadoPorVisitar(Cinza)-pic.png">
    <img src="https://user-images.githubusercontent.com/76459155/221390038-184b6e68-53bb-4f33-ba0b-2a6dd727b592.png" align="center" width="600" height="90" alt="ObrigadoPorVisitar(Cinza)-pic" title="Bye bye! :)" />
  </a>
</div>

<div align="center">
  Feito com 🖤 por Juletopi
</div>
