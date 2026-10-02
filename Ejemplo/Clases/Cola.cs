namespace Clases;

public class Cola
{
    public Nodo frente=null;
    public Nodo final=null;

    public void Encolar(Persona p)
    {
        Nodo nuevoNodo = new Nodo();
        nuevoNodo.dato = p;

        if (frente == null)
        {
            frente = nuevoNodo;
        }
        else
        {
            final.sig = nuevoNodo;
        }
        final = nuevoNodo;
    }
    public void EncolarPrioridad(Persona p)
    {
        Nodo nuevoNodo = new Nodo();
        nuevoNodo.dato = p;

        if (frente == null)
        {
            frente = nuevoNodo;
            final = nuevoNodo;
        } 
        else 
        {
            if(p.prioridad == 1)
            {
                //ubicar a la persona con prioridad al frente de la cola
                nuevoNodo.sig = frente;
                frente = nuevoNodo;
            }
            else
            {
                final.sig = nuevoNodo;
                final = nuevoNodo;
            }
        }
    }

    public Persona Desencolar()
    {
        if (frente == null)
        {
            return null;
        }
        else
        {
            Persona p = frente.dato;
            frente = frente.sig;
            if (frente == null)
            {
                final = null;
            }
            return p;
        }
    }
}