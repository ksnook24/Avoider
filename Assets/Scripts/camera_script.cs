using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_script : MonoBehaviour
{
    public player_controller pc;

    void Update()
    {
        this.transform.position = new Vector3(
            pc.transform.position.x,
            pc.transform.position.y,
            this.transform.position.z
            );
    }

}
