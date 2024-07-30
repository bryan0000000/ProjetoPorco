namespace Modelos;
public class Estoque:Registro
{
    string Cor;
    string Tecido;
    int Quantidade;
    int id;
public void SetCor (string Cor)
{
    this.Cor=Cor; 
}
public void SetTecido (string Tecido)
{
    this.Tecido=Tecido; 
}
public void SetQuantidade (string Quantia)
{
    this.Quantidade=Quantidade; 
}
//-----------------------------------------------------------------------------
public string GetCor ( )
{
    return Cor; 
}
public string GetTecido ( )
{
    return Tecido; 
}
public int GetQuantia ( )
{
   return Quantidade; 
}
}