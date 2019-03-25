using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour {

	public float speed = 0.2f;
	private Renderer rend;

	void Start () {
		//pegar os componenter de renderer para poder alterar o offset
		rend = GetComponent <Renderer> ();
	}
	
	void Update () {
		//velocidade do movimento
		float offset = Time.time * speed;
		//alterando o offset no eixo y do material principal do cenário
		rend.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
	}
}
