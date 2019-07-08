using UnityEngine;
using System;

namespace Egret3DExportTools
{
    public class SpotLightSerializer : DirectionalLightSerializer
    {
        protected override bool Match(Component component)
        {
            Light comp = component as Light;
            return comp.type == LightType.Spot;
        }
        protected override void Serialize(Component component, ComponentData compData)
        {
            Light comp = component as Light;
            base.Serialize(component, compData);
            compData.properties.SetNumber("distance", comp.range);
            compData.properties.SetNumber("angle", comp.spotAngle * Math.PI / 180.0f);
        }
    }
}
