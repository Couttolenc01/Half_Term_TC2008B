using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This FollowPlayer class will follow the vehicle player by the main camera.
/// Standar coding documentarion can be found in 
/// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/documentation-comments
/// </summary>


public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    
   
    /// <summary>
    /// Start is called before the first frame update
    void Start()
    {
        
    }
    /// </summary>


    /// <summary>
    /// This method is called once per frame, after Update method is called.
    void LateUpdate()
    {
        transform.position = player.transform.position + new Vector3(0,6,-7);
      
    }
    /// </summary>
}
