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
public string GetFornecimento ( )
{
    return Fornecimento; 
}
}