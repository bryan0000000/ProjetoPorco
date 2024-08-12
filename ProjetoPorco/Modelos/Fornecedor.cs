using LiteDB;

namespace Modelos;
public class Fornecedor : Registro
{
    string Nome { get; set; }
    string Telefone { get; set; }
    string Email { get; set; }
    string Endereço { get; set; }
    string Fornecimento { get; set; }
    [BsonId]
    int id { get; set; }

    public void SetNome(string Nome)
    {
        this.Nome = Nome;
    }
    public void SetTelefone(string Telefone)
    {
        this.Telefone = Telefone;
    }
    public void SetEmail(string Email)
    {
        this.Email = Email;
    }
    public void SetEndereço(string Endereço)
    {
        this.Endereço = Endereço;
    }
    public void SetFornecimento(string Fornecimento)
    {
        this.Fornecimento = Fornecimento;
    }
    //----------------------------------------------------------------------------
    public string GetNome()
    {
        return Nome;
    }
    public string GetTelefone()
    {
        return Telefone;
    }
    public string GetEmail()
    {
        return Email;
    }
    public string GetEndereço()
    {
        return Endereço;
    }
    public string GetFornecimento()
    {
        return Fornecimento;
    }
}