using System;
using System.Collections.Generic;

namespace CentralLlamadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Llamada llamadaDpto = new LlamadaProvincial();
            llamadaDpto.NumDestino="123";
            llamadaDpto.NumOrigen="456";
            ((LlamadaProvincial)llamadaDpto).Franja=0;
            llamadaDpto.Duracion=10;
            ((LlamadaProvincial)llamadaDpto).Precio1=1.5;

            Llamada llamadaLocal= new LlamadaLocal();
            llamadaDpto.NumDestino="789";
            llamadaDpto.NumOrigen="135";
            llamadaLocal.Duracion=5;
            ((LlamadaLocal)llamadaLocal).Precio=0.96;

            Llamada otraLlamada= new LlamadaLocal();
            otraLlamada.NumDestino="111";
            otraLlamada.NumOrigen="222";
            otraLlamada.Duracion=25;
            ((LlamadaLocal)otraLlamada).Precio=0.96;

            List<Llamada> llamadasRealizadas= new List<Llamada>();

            llamadasRealizadas.Add(llamadaDpto);
            llamadasRealizadas.Add(llamadaLocal);
            llamadasRealizadas.Add(otraLlamada);

            foreach (Llamada item in llamadasRealizadas)
            {
                if(item is LlamadaProvincial){
                    Console.WriteLine($"Llamada Departamental ({item}) Precio : {item.calcularPrecio()}");
                }
                else if(item is LlamadaLocal){
                    Console.WriteLine($"Llamada Local ({item}) Precio : {item.calcularPrecio()}");
                }
                
            }
            Console.ReadKey();
        }
    }
}
