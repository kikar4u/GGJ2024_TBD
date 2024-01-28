using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class endScore : MonoBehaviour
{
    private void OnEnable()
    {
        GetComponent<TMP_Text>().text = GameManager.Instance.GetScore().ToString();
    }
}
