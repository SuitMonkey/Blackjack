using UnityEngine;
using System.Collections;

namespace Modelos 
{
	enum Palo
	{
		Trebol,
		Diamante,
		Corazon,
		Espada
	}

	public class Cartas : MonoBehaviour {
		Palo palo;

		public Cartas(Palo palo)
		{

		}

	}

}