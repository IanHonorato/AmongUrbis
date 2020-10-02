using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.PlayerLoop;

public class Movement : MonoBehaviour
{
	public float _velocidade;
	public float _jumpforce;
	public Rigidbody playerbody;
	private Vector3 inputVector;

	void Start()
	{
		playerbody = GetComponent<Rigidbody>();
		_velocidade = 10.0F;
		_jumpforce = 5.0F;
	}

	void Update()
	{
		//mudar para getaxis
		inputVector = new Vector3(Input.GetAxis("Horizontal") * _velocidade, playerbody.velocity.y, Input.GetAxis("Vertical") * _velocidade);
		transform.LookAt(transform.position + new Vector3(inputVector.x, 0, inputVector.z));
		if (Input.GetKeyDown("space")) {
			playerbody.AddForce(0, _jumpforce, 0, ForceMode.Impulse);
		}

		playerbody.velocity = inputVector;
	}

	/*private void FixedUpdate() {
		playerbody.velocity = inputVector;
	}*/

}
