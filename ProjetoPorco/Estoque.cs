namespace ProjetoPorco;
public class Estoque
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
    this.Cor=Cor; 
}
public void GetTecido (string Tecido)
{
    this.Tecido=Tecido; 
}
public void GetQuantia (string Quantia)
{
    this.Quantidade=Quantidade; 
}
}