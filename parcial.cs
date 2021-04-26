using System;

namespace Necflis
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario[] lista = new Usuario[15];
            Usuario usuario = new Usuario(null,null,0);
            Peliculas[] lista2 = new Peliculas[15];
            Peliculas peliculas = new Peliculas(null,null,null,null);
            registro registro = new registro(null,null,0);
            registro[] lista3 = new registro[30];
            string[] listaprueba = new string[10];
            int contador = 0;          
            int resultado = 0;
            int operacion = 0;
            int numero = 1 ;
            int valor = 0;
            int contar = 0;
            int num = 1;
            int sumatoria = 0;
            System.Console.WriteLine("Bienvenidos a Necflis");
            while(resultado!=3){
            System.Console.WriteLine("Seleccionar alguna Opcion");
            System.Console.WriteLine("1. Clientes");
            System.Console.WriteLine("2. Peliculas");
            System.Console.WriteLine("3. Salir");

            resultado=Convert.ToInt32(Console.ReadLine());
            switch(resultado){
                case 1:
                    while(operacion!=4){
                        System.Console.WriteLine("    Escojer   ");
                        System.Console.WriteLine("1. Ver Lista");
                        System.Console.WriteLine("2. Crear nuevo Cliente");
                        System.Console.WriteLine("3. Seleccionar Cliente");
                        System.Console.WriteLine("4. Salir");

                        operacion=Convert.ToInt32(Console.ReadLine());
                        switch(operacion){
                            case 1:   
                                System.Console.WriteLine("  Lista de Usuarios  ");
                    
                                for (int i = 0; i < contador; i++)
                                {
                                    usuario = lista[i];
                                    System.Console.WriteLine(""+numero +". " + usuario.nombre);
                                    numero++;
                                }
                                numero= 1;

                            break;
                            case 2:
                                usuario = new Usuario();
                                lista[contador] = usuario;
                                contador++;                   
                            break;

                            case 3:
                                System.Console.WriteLine("  Ingrese Numero de Cliente  ");
                                int valor1 = Int32.Parse(Console.ReadLine());
                                Usuario usuario1 = lista[valor1 -1];
                                System.Console.WriteLine("  Informacion general  ");
                                System.Console.WriteLine(" ");
                                System.Console.WriteLine("Nombre: "+ usuario1.nombre);
                                System.Console.WriteLine("Direccion: " + usuario1.direccion);
                                System.Console.WriteLine("Edad: " + usuario1.edad);

                                while(true){
                                System.Console.WriteLine("  Escojer una de las opciones  ");
                                System.Console.WriteLine("1. Playlist");
                                System.Console.WriteLine("2. Agregar pelicula");
                                System.Console.WriteLine("3. Atras");
                                int indice = Int32.Parse(Console.ReadLine());
                                


                                if (indice ==1){
                                    for (int i = 0; i < sumatoria; i++)
                                    {
                                    string valores = registro.lista[i];
                                    System.Console.WriteLine( num +" " + valores);
                                    num++;
                                    }
                                    num = 1;
                                    
                                }
                                if (indice ==2){
                                    while(true){
                                    System.Console.WriteLine("  Lista de Peliculas  ");
                                    for (int i = 0; i < contar; i++)
                                    {
                                        peliculas = lista2[i];
                                        System.Console.WriteLine( num +" " + peliculas.nombre);
                                        num++;
                                    }
                                    num = 1;
    
                                    System.Console.WriteLine("  Escojer la pelicula agregara  ");
                                    int escojer = Int32.Parse(Console.ReadLine());
                                    if(escojer==0){

                                        registro = new registro(usuario1.nombre,listaprueba);
                                        break;
                                        
                                    }
                                    
                                    else{
                                        peliculas = lista2[escojer-1];
                                        string peli = peliculas.nombre; 
                                        registro =new registro(usuario1.nombre,peli,sumatoria);
                                        lista3[sumatoria] = registro;
                                        sumatoria++;

                                    }

                                    for (int i = 0; i < sumatoria; i++)
                                    {
                                        registro=lista3[i];
                                        listaprueba[i] = registro.peliculas_usuario;
                                    }

                                    }

                                }
                                if (indice ==3){
                                    break;
                                }
                                else{
                                    System.Console.WriteLine("Escojer uno de los valores");
                                }
                                }


                            break; 
                            case 4:
                                System.Console.WriteLine("Vuelva Pronto");
                            break;                   
                            default:
                                System.Console.WriteLine("Escojer una de las opciones");
                            break;
                            }
                    }

                    break;
                case 2:
                    while(valor!=3){
                        System.Console.WriteLine("  Peliculas  ");
                        System.Console.WriteLine("Escojer una de las opciones");
                        System.Console.WriteLine("1. Ver peliculas");
                        System.Console.WriteLine("2. Agregar peliculas");
                        System.Console.WriteLine("3. Salir");

                        valor = Int32.Parse(Console.ReadLine());
                        switch(valor){
                            case 1: 
                            System.Console.WriteLine("  Lista de peliculas  ");
                                for (int i = 0; i < contar; i++)
                                {
                                    peliculas = lista2[i];
                                    System.Console.WriteLine( num +" " + peliculas.nombre);
                                    num++;
                                }
                                num = 1;
                            break;

                            case 2:
                                peliculas = new Peliculas();
                                lista2[contar] = peliculas;
                                contar++; 
                            break;

                            case 3:
                                System.Console.WriteLine("  Gracias por entrar  ");
                            break;
                            default:
                                System.Console.WriteLine("  Escojer una de las opciones  ");
                            break;
                        }
                    }
                    break;
                case 3:

                    System.Console.WriteLine("  Gracias por usar el programa  ");

                    break;
                default:
                    System.Console.WriteLine("  Escojer uno de los valores  ");

                    break;
                }
            }
        }
    }

    class Usuario{
        public string nombre;
        public string direccion;
        public int edad;

        public Usuario(string nombre, string direccion, int edad){
            this.nombre = nombre;
            this.direccion = direccion;
            this.edad = edad;
        }
        public Usuario(){
            System.Console.WriteLine("Escribir el Nombre del Usuario");
            nombre = Console.ReadLine();
                                            
            System.Console.WriteLine("Cliente Dirección");
            direccion = Console.ReadLine();

            System.Console.WriteLine("Edad Cliente");
            edad=Convert.ToInt32(Console.ReadLine());

        }
    }
    class Peliculas{
        public string nombre;
        public string tipo;
        public string genero;
        public string sinopsis;
        public Peliculas(string nombre, string tipo, string genero, string sinopsis){
            this.nombre = nombre;
            this.tipo = tipo;
            this.genero = genero;
            this.sinopsis = sinopsis;
        }

        public Peliculas(){
            System.Console.WriteLine("  Escribir el Nombre de la Pelicula  ");
            nombre = Console.ReadLine();
            System.Console.WriteLine("1. Escojer el Tipo de Pelicula  ");
            System.Console.WriteLine("2. Serie");
            System.Console.WriteLine("3. Pelicula");
            tipo = Console.ReadLine();
            System.Console.WriteLine("  Escojer el Genero de la pelicula  ");
            System.Console.WriteLine("1. Drama");
            System.Console.WriteLine("2. Comedia");
            System.Console.WriteLine("3. Terror");
            System.Console.WriteLine("4. Suspenso");
            genero =Console.ReadLine();
            System.Console.WriteLine("Escribir un Breve Resumen de la Pelicula");
            sinopsis = Console.ReadLine();

        }
    }

    class registro{
        public string nombre_usuario;

        public string peliculas_usuario;

        public int cantidad;

        public string[] lista;
        public registro(string nombre_usuario, string peliculas_usuario, int cantidad){
            this.nombre_usuario = nombre_usuario;
            this.peliculas_usuario =  peliculas_usuario;       
            this.cantidad = cantidad;     
        }

        public registro(string nombre_usuario,string[] lista){
            this.nombre_usuario = nombre_usuario;
            this.lista = lista;
        }
        
    }
}
