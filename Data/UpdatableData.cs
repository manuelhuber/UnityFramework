using System;
using UnityEditor;

namespace Grimity.Data {
public class UpdatableData : UnityEngine.ScriptableObject {
    public event Action OnValuesUpdated;
    public bool autoUpdate;

    public void Clear() {
        OnValuesUpdated = null;
    }

#if UNITY_EDITOR

    protected virtual void OnValidate() {
        if (autoUpdate) {
            EditorApplication.update += NotifyOfUpdatedValues;
        }
    }

    public void NotifyOfUpdatedValues() {
        EditorApplication.update -= NotifyOfUpdatedValues;
        if (OnValuesUpdated != null) {
            OnValuesUpdated();
        }
    }

#endif
}
}