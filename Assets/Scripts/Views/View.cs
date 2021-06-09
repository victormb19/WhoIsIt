using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace WhoIsIt.Views
{
    [Serializable]
    abstract class View: MonoBehaviour
    {
        protected IViewVisitor viewVisitor;
        protected VisualElement visualElement;

        public void Initialize(IViewVisitor viewVisitor)
        {
            this.viewVisitor = viewVisitor;
            visualElement = GetComponent<UIDocument>().rootVisualElement;
            InitializeComponents();
        }

        protected abstract void InitializeComponents();

        public void EnableView()
        {
            visualElement.style.display = DisplayStyle.Flex;
        }

        public void DisableView()
        {
            visualElement.style.display = DisplayStyle.None;
        }
    }
}
