using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class ChickenGFX : MonoBehaviour
{
   public AIPath path;
    public SpriteRenderer renderer;
    

    // Update is called once per frame
    void Update()
    {
        if (path.desiredVelocity.x >= 0.01f)
        {
            renderer.flipX = true;
        }
        else if (path.desiredVelocity.x <= -0.01f)
        {
            renderer.flipX = false;
        }
    }
}
