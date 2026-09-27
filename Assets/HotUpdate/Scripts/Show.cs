using System.Collections;
using System.Collections.Generic;
using System.Resources;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class Show : MonoBehaviour
{
    Animator animator;
    async void Start()
    {
        animator = GetComponent<Animator>();
        await PlayAn();
    }
    async UniTask PlayAn()
    {
        while (true)
        {
            try
            {
                // 1. 确保当前处于 Idle 且不在过渡中
                await UniTask.WaitUntil(() =>
                animator.GetCurrentAnimatorStateInfo(0).IsName("Idle")
                && !animator.IsInTransition(0));

                // 2. 触发随机动画
                animator.SetInteger("Index", Random.Range(1, 7));

                // 3. 等待离开 Idle（动画开始播放）
                await UniTask.WaitUntil(() =>
                !animator.GetCurrentAnimatorStateInfo(0).IsName("Idle")
                || animator.IsInTransition(0));

                // 4. 等待动画播放完回到 Idle
                await UniTask.WaitUntil(() =>
                animator.GetCurrentAnimatorStateInfo(0).IsName("Idle")
                && !animator.IsInTransition(0));

                // 5. 重置 Index
                animator.SetInteger("Index", 0);

                // 6. 间隔 10 秒再播下一个
                await UniTask.Delay(10000);
            }
            catch
            {
                return;
            }
            
        }
    }
}
