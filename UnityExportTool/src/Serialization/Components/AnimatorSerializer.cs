using System;
using UnityEngine;

namespace Egret3DExportTools
{
    public class AnimatorSerializer : AnimationSerializer
    {
        public override bool Match(Component component)
        {
            var aniamtior = component as Animator;
            if (aniamtior.runtimeAnimatorController == null)
            {
                MyLog.Log("缺少runtimeAnimatorController");
                return false;
            }
            var clips = aniamtior.runtimeAnimatorController.animationClips;
            if (clips == null || clips.Length == 0)
            {
                MyLog.Log("clips为空");
                return false;
            }

            return true;
        }
        public override void Serialize(Component component, ComponentData compData)
        {
            var aniamtior = component as Animator;
            var clips = aniamtior.runtimeAnimatorController.animationClips;
            compData.properties.SetBool("autoPlay", true); // TODO
            compData.SetAnimation(component.gameObject, clips);
        }
    }
}