using LiteDB;

namespace Modelos;
public class Estoque : Registro
{
    string Cor { get; set; }
    string Tecido { get; set; }
    int Quantidade { get; set; }
    [BsonId]
    int id { get; set; }
    public void SetCor(string Cor)
    {
        this.Cor = Cor;
    }
    public void SetTecido(string Tecido)
    {
        this.Tecido = Tecido;
    }
    public void SetQuantidade(string Quantia)
    {
        this.Quantidade = Quantidade;
    }
    //-----------------------------------------------------------------------------
    public string GetCor()
    {
        return Cor;
    }
    public string GetTecido()
    {
        return Tecido;
    }
    public int GetQuantia()
    {
        return Quantidade;
    }
}