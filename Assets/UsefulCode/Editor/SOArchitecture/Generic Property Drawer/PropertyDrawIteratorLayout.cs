﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace UsefulCode.SOArchitecture.Editor.Generic_Property_Drawer
{
    public class PropertyDrawIteratorLayout : BasePropertyDrawIterator
    {
        public PropertyDrawIteratorLayout(SerializedProperty property, bool drawLabel) : base(property, drawLabel)
        {
        }

        protected override void DrawPropertyWithLabel()
        {
            EditorGUILayout.PropertyField(iterator);
        }
        protected override void DrawProperty()
        {
            EditorGUILayout.PropertyField(iterator, GUIContent.none);
        }
    } 
}
