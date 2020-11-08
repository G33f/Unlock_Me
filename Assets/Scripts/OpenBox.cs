using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class OpenBox : MonoBehaviour
{
    public Transform target;
    public GameObject gO;
    public AudioSource audioSource;

    private void Start()
    {
        audioSource.Stop();
    }

    public void Click()
    {
        audioSource.Play();
        StartCoroutine(MoveBox(2));    
    }

    private IEnumerator MoveBox(float time)
    {
        Vector3 startingPos = gO.transform.position;
        Vector3 finalPos = new Vector3(gO.transform.position.x, gO.transform.position.y, gO.transform.position.z - 0.1f);
        float elapsedTime = 0;

        while (elapsedTime < time)
        {
            gO.transform.position = Vector3.Lerp(startingPos, finalPos, (elapsedTime / time));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        SceneManager.LoadScene("Video");
    }
}
