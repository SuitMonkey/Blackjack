using System.Collections.Generic;
using Modelos.Cartas;
using UnityEngine;

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
			int n = cartas.Count;
			while (n > 1) {
				n--;
				int rnd = Random.Range (1, 53);
				Cartas temp = cartas [rnd];
				cartas [rnd] = cartas [n];
				cartas [n] = temp;
			}
		}

		public Cartas reparatir(List<Cartas> cartas){
			Cartas carta = new Modelos.Cartas ();
			carta = cartas [cartas.LastIndexOf];
			cartas.Remove(cartas.LastIndexOf);

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
			for(int i = 0; i<=52 ;i++){

				if(i >= 1 && i <= 14 ){
					Cartas carta = new Cartas (Palos.Corazon,((i==13 )? 13:i%13));
					cartas.Add(cartas);
				}
				if (i > 14 && i <= 26) {
					Cartas carta = new Cartas (Palos.Corazon,((i==26 )? 13:i%13));
					cartas.Add (carta);
				}
				if (i > 26 && i <= 39) {
					Cartas carta = new Cartas (Palos.Corazon,((i==39 )? 13:i%13));
					cartas.Add (cartas);
				}
				if(i > 39 && i <= 52){
					Cartas carta = new Cartas (Palos.Corazon,((i==52 )? 13:i%13));
					cartas.Add (cartas);
				}

			}

		}

	}
}