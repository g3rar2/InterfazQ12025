using InterfazQ12025;

Operacion operacion = new Operacion();

Console.WriteLine("Ingrese Primer Numero");
operacion.N1 =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese Segundo Numero");
operacion.N2 = Convert.ToInt32(Console.ReadLine());

operacion.Imprimir();
