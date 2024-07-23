namespace Controles
 {   
        public class Controle_Base
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
                public virtual void ler (int id)
            { 
                    return id;  
            }
    }
 }

