namespace Modelos;
public class Fornecedor:Registro
{
    string Nome;
    string Telefone;
    string Email;
    string Endereço;
    string Fornecimento;
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
public void SetFornecimento (string Fornecimento)
{
    this.Fornecimento=Fornecimento; 
}
//----------------------------------------------------------------------------
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
public void GetFornecimento (string Fornecimento)
{
    return Fornecimento; 
}
}