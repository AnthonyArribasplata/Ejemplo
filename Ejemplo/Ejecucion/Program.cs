using Clases;
using System;

Cola cola_personas = new Cola();

cola_personas.EncolarPrioridad(new Persona("Juan", "+51987232322",0));
cola_personas.EncolarPrioridad(new Persona("Maria", "+51987232323",0));
cola_personas.EncolarPrioridad(new Persona("Pedro", "+51987232324",0));
cola_personas.EncolarPrioridad(new Persona("Ana", "+51987232325",1));

Console.WriteLine("Desencolando personas de la cola:");
Persona personaDesencolada;
while ((personaDesencolada = cola_personas.Desencolar()) != null)
{
    Console.WriteLine($"Nombre: {personaDesencolada.nombre}, Teléfono: {personaDesencolada.telefono}");
}   
