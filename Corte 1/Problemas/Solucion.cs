using System;

namespace Problemas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0,opci = 0;
            decimal num = 0,num1 = 0,num2 = 0,num3 =0,prome = 0;
            string entrada ="",Nom1 ="",Nom2 ="",Nom3 ="",a="a",e="e",i="i",o="o",u="u",A="A",E="E",I="I",O="O",U="U";
            double res,nu = 0;
            bool resul,symb;
            char letra;            


            Console.WriteLine("Menu");
            Console.WriteLine("1.Valor Absoluto");
            Console.WriteLine("2.Precio Peliculas");
            Console.WriteLine("3.Calificaciones");            
            Console.WriteLine("4.Conjetura de Collatz");
            Console.WriteLine("5.Raiz Cuadrada");
            Console.WriteLine("6.Periodo de Tiempo");
            Console.WriteLine("7.Venta de Productos");
            Console.WriteLine("8.Caracteres");
            Console.WriteLine("9.Edad de un Perro");
            Console.WriteLine("10.Verificar Contraseña");


            Console.WriteLine("Ingrese Opcion");
            opc = Convert.ToInt32(Console.ReadLine());
            switch(opc)
            {
                case 1: 
                    
                    Console.WriteLine("Valor absoluto");
                    Console.WriteLine("Ingrese un numero:");
                    entrada = Console.ReadLine();
                    num = Convert.ToDecimal(entrada);

                    if (num>0)
                    {
                        Console.WriteLine("El valor absoluto es {0}",num);
                    }else
                    {
                        num1 = -1 * num;
                        Console.WriteLine("El valor absoluto es {0}",num1);
                    }

                break;
                case 2:

                    Console.WriteLine("Precio Peliculas");
                    Console.WriteLine("Numero de peliculas");
                    opci = Convert.ToInt32(Console.ReadLine());

                    if (opci>3)
                    {
                        Console.WriteLine("Promocion peliculas");
                        Console.WriteLine("Precio pelicula de menos valor #1");
                        entrada = Console.ReadLine();
                        num = Convert.ToDecimal(entrada);
                        Console.WriteLine("Precio pelicula de menos valor #2");
                        entrada = Console.ReadLine();
                        num1 = Convert.ToDecimal(entrada);

                        num2 = (num1 + num) / 2;
                        Console.WriteLine("Debe cancelar {0}",num2);                                               
                    }else
                    {
                        Console.WriteLine("Precio pelicula #1");
                        entrada = Console.ReadLine();
                        num = Convert.ToDecimal(entrada);
                        Console.WriteLine("Precio pelicula #2");
                        entrada = Console.ReadLine();
                        num1 = Convert.ToDecimal(entrada);

                        num2 = num1 + num;
                        Console.WriteLine("Debe cancelar {0}",num2);
                    }
                break;
                case 3:
                    Console.WriteLine("Calificaciones");
                    
                    Console.WriteLine("Calificación #1");
                    num = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Calificación #2");
                    num1 = decimal.Parse(Console.ReadLine());                    
                    
                    Console.WriteLine("Calificación #3");
                    num2 = decimal.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Calificación #4");
                    num3 = decimal.Parse(Console.ReadLine());
                    
                    if (num>num1 && num>num2 && num>num3)
                    {
                        Console.WriteLine("La calificación mas alta es {0}",num);
                        if (num1>num2 && num1>num3)
                        {
                            if (num2>num3)
                            {
                                Console.WriteLine("La calificación mas baja es {0}",num3);
                            }else
                            {
                                Console.WriteLine("La calificación mas baja es {0}",num2);
                            }
                        }else
                        {
                          if (num2>num1 && num2>num3)
                          {
                              if (num1>num3)
                              {
                                Console.WriteLine("La calificación mas baja es {0}",num3);
                              }else
                              {
                                Console.WriteLine("La calificación mas baja es {0}",num1);
                              }
                          }else
                          {
                             if (num3>num1 && num3>num2)
                             {
                                 if (num1>num2)
                                 {
                                    Console.WriteLine("La calificación mas baja es",num2);    
                                 }else
                                 {
                                    Console.WriteLine("La calificación mas baja es",num1); 
                                 }
                             } 
                          }
                        } 
                    }else
                    {
                        if (num1>num && num1>num2 && num1>num3)
                        {
                            Console.WriteLine("La calificación mas alta es {0}",num1);
                            if (num>num2 && num>num3)
                            {
                                if (num2>num3)
                                {
                                    Console.WriteLine("La calificación mas baja es {0}",num3);
                                }else
                                {
                                    Console.WriteLine("La calificación mas baja es {0}",num2);
                                }
                            }else
                            {
                                if (num2>num && num2>num3)
                                {
                                    if (num>num3)
                                    {
                                        Console.WriteLine("La calificación mas baja es {0}",num3);
                                    }else
                                    {
                                        Console.WriteLine("La calificación mas baja es {0}",num);
                                    }
                                }else
                                {
                                    if (num3>num && num3>num2)
                                    {
                                        if (num>num2)
                                        {
                                            Console.WriteLine("La calificación mas baja es",num2);    
                                        }else
                                        {
                                            Console.WriteLine("La calificación mas baja es",num);
                                        }
                                    } 
                                }
                            } 
                        }else
                        {
                            if  (num2>num && num2>num1 && num2>num3)
                            {                      
                                Console.WriteLine("La calificación mas alta es {0}",num2);
                                if (num>num1 && num>num3)
                                {
                                    if (num1>num3)
                                    {
                                        Console.WriteLine("La calificación mas baja es",num3);
                                    }else
                                    {
                                        Console.WriteLine("La calificación mas baja es",num1);
                                    }
                                }else
                                {
                                    if (num1>num && num1>num3)
                                    {
                                        if (num>num3)
                                        {
                                            Console.WriteLine("La calificación mas baja es {0}",num3);
                                        }else
                                        {
                                            Console.WriteLine("La calificación mas baja es {0}",num);
                                        }
                                    }else
                                    {
                                        if (num3>num && num3>num1)
                                        {
                                            if (num>num2)
                                            {
                                                Console.WriteLine("La calificación mas baja es {0}",num2);    
                                            }else
                                            {
                                                Console.WriteLine("La calificación mas baja es {0}",num);
                                            }
                                        } 
                                    }
                                }
                            }else
                            {
                                if  (num3>num && num3>num1 && num3>num2)
                                {                      
                                    Console.WriteLine("La calificación mas alta es {0}",num2);
                                    if (num>num1 && num>num2)
                                    {
                                        if (num1>num2)
                                        {
                                            Console.WriteLine("La calificación mas baja es {0}",num2);
                                        }else
                                        {
                                            Console.WriteLine("La calificación mas baja es {0}",num1);
                                        }
                                    }else
                                    {
                                        if (num1>num && num1>num2)
                                        {
                                            if (num>num2)
                                            {
                                                Console.WriteLine("La calificación mas baja es {0}",num2);
                                            }else
                                            {
                                                Console.WriteLine("La calificación mas baja es {0}",num);
                                            }
                                        }else
                                        {
                                            if (num2>num && num2>num1)
                                            {
                                                if (num>num1)
                                                {
                                                Console.WriteLine("La calificación mas baja es {0}",num1);    
                                                }else
                                                {
                                                    Console.WriteLine("La calificación mas baja es {0}",num);
                                                }
                                            }   
                                        }
                                    }
                                }
                            
                        
                                                  
                        
                            }
                        }                         
                    }     
                    prome =(num+num1+num2+num3)/4;
                    Console.WriteLine("El promedio es {0}",prome);    
                    
                    
                    
                break;
                case 4:

                    Console.WriteLine("Conjetura de Collatz");
                    Console.WriteLine("Ingrese un numero");
                    opci = Int32.Parse(Console.ReadLine());
                    while (opci>1)
                    {
                        if (opci%2 == 0)
                        {
                            opci = opci / 2;
                        }else
                        {
                            opci = opci * 3 + 1;
                        }
                        Console.WriteLine("{0}",opci);
                    }

                break;
                case 5:
                
                    Console.WriteLine("Raiz Cuadrada");
                    Console.WriteLine("Ingrese un numero");
                    nu = Int32.Parse(Console.ReadLine());

                    if (nu>0)                                       
                    {
                        res = Math.Sqrt(nu);
                        Console.WriteLine("El resultado es {0}",res);
                    }else
                    {
                        Console.WriteLine("Ingreso un numero negativo");
                        Console.WriteLine("No se puede realizar la raiz cuadrada");
                    }  
                break;
                case 6:
                    Console.WriteLine("Periodo de Tiempo");
                    Console.WriteLine("Ingrese un entero");
                    num = decimal.Parse(Console.ReadLine());

                    if (num>60)
                    {
                        num = num / 60;
                        if (num>1)
                        {
                            opci = (int) num;
                            num1 = num - opci ;
                            Console.WriteLine("Son {0} horas y {1} minutos",opci,num1);
                        }

                    }
                break;
                case 7:
                    Console.WriteLine("Ventas");
                    Console.WriteLine("Resumen de ventas");
                    Console.WriteLine("Ingrese Nombre del producto");
                    Nom1 = Console.ReadLine();
                    Console.WriteLine("Ingrese ventas de {0}",Nom1);
                    num = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese Nombre del producto");
                    Nom2 = Console.ReadLine();
                    Console.WriteLine("Ingrese ventas de {0}",Nom2);
                    num1 = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese Nombre del producto");
                    Nom3 = Console.ReadLine();
                    Console.WriteLine("Ingrese ventas de {0}",Nom3);
                    num2 = decimal.Parse(Console.ReadLine());

                    if (num>num1 && num>num2)
                    {
                        Console.WriteLine("Las ventas del producto {0} son las más elevadas.",Nom1);                        
                    }
                    if (num1>num && num1>num2)
                    {
                        Console.WriteLine("Las ventas del producto {0} son las más elevadas.",Nom2);                        
                    }
                    if (num2>num1 && num2>num)
                    {
                        Console.WriteLine("Las ventas del producto {0} son las más elevadas.",Nom3);                        
                    }

                    if (200<=num && 200<=num1 && 200<=num2)
                    {
                        Console.WriteLine("Ningún producto tiene unas ventas inferiores a 200.");    
                    }
                    
                    if (num>=400)
                    {
                        Console.WriteLine("Algún producto tiene unas ventas superiores a 400.");
                    }else
                    {
                        if (num1>=400)
                        {
                            Console.WriteLine("Algún producto tiene unas ventas superiores a 400.");    
                        }else
                        {
                            if (num2>=400)
                            {
                                Console.WriteLine("Algún producto tiene unas ventas superiores a 400.");
                            }
                        }
                    }

                    num3 = num + num1 + num2;
                    prome = num3 / 3;
                                        
                    if (prome>500)
                    {
                        Console.WriteLine("La media de ventas es superior a 500.");
                    }

                    if (num<num1 && num<num2)
                    {
                        Console.WriteLine("El producto {0} no es el más vendido.",Nom1);
                                                
                    }
                    if (num1<num && num1<num2)
                    {
                        Console.WriteLine("El producto {0} no es el más vendido.",Nom2);                        
                    }
                    if (num2<num1 && num2<num)
                    {
                        Console.WriteLine("El producto {0} no es el más vendido.",Nom3);                        
                    }
                    if (num3>=500)
                    {
                        if (num3<=1000)
                        {
                            Console.WriteLine("El total de ventas esta entre 500 y 1000.");
                        }
                        
                    }
                break;
                case 8:
                    Console.WriteLine("Caracteres");
                    Console.WriteLine("Ingrese un caracter:");
                    entrada = Console.ReadLine();
                    letra = char.Parse(entrada);
                    resul = Char.IsLower(letra);
                    symb = char.IsSymbol(letra);
                    
                    
                    if (entrada == a && entrada == e && entrada == i && entrada == o && entrada == u && entrada == A && entrada == E && entrada == I && entrada == O && entrada == U)
                    {
                        Console.WriteLine("{0} es una vocal",entrada);
                    }
                    
                    if (resul == true)
                    {
                        Console.WriteLine("{0} es una letra minuscula",letra);
                    }
                    if (symb == true)
                    {
                        Console.WriteLine("{0} es un simbolo del alfabeto",letra);
                    }
                    
                break;
                case 9:
                    Console.WriteLine("Edad de un perro");
                    Console.WriteLine("Ingrese la edad:");
                    num1 = decimal.Parse(Console.ReadLine());
                    if (num1 >2)
                    {
                        num2 = num1 - 2;
                        num3 = num2 * 4;
                        num = num3 + 10 +1/2;
                        Console.WriteLine("La edad de su perro es: {0}",num);

                    }else
                    {
                        num2 = num1 *(5+1/4);
                        Console.WriteLine("La edad de su perro es: {0}",num2);
                    }
                break;
                case 10:
                    do
                    {
                        String contra = "iloveyou123";
                        Console.WriteLine("Bienvenido");
                        Console.WriteLine("Ingrese la contraseña:");
                        entrada = Console.ReadLine();

                        if (entrada == contra)
                        {
                            num2 = 3;                            
                            Console.WriteLine("Contraseña correcta");
                            Console.WriteLine("Bienvenido");
                        }else
                        {
                            num2=num2+1;
                            if (num2==3)
                            {
                                Console.WriteLine("Excedio los intentos");
                            }
                        }

                    }while(num2<3);
                break;

                

            }
        }
    }    
}
