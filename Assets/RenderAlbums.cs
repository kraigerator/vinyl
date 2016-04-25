using UnityEngine;
using System.Collections;
using LitJson;
using System.Collections.Generic;
using UnityEngine.UI;

public class Album
{
	public string id { get; set; }
	public string name { get; set; }
	public string coverArt { get; set; }
	//public List<Track> tracks;

}

public class Track {
	public string id { get; set; }
	public string name { get; set; }
	public string trackName { get; set; }
	public string discNumber { get; set; }
	public string previewUrl { get; set; }
}

public class RenderAlbums : MonoBehaviour {
	public GameObject albumCoverPrefab;
	public GameObject[] albumCovers;

	// Use this for initialization
	IEnumerator Start () {
		string url = "https://vinyl-backend.herokuapp.com/spotify/albums";
		WWW www = new WWW(url);
		yield return www;

		if (www.error == null)
		{
			Process(www.text);
		}
		else
		{
			Debug.Log("ERROR: " + www.error);
		}
	}

	IEnumerator DownloadImage(GameObject go, string name, string url)
	{
		WWW www = new WWW(url);
		yield return www;

		Debug.Log (go.name);

		if (go.name == name) {

			go.GetComponent<Renderer> ().material.mainTexture = www.texture;
		}
	}

	private void Process(string json)
	{
		Album[] albums = JsonMapper.ToObject<Album[]>(json);

		if (albumCovers == null) {

			albumCovers = GameObject.FindGameObjectsWithTag ("Album");
		}

		for (int i = 0; i < albums.Length; i++) {

			StartCoroutine(DownloadImage(this.gameObject, albums[i].name, albums[i].coverArt));

		}

		Debug.Log (albumCovers.Length.ToString());


	}
}