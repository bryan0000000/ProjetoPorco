namespace Controles
 {   
        public class Controle_Base
    {
                public virtual void Criar (Objeto O)
            {
            }
                public virtual void Atualizar (Registro O)
            {   
            }
                public virtual void Apagar (int id)
            {   
            }
                public virtual void ler (int id)
            { 
                    return id;  
            }
    }
 }

