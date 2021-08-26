//Dependencias
using System;

//Alcance del proyecto
namespace PrimeraClase
{
    //shkjdfsd
    //Clase principal
    //Primera letra en mayúscula y en singular
    class Program
    {
        //función principal / programa principal (thread)
        static void Main(string[] args)
        {
            while (false)
            {
                //print
                //System.out.println
                Console.WriteLine("Hola Mundo!");

                //Tipos de dato primitivo
                //Siempre, antes del nombre de la variable,
                //se declara el tipo de dato
                int numero = 7;
                long numeroGrande = 3455555555555778L;
                float numeroDecimal = 1.2F;
                double numeroGrandeyDecimal = 234324234234.23423423;
                string cadenaDeTexto = "Soy un texto";
                bool verdaderoOFalso = true;


                //Una variable puede no ser inicializada como en éste caso,
                //y darle un valor posteriormente
                string nombre;
                //código
                //código
                nombre = "Diego";
                char letra = 'h';

                int soyUnNumero = 9;

                //existen palabras reservadas que no podremos usar
                int _class = 8;
                string _void = "palabra reservada";


                //sentencia iterativa
                bool doyVueltas = true;
                int vueltas = 0;
                while (doyVueltas)
                {
                    Console.WriteLine("Estoy dando vueltas");
                    vueltas = vueltas + 1;
                    Console.WriteLine("Llevo ");
                    Console.WriteLine(vueltas);
                    Console.WriteLine(" Vueltas");
                    if (vueltas == 10)
                    {
                        doyVueltas = false;
                    }
                }


                //sentencia iterativa
                for (int vueltasB = 0; vueltasB <= 10; vueltasB++)
                {
                    Console.WriteLine("Estoy dando vueltas");

                    Console.WriteLine("Llevo ");
                    Console.WriteLine(vueltasB);
                    Console.WriteLine(" Vueltas");
                }

                /*
                 * fdsfsdhfkdsfjsdkf
                 * fjsdkfhksdjf
                 * sdjfhsdjfh###
                 */
            }

            //Instanciar un objeto
            //tipo de dato (Auto)
            //nombre (miAuto)
            //new: indica la creación de un objeto en base a la clase
            //Auto miAuto = new Auto(); //instanciamos un objeto
            //Auto miSegundoAuto;
            //miSegundoAuto = new Auto();
            Auto miAuto = new Auto("AA 22 22");

            //miAuto.color = "Rojo";
            //miAuto.cambiarColor("Rojo");
            //miAuto.patente = "AB 23 23";
            //miAuto.cambiarPatente("AB 23 23");
            //miAuto.anioCreacion = 2020;
            //miAuto.cambiarAnio(2020);
            //miAuto.tipo = "Auto";
            //miAuto.cambiarTipo("Auto");

            //miSegundoAuto.color = "Blanco";
            //miSegundoAuto.patente = "HH 76 76";
            //miSegundoAuto.anioCreacion = 2019;
            //miSegundoAuto.tipo = "Camioneta";

            //miAuto.acelerar();

            //Console.WriteLine("Color del auto "+miAuto.color);
            //Console.WriteLine("Patente del auto "+miAuto.patente);
            //Console.WriteLine("Año de creación "+miAuto.anioCreacion);
            //Console.WriteLine("Mi auto es un/a "+miAuto.tipo);

            //Ahora no accedemos directamente a los datos
            //ellos están encapsulados en funciones
            Console.WriteLine("Color del auto: "+miAuto.obtenerColor());
            Console.WriteLine("Patente del auto " + miAuto.obtenerPatente());
            Console.WriteLine("Año del auto " + miAuto.obtenerAnio());
            Console.WriteLine("Tipo del auto " + miAuto.obtenerTipo());
        }
    }

    //class: define que comienza una clase
    //Primera letra en mayúscula y en singular
    //Clase: Receta, molde, de un objeto.
    //Objeto: instancia de clase
    class Auto
    {
        /*****ATRIBUTOS (ESTADO)************  <----------- */ 
        //mutador de acceso -> tipo de dato -> nombre
        //-->>ENCAPSULACIÓN: esconder los datos para manejar su comportamiento
        //-->>ABSTRACCIÓN: esconder bajo capas el comportamiento de un programa
        private string color;
        private string patente;
        private int anioCreacion;
        private string tipo;

        /*******CONSTRUCTOR************/
        //El constructor establece la manera de instanciar la clase
        //-->POLIMORFISMO: Diferentes maneras de acceder a una función
        //Sobrecarga del constructor
        //INVESTIGUE HERENCIA...
        public Auto(int anioConstruccion)
        {
            this.anioCreacion = anioConstruccion;
        }
        public Auto()
        {
            this.anioCreacion = 1981;
        }

        public Auto(string patentePorDefecto)
        {
            this.patente = patentePorDefecto;
        }

        



        /*****FUNCIONES o MÉTODOS (COMPORTAMIENTO)*****/

        //Acelerar
        //Accesador primero que todo
        //No retorna ningún dato, solo ejecuta una función
        //Console.writeline.
        public void acelerar() //Firma de la función o método
        {
            Console.WriteLine(color);
            Console.WriteLine("He acelerado");
        }


        //Encapsulamiento de los atributos de la clase
        public string obtenerColor()
        {
            return color;
        }

        public void cambiarColor(string nuevoColor)
        {
            color = nuevoColor;
        }

        public string obtenerPatente()
        {
            return patente;
        }

        public void cambiarPatente(string nuevaPatente)
        {
            patente = nuevaPatente;
        }

        public int obtenerAnio()
        {
            return anioCreacion;
        }

        public void cambiarAnio(int nuevoAnio)
        {
            if (nuevoAnio < 1980 || nuevoAnio > 2023)
            {
                anioCreacion = anioCreacion;
            }
            else
            {
                anioCreacion = nuevoAnio;
            }
        }

        public string obtenerTipo()
        {
            return tipo;
        }

        public void cambiarTipo(string nuevoTipo)
        {
            tipo = nuevoTipo;
        }


        //Retorna un tipo de dato int, por tanto, debo declararlo al comienzo,
        //antes del nombre de la función
        //al igual que los datos del argumento
        int suma(int x, int y)//Firma
        {
            return x + y;
        }
    }
}
