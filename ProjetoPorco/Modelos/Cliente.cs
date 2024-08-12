using LiteDB;

namespace Modelos;

public class Cliente : Registro
{
    [BsonId]
    int id { get; set; }
    string Nome { get; set; }
    string Telefone { get; set; }


    public void SetNome(string Nome)
    {
        this.Nome = Nome;
    }
    public void SetTelefone(string Telefone)
    {
        this.Telefone = Telefone;
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
}