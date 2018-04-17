using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class coun : MonoBehaviour 
{
	public Text countText;
	public Text winText;
	public Text myTime;

	int count;
	DateTime curr;

	void Start () 
	{
		count = 0;

		countText.text="分數";
		winText.text = "";

		curr = DateTime.Now;
		myTime.text = "10";
	}

	void Update () 
	{
		TimeSpan ts = DateTime.Now - curr;

		if (ts.Seconds < 10)
			myTime.text = (10 - ts.Seconds).ToString() + ":" + (1000 - ts.Milliseconds).ToString();
		else
		{
			myTime .text= "0:0";
			winText.text = "You Lose!";
		}

	}

	void OnTriggerEnter(Collider other)
	{
		count++;
		showText ();
	}

	void showText()
	{
		countText.text = "分數" + count;

		if (count >= 4)
			winText.text = "YOU WIN";
	}
}
