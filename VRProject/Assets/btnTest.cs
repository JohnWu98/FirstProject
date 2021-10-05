using HTC.UnityPlugin.Vive;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnTest : MonoBehaviour {

	public Transform righthandPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ViveInput.GetPressDown(HandRole.RightHand, ControllerButton.Trigger))
		{
			GameObject tempGo = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			tempGo.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			tempGo.transform.position = righthandPos.position;
			Debug.Log("Trigger");
		}
	}

	public void BtnOnclick()
	{
		Debug.Log("按钮被点击");
	}
}
