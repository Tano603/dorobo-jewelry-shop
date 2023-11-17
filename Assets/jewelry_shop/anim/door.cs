using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door0 : MonoBehaviour
{
    //　ドアのアニメーター
    [SerializeField]
    //[Tooltip("自動ドアのアニメーター")]
    private Animator DoorAnimator0;

    /// <summary>
    /// 自動ドア検知エリアに入った時
    /// </summary>
    /// <param name="other"></param>
	private void OnTriggerEnter(Collider other)
    {
        // アニメーションパラメータをtrueにする。(ドアが開く)
        DoorAnimator0.SetBool("rightsidedoor_Open", true);
    }

    /// <summary>
    /// 自動ドア検知エリアを出た時
    /// </summary>
    /// <param name="other"></param>
	private void OnTriggerExit(Collider other)
    {
        // アニメーションパラメータをfalseにする。(ドアが閉まる)
        DoorAnimator0.SetBool("rightsidedoor_Open", false);
    }
}
