namespace CesarWeb.Services
{

    public class SeguridadService : ISeguridadService<int>
    {
        static string ABECEDARIO = ("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
        static string ABECEDARIOS = ("abcdefghijklmnñopqrstuvwxyz");

        ///  Aquí deben hacer todo el código necesario para Desencriptar el mensaje
      
        public string DesEncriptar(string Mensaje, int clave)
        {
            clave=clave*(-1);
            int x=0;
            char[] clon =new  char[Mensaje.Length];
            for(int rep=0 ;rep<Mensaje.Length; rep++)
            {
                clon[rep]=Mensaje[rep];
            }
            for(int i=0; i< Mensaje.Length;i++)
            { 
                for(x=0; x<=26; x++)
                {
                    if(Mensaje[i]==ABECEDARIO[x])
                    {
                        if(x+clave<0)
                        {
                            int sol=x-clave;
                            int res=27-sol;
                            clon[i]=ABECEDARIO[res];
                        }
                        else
                        {
                        int clav=(x+clave)%27;
                        clon[i]=ABECEDARIO[clav];
                        }
                    }
                    if(Mensaje[i]==ABECEDARIOS[x])
                    {
                         if(x+clave<0)
                        {
                            int sol=x-clave;
                            int res=27-sol;
                            clon[i]=ABECEDARIOS[res];
                        }
                        else
                        {
                        int clav=(x+clave)%27;
                        clon[i]=ABECEDARIOS[clav];
                        }
                    }
                    }
            }
           
                string Mensajedesencriptado=new string(clon);
                Mensaje=Mensajedesencriptado;
      
          return Mensaje;
        }
        ///  Aquí deben hacer todo el código necesario para Encriptar el mensaje
        public string Encriptar(string Mensaje, int clave)
        {
            int x=0;
            char[] clon =new  char[Mensaje.Length];
            for(int rep=0 ;rep<Mensaje.Length; rep++)
            {
                clon[rep]=Mensaje[rep];
            }
            for(int i=0; i< Mensaje.Length;i++)
            { 
                for(x=0; x<=26; x++)
                {
                    if(Mensaje[i]==ABECEDARIO[x])
                    {
                        if(x+clave<0)
                        {
                            int sol=x-clave;
                            int res=27-sol;
                            clon[i]=ABECEDARIO[res];
                        }
                        else
                        {
                        int clav=(x+clave)%27;
                        clon[i]=ABECEDARIO[clav];
                        }
                    }
                    if(Mensaje[i]==ABECEDARIOS[x])
                    {
                         if(x+clave<0)
                        {
                            int sol=x-clave;
                            int res=27-sol;
                            clon[i]=ABECEDARIOS[res];
                        }
                        else
                        {
                        int clav=(x+clave)%27;
                        clon[i]=ABECEDARIOS[clav];
                        }
                    }
                    }
            }
                string Mensajeencriptado=new string(clon);
                Mensaje=Mensajeencriptado;
            return Mensaje;
        }
    }
}