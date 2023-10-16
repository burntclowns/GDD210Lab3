using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolkyPolky : MonoBehaviour
{
	public float Speed;


	private void Update()
	{
		//turn yourself around!
		transform.Rotate(new Vector3(0, 30*Speed, 0) * Time.deltaTime);
	}
}
