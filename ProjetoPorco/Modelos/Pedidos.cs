namespace Modelos;
public class Pedidos:Registro
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
public void SetQuantia (int Quantia)
{
    this.Quantia=Quantia; 
}
//--------------------------------------------------------------------------------------
public string GetNome ( )
{
    return Nome; 
}
public string GetTelefone ( )
{
    return Telefone; 
}
public string GetEmail ( )
{
    return Email; 
}
public string GetEndereço ( )
{
    return Endereço; 
}
public string GetRoupa ( )
{
    return Roupa; 
}
public int GetQuantia ( )
{
    return Quantia; 
}
}


