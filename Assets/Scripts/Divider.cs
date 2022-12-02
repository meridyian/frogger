using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Divider : MonoBehaviour
{
    public Score score;

    private void Start()
    {
        score.OnLevelEnd += CloseDividers;
    }

    private void CloseDividers()
    {
        gameObject.SetActive(false);
    }

}
