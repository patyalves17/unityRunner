using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerarAboborasScript : MonoBehaviour {

	public float limiteEsquerdo, limiteDiretiro, limteFronal, limiteTraseiro;
	public float frequencia;
	public GameObject aboboraPrefab;

	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds (Random.Range(0.5f, frequencia));
		Vector3 posicao;
		posicao.x = Random.Range (limiteEsquerdo, limiteDiretiro);
		posicao.y = transform.position.y;
		posicao.z = Random.Range (limteFronal, limiteTraseiro);
		Instantiate (aboboraPrefab, posicao, transform.rotation);
		StartCoroutine (Start());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
