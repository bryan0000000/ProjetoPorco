namespace Controles
 {   
        public class Fornecedor_Controle:Controle_Base
    {
                public virtual void Criar (Registro)
            {
            }
                public virtual void Atualizar (Registro)
            {   
            }
                public virtual void Apagar (int id)
            {   
            }
                public virtual void Ler (int id)
            { 
                    return id;  
            }

   }
 }