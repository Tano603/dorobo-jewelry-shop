using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door3 : MonoBehaviour
{
    //　ドアのアニメーター
    [SerializeField]
    //[Tooltip("自動ドアのアニメーター")]
    private Animator DoorAnimator3;

    /// <summary>
    /// 自動ドア検知エリアに入った時
    /// </summary>
    /// <param name="other"></param>
	private void OnTriggerEnter(Collider other)
    {
        // アニメーションパラメータをtrueにする。(ドアが開く)
        DoorAnimator3.SetBool("rightfrontdoor_Open", true);
    }

    /// <summary>
    /// 自動ドア検知エリアを出た時
    /// </summary>
    /// <param name="other"></param>
	private void OnTriggerExit(Collider other)
    {
        // アニメーションパラメータをfalseにする。(ドアが閉まる)
        DoorAnimator3.SetBool("rightfrontdoor_Open", false);
    }
}
