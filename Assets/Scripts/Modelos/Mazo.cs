using System.Collections.Generic;
using Modelos.Cartas;

namespace Modelos {
	public class Mazo {

		public List<object> cartas;
		public int indice;

		public Mazo(List<Cartas> cartas, int indice){
			cartas = new List<Cartas> ();
			this.indice = indice;
			crearMazo ();
		}

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {

		}

		//Esta funcion es para barajar las cartas
		//Este metodo recibe las barajas
		public void barajar(List<Cartas> cartas){

		}

		public object reparatir(){

		}

		public List<Cartas> Cartas{
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
				Cartas carta = new Cartas ();
				if(i >= 1 && i <= 13 ){
					cartas.Add(carta);
				}
				if (i >= 14 && i <= 27) {
					cartas.Add (carta);
				}
				if (i >= 28 && i <= 41) {
					cartas.Add (cartas);
				}
				if(i>= 42 && i <= 52){
					cartas.Add (cartas);
				}

			}

		}

	}
}