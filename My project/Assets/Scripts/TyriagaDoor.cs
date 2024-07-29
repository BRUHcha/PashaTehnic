using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TyriagaDoor : MonoBehaviour, IClickable
{
    [SerializeField] private RandomAnimation _randomAnim;
    [SerializeField] private bool _resetAnim;

    public void DoSomething()
    {
        if (_resetAnim)
            _randomAnim.ResetAnim();
        else
            _randomAnim.RandomAnim();
    }
}
