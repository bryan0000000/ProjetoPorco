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
public void GetCor (string Cor)
{
    return Cor; 
}
public void GetTecido (string Tecido)
{
    return Tecido; 
}
public void GetQuantia (string Quantia)
{
   return Quantidade; 
}
}