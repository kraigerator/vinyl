using UnityEngine;
using System.Collections;
using System;

public class CubeListener : MonoBehaviour 
{

    public void MyPointerEnter()
    {
        GetComponent<Renderer>().material.color = Color.red;
        //this.gameObject.scene.
        //foreach (Transform child in transform)
        //  child.position += Vector3.up * 10.0F;
        //transform.Rotate(new Vector3(0, 0, 0), 45);
        // transform.Rotate(Vector3.up * 30 * Time.deltaTime);



        if (this.gameObject.name.StartsWith("Kind", StringComparison.OrdinalIgnoreCase))
        {
            if (GameObject.Find("AudioLeft").GetComponent<AudioSource>().tag == "1")
                return;
            GameObject.Find("AudioLeft").GetComponent<AudioSource>().clip = Resources.Load("miles-l") as AudioClip;
            GameObject.Find("AudioLeft").GetComponent<AudioSource>().Play();
            GameObject.Find("AudioRight").GetComponent<AudioSource>().clip = Resources.Load("miles-r") as AudioClip;
            GameObject.Find("AudioRight").GetComponent<AudioSource>().Play();

            GameObject.Find("AudioLeft").GetComponent<AudioSource>().tag = "1";
        }
        else if (this.gameObject.name.StartsWith("Black", StringComparison.OrdinalIgnoreCase))
        {
            if (GameObject.Find("AudioLeft").GetComponent<AudioSource>().tag == "2")
                return;
            GameObject.Find("AudioLeft").GetComponent<AudioSource>().clip = Resources.Load("bowie-l") as AudioClip;
            GameObject.Find("AudioLeft").GetComponent<AudioSource>().Play();
            GameObject.Find("AudioRight").GetComponent<AudioSource>().clip = Resources.Load("bowie-r") as AudioClip;
            GameObject.Find("AudioRight").GetComponent<AudioSource>().Play();

            GameObject.Find("AudioLeft").GetComponent<AudioSource>().tag = "2";
        }
        else if (this.gameObject.name.StartsWith("Abstract", StringComparison.OrdinalIgnoreCase))
        {
            if (GameObject.Find("AudioLeft").GetComponent<AudioSource>().tag == "3")
                return;
            GameObject.Find("AudioLeft").GetComponent<AudioSource>().clip = Resources.Load("guides-l") as AudioClip;
            GameObject.Find("AudioLeft").GetComponent<AudioSource>().Play();
            GameObject.Find("AudioRight").GetComponent<AudioSource>().clip = Resources.Load("guides-r") as AudioClip;
            GameObject.Find("AudioRight").GetComponent<AudioSource>().Play();

            GameObject.Find("AudioLeft").GetComponent<AudioSource>().tag = "3";
        }
        else if (this.gameObject.name.StartsWith("Awake", StringComparison.OrdinalIgnoreCase))
        {
            if (GameObject.Find("AudioLeft").GetComponent<AudioSource>().tag == "4")
                return;
            GameObject.Find("AudioLeft").GetComponent<AudioSource>().clip = Resources.Load("tycho-l") as AudioClip;
            GameObject.Find("AudioLeft").GetComponent<AudioSource>().Play();
            GameObject.Find("AudioRight").GetComponent<AudioSource>().clip = Resources.Load("tycho-r") as AudioClip;
            GameObject.Find("AudioRight").GetComponent<AudioSource>().Play();

            GameObject.Find("AudioLeft").GetComponent<AudioSource>().tag = "4";
        }

        //transform.Rotate(Vector3.up * 60 * Time.deltaTime);

        //GetComponent<AudioSource>
    }

    public void MyPointerLeave ()
	{
		GetComponent<Renderer>().material.color = Color.white;
	}
}
