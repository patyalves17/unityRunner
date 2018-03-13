using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagemScript : MonoBehaviour {
	Vector3 novaPosicao;
	public float velocidade;
	public GameObject personagem;
	Animation ani;



	// Use this for initialization
	void Start () {
		//Capura a posicao inicial do prsonagem
		novaPosicao = transform.position;
		ani = personagem.GetComponent<Animation> ();

		//deine a animacao inicial
		ani.CrossFade("idle");
	}
	
	// Update is called once per frame
	void Update () {
		//touch ou clique do mouse
		if (Input.GetButton ("Fire1")) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			//obtem a nova posicao
			if (Physics.Raycast (ray, out hit)) {
				novaPosicao = hit.point;

			}
			//move o personagem
			transform.position = Vector3.MoveTowards (transform.position, novaPosicao, velocidade * Time.deltaTime);
			ani.CrossFade("run");
			transform.LookAt (hit.point);

		} else {
			//animacao de ile
			ani.CrossFade("idle");
		}



	}

	void OnCollisionEnter(Collision c){
		if(c.gameObject.tag == "item"){
			Destroy (c.gameObject);
		}
	}
}
