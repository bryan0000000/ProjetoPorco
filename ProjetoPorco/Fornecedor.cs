namespace ProjetoPorco;
public class Fornecedor
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
    this.Nome=Nome; 
}
public void GetTelefone (string Telefone)
{
    this.Telefone=Telefone; 
}
public void GetEmail (string Email)
{
    this.Email=Email; 
}
public void GetEndereço (string Endereço)
{
    this.Endereço=Endereço; 
}
public void GetFornecimento (string Fornecimento)
{
    this.Fornecimento=Fornecimento; 
}
}