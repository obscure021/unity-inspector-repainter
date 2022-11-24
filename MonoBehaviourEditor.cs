using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

[CustomEditor(typeof(MonoBehaviour), true)]
public class MonoBehaviourEditor : Editor
{
    public override VisualElement CreateInspectorGUI()
    {
        VisualElement container = new VisualElement();

        SerializedProperty property = serializedObject.GetIterator();
        property.Next(true);

        while (property.NextVisible(false))
        {
            PropertyField field = new PropertyField(property);
            field.SetEnabled(property.name != "m_Script");
            container.Add(field);
        }

        return container;
    }
}
