using Modelos;

namespace Controles
 {   
        public class Controle_Base
    {
                public virtual void Criar (Registro O)
            {
            }
                public virtual void Atualizar (Registro O)
            {   
            }
                public virtual void Apagar (int id)
            {   
            }
                public virtual Registro ler (int id)
            { 
                    return null;  
            }
    }
 }

