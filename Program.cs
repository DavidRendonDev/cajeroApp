using System;

class Program
{
    static void Main(string[] args)
    {
        // Saldo inicial
        decimal saldo = 1000000m;
        int opcion = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("=== Cajero Automático ===");
            Console.WriteLine("1. Consultar saldo");
            Console.WriteLine("2. Depositar dinero");
            Console.WriteLine("3. Retirar dinero");
            Console.WriteLine("4. Salir");
            Console.WriteLine("5. Avance de dinero");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"💰 Su saldo actual es: ${saldo:N0} COP");
                        break;

                    case 2:
                        Console.Write("Ingrese el monto a depositar: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal deposito) && deposito > 0)
                        {
                            saldo += deposito;
                            Console.WriteLine($"✅ Depósito exitoso. Nuevo saldo: ${saldo:N0} COP");
                        }
                        else
                        {
                            Console.WriteLine("⚠️ Monto inválido.");
                        }
                        break;

                    case 3:
                        Console.Write("Ingrese el monto a retirar: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal retiro) && retiro > 0)
                        {
                            if (retiro <= saldo)
                            {
                                saldo -= retiro;
                                Console.WriteLine($"✅ Retiro exitoso. Nuevo saldo: ${saldo:N0} COP");
                            }
                            else
                            {
                                Console.WriteLine("⚠️ Fondos insuficientes. No puede retirar más de su saldo.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("⚠️ Monto inválido.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("👋 Gracias por usar el cajero automático. ¡Hasta pronto!");
                        break;

                    case 5:
                        Console.Write("Ingrese el monto del avance: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal avance) && avance > 0)
                        {
                            saldo -= avance; // Se descuenta, generando posible saldo negativo
                            Console.WriteLine($"💳 Avance realizado. Nuevo saldo: ${saldo:N0} COP");

                            // Mensaje de advertencia si el saldo queda negativo
                            if (saldo < 0)
                            {
                                Console.WriteLine("⚠️ Saldo negativo, recuerda pagar el avance anteriormente realizado.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("⚠️ Monto inválido.");
                        }
                        break;

                    default:
                        Console.WriteLine("⚠️ Opción no válida, intente de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("⚠️ Entrada no válida. Por favor ingrese un número del 1 al 5.");
            }

            if (opcion != 4)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 4);
    }
}
