using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class API : MonoBehaviour 
{
	private const string URL = "http://openapi.airkorea.or.kr/openapi/services/rest/ArpltnInforInqireSvc/getMinuDustFrcstDspth?searchDate=2017-04-19&ServiceKey=KD9z5m4PSjedJaRquWlGpAlJ5LFEFHhvN1c2mSI9TgkZKBjewHTtvvKz66c6ms99P09gzaIXEatfs8o4s7fjcA%3D%3D";
	private const string API_KEY = "KD9z5m4PSjedJaRquWlGpAlJ5LFEFHhvN1c2mSI9TgkZKBjewHTtvvKz66c6ms99P09gzaIXEatfs8o4s7fjcA%3D%3D";
	public Text responseText;

	public void Request()
	{
		WWW request = new WWW(URL);
		StartCoroutine(OnResponse(request));


	}

	private IEnumerator OnResponse(WWW req)
	{
		yield return req;
		responseText.text = req.text;
	}




}
