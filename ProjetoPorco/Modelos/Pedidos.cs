using LiteDB;

namespace Modelos;
public class Pedidos : Registro
{
       public string Nome { get; set; }
       public string Telefone { get; set; }
       public string Email { get; set; }
       public string Endereço { get; set; }
       public string Roupa { get; set; }
       public int Quantia { get; set; }
              [BsonId]
       public int id { get; set; }

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
    public void SetRoupa(string Roupa)
    {
        this.Roupa = Roupa;
    }
    public void SetQuantia(int Quantia)
    {
        this.Quantia = Quantia;
    }
    //--------------------------------------------------------------------------------------
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
    public string GetRoupa()
    {
        return Roupa;
    }
    public int GetQuantia()
    {
        return Quantia;
    }
}


