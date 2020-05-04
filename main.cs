using System;

class MainClass {
  public static void Main (string[] args) {
    int NUMERO1, NUMERO2, NUMERO3;
    string linea;

    Console.Write("primer numero: ");
    linea = Console.ReadLine();
    NUMERO1 = int.Parse(linea);
    Console.Write("segundo numero: ");
    linea = Console.ReadLine();
    NUMERO2 = int.Parse(linea);
    Console.Write("operacion: (1)suma (2)resta (3)multiplicación (4)división: ");
    linea = Console.ReadLine();
    NUMERO3 = int.Parse(linea);

    if (NUMERO3 == 1){
       int suma = suma2 (NUMERO1,NUMERO2);
       Console.WriteLine ("La suma es "+suma);
    }
    if (NUMERO3 == 2){
       int resta = resta2 (NUMERO1,NUMERO2);
       Console.WriteLine ("La resta es "+resta);
    }
    if (NUMERO3 == 3){
       int multiplicación = multiplicacion2 (NUMERO1,NUMERO2);
       Console.WriteLine ("La resta es "+multiplicación);
    }
    if (NUMERO3 == 4){
       int división = división2 (NUMERO1,NUMERO2);
       Console.WriteLine ("La resta es "+división);
    }
  }

  public static int suma2(int a, int b){
 
    int suma = a + b;
 
     return suma;
  }
  public static int resta2(int a, int b){
 
    int resta = a - b;
 
     return resta;
  }
  public static int multiplicacion2(int a, int b){
 
    int multiplicación = a * b;
 
     return multiplicación;
  }
  public static int división2(int a, int b){
 
    int división = a / b;
 
     return división;
  }

}