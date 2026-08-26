using System.ComponentModel.DataAnnotations;
namespace DataAnnotations.Models;

public class ClientePremiumViewModel
{
    [Required(
        ErrorMessage = "Nome completo é obrigatório.")]
    [StringLength(
        100, 
        MinimumLength = 5, 
        ErrorMessage = "Mín. de 5 e máx. de 100 caracteres.")]
    [Display(
        Name = "Nome completo")]
    public string NomeCompleto { get; set; }
    
    [Required(
        ErrorMessage = "Data de nascimento é obrigatória.")]
    [DataType(
        DataType.Date)]
    [Display(
        Name = "Data de nascimento")]
    public DateTime DataNascimento { get; set; }

    [Required(
        ErrorMessage = "CPF é obrigatório.")]
    [RegularExpression(
        @"^\d{11}$",
        ErrorMessage = "Formato de CPF inválido.")]
    [Display(
        Name = "CPF")]
    public string Cpf { get; set; }

    [Required(
        ErrorMessage = "Telefone celular é obrigatório.")]
    [Phone(
        ErrorMessage = "Informe um telefone celular válido.")]
    [Display(
        Name = "Telefone celular")]
    public string TelefoneCelular { get; set; }

    [Url(
        ErrorMessage = "Informe uma URL válida para o perfil do LinkedIn.")]
    [Display(
        Name = "LinkedIn")]
    public string UrlPerfilLinkedIn { get; set; }

    [Required(
        ErrorMessage = "Renda mensal é obrigatória.")]
    [Range(
        3000, 
        1000000, 
        ErrorMessage = "A renda mensal deve estar entre R$ 3.000,00 e R$ 1.000.000,00.")]
    [DataType(
        DataType.Currency)]
    [Display(
        Name = "Renda mensal")]
    public decimal RendaMensal { get; set; }

    [Required(
        ErrorMessage = "Número do cartão de crédito é obrigatório.")]
    [CreditCard(
        ErrorMessage = "Informe um número de cartão de crédito válido.")]
    [Display(
        Name = "Número do cartão de crédito")]
    public string NumeroCartaoCredito { get; set; }

    [Required(
        ErrorMessage = "Senha de acesso é obrigatória.")]
    [DataType(
        DataType.Password)]
    [RegularExpression(
        @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z\d]).{8,}$",
        ErrorMessage = "A senha deve conter pelo menos 8 caracteres, uma letra maiúscula, uma letra minúscula, um número e um caractere especial.")]
    [Display(
        Name = "Senha de acesso")]
    public string SenhaAcesso { get; set; }

    [Required(
        ErrorMessage = "A confirmação da senha é obrigatória.")]
    [DataType(
        DataType.Password)]
    [Compare(
        "SenhaAcesso",
        ErrorMessage = "A senha deve ser igual à senha de acesso.")]
    [Display(
        Name = "Confirmar senha")]
    public string ConfirmarSenhaAcesso { get; set; }
}
