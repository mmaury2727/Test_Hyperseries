using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScreen : MonoBehaviour
{
    bool isFullScreen;

    [SerializeField] GameObject player;
    private Vector3 strartPos;

    // Start is called before the first frame update
    void Start()
    {
        //Vector3 startPos = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fullScreenClicked()
    {
        if (!isFullScreen)
        {
            player.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, -90f));
            //player.transform.localScale = new Vector3(1.784512f, 1.784512f, 1.784512f);
            player.transform.localScale = new Vector3(1.82f, 1.82f, 1.82f);
            player.transform.position = new Vector3(-190, 565, 0);
            isFullScreen = true;
        } else
        {
            player.transform.position = new Vector3(320, 608, 0);
            player.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 0));
            player.transform.localScale = new Vector3(1f, 1f, 1f);
            isFullScreen = false;
        }

    }
}
