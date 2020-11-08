using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class RandomVideo : MonoBehaviour
{
    public VideoClip[] videoClips;
    public VideoPlayer videoPlayer;
    void Start()
    {
        videoPlayer.clip = videoClips[Random.Range(0, 7)];
        Cursor.visible = true;
    }
}
