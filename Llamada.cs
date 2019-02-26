namespace CentralLlamadas{

    public abstract class Llamada{

        private string numOrigen;
        private string numDestino;
        private double duracion;

        public string NumOrigen{
            get{return numOrigen;}
            set{numOrigen=value;}
        }

        public string NumDestino{
            get{return numDestino;}
            set{numDestino=value;}
        }

        public double Duracion{
            get{return duracion;}
            set{duracion=value;}
        }

        public abstract double calcularPrecio();
        
        public override string ToString(){
            return $"#Origen: {this.numOrigen} - #Destino: {this.numDestino} -Duracion: {this.duracion}";
        } 
    }
}