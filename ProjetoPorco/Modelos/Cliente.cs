namespace Modelos;

public class cliente:Registro
{
    string Nome;
    string Telefone;
    int id;

public void SetNome (string Nome)
{
    this.Nome=Nome; 
}
public void SetTelefone (string Telefone)
{
    this.Telefone=Telefone; 
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