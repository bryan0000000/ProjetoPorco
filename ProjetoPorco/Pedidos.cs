namespace ProjetoPorco;
public class Pedidos
{
    string Nome;
    string Telefone;
    string Email;
    string Endereço;
    string Roupa;
    int Quantia;
    int id;

public void SetNome (string Nome)
{
    this.Nome=Nome; 
}
public void SetTelefone (string Telefone)
{
    this.Telefone=Telefone; 
}
public void SetEmail (string Email)
{
    this.Email=Email; 
}
public void SetEndereço (string Endereço)
{
    this.Endereço=Endereço; 
}
public void SetRoupa (string Roupa)
{
    this.Roupa=Roupa; 
}
public void SetQuantia (string Quantia)
{
    this.Quantia=Quantia; 
}
//--------------------------------------------------------------------------------------
public void GetNome (string Nome)
{
    return Nome; 
}
public void GetTelefone (string Telefone)
{
    return Telefone; 
}
public void GetEmail (string Email)
{
    return Email; 
}
public void GetEndereço (string Endereço)
{
    return Endereço; 
}
public void GetRoupa (string Roupa)
{
    return Roupa; 
}
public void GetQuantia (string Quantia)
{
    return Quantia; 
}
}


