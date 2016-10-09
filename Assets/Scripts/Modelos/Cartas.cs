using System.Collections;
using System.Collections.Generic;

namespace Modelos
{

	enum Palos
	{
		Trebol,
		Diamante,
		Corazon,
		Espada
	}

	public class Cartas {
		private int numero_Carta;
		private Palos palo;
		string[] nombrePalo = {"clubs","diamonds","hearts","spades"};

		public Cartas(Palos paloCarta, int numero)
		{
			numero_Carta = numero;
			palo = paloCarta;
		}

		public int Numero_Carta {
			get {numero_Carta;}
			set {numero_Carta = value;}
		}

		public Palos Palo {
			get {palo;}
			set {palo = value;}
		}

		public override string ToString() {
			return "card_" + nombrePalo[(int)palo] + "_" + numero_Carta;
		}

	}



}