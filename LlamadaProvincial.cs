namespace CentralLlamadas{

    public class LlamadaProvincial : Llamada{

        private double precio1;
        private double precio2;
        private double precio3;
        private int franja;

        public double Precio1{
            get{return precio1;}
            set{precio1=value;}
        }
        public double Precio2{
            get{return precio2;}
            set{precio2=value;}
        }
        public double Precio3{
            get{return precio3;}
            set{precio3=value;}
        }
        public int Franja{
            get{return franja;}
            set{franja=value;}
        }
        public override double calcularPrecio(){
            double result=0;
            if(this.Franja==0){
                result=this.Precio1*this.Duracion;
            }
            else if(this.Franja==1){
                result=this.Precio2*this.Duracion;
            }
            else if(this.Precio3==2){
                result=this.Precio3*this.Duracion;
            }
            return result;
        }
    }
}