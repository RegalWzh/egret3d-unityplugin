using System;
using UnityEngine;
namespace Egret3DExportTools
{
    /**
     * 组件管理器接口
     */
    public interface IComponentParser
    {
        Type compType { set; get; }
        string className { set; get; }
        bool WriteToJson(GameObject _object, Component component, MyJson_Object compJson, MyJson_Object entityJson);
    }

    public abstract class ComponentParser : IComponentParser
    {
        protected Type _compType;
        protected string _className;
        public virtual bool WriteToJson(GameObject _object, Component component, MyJson_Object compJson, MyJson_Object entityJson)
        {
            return true;
        }

        public Type compType { get => _compType; set => _compType = value; }
        public string className { get => _className; set => _className = value; }
    }
}