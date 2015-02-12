using UnityEngine;
using System.Collections;


public class StartAfterFade : MonoBehaviour
{
	public void Update()
	{
		StartCoroutine(LoadAfterDelay("Text"));
	}
	IEnumerator LoadAfterDelay(string levelName)
	{
		yield return new WaitForSeconds(12); // wait seconds
		Application.LoadLevel("NewLevel01");
	}
}
