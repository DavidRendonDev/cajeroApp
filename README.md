# cajeroApp

🏦 Cajero Automático en Consola - C# + .NET

Este proyecto es una simulación de un cajero automático desarrollada en C# y .NET.
Permite al usuario interactuar con un menú de opciones para gestionar su dinero de manera sencilla desde la terminal.

✨ Funcionalidades

✅ Consultar saldo: muestra el saldo actual del usuario.
✅ Depositar dinero: permite ingresar un monto y sumarlo al saldo.
✅ Retirar dinero: permite retirar dinero solo si existe saldo suficiente.
✅ Salir: finaliza el programa con un mensaje de despedida.
✅ Avance de dinero (Extra):

El usuario puede pedir un monto como avance aunque no tenga saldo suficiente.

El saldo puede quedar en negativo solo a través de esta opción.

Si el saldo es menor a 0, se muestra un mensaje de advertencia de morosidad.

📋 Reglas de negocio

Saldo inicial: $1.000.000 COP

Retiro de dinero: no permite sobregiros.

Avance de dinero: permite saldo negativo.

Estado de moroso:

Si el saldo baja de 0, se muestra el mensaje:

🖥️ Ejemplo de uso
=== Cajero Automático ===
1. Consultar saldo
2. Depositar dinero
3. Retirar dinero
4. Salir
5. Avance de dinero
Seleccione una opción: 1

💰 Su saldo actual es: $1,000,000 COP

🚀 Instalación y ejecución

Clonar el repositorio o copiar el código:
git clone https://github.com/tuusuario/CajeroAutomatico.git
cd CajeroAutomatico

Crear un nuevo proyecto de consola en .NET (si no existe):

dotnet new console -n CajeroApp
cd CajeroApp

Reemplazar el contenido de Program.cs con el código del cajero.

Ejecutar el programa:

dotnet run


🛠️ Tecnologías utilizadas

Lenguaje: C#

Framework: .NET 6/7/

Entorno: Consola

📌 Créditos

Desarrollado por David Estevan Rendon Sanchez 👨‍💻
Proyecto académico para la asignatura de Programación en C# y .NET
