namespace tp1.tp3
{
    //Ejercicio 2
    public class generadorDatosAleatorio
    {

      static public int numeroAleatorio(int max){
        Random random =  new Random();
        Int32 num_aleatorio = random.Next(0, max);
        return num_aleatorio;
      }

      static public string stringAleatorio(int cantidad){
        Random num_aleatorio = new Random();
        char[] letras = { 'q', 'w','e','r','t','y','u','i','o','p','a','s','d','f','g','h','j','k','l','ñ','z','x','c','v','b','n','m' };
        string string_aleatorio = null;

        for (int i = 0; i < cantidad; i++)
        {
            string_aleatorio = string_aleatorio + letras[num_aleatorio.Next(0,27)];

        }

        return string_aleatorio;
      }  
    }
}