using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    int _score;

  public void AddPoint()
    {
        _score++;
        var text = GetComponent<TMP_Text>();
        text.SetText(_score.ToString());
    }
}
