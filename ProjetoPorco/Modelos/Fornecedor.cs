using LiteDB;

namespace Modelos;
public class Fornecedor : Registro
{
   public string Nome { get; set; }
   public string Telefone { get; set; }
   public string Email { get; set; }
   public string Endereço { get; set; }
   public string Fornecimento { get; set; }
   [BsonId]
   public int id { get; set; }

  
}