using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class StartTimeLine : MonoBehaviour
{
    // Start is called before the first frame update
    private PlayableDirector playableDirector;
    void Start()
    {
        playableDirector = FindAnyObjectByType<PlayableDirector>();
         playableDirector.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
