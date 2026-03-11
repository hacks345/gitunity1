using UnityEngine;
using System.Collections.Generic;

public class Damage : MonoBehaviour
{
    public void GetBumped()
    {
        Destroy(gameObject);
    }
}
