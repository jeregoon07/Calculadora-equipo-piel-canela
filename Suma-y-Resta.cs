//Esta es la parte de Suma y Resta 
//Tambien ya hago la parte de interaccion con el usuario
//Al momento de hacer las funciones me guie por las ya echas en el Readme

//Bucle para que siga abierta la calculadora
int funcion = 0;
while (funcion != 5)
{    
    //Interaccion
    Console.WriteLine("Hola como estas? Esta es la calculadora del equipo Piel Canela,\n porfavor elige la funcion que desear utilizar: \n 1) Suma \n 2) Resta \n 3) Multiplicacion \n 4) Division \n 5)Salir");
    funcion=int.Parse(Console.ReadLine());
    //Suma
    if (funcion == 1)
    {
        Console.Write("Ingrese el valor de a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el valor de b: ");
        int b = int.Parse(Console.ReadLine());
        int resultado = a + b;
        Console.WriteLine($"El resultado de la suma es: {resultado} ");
    }
    //Resta
    if (funcion == 2)
    {
        Console.Write("Ingrese el valor de a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el valor de b: ");
        int b = int.Parse(Console.ReadLine());
        int resultado = a - b;
        Console.WriteLine($"El resultado de la resta es: {resultado} ");
    }
    //Chau
    if (funcion == 5);
    {
        Console.WriteLine("Fue un placer");
    }
}    