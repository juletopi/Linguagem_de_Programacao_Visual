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
<img src="https://github-visitors-badge.glitch.me/badge?page_id=Linguagem_de_Programacao_Visual.github-visitors-badge" alt="PageVisitors-badge">
</div>

<br>

<!-- PRESENTATION -->

<div align="center">
<a href="https://github.com/juletopi/Linguagem_de_Programacao_Visual/blob/main/Assets/Images/WindowsForms-pic.png"><img src="https://user-images.githubusercontent.com/76459155/221386519-5f7aa521-6c02-4adb-a1ed-9c2e79e1454d.png" alt="VisualProgramming-pic" width="116px"></a>
<h2 align="center">Linguagem de Programação Visual 📟</h2>
</div>

<div align="center">

• Este é um repositório com os conteúdos de Linguagem de Programação Visual, \
ministradas pelo professor [**Reinaldo Lima**](https://www.linkedin.com/in/reinaldo-lima-pereira-7b726856/), utilizando o **Visual Studio**, \
a linguagem **CSharp** e a estrutura de interface do **Windows Forms** \
como ferramentas de aprendizado.
</div>

<div align="center">
<a href="https://visualstudio.microsoft.com/"><img src="https://img.shields.io/badge/Made%20with%20IDE:-Visual%20Studio%20-gray.svg?colorA=655BE1&amp;colorB=4F44D6&amp;style=for-the-badge" alt="VisualStudioIDE-badge" style="max-width: 100%;"></a>
<a href="https://dotnet.microsoft.com/en-us/languages/csharp"><img src="https://img.shields.io/badge/Made%20with%20language:-CSharp%20-gray.svg?colorA=61c265&amp;colorB=4CAF50&amp;style=for-the-badge" alt="CSharpLanguage-badge" style="max-width: 100%;"></a>

<a href="https://learn.microsoft.com/en-us/visualstudio/ide/create-csharp-winform-visual-studio?view=vs-2022"><img src="https://img.shields.io/badge/Made%20with%20GUI:-Windows%20Forms-gray.svg?colorA=636363&amp;colorB=343434&amp;style=for-the-badge" alt="WindowsForms-badge" style="max-width: 100%;"></a>
</div>

<div align="center">
<img align="center" src="https://capsule-render.vercel.app/api?type=rect&color=636363&height=4&section=header&%20render">

<br>
<br>

[![Readme Quotes](https://quotes-github-readme.vercel.app/api?type=horizontal&theme=dark&quote=Algumas%20pessoas%20pensam%20que%20design%20significa%20como%20ele%20se%20parece.%20Mas,%20é%20claro,%20se%20você%20cavar%20mais%20fundo,%20na%20verdade%20é%20como%20ele%20funciona.&author=Steve%20Jobs)](https://github.com/piyushsuthar/github-readme-quotes)
</div>

<!-- ABOUT TEACHER -->

<div align="left">

## 👨‍🏫 Professor:

<a href="https://github.com/juletopi/Linguagem_de_Programacao_Visual/blob/main/Assets/Images/ReinaldoLima-pic.png"><img align="left" height="135px" width="135px" alt="ReinaldoLima-pic" src="https://user-images.githubusercontent.com/76459155/221387561-1a565eeb-2f3a-4524-bccf-5d0fcd03927f.png"></a>

**Reinaldo Lima - Professor de Informática | Professor de Curso Técnico, Superior e Pós-Graduação** \
[**IFRO Campus Ji-Paraná**](https://portal.ifro.edu.br/ji-parana) • <i>Atuando desde Março de 2016</i> \
Linguagens & Tecnologias: `C#` • `Windows Forms` • `Java` • `Delphi` \
Contato: **[reinaldo.pereira@ifro.local](mailto:reinaldo.pereira@ifro.local)**

<br>

<div align="center">
<img align="center" src="https://capsule-render.vercel.app/api?type=rect&color=636363&height=4&section=header&%20render">
</div>

<!-- LEARNED CONCEPTS -->

## 📚 Conceitos Aprendidos:

### 1. Ferramentas do Windows Forms e Criando uma Calculadora Simples

> <a href="https://github.com/juletopi/Linguagem_de_Programacao_Visual/blob/main/Assets/Images/JanelaCalculadoraSimples-pic.PNG"><img align="center" src="https://user-images.githubusercontent.com/76459155/222274248-4f711c97-50e6-4b9f-a779-18d0ad695f66.PNG" alt="JanelaCalculadoraSimples-pic" style="width: 60%;"></a>
</div>

> **Note** ➜ *Retirado da aula de "[Calculadora_WinForms](https://github.com/juletopi/Linguagem_de_Programacao_Visual/blob/main/Calculadora_WinForms/Form1.cs)"*

Nesta aula foram aprendidos:
- Conceitos básicos da ferramenta do Windows Forms
- Criação labels, text-boxes e buttons com a Caixa de Ferramentas
- Algoritmos simples de Soma, Subtração, Multiplicação e Divisão
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

<h6 align="left">
<a href="#linguagem-de-programação-visual-"> Voltar para o início ↺</a></h6>

<div align="center">
<img align="center" src="https://capsule-render.vercel.app/api?type=rect&color=636363&height=4&section=header&%20render">
</div>

### 2. Ferramentas do Windows Forms e Criando uma Calculadora Simples

> <a href="#"><img align="center" src="https://user-images.githubusercontent.com/76459155/222634709-7ce89082-bb4b-4cf3-9578-cded6cf2e2ac.PNG" alt="JanelaCalcDeDesconto-pic" style="width: 50%;"></a>
</div>

> **Note** ➜ *Retirado da aula de "[Calc_de_Desconto_WinForms](https://github.com/juletopi/Linguagem_de_Programacao_Visual/blob/main/Calc_de_Desconto_WinForms/Form1.cs)"*

Nesta aula foram aprendidos:
- Criação labels, text-boxes e buttons com a Caixa de Ferramentas
- Algoritmo matemático simples de aplicação de desconto em porcentagem
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

<h6 align="left">
<a href="#linguagem-de-programação-visual-"> Voltar para o início ↺</a></h6>

<br>

<!-- THANK YOU, GOODBYE -->

----

<div align="center">
<a href="https://github.com/juletopi/Linguagem_de_Programacao_Visual/blob/main/Assets/Images/ObrigadoPorVisitar(Cinza)-pic.png"><img src="https://user-images.githubusercontent.com/76459155/221390038-184b6e68-53bb-4f33-ba0b-2a6dd727b592.png" align="center" width="600" height="90" alt="ObrigadoPorVisitar(Cinza)-pic"/></a>
</div>

<div align="center">
Feito com 🖤 por Juletopi
</div>
