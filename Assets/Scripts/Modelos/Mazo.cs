using System.Collections.Generic;

namespace Modelos {
	public class Mazo {

		public List<object> cartas;
		public int indice;

		public Mazo(List<object> cartas, int indice){
			cartas = new List<object> ();
			this.indice = indice;
		}

		// Use this for initialization
		void Start () {
			
		}
	
		// Update is called once per frame
		void Update () {
	
		}

		//Esta funcion es para barajar las cartas
		//Este metodo recibe las barajas
		public void barajar(List<object> cartas){
			
		}

		public object reparatir(){
		
		}

		public List<object> Cartas{
			get { return cartas;}
			set { cartas = value;}
		}

		public int Indice {
			get { return indice; }
			set { indice = value; }
		}

		private void crearMazo(){
			int contador = 0;
			for(int i = 1; i<=52 ;i++){
				contador = i;

			}

		}

	}
}