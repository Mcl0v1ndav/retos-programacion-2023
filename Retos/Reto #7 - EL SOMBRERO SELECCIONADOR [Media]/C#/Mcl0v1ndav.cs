using System;

namespace program 
{
    class SombreroSeleccionador
    {
        public static List<int> seleccionados = new List<int>(5);
        public static int respuestas = 0;
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.WriteLine("Vaya a donde te enviare, dime... ingresa el numero de la opcion que escojas");
                    Console.WriteLine("¿Que harias si tu mejor amigo en hogwarts estubiera a punto de caer de su escoba y tu a punto de coger la snicth dorada?");
                    Console.WriteLine("1.- Lo salvaria\n2.- Seguiria y la tomaria\n3.- Creo ser capaz de tomarla y salvarlo\n4.- Creo que se hay una mejor forma que las que acabas de decir");
                    respuestas = Convert.ToInt32(Console.ReadLine());
                    seleccionados.Add(respuestas);
                    Console.WriteLine("¿Que opinas de los magos que son hijos de mugles?");
                    Console.WriteLine("1.- Creo que dependera de su audacia y valentia tener mi respeto\n2.- Ni si quiera deberian ser aceptados\n3.- Creo que son igual de buenos magos cualquiera de linaje puro\n4.- Creo que con un buen estudio son grandiosos magos");
                    respuestas = Convert.ToInt32(Console.ReadLine());
                    seleccionados.Add(respuestas);
                    Console.WriteLine("¿En una pelea con un mago que intenta matarte, ganaste y su vida depende de ti que escogerias?");
                    Console.WriteLine("1.- Su muerte dependera de la nobleza de este\n2.- Lo asesinaria ya que perdio\n3.- Dependera del daño que alla hecho o que pueda hacerme a mi y a los mios si lo dejo con vida\n4.- Debe ser apresado en busca de informacion");
                    respuestas = Convert.ToInt32(Console.ReadLine());
                    seleccionados.Add(respuestas);
                    Console.WriteLine("Pongamos que tienes la oportunidad de obtener un objeto mágico muy poderoso, pero para hacerlo debes enfrentarte a un desafío peligroso. ¿Qué es lo que más te motiva a aceptar el desafío?");
                    Console.WriteLine("1.- Porque es lo correcto, y tengo que proteger a los demás\n2.- Porque quiero demostrar mi valía y ganar reconocimiento\n3.- Porque creo que es importante trabajar en equipo y superar obstáculos juntos\n4.- Porque estoy ávido de conocimiento y quiero aprender más");
                    respuestas = Convert.ToInt32(Console.ReadLine());
                    seleccionados.Add(respuestas);
                    Console.WriteLine("¿Cual es tu cualidad mas resaltada segun tu mismo?");
                    Console.WriteLine("1.- Soy valiente \n2.- Soy paciente \n3.- Soy inteligente \n4.- Soy astuto ");
                    respuestas = Convert.ToInt32(Console.ReadLine());
                    seleccionados.Add(respuestas);
                    SelectorDeCasa(seleccionados);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("¡Te dije el numero!, Empezemos de nuevo");
                    seleccionados.Clear();
                    seleccionados.Add(0);
                }
            } while (seleccionados[0] == 0);        
        }
        private static void SelectorDeCasa(List<int> listaEntrada)
        {
            var frecuencias = listaEntrada.GroupBy(n => n).Select(g => new  { Numero = g.Key, Cantidad = g.Count() });
            var numeroMasRepetido = frecuencias.OrderByDescending(x => x.Cantidad).First();

            string? answere;

            int numero = numeroMasRepetido.Numero;

            if (numero == 1)
            {
                Console.WriteLine("¡Gryffindor!");
            }
            else if (numero == 2)
            {
                Console.WriteLine("¡Slytherin!");
            }
            else if (numero == 3)
            {
                Console.WriteLine("¡Hufflepuff!");
            }
            else
            {
                Console.WriteLine("¡Ravenclaw!");
            }
        }
    }
}
