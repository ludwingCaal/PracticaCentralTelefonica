namespace CentralLlamadas{

    public class LlamadaLocal : Llamada{

        private double precio;

        public double Precio{
            get{return precio;}
            set{precio=value;}
        }
        public override double calcularPrecio(){
            return this.Precio*this.Duracion;
        }
    }
}